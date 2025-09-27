using Project_LBTToolBox.Interfaces;
using Project_LBTToolBox.Views;
using Project_LBTToolBox.Views.Alarms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project_LBTToolBox.Scopes.Scope;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        static SettingView settingView;
        static AlarmDashboardView alarmDashboardView;
        static AlarmSettingsView alarmSettingsView;

        void InitializeSettingView()
        {
            alarmDashboardView = new AlarmDashboardView();
            settingView = new SettingView(new SettingViewPack());
        }
    }

    public partial class Scope
    {
        public class SettingViewPack : ISettingViewPack
        {

        }
    }
}
