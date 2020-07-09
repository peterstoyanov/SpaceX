using SpaceX.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using DinkToPdf.Contracts;
using System;

namespace SpaceX.Client.Controllers
{
    public class CreatePdfController : ControllerBase
    {
        private readonly IPdfCreatorService pdfCreatorService;
        private readonly IConverter converter;

        public CreatePdfController(IPdfCreatorService pdfCreatorService, IConverter converter)
        {
            this.pdfCreatorService = pdfCreatorService ?? throw new ArgumentNullException(nameof(pdfCreatorService));
            this.converter = converter ?? throw new ArgumentNullException(nameof(converter));
        }

        public IActionResult CreatePDF()
        {
            var pdf = pdfCreatorService.CreatePdf();
            var file = converter.Convert(pdf);
            return File(file, "application/pdf");
        }
    }
}
