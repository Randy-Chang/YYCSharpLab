using LBT.Data.Models;
using LBT.Data.Models.FileSpecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            EInputRawData.OSASweep1,
            EInputRawData.OSASweep2,
            EInputRawData.SingleAndOSATerm,
        };

        public ISet<EInputLotFile> RequiredLotFiles => new HashSet<EInputLotFile>
        {
            EInputLotFile.LotFile,
            EInputLotFile.ModuleFileByBroadcom,
        };


        // 新增：每個 Raw 檔角色的規格
        public IReadOnlyDictionary<EInputRawData, RawFileSpec> RawFileSpecs =>
            new Dictionary<EInputRawData, RawFileSpec>
            {
                [EInputRawData.LDSweep1] = new RawFileSpec
                {
                    Pattern = "*_0_LD_SweepI.csv",
                    RawDataType = ERawDataType.LD_SweepI,
                    Scope = FileScope.OnePerBar,
                    ColumnMappings = new Dictionary<string, EChannel>
                    {
                    { "LD_I", EChannel.LD_Current },
                    { "LD_V", EChannel.LD_Voltage },
                    { "LD_P", EChannel.LD_ForwardLightPower },
                    { "LD_BackPower", EChannel.LD_BackwardLightPower },
                    { "EA_I", EChannel.EA_Current },
                    }
                },

                [EInputRawData.EASweep1] = new RawFileSpec
                {
                    Pattern = "*_1_EA_SweepV.csv",
                    RawDataType = ERawDataType.EA_SweepV,
                    Scope = FileScope.OnePerBar,
                    ColumnMappings = new Dictionary<string, EChannel>
                    {
                    { "EA_V", EChannel.EA_Voltage },
                    { "EA_I", EChannel.EA_Current },
                    { "LD_V", EChannel.LD_Voltage },
                    { "LD_FrontPower", EChannel.LD_ForwardLightPower },
                    { "LD_BackPower", EChannel.LD_BackwardLightPower },
                    }
                },

                [EInputRawData.EASweep2] = new RawFileSpec
                {
                    Pattern = "*_12_EA_SweepV.csv",
                    RawDataType = ERawDataType.EA_SweepV,
                    Scope = FileScope.OnePerBar,
                    ColumnMappings = new Dictionary<string, EChannel>
                    {
                    { "EA_V", EChannel.EA_Voltage },
                    { "EA_I", EChannel.EA_Current },
                    { "LD_V", EChannel.LD_Voltage },
                    { "LD_FrontPower", EChannel.LD_ForwardLightPower },
                    { "LD_BackPower", EChannel.LD_BackwardLightPower },
                    }
                },

                [EInputRawData.OSASweep1] = new RawFileSpec
                {
                    Pattern = "*_3_OSA_Sweep.csv",
                    RawDataType = ERawDataType.OSA_Sweep,
                    Scope = FileScope.OnePerBar,
                    ColumnMappings = new Dictionary<string, EChannel>
                    {
                    { "WL", EChannel.Spectrum_Wavelength },
                    { "power(dBm)", EChannel.Spectrum_Power },
 
                    }
                },

                [EInputRawData.OSASweep2] = new RawFileSpec
                {
                    Pattern = "*_4_OSA_Sweep.csv",
                    RawDataType = ERawDataType.OSA_Sweep,
                    Scope = FileScope.OnePerBar,
                    ColumnMappings = new Dictionary<string, EChannel>
                    {
                    { "WL", EChannel.Spectrum_Wavelength },
                    { "power(dBm)", EChannel.Spectrum_Power },

                    }
                },

                [EInputRawData.SingleAndOSATerm] = new RawFileSpec
                {
                    Pattern = "*_lotFile.csv",
                    RawDataType = ERawDataType.SingleAndOSATerm,
                    Scope = FileScope.OnePerBar,
                    ColumnMappings = new Dictionary<string, EChannel>
                    {
                    }
                },
            };

        public IReadOnlyDictionary<EInputLotFile, LotFileSpec> LotFileSpecs =>
            new Dictionary<EInputLotFile, LotFileSpec>
            {
                // 根目錄：QT370931_B2613545_257_lotFile.csv
                [EInputLotFile.LotFile] = new LotFileSpec
                {
                    Pattern = "*_lotFile.csv",
                    Scope = FileScope.OnePerLot,
                    // 這裡不是通道，而是索引欄位等標準欄名；依實際表頭調整
                    ColumnMappings = new Dictionary<string, string>
                    {
                        { "ChipID",   "ChipId"    },
                        { "BarID",    "BarId"     },
                        { "Index",    "DieIndex"  },
                        { "WaferNo",  "WaferNumber" }, // 若檔內有
                        { "BpackNo",  "BpackNumber" }  // 若檔內有
                    }
                },

                // 根目錄：B2613545_2025_08_30.csv
                [EInputLotFile.ModuleFileByBroadcom] = new LotFileSpec
                {
                    Pattern = "*_????_??_??.csv",
                    Scope = FileScope.OnePerLot,
                    // 視實際表頭而定（示意）
                    ColumnMappings = new Dictionary<string, string>
                    {
                        { "ModuleName", "Module"   },
                        { "Date",       "Date"     },
                        { "Bpack",      "BpackNumber" }
                    }
                }
            };
    }

}
