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
    public partial class settingsform : Form
    {
        public settingsform()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e) // menu tuşu işlevi
        {
            this.Close();
        }

        private void settingsform_Load(object sender, EventArgs e) // settingsform yüklendiği an gerekli yerleri seçili göster 
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 6;
            maskedTextBox1.Text = "20:00";
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void settingsform_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void settingsform_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void settingsform_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button2_Click(object sender, EventArgs e) // notifications buttons
        {
            button2.Visible = false;
            button3.Visible = true;
            label6.Text = "Notifications\r\n        on\r\n";
        }

        private void button3_Click(object sender, EventArgs e) // notifications buttons
        {
            button3.Visible=false;
            button2.Visible=true;
            label6.Text = "Notifications\r\n        off\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text !="Sunday" || comboBox1.Text !="English" || button3.Visible==true)
            {
                pictureBox6.Visible=true;
                button1.Visible=false;
                label5.Visible = true;
                label5.ForeColor = Color.Lime;
                label7.Visible=false;
            }
            else
            {
                label5.Visible=false;
                label7.Visible=true;
            }
        }
    }
}
