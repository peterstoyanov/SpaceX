using Newtonsoft.Json;

namespace SpaceX.Models
{
    /// <summary>
    /// A class that mapped Core properties from JSON as classes from API.
    /// </summary>
    public class Core
    {
        [JsonProperty(PropertyName = "core_serial")]
        public string CoreSerial { get; set; }

        [JsonProperty(PropertyName = "flight")]
        public int? Flight { get; set; }
    }
}
