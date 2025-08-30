using LBT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Units
{
    public class SIUnitInfo
    {
        public ESIUnit Unit { get; set; }
        public ESIUnitOrder Order { get; set; }

        public SIUnitInfo(ESIUnit unit, ESIUnitOrder order)
        {
            Unit = unit;
            Order = order;
        }
    }
}
