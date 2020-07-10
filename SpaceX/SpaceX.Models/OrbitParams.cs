using Newtonsoft.Json;

namespace SpaceX.Models
{
    public class OrbitParams
    {
        [JsonProperty(PropertyName = "reference_system")]
        public string ReferenceSystem { get; set; }

        [JsonProperty(PropertyName = "regime")]
        public string Regime { get; set; }
    }
}
