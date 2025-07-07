using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Services.ChipIdCorrection
{
    /// <summary>
    /// 提供 OCR 比對條件的擴充方法（根據 CSV 行內容進行欄位比對）。
    /// </summary>
    public static class OcrMatchCriteriaExtensions
    {
        public static bool IsMatchFromLine(this OcrMatchCriteria criteria, string[] headers, string[] values)
        {
            var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < headers.Length && i < values.Length; i++)
                dict[headers[i]] = values[i];

            return IsFieldEqual(dict, "TestSet", criteria.TestSet)
                && IsFieldEqual(dict, "BinX", criteria.BinX)
                && IsFieldEqual(dict, "BinY", criteria.BinY)
                && IsFieldEqual(dict, "TestTimeStart", criteria.TestTime);
        }

        private static bool IsFieldEqual(Dictionary<string, string> dict, string field, string expected)
        {
            return dict.TryGetValue(field, out var actual)
                && string.Equals(actual, expected, StringComparison.OrdinalIgnoreCase);
        }
    }
}
