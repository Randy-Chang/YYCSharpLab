using System.Drawing;
using System.Windows.Forms;
using Project_LBTToolBox.Controls;

namespace Project_LBTToolBox.Views
{
    public static class UiHelpers
    {
        public static void ApplyDarkTheme(Control root)
        {
            if (root == null) return;
            root.BackColor = DarkColors.Bg;
            root.ForeColor = DarkColors.Text;

            foreach (Control c in root.Controls)
                ApplyDarkTheme(c);

            // 特別處理常見控制項
            if (root is TextBox tb)
            {
                tb.BackColor = DarkColors.Card;
                tb.ForeColor = DarkColors.Text;
                tb.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (root is ComboBox cb)
            {
                cb.BackColor = DarkColors.Card;
                cb.ForeColor = DarkColors.Text;
                cb.FlatStyle = FlatStyle.Flat;
            }
            else if (root is DateTimePicker dtp)
            {
                dtp.CalendarForeColor = DarkColors.Text;
                dtp.CalendarMonthBackground = DarkColors.Card;
            }
            else if (root is CheckedListBox clb)
            {
                clb.BackColor = DarkColors.Card;
                clb.ForeColor = DarkColors.Text;
                clb.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (root is ListBox lb)
            {
                lb.BackColor = DarkColors.Card;
                lb.ForeColor = DarkColors.Text;
                lb.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (root is StatusStrip ss)
            {
                ss.BackColor = DarkColors.Bg;
                ss.ForeColor = DarkColors.Muted;
                ss.SizingGrip = false;
            }
        }

        public static void StyleButton(Button btn, Color bg)
        {
            if (btn == null) return;
            btn.BackColor = bg;
            btn.ForeColor = Color.Black;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Padding = new Padding(12, 6, 12, 6);
            btn.Margin = new Padding(8, 4, 0, 0);
        }

        public static void StyleDataGrid(DataGridView gv, bool readOnly)
        {
            if (gv == null) return;
            gv.BackgroundColor = DarkColors.Card;
            gv.BorderStyle = BorderStyle.None;
            gv.EnableHeadersVisualStyles = false;
            gv.RowHeadersVisible = false;
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gv.AllowUserToAddRows = !readOnly;
            gv.AllowUserToDeleteRows = !readOnly;
            gv.ReadOnly = readOnly;
            gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv.MultiSelect = true;

            gv.ColumnHeadersDefaultCellStyle.BackColor = DarkColors.Border;
            gv.ColumnHeadersDefaultCellStyle.ForeColor = DarkColors.Text;
            gv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft JhengHei UI", 9.5f, FontStyle.Bold);

            gv.DefaultCellStyle.BackColor = DarkColors.Card;
            gv.DefaultCellStyle.ForeColor = DarkColors.Text;
            gv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 100, 200);
            gv.DefaultCellStyle.SelectionForeColor = Color.White;
            gv.GridColor = DarkColors.Border;
        }
    }
}
