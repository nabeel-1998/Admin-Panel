using System;
using System.Collections;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            userBindingSource.AddingNew += UserBindingSource_AddingNew;
            issueBindingSource.AddingNew += IssueBindingSource_AddingNew;
            volunteerBindingSource2.AddingNew += VolunteerBindingSource2_AddingNew;
            reportBindingSource.AddingNew += ReportBindingSource_AddingNew;
            advertismentBindingSource.AddingNew += AdvertismentBindingSource_AddingNew;
            resolvedIssuesBindingSource.AddingNew += ResolvedIssuesBindingSource_AddingNew;



        }

        private void VolunteerBindingSource2_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (VOLUNTEER_TABLE.Rows.Count == volunteerBindingSource2.Count)
            {
                volunteerBindingSource2.RemoveAt(volunteerBindingSource2.Count - 1);
            }
        }

        private void ResolvedIssuesBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (RESOLVE_ISSUES_TABLE.Rows.Count == resolvedIssuesBindingSource.Count)
            {
                resolvedIssuesBindingSource.RemoveAt(resolvedIssuesBindingSource.Count - 1);
            }
        }

        private void AdvertismentBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (FEEDBACK_TABLE.Rows.Count == advertismentBindingSource.Count)
            {
                advertismentBindingSource.RemoveAt(advertismentBindingSource.Count - 1);
            }
        }

        private void ReportBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (REPORT_TABLE.Rows.Count == reportBindingSource.Count)
            {
                reportBindingSource.RemoveAt(reportBindingSource.Count - 1);
            }
        }

        

        private async void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //btnvolunteers
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Volunteers");
            volunteerBindingSource2.DataSource = await WindowsFormsApp4.Controls.VolunteerControl.volunteerdata();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClosee_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        List<Model.Issue> issueList;
        List<Model.User> userList;
        List<Model.Advertisment> adList;
        List<Model.Funds> fundList;
        List<Model.Volunteer> volunteerList;
        List<Model.Report> reportList;
        List<Model.Funds> fundslist;
        List<Model.Issue> resolvelist;


        
        private async void Dashboard_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            label9.Text = DateTime.Now.ToShortDateString();
            label10.Text = DateTime.Now.ToShortTimeString();

            volunteerList = await WindowsFormsApp4.Controls.VolunteerControl.volunteerdata();
            label1.Text = volunteerList.Count.ToString();
            issueList = await WindowsFormsApp4.Controls.IssueControl.issuedata();
            label2.Text = issueList.Count.ToString();
            TotalIsssuesValue.Text = label2.Text;

            userList = await WindowsFormsApp4.Controls.UserControl.userdata();
            label3.Text = userList.Count.ToString();
            reportList = await WindowsFormsApp4.Controls.ReportControl.reportdata();
            label4.Text = reportList.Count.ToString();
            adList = await WindowsFormsApp4.Controls.AdvertismentControl.advertismentdata();
            label8.Text = adList.Count.ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                     resolvelist = await WindowsFormsApp4.Controls.IssueControl.issuedata();
            int rIC = 0;
            foreach(var item in resolvelist)
            {
                if(item.isresolved==1)
                {
                    rIC += 1;
                }
            }
            label6.Text = rIC.ToString();
            fundList = await WindowsFormsApp4.Controls.FundsControl.funddata();
            label7.Text = fundList.Count.ToString();
            
            
            


            




        }

        private void label9_Click(object sender, EventArgs e)
        {
            //date
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //time
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;  
            Pages.SetPage("Dashboard");
        }

        private void btnIssues_ClickAsync(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Issues");
            ISSUE_TABLE.DataSource = issueList;

            //foreach (var item in await WindowsFormsApp4.Controls.IssueControl.issuedata())
            //{

            //    issueBindingSource.Add(item);


            //}
        }

        private void IssueBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (ISSUE_TABLE.Rows.Count == issueBindingSource.Count)
            {
                issueBindingSource.RemoveAt(issueBindingSource.Count - 1);
            }

        }

        private async void btnUsers_ClickAsync(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Users");
            USER_TABLE.DataSource = await WindowsFormsApp4.Controls.UserControl.userdata();
            //foreach (var item in await WindowsFormsApp4.Controls.UserControl.userdata())
            //{
            //    userBindingSource.Add(item);
            //    //userBindingSource.AddingNew += UserBindingSource_AddingNew;
            //}
        }

        private void UserBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (USER_TABLE.Rows.Count == userBindingSource.Count)
            {
                userBindingSource.RemoveAt(userBindingSource.Count - 1);
            }

        }

        private async void btnReports_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Reports");
            REPORT_TABLE.DataSource = await WindowsFormsApp4.Controls.ReportControl.reportdata();
        }

        private async void btnFeedbacks_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Feedbacks");
            FEEDBACK_TABLE.DataSource = await WindowsFormsApp4.Controls.AdvertismentControl.advertismentdata();
        }

        private void btnFunds_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Funds");
        }

        private async void btnResolvedIssues_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Resolved Issues");
            RESOLVE_ISSUES_TABLE.DataSource = await WindowsFormsApp4.Controls.ResovedIssueControl.resolveissuedata();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            Pages.SetPage("Settings");
        }

        private void SettingsPage_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //total issues
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void label7_Click(object sender, EventArgs e)
        {
        
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void label6_Click(object sender, EventArgs e)
        {
        
        }

        private async void dashboardpanel5_Click(object sender, EventArgs e)
        {
            //issues
            Pages.SetPage("Issues");
            indicator.SetBounds(1,284,4,51);// x axis, y axis, width,height of indicator panel
            btnIssues.selected = true;
            btnDashboard.selected = false;
            ISSUE_TABLE.DataSource = await WindowsFormsApp4.Controls.IssueControl.issuedata();

        }

        private async void Volunteerpanel4_Click(object sender, EventArgs e)
        {
            Pages.SetPage("Volunteers");
            indicator.SetBounds(1, 230, 4, 51);// x axis, y axis, width,height of indicator panel
            btnVolunteer.selected = true;
            btnDashboard.selected = false;
            volunteerBindingSource2.DataSource = await WindowsFormsApp4.Controls.VolunteerControl.volunteerdata();

        }

        private async void Userspanel6_Click(object sender, EventArgs e)
        {
            Pages.SetPage("Users");
            indicator.SetBounds(1, 338, 4, 51);// x axis, y axis, width,height of indicator panel
            btnUsers.selected = true;
            btnDashboard.selected = false;
            USER_TABLE.DataSource = await WindowsFormsApp4.Controls.UserControl.userdata();

        }

        private async void Reportspanel7_Click(object sender, EventArgs e)
        {
            Pages.SetPage("Reports");
            indicator.SetBounds(1, 392, 4, 51);// x axis, y axis, width,height of indicator panel
            btnReports.selected = true;
            btnDashboard.selected = false;
            FEEDBACK_TABLE.DataSource = await WindowsFormsApp4.Controls.AdvertismentControl.advertismentdata();

        }

        private async void feedbackspanel12_Click(object sender, EventArgs e)
        {
            Pages.SetPage("Feedbacks");
            indicator.SetBounds(1, 446, 4, 51);// x axis, y axis, width,height of indicator panel
            btnFeedbacks.selected = true;
            btnDashboard.selected = false;
            FEEDBACK_TABLE.DataSource = await WindowsFormsApp4.Controls.AdvertismentControl.advertismentdata();

        }

        private void fundspanel11_Click(object sender, EventArgs e)
        {
            Pages.SetPage("Funds");
            indicator.SetBounds(1, 500, 4, 51);// x axis, y axis, width,height of indicator panel
            btnFunds.selected = true;
            btnDashboard.selected = false;
        }

        private void resolvedissuespanel10_Click(object sender, EventArgs e)
        {
            Pages.SetPage("Resolved Issues");
            indicator.SetBounds(1, 554, 4, 51);// x axis, y axis, width,height of indicator panel
            btnResolvedIssues.selected = true;
            btnDashboard.selected = false;
        }

        private void VOLUNTEER_TABLE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void VOLUNTEER_TABLE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void VolunteersPages_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
          
            AddVolunteer a = new AddVolunteer();
            a.ShowDialog();
        }

        private void ISSUE_TABLE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FUNDS_PANEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void REOLVED_ISSUES_PANEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VOLUNTEER_PANEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardPage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage1);
        }

        private void bunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           // AccountControl.changeusername(bunifuMaterialTextbox1.Text, bunifuMaterialTextbox2.Text);

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage3);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage2);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage4);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage5);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage6);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage7);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

            AccountControl.changepassword(bunifuMaterialTextbox3.Text, bunifuMaterialTextbox4.Text);

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
