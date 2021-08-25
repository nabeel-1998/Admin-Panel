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
    class AccountControl
    {
        public static async Task Changestatus(int userid)
        {
            HttpClient client = new HttpClient();
            var uri = User.baseuri + "/api/admin/updateuserstatus/?userid=" + userid;
            var response = await client.GetAsync(uri);
        }
        public static async void changeusername(string name, string pass)
        {
            var check = await Admin.ChangeUserName(name, pass);
            if (check == true)
            {
                MessageBox.Show("Username Changed Sucessfully");
            }
            else
            {
                MessageBox.Show("Could not found user, Invalid password");
            }
        }

        public static async void changepassword(string newpassword, string oldpassword)
        {
            var check = await Admin.changePassword(newpassword, oldpassword);
            if (check == true)
            {
                MessageBox.Show("Password Changed Sucessfully");
            }
            else
            {
                MessageBox.Show("Could not found user, Invalid password");
            }
        }
    }
}
