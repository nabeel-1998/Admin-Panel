using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.Model
{
    public class Issue
    {

        public int issue_id { get; set; }
        
        public string status { get; set; }
        public string issueStatement { get; set; }

        public string IssueImage { get; set; }
        //public string issue_image { get; set; }
        public DateTime issue_date { get; set; }

        public int isresolved { get; set; }
       
        public static async Task<List<Issue>> getallissues()
        {
            HttpClient client = new HttpClient();
            string uri = User.baseuri + "/api/admin/fetchallissues";
            var response = await client.GetStringAsync(uri);
            var content = JsonConvert.DeserializeObject<List<Model.Issue>>(response);
            return content;
        }
    }
}
