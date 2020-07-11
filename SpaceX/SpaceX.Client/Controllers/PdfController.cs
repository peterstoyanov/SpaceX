using Microsoft.AspNetCore.Http;
using SpaceX.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DinkToPdf.Contracts;
using System;

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

        /// <summary>
        /// Gets PDF document which is creating dynamically.
        /// </summary>
        /// <param name="id">The id of the certain launch.</param>
        /// <returns>On success - The file of certain launch details.</returns>
        /// <response code="200">Returns file of certain launch details.</response>
        /// <response code="404">If id or the launch is null - NotFound.</response>
        // GET: Pdf/Get/5
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return NotFound("The entity with the given id is Not Found");
            }

            var pdf = await pdfCreatorService.CreatePdf(id);
            var file = converter.Convert(pdf);
            return File(file, "application/pdf");
        }
    }
}
