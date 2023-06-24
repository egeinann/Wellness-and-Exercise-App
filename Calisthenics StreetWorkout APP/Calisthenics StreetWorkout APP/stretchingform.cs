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
    public partial class stretchingform : Form
    {
        public stretchingform()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e) // menu tuşu işlevi
        {
            this.Close();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void stretchingform_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void stretchingform_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void stretchingform_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button1_Click(object sender, EventArgs e) //LOWER BODY STRETCHING BUTTON
        {
            lowerbodystretching lowerbodystretching = new lowerbodystretching();
            lowerbodystretching.Show();
        }

        private void button3_Click(object sender, EventArgs e) //FULL BODY STRENGTH BUTTON
        {
            fullbodystrengthform fullbodystrength = new fullbodystrengthform();
            fullbodystrength.Show();
        }

        private void button2_Click(object sender, EventArgs e) //UPPER BODY STRENGTH BUTTON
        {
            upperbodystrengthform upperbodystrength = new upperbodystrengthform();
            upperbodystrength.Show();
        }
    }
}
