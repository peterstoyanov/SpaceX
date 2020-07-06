using SpaceX.Client.Models;
using SpaceX.Services.DTOs;

namespace SpaceX.Client.ClientMapper
{
    public static class LaunchClientMapper
    {
        public static LaunchViewModel MapToVM(this LaunchDTO modelDto)
        {
            return new LaunchViewModel
            {
                FlightNumber = modelDto.FlightNumber,
                MissionName = modelDto.MissionName,
                LaunchDate = modelDto.LaunchDate,
                LaunchSuccess = modelDto.LaunchSuccess,
                RocketId = modelDto.RocketId,
                RocketName = modelDto.RocketName,
                RocketType = modelDto.RocketType,
                FailureTime = modelDto.FailureTime,
                FailureAltitude = modelDto.FailureAltitude,
                FailureReason = modelDto.FailureReason,
                LinkMissionPatch = modelDto.LinkMissionPatch,
                LinkMissionPatchSmall = modelDto.LinkMissionPatchSmall,
                LinkArticle = modelDto.LinkArticle,
                LinkVideo = modelDto.LinkVideo,
                LinkImages = modelDto.LinkImages,
                Details = modelDto.Details,
            };
        }

        public static LaunchDTO MapToBreweryDTO(this LaunchViewModel modelVM)
        {
            return new LaunchDTO
            {
                FlightNumber = modelVM.FlightNumber,
                MissionName = modelVM.MissionName,
                LaunchDate = modelVM.LaunchDate,
                LaunchSuccess = modelVM.LaunchSuccess,
                RocketId = modelVM.RocketId,
                RocketName = modelVM.RocketName,
                RocketType = modelVM.RocketType,
                FailureTime = modelVM.FailureTime,
                FailureAltitude = modelVM.FailureAltitude,
                FailureReason = modelVM.FailureReason,
                LinkMissionPatch = modelVM.LinkMissionPatch,
                LinkMissionPatchSmall = modelVM.LinkMissionPatchSmall,
                LinkArticle = modelVM.LinkArticle,
                LinkVideo = modelVM.LinkVideo,
                LinkImages = modelVM.LinkImages,
                Details = modelVM.Details,
            };
        }
    }
}
