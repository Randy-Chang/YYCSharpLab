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
        AlarmDashboardView2 alarmDashboardView2;

        void InitializeAlarmDashboard2View()
        {
            alarmDashboardView2 = new AlarmDashboardView2();
        }
    }
}
