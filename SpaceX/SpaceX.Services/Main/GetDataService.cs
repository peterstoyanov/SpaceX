using System.Runtime.InteropServices;
using System.Collections.Generic;
using SpaceX.Services.Mappers;
using System.Threading.Tasks;
using SpaceX.Services.Main;
using SpaceX.Services.DTOs;
using System.Net.Http;
using Newtonsoft.Json;
using SpaceX.Models;

namespace SpaceX.Services.Contracts
{
    public class GetDataService : IGetDataService
    {
        private const string spaceXData = "https://api.spacexdata.com/v3/launches/";

        public GetDataService()
        {

        }

        public async Task<ICollection<LaunchDTO>> GetAllAsync()
        {
            return await GetData();
        }

        public async Task<ICollection<LaunchDTO>> GetDataById(int flightNumber)
        {
            return await GetData($"{spaceXData} + {flightNumber}");
        }

        private async Task<ICollection<LaunchDTO>> GetData([Optional] string address)
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
