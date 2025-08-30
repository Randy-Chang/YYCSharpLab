using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Models
{
    public abstract class RawDataBase
    {
        public ERawDataType RawDataType { get; set; }
        public string FilePath { get; set; }
        public DataTable DataTable { get; set; } // 原始表格暫存

        public RawDataBase(ERawDataType type, string filePath)
        {
            RawDataType = type;
            FilePath = filePath;
        }
    }
}
