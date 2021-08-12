using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    class Report
    {
        public int report_id { get; set; }
        public int user_ID { get; set; }
        public int issue_id { get; set; }
        public string report_text { get; set; }
        public string status { get; set; }
        public string admin_reply { get; set; }

        public static async Task<List<Report>> getallreports()
        {
            HttpClient client = new HttpClient();
            string uri = Model.User.baseuri + "/api/admin/fetchallreports";
            var response = await client.GetStringAsync(uri);
            var content = JsonConvert.DeserializeObject<List<Model.Report>>(response);
            return content;


    }
}
}
