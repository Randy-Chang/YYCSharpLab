using LBT.Data.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Models
{
    public class SweepBarRawData : RawDataBase
    {
        public Dictionary<EChannel, List<double>> ChannelData { get; set; } = new Dictionary<EChannel, List<double>>();

        public IReadOnlyCollection<EChannel> Channels => ChannelData.Keys;


        public SweepBarRawData(string filePath, ERawDataType eRawDataType) : base(eRawDataType, filePath) { }

        public void AddData(EChannel channel, IEnumerable<double> values)
        {
            ChannelData[channel] = values.ToList();
        }

        public SIUnitInfo GetUnit(EChannel channel)
        {
            return ChannelUnits.GetUnit(channel);
        }
    }
}
