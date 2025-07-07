using Project_LBTToolBox.Interfaces;
using Project_LBTToolBox.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        public static MainForm mainForm;

        void InitializeMainForm()
        {
            mainForm = new MainForm(new MainFormPack());
            mainForm.BtnChipIdCorrection.Click += (s, e) => ShowChipIdCorrection();
            mainForm.BtnSetting.Click += (s, e) => ShowSetting();

            InitializeViewHost();
            ShowChipIdCorrection();
        }

        void ShowChipIdCorrection()
        {
            viewHostManager.ShowUserControl(Scope.chipIdCorrectionView, mainForm.BtnChipIdCorrection);
        }

        void ShowSetting()
        {
            viewHostManager.ShowUserControl(Scope.settingView, mainForm.BtnSetting);
        }
    }

    public partial class Scope
    {
        public class MainFormPack : IMainFormPack
        {

        }
    }
}
