using SpaceX.Client.ClientMapper;
using SpaceX.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace SpaceX.Client.Controllers
{
    public class LaunchController : Controller
    {
        private readonly ISpaceXService spaceXService;

        public LaunchController(ISpaceXService spaceXService)
        {
            this.spaceXService = spaceXService ?? throw new ArgumentNullException(nameof(spaceXService));
        }

        [HttpGet]
        public async Task<IActionResult> GetPlans()
        {
            var plans = (await spaceXService.GetAllAsync()).MapToVMs();

            return Ok(plans);
        }

    }
}
