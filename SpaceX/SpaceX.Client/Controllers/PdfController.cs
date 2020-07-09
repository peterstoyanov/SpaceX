using SpaceX.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DinkToPdf.Contracts;
using System;

namespace SpaceX.Client.Controllers
{
    public class PdfController : ControllerBase
    {
        private readonly IPdfCreatorService pdfCreatorService;
        private readonly IConverter converter;

        public PdfController(IPdfCreatorService pdfCreatorService, IConverter converter)
        {
            this.pdfCreatorService = pdfCreatorService ?? throw new ArgumentNullException(nameof(pdfCreatorService));
            this.converter = converter ?? throw new ArgumentNullException(nameof(converter));
        }

        [HttpGet]
        public async Task<IActionResult> Create(int flightNumber)
        {
            var pdf = await pdfCreatorService.CreatePdf(flightNumber);
            var file = converter.Convert(pdf);
            return File(file, "application/pdf");
        }
    }
}
