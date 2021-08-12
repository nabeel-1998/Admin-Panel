using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    class Volunteer
    {
        public int volunteer_id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string cnic_no { get; set; }
        public string password { get; set; }


        public static async Task<List<Volunteer>> getallvolunteers()
        {
            HttpClient client = new HttpClient();
            string uri = User.baseuri + "/api/admin/fetchallvolunteers";
            var response= await client.GetStringAsync(uri);
            var content = JsonConvert.DeserializeObject<List<Volunteer>>(response);
            return content;
        }
    }
}
