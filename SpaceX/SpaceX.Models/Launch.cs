using Newtonsoft.Json;
using System;

namespace SpaceX.Models
{
    public class Launch
    {
        [JsonProperty(PropertyName = "flight_number")]
        public int? FlightNumber { get; set; }

        [JsonProperty(PropertyName = "mission_name")]
        public string MissionName { get; set; }

        [JsonProperty(PropertyName = "launch_date_local")]
        public DateTime LaunchDate { get; set; }

        [JsonProperty(PropertyName = "rocket")]
        public Rocket Rocket { get; set; }

        [JsonProperty(PropertyName = "links")]
        public Links Links { get; set; }

        [JsonProperty(PropertyName = "launch_site")]
        public LaunchSite LaunchSite { get; set; }

        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }
    }
}
