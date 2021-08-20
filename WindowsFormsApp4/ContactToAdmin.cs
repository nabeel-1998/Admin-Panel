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
using WindowsFormsApp4.Chat_Controls;
using System.Threading;

namespace WindowsFormsApp4
{
    public partial class ContactToAdmin : Form
    {
        public ContactToAdmin()
        {
            InitializeComponent();
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            var chat = await AdminControl.SendMessage(bunifuCustomTextbox1.Text);
            bunifuCustomTextbox1.Text = string.Empty;
            chatpanel.Controls.Clear();

            foreach (var item in chat)
            {
                var senderInfo = item.user_name_id.Split('-');
                var Type = senderInfo[2].Replace(": ", "");
                var id = Convert.ToInt32(Type);
                if (id == Admin_info_holder.admin_id)
                {
                    var bubble = new Outgoing();

                    bubble.Dock = DockStyle.Top;
                    bubble.Message = item.user_name_id + item.message;
                    chatpanel.Controls.Add(bubble);

                }
                else
                {
                    var bubble = new Incoming();

                    bubble.Dock = DockStyle.Top;
                    bubble.Message = item.user_name_id + item.message;
                    chatpanel.Controls.Add(bubble);
                }
            }
        }

        private void ContactToAdmin_Load(object sender, EventArgs e)
        {
            bunifuButton1.PerformClick();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 20000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bunifuButton1.PerformClick();
        }
    }
}
