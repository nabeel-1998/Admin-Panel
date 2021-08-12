using Google.Type;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    class Funds
    {
        public int user_id { get; set; }
        public int issue_id { get; set; }
        public int funds_id { get; set; }
        public string amount { get; set; }
        public string issueStatement { get; set; }
        public string location_name { get; set; }
        public System.DateTime fund_date { get; set; }
        public int estimated_cost { get; set; }
        public int balance_payment { get; set; }
        
        public static async Task<List<Funds>> getallfunds()
        {
            HttpClient client = new HttpClient();
            string uri = User.baseuri + "/api/admin/fetchallfunds";
            var response = await client.GetStringAsync(uri);
            var content = JsonConvert.DeserializeObject<List<Model.Funds>>(response);
            return content;
        }
    }
}
