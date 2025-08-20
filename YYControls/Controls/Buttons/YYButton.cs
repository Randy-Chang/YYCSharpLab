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
    public class YYButton : Button
    {
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

        [Category("YY Button"), Description("外框粗細（像素）"), DefaultValue(1)]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = Math.Max(0, value); Invalidate(); }
        }

        [Category("YY Button"), Description("圓角半徑（像素）"), DefaultValue(12)]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("YY Button"), Description("外框顏色")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("YY Button"), Description("一般背景色")]
        public Color BackColorNormal
        {
            get => _backColorNormal;
            set { _backColorNormal = value; Invalidate(); }
        }

        [Category("YY Button"), Description("滑過背景色")]
        public Color BackColorHover
        {
            get => _backColorHover;
            set { _backColorHover = value; Invalidate(); }
        }

        [Category("YY Button"), Description("按下背景色")]
        public Color BackColorPressed
        {
            get => _backColorPressed;
            set { _backColorPressed = value; Invalidate(); }
        }

        [Category("YY Button"), Description("停用背景色")]
        public Color BackColorDisabled
        {
            get => _backColorDisabled;
            set { _backColorDisabled = value; Invalidate(); }
        }

        [Category("YY Button"), Description("啟用漸層背景"), DefaultValue(false)]
        public bool UseGradient
        {
            get => _useGradient;
            set { _useGradient = value; Invalidate(); }
        }

        [Category("YY Button"), Description("漸層角度（度）"), DefaultValue(90f)]
        public float GradientAngle
        {
            get => _gradientAngle;
            set { _gradientAngle = value; Invalidate(); }
        }

        [Category("YY Button"), Description("背景色別名（同步 BackColor）")]
        public Color BackgroundColor
        {
            get => this.BackColor;
            set { this.BackColor = value; Invalidate(); }
        }

        [Category("YY Button"), Description("文字色別名（同步 ForeColor）")]
        public Color TextColor
        {
            get => this.ForeColor;
            set { this.ForeColor = value; Invalidate(); }
        }

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

        protected override void OnParentChanged(EventArgs e)
        {
            // unsubscribe from old parent
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && Parent != null)
            {
                Parent.BackColorChanged -= Parent_BackColorChanged;
            }
            base.Dispose(disposing);
        }

        private void Parent_BackColorChanged(object sender, EventArgs e) => Invalidate();

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (BackColor.A < 255 && Parent != null)
            {
                var g = pevent.Graphics;
                var state = g.Save();
                g.TranslateTransform(-Left, -Top);
                PaintEventArgs pea = new PaintEventArgs(g, Parent.DisplayRectangle);
                InvokePaintBackground(Parent, pea);
                InvokePaint(Parent, pea);
                g.Restore(state);
            }
            else
            {
                base.OnPaintBackground(pevent);
            }
        }

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

            var rectBorder = RectangleF.Inflate(rect, -border * 0.5f, -border * 0.5f);

            using (var path = RoundedRect(rect, radius))
            using (var region = new Region(path))
            {
                Region = region.Clone();

                Color baseColor = CurrentBackColor();
                using (Brush b = _useGradient
                    ? (Brush)new LinearGradientBrush(rect, baseColor, ControlPaint.Light(baseColor, 0.15f), _gradientAngle)
                    : (Brush)new SolidBrush(baseColor))
                {
                    g.FillPath(b, path);
                }

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

        private Color CurrentBackColor()
        {
            if (!Enabled) return _backColorDisabled;
            if (_pressed) return _backColorPressed;
            if (_hovered) return _backColorHover;
            return _backColorNormal;
        }

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

        private void DrawContent(Graphics g)
        {
            Rectangle contentRect = Rectangle.Inflate(ClientRectangle, -4, -2);

            var img = Image;
            var text = Text ?? string.Empty;

            var textColor = Enabled ? ForeColor : _textColorDisabled;

            Rectangle imageRect = Rectangle.Empty;
            if (img != null)
            {
                imageRect.Size = img.Size;
                imageRect = AlignWithin(contentRect, imageRect.Size, ImageAlign);
            }

            Size textSize;
            using (var tmpBmp = new Bitmap(1, 1))
            using (var gTmp = Graphics.FromImage(tmpBmp))
            {
                textSize = Size.Ceiling(gTmp.MeasureString(text, Font));
            }

            Rectangle textRect = new Rectangle(Point.Empty, textSize);
            textRect = AlignWithin(contentRect, textRect.Size, TextAlign);

            switch (TextImageRelation)
            {
                case TextImageRelation.ImageBeforeText:
                    if (!imageRect.IsEmpty)
                    {
                        imageRect = new Rectangle(contentRect.Left, AlignMiddleY(contentRect, imageRect.Height), img.Width, img.Height);
                        textRect = new Rectangle(imageRect.Right + Padding.Left, AlignMiddleY(contentRect, textRect.Height),
                                                 Math.Min(contentRect.Right - imageRect.Right - Padding.Horizontal, textRect.Width), textRect.Height);
                    }
                    break;
                case TextImageRelation.TextBeforeImage:
                    if (!imageRect.IsEmpty)
                    {
                        textRect = new Rectangle(contentRect.Left, AlignMiddleY(contentRect, textRect.Height),
                                                 Math.Min(contentRect.Width - img.Width - Padding.Horizontal, textRect.Width), textRect.Height);
                        imageRect = new Rectangle(textRect.Right + Padding.Right, AlignMiddleY(contentRect, imageRect.Height), img.Width, img.Height);
                    }
                    break;
                case TextImageRelation.ImageAboveText:
                    if (!imageRect.IsEmpty)
                    {
                        imageRect = new Rectangle(AlignMiddleX(contentRect, imageRect.Width), contentRect.Top, img.Width, img.Height);
                        textRect = new Rectangle(AlignMiddleX(contentRect, textRect.Width), imageRect.Bottom + Padding.Top,
                                                 textRect.Width, textRect.Height);
                    }
                    break;
                case TextImageRelation.TextAboveImage:
                    if (!imageRect.IsEmpty)
                    {
                        textRect = new Rectangle(AlignMiddleX(contentRect, textRect.Width), contentRect.Top, textRect.Width, textRect.Height);
                        imageRect = new Rectangle(AlignMiddleX(contentRect, imageRect.Width), textRect.Bottom + Padding.Top, img.Width, img.Height);
                    }
                    break;
                case TextImageRelation.Overlay:
                default:
                    break;
            }

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

        private static int AlignMiddleY(Rectangle outer, int h) => outer.Top + (outer.Height - h) / 2;
        private static int AlignMiddleX(Rectangle outer, int w) => outer.Left + (outer.Width - w) / 2;

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
    }
}
