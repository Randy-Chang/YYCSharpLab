using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Models
{
    public class SingleAndOSARawData : RawDataBase
    {
        public Dictionary<string, double> KeyValues { get; set; } = new Dictionary<string, double>();

        public SingleAndOSARawData(string filePath) : base(ERawDataType.SingleAndOSATerm, filePath) { }
    }
}
