using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Profiles
{
    internal interface IProfile
    {
        string ProfileName { get; }
        ISet<EInputRawData> RequiredRawDataFiles { get; }
        ISet<EInputLotFile> RequiredLotFiles { get; }
    }
}
