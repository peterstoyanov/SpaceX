using System.Collections.Generic;
using SpaceX.Services.Mappers;
using SpaceX.Services.DTOs;
using SpaceX.Models;
using System.Linq;
using System;

namespace SpaceX.Services.Contracts
{
    public class DisplayDataService : IDisplayDataService
    {
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
                switch (sort.ToLower())
                {
                    case "flight":
                        data = data.OrderBy(x => x.FlightNumber).ToList();
                        break;
                    case "flight_desc":
                        data = data.OrderByDescending(x => x.FlightNumber).ToList();
                        break;
                    case "mission":
                        data = data.OrderBy(x => x.MissionName).ToList();
                        break;
                    case "mission_desc":
                        data = data.OrderByDescending(x => x.MissionName).ToList();
                        break;
                    case "date":
                        data = data.OrderBy(x => x.LaunchDate).ToList();
                        break;
                    case "date_desc":
                        data = data.OrderByDescending(x => x.LaunchDate).ToList();
                        break;
                    case "rocketName":
                        data = data.OrderBy(x => x.RocketName).ToList();
                        break;
                    case "rocketName_desc":
                        data = data.OrderByDescending(x => x.RocketName).ToList();
                        break;
                    case "rocketType":
                        data = data.OrderBy(x => x.RocketType).ToList();
                        break;
                    case "rocketType_desc":
                        data = data.OrderByDescending(x => x.RocketType).ToList();
                        break;
                    default:
                        break;
                }
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

