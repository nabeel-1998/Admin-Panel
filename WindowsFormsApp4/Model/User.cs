using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp4.Model
{
    class User
    {
        public static int RowCount { get; set; }
        public string user_id { get; set; }
        public string name { get; set; }
        public string email_address { get; set; }
        public string contact_no { get; set; }
        public string userrating { get; set; }
        public string Status { get; set; }
       
        //http://{0}:8045","localhost
        public static string baseuri = string.Format("https://fypwebapiappservice1.azurewebsites.net");
        public static async Task<List<User>> getallusers()
        {
            HttpClient client = new HttpClient();
            string uri = baseuri + "/api/admin/fetchallusers";
            
            var response = await client.GetStringAsync(uri);
            
            var content = JsonConvert.DeserializeObject<List<WindowsFormsApp4.Model.User>>(response);
            return content;

        }
        
    }
}
