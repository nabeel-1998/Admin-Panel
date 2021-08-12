using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Model;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace WindowsFormsApp4.Controls
{
    class UserControl
    {

        public static async Task<List<User>> userdata()
        {
            var list = await User.getallusers();

            return list;

        }
        
    }
}
