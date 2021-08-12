using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.Controls
{
    class IssueControl
    {
        public static async Task<List<Model.Issue>> issuedata()
        {
            var list = await Model.Issue.getallissues();
           
            return list;
        }
    }
}
