﻿using System.Runtime.InteropServices;
using System.Collections.Generic;
using SpaceX.Services.Mappers;
using System.Threading.Tasks;
using SpaceX.Services.Main;
using SpaceX.Services.DTOs;
using System.Net.Http;
using Newtonsoft.Json;
using SpaceX.Models;
using System.Linq;
using System;
using System.Reflection;

namespace SpaceX.Services.Contracts
{
    public class GetDataService : IGetDataService
    {
        private const string spaceXData = "https://api.spacexdata.com/v3/launches/";

        public GetDataService()
        {

        }


        public async Task<ICollection<LaunchDTO>> GetAllLaunchesAsync()
        {
            return await GetDataAsync();
        }

        public async Task<ICollection<LaunchDTO>> GetAllUpcomingsAsync()
        {
            return await GetDataAsync($"{spaceXData}" + "upcoming");
        }

        public async Task<LaunchDTO> GetLaunchByIdAsync(string flightNumber)
        {
            return (await GetDataAsync($"{spaceXData} + {flightNumber}"))
                .FirstOrDefault(x => x.FlightNumber == flightNumber);
        }

        public async Task<IEnumerable<string>> GetValidImages()
        {
            var images = (await GetDataAsync())
                         .Select(x => x.LinkImages.FirstOrDefault())
                         .Where(x => x != null)
                         .Take(20);
            return images;
        }

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
//var images = (await GetDataAsync())
//             .Select(x => x.LinkImages.FirstOrDefault())
//             .Where(x => x != null)
//             .Take(20);
