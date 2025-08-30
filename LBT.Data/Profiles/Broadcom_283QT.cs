using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Profiles
{
    internal class Broadcom_283QT : IProfile
    {
        public string ProfileName => "283QT";
        public ISet<EInputRawData> RequiredRawDataFiles => new HashSet<EInputRawData>
        {
            EInputRawData.LDSweep1,
            EInputRawData.EASweep1,
            EInputRawData.EASweep2,
            EInputRawData.Spectrum1,
            EInputRawData.Spectrum2,
            EInputRawData.SingleAndOSATerm,
        };

        public ISet<EInputLotFile> RequiredLotFiles => new HashSet<EInputLotFile>
        {
            EInputLotFile.LotFile,
            EInputLotFile.ModuleFileByBroadcom,
        };

    }
}
