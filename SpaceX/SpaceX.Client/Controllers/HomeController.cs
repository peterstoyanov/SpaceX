using SpaceX.Client.ClientMapper;
using SpaceX.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SpaceX.Client.Models;
using System.Diagnostics;
using X.PagedList;
using System.Linq;
using System;

namespace SpaceX.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetDataService getDataService;
        private readonly IDisplayDataService displayDataService;

        public HomeController(IGetDataService getDataService, IDisplayDataService displayDataService)
        {
            this.getDataService = getDataService ?? throw new ArgumentNullException(nameof(getDataService));
            this.displayDataService = displayDataService ?? throw new ArgumentNullException(nameof(displayDataService));
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Index(string sort, string search, string mission, string rocketName, string rocketType, int? pageNumber)
        {
            var plans = await getDataService.GetAllAsync();

            //Sort
            plans = displayDataService.SortData(sort, plans).ToList();
            //Search
            plans = displayDataService.SearchData(search, plans).ToList();
            //Filter
            plans = displayDataService.FilterData(plans, mission, rocketName, rocketType).ToList();

            ViewData["CurrentSort"] = sort;
            ViewData["SortByFlight"] = sort == "flight" ? "flight_desc" : "flight";
            ViewData["SortByMission"] = sort == "mission" ? "mission_desc" : "mission";
            ViewData["SortByDate"] = sort == "date" ? "date_desc" : "date";
            ViewData["SortByRocketName"] = sort == "rocketName" ? "rocketName_desc" : "rocketName";
            ViewData["SortByRocketType"] = sort == "rocketType" ? "rocketType_asc" : "rocketType";
            ViewData["PageNumber"] = pageNumber;
            ViewData["Search"] = search;
            ViewData["ResultsCount"] = plans.Count;

            int pageSize = 8;
            return View(await plans.MapToVMs().ToPagedListAsync(pageNumber ?? 1, pageSize));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
