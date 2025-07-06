using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace YYCSharpLab.UIFramework.Extensions
{
    public static class JsonThemeLoader
    {
        public static List<string> LoadColorListFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<string>();

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<string>>(json) ?? new List<string>();
        }
    }
}
