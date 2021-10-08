using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        public async Task<bool> AddFundToIssue(int issueid, int amount,int userid)
        {
            HttpClient client = new HttpClient();
            var uri = Model.User.baseuri + "/api/issue/addfundtoissue/?issueid=" + issueid + "&amount=" + amount + "&userid=" + userid;
            var response = await client.GetAsync(uri);
            if(response.StatusCode==System.Net.HttpStatusCode.Accepted)
            {
                return true;
            }
            return false;
            
        }

        public async Task<bool> DeleteAnIssue(int issueid)
        {
            HttpClient client = new HttpClient();
            var uri = Model.User.baseuri + "/api/issue/deleteanissue/?issueid=" + issueid;
            var response = await client.GetAsync(uri);
            if(response.StatusCode==System.Net.HttpStatusCode.Accepted)
            {
                return true;
            }
            return false;
        }

        public async Task estimateAllIssuesCost()
        {
            HttpClient client = new HttpClient();
            var uri = Model.User.baseuri + "/api/issue/estimateallcost";
            var response = await client.GetAsync(uri);
        }
    }
}
