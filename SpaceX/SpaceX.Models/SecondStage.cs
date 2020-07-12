using Newtonsoft.Json;

namespace SpaceX.Models
{
    /// <summary>
    /// A class that mapped SecondStage properties from JSON as classes from API.
    /// </summary>
    public class SecondStage
    {
        [JsonProperty(PropertyName = "block")]
        public int? Block { get; set; }

        [JsonProperty(PropertyName = "payloads")]
        public Payload[] Payloads { get; set; }
    }
}
