using Newtonsoft.Json;

namespace SpaceX.Models
{
    /// <summary>
    /// A class that mapped FirstStage properties from JSON as classes from API.
    /// </summary>
    public class FirstStage
    {
        [JsonProperty(PropertyName = "cores")]
        public Core[] Cores { get; set; }
    }
}
