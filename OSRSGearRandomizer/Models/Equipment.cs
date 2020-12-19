using Newtonsoft.Json;

namespace OSRSGearRandomizer
{
    public class Equipment
    {
        [JsonProperty("attack_stab")]
        public int AttackStab { get; set; }

        [JsonProperty("attack_slash")]
        public int AttackSlash { get; set; }

        [JsonProperty("attack_crush")]
        public int AttackCrush { get; set; }

        [JsonProperty("attack_magic")]
        public int AttackMagic { get; set; }

        [JsonProperty("attack_ranged")]
        public int AttackRanged { get; set; }

        [JsonProperty("defence_stab")]
        public int DefenceStab { get; set; }

        [JsonProperty("defence_slash")]
        public int DefenceSlash { get; set; }

        [JsonProperty("defence_crush")]
        public int DefenceCrush { get; set; }

        [JsonProperty("defence_magic")]
        public int DefenceMagic { get; set; }

        [JsonProperty("defence_ranged")]
        public int DefenceRanged { get; set; }

        [JsonProperty("melee_strength")]
        public int MeleeStrength { get; set; }

        [JsonProperty("ranged_strength")]
        public int RangedStrength { get; set; }

        [JsonProperty("magic_damage")]
        public int MagicDamage { get; set; }

        [JsonProperty("prayer")]
        public int Prayer { get; set; }

        [JsonProperty("slot")]
        public string Slot { get; set; }

        [JsonProperty("requirements")]
        public Requirements Requirements { get; set; }
    }
}
