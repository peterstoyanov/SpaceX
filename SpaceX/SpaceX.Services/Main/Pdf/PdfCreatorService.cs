using SpaceX.Services.Contracts;
using DinkToPdf;
using System.IO;
using System;

namespace SpaceX.Services.Main.Pdf
{
    public class PdfCreatorService : IPdfCreatorService
    {
        private readonly ITemplateGenerator templateGenerator;

        public PdfCreatorService(ITemplateGenerator templateGenerator)
        {
            this.templateGenerator = templateGenerator ?? throw new ArgumentNullException(nameof(templateGenerator));
        }

        public HtmlToPdfDocument CreatePdf()
        {
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = GlobSettings(),
                Objects = { ObjSettings() }
            };

            return pdf;
        }

        private GlobalSettings GlobSettings()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
            };

            return globalSettings;
        }

        private ObjectSettings ObjSettings()
        {
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = templateGenerator.GetHTMLString(),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/css", "pdfDesign.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };

            return objectSettings;
        }
    }
}
