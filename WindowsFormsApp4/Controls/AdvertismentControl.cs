using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Controls
{
    class AdvertismentControl
    {
        public static async Task<List<Model.Advertisment>> advertismentdata()
        {
            var list = await Model.Advertisment.getalladvertisments();
            return list;
        }
    }
}
