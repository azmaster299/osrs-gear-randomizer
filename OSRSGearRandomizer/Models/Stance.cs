using Newtonsoft.Json;

namespace OSRSGearRandomizer
{
    public class Stance
    {
        [JsonProperty("combat_style")]
        public string CombatStyle { get; set; }

        [JsonProperty("attack_type")]
        public string AttackType { get; set; }

        [JsonProperty("attack_style")]
        public string AttackStyle { get; set; }

        [JsonProperty("experience")]
        public string Experience { get; set; }

        [JsonProperty("boosts")]
        public string Boosts { get; set; }
    }
}
