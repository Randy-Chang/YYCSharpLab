using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        public Scope() 
        {
            InitializeLogger();

            InitializeChipIdCorrectionService();
            InitializeLotFileDisplayService();

            InitializeChipIdCorrectionView();
            INITializeSettingView();
            InitializeMainForm();
        }
    }
}
