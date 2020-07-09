using SpaceX.Services.Contracts;
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

        public string GetHTMLString()
        {
            var data = getDataService.GetAllAsync();

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

            foreach (var plan in data.Result)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                  </tr>", plan.MissionName, plan.LinkVideo, plan.LinkMissionPatch, plan.LinkImages);
            }

            sb.Append(@"
                                </table>
                            </body>
                        </html>");

            return sb.ToString();
        }
    }
}
