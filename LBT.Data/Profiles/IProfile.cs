using LBT.Data.Models.FileSpecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Profiles
{
    internal interface IProfile
    {
        /// <summary>
        /// Profile 名稱，用於識別（例如產品型號）。
        /// </summary>
        string ProfileName { get; }
        
        /// <summary>
        /// 必須的 RawData 檔案角色（檢查用）。
        /// </summary>
        ISet<EInputRawData> RequiredRawDataFiles { get; }

        /// <summary>
        /// 必須的 LotFile 檔案角色（檢查用）。
        /// </summary>
        ISet<EInputLotFile> RequiredLotFiles { get; }

        /// <summary>
        /// RawData 規格（包含 Pattern、Scope、欄位 Mapping）。
        /// Loader 依此決定如何尋找與解析。
        /// </summary>
        IReadOnlyDictionary<EInputRawData, RawFileSpec> RawFileSpecs { get; }

        /// <summary>
        /// LotFile 規格（包含 Pattern、Scope、欄位 Mapping）。
        /// </summary>
        IReadOnlyDictionary<EInputLotFile, LotFileSpec> LotFileSpecs { get; }
    }
}
