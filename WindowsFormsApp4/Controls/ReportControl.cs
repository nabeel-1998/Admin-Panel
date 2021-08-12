using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Controls
{
    class ReportControl
    {
       public static async Task<List<Model.Report>> reportdata()
        {
            var list = await Model.Report.getallreports();
            return list;
        }
    }
}
