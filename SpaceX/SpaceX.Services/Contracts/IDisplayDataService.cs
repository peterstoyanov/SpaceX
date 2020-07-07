using System.Collections.Generic;
using SpaceX.Services.DTOs;
using SpaceX.Models;

namespace SpaceX.Services.Contracts
{
    public interface IDisplayDataService
    {
        ICollection<LaunchDTO> SortData(string sort, ICollection<LaunchDTO> data);

        ICollection<LaunchDTO> SearchData(string search, ICollection<LaunchDTO> data);

        ICollection<LaunchDTO> FilterData(ICollection<LaunchDTO> data, string mission, string rocketName, string rocketType);
    }
}