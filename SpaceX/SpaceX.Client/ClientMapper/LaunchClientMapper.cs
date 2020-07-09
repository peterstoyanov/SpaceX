using System.Collections.Generic;
using SpaceX.Client.Models;
using SpaceX.Services.DTOs;
using System.Linq;

namespace SpaceX.Client.ClientMapper
{
    public static class LaunchClientMapper
    {
        public static DataViewModel MapToVM(this LaunchDTO modelDto)
        {
            return new DataViewModel
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
                YouTubeLink = modelDto.YouTubeLink,
                YouTubeId = modelDto.YouTubeId,
                LinkImages = modelDto.LinkImages,
                Details = modelDto.Details,
            };
        }

        public static ICollection<DataViewModel> MapToVMs(this ICollection<LaunchDTO> models)
             => models.Select(MapToVM).ToList();
    }
}
