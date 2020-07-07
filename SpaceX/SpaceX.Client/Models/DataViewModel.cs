using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace SpaceX.Client.Models
{
    public class DataViewModel
    {
        [DisplayName("Flight №")]
        public int FlightNumber { get; set; }

        [DisplayName("Mission")]
        public string MissionName { get; set; }

        [DisplayName("Launch Date")]
        public DateTime LaunchDate { get; set; }

        [DisplayName("Launch Success")]
        public bool? LaunchSuccess { get; set; }

        public string RocketId { get; set; }

        [DisplayName("Rocket Name")]
        public string RocketName { get; set; }

        [DisplayName("Rocket Type")]
        public string RocketType { get; set; }

        public string LinkMissionPatch { get; set; }
        public string LinkMissionPatchSmall { get; set; }
        public string LinkArticle { get; set; }
        public string LinkVideo { get; set; }
        public ICollection<string> LinkImages { get; set; }

        public string Details { get; set; }
    }
}
