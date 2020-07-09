using SpaceX.Services.Contracts;
using System.Threading.Tasks;
using System.Text;
using System;

namespace SpaceX.Services.Main.Pdf
{
    public sealed class TemplateGenerator : ITemplateGenerator
    {
        private readonly IGetDataService getDataService;

        public TemplateGenerator(IGetDataService getDataService)
        {
            this.getDataService = getDataService ?? throw new ArgumentNullException(nameof(getDataService));
        }

        public async Task<string> GetHTMLString(int flightNumber)
        {
            var data = await getDataService.GetDataByIdAsync(flightNumber);

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>This is the generated PDF launch plans!!!</h1></div>
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
                                  </tr>", data.MissionName, data.LinkVideo, data.LinkMissionPatch, data.LinkImages);
            

            sb.Append(@"
                                </table>
                            </body>
                        </html>");

            return sb.ToString();
        }
    }
}
