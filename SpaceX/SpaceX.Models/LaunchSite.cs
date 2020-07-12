using Newtonsoft.Json;

namespace SpaceX.Models
{
    /// <summary>
    /// A class that mapped LaunchSite properties from JSON as classes from API.
    /// </summary>
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
