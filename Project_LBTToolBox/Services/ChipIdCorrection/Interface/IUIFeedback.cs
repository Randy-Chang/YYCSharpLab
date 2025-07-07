using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Services.ChipIdCorrection.Interface
{
    /// <summary>
    /// 用來與 UI 層互動，例如提示訊息或標示 UI 項目。
    /// </summary>
    public interface IUIFeedback
    {
        void ShowMessage(string message);
        void ShowError(string message);
        void HighlightRow(int index);
    }
}
