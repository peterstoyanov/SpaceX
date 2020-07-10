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
                                        <th>Rocket Name</th>
                                        <td>{launchDTO.RocketName}<td>
                                    </tr>
                                    <tr>
                                        <th>Rocket Type</th>
                                        <td>{launchDTO.RocketType}</td>
                                    </tr>
                                     <tr>
                                        <th>Details</th>
                                        <td>{launchDTO.Details}</td>
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

//sb.AppendLine("<div> <a style=\"text-decoration:none;border:1px solid #333;\" href ='' >Add to Calendar<img height ='25' width='25' src='calendar.png' alt='logo' /></ a ></div>");
//string pathToHTMLFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/pdfTemplate.cshtml");
// string htmlString = File.ReadAllText(pathToHTMLFile);