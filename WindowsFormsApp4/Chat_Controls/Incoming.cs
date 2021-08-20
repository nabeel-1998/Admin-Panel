using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.Chat_Controls
{
    public partial class Incoming : UserControl
    {
        public Incoming()
        {
            InitializeComponent();
        }

        public string Message
        {
            get
            {
                return IncomingLabel.Text;
            }
            set
            {
                IncomingLabel.Text = value;
                AdjustHeight();
            }
        }

        private void AdjustHeight()
        {
            IncomingLabel.Height = Utils.GetTextHeight(IncomingLabel);
            bunifuUserControl1.Height = IncomingLabel.Top + bunifuUserControl1.Top + IncomingLabel.Height + 10;

            this.Height = bunifuUserControl1.Bottom + 10;
        }
    }
}
