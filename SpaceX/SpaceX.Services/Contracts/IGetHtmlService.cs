using System.Threading.Tasks;

namespace SpaceX.Services.Contracts
{
    public interface IHtmlService
    {
        Task<string> GetHTMLString(string flightNumber);
    }
}
