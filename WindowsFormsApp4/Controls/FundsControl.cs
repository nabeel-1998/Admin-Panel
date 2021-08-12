using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Controls
{
    class FundsControl
    {
        public static async Task<List<Model.Funds>> funddata()
        {
            var list = await Model.Funds.getallfunds();

            return list;
        }
    }
}
