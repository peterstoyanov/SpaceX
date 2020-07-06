using System.Collections.Generic;
using System.Threading.Tasks;
using SpaceX.Services.DTOs;

namespace SpaceX.Services.Contracts
{
    public interface ISpaceXService
    {
        Task<LaunchDTO> GetAllAsync();
    }
}
