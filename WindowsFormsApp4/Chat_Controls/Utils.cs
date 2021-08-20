using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4.Chat_Controls
{
    class Utils
    {
        public static int GetTextHeight(Label lbl)
        {
            using (Graphics g = lbl.CreateGraphics())
            {
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 460);
                return (int)Math.Ceiling(size.Height);
            }
        }

    }
}
