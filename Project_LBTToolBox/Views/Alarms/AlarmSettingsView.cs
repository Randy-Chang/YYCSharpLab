using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Project_LBTToolBox.Views.Alarms
{
    public partial class AlarmSettingsView : UserControl
    {
        public AlarmSettingsView()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            //ApplyDarkTheme(this);
        }

        private void ApplyDarkTheme(Control c)
        {
            c.BackColor = Color.FromArgb(13, 13, 13);
            c.ForeColor = Color.White;
            foreach (Control child in c.Controls)
                ApplyDarkTheme(child);
        }
    }
}
