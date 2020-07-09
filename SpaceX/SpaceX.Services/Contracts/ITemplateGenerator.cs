using System.Threading.Tasks;

namespace SpaceX.Services.Contracts
{
    public interface ITemplateGenerator
    {
        Task<string> GetHTMLString(int flightNumber);
    }
}
