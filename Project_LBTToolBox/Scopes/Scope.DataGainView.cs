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
        public static DataGainView dataGainView;

        void InitializeDataGainView()
        {
            dataGainView = new DataGainView();
        }
    }
}
