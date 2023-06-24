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
    public partial class calisthenicsform : Form
    {
        public calisthenicsform()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void calisthenicsform_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void calisthenicsform_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void calisthenicsform_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button2_Click(object sender, EventArgs e) // PUSHUP FORM OPEN
        {
            pushupform pushup = new pushupform();
            pushup.Show();
        }

        private void button1_Click(object sender, EventArgs e) // PULLUP FORM OPEN
        {
            pullupform pullup = new pullupform();
            pullup.Show();
        }

        private void button3_Click(object sender, EventArgs e) // JUMPSQUAD FORM OPEN
        {
            jumpsquadform jumpsquad = new jumpsquadform();
            jumpsquad.Show();
        }

        private void button4_Click(object sender, EventArgs e) // MUSCLEUP FORM OPEN
        {
            muscleupform muscleup= new muscleupform();
            muscleup.Show();
        }

        private void button5_Click(object sender, EventArgs e) // HANDSTAND FORM OPEN
        {
            handstandform handstand = new handstandform();
            handstand.Show();
        }

        private void button6_Click(object sender, EventArgs e) // PİSTOLSQUAD FORM OPEN
        {
            pistolsquatform pistolsquad = new pistolsquatform();
            pistolsquad.Show();
        }

        private void button7_Click(object sender, EventArgs e) // FRONTLEVER FORM OPEN
        {
            frontleverform frontlever = new frontleverform();
            frontlever.Show();
        }

        private void button8_Click(object sender, EventArgs e) // BACKLEVER FORM OPEN
        {
            backleverform backlever = new backleverform();
            backlever.Show();
        }

        private void button9_Click(object sender, EventArgs e) // PLANCHE FORM OPEN
        {
            plancheform planche = new plancheform();
            planche.Show();
        }

        private void calisthenicsform_Load(object sender, EventArgs e) // NULL
        {
        }
    }
}
