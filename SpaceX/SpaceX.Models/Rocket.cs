using Newtonsoft.Json;

namespace SpaceX.Models
{
    public class Rocket
    {
        [JsonProperty(PropertyName = "rocket_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "rocket_name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "rocket_type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "first_stage")]
        public FirstStage FirstStage { get; set; }

        [JsonProperty(PropertyName = "second_stage")]
        public SecondStage SecondStage { get; set; }
    }
}
