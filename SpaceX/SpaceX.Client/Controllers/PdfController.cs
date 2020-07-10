using SpaceX.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DinkToPdf.Contracts;
using System;
using DinkToPdf;
using SpaceX.Client.Utilities;
using SpaceX.Client.ClientMapper;

namespace SpaceX.Client.Controllers
{
    public class PdfController : Controller
    {
        private readonly IPdfCreatorService pdfCreatorService;
        private readonly IConverter converter;

        public PdfController(IPdfCreatorService pdfCreatorService, IConverter converter)
        {
            this.pdfCreatorService = pdfCreatorService ?? throw new ArgumentNullException(nameof(pdfCreatorService));
            this.converter = converter ?? throw new ArgumentNullException(nameof(converter));
        }


        public async Task<IActionResult> Create(int id)
        {
            var pdf = await pdfCreatorService.CreatePdf(id);
            var file = converter.Convert(pdf);
            return File(file, "application/pdf");
        }
    }
}
