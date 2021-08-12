using Google.Type;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    class ResolvedIssues
    {
        public int issue_id { get; set; }
        public string issueStatement { get; set; }
        public string Location_name { get; set; }
        private string issuedate;

        public string Issuedate 
        {
            get { return issuedate; }
            set 
            {
                issuedate = value.ToString();
            }
        }
        //public System.DateTime resolveddate { get; set; }
        public static async Task<List<ResolvedIssues>> getallresolvedissues()
        {
            HttpClient client = new HttpClient();
            string uri = User.baseuri + "/api/admin/fetchallresolvedissues";

            var response = await client.GetStringAsync(uri);

            var content = JsonConvert.DeserializeObject<List<WindowsFormsApp4.Model.ResolvedIssues>>(response);
            return content;

        }
    }
}
