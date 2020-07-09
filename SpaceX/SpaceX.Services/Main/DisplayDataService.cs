using System.Collections.Generic;
using SpaceX.Services.DTOs;
using System.Linq;
using System;

namespace SpaceX.Services.Contracts
{
    public class DisplayDataService : IDisplayDataService
    {
        public DisplayDataService()
        {
        }

        /// <summary>
        /// Sorts a collection of Launch Data a given property.
        /// </summary>
        /// <param name="sort">The property to sort.</param>
        /// <param name="data">The target collection of Launch Data.</param>
        /// <returns>ICollection of LaunchDTO.</returns>
        public ICollection<LaunchDTO> SortData(string sort, ICollection<LaunchDTO> data)
        {
            if (sort != null)
            {
                data = (sort.ToLower()) switch
                {
                    "flight" => data.OrderBy(x => x.FlightNumber).ToList(),
                    "flight_desc" => data.OrderByDescending(x => x.FlightNumber).ToList(),
                    "mission" => data.OrderBy(x => x.MissionName).ToList(),
                    "mission_desc" => data.OrderByDescending(x => x.MissionName).ToList(),
                    "date" => data.OrderBy(x => x.LaunchDate).ToList(),
                    "date_desc" => data.OrderByDescending(x => x.LaunchDate).ToList(),
                    "rocketName" => data.OrderBy(x => x.RocketName).ToList(),
                    "rocketName_desc" => data.OrderByDescending(x => x.RocketName).ToList(),
                    "rocketType" => data.OrderBy(x => x.RocketType).ToList(),
                    "rocketType_desc" => data.OrderByDescending(x => x.RocketType).ToList(),
                    _ => data.OrderBy(p => p.FlightNumber).ToList(),
                };
            }
            return data;
        }

        /// <summary>
        /// Searches a collection of Launch Data by its Mission Name.
        /// </summary>
        /// <param name="search">The search query string.</param>
        /// <param name="data">The target collection of Launch Data.</param>
        /// <returns>ICollection of LaunchDTO.</returns>
        public ICollection<LaunchDTO> SearchData(string search, ICollection<LaunchDTO> data)
        {
            if (!String.IsNullOrEmpty(search))
            {
                data = data.Where(r => r.MissionName.ToLower().Contains(search.ToLower())).ToList();
            }
            return data;
        }
    }
}

