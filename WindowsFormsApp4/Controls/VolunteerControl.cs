using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Model;

namespace WindowsFormsApp4.Controls
{
    class VolunteerControl
    {
        public static async Task<List<Model.Volunteer>> volunteerdata()
        {
            var list = await Volunteer.getallvolunteers();
            return list;
        }


        public static async void addVolunteer(Volunteer v)
        {
            HttpClient client = new HttpClient();
            var uri = Model.User.baseuri + "/api/admin/addvolunteer";
            var json = JsonConvert.SerializeObject(v);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(uri, content);


        }
    }
}
