using Newtonsoft.Json;

namespace SpaceX.Models
{
    public class SecondStage
    {
        [JsonProperty(PropertyName = "block")]
        public int? Block { get; set; }

        [JsonProperty(PropertyName = "payloads")]
        public Payload[] Payloads { get; set; }
    }
}
