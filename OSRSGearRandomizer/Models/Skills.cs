using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRSGearRandomizer
{
    public class Skills
    {
        [JsonProperty("attack")]
        public int Attack { get; set; }

        [JsonProperty("ranged")]
        public int? Ranged { get; set; }

        [JsonProperty("defence")]
        public int? Defence { get; set; }

        [JsonProperty("mining")]
        public int? Mining { get; set; }

        [JsonProperty("magic")]
        public int? Magic { get; set; }

        [JsonProperty("strength")]
        public int? Strength { get; set; }

        [JsonProperty("slayer")]
        public int? Slayer { get; set; }

        [JsonProperty("thieving")]
        public int? Thieving { get; set; }

        [JsonProperty("agility")]
        public int? Agility { get; set; }

        [JsonProperty("prayer")]
        public int? Prayer { get; set; }

        [JsonProperty("hitpoints")]
        public int? Hitpoints { get; set; }

        [JsonProperty("runecraft")]
        public int? Runecraft { get; set; }

        [JsonProperty("herblore")]
        public int? Herblore { get; set; }

        [JsonProperty("crafting")]
        public int? Crafting { get; set; }

        [JsonProperty("fletching")]
        public int? Fletching { get; set; }

        [JsonProperty("construction")]
        public int? Construction { get; set; }

        [JsonProperty("smithing")]
        public int? Smithing { get; set; }

        [JsonProperty("fishing")]
        public int? Fishing { get; set; }

        [JsonProperty("cooking")]
        public int? Cooking { get; set; }

        [JsonProperty("firemaking")]
        public int? Firemaking { get; set; }

        [JsonProperty("woodcutting")]
        public int? Woodcutting { get; set; }

        [JsonProperty("farming")]
        public int? Farming { get; set; }

        [JsonProperty("hunter")]
        public int? Hunter { get; set; }
    }
}
