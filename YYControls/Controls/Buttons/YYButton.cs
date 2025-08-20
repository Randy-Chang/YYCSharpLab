using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;

namespace YYControls.Controls.Buttons
{
    /// <summary>
    /// 自訂樣式的 WinForms 按鈕（.NET Framework 4.8）
    /// - 支援圓角、邊框、漸層背景
    /// - 支援 Hover / Pressed / Disabled 狀態色
    /// - 支援文字/圖片排版與 TextImageRelation
    /// - 支援半透明背景與父層背景變更重繪
    /// </summary>
    [DesignerCategory("Code")]
    public class YYButton : Button
    {
        #region === Fields ===

        private int _borderSize = 1;
        private int _borderRadius = 12;
        private Color _borderColor = Color.PaleVioletRed;

        private bool _hovered = false;
        private bool _pressed = false;

        private Color _backColorNormal = Color.MediumSlateBlue;
        private Color _backColorHover = Color.FromArgb(0x6C, 0x8E, 0xFA);
        private Color _backColorPressed = Color.FromArgb(0x58, 0x76, 0xD6);
        private Color _backColorDisabled = Color.Gray;

        private Color _textColorDisabled = Color.FromArgb(180, 255, 255, 255);

        private bool _useGradient = false;
        private float _gradientAngle = 90f;

        #endregion

        #region === Public Properties ===

