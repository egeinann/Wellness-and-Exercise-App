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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e) // STRETCHİNG İNFO BUTTON
        {
            MessageBox.Show("Stretching is a set of physical exercises that stretch, stretch and lengthen certain muscles, tendons and soft tissues such as ligaments to increase the elasticity of the muscles. Regular stretching improves muscle control, flexibility and range of motion.");
        }

        private void button6_Click(object sender, EventArgs e) // CALİSTHENİCS İNFO BUTTON
        {
            MessageBox.Show("Calisthenic is basically a form of strength training. However, while it effectively improves balance, control, endurance, flexibility abilities along with strength, it also gives very good results in psychomotor skills, fat burning and a fit appearance.");
        }

        private void button7_Click(object sender, EventArgs e) // FİTNESS İNFO BUTTON
        {
            MessageBox.Show("Bodybuilders do less cardiovascular exercise and more weight training. Fitness, on the other hand, is done to have a healthy body, to tighten, strengthen and develop the muscles.");
        }

        private void button8_Click(object sender, EventArgs e) // HIIT WORKOUR İNFO BUTTON
        {
            MessageBox.Show("It is a workout that is usually performed with body weight, without the use of any equipment. In Hiit training, it is aimed to bring the maximum heart rate to 85-90% with an exercise ranging from 5 seconds to 8 minutes.");
        }

        private void button1_Click(object sender, EventArgs e) // STRETCHİNG BUTTON
        {
            stretchingform stretching = new stretchingform();
            stretching.Show();
        }

        private void button2_Click(object sender, EventArgs e) // CALİSTHENİCS BUTTON
        {
            calisthenicsform calisthenics = new calisthenicsform();
            calisthenics.Show();
        }

        private void button3_Click(object sender, EventArgs e) // FİTNESS BUTTON
        {
            fitnessform fitness = new fitnessform();
            fitness.Show();
        }

        private void button4_Click(object sender, EventArgs e) // HIIT WORKOUT BUTTON
        {
            hiitworkoutform hiitw = new hiitworkoutform();
            hiitw.Show();
        }

        private void button9_Click(object sender, EventArgs e) // SETTINGS BUTTON
        {
            settingsform settings = new settingsform();
            settings.Show();
        }

        private void button10_Click(object sender, EventArgs e) // X exit BUTTON
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move= true;
            mouse_x = e.X;
            mouse_y= e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move= false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button11_Click(object sender, EventArgs e) // LOGIN BUTTON
        {
            loginform login = new loginform();
            login.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) //NULL
        {
        }

        private void label3_Click(object sender, EventArgs e) // NULL
        {
        }

        private void button13_Click(object sender, EventArgs e) // BOXING INFO
        {
            MessageBox.Show("Boxing is a sports competition in which two people fight each other under the supervision of a referee and try to beat each other with a knockout or points.");
        }

        private void button17_Click(object sender, EventArgs e) // RESISTANCE INFO
        {
            MessageBox.Show("A resistance band is a piece of equipment that can be used to work all parts of the body. It can be used to stay in shape as well as to lose weight. The band, which strengthens the muscles and gains resistance, also helps the body to get into shape.");
        }

        private void button18_Click(object sender, EventArgs e) // KETTLEBELL INFO
        {
            MessageBox.Show("Kettlebell or Dumbbel swing is a very effective exercise that works almost every part of your body – especially the hips, legs, back, core and shoulders – and increases the endurance and muscle strength in these areas.");
        }

        private void button19_Click(object sender, EventArgs e) // HEALTY FOODS INFO
        {
            MessageBox.Show("In the most basic sense, healthy nutrition is the type of nutrition that contains all macro and micro nutrients in the amounts that the person needs, at the same time fully meets the amount of energy needed by the individual, and is suitable for maintaining the ideal weight.");
        }

        private void button12_Click(object sender, EventArgs e) // BOXİNGFORM OPEN
        {
            boxingform boxing = new boxingform();
            boxing.Show();
        }

        private void button14_Click(object sender, EventArgs e) // RESISTANCEFORM OPEN
        {
            resistanceform resistance = new resistanceform();
            resistance.Show();
        }

        private void button15_Click(object sender, EventArgs e) // KETTLEBELLFORM OPEN
        {
            kettlebellform kettlebell = new kettlebellform();
            kettlebell.Show();
        }

        private void button16_Click(object sender, EventArgs e) // HEALTYFOODSFORM OPEN
        {
            foodsform foods = new foodsform();
            foods.Show();
        }

        private void button20_Click(object sender, EventArgs e) // CENTAURIFORM OPEN
        {
            centauri centauri = new centauri();
            centauri.Show();
        }

        private void Form1_Load(object sender, EventArgs e) // FORMLOAD
        {
            this.Visible = true;
            startfrom startfrom=new startfrom();
            startfrom.ShowDialog();
        }
    }
}
