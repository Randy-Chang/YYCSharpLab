using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeUtilities
{
    public class DateTimeHelper
    {
        #region DateTime Function
        public static string GetNowTime_toDay
        {
            get
            {
                return DateTime.Now.ToString("yyyyMMdd");
            }
        }
        #endregion
    }
}
