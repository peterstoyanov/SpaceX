using SpaceX.Client.ClientMapper;
using SpaceX.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SpaceX.Client.Models;
using System.Diagnostics;
using X.PagedList;
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

        /// <summary>
        /// Get all launches
        /// </summary>
        /// <param name="searchString">A string to search for.</param>
        /// <param name="sortOption">A string to sort by.</param>
        /// <param name="page">An int page number.</param>
        /// <returns></returns>
        /// <returns>On success - View with launches(in a paged list).</returns>
        /// <response code="200">Returns All Launches(in a paged list).</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Index(string searchString, string sortOption, int page = 1)
        {
            int pageSize = 1;
            var plans = await getDataService.GetAllLaunchesAsync();
            plans = displayDataService.SearchData(searchString, plans);
            plans = displayDataService.SortData(sortOption, plans);

            bool isAjax = HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";

            return isAjax ? (IActionResult)PartialView("LaunchList", plans.MapToVMs().ToPagedList(page, pageSize))
                 : View(plans.MapToVMs().ToPagedList(page, pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> Images()
        {
            var images = (await getDataService.GetValidImages());
            ViewBag.AllImages = images;
            return View(images);
        }

        /// <summary>
        /// Load Error Page
        /// </summary>
        /// <returns>On success - View</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
