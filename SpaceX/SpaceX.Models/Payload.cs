using Newtonsoft.Json;

namespace SpaceX.Models
{
    public class Payload
    {
        [JsonProperty(PropertyName = "payload_id")]
        public string PayloadId { get; set; }

        [JsonProperty(PropertyName = "nationality")]
        public string Nationality { get; set; }

        [JsonProperty(PropertyName = "manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty(PropertyName = "payload_type")]
        public string PayloadType { get; set; }

        [JsonProperty(PropertyName = "payload_mass_kg")]
        public double? PayloadMassKg { get; set; }

        [JsonProperty(PropertyName = "payload_mass_lbs")]
        public double? PayloadMassLbs { get; set; }

        [JsonProperty(PropertyName = "orbit")]
        public string Orbit { get; set; }

        [JsonProperty(PropertyName = "orbit_params")]
        public OrbitParams orbit_params { get; set; }
    }
}
