using System.Collections.Generic;
using SpaceX.Services.DTOs;

namespace SpaceX.Services.Contracts
{
    public interface IDisplayDataService
    {
        ICollection<LaunchDTO> SortData(string sort, ICollection<LaunchDTO> data);

        ICollection<LaunchDTO> SearchData(string search, ICollection<LaunchDTO> data);
    }
}