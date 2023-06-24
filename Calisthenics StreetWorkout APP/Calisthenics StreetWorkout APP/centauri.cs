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
    public partial class centauri : Form
    {
        public centauri()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e) // menu button
        {
            this.Close();
        }

        public void truefalse()
        {
            pictureBox4.Visible = false;
            label4.Visible = false;
            pictureBox8.Visible = true;
            label4.Visible = true;
            label4.BringToFront();
        }
        private void label3_Click(object sender, EventArgs e) // null
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            truefalse();
            label4.Text = "You can do exercises other\r\nthan hiit workout slowly,\r\nbut I recommend you to\r\nconsult your doctor first.\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            truefalse();
            label4.Text = "Exercises are sufficient for a\r\nhealthy life and abilities.\r\nBut nutrition is the most\r\nbasic of the work. Pay\r\nattention to your nutrition\r\nas much as possible.\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            truefalse();
            label4.Text = "It's not a big deal,\r\ndon't worry. Keep your\r\nnext meal balanced,move\r\nand drink lots of water.\r\n";
        }

        private void centauri_Load(object sender, EventArgs e) // null
        {
        }
    }
}
