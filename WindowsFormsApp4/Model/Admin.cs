using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Controls;

namespace WindowsFormsApp4.Model
{
    class Admin
    {
        public int admin_id { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public static async Task<bool> logindata(string name, string password)
        {
           
            HttpClient client = new HttpClient();
            string uri = User.baseuri + "/api/admin/adminlogin/?name=" + name + "&password=" + password;
            var response = await client.GetAsync(uri);
            var another_response = await client.GetStringAsync(uri);
            if (response.StatusCode == HttpStatusCode.Accepted)
            {
                
                var adminObject = JsonConvert.DeserializeObject<Admin>(another_response);
                Admin_info_holder.GetInfo(adminObject);
                return true;
            }
            else
            {
                return false;
            }
           

        }
        //api bnani hai admin ki change password and username ki
        public static async Task<bool> changePassword(string newpassword, string oldpassword)
        {
            HttpClient client = new HttpClient();
            var uri = Model.User.baseuri + "/api/admin/changepassword/?name=" + AdminControl.name + "&newpassword=" + newpassword + "&password=" + oldpassword;
            var response = await client.PutAsync(uri, null);
            if (response.StatusCode == HttpStatusCode.Accepted)
            {
                return true;
        }
            else
            {
                return false;
            }
        }

        //string name,string oldname, string password
        public static async Task<bool> ChangeUserName(string newname, string password)
        {
            HttpClient client = new HttpClient();
            var uri = Model.User.baseuri + "/api/admin/changeusername/?name=" + newname + "&oldname=" + AdminControl.name + "&password=" + password;
            var response = await client.PutAsync(uri, null);
            if (response.StatusCode == HttpStatusCode.Accepted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
