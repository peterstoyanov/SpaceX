using System.Threading.Tasks;
using DinkToPdf;

namespace SpaceX.Services.Contracts
{
    public interface IPdfCreatorService
    {
        Task<HtmlToPdfDocument> CreatePdf(string flightNumber);
    }
}