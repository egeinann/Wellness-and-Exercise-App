using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Calisthenics_StreetWorkout_APP
{
    public partial class upperbodystrengthform : Form
    {
        private Timer timer;
        private int countdownSeconds = 30;
        public upperbodystrengthform()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e) // exit button
        {
            if (timer1.Enabled == true || timer2.Enabled == true) // eğer zamanlayıcılar aktif ise çıkış tuşunu engelle
            {
                MessageBox.Show("You cannot leave the page while the exercise is in progress.");
            }
            else
            {
                this.Close();
            }
        }

        private void upperbodystrengthform_Load(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;
            pictureBox7.Visible = true;
            pictureBox6.Visible = false;

            progressBar1.Value = progressBar1.Maximum; // 1. İlerleme çubuğunu tamamen doldur
            progressBar1.Minimum = 0;
            progressBar1.Maximum = countdownSeconds;
            progressBar2.Value = progressBar2.Maximum; // 2. İlerleme çubuğunu tamamen doldur
            progressBar2.Minimum = 0;
            progressBar2.Maximum = countdownSeconds;
            timer = new Timer();
            timer.Interval = 10000; // 1 saniye
        }

        private void button1_Click(object sender, EventArgs e) // STARTBUTTON1
        {
            if(progressBar1.Value!=0)
            {
                timer1.Enabled = true;
                timer1.Start();
                button2.Enabled = false;
                button5.Enabled = false;
            }
            else
            {
                MessageBox.Show("To repeat the exercise,\nyou must refresh...");
            }
        }

        private void button4_Click(object sender, EventArgs e) // REFRESHBUTTON1
        {
            timer1.Stop(); // dur
            progressBar1.Value = progressBar1.Maximum; // barı fule
            countdownSeconds = 30; // 30 dan başla
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            label1.Text = progressBar1.Maximum.ToString();
            button2.Enabled = true;
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e) // STARTBUTTON2
        {
            if(progressBar2.Value!=0)
            {
                timer2.Enabled = true;
                timer2.Start();
                button1.Enabled = false;
                button4.Enabled = false;
            }
            else
            {
                MessageBox.Show("To repeat the exercise,\nyou must refresh...");
            }          
        }

        private void button5_Click(object sender, EventArgs e) // REFRESHBUTTON2
        {
            timer2.Stop(); // dur
            progressBar2.Value = progressBar2.Maximum; // barı fule
            countdownSeconds = 30; // 30 dan başla
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            label5.Text = progressBar2.Maximum.ToString();
            button1.Enabled = true;
            button4.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e) // TİMER1
        {
            countdownSeconds--; // zamanlayıcı -1 şeklinde azalsın

            if (countdownSeconds >= progressBar1.Minimum)
            {
                progressBar1.Value = countdownSeconds;
                label1.Text = countdownSeconds.ToString();
            }
            else
            {
                timer1.Stop();
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                button1.Enabled = true;
                countdownSeconds = 30;
                progressBar1.Value = progressBar1.Minimum;
                button2.Enabled = true;
                button5.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e) // TIMER2
        {
            countdownSeconds--; // zamanlayıcı -1 şeklinde azalsın

            if (countdownSeconds >= progressBar2.Minimum)
            {
                progressBar2.Value = countdownSeconds;
                label5.Text = countdownSeconds.ToString();
            }
            else
            {
                timer2.Stop();
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                button2.Enabled = true;
                countdownSeconds = 30;
                progressBar2.Value = progressBar2.Minimum;
                button1.Enabled = true;
                button4.Enabled = true;
            }
        }
    }
}
