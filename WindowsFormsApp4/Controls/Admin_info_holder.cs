using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Controls
{
    class Admin_info_holder
    {
        public static int admin_id { get; set; }
        public static string name { get; set; }
        public static string password { get; set; }

        public static void GetInfo(Model.Admin admin)
        {
            admin_id = admin.admin_id;
            name = admin.name;
            password = admin.password;
        }

        public static void CLearInfo()
        {
            admin_id = 0;
            name = null;
            password = null;
        }
    }
}
