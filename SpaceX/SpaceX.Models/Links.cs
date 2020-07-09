using System.Collections.Generic;
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
        public string YouTubeLink { get; set; }

        [JsonProperty(PropertyName = "youtube_id")]
        public string YouTubeId { get; set; }

        [JsonProperty(PropertyName = "flickr_images")]
        public ICollection<string> Images { get; set; } = new List<string>();
    }
}

