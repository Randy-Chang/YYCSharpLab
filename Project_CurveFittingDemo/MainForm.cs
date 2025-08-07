using Project_CurveFittingDemo.Scopes;
using System.Windows.Forms;

namespace Project_CurveFittingDemo
{
    public partial class MainForm : Form, IMainFormUI
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public Button BtnRunDemo => btnRunDemo;

        public Panel PanelChart => panelChart;
    }
}
