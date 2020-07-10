﻿using SpaceX.Services.Contracts;
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

        public async Task<string> GetHTMLString(int flightNumber)
        {
            var data = await getDataService.GetDataByIdAsync(flightNumber);
            return TemplateGenerator.ConvertStringToHtml(data);
        }
    }
}
