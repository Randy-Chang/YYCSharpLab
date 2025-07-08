using Project_LBTToolBox.Interfaces;
using System;
using System.Windows.Forms;
using YYCSharpLab.UIFramework.Core;

namespace Project_LBTToolBox.Views
{
    public partial class MainForm : Form, IMainFormPack
    {
        public Panel PanelView => panelView;
        public Panel PanelMenu => panelMenu;
        public Button BtnChipIdCorrection => btnChipIdCorrection;
        public Button BtnSetting => btnSetting;

        IMainFormPack _pack;

        public MainForm(IMainFormPack pack)
        {
            InitializeComponent();

            _pack = pack;

            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
