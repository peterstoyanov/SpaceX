using Newtonsoft.Json;

namespace SpaceX.Models
{
    public class Core
    {
        [JsonProperty(PropertyName = "core_serial")]
        public string CoreSerial { get; set; }

        [JsonProperty(PropertyName = "flight")]
        public int? Flight { get; set; }
    }
}
