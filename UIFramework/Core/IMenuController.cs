using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFramework.Core
{
    public interface IMenuController
    {
        /// <summary>
        /// 初始化選單控制器，並將控制器綁定至指定的 Menu 容器。
        /// </summary>
        /// <param name="menuPanel">作為選單容器的控制項（例如 FlowLayoutPanel）。</param>
        void Initialize(Control menuPanel);

        /// <summary>
        /// 設定選單項目與 View Key 的對應關係。
        /// </summary>
        /// <param name="mappings">選單 Key 與 View Key 的對應表。</param>
        void SetMenuMappings(Dictionary<string, string> mappings);

        /// <summary>
        /// 當選單項目被點擊時觸發，傳回對應的 View Key。
        /// </summary>
        event Action<string> MenuItemSelected;
    }


}
