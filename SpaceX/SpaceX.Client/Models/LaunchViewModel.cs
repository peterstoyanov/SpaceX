using System.Collections.Generic;
using System;

namespace SpaceX.Client.Models
{
    public class LaunchViewModel
    {
        public int FlightNumber { get; set; }
        public string MissionName { get; set; }
        public DateTime LaunchDate { get; set; }
        public bool? LaunchSuccess { get; set; }

        public string RocketId { get; set; }
        public string RocketName { get; set; }
        public string RocketType { get; set; }

        public string LinkMissionPatch { get; set; }
        public string LinkMissionPatchSmall { get; set; }
        public string LinkArticle { get; set; }
        public string LinkVideo { get; set; }
        public ICollection<string> LinkImages { get; set; }

        public string Details { get; set; }
    }
}
