using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        PictureBox[] pict; //declaracion de matrices
        int count = 0;
        int count2 = 0;

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pict = new PictureBox[8] { pt1, pt2, pt3, pt4, pt5, pt6, pt7, pt8 };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            if (count < 8)
            {
                pict[count].Visible = true;
                if (count2 == 1)
                {
                   timer1.Interval = 250;
                   pict[count].BackgroundImage = Properties.Resources.Circle2;
                   pict[count].Size = new Size(13, 13);
                }
                count++;
            }
            else if (count2 < 1)
            {
                count = 0;
                count2++;
            }

            else
            {
                timer1.Enabled = false;
                this.Hide();
                Login frm = new Login(); frm.Show();
            }
        }

} 
    
}
