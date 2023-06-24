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
    public partial class armsform : Form
    {
        private Timer timer;
        private int countdownSeconds = 60;
        public armsform()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true || timer2.Enabled == true || timer3.Enabled == true || timer4.Enabled ==true) // eğer zamanlayıcılar aktif ise çıkış tuşunu engelle
            {
                MessageBox.Show("You cannot leave the page while the exercise is in progress.");
            }
            else
            {
                this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // STARTBUTTON1
        {
            if (progressBar1.Value != 0)
            {
                timer1.Enabled = true;
                timer1.Start();
                button2.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button9.Enabled = false;
                button8.Enabled = false;
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
            countdownSeconds = 60; // 30 dan başla
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            label1.Text = progressBar1.Maximum.ToString();
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
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
                countdownSeconds = 60;
                progressBar1.Value = progressBar1.Minimum;
                button2.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button9.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) // STARTBUTTON2
        {
            if (progressBar2.Value != 0)
            {
                timer2.Enabled = true;
                timer2.Start();
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button9.Enabled = false;
                button8.Enabled = false;
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
            countdownSeconds = 60; // 30 dan başla
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            label5.Text = progressBar2.Maximum.ToString();
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e) // TİMER2
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
                countdownSeconds = 60;
                progressBar2.Value = progressBar2.Minimum;
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button6.Enabled = true;
                button9.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e) // STARTBUTTON3
        {
            if (progressBar3.Value != 0)
            {
                timer3.Enabled = true;
                timer3.Start();
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button9.Enabled = false;
                button8.Enabled = false;
            }
            else
            {
                MessageBox.Show("To repeat the exercise,\nyou must refresh...");
            }
        }

        private void button6_Click(object sender, EventArgs e) // REFRESHBUTTON3
        {
            timer3.Stop(); // dur
            progressBar3.Value = progressBar3.Maximum; // barı fule
            countdownSeconds = 60; // 30 dan başla
            pictureBox8.Visible = false;
            pictureBox9.Visible = true;
            label6.Text = progressBar2.Maximum.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e) // TİMER3
        {
            countdownSeconds--; // zamanlayıcı -1 şeklinde azalsın

            if (countdownSeconds >= progressBar3.Minimum)
            {
                progressBar3.Value = countdownSeconds;
                label6.Text = countdownSeconds.ToString();
            }
            else
            {
                timer3.Stop();
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
                button3.Enabled = true;
                countdownSeconds = 60;
                progressBar3.Value = progressBar3.Minimum;
                button1.Enabled = true;
                button2.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button9.Enabled = true;
                button8.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e) // STARTBUTTON4
        {
            if (progressBar4.Value != 0)
            {
                timer4.Enabled = true;
                timer4.Start();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                MessageBox.Show("To repeat the exercise,\nyou must refresh...");
            }
        }

        private void button8_Click(object sender, EventArgs e) // REFRESHBUTTON4
        {
            timer4.Stop(); // dur
            progressBar4.Value = progressBar4.Maximum; // barı fule
            countdownSeconds = 60; // 30 dan başla
            pictureBox11.Visible = true;
            pictureBox12.Visible = false;
            label12.Text = progressBar2.Maximum.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e) // TİMER4
        {
            countdownSeconds--; // zamanlayıcı -1 şeklinde azalsın

            if (countdownSeconds >= progressBar4.Minimum)
            {
                progressBar4.Value = countdownSeconds;
                label12.Text = countdownSeconds.ToString();
            }
            else
            {
                timer4.Stop();
                pictureBox12.Visible = true;
                pictureBox11.Visible = false;
                button4.Enabled = true;
                countdownSeconds = 60;
                progressBar4.Value = progressBar4.Minimum;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
        }

        private void armsform_Load(object sender, EventArgs e) // FORMLOAD
        {
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;
            pictureBox7.Visible = true;
            pictureBox6.Visible = false;
            pictureBox9.Visible = true;
            pictureBox8.Visible = false;
            pictureBox11.Visible = true;
            pictureBox12.Visible = false;
            progressBar1.Value = progressBar1.Maximum; // 1. İlerleme çubuğunu tamamen doldur
            progressBar1.Minimum = 0;
            progressBar1.Maximum = countdownSeconds;
            progressBar2.Value = progressBar2.Maximum; // 2. İlerleme çubuğunu tamamen doldur
            progressBar2.Minimum = 0;
            progressBar2.Maximum = countdownSeconds;
            progressBar3.Value = progressBar3.Maximum; // 3. İlerleme çubuğunu tamamen doldur
            progressBar3.Minimum = 0;
            progressBar3.Maximum = countdownSeconds;
            progressBar4.Value = progressBar4.Maximum; // 4. İlerleme çubuğunu tamamen doldur
            progressBar4.Minimum = 0;
            progressBar4.Maximum = countdownSeconds;
            timer = new Timer();
            timer.Interval = 10000; // 1 saniye
            timer.Tick += timer1_Tick;
            timer.Tick += timer2_Tick;
            timer.Tick += timer3_Tick;
            timer.Tick += timer4_Tick;
        }
    }
}
