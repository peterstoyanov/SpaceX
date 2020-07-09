using System.Collections.Generic;
using System.Threading.Tasks;
using SpaceX.Services.DTOs;

namespace SpaceX.Services.Contracts
{
    public interface IGetDataService
    {
        Task<ICollection<LaunchDTO>> GetAllDataAsync();

        Task<LaunchDTO> GetDataByIdAsync(int flightNumber);
    }
}
