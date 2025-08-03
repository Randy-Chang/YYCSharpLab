using System;
using System.IO;
using System.Web.Script.Serialization;
using UIFramework.Core;

namespace UIFramework.Settings
{
    /// <summary>
    /// 使用 JSON 格式實作設定檔存取（.NET Framework 4.8）。
    /// </summary>
    public class JsonSettingsProvider<T> : ISettingsProvider<T> where T : new()
    {
        private readonly string _filePath;
        private readonly JavaScriptSerializer _serializer = new JavaScriptSerializer();

        public JsonSettingsProvider(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

            _filePath = filePath;
        }

        public T Load()
        {
            if (!File.Exists(_filePath))
                return new T();

            try
            {
                string json = File.ReadAllText(_filePath);
                var obj = _serializer.Deserialize<T>(json);
                return obj == null ? new T() : obj;
            }
            catch
            {
                return new T();
            }
        }

        public void Save(T settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            string json = _serializer.Serialize(settings);
            File.WriteAllText(_filePath, json);
        }
    }
}
