using Newtonsoft.Json;
using System.IO;

namespace OSRSGearRandomizer
{
    public class AppSettings
    {
        [JsonProperty("Player")]
        public Player Player { get; set; }

        [JsonProperty("Members")]
        public bool Members { get; set; }

        [JsonProperty("Cosmetics")]
        public bool Cosmetics { get; set; }

        [JsonProperty("Untradeables")]
        public bool Untradeables { get; set; }

        [JsonProperty("QuestItems")]
        public bool QuestItems { get; set; }

        [JsonProperty("RequireStats")]
        public bool RequireStats { get; set; }

        [JsonProperty("HideRandomizeAll")]
        public bool HideRandomizeAll { get; set; }

        [JsonProperty("CheckRequirements")]
        public bool CheckRequirements { get; set; }

        public void Save()
        {
            string settingsJson = JsonConvert.SerializeObject(this, Formatting.Indented);
            StreamWriter writer = File.CreateText(SettingsDataFilePath);
            writer.Write(settingsJson);
            writer.Close();
            writer.Dispose();
        }

        public static string SettingsDataFilePath
        {
            get
            {
                return Directory.GetCurrentDirectory() + "/Resources/appsettings.json";
            }
        }
    }
}
