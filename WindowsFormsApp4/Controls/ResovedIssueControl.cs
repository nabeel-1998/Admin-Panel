using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Controls
{
    class ResovedIssueControl
    {
        public static async Task<List<Model.ResolvedIssues>> resolveissuedata()
        {
            var list = await Model.ResolvedIssues.getallresolvedissues();

            return list;
        }
    }
}
