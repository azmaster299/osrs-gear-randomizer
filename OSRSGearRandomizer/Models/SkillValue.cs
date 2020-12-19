using Newtonsoft.Json;

namespace OSRSGearRandomizer
{
    public class SkillValue
    {
        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("xp")]
        public int Xp { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
