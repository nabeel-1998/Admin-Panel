using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Controls;

namespace WindowsFormsApp4
{
    public partial class Issue_Info : Form
    {
        Model.Issue Issue;
        public Issue_Info(Model.Issue Issue)
        {
            InitializeComponent();
            this.Issue = Issue;
        }

        IssueControl iControl = new IssueControl();
        private async void FndBtn_Click(object sender, EventArgs e)
        {
            LoaderImage.Visible = true;
            int amount=0, userid = 0;
            try
            {
                amount = Convert.ToInt32(UserAmountBox.Text);
                userid = Convert.ToInt32(UserIDBox.Text);
                try
                {
                    var result = await iControl.AddFundToIssue(Issue.issue_id, amount, userid);
                    if (result)
                    {
                        MessageBox.Show("Fund Details added successfully");
                    }
                    else
                    {
                        MessageBox.Show("User with this ID Not found");
                    }
                }
                finally
                {
                    LoaderImage.Visible = false;
                }
                
                
              
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter correct User ID and Amount");
            }
           
            

            
        }

        private void Issue_Info_Load(object sender, EventArgs e)
        {
            byte[] arr = Convert.FromBase64String(Issue.IssueImage);
            MemoryStream ms = new MemoryStream(arr, 0, arr.Length);
            ms.Write(arr, 0, arr.Length);
            IssueImage.Image = Image.FromStream(ms, true);
            IssueType.Text = Issue.issueStatement;
            LoaderImage.Visible = false;
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            bool result = false;
            LoaderImage.Visible = true;
            try
            {
                result = await iControl.DeleteAnIssue(Issue.issue_id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                LoaderImage.Visible = false;
                if (result)
                {
                    MessageBox.Show("Issue Deleted Sucessfully");
                }
                else
                {
                    MessageBox.Show("This issue cannot be deleted Because it has started receiving funds");
                }
            }

            
          
        }
    }
}
