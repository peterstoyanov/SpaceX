using Newtonsoft.Json;
using System.Collections.Generic;

namespace SpaceX.Models
{
    public class FirstStage
    {
        [JsonProperty(PropertyName = "cores")]
        public Core[] Cores { get; set; }
    }
}
