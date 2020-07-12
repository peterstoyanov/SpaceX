using SpaceX.Services.Contracts;
using System.Threading.Tasks;
using DinkToPdf;
using System.IO;
using System;

namespace SpaceX.Services.Main.Pdf
{
    public class PdfCreatorService : IPdfCreatorService
    {
        private readonly IHtmlService templateGenerator;

        public PdfCreatorService(IHtmlService templateGenerator)
        {
            this.templateGenerator = templateGenerator ?? throw new ArgumentNullException(nameof(templateGenerator));
        }
        /// <summary>
        /// Creates a PDF document by DinkToPDF Library
        /// </summary>
        /// <param name="flightNumber">The flight number for the certain launch</param>
        /// <returns>HtmlToPdfDocument</returns>
        public async Task<HtmlToPdfDocument> CreatePdf(string flightNumber)
        {
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = GlobSettings(),
                Objects = { await ObjSettingsAsync(flightNumber) }
            };

            return pdf;
        }

        /// <summary>
        /// The basic settings for PDF representations of data 
        /// </summary>
        /// <returns>GlobalSettings</returns>
        private GlobalSettings GlobSettings()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
            };

            return globalSettings;
        }

        /// <summary>
        /// Settings about Html content and CSS loading for a PDF
        /// </summary>
        /// <param name="flightNumber">The flight number for the certain launch</param>
        /// <returns></returns>
        private async Task<ObjectSettings> ObjSettingsAsync(string flightNumber)
        {
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = await templateGenerator.GetHTMLString(flightNumber),

                WebSettings = {
                    DefaultEncoding = "utf-8",
                    UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot/css", "launchList.css")
                },

                HeaderSettings = { Right = "Page [page] of [toPage]", Line = true },
            };

            return objectSettings;
        }
    }
}
