using Newtonsoft.Json;

namespace SpaceX.Models
{
    /// <summary>
    /// A class that mapped OrbitParams properties from JSON as classes from API.
    /// </summary>
    public class OrbitParams
    {
        [JsonProperty(PropertyName = "reference_system")]
        public string ReferenceSystem { get; set; }

        [JsonProperty(PropertyName = "regime")]
        public string Regime { get; set; }
    }
}
