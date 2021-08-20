using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Controls
{
    class AdvertismentControl
    {
        public static async Task<List<Model.Advertisment>> advertismentdata()
        {
            var list = await Model.Advertisment.getalladvertisments();
            foreach (var item in list)
            {
                item.ImageAd = item.ConvertToImage();
            }
            return list;
        }

        public async Task<bool> UpdateStatusofAd(string AdStatus, int AdId, int DTR)
        {
            var uri = Model.User.baseuri + "/api/admin/updateadstatus/?status="+AdStatus+"&ad_id="+AdId+"&daystorun="+DTR;
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(uri);
            if(response.StatusCode==System.Net.HttpStatusCode.Accepted)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> SendMessagetoAdvertiser(int userid, string message)
        {
            var uri = Model.User.baseuri + "/api/admin/sendmessagetoadvertiser/?userid=" + userid + "&message=" + message;
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(uri);
            if(response.StatusCode==System.Net.HttpStatusCode.Accepted)
            {
                return true;
            }
            return false;
        }
    }
}
