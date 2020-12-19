using Newtonsoft.Json;

namespace OSRSGearRandomizer
{
    public class Self
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
