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
    public partial class fitnessform : Form
    {
        public fitnessform()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e) // menü tuşu işevi
        {
            this.Close();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void fitnessform_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void fitnessform_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void fitnessform_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button4_Click(object sender, EventArgs e) //chestform open
        {
            chestform chest=new chestform();
            chest.Show();
        }

        private void button1_Click(object sender, EventArgs e) //backform open
        {
            backform back = new backform();
            back.Show();
        }

        private void button2_Click(object sender, EventArgs e) //armsform open
        {
            armsform arms = new armsform();
            arms.Show();
        }

        private void button3_Click(object sender, EventArgs e) //shouldersform open
        {
            shouldersform shoulders = new shouldersform();
            shoulders.Show();
        }

        private void button5_Click(object sender, EventArgs e) //ABSform open
        {
            absform abs = new absform();
            abs.Show();
        }

        private void button6_Click(object sender, EventArgs e) //legsform open
        {
            legsform legs = new legsform();
            legs.Show();
        }
    }
}
