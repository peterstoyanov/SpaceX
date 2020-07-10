using SpaceX.Services.DTOs;
using System.Text;

namespace SpaceX.Services.Main.Pdf
{
    public static class TemplateGenerator
    {
        public static string ConvertStringToHtml(LaunchDTO launchDTO)
        {
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'>SpaceX Official information about launches<h1></h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>Name</th>
                                        <th>LastName</th>
                                        <th>Age</th>
                                        <th>Gender</th>
                                    </tr>");

            sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                    <td>
                                  </tr>",

                              launchDTO.MissionName,
                              launchDTO.YouTubeLink,
                              launchDTO.LinkMissionPatch,
                              launchDTO.LinkImages);


            sb.Append(@"
                                </table>
                            </body>
                        </html>");

            return sb.ToString();
        }
    }
}
