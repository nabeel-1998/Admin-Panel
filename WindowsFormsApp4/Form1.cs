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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }


        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnClosee_Click(object sender, EventArgs e)
        {
            //btnClose
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show pass
            if (bunifuTextBox2.PasswordChar=='*')
            {
                button2.BringToFront();
                bunifuTextBox2.PasswordChar = '\0';
            }
            else
            {
                button1.BringToFront();
                bunifuTextBox2.PasswordChar = '*';
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hide pass
            if (bunifuTextBox2.PasswordChar == '\0')
            {
                button1.BringToFront();
                bunifuTextBox2.PasswordChar = '*';
            }
            else
            {
                button2.BringToFront();
                bunifuTextBox2.PasswordChar = '\0';
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoaderImage.Visible = false;
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            LoaderImage.Visible = true;
            var result = await AdminControl.login(bunifuTextBox1.Text,bunifuTextBox2.Text,this);
            if(!result)
            {
                LoaderImage.Visible = false;
            }
            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