        /// <summary>外框粗細（像素）。</summary>
        [Category("YY Button"), Description("外框粗細（像素）"), DefaultValue(1)]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = Math.Max(0, value); Invalidate(); }
        }

        /// <summary>圓角半徑（像素）。</summary>
        [Category("YY Button"), Description("圓角半徑（像素）"), DefaultValue(12)]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = Math.Max(0, value); Invalidate(); }
        }

        /// <summary>外框顏色。</summary>
        [Category("YY Button"), Description("外框顏色")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        /// <summary>一般狀態背景色。</summary>
        [Category("YY Button"), Description("一般背景色")]
        public Color BackColorNormal
        {
            get => _backColorNormal;
            set { _backColorNormal = value; Invalidate(); }
        }

        /// <summary>滑過（Hover）背景色。</summary>
        [Category("YY Button"), Description("滑過背景色")]
        public Color BackColorHover
        {
            get => _backColorHover;
            set { _backColorHover = value; Invalidate(); }
        }

        /// <summary>按下（Pressed）背景色。</summary>
        [Category("YY Button"), Description("按下背景色")]
        public Color BackColorPressed
        {
            get => _backColorPressed;
            set { _backColorPressed = value; Invalidate(); }
        }

        /// <summary>停用（Disabled）背景色。</summary>
        [Category("YY Button"), Description("停用背景色")]
        public Color BackColorDisabled
        {
            get => _backColorDisabled;
            set { _backColorDisabled = value; Invalidate(); }
        }

        /// <summary>啟用漸層背景。</summary>
        [Category("YY Button"), Description("啟用漸層背景"), DefaultValue(false)]
        public bool UseGradient
        {
            get => _useGradient;
            set { _useGradient = value; Invalidate(); }
        }

        /// <summary>漸層角度（度）。</summary>
        [Category("YY Button"), Description("漸層角度（度）"), DefaultValue(90f)]
        public float GradientAngle
        {
            get => _gradientAngle;
            set { _gradientAngle = value; Invalidate(); }
        }

        /// <summary>背景色別名（同步 BackColor）。</summary>
        [Category("YY Button"), Description("背景色別名（同步 BackColor）")]
        public Color BackgroundColor
        {
            get => this.BackColor;
            set { this.BackColor = value; Invalidate(); }
        }

        /// <summary>文字色別名（同步 ForeColor）。</summary>
        [Category("YY Button"), Description("文字色別名（同步 ForeColor）")]
        public Color TextColor
        {
            get => this.ForeColor;
            set { this.ForeColor = value; Invalidate(); }
        }

        #endregion

        #region === Constructor / Dispose ===

        /// <summary>
        /// 建構式：初始化樣式、預設尺寸、滑鼠事件與 Enabled 變更重繪。
        /// </summary>
        public YYButton()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            Size = new Size(150, 40);
            BackColor = _backColorNormal;
            ForeColor = Color.White;
            Cursor = Cursors.Hand;

            MouseEnter += (s, e) => { _hovered = true; Invalidate(); };
            MouseLeave += (s, e) => { _hovered = false; _pressed = false; Invalidate(); };
            MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) { _pressed = true; Invalidate(); } };
            MouseUp += (s, e) => { _pressed = false; Invalidate(); };

            EnabledChanged += (s, e) => Invalidate();
        }

        /// <inheritdoc/>
        protected override void Dispose(bool disposing)
        {
            if (disposing && Parent != null)
            {
                Parent.BackColorChanged -= Parent_BackColorChanged;
            }
            base.Dispose(disposing);
        }

        #endregion

        #region === Parent / Background Handling ===

        /// <summary>
        /// 父容器變更時重新訂閱父容器的 BackColorChanged，以確保透明背景時能正確重繪。
        /// </summary>
        protected override void OnParentChanged(EventArgs e)
        {
            if (Parent != null)
            {
                Parent.BackColorChanged -= Parent_BackColorChanged;
            }

            base.OnParentChanged(e);

            if (Parent != null)
            {
                Parent.BackColorChanged += Parent_BackColorChanged;
            }

            Invalidate();
        }

        private void Parent_BackColorChanged(object sender, EventArgs e) => Invalidate();

        /// <summary>
        /// 支援半透明背景：如果自身有透明度，先讓父容器幫忙繪底，再繪製自身。
        /// </summary>
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (BackColor.A < 255 && Parent != null)
            {
                var g = pevent.Graphics;
                var state = g.Save();
                try
                {
                    g.TranslateTransform(-Left, -Top);
                    var pea = new PaintEventArgs(g, Parent.DisplayRectangle);
                    InvokePaintBackground(Parent, pea);
                    InvokePaint(Parent, pea);
                }
                finally
                {
                    g.Restore(state);
                }
            }
            else
            {
                base.OnPaintBackground(pevent);
            }
        }

        #endregion

        #region === Painting ===

        /// <summary>
        /// 核心繪製流程：背景（含圓角/邊框/漸層）＋ 內容（圖/文）。
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            var rect = ClientRectangle;
            if (rect.Width <= 0 || rect.Height <= 0) return;

            int border = _borderSize;
            float radius = _borderRadius;

            var rectBorder = RectangleF.Inflate(RectangleF.Empty, 0, 0); // 初始化避免警告
            rectBorder = RectangleF.Inflate(rect, -border * 0.5f, -border * 0.5f);

            using (var path = RoundedRect(rect, radius))
            using (var region = new Region(path))
            {
                // 設定剪裁區域：避免邊角以外的像素被填滿
                Region = region.Clone();

                // 背景（單色或漸層）
                Color baseColor = CurrentBackColor();
                using (Brush b = _useGradient
                    ? (Brush)new LinearGradientBrush(rect, baseColor, ControlPaint.Light(baseColor, 0.15f), _gradientAngle)
                    : (Brush)new SolidBrush(baseColor))
                {
                    g.FillPath(b, path);
                }

                // 邊框
                if (border > 0)
                {
                    using (var borderPath = RoundedRect(rectBorder, Math.Max(0, radius - border * 0.5f)))
                    using (var pen = new Pen(_borderColor, border) { Alignment = PenAlignment.Center })
                    {
                        g.DrawPath(pen, borderPath);
                    }
                }
            }

            DrawContent(g);
        }

        /// <summary>
        /// 依目前狀態（Normal / Hover / Pressed / Disabled）回傳背景色。
        /// </summary>
        private Color CurrentBackColor()
        {
            if (!Enabled) return _backColorDisabled;
            if (_pressed) return _backColorPressed;
            if (_hovered) return _backColorHover;
            return _backColorNormal;
        }

        /// <summary>
        /// 繪製圖文內容（依 TextImageRelation 與對齊設定分配區域）。
        /// </summary>
        private void DrawContent(Graphics g)
        {
            Rectangle contentRect = Rectangle.Inflate(ClientRectangle, -4, -2);

            var img = Image;
            var text = Text ?? string.Empty;
            var textColor = Enabled ? ForeColor : _textColorDisabled;

            // 計算圖片矩形
            Rectangle imageRect = Rectangle.Empty;
            if (img != null)
            {
                imageRect.Size = img.Size;
                imageRect = AlignWithin(contentRect, imageRect.Size, ImageAlign);
            }

            // 計算文字尺寸與矩形
            Size textSize;
            using (var tmp = new Bitmap(1, 1))
            using (var gTmp = Graphics.FromImage(tmp))
            {
                textSize = Size.Ceiling(gTmp.MeasureString(text, Font));
            }

            Rectangle textRect = new Rectangle(Point.Empty, textSize);
            textRect = AlignWithin(contentRect, textRect.Size, TextAlign);

            // 根據 TextImageRelation 調整圖文相對位置
            switch (TextImageRelation)
            {
                case TextImageRelation.ImageBeforeText:
                    if (!imageRect.IsEmpty)
                    {
                        imageRect = new Rectangle(
                            contentRect.Left,
                            AlignMiddleY(contentRect, imageRect.Height),
                            imageRect.Width, imageRect.Height);

                        textRect = new Rectangle(
                            imageRect.Right + Padding.Left,
                            AlignMiddleY(contentRect, textRect.Height),
                            Math.Min(contentRect.Right - imageRect.Right - Padding.Horizontal, textRect.Width),
                            textRect.Height);
                    }
                    break;

                case TextImageRelation.TextBeforeImage:
                    if (!imageRect.IsEmpty)
                    {
                        textRect = new Rectangle(
                            contentRect.Left,
                            AlignMiddleY(contentRect, textRect.Height),
                            Math.Min(contentRect.Width - imageRect.Width - Padding.Horizontal, textRect.Width),
                            textRect.Height);

                        imageRect = new Rectangle(
                            textRect.Right + Padding.Right,
                            AlignMiddleY(contentRect, imageRect.Height),
                            imageRect.Width, imageRect.Height);
                    }
                    break;

                case TextImageRelation.ImageAboveText:
                    if (!imageRect.IsEmpty)
                    {
                        imageRect = new Rectangle(
                            AlignMiddleX(contentRect, imageRect.Width),
                            contentRect.Top,
                            imageRect.Width, imageRect.Height);

                        textRect = new Rectangle(
                            AlignMiddleX(contentRect, textRect.Width),
                            imageRect.Bottom + Padding.Top,
                            textRect.Width, textRect.Height);
                    }
                    break;

                case TextImageRelation.TextAboveImage:
                    if (!imageRect.IsEmpty)
                    {
                        textRect = new Rectangle(
                            AlignMiddleX(contentRect, textRect.Width),
                            contentRect.Top,
                            textRect.Width, textRect.Height);

                        imageRect = new Rectangle(
                            AlignMiddleX(contentRect, imageRect.Width),
                            textRect.Bottom + Padding.Top,
                            imageRect.Width, imageRect.Height);
                    }
                    break;

                case TextImageRelation.Overlay:
                default:
                    // 不調整，使用 AlignWithin 結果
                    break;
            }

            // 繪圖
            if (img != null)
            {
                if (Enabled)
                    g.DrawImage(img, imageRect);
                else
                    ControlPaint.DrawImageDisabled(g, img, imageRect.X, imageRect.Y, Color.Transparent);
            }

            using (var sf = GetStringFormat(TextAlign))
            using (var brush = new SolidBrush(textColor))
            {
                g.DrawString(text, Font, brush, textRect, sf);
            }
        }

        #endregion

        #region === Layout Helpers ===

        /// <summary>回傳文字的 StringFormat（水平/垂直對齊）。</summary>
        private static StringFormat GetStringFormat(ContentAlignment align)
        {
            var sf = new StringFormat(StringFormatFlags.NoWrap);
            switch (align)
            {
                case ContentAlignment.TopLeft: sf.Alignment = StringAlignment.Near; sf.LineAlignment = StringAlignment.Near; break;
                case ContentAlignment.TopCenter: sf.Alignment = StringAlignment.Center; sf.LineAlignment = StringAlignment.Near; break;
                case ContentAlignment.TopRight: sf.Alignment = StringAlignment.Far; sf.LineAlignment = StringAlignment.Near; break;
                case ContentAlignment.MiddleLeft: sf.Alignment = StringAlignment.Near; sf.LineAlignment = StringAlignment.Center; break;
                case ContentAlignment.MiddleCenter: sf.Alignment = StringAlignment.Center; sf.LineAlignment = StringAlignment.Center; break;
                case ContentAlignment.MiddleRight: sf.Alignment = StringAlignment.Far; sf.LineAlignment = StringAlignment.Center; break;
                case ContentAlignment.BottomLeft: sf.Alignment = StringAlignment.Near; sf.LineAlignment = StringAlignment.Far; break;
                case ContentAlignment.BottomCenter: sf.Alignment = StringAlignment.Center; sf.LineAlignment = StringAlignment.Far; break;
                case ContentAlignment.BottomRight: sf.Alignment = StringAlignment.Far; sf.LineAlignment = StringAlignment.Far; break;
            }
            return sf;
        }

        /// <summary>將指定大小的內容對齊到外框矩形中的某個 <see cref="ContentAlignment"/> 位置。</summary>
        private static Rectangle AlignWithin(Rectangle outer, Size inner, ContentAlignment align)
        {
            int x = outer.Left, y = outer.Top;
            switch (align)
            {
                case ContentAlignment.TopLeft: x = outer.Left; y = outer.Top; break;
                case ContentAlignment.TopCenter: x = AlignMiddleX(outer, inner.Width); y = outer.Top; break;
                case ContentAlignment.TopRight: x = outer.Right - inner.Width; y = outer.Top; break;
                case ContentAlignment.MiddleLeft: x = outer.Left; y = AlignMiddleY(outer, inner.Height); break;
                case ContentAlignment.MiddleCenter: x = AlignMiddleX(outer, inner.Width); y = AlignMiddleY(outer, inner.Height); break;
                case ContentAlignment.MiddleRight: x = outer.Right - inner.Width; y = AlignMiddleY(outer, inner.Height); break;
                case ContentAlignment.BottomLeft: x = outer.Left; y = outer.Bottom - inner.Height; break;
                case ContentAlignment.BottomCenter: x = AlignMiddleX(outer, inner.Width); y = outer.Bottom - inner.Height; break;
                case ContentAlignment.BottomRight: x = outer.Right - inner.Width; y = outer.Bottom - inner.Height; break;
            }
            return new Rectangle(new Point(x, y), inner);
        }

        private static int AlignMiddleY(Rectangle outer, int h) => outer.Top + (outer.Height - h) / 2;
        private static int AlignMiddleX(Rectangle outer, int w) => outer.Left + (outer.Width - w) / 2;

        #endregion

        #region === Geometry Helpers ===

        /// <summary>
        /// 產生圓角矩形路徑；當半徑為 0 時退化為直角矩形。
        /// </summary>
        private static GraphicsPath RoundedRect(RectangleF rect, float radius)
        {
            var path = new GraphicsPath();
            float r = Math.Max(0f, Math.Min(radius, Math.Min(rect.Width, rect.Height) / 2f));
            if (r == 0f)
            {
                path.AddRectangle(rect);
                path.CloseFigure();
                return path;
            }

            float d = 2f * r;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        #endregion
    }
}
