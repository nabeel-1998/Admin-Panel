using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Controls
{
    class ReportControl
    {
       public static async Task<List<Model.Report>> reportdata()
       {
            var list = await Model.Report.getallreports();
            return list;
       }

        public async static Task<List<Model.Volunteer_Report>> VolunteerReportData()
        {
            var list = await Model.Volunteer_Report.getallreports();
            return list;
        }

        public async static Task<List<Model.Feedback>> getallfeedback()
        {
            HttpClient client = new HttpClient();
            var uri = Model.User.baseuri + "/api/admin/getallfeedback";
            var response = await client.GetStringAsync(uri);
            var list = JsonConvert.DeserializeObject<List<Model.Feedback>>(response);
            if(list!=null)
            {
                return list;
            }
            return null;

        }
    }
}
