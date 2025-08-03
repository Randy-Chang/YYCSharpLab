using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFramework.Core
{
    public interface IViewHost
    {
        // 註冊 View（關鍵字 + UserControl 實例）
        void Register(string key, UserControl view);

        // 切換當前顯示的 View
        void Switch(string key);

        // 目前顯示的 View Key
        string CurrentViewKey { get; }

        // 當 View 被切換時觸發
        event Action<string> ViewSwitched;
    }

}
