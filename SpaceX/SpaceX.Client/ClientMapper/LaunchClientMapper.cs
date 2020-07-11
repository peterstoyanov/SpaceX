using System.Collections.Generic;
using SpaceX.Client.Models;
using SpaceX.Services.DTOs;
using System.Linq;

namespace SpaceX.Client.ClientMapper
{
    public static class LaunchClientMapper
    {
        public static DataViewModel MapToDM(this LaunchDTO modelDto)
        {
            return new DataViewModel
            {
                FlightNumber = modelDto.FlightNumber,
                MissionName = modelDto.MissionName,
                LaunchDate = modelDto.LaunchDate,
                RocketId = modelDto.RocketId,
                RocketName = modelDto.RocketName,
                RocketType = modelDto.RocketType,
                CoreSerial = modelDto.CoreSerial,
                Flight = modelDto.Flight,
                Block = modelDto.Block,
                PayloadId = modelDto.PayloadId,
                Nationality = modelDto.Nationality,
                Manufacturer = modelDto.Manufacturer,
                PayloadType = modelDto.PayloadType,
                PayloadMassKg = modelDto.PayloadMassKg,
                PayloadMassLbs = modelDto.PayloadMassLbs,
                Orbit = modelDto.Orbit,
                ReferenceSystem = modelDto.ReferenceSystem,
                Regime = modelDto.Regime,
                SiteId = modelDto.SiteId,
                SiteName = modelDto.SiteName,
                SiteNameLong = modelDto.SiteNameLong,
                LinkMissionPatch = modelDto.LinkMissionPatch,
                LinkMissionPatchSmall = modelDto.LinkMissionPatchSmall,
                LinkArticle = modelDto.LinkArticle,
                YouTubeId = modelDto.YouTubeId,
                LinkImages = modelDto.LinkImages,
                Details = modelDto.Details,
            };
        }

        public static ICollection<DataViewModel> MapToVMs(this ICollection<LaunchDTO> models)
             => models.Select(MapToDM).ToList();
    }
}
