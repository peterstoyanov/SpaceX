using SpaceX.Services.Contracts;
using System.Threading.Tasks;
using System;

namespace SpaceX.Services.Main.Pdf
{
    public sealed class HtmlService : IHtmlService
    {
        private readonly IGetDataService getDataService;

        public HtmlService(IGetDataService getDataService)
        {
            this.getDataService = getDataService ?? throw new ArgumentNullException(nameof(getDataService));
        }

        /// <summary>
        /// Gets HTML data by its given flight number
        /// </summary>
        /// <param name="flightNumber">The flight number for the certain launch</param>
        /// <returns>string</returns>
        public async Task<string> GetHTMLString(string flightNumber)
        {
            var data = await getDataService.GetLaunchByIdAsync(flightNumber);
            return TemplateGenerator.ConvertStringToHtml(data);
        }
    }
}
