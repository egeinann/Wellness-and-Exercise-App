using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // KAYIT VERİLERİNİ SQL SERVERA KAYDETME

namespace Calisthenics_StreetWorkout_APP
{
    public partial class signinform : Form
    {
        public signinform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-EPF9A99\SQLEXPRESS;Initial Catalog=APPdata;Integrated Security=True"); // veriler APPdata adlı server ile ilişkilendirildi
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) // NULL
        {
        }

        //TEXTBOX1 *************************************************************************************************************************************************
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "e-Mail")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "e-Mail";
                textBox1.ForeColor = Color.Gray;
            }
        }
        //TEXTBOX2 ************************************************************************************************************************************************
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
        //TEXTBOX3 ************************************************************************************************************************************************
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Verify your password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.White;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Verify your password";
                textBox3.ForeColor = Color.Gray;
            }
        }
        //MASKEDTEXTBOX ******************************************************************************************************************************************
        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                maskedTextBox1.ForeColor = Color.White;
            }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)// NULL
        {
            if (maskedTextBox1.Text == "(   )   -    ")
            {
                maskedTextBox1.ForeColor = Color.Gray;
            }
        }
        //TEXTBOX4 ************************************************************************************************************************************************
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Verification Code")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.White;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Verification Code";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // NULL
        {
        }
        Random rastgele = new Random();
        int kod;
        private void button5_Click(object sender, EventArgs e) // SIGNIN BUTTON
        {
            if(textBox1.Text.Length<15 || textBox1.Text.Length > 25) // e mail 15-25 karakter arası olmalı blok
            {
                pictureBox3.Visible = true;
                label3.Text=("e-mail is incorrect !!!");
                label3.Visible = true;
                textBox1.Text = "";
            }
            else if (textBox2.Text.Length < 8 || textBox2.Text.Length > 16) // şifre 8-16 karakter arası olmalı blok
            {
                pictureBox3.Visible = true;
                label3.Text=("Password must be\nbetween 8-16 characters !!!");
                label3.Visible = true;
                textBox2.Text = "";
            }
            else if(textBox2.Text!= textBox3.Text) // ikinci şifre, şifre ile aynı olmalı blok
            {
                pictureBox3.Visible = true;
                label3.Text=("The passwords entered\nare not the same !!!");
                label3.Visible = true;
                textBox3.Text = "";
            }
            else if(textBox4.Text =="" || textBox4.Text!=kod.ToString()) // doğrulama kodu ekran çıktısı ile aynı olmalı
            {
                pictureBox3.Visible = true;
                label3.Text=("Verification code field\nis incorrect !!!");
                label3.Visible = true;
                textBox4.Text = "";
            }
            else
            {
                label3.Visible = false;
                pictureBox3.Visible= false;
                label1.Visible = true;
                pictureBox2.Visible = true;
            }
        }

        private void button10_Click(object sender, EventArgs e) // EXİT BUTTON
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // SEND BUTTON
        {
            if(maskedTextBox1.Text== "(   )    -") // telefon numarası kısmı boş ise
            {
                label3.Visible= true;
                pictureBox3.Visible= true;
                label3.Text=("ERROR\nEnter your phone number !!!");
            }
            else // boş değil ise
            {
                label3.Visible = false;
                pictureBox3.Visible=false;
                kod = rastgele.Next(1111, 9999); // 4 haneli kod oluştur
                MessageBox.Show("Your verification code\n" + kod.ToString());
            }
        }
        bool move;
        int mouse_x;
        int mouse_y;
        private void signinform_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void signinform_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void signinform_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void label3_Click(object sender, EventArgs e) //NULL
        {
        }
    }
}
