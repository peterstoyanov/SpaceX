using System.Collections.Generic;
using SpaceX.Services.Main;
using SpaceX.Services.DTOs;
using SpaceX.Models;
using System.Linq;

namespace SpaceX.Services.Mappers
{
    public static class LaunchMapper
    {
        /// <summary>
        /// Maps a LaunchDTO from an existing entities from API.
        /// Checks every entity for an empty results.
        /// </summary>
        /// <param name="model">The target Launch Entity</param>
        /// <returns>LaunchDTO</returns>
        public static LaunchDTO MapToDto(this Launch model)
        {
            const string msg = "Information is not available because is missing from the SpaceX API";
            return new LaunchDTO
            {
                FlightNumber = Validator.EmptyIfNull(model.FlightNumber, msg),
                MissionName = model.MissionName ?? msg,
                LaunchDate = model.LaunchDate,
                RocketId = model.Rocket.Id ?? msg,
                RocketName = model.Rocket.Name ?? msg,
                RocketType = model.Rocket.Type ?? msg,
                CoreSerial = model.Rocket.FirstStage.Cores[0].CoreSerial ?? msg,
                Flight = Validator.EmptyIfNull(model.Rocket.FirstStage.Cores[0].Flight, msg),
                Block = Validator.EmptyIfNull(model.Rocket.SecondStage.Block, msg),
                PayloadId = model.Rocket.SecondStage.Payloads[0].PayloadId ?? msg,
                Nationality = model.Rocket.SecondStage.Payloads[0].Nationality ?? msg,
                Manufacturer = model.Rocket.SecondStage.Payloads[0].Manufacturer ?? msg,
                PayloadType = model.Rocket.SecondStage.Payloads[0].PayloadId ?? msg,
                PayloadMassKg = Validator.EmptyIfNull(model.Rocket.SecondStage.Payloads[0].PayloadMassKg, msg),
                PayloadMassLbs = Validator.EmptyIfNull(model.Rocket.SecondStage.Payloads[0].PayloadMassLbs, msg),
                Orbit = model.Rocket.SecondStage.Payloads[0].Orbit ?? msg,
                ReferenceSystem = model.Rocket.SecondStage.Payloads[0].orbit_params.ReferenceSystem ?? msg,
                Regime = model.Rocket.SecondStage.Payloads[0].orbit_params.Regime ?? msg,
                SiteId = model.LaunchSite.SiteId ?? msg,
                SiteName = model.LaunchSite.SiteName ?? msg,
                SiteNameLong = model.LaunchSite.SiteNameLong ?? msg,
                LinkMissionPatch = model.Links.MissionPatch ?? "/img/missingInfo.jpg",
                LinkMissionPatchSmall = model.Links.MissionPatchSmall ?? "/img/missingInfo.jpg",
                LinkArticle = model.Links.Article ?? msg,
                YouTubeId = model.Links.YouTubeId ?? "/img/youtube.png",
                Webcast = model.Links.Webcast ?? "/img/youtube.png",
                LinkImages = model.Links.Images,
                Details = model.Details ?? msg,
            };
        }

        /// <summary>
        /// Maps a collection of Launch to the collection of LaunchDTO
        /// </summary>
        /// <param name="models">The target Launch Entity</param>
        /// <returns>ICollection<LaunchDTO></returns>
        public static ICollection<LaunchDTO> MapToDtos(this ICollection<Launch> models)
             => models.Select(MapToDto).ToList();
    }
}
