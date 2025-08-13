using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYControls.Controls.WaferMap
{
    /// <summary>晶粒狀態（後續可由 lotFile 帶入著色）。</summary>
    public enum DieStatus
    {
        Unknown = 0,
        Pass = 1,
        Ng = 2,
        Null = 3, // 無晶粒
    }
}
