using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    class Volunteer_Report
    {
        public int report_id { get; set; }
        public string volunteer_name { get; set; }
        public string report { get; set; }
        public int volunteer_id { get; set; }
        public int issue_id { get; set; }

        internal static async Task<List<Model.Volunteer_Report>> getallreports()
        {
            HttpClient client = new HttpClient();
            var uri = Model.User.baseuri + "/api/volunteer/getallvolunteerreports";
            var response = await client.GetStringAsync(uri);
            var list = JsonConvert.DeserializeObject<List<Model.Volunteer_Report>>(response);
            return list;

        }
    }
}
