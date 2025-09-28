using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        static string versionDate = "LBT Tool Box 2025-0928-1";

        public Scope() 
        {
            InitializeLogger();

            InitializeChipIdCorrectionService();
            InitializeLotFileDisplayService();

            // Initialize Views
            InitializeChipIdCorrectionView();
            InitializeDataGainView();
            InitializeSettingView();
            InitializeAlarmDashboard2View();


            InitializeMainForm();

            InitializeUIFramework();
        }
    }
}
