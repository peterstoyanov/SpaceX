using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using SpaceX.Models;
using System;

namespace SpaceX.Services
{
    public class SpaceXLaunches
    {
        private const string spaceXData = "https://api.spacexdata.com/v3/launches/";

        public async Task<IEnumerable<Launch>> GetAll()
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, spaceXData);

                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    //return await response.Content.ReadFromJsonAsync<LaunchModel>();

                    string myJsonAsString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Launch>>(myJsonAsString);
                }

                else
                {
                    throw new ArgumentException($"There was an error while getting launches plans: {response.ReasonPhrase}");
                }
            }
        }
    }
}
