using System.Runtime.InteropServices;
using System.Collections.Generic;
using SpaceX.Services.Mappers;
using System.Threading.Tasks;
using SpaceX.Services.Main;
using SpaceX.Services.DTOs;
using System.Net.Http;
using Newtonsoft.Json;
using SpaceX.Models;
using System.Linq;

namespace SpaceX.Services.Contracts
{
    /// <summary>
    /// A class responsible only for getting data from API
    /// </summary>
    public class GetDataService : IGetDataService
    {
        private const string spaceXData = "https://api.spacexdata.com/v3/launches/";

        public GetDataService()
        {

        }

        /// <summary>
        /// Gets all launches data
        /// </summary>
        /// <returns>ICollection<LaunchDTO></returns>
        public async Task<ICollection<LaunchDTO>> GetAllLaunchesAsync()
        {
            return await GetDataAsync();
        }

        /// <summary>
        /// Gets all upcoming launches
        /// </summary>
        /// <returns>ICollection<LaunchDTO></returns>
        public async Task<ICollection<LaunchDTO>> GetAllUpcomingsAsync()
        {
            return await GetDataAsync($"{spaceXData}" + "upcoming");
        }

        /// <summary>
        /// Gets launch data by its flight number
        /// </summary>
        /// <param name="flightNumber">The flight number for the certain launch</param>
        /// <returns>LaunchDTO</returns>
        public async Task<LaunchDTO> GetLaunchByIdAsync(string flightNumber)
        {
            return (await GetDataAsync($"{spaceXData} + {flightNumber}"))
                .FirstOrDefault(x => x.FlightNumber == flightNumber);
        }

        /// <summary>
        /// Gets twenty images from non-empty collections
        /// </summary>
        /// <returns>IEnumerable<string></returns>
        public async Task<IEnumerable<string>> GetValidImages()
        {
            return (await GetDataAsync())
                         .Select(x => x.LinkImages.FirstOrDefault())
                         .Where(x => x != null)
                         .Take(20);
        }

        /// <summary>
        /// A private method that sends requests to API and deserializing response to DTO.
        /// </summary>
        /// <param name="address"></param>
        /// <returns>Optional parameter that extends information from API by given valid route address.></returns>
        private async Task<ICollection<LaunchDTO>> GetDataAsync([Optional] string address)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, spaceXData);
                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string myJsonAsString = await response.Content.ReadAsStringAsync();
                    var deserialize = JsonConvert.DeserializeObject<ICollection<Launch>>(myJsonAsString).MapToDtos();
                    client.Dispose();
                    deserialize.CheckCollection();
                    return deserialize;
                }

                else
                {
                    throw new HttpRequestException($"There was an error while getting data: {response.ReasonPhrase}");
                }
            }
        }
    }
}
