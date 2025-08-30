using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Profiles
{
    public enum EInputRawData
    {
        LDSweep1,
        LDSweep2,
        LDSweep3,
        EASweep1,
        EASweep2,
        EASweep3,
        SOASweep1,
        SOASweep2,
        SOASweep3,
        Spectrum1,
        Spectrum2,
        Spectrum3,
        Spectrum4,
        Spectrum5,
        SingleAndOSATerm,
    }

    public enum EInputLotFile
    {
        LotFile,
        ModuleFileByBroadcom,
    }
}
