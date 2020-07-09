using System.Threading.Tasks;
using DinkToPdf;

namespace SpaceX.Services.Contracts
{
    public interface IPdfCreatorService
    {
        HtmlToPdfDocument CreatePdf();
    }
}