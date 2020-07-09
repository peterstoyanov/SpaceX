using System.Collections.Generic;
using SpaceX.Services.Mappers;
using System.Threading.Tasks;
using SpaceX.Services.Main;
using SpaceX.Services.DTOs;
using System.Net.Http;
using Newtonsoft.Json;
using SpaceX.Models;
using System;

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
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, spaceXData);
                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string myJsonAsString = await response.Content.ReadAsStringAsync();
                    var deserialize = JsonConvert.DeserializeObject<ICollection<Launch>>(myJsonAsString).MapToDtos();
                    deserialize.CheckCollection();
                    return deserialize;
                }

                else
                {
                    throw new ArgumentException($"There was an error while getting launches plans: {response.ReasonPhrase}");
                }
            }
        }
    }
}
