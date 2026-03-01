using Project_LBTToolBox.Views.Alarms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        private static AlarmDashboardView3 alarmDashboardView3;

        private void InitializeAlarmDashboard3View()
        {
            alarmDashboardView3 = new AlarmDashboardView3();
        }
    }
}
