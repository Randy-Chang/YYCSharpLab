using System.Drawing;
using System.Windows.Forms;
using Project_LBTToolBox.Controls;

namespace Project_LBTToolBox.Views
{
    public static class UiHelpers
    {
        public static void SetupKpiCard(Panel card, Label title, Label value, string text)
        {
            card.Dock = DockStyle.Fill;
            title.Text = text;
            title.Dock = DockStyle.Top;
            value.Text = "—";
            value.Dock = DockStyle.Top;
            value.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold);
            card.Controls.Add(value);
            card.Controls.Add(title);
            value.BringToFront();
        }
    }
}
