using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project_LBTToolBox.Controls
{
    public static class DarkColors
    {
        public static readonly Color Bg = Color.FromArgb(13, 13, 13);      // #0D0D0D
        public static readonly Color Card = Color.FromArgb(26, 26, 26);    // #1A1A1A
        public static readonly Color Border = Color.FromArgb(42, 42, 42);  // #2A2A2A
        public static readonly Color Text = Color.FromArgb(230, 230, 230); // #E6E6E6
        public static readonly Color Muted = Color.FromArgb(160, 160, 160);
        public static readonly Color Accent = Color.FromArgb(59, 130, 246); // #3B82F6
        public static readonly Color Accent2 = Color.FromArgb(16, 185, 129); // #10B981
        public static readonly Color Accent3 = Color.FromArgb(245, 158, 11); // #F59E0B
        public static readonly Color Accent4 = Color.FromArgb(239, 68, 68);  // #EF4444
    }

    [DefaultEvent("Click")]
    public class CardPanel : Panel
    {
        private int _cornerRadius = 12;
        private int _borderThickness = 1;
        private Color _borderColor = DarkColors.Border;

        [Category("Appearance")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        public int BorderThickness
        {
            get => _borderThickness;
            set { _borderThickness = Math.Max(0, value); Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public CardPanel()
        {
            DoubleBuffered = true;
            BackColor = DarkColors.Card;
            ForeColor = DarkColors.Text;
            Padding = new Padding(16);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = ClientRectangle;
            rect.Inflate(-1, -1);

            using (var path = RoundedRect(rect, _cornerRadius))
            using (var bg = new SolidBrush(BackColor))
            using (var pen = new Pen(_borderColor, _borderThickness))
            {
                g.FillPath(bg, path);
                if (_borderThickness > 0)
                    g.DrawPath(pen, path);
            }
        }

        private GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            if (radius <= 0) { path.AddRectangle(r); return path; }
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }

    public static class DarkTheme
    {
        public static void Apply(Control root)
        {
            root.BackColor = DarkColors.Bg;
            root.ForeColor = DarkColors.Text;
            foreach (Control c in root.Controls) Apply(c);
        }
    }
}
