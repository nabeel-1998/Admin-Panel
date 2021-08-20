using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    public class Advertisment
    {
        public int advertisment_id { get; set; }
        public string Adstitle { get; set; }
        public string Adstext { get; set; }
        public string websitelink { get; set; }
        public string Adsimage { get; set; }
        public string Status { get; set; }
        public int User_id { get; set; }
        public DateTime Date { get; set; }
        public int Elapsed_Days { get; set; }

        public Image ImageAd { get; set; }

        public Image ConvertToImage()
        {
            byte[] imageBytes = Convert.FromBase64String(Adsimage);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public static async Task<List<Model.Advertisment>> getalladvertisments()
        {
            HttpClient client = new HttpClient();
            string uri = Model.User.baseuri + "/api/admin/fetchalladvertisments";
            var response = await client.GetStringAsync(uri);
            var content = JsonConvert.DeserializeObject<List<Model.Advertisment>>(response);
            return content;
        }

       
    }
}
