using System.Collections.Generic;
using SpaceX.Services.DTOs;
using SpaceX.Models;
using System.Linq;
using System;

namespace SpaceX.Services.Mappers
{
    /// <summary>
    /// Used to map from Launch => LaunchDTO
    /// </summary>
    public static class LaunchMapper
    {
        public static LaunchDTO MapToDto(this Launch model)
        {
            if (model == null)
            {
                throw new ArgumentNullException();
            }
            return new LaunchDTO
            {
                FlightNumber = model.FlightNumber,
                MissionName = model.MissionName,
                LaunchDate = model.LaunchDate,
                LaunchSuccess = model.LaunchSuccess,
                RocketId = model.Rocket.Id,
                RocketName = model.Rocket.Name,
                RocketType = model.Rocket.Type,
                LinkMissionPatch = model.Links.MissionPatch,
                LinkMissionPatchSmall = model.Links.MissionPatchSmall,
                LinkArticle = model.Links.Article,
                LinkVideo = model.Links.Video,
                LinkImages = model.Links.Images,
                Details = model.Details,
            };
        }

        public static ICollection<LaunchDTO> MapToDtos(this ICollection<Launch> models)
             => models.Select(MapToDto).ToList();
    }
}
