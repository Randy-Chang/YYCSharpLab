// Libraries/YYControls/Controls/WaferMap/WaferMapControl.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YYControls.Controls.WaferMap
{
    /// <summary>
    /// Wafer Map（矩陣完整放入圓內，無圓形裁切）
    /// 功能：
    /// - 讀取 map.csv（矩陣）
    /// - 以「對角線內切」計算 cellSize：整個 rows x cols 矩形完全置入晶圓圓內
    /// - 滾輪縮放（以滑鼠位置為中心），縮小下限＝Fit（zoom=1）
    /// - 平移：中鍵拖曳，或開啟「拖曳」模式後用左鍵拖曳（Fit 時禁拖）
    /// - 拖曳「卡極限」：依目前縮放自動夾在合法範圍，不會亂飛
    /// - 左上角工具列：Fit / 拖曳切換 / 放大 / 縮小（支援 Icon, 可關閉文字）
    /// </summary>
    [DesignerCategory("Code")]
    public class WaferMapControl : UserControl
    {
        // ===== 內部資料 =====
        private string[,] _grid = new string[0, 0];
        private int _rows = 0;
        private int _cols = 0;

        // ===== 視圖狀態（縮放/平移） =====
        private float _zoom = 1.0f;              // 目前縮放（Fit = 1）
        private float _panX = 0f, _panY = 0f;    // 目前平移（作用於圓的外接正方形座標系）
        private const float MaxZoom = 12f;
        private const float ZoomStep = 1.1f;     // 每次放大/縮小倍率（±10%）

        // 中鍵/左鍵平移狀態
        private bool _isPanning = false;
        private Point _panStartPoint;
        private float _panStartX, _panStartY;
        private bool _panMode = false;           // 打開時，左鍵拖曳也可平移（Fit 時仍禁拖）

        // ===== 外觀設定 =====
        [Browsable(true), DefaultValue(true), Category("Appearance")]
        public bool ShowCellText { get; set; } = true;

        [Browsable(true), DefaultValue(true), Category("Appearance")]
        public bool ShowGridLines { get; set; } = true;

        [Browsable(true), DefaultValue(8), Category("Layout")]
        public int OuterPadding { get; set; } = 8;

        [Browsable(true), DefaultValue(1), Category("Layout")]
        public int CellGap { get; set; } = 1;

        [Browsable(true), Category("Appearance")]
        public Font CellFont { get; set; } = new Font("Consolas", 8f, FontStyle.Regular);

        [Browsable(false)]
        public Dictionary<string, DieStatus> StatusByKey { get; private set; } =
            new Dictionary<string, DieStatus>(StringComparer.OrdinalIgnoreCase);

        // 顏色
        [Browsable(false)] public Color WaferEdgeColor { get; set; } = Color.Gray;
        [Browsable(false)] public Color CellLineColor { get; set; } = Color.FromArgb(180, 200, 200, 200);
        [Browsable(false)] public Color CellFillUnknown { get; set; } = Color.FromArgb(240, 240, 240);
        [Browsable(false)] public Color CellFillPass { get; set; } = Color.FromArgb(200, 240, 200);
        [Browsable(false)] public Color CellFillNg { get; set; } = Color.FromArgb(245, 200, 200);

        // ========== 工具列（左上角） ==========
        private FlowLayoutPanel _toolbar;
        private Button _btnFit, _btnPan, _btnZoomIn, _btnZoomOut;
        private Color _btnPanDefaultBack;

        [Category("Toolbar"), DefaultValue(true)]
        public bool ShowToolbar
        {
            get => _toolbar?.Visible ?? true;
            set { if (_toolbar != null) _toolbar.Visible = value; }
        }

        [Category("Toolbar"), DefaultValue(true)]
        public bool ToolbarShowText
        {
            get => _toolbarShowText;
            set { _toolbarShowText = value; ApplyToolbarVisual(); }
        }
        private bool _toolbarShowText = false;

        private Image   _fitIconRaw, 
                        _panIconRaw = Properties.Resources.PanIcon_1, 
                        _zoomInIconRaw, 
                        _zoomOutIconRaw;

        private Image _fitIconScaled, _panIconScaled, _zoomInIconScaled, _zoomOutIconScaled;

        // 統一的按鈕邊長（正方形）；與圖示邊長
        [Category("Toolbar"), DefaultValue(32)]
        public int ToolbarButtonSize
        {
            get => _toolbarButtonSize;
            set { _toolbarButtonSize = Math.Max(24, Math.Min(80, value)); UpdateScaledIcons(); ApplyToolbarVisual(); }
        }
        private int _toolbarButtonSize = 36;

        [Category("Toolbar"), DefaultValue(20)]
        public int ToolbarIconSize
        {
            get => _toolbarIconSize;
            set { _toolbarIconSize = Math.Max(12, Math.Min(64, value)); UpdateScaledIcons(); ApplyToolbarVisual(); }
        }
        private int _toolbarIconSize = 20;

        // Icon 屬性：設定就刷新
        [Category("Toolbar")]
        public Image FitIcon { get => _fitIconRaw; set { _fitIconRaw = value; UpdateScaledIcons(); ApplyToolbarVisual(); } }
        [Category("Toolbar")]
        public Image PanIcon { get => _panIconRaw; set { _panIconRaw = value; UpdateScaledIcons(); ApplyToolbarVisual(); } }
        [Category("Toolbar")]
        public Image ZoomInIcon { get => _zoomInIconRaw; set { _zoomInIconRaw = value; UpdateScaledIcons(); ApplyToolbarVisual(); } }
        [Category("Toolbar")]
        public Image ZoomOutIcon { get => _zoomOutIconRaw; set { _zoomOutIconRaw = value; UpdateScaledIcons(); ApplyToolbarVisual(); } }


        // 事件
        public event EventHandler<DieClickedEventArgs> DieClicked;

        [Browsable(true), DefaultValue(true), Category("Behavior")]
        public new bool TabStop
        {
            get => base.TabStop;
            set => base.TabStop = value;
        }

        public WaferMapControl()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.Selectable, true);

            BackColor = Color.White;
            base.TabStop = true;

            BuildToolbar();
        }

        #region Public API

        public void LoadMapCsv(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                throw new FileNotFoundException("map.csv not found.", path);

            string[] lines = ReadAllLinesWithEncodings(path,
                new[] { "utf-8-sig", "utf-8", "cp950", "big5", "latin1" });

            ParseMatrix(lines);
            ResetView();
        }

        public void SetGrid(string[,] grid)
        {
            if (grid == null) throw new ArgumentNullException(nameof(grid));
            _grid = grid;
            _rows = grid.GetLength(0);
            _cols = grid.GetLength(1);
            ResetView();
        }

        public void SetStatus(Dictionary<string, DieStatus> statusByKey)
        {
            StatusByKey = statusByKey ?? new Dictionary<string, DieStatus>(StringComparer.OrdinalIgnoreCase);
            Invalidate();
        }

        [Browsable(false)]
        public float Zoom => _zoom;

        /// <summary>重置視圖（回到 Fit：zoom=1, pan=0）。</summary>
        public void ResetView()
        {
            _zoom = 1f;
            _panX = _panY = 0f;
            Invalidate();
        }

        public int RowCount => _rows;
        public int ColCount => _cols;

        #endregion

        #region CSV parsing helpers

        private static string[] ReadAllLinesWithEncodings(string path, string[] encs)
        {
            foreach (var encName in encs)
            {
                try
                {
                    var enc = Encoding.GetEncoding(encName);
                    var lines = File.ReadAllLines(path, enc);
                    if (lines.Length > 0) return lines;
                }
                catch { /* try next */ }
            }
            return File.ReadAllLines(path, Encoding.UTF8);
        }

        private static string[] SplitFlexible(string line)
        {
            if (line.IndexOf('\t') >= 0) return line.Split('\t');
            if (line.IndexOf(';') >= 0) return line.Split(';');
            return line.Split(',');
        }

        private void ParseMatrix(string[] lines)
        {
            var rows = new List<string[]>();
            int maxCols = 0;

            foreach (var raw in lines)
            {
                if (string.IsNullOrWhiteSpace(raw)) continue;
                var arr = SplitFlexible(raw).Select(s => (s ?? string.Empty).Trim()).ToArray();
                rows.Add(arr);
                if (arr.Length > maxCols) maxCols = arr.Length;
            }

            _rows = rows.Count;
            _cols = Math.Max(0, maxCols);
            if (_rows == 0 || _cols == 0)
            {
                _grid = new string[0, 0];
                return;
            }

            _grid = new string[_rows, _cols];

            for (int r = 0; r < _rows; r++)
            {
                var arr = rows[r];
                for (int c = 0; c < _cols; c++)
                {
                    string token = (c < arr.Length) ? (arr[c] ?? "") : "";
                    if (string.IsNullOrWhiteSpace(token) ||
                        token == "-" ||
                        token.Equals("NULL", StringComparison.OrdinalIgnoreCase))
                    {
                        token = "";
                    }
                    _grid[r, c] = token;
                }
            }
        }

        #endregion

        #region Layout helpers（對角線內切，把矩形完整放入圓內）

        private bool TryGetLayout(out Rectangle waferRect, out RectangleF gridRect, out float cellSize)
        {
            waferRect = Rectangle.Empty;
            gridRect = RectangleF.Empty;
            cellSize = 0;

            if (_rows <= 0 || _cols <= 0) return false;

            var client = ClientSize;
            int pad = Math.Max(0, OuterPadding);

            // 圓的外接正方形基準邊長（zoom=1）
            int baseSize = Math.Max(0, Math.Min(client.Width, client.Height) - pad * 2);
            if (baseSize <= 0) return false;

            // 依縮放後的新尺寸 & 左上角（含平移）
            float sizeZ = baseSize * _zoom;
            int originX = (int)Math.Round((client.Width - sizeZ) / 2f + _panX);
            int originY = (int)Math.Round((client.Height - sizeZ) / 2f + _panY);

            waferRect = new Rectangle(originX, originY, (int)Math.Round(sizeZ), (int)Math.Round(sizeZ));

            // 對角線內切：讓矩形對角線 <= 圓直徑 sizeZ
            double denom = Math.Sqrt((double)_cols * _cols + (double)_rows * _rows);
            cellSize = (float)(sizeZ / (denom > 0 ? denom : 1.0));

            float gridWidth = cellSize * _cols;
            float gridHeight = cellSize * _rows;

            float gridX = waferRect.Left + (sizeZ - gridWidth) / 2f;
            float gridY = waferRect.Top + (sizeZ - gridHeight) / 2f;

            gridRect = new RectangleF(gridX, gridY, gridWidth, gridHeight);
            return true;
        }

        #endregion

        #region Painting

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(BackColor);

            if (!TryGetLayout(out var waferRect, out var gridRect, out float cellSize))
                return;

            // 畫晶圓外框（參考用）
            using (var waferPen = new Pen(WaferEdgeColor, 2))
            {
                e.Graphics.DrawEllipse(waferPen, waferRect);
            }

            using (var linePen = new Pen(CellLineColor, 1f))
            using (var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            })
            {
                for (int r = 0; r < _rows; r++)
                {
                    for (int c = 0; c < _cols; c++)
                    {
                        float x = gridRect.Left + c * cellSize;
                        float y = gridRect.Top + r * cellSize;
                        float gap = Math.Max(0, CellGap);
                        RectangleF cellRect = new RectangleF(x + gap, y + gap, cellSize - gap * 2, cellSize - gap * 2);

                        string token = _grid[r, c];
                        bool hasDie = !string.IsNullOrEmpty(token);

                        if (!hasDie)
                        {
                            if (ShowGridLines)
                                e.Graphics.DrawRectangle(linePen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                            continue;
                        }

                        // 著色（Unknown / Pass / NG）
                        Color fill = CellFillUnknown;
                        if (StatusByKey.TryGetValue(token, out var status))
                        {
                            if (status == DieStatus.Pass) fill = CellFillPass;
                            else if (status == DieStatus.Ng) fill = CellFillNg;
                        }

                        using (var brush = new SolidBrush(fill))
                            e.Graphics.FillRectangle(brush, cellRect);

                        if (ShowGridLines)
                            e.Graphics.DrawRectangle(linePen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                        if (ShowCellText && CellFont != null)
                        {
                            using (var textBrush = new SolidBrush(Color.Black))
                                e.Graphics.DrawString(token, CellFont, textBrush, cellRect, sf);
                        }
                    }
                }
            }
        }

        #endregion

        #region 互動（滾輪縮放 + 中鍵/左鍵平移 + 點擊）

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (CanSelect) this.Focus();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            bool wantPan = (e.Button == MouseButtons.Middle) ||
                           (e.Button == MouseButtons.Left && _panMode);

            // Fit（zoom=1）時禁拖曳
            if (wantPan && _zoom > 1f)
            {
                _isPanning = true;
                _panStartPoint = e.Location;
                _panStartX = _panX;
                _panStartY = _panY;
                Cursor = Cursors.Hand;
                Capture = true;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_isPanning)
            {
                _panX = _panStartX + (e.X - _panStartPoint.X);
                _panY = _panStartY + (e.Y - _panStartPoint.Y);
                ClampPan();               // ← 卡極限
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (_isPanning && (e.Button == MouseButtons.Middle || e.Button == MouseButtons.Left))
            {
                _isPanning = false;
                Cursor = _panMode ? Cursors.Hand : Cursors.Default;
                Capture = false;
            }
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            if (_rows <= 0 || _cols <= 0) return;

            float factor = e.Delta > 0 ? ZoomStep : 1f / ZoomStep;
            ZoomAt(new PointF(e.X, e.Y), factor, clampToFitMin: true);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (_isPanning) return; // 拖曳中不觸發點擊

            if (!TryGetLayout(out _, out var gridRect, out float cellSize))
                return;

            if (!gridRect.Contains(e.Location)) return;

            int col = (int)Math.Floor((e.X - gridRect.Left) / cellSize);
            int row = (int)Math.Floor((e.Y - gridRect.Top) / cellSize);
            if (row < 0 || row >= _rows || col < 0 || col >= _cols) return;

            string token = _grid[row, col];
            if (!string.IsNullOrEmpty(token))
                DieClicked?.Invoke(this, new DieClickedEventArgs(row, col, token));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            PositionToolbar();
            ClampPan(); // 視窗尺寸改變時也卡一次
            Invalidate();
        }

        #endregion

        #region Zoom & Pan helpers

        /// <summary>
        /// 以指定的「螢幕座標點」為錨點縮放；clampToFitMin=true 時，縮小下限為 Fit（zoom=1，並自動置中）。
        /// </summary>
        private void ZoomAt(PointF anchorClient, float factor, bool clampToFitMin)
        {
            var client = ClientSize;
            int pad = Math.Max(0, OuterPadding);
            int baseSize = Math.Max(0, Math.Min(client.Width, client.Height) - pad * 2);
            if (baseSize <= 0) return;

            float oldZoom = _zoom;
            float newZoom = oldZoom * factor;
            if (newZoom > MaxZoom) newZoom = MaxZoom;

            if (clampToFitMin && newZoom < 1f)
                newZoom = 1f;

            float sizeOld = baseSize * oldZoom;
            float sizeNew = baseSize * newZoom;

            float originOldX = (client.Width - sizeOld) / 2f + _panX;
            float originOldY = (client.Height - sizeOld) / 2f + _panY;

            float qx = (anchorClient.X - originOldX) / sizeOld;
            float qy = (anchorClient.Y - originOldY) / sizeOld;

            // 更新 zoom
            _zoom = newZoom;

            if (Math.Abs(newZoom - 1f) < 1e-6f && clampToFitMin)
            {
                // 回到 Fit：置中 & 清空平移
                _panX = _panY = 0f;
            }
            else
            {
                float originNewX = anchorClient.X - qx * sizeNew;
                float originNewY = anchorClient.Y - qy * sizeNew;

                _panX = originNewX - (client.Width - sizeNew) / 2f;
                _panY = originNewY - (client.Height - sizeNew) / 2f;

                ClampPan();
            }

            Invalidate();
        }

        /// <summary>
        /// 根據目前縮放，將平移量限制在合法範圍（Fit/zoom<=1 時固定為 0,0）。
        /// 規則：若縮放後的圓外接正方形 sizeZ 比視窗還小，該方向不能拖曳；若比視窗大，允許在一半差距內平移。
        /// </summary>
        private void ClampPan()
        {
            var client = ClientSize;
            int pad = Math.Max(0, OuterPadding);
            int baseSize = Math.Max(0, Math.Min(client.Width, client.Height) - pad * 2);
            if (baseSize <= 0) { _panX = _panY = 0f; return; }

            if (_zoom <= 1f + 1e-6f)
            {
                _zoom = 1f;
                _panX = _panY = 0f;
                return;
            }

            float sizeZ = baseSize * _zoom;

            // 水平：如果 sizeZ <= client.Width，不允許水平拖曳（固定 0）
            if (sizeZ <= client.Width)
            {
                _panX = 0f;
            }
            else
            {
                float halfFreeX = (sizeZ - client.Width) / 2f;
                if (_panX < -halfFreeX) _panX = -halfFreeX;
                if (_panX > +halfFreeX) _panX = +halfFreeX;
            }

            // 垂直：同理
            if (sizeZ <= client.Height)
            {
                _panY = 0f;
            }
            else
            {
                float halfFreeY = (sizeZ - client.Height) / 2f;
                if (_panY < -halfFreeY) _panY = -halfFreeY;
                if (_panY > +halfFreeY) _panY = +halfFreeY;
            }
        }

        #endregion

        #region Toolbar（左上角小按鈕 + Icon 支援）

        private void BuildToolbar()
        {
            _toolbar = new FlowLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                BackColor = SystemColors.Window,
                Margin = new Padding(0),
                Padding = new Padding(4, 4, 4, 4),
            };

            _btnFit = NewBtn("Fit", (s, e) => ResetView());
            _btnPan = NewBtn("拖曳", (s, e) => TogglePanMode());
            _btnZoomIn = NewBtn("＋", (s, e) => ZoomAt(CenterPoint(), ZoomStep, true));
            _btnZoomOut = NewBtn("－", (s, e) => ZoomAt(CenterPoint(), 1f / ZoomStep, true));

            _toolbar.Controls.AddRange(new Control[] { _btnFit, _btnPan, _btnZoomIn, _btnZoomOut });
            Controls.Add(_toolbar);
            _toolbar.BringToFront();

            _btnPanDefaultBack = _btnPan.BackColor;

            ApplyToolbarVisual();
            PositionToolbar();
        }

        private Button NewBtn(string text, EventHandler onClick)
        {
            var b = new Button
            {
                AutoSize = false,                         // 固定尺寸
                //FlatStyle = FlatStyle.Standard,
                UseVisualStyleBackColor = false,
                Margin = new Padding(2),
                Text = text,
                TabStop = false,
                ImageAlign = ContentAlignment.MiddleCenter,
                TextAlign = ContentAlignment.MiddleCenter,
                TextImageRelation = TextImageRelation.Overlay,
                Size = new Size(_toolbarButtonSize, _toolbarButtonSize),   // 固定邊長
                MinimumSize = new Size(_toolbarButtonSize, _toolbarButtonSize),
                MaximumSize = new Size(_toolbarButtonSize, _toolbarButtonSize),
                Padding = Padding.Empty,

                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            b.Click += onClick;
            return b;
        }



        private void TogglePanMode()
        {
            _panMode = !_panMode;
            Cursor = _panMode ? Cursors.Hand : Cursors.Default;

            // 視覺提示：啟用時反白
            _btnPan.BackColor = _panMode ? Color.SteelBlue : _btnPanDefaultBack;
            _btnPan.ForeColor = _panMode ? Color.White : SystemColors.ControlText;
        }

        private void ApplyToolbarVisual()
        {
            // 先確保縮圖已計算
            if ((_fitIconScaled == null && _fitIconRaw != null) ||
                (_panIconScaled == null && _panIconRaw != null) ||
                (_zoomInIconScaled == null && _zoomInIconRaw != null) ||
                (_zoomOutIconScaled == null && _zoomOutIconRaw != null))
            {
                UpdateScaledIcons();
            }

            ApplyButtonVisual(_btnFit, _fitIconScaled, "Fit");
            ApplyButtonVisual(_btnPan, _panIconScaled, "拖曳");
            ApplyButtonVisual(_btnZoomIn, _zoomInIconScaled, "＋");
            ApplyButtonVisual(_btnZoomOut, _zoomOutIconScaled, "－");

            // 重申固定尺寸（避免 DPI 或外部修改）
            foreach (var b in new[] { _btnFit, _btnPan, _btnZoomIn, _btnZoomOut })
            {
                b.Size = new Size(_toolbarButtonSize, _toolbarButtonSize);
                b.MinimumSize = b.MaximumSize = b.Size;
            }
        }

        private void ApplyButtonVisual(Button b, Image icon, string textWhenNoIcon)
        {
            b.Image = icon;
            if (icon != null)
            {
                // 有圖 → 顯圖、不顯字；用 ToolTip 補語意
                b.Text = string.Empty;
                EnsureToolTip().SetToolTip(b, textWhenNoIcon);
            }
            else
            {
                // 沒圖 → 顯字
                b.Text = textWhenNoIcon;
                EnsureToolTip().SetToolTip(b, null);
            }
            b.ImageAlign = ContentAlignment.MiddleCenter;
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.TextImageRelation = TextImageRelation.Overlay;
        }

        private ToolTip _tt;
        private ToolTip EnsureToolTip()
        {
            if (_tt == null)
            {
                _tt = new ToolTip { AutomaticDelay = 300 };
            }
            return _tt;
        }


        private void UpdateScaledIcons()
        {
            // 先清掉舊的 scaled 以免記憶體累積
            _fitIconScaled?.Dispose(); _fitIconScaled = null;
            _panIconScaled?.Dispose(); _panIconScaled = null;
            _zoomInIconScaled?.Dispose(); _zoomInIconScaled = null;
            _zoomOutIconScaled?.Dispose(); _zoomOutIconScaled = null;

            var sz = new Size(_toolbarIconSize, _toolbarIconSize);
            _fitIconScaled = ScaleImageKeepAspect(_fitIconRaw, sz);
            _panIconScaled = ScaleImageKeepAspect(_panIconRaw, sz);
            _zoomInIconScaled = ScaleImageKeepAspect(_zoomInIconRaw, sz);
            _zoomOutIconScaled = ScaleImageKeepAspect(_zoomOutIconRaw, sz);
        }

        private static Image ScaleImageKeepAspect(Image src, Size target)
        {
            if (src == null) return null;
            var bmp = new Bitmap(target.Width, target.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                // 等比例縮放置中
                var fit = GetFitRect(src.Width, src.Height, target.Width, target.Height);
                g.DrawImage(src, fit);
            }
            return bmp;
        }

        private static Rectangle GetFitRect(int w, int h, int W, int H)
        {
            if (w <= 0 || h <= 0 || W <= 0 || H <= 0) return new Rectangle(0, 0, W, H);
            double scale = Math.Min((double)W / w, (double)H / h);
            int nw = Math.Max(1, (int)Math.Round(w * scale));
            int nh = Math.Max(1, (int)Math.Round(h * scale));
            int x = (W - nw) / 2;
            int y = (H - nh) / 2;
            return new Rectangle(x, y, nw, nh);
        }


        private void PositionToolbar()
        {
            if (_toolbar == null) return;
            _toolbar.Location = new Point(OuterPadding + 6, OuterPadding + 6);
        }

        private PointF CenterPoint() => new PointF(ClientSize.Width / 2f, ClientSize.Height / 2f);

        #endregion
    }
}
