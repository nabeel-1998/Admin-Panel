using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Model;

namespace WindowsFormsApp4.Controls
{
    class AdminControl
    {
        public static string name { get; set; }
        public static string password { get; set; }
        public static string phoneNo { get; set; }
        public static string email { get; set; }

        public static async Task<bool> login(string name, string passwrod, WindowsFormsApp4.Form1 form)
        {
            bool check = await Admin.logindata(name, passwrod);
            if (check == true)
            {
                form.Hide();
                Dashboard d = new Dashboard();
                d.Show();
            }
            else
            {

                MessageBox.Show("Login Failed");
            }
            return check;
        }

        internal async static Task<List<Message>> SendMessage(string msgtext)
        {
            HttpClient client = new HttpClient();
            string username = Admin_info_holder.name + "-" + "Admin" + "-" + Admin_info_holder.admin_id+ ": ";
            string uri = Model.User.baseuri + "/api/volunteer/sendmessage/?id_name=" + username + "&message=" + msgtext;
            var response = await client.GetStringAsync(uri);
            var message = JsonConvert.DeserializeObject<List<Message>>(response);
            return message;
        }



    }

    public class Message
    {
        public string message { get; set; }
        public string user_name_id { get; set; }
    }
}
