using Newtonsoft.Json;

namespace OSRSGearRandomizer
{
    public class Links
    {
        [JsonProperty("self")]
        public Self Self { get; set; }
    }
}
