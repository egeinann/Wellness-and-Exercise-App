using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisthenics_StreetWorkout_APP
{
    public partial class hiitworkoutform : Form
    {
        public hiitworkoutform()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void hiitworkoutform_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void hiitworkoutform_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void hiitworkoutform_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button5_Click(object sender, EventArgs e) //burpeeform open
        {
            burpeeform burpee=new burpeeform();
            burpee.Show();
        }

        private void button4_Click(object sender, EventArgs e) //jumpingjacksform open
        {
            jumpingjacksform jumpingjacks = new jumpingjacksform();
            jumpingjacks.Show();
        }

        private void button2_Click(object sender, EventArgs e) //highkneesform open
        {
            highkneesform highknees=new highkneesform();
            highknees.Show();
        }

        private void button1_Click(object sender, EventArgs e) //mountainclimbersform open
        {
            mountainclimbersform mountainclimbers=new mountainclimbersform();
            mountainclimbers.Show();
        }

        private void button3_Click(object sender, EventArgs e) //jumpingropeform open
        {
            jumpingropeform jumpingrope= new jumpingropeform();
            jumpingrope.Show();
        }
    }
}
