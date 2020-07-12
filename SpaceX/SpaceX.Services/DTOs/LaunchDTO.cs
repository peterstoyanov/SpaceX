using System.Collections.Generic;
using System;

namespace SpaceX.Services.DTOs
{
    public class LaunchDTO
    {
        public string FlightNumber { get; set; }
        public string MissionName { get; set; }
        public DateTime LaunchDate { get; set; }

        public string RocketId { get; set; }
        public string RocketName { get; set; }
        public string RocketType { get; set; }

        public string CoreSerial { get; set; }
        public string Flight { get; set; }
        public string Block { get; set; }

        public string PayloadId { get; set; }
        public string Nationality { get; set; }
        public string Manufacturer { get; set; }
        public string PayloadType { get; set; }
        public string PayloadMassKg { get; set; }
        public string PayloadMassLbs { get; set; }
        public string Orbit { get; set; }

        public string ReferenceSystem { get; set; }
        public string Regime { get; set; }

        public string SiteId { get; set; }
        public string SiteName { get; set; }
        public string SiteNameLong { get; set; }
        public string LinkMissionPatch { get; set; }
        public string LinkMissionPatchSmall { get; set; }
        public string LinkArticle { get; set; }
        public string YouTubeId { get; set; }
        public string Webcast { get; set; }
        public IEnumerable<string> LinkImages { get; set; }

        public string Details { get; set; }
    }
}
