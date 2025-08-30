using LBT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Units
{
    public static class ChannelUnits
    {
        public static readonly Dictionary<EChannel, SIUnitInfo> ChannelToUnitMap = new Dictionary<EChannel, SIUnitInfo>
        {
            { EChannel.LD_Current, new SIUnitInfo(ESIUnit.Ampere, ESIUnitOrder.Milli) },
            { EChannel.LD_Voltage, new SIUnitInfo(ESIUnit.Volt, ESIUnitOrder.None) },

            { EChannel.LD_ForwardLightPower, new SIUnitInfo(ESIUnit.Watt, ESIUnitOrder.Milli) },
            { EChannel.LD_BackwardLightPower, new SIUnitInfo(ESIUnit.Watt, ESIUnitOrder.Milli) },
            { EChannel.LD_ForwardPD_Voltage, new SIUnitInfo(ESIUnit.Volt, ESIUnitOrder.None) },
            { EChannel.LD_BackwardPD_Voltage, new SIUnitInfo(ESIUnit.Volt, ESIUnitOrder.None) },

            { EChannel.EA_Current, new SIUnitInfo(ESIUnit.Ampere, ESIUnitOrder.Milli) },
            { EChannel.EA_Voltage, new SIUnitInfo(ESIUnit.Volt, ESIUnitOrder.None) },
            { EChannel.SOA_Current, new SIUnitInfo(ESIUnit.Ampere, ESIUnitOrder.Milli) },
            { EChannel.SOA_Voltage, new SIUnitInfo(ESIUnit.Volt, ESIUnitOrder.None) },
            { EChannel.Spectrum_Wavelength, new SIUnitInfo(ESIUnit.Meter, ESIUnitOrder.Nano) },
            { EChannel.Spectrum_Power, new SIUnitInfo(ESIUnit.DecibelMilliWatt, ESIUnitOrder.None) },
        };

        public static SIUnitInfo GetUnit(EChannel channel)
        {
            if (ChannelToUnitMap.TryGetValue(channel, out var unitInfo))
            {
                return unitInfo;
            }
            throw new ArgumentException($"No unit information found for channel: {channel}");
        }
    }


}
