using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Models
{
    public enum ERawDataType
    {
        LD_SweepI,
        EA_SweepV,
        SOA_SweepI,
        OSA_Sweep,
        SingleAndOSATerm,
    }

    public enum EChannel
    {
        LD_Current,
        LD_Voltage,

        LD_ForwardLightPower,
        LD_BackwardLightPower,
        LD_ForwardPD_Voltage,
        LD_BackwardPD_Voltage,

        EA_Current,
        EA_Voltage,

        SOA_Current,
        SOA_Voltage,

        Spectrum_Wavelength,
        Spectrum_Power
    }
}
