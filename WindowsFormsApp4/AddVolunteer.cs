using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class AddVolunteer : Form
    {
        public AddVolunteer()
        {
            InitializeComponent();
        }

        private void AddVolunteer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hide pass
            if (bunifuTextBox1.PasswordChar == '\0')
            {
                button1.BringToFront();
                bunifuTextBox1.PasswordChar = '*';
            }
            else
            {
                button2.BringToFront();
                bunifuTextBox1.PasswordChar = '\0';
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.PasswordChar == '*')
            {
                button2.BringToFront();
                bunifuTextBox1.PasswordChar = '\0';
            }
            else
            {
                button1.BringToFront();
                bunifuTextBox1.PasswordChar = '*';
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Model.Volunteer v = new Model.Volunteer();
            v.name = edtName.Text;
            v.email = edtEmail.Text;
            v.contact = edtContact.Text;
            v.cnic_no = edtCnic.Text;
            v.password = bunifuTextBox1.Text;

            try
            {
                WindowsFormsApp4.Controls.VolunteerControl.addVolunteer(v);
            }
            catch { }
            finally
            {
                MessageBox.Show("Volunteer added sucessfully!!");
                this.Close();
            }
            
        }
    }
}
