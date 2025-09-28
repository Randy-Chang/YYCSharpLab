using LoggingUtilities;
using Project_LBTToolBox.Services.LotFileDisplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        LotFileDisplayService lotFileDisplayService;

        void InitializeLotFileDisplayService()
        {
            lotFileDisplayService = new LotFileDisplayService(lotFileParserCsv);
            LoggerService.Instance.Info("LotFileDisplayService 初始化完成");
        }
    }
}
