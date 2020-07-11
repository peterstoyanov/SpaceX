using System.Collections.Generic;
using System.Threading.Tasks;
using SpaceX.Services.DTOs;

namespace SpaceX.Services.Contracts
{
    public interface IGetDataService
    {
        Task<ICollection<LaunchDTO>> GetAllLaunchesAsync();
        Task<ICollection<LaunchDTO>> GetAllUpcomingsAsync();
        Task<IEnumerable<string>> GetValidImages();
        Task<LaunchDTO> GetLaunchByIdAsync(string flightNumber);
    }
}
