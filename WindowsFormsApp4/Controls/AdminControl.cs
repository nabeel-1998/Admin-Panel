using System;
using System.Collections.Generic;
using System.Linq;
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

        public static async void login(string name, string passwrod, WindowsFormsApp4.Form1 form)
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

        }

    }
}
