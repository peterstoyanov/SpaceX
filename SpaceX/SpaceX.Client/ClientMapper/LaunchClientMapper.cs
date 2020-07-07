using System.Collections.Generic;
using SpaceX.Client.Models;
using SpaceX.Services.DTOs;
using System.Linq;

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
                LinkMissionPatch = modelDto.LinkMissionPatch,
                LinkMissionPatchSmall = modelDto.LinkMissionPatchSmall,
                LinkArticle = modelDto.LinkArticle,
                LinkVideo = modelDto.LinkVideo,
                LinkImages = modelDto.LinkImages,
                Details = modelDto.Details,
            };
        }

        public static ICollection<LaunchViewModel> MapToVMs(this ICollection<LaunchDTO> models)
             => models.Select(MapToVM).ToList();
    }
}
