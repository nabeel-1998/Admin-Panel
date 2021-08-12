using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    class Advertisment
    {
        public int advertisment_id{ get; set; }
        public string advertisement_name { get; set; }
        public string  advertisement_link { get; set; }

        public string  advertisemnet_description { get; set; }
        public string advertisement_image { get; set; }

        public static async Task<List<Model.Advertisment>> getalladvertisments()
        {
            HttpClient client = new HttpClient();
            string uri = Model.User.baseuri + "/api/admin/fetchalladvertisments";
            var response = await client.GetStringAsync(uri);
            var content = JsonConvert.DeserializeObject<List<Model.Advertisment>>(response);
            return content;
        }
    }
}
