using Newtonsoft.Json;

namespace SpaceX.Models
{
    public class Links
    {
        [JsonProperty(PropertyName = "mission_patch")]
        public string MissionPatch { get; set; }

        [JsonProperty(PropertyName = "mission_patch_small")]
        public string MissionPatchSmall { get; set; }

        [JsonProperty(PropertyName = "article_link")]
        public string Article { get; set; }

        [JsonProperty(PropertyName = "video_link")]
        public string Video { get; set; }

        [JsonProperty(PropertyName = "flickr_images")]
        public string[] Images { get; set; }
    }
}
