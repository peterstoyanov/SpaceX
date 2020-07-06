using System.Collections.Generic;
using SpaceX.Services.Contracts;
using System.Threading.Tasks;
using SpaceX.Services.DTOs;
using Newtonsoft.Json;
using System.Net.Http;
using SpaceX.Models;
using System;
using SpaceX.Services.Mappers;

namespace SpaceX.Services
{
    public class SpaceXService : ISpaceXService
    {
        private const string spaceXData = "https://api.spacexdata.com/v3/launches/";

        public SpaceXService()
        {
        }

        public async Task<LaunchDTO> GetAllAsync()
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, spaceXData);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string myJsonAsString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Launch>(myJsonAsString).MapToDto();
                }

                else
                {
                    throw new ArgumentException($"There was an error while getting launches plans: {response.ReasonPhrase}");
                }
            }
        }
    }
}
