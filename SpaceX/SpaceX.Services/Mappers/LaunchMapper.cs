using SpaceX.Services.DTOs;
using SpaceX.Models;

namespace SpaceX.Services.Mappers
{
    /// <summary>
    /// Used to map from Launch => LaunchDTO
    /// </summary>
    public static class LaunchMapper
    {
        public static LaunchDTO MapToDto(this Launch model)
        {
            return new LaunchDTO
            {
                FlightNumber = model.FlightNumber,
                MissionName = model.MissionName,
                LaunchDate = model.LaunchDate,
                LaunchSuccess = model.LaunchSuccess,
                RocketId = model.Rocket.Id,
                RocketName = model.Rocket.Name,
                RocketType = model.Rocket.Type,
                FailureTime = model.FailureDetails.Time,
                FailureAltitude = model.FailureDetails.Altitude,
                FailureReason = model.FailureDetails.Reason,
                LinkMissionPatch = model.Links.MissionPatch,
                LinkMissionPatchSmall = model.Links.MissionPatchSmall,
                LinkArticle = model.Links.Article,
                LinkVideo = model.Links.Video,
                LinkImages = model.Links.Images,
                Details = model.Details,
            };
        }


    }
}
