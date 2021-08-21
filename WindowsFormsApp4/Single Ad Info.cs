using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Controls;

namespace WindowsFormsApp4
{
    public partial class adtitle : Form
    {
        private Model.Advertisment AdInfo { get; set; }
        public adtitle(Model.Advertisment advertisment)
        {
            InitializeComponent();
            AdInfo = advertisment;
        }

        private void adtitle_Load(object sender, EventArgs e)
        {
            adimage.Image = AdInfo.ImageAd;
            bunifuLabel4.Text = AdInfo.Adstitle;
            adtext.Text = AdInfo.Adstext;
            websitelink.Text = AdInfo.websitelink;
            bunifuDropdown1.Text = AdInfo.Status;

        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            AdvertismentControl adControl = new AdvertismentControl();
            if(string.IsNullOrEmpty(message.Text))
            {
                var result=await adControl.UpdateStatusofAd((string)bunifuDropdown1.SelectedItem, AdInfo.advertisment_id, Convert.ToInt32(elapsed_days.Text));
                if(result)
                {
                    MessageBox.Show("Status Updated successfully");
            }
            else
            {
                    MessageBox.Show("Status Not Updated!");
                }
            }
            else
            {
                var result = await adControl.UpdateStatusofAd((string)bunifuDropdown1.SelectedItem, AdInfo.advertisment_id, Convert.ToInt32(elapsed_days.Text));
                await adControl.SendMessagetoAdvertiser(AdInfo.User_id, message.Text);
                if (result)
                {
                    MessageBox.Show("Status Sent successfully");
                }
                else
                {
                    MessageBox.Show("Status Not Updated!");
                }
            }
        }
    }
}
