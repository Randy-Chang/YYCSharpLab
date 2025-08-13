using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYControls.Controls.WaferMap
{
    /// <summary>點擊晶粒事件參數。</summary>
    public sealed class DieClickedEventArgs : EventArgs
    {
        public int Row { get; }
        public int Col { get; }
        public string CellText { get; }

        public DieClickedEventArgs(int row, int col, string text)
        {
            Row = row;
            Col = col;
            CellText = text;
        }
    }
}
