using SpaceX.Services.DTOs;
using System.Text;

namespace SpaceX.Services.Main.Pdf
{
    public static class TemplateGenerator
    {
        public static string ConvertStringToHtml(LaunchDTO launchDTO)
        {
            var sb = new StringBuilder();

            sb.AppendFormat($@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>""{launchDTO.MissionName}""</h1>
                                  <h3>SpaceX Official information about launches</h3>
                                </div>
                                <table class=""table"">
                                 <thead>
                                     <tr>
                                       <th colspan=""2""></th>
                                     </tr>
                                 </thead>
                                 <tbody>
                                     <tr>
                                        <th>Mission Patch</th>
                                        <td><img src=""{launchDTO.LinkMissionPatchSmall}""/></td>
                                    </tr>
                                     <tr>
                                        <th>Flight Number</th>
                                        <td>{launchDTO.FlightNumber}</td>
                                    </tr>
                                      <tr>
                                        <th>Launch Date</th>
                                        <td>{launchDTO.LaunchDate}</td>
                                    </tr>
                                     <tr>
                                        <th>Rocket Id</th>
                                        <td>{launchDTO.RocketId}<td>
                                    </tr>
                                     <tr>
                                        <th>Rocket Name</th>
                                        <td>{launchDTO.RocketName}<td>
                                    </tr>
                                    <tr>
                                        <th>Rocket Type</th>
                                        <td>{launchDTO.RocketType}</td>
                                    </tr>
                                     <tr>
                                        <th>Core Serial</th>
                                        <td>{launchDTO.CoreSerial}</td>
                                    </tr>
                                      <tr>
                                        <th>Flight</th>
                                        <td>{launchDTO.Flight}</td>
                                    </tr>
                                     <tr>
                                        <th>Block</th>
                                        <td>{launchDTO.Block}<td>
                                    </tr>
                                     <tr>
                                        <th>Payload Id</th>
                                        <td>{launchDTO.PayloadId}</td>
                                    </tr>
                                     <tr>
                                        <th>Nationality</th>
                                        <td>{launchDTO.Nationality}<td>
                                    </tr>
                                     <tr>
                                        <th>Manufacturer</th>
                                        <td>{launchDTO.Manufacturer}<td>
                                    </tr>
                                    <tr>
                                        <th>Payload Type</th>
                                        <td>{launchDTO.PayloadType}</td>
                                    </tr>
                                     <tr>
                                        <th>Payload Mass Kg</th>
                                        <td>{launchDTO.PayloadMassKg}</td>
                                    </tr>
                                      <tr>
                                        <th>Payload Mass Lbs</th>
                                        <td>{launchDTO.PayloadMassLbs}</td>
                                    </tr>
                                     <tr>
                                        <th>Block</th>
                                        <td>{launchDTO.Block}<td>
                                    </tr>
                                     <tr>
                                        <th>Orbit</th>
                                        <td>{launchDTO.Orbit}<td>
                                    </tr>
                                    <tr>
                                        <th>Reference System</th>
                                        <td>{launchDTO.ReferenceSystem}</td>
                                    </tr>
                                     <tr>
                                        <th>Regime</th>
                                        <td>{launchDTO.Regime}</td>
                                    </tr>
                                      <tr>
                                        <th>Site Id</th>
                                        <td>{launchDTO.SiteId}</td>
                                    </tr>
                                     <tr>
                                        <th>Site Name</th>
                                        <td>{launchDTO.SiteName}<td>
                                    </tr>
                                     <tr>
                                        <th>Site Name Long</th>
                                        <td>{launchDTO.SiteNameLong}<td>
                                    </tr>
                                     <tr>
                                        <th>Details</th>
                                        <td>{launchDTO.Details}</td>
                                    </tr>
                                     <tr>
                                        <th>Link Article</th>
                                        <td>
                                          <a href=""{launchDTO.LinkArticle}"">See article</a>
                                       </td>
                                    </tr>
                                  </tbody>");
            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}

    //foreach (var item in launchDTO as IEnumerable<LaunchDTO>)
    //        {
    //            sb.Append($@"
    //                          <tr>
    //                             <th>""{item.ToString()}""</th>
    //                             <td>""{item}""<td>
    //                          </tr>");
    //        }