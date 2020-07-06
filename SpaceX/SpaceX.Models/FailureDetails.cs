using Newtonsoft.Json;

namespace SpaceX.Models
{
    public class FailureDetails
    {
        [JsonProperty(PropertyName = "time")]
        public int Time { get; set; }

        [JsonProperty(PropertyName = "altitude")]
        public int? Altitude { get; set; }

        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
    }
}
