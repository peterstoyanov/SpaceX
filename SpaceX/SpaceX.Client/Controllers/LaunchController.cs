using SpaceX.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace SpaceX.Client.Controllers
{
    public class LaunchController : Controller
    {
        private readonly ISpaceXService _spaceXService;

        public LaunchController(ISpaceXService _spaceXService)
        {
            this._spaceXService = _spaceXService ?? throw new ArgumentNullException(nameof(_spaceXService));
        }

        [HttpGet]
        public async Task<IActionResult> GetPlans()
        {
            var plans = await _spaceXService.GetAllAsync();
            return Ok(plans);
        }

    }
}
