using System;
using System.IO;
using System.Xml.Serialization;

namespace Project_LBTToolBox.Services.AlarmsV3
{
    public enum AlarmDashboard3SourceMode
    {
        Remote,
        Local
    }

    [Serializable]
    public class AlarmDashboard3Preferences
    {
        public string RemotePath { get; set; } = string.Empty;
        public string LocalPath { get; set; } = string.Empty;
        public string LastMode { get; set; } = AlarmDashboard3SourceMode.Remote.ToString();
    }

    public static class AlarmDashboard3PreferencesStore
    {
        private static readonly XmlSerializer Serializer = new XmlSerializer(typeof(AlarmDashboard3Preferences));

        public static AlarmDashboard3Preferences Load()
        {
            string path = GetConfigPath();
            if (!File.Exists(path))
                return new AlarmDashboard3Preferences();

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    return Serializer.Deserialize(fs) as AlarmDashboard3Preferences ?? new AlarmDashboard3Preferences();
                }
            }
            catch
            {
                return new AlarmDashboard3Preferences();
            }
        }

        public static void Save(AlarmDashboard3Preferences preferences)
        {
            if (preferences == null)
                return;

            string path = GetConfigPath();
            string dir = Path.GetDirectoryName(path);
            if (!string.IsNullOrWhiteSpace(dir))
                Directory.CreateDirectory(dir);

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Serializer.Serialize(fs, preferences);
            }
        }

        private static string GetConfigPath()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(appData, "Project_LBTToolBox", "AlarmDashboardView3.config.xml");
        }
    }
}
