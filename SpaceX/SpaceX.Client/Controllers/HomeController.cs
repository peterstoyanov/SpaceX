using Microsoft.Extensions.Logging;
using SpaceX.Client.ClientMapper;
using SpaceX.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SpaceX.Client.Models;
using System.Diagnostics;
using System;

namespace SpaceX.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly ISpaceXService spaceXService;
        public HomeController(ILogger<HomeController> logger, ISpaceXService spaceXService)
        {
            this.logger = logger;
            this.spaceXService = spaceXService ?? throw new ArgumentNullException(nameof(spaceXService));
        }

        public async Task<IActionResult> Index()
        {
            await GetPlans();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetPlans()
        {
            var plans = (await spaceXService.GetAllAsync()).MapToVMs();
            return View(plans);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
