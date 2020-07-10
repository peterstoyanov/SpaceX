using Newtonsoft.Json;

namespace SpaceX.Models
{
    public class LaunchSite
    {
        [JsonProperty(PropertyName = "site_id")]
        public string SiteId { get; set; }

        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; set; }

        [JsonProperty(PropertyName = "site_name_long")]
        public string SiteNameLong { get; set; }
    }
}
