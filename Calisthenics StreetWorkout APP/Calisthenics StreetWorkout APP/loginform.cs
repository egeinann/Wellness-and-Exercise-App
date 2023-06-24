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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="e-Mail")
            {
                textBox1.Text="";
                textBox1.ForeColor=Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox1.Text = "e-Mail";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button9_Click(object sender, EventArgs e) // MENU BUTTON
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signinform signinform= new signinform();
            signinform.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // NULL
        {
        }

        private void button1_Click(object sender, EventArgs e) // close eyes
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e) // LOG IN BUTTON
        {
        }

        private void loginform_Load(object sender, EventArgs e) // NULL
        {
        }
        
        bool move;
        int mouse_x;
        int mouse_y;
        private void loginform_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void loginform_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void loginform_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button2_Click(object sender, EventArgs e) // open eyes
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
            button2.Visible=false;
            button1.Visible=true;
        }
    }
}
