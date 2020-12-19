using Newtonsoft.Json;
using System.Collections.Generic;

namespace OSRSGearRandomizer
{
    public class Weapon
    {
        [JsonProperty("attack_speed")]
        public int AttackSpeed { get; set; }

        [JsonProperty("weapon_type")]
        public string WeaponType { get; set; }

        [JsonProperty("stances")]
        public List<Stance> Stances { get; set; }
    }
}
