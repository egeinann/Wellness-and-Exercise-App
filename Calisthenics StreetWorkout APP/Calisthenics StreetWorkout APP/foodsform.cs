using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calisthenics_StreetWorkout_APP
{

    public partial class foodsform : Form
    {
        int totalkcal;
        public foodsform()
        {
            InitializeComponent();
        }
        public void centauriuyari() // centauri besin değerleri aşımı, uyari !!!
        {
            label45.ForeColor = Color.Red;
            label45.Text = "Hey slow down !\r\nYou ate too much food today.\r\nPlease contact me in the main menu.\r\n";
            label45.BringToFront();
        }
        public void kaloriuyari() // kalori aşımı method
        {
            pictureBox13.Visible = true;
            label36.Visible = true;
            progressBar4.Value = 0;
            label34.ForeColor = Color.Red;
            label37.ForeColor = Color.Red;
            label33.ForeColor = Color.Red;
        }
        public void proteinuyari() // protein aşımı method
        {
            pictureBox14.Visible = true;
            label41.Visible = true;
            label30.ForeColor = Color.Red;
            label38.ForeColor = Color.Red;
        }
        public void karbonhidratuyari() // karbonhidrat aşımı method
        {
            pictureBox14.Visible = true;
            label41.Visible = true;
            label31.ForeColor = Color.Red;
            label39.ForeColor = Color.Red;
        }
        public void yaguyari() // yağ aşımı method
        {
            pictureBox14.Visible = true;
            label41.Visible = true;
            label32.ForeColor = Color.Red;
            label40.ForeColor = Color.Red;
        }
        public void HesaplaPeynir(int gram) // peynir için gerekli method ****************************************************************************************************************
        {
            int kcalToAdd;
            double proteinToAdd;
            double karbonhidratToAdd;
            double yagToAdd;

            if (gram == 50)
            {
                kcalToAdd = 201;
                proteinToAdd = 10;
                karbonhidratToAdd = 1;
                yagToAdd = 12;
            }
            else if (gram == 100)
            {
                kcalToAdd = 402;
                proteinToAdd = 20;
                karbonhidratToAdd = 2;
                yagToAdd = 24;
            }
            else if (gram == 150)
            {
                kcalToAdd = 603;
                proteinToAdd = 30;
                karbonhidratToAdd = 3;
                yagToAdd = 36;
            }
            else if (gram == 200)
            {
                kcalToAdd = 804;
                proteinToAdd = 40;
                karbonhidratToAdd = 4;
                yagToAdd = 48;
            }
            else
            {
                return; // Geçersiz gram değeri, işlem yapma
            }

            // Kalori çubuğunu güncelle
            if (progressBar4.Value + kcalToAdd > progressBar4.Maximum) // kalori aşımı
            {
                kaloriuyari();
                centauriuyari();
            }
            else
            {
                progressBar4.Value += kcalToAdd;
            }
            totalkcal += kcalToAdd;
            label33.Text = totalkcal.ToString();

            // Protein çubuğunu güncelle
            if (progressBar1.Value + proteinToAdd > progressBar1.Maximum) // protein miktarı aşımı
            {
                proteinuyari();
                centauriuyari();
            }
            else
            {
                progressBar1.Value += (int)proteinToAdd;
            }
            label30.Text = progressBar1.Value.ToString();

            // Karbonhidrat çubuğunu güncelle
            if (progressBar2.Value + karbonhidratToAdd > progressBar2.Maximum) // karbonhidrat miktarı aşımı
            {
                karbonhidratuyari();
                centauriuyari();
            }
            else
            {
                progressBar2.Value += (int)karbonhidratToAdd;
            }
            label31.Text = progressBar2.Value.ToString();

            // Yağ çubuğunu güncelle
            if (progressBar3.Value + yagToAdd > progressBar3.Maximum) // yağ miktarı aşımı
            {
                yaguyari();
                centauriuyari();
            }
            else
            {
                progressBar3.Value += (int)yagToAdd;
            }
            label32.Text = progressBar3.Value.ToString();

            // Yüzdesel ifadeyi hesapla ve label34'e yansıt
            double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // progressbar4'e göre yüzde hesaplama
            label34.Text = progressPercentage.ToString("0.##") + "%"; // hesaplanan yüzde label'a aktarılıyor
        }
        public void HesaplaYumurta(int gram) // YUMURTA İÇİN GEREKLİ METHOD ******************************************************************************************************
        {
            int kcalToAdd;
            double proteinToAdd;
            double karbonhidratToAdd;
            double yagToAdd;

            if (gram == 50)
            {
                kcalToAdd = 70;
                proteinToAdd = 6.3;
                karbonhidratToAdd = 0.6;
                yagToAdd = 4.8;
            }
            else if (gram == 100)
            {
                kcalToAdd = 154;
                proteinToAdd = 12.9;
                karbonhidratToAdd = 1;
                yagToAdd = 11.2;
            }
            else if (gram == 150)
            {
                kcalToAdd = 231;
                proteinToAdd = 19.35;
                karbonhidratToAdd = 1.5;
                yagToAdd = 16.8;
            }
            else if (gram == 200)
            {
                kcalToAdd = 308;
                proteinToAdd = 25.8;
                karbonhidratToAdd = 2;
                yagToAdd = 22.4;
            }
            else
            {
                // Geçersiz gram değeri
                return;
            }

            if (progressBar4.Value + kcalToAdd > progressBar4.Maximum) // kalori aşımı
            {
                kaloriuyari();
                centauriuyari();
            }
            else
            {
                progressBar4.Value += kcalToAdd;
            }
            totalkcal += kcalToAdd;
            label33.Text = totalkcal.ToString();

            // Protein çubuğunu güncelle
            if (progressBar1.Value + proteinToAdd > progressBar1.Maximum) // protein miktarı aşımı
            {
                // Gerekli işlemler
                proteinuyari();
                centauriuyari();
            }
            else
            {
                progressBar1.Value += (int)proteinToAdd;
            }
            label30.Text = progressBar1.Value.ToString();

            // Karbonhidrat çubuğunu güncelle
            if (progressBar2.Value + karbonhidratToAdd > progressBar2.Maximum) // karbonhidrat miktarı aşımı
            {
                // Gerekli işlemler
                karbonhidratuyari();
                centauriuyari();
            }
            else
            {
                progressBar2.Value += (int)karbonhidratToAdd;
            }
            label31.Text = progressBar2.Value.ToString();

            // Yağ çubuğunu güncelle
            if (progressBar3.Value + yagToAdd > progressBar3.Maximum) // yağ miktarı aşımı
            {
                // Gerekli işlemler
                yaguyari();
                centauriuyari();
            }
            else
            {
                progressBar3.Value += (int)yagToAdd;
            }
            label32.Text = progressBar3.Value.ToString();

            // Yüzdesel ifadeyi hesapla ve label34'e yansıt
            double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // progressbar4'e göre yüzde hesaplama
            label34.Text = progressPercentage.ToString("0.##") + "%"; // hesaplanan yüzde label'a aktarılıyor
        }
        public void HesaplaRice(int gram) // rice için gerekli method ********************************************************************************************************************
        {
            int kcalToAdd = 0;
            double proteinToAdd = 0;
            double karbonhidratToAdd = 0;
            double yagToAdd = 0;

            if (gram == 50)
            {
                kcalToAdd = 65;
                proteinToAdd = 1.25;
                karbonhidratToAdd = 14.5;
                yagToAdd = 1;
            }
            else if (gram == 100)
            {
                kcalToAdd = 130;
                proteinToAdd = 2.5;
                karbonhidratToAdd = 29;
                yagToAdd = 1;
            }
            else if (gram == 150)
            {
                kcalToAdd = 195;
                proteinToAdd = 3.75;
                karbonhidratToAdd = 43.5;
                yagToAdd = 1.5;
            }
            else if (gram == 200)
            {
                kcalToAdd = 260;
                proteinToAdd = 5;
                karbonhidratToAdd = 58;
                yagToAdd = 2;
            }

            if (progressBar4.Value + kcalToAdd > progressBar4.Maximum) // kalori aşımı
            {
                kaloriuyari();
                centauriuyari();
            }
            else
            {
                progressBar4.Value += kcalToAdd;
            }
            totalkcal += kcalToAdd;
            label33.Text = totalkcal.ToString();

            // Protein çubuğunu güncelle
            if (progressBar1.Value + proteinToAdd > progressBar1.Maximum) // protein miktarı aşımı
            {
                proteinuyari();
                centauriuyari();
            }
            else
            {
                progressBar1.Value += (int)proteinToAdd;
            }
            label30.Text = progressBar1.Value.ToString();

            // Karbonhidrat çubuğunu güncelle
            if (progressBar2.Value + karbonhidratToAdd > progressBar2.Maximum) // karbonhidrat miktarı aşımı
            {
                karbonhidratuyari();
                centauriuyari();
            }
            else
            {
                progressBar2.Value += (int)karbonhidratToAdd;
            }
            label31.Text = progressBar2.Value.ToString();

            // Yağ çubuğunu güncelle
            if (progressBar3.Value + yagToAdd > progressBar3.Maximum) // yağ miktarı aşımı
            {
                yaguyari();
                centauriuyari();
            }
            else
            {
                progressBar3.Value += (int)yagToAdd;
            }
            label32.Text = progressBar3.Value.ToString();

            // Yüzdesel ifadeyi hesapla ve label34'e yansıt
            double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // progressbar4'e göre yüzde hesaplama
            label34.Text = progressPercentage.ToString("0.##") + "%"; // hesaplanan yüzde label'a aktarılıyor
        }
        public void HesaplaYulafEzmesi(int gram) // yulaf ezmesi için gerekli method ***************************************************************************************************
        {
            int kcalToAdd = 0;
            double proteinToAdd = 0;
            double karbonhidratToAdd = 0;
            double yagToAdd = 0;

            if (gram == 50)
            {
                kcalToAdd = 193;
                proteinToAdd = 8;
                karbonhidratToAdd = 33;
                yagToAdd = 3;
            }
            else if (gram == 100)
            {
                kcalToAdd = 386;
                proteinToAdd = 16;
                karbonhidratToAdd = 66;
                yagToAdd = 6;
            }
            else if (gram == 150)
            {
                kcalToAdd = 579;
                proteinToAdd = 24.3;
                karbonhidratToAdd = 99;
                yagToAdd = 9.9;
            }
            else if (gram == 200)
            {
                kcalToAdd = 772;
                proteinToAdd = 32.6;
                karbonhidratToAdd = 132;
                yagToAdd = 13.2;
            }

            if (progressBar4.Value + kcalToAdd > progressBar4.Maximum) // kalori aşımı
            {
                kaloriuyari();
                centauriuyari();
            }
            else
            {
                progressBar4.Value += kcalToAdd;
            }
            totalkcal += kcalToAdd;
            label33.Text = totalkcal.ToString();

            // Protein çubuğunu güncelle
            if (progressBar1.Value + proteinToAdd > progressBar1.Maximum) // protein miktarı aşımı
            {
                proteinuyari();
                centauriuyari();
            }
            else
            {
                progressBar1.Value += (int)proteinToAdd;
            }
            label30.Text = progressBar1.Value.ToString();

            // Karbonhidrat çubuğunu güncelle
            if (progressBar2.Value + karbonhidratToAdd > progressBar2.Maximum) // karbonhidrat miktarı aşımı
            {
                karbonhidratuyari();
                centauriuyari();
            }
            else
            {
                progressBar2.Value += (int)karbonhidratToAdd;
            }
            label31.Text = progressBar2.Value.ToString();

            // Yağ çubuğunu güncelle
            if (progressBar3.Value + yagToAdd > progressBar3.Maximum) // yağ miktarı aşımı
            {
                yaguyari();
                centauriuyari();
            }
            else
            {
                progressBar3.Value += (int)yagToAdd;
            }
            label32.Text = progressBar3.Value.ToString();

            // Yüzdesel ifadeyi hesapla ve label34'e yansıt
            double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // progressbar4'e göre yüzde hesaplama
            label34.Text = progressPercentage.ToString("0.##") + "%"; // hesaplanan yüzde label'a aktarılıyor
        }
        public void HesaplaChickenMeat(int gram) // chicken meat için gerekli method *****************************************************************************************************
        {
            int kcalToAdd = 0;
            double proteinToAdd = 0;
            double karbonhidratToAdd = 0;
            double yagToAdd = 0;

            if (gram == 50)
            {
                kcalToAdd = 55;
                proteinToAdd = 11.85;
                karbonhidratToAdd = 0;
                yagToAdd = 1;
            }
            else if (gram == 100)
            {
                kcalToAdd = 110;
                proteinToAdd = 23.7;
                karbonhidratToAdd = 0;
                yagToAdd = 1.5;
            }
            else if (gram == 150)
            {
                kcalToAdd = 165;
                proteinToAdd = 35.55;
                karbonhidratToAdd = 0;
                yagToAdd = 2;
            }
            else if (gram == 200)
            {
                kcalToAdd = 220;
                proteinToAdd = 47.4;
                karbonhidratToAdd = 0;
                yagToAdd = 2.5;
            }

            if (progressBar4.Value + kcalToAdd > progressBar4.Maximum) // kalori aşımı
            {
                kaloriuyari();
                centauriuyari();
            }
            else
            {
                progressBar4.Value += kcalToAdd;
            }
            totalkcal += kcalToAdd;
            label33.Text = totalkcal.ToString();

            if (progressBar1.Value + proteinToAdd > progressBar1.Maximum) // protein miktarı aşımı
            {
                proteinuyari();
                centauriuyari();
            }
            else
            {
                progressBar1.Value += (int)proteinToAdd;
            }
            label30.Text = progressBar1.Value.ToString();

            if (progressBar2.Value + karbonhidratToAdd > progressBar2.Maximum) // karbonhidrat miktarı aşımı
            {
                karbonhidratuyari();
                centauriuyari();
            }
            else
            {
                progressBar2.Value += (int)karbonhidratToAdd;
            }
            label31.Text = progressBar2.Value.ToString();

            if (progressBar3.Value + yagToAdd > progressBar3.Maximum) // yağ miktarı aşımı
            {
                yaguyari();
                centauriuyari();
            }
            else
            {
                progressBar3.Value += (int)yagToAdd;
            }
            label32.Text = progressBar3.Value.ToString();

            double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // yüzdesel ifade hesaplama
            label34.Text = progressPercentage.ToString("0.##") + "%";
        }
        public void HesaplaDill(int gram) // DILL için gerekli method
        {
            int kcalToAdd = 0;
            double proteinToAdd = 0;
            double karbonhidratToAdd = 0;
            double yagToAdd = 0;

            
            if (gram == 50)
            {
                kcalToAdd = 22;
                proteinToAdd = 1.75;
                karbonhidratToAdd = 3.5;
                yagToAdd = 1;
                // diğer değişkenlerin değerlerini atayın
            }
            else if (gram == 100)
            {
                kcalToAdd = 43;
                proteinToAdd = 3.5;
                karbonhidratToAdd = 7;
                yagToAdd = 1;
                // diğer değişkenlerin değerlerini atayın
            }
            else if (gram == 150)
            {
                kcalToAdd = 65;
                proteinToAdd = 5.25;
                karbonhidratToAdd = 10.5;
                yagToAdd = 1.2;
                // diğer değişkenlerin değerlerini atayın
            }
            else if (gram == 200)
            {
                kcalToAdd = 86;
                proteinToAdd = 7;
                karbonhidratToAdd = 14;
                yagToAdd = 1.5;
                // diğer değişkenlerin değerlerini atayın
            }

            // Kalori çubuğunu güncelle
            if (progressBar4.Value + kcalToAdd > progressBar4.Maximum) // kalori aşımı
            {
                kaloriuyari();
                centauriuyari();
            }
            else
            {
                progressBar4.Value += kcalToAdd;
            }
            totalkcal += kcalToAdd;
            label33.Text = totalkcal.ToString();

            // Protein çubuğunu güncelle
            if (progressBar1.Value + proteinToAdd > progressBar1.Maximum) // protein miktarı aşımı
            {
                proteinuyari();
                centauriuyari();
            }
            else
            {
                progressBar1.Value += (int)proteinToAdd;
            }
            label30.Text = progressBar1.Value.ToString();

            // Karbonhidrat çubuğunu güncelle
            if (progressBar2.Value + karbonhidratToAdd > progressBar2.Maximum) // karbonhidrat miktarı aşımı
            {
                karbonhidratuyari();
                centauriuyari();
            }
            else
            {
                progressBar2.Value += (int)karbonhidratToAdd;
            }
            label31.Text = progressBar2.Value.ToString();

            // Yağ çubuğunu güncelle
            if (progressBar3.Value + yagToAdd > progressBar3.Maximum) // yağ miktarı aşımı
            {
                yaguyari();
                centauriuyari();
            }
            else
            {
                progressBar3.Value += (int)yagToAdd;
            }
            label32.Text = progressBar3.Value.ToString();

            // Yüzdesel ifadeyi hesapla ve label34'e yansıt
            double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // progressbar4'e göre yüzde hesaplama
            label34.Text = progressPercentage.ToString("0.##") + "%"; // hesaplanan yüzde label'a aktarılıyor
        }
        public void HesaplaAvokado(int gram) // avokado için gerekli method ****************************************************************************************************************
        {
            int kcalToAdd;
            double proteinToAdd;
            double karbonhidratToAdd;
            double yagToAdd;

            if (gram == 50)
            {
                kcalToAdd = 80;
                proteinToAdd = 3;
                karbonhidratToAdd = 4;
                yagToAdd = 7;
            }
            else if (gram == 100)
            {
                kcalToAdd = 160;
                proteinToAdd = 6;
                karbonhidratToAdd = 8;
                yagToAdd = 14;
            }
            else if (gram == 150)
            {
                kcalToAdd = 240;
                proteinToAdd = 9;
                karbonhidratToAdd = 12;
                yagToAdd = 21;
            }
            else if (gram == 200)
            {
                kcalToAdd = 320;
                proteinToAdd = 12;
                karbonhidratToAdd = 16;
                yagToAdd = 28;
            }
            else
            {
                return; // Geçersiz gram değeri, işlem yapma
            }

            // Kalori çubuğunu güncelle
            if (progressBar4.Value + kcalToAdd > progressBar4.Maximum) // kalori aşımı
            {
                kaloriuyari();
                centauriuyari();
            }
            else
            {
                progressBar4.Value += kcalToAdd;
            }
            totalkcal += kcalToAdd;
            label33.Text = totalkcal.ToString();

            // Protein çubuğunu güncelle
            if (progressBar1.Value + proteinToAdd > progressBar1.Maximum) // protein miktarı aşımı
            {
                proteinuyari();
                centauriuyari();
            }
            else
            {
                progressBar1.Value += (int)proteinToAdd;
            }
            label30.Text = progressBar1.Value.ToString();

            // Karbonhidrat çubuğunu güncelle
            if (progressBar2.Value + karbonhidratToAdd > progressBar2.Maximum) // karbonhidrat miktarı aşımı
            {
                karbonhidratuyari();
                centauriuyari();
            }
            else
            {
                progressBar2.Value += (int)karbonhidratToAdd;
            }
            label31.Text = progressBar2.Value.ToString();

            // Yağ çubuğunu güncelle
            if (progressBar3.Value + yagToAdd > progressBar3.Maximum) // yağ miktarı aşımı
            {
                yaguyari();
                centauriuyari();
            }
            else
            {
                progressBar3.Value += (int)yagToAdd;
            }
            label32.Text = progressBar3.Value.ToString();

            // Yüzdesel ifadeyi hesapla ve label34'e yansıt
            double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // progressbar4'e göre yüzde hesaplama
            label34.Text = progressPercentage.ToString("0.##") + "%"; // hesaplanan yüzde label'a aktarılıyor
        }
        public void HesaplaBadem(int gram)
        {
            int kcalToAdd;
            double proteinToAdd;
            double karbonhidratToAdd;
            double yagToAdd;

            if (gram == 50)
            {
                kcalToAdd = 300;
                proteinToAdd = 20;
                karbonhidratToAdd = 4;
                yagToAdd = 40;
            }
            else if (gram == 100)
            {
                kcalToAdd = 600;
                proteinToAdd = 40;
                karbonhidratToAdd = 8;
                yagToAdd = 80;
            }
            else if (gram == 150)
            {
                kcalToAdd = 900;
                proteinToAdd = 60;
                karbonhidratToAdd = 12;
                yagToAdd = 120;
            }
            else if (gram == 200)
            {
                kcalToAdd = 1200;
                proteinToAdd = 80;
                karbonhidratToAdd = 16;
                yagToAdd = 160;
            }
            else
            {
                return; // Geçersiz gram değeri, işlem yapma
            }

            // Kalori çubuğunu güncelle
            if (progressBar4.Value + kcalToAdd > progressBar4.Maximum) // kalori aşımı
            {
                kaloriuyari();
                centauriuyari();
            }
            else
            {
                progressBar4.Value += kcalToAdd;
            }
            totalkcal += kcalToAdd;
            label33.Text = totalkcal.ToString();

            // Protein çubuğunu güncelle
            if (progressBar1.Value + proteinToAdd > progressBar1.Maximum) // protein miktarı aşımı
            {
                proteinuyari();
                centauriuyari();
            }
            else
            {
                progressBar1.Value += (int)proteinToAdd;
            }
            label30.Text = progressBar1.Value.ToString();

            // Karbonhidrat çubuğunu güncelle
            if (progressBar2.Value + karbonhidratToAdd > progressBar2.Maximum) // karbonhidrat miktarı aşımı
            {
                karbonhidratuyari();
                centauriuyari();
            }
            else
            {
                progressBar2.Value += (int)karbonhidratToAdd;
            }
            label31.Text = progressBar2.Value.ToString();

            // Yağ çubuğunu güncelle
            if (progressBar3.Value + yagToAdd > progressBar3.Maximum) // yağ miktarı aşımı
            {
                yaguyari();
                centauriuyari();
            }
            else
            {
                progressBar3.Value += (int)yagToAdd;
            }
            label32.Text = progressBar3.Value.ToString();

            // Yüzdesel ifadeyi hesapla ve label34'e yansıt
            double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // progressbar4'e göre yüzde hesaplama
            label34.Text = progressPercentage.ToString("0.##") + "%"; // hesaplanan yüzde label'a aktarılıyor
        }
        private void IncrementProgressBar(int incrementValue) // WATER için gerekli method *************************************************************************************************
        {
            // ProgressBar'ın mevcut değeri
            int currentValue = progressBar5.Value;

            // Artırılan değeri ekle
            int newValue = currentValue + incrementValue;

            // ProgressBar'ın maksimum değerini kontrol et
            if (newValue <= progressBar5.Maximum)
            {
                // ProgressBar'ın değerini güncelle
                progressBar5.Value = newValue;
            }
            else
            {
                // Aşım durumunda ProgressBar'ın değerini maksimum değere eşitle
                progressBar5.Value = progressBar5.Maximum;
                label43.ForeColor = Color.Red;
                label44.ForeColor = Color.Red;
            }

            // Label'ı güncelle
            label43.Text = progressBar5.Value.ToString();
        }
        public void HesaplaMuz(int gram) // MUZ için gerekli method *************************************************************************************************************
        {
            int kcalToAdd;
            double proteinToAdd;
            double karbonhidratToAdd;
            double yagToAdd;

            if (gram == 50)
            {
                kcalToAdd = 45;
                proteinToAdd = 1;
                karbonhidratToAdd = 10;
                yagToAdd = 1;
            }
            else if (gram == 100)
            {
                kcalToAdd = 90;
                proteinToAdd = 2;
                karbonhidratToAdd = 20;
                yagToAdd = 2;
            }
            else if (gram == 150)
            {
                kcalToAdd = 135;
                proteinToAdd = 3;
                karbonhidratToAdd = 30;
                yagToAdd = 3;
            }
            else if (gram == 200)
            {
                kcalToAdd = 180;
                proteinToAdd = 4;
                karbonhidratToAdd = 40;
                yagToAdd = 4;
            }
            else
            {
                return; // Geçersiz gram değeri, işlem yapma
            }

            // Kalori çubuğunu güncelle
            if (progressBar4.Value + kcalToAdd > progressBar4.Maximum) // kalori aşımı
            {
                kaloriuyari();
                centauriuyari();
            }
            else
            {
                progressBar4.Value += kcalToAdd;
            }
            totalkcal += kcalToAdd;
            label33.Text = totalkcal.ToString();

            // Protein çubuğunu güncelle
            if (progressBar1.Value + proteinToAdd > progressBar1.Maximum) // protein miktarı aşımı
            {
                proteinuyari();
                centauriuyari();
            }
            else
            {
                progressBar1.Value += (int)proteinToAdd;
            }
            label30.Text = progressBar1.Value.ToString();

            // Karbonhidrat çubuğunu güncelle
            if (progressBar2.Value + karbonhidratToAdd > progressBar2.Maximum) // karbonhidrat miktarı aşımı
            {
                karbonhidratuyari();
                centauriuyari();
            }
            else
            {
                progressBar2.Value += (int)karbonhidratToAdd;
            }
            label31.Text = progressBar2.Value.ToString();

            // Yağ çubuğunu güncelle
            if (progressBar3.Value + yagToAdd > progressBar3.Maximum) // yağ miktarı aşımı
            {
                yaguyari();
                centauriuyari();
            }
            else
            {
                progressBar3.Value += (int)yagToAdd;
            }
            label32.Text = progressBar3.Value.ToString();

            // Yüzdesel ifadeyi hesapla ve label34'e yansıt
            double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // progressbar4'e göre yüzde hesaplama
            label34.Text = progressPercentage.ToString("0.##") + "%"; // hesaplanan yüzde label'a aktarılıyor
        }
        public void HesaplaSut(int ml) // MILK için gerekli method ********************************************************************************************************************
        {
            int kcalToAdd;
            double proteinToAdd;
            double karbonhidratToAdd;
            double yagToAdd;

            if (ml == 180)
            {
                kcalToAdd = 112;
                proteinToAdd = 6;
                karbonhidratToAdd = 9;
                yagToAdd = 4;
            }
            else if (ml == 300)
            {
                kcalToAdd = 186;
                proteinToAdd = 10;
                karbonhidratToAdd = 15;
                yagToAdd = 9;
            }
            else
            {
                return; // Geçersiz ml değeri, işlem yapma
            }

            // Kalori çubuğunu güncelle
            if (progressBar4.Value + kcalToAdd > progressBar4.Maximum) // kalori aşımı
            {
                kaloriuyari();
                centauriuyari();
            }
            else
            {
                progressBar4.Value += kcalToAdd;
            }
            totalkcal += kcalToAdd;
            label33.Text = totalkcal.ToString();

            // Protein çubuğunu güncelle
            if (progressBar1.Value + proteinToAdd > progressBar1.Maximum) // protein miktarı aşımı
            {
                proteinuyari();
                centauriuyari();
            }
            else
            {
                progressBar1.Value += (int)proteinToAdd;
            }
            label30.Text = progressBar1.Value.ToString();

            // Karbonhidrat çubuğunu güncelle
            if (progressBar2.Value + karbonhidratToAdd > progressBar2.Maximum) // karbonhidrat miktarı aşımı
            {
                karbonhidratuyari();
                centauriuyari();
            }
            else
            {
                progressBar2.Value += (int)karbonhidratToAdd;
            }
            label31.Text = progressBar2.Value.ToString();

            // Yağ çubuğunu güncelle
            if (progressBar3.Value + yagToAdd > progressBar3.Maximum) // yağ miktarı aşımı
            {
                yaguyari();
                centauriuyari();
            }
            else
            {
                progressBar3.Value += (int)yagToAdd;
            }
            label32.Text = progressBar3.Value.ToString();

            // Yüzdesel ifadeyi hesapla ve label34'e yansıt
            double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // progressbar4'e göre yüzde hesaplama
            label34.Text = progressPercentage.ToString("0.##") + "%"; // hesaplanan yüzde label'a aktarılıyor
        }
        private void button9_Click(object sender, EventArgs e) // BANANA 9 *******************************************************************************************************************
        {
            if (comboBox9.Text != "50 GR" && comboBox9.Text != "100 GR" && comboBox9.Text != "150 GR" && comboBox9.Text != "200 GR") // öğelerden biri seçili değilse önle !
            {
                comboBox9.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if(comboBox9.Text == "50 GR")
            {
                HesaplaMuz(50);
            }
            else if (comboBox9.Text == "100 GR")
            {
                HesaplaMuz(100);
            }
            else if (comboBox9.Text == "150 GR")
            {
                HesaplaMuz(150);
            }
            else if (comboBox9.Text == "200 GR")
            {
                HesaplaMuz(200);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e) // EGG 1 **********************************************************************************************************************
        {
            if (comboBox1.Text != "50 GR" && comboBox1.Text != "100 GR" && comboBox1.Text != "150 GR" && comboBox1.Text != "200 GR") // öğelerden biri seçili değilse önle !
            {
                comboBox1.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if (comboBox1.Text == "50 GR")
            {
                HesaplaYumurta(50);
            }
            else if (comboBox1.Text == "100 GR")
            {
                HesaplaYumurta(100);
            }
            else if (comboBox1.Text == "150 GR")
            {
                HesaplaYumurta(150);
            }
            else if (comboBox1.Text == "200 GR")
            {
                HesaplaYumurta(200);
            }
        }
        private void progressBar4_Click(object sender, EventArgs e) // NULL
        {
        }

        private void label12_Click(object sender, EventArgs e) // null
        {
        }

        private void foodsform_Load(object sender, EventArgs e) // from load
        {
            this.progressBar4.Minimum = 0;
            this.progressBar4.Maximum = 2500; // günlük max kalori
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum = 100; // günlük max protein
            this.progressBar2.Minimum = 0;
            this.progressBar2.Maximum = 150; // günlük max karbonhidrat
            this.progressBar3.Minimum = 0;
            this.progressBar3.Maximum = 45; // günlük max yağ
            this.progressBar5.Minimum = 0;
            this.progressBar5.Maximum = 3000; // günlük max su
        }

        private void button14_Click(object sender, EventArgs e) // reset BUTTON
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;
            pictureBox14.Visible = false;
            label41.Visible = false;
            pictureBox13.Visible = false;
            label36.Visible = false;
            label43.Text = "0";
            label30.Text = "0";
            label31.Text = "0";
            label32.Text = "0";
            label33.Text = "0";
            label34.Text = "% 0";
            totalkcal = 0;
            label43.ForeColor = Color.White;
            label44.ForeColor = Color.White;
            label30.ForeColor = Color.White;
            label31.ForeColor = Color.White;
            label32.ForeColor = Color.White;
            label33.ForeColor = Color.White;
            label34.ForeColor = Color.White;
            label38.ForeColor = Color.White;
            label39.ForeColor = Color.White;
            label40.ForeColor = Color.White;
            label37.ForeColor = Color.White;
            label45.Text="Hello, be careful not to\r\nexceedthe nutritional values\r\nand calories during the day.\r\nIf you overdo it, you can consult me!\r\n";
            label45.ForeColor = Color.Lime;
        }

        private void button2_Click(object sender, EventArgs e) // OAT 2 ******************************************************************************************************************
        {
            if (comboBox2.Text != "50 GR" && comboBox2.Text != "100 GR" && comboBox2.Text != "150 GR" && comboBox2.Text != "200 GR") // öğelerden biri seçili değilse önle !
            {
                comboBox2.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if (comboBox2.Text == "50 GR")
            {
                HesaplaYulafEzmesi(50);
            }
            else if (comboBox2.Text == "100 GR")
            {
                HesaplaYulafEzmesi(100);
            }
            else if (comboBox2.Text == "150 GR")
            {
                HesaplaYulafEzmesi(150);
            }
            else if (comboBox2.Text == "200 GR")
            {
                HesaplaYulafEzmesi(200);
            }

        }

        private void button3_Click(object sender, EventArgs e) // RİCE 3 *********************************************************************************************************************
        {
            if (comboBox3.Text != "50 GR" && comboBox3.Text != "100 GR" && comboBox3.Text != "150 GR" && comboBox3.Text != "200 GR") // öğelerden biri seçili değilse önle !
            {
                comboBox3.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if(comboBox3.Text =="50 GR")
            {
                HesaplaRice(50);
            }
            else if (comboBox3.Text == "100 GR")
            {
                HesaplaRice(100);
            }
            else if (comboBox3.Text == "150 GR")
            {
                HesaplaRice(150);
            }
            else if (comboBox3.Text == "200 GR")
            {
                HesaplaRice(200);
            }
        }

        private void button4_Click(object sender, EventArgs e) // CHİCKEN MEAT ***********************************************************************************************************
        {
            if (comboBox4.Text != "50 GR" && comboBox4.Text != "100 GR" && comboBox4.Text != "150 GR" && comboBox4.Text != "200 GR") // öğelerden biri seçili değilse önle !
            {
                comboBox4.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if(comboBox4.Text == "50 GR")
            {
                HesaplaChickenMeat(50);
            }
            else if (comboBox4.Text == "100 GR")
            {
                HesaplaChickenMeat(100);
            }
            else if (comboBox4.Text == "150 GR")
            {
                HesaplaChickenMeat(150);
            }
            else if (comboBox4.Text == "200 GR")
            {
                HesaplaChickenMeat(200);
            }
        }

        private void button5_Click(object sender, EventArgs e) // DILL 5 *****************************************************************************************************************
        {
            if (comboBox5.Text != "50 GR" && comboBox5.Text != "100 GR" && comboBox5.Text != "150 GR" && comboBox5.Text != "200 GR") // öğelerden biri seçili değilse önle !
            {
                comboBox5.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if(comboBox5.Text == "50 GR")
            {
                HesaplaDill(50);
            }
            else if (comboBox5.Text == "100 GR")
            {
                HesaplaDill(100);
            }
            else if (comboBox5.Text == "150 GR")
            {
                HesaplaDill(150);
            }
            else if (comboBox5.Text == "200 GR")
            {
                HesaplaDill(200);
            }
        }

        private void button6_Click(object sender, EventArgs e) // CHEESE 6 **********************************************************************************************************************
        {
            if (comboBox6.Text != "50 GR" && comboBox6.Text != "100 GR" && comboBox6.Text != "150 GR" && comboBox6.Text != "200 GR") // öğelerden biri seçili değilse önle !
            {
                comboBox6.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if(comboBox6.Text == "50 GR")
            {
                HesaplaPeynir(50);
            }
            else if(comboBox6.Text == "100 GR")
            {
                HesaplaPeynir(100);
            }
            else if(comboBox6.Text == "150 GR")
            {
                HesaplaPeynir(150);
            }
            else if (comboBox6.Text == "200 GR")
            {
                HesaplaPeynir(200);
            }
        }

        private void button7_Click(object sender, EventArgs e) // AVOKADO 7 *****************************************************************************************************************
        {
            if (comboBox7.Text != "50 GR" && comboBox7.Text != "100 GR" && comboBox7.Text != "150 GR" && comboBox7.Text != "200 GR") // öğelerden biri seçili değilse önle !
            {
                comboBox7.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if(comboBox7.Text == "50 GR")
            {
                HesaplaAvokado(50);
            }
            else if (comboBox7.Text == "100 GR")
            {
                HesaplaAvokado(100);
            }
            else if (comboBox7.Text == "150 GR")
            {
                HesaplaAvokado(150);
            }
            else if (comboBox7.Text == "200 GR")
            {
                HesaplaAvokado(200);
            }
        }

        private void button8_Click(object sender, EventArgs e) // ALMOND 8 ***************************************************************************************************************
        {
            if (comboBox8.Text != "50 GR" && comboBox8.Text != "100 GR" && comboBox8.Text != "150 GR" && comboBox8.Text != "200 GR") // öğelerden biri seçili değilse önle !
            {
                comboBox8.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if(comboBox8.Text == "50 GR")
            {
                HesaplaBadem(50);
            }
            else if (comboBox8.Text == "100 GR")
            {
                HesaplaBadem(100);
            }
            else if (comboBox8.Text == "150 GR")
            {
                HesaplaBadem(150);
            }
            else if (comboBox8.Text == "200 GR")
            {
                HesaplaBadem(200);
            }
        }

        private void button10_Click(object sender, EventArgs e) // WATER 10 ****************************************************************************************************************
        {
            int currentValue = progressBar5.Value;
            if (comboBox10.Text != "1 cup(300ml)" && comboBox10.Text != "1 bottled of water(500ml)" && comboBox10.Text != "1 LT")
            {
                comboBox10.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if (comboBox10.Text == "1 cup(300ml)")
            {
                IncrementProgressBar(300);
                label43.Text = progressBar5.Value.ToString();
            }
            else if (comboBox10.Text == "1 bottled of water(500ml)")
            {
                IncrementProgressBar(500);
                label43.Text = progressBar5.Value.ToString();
            }
            else if (comboBox10.Text == "1 LT")
            {
                IncrementProgressBar(1000);
                label43.Text = progressBar5.Value.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e) // MILK 11  *******************************************************************************************************************
        {
            if (comboBox11.Text != "little milk(180ml)" && comboBox11.Text != "1 cup(300ml)")
            {
                comboBox11.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if(comboBox11.Text == "little milk(180ml)")
            {
                HesaplaSut(180);
            }
            else if( comboBox11.Text =="1 cup(300ml)")
            {
                HesaplaSut(300);
            }
        }

        private void button12_Click(object sender, EventArgs e) // FILTER COFFEE 12 ***********************************************************************************************************
        {
            if (comboBox12.Text != "small cup(100ml)" && comboBox12.Text != "large cup(300ml)")
            {
                comboBox12.Text = "AMOUNT";
                MessageBox.Show("PLEASE ENTER QUANTITY !!");
            }
            else if(comboBox12.Text == "small cup(100ml)")
            {
                progressBar4.Value += 1;
                label33.Text = progressBar4.Value.ToString(); // kalori miktarını gösteren label
                double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // progressbar4'e göre yüzde hesaplama
                label34.Text = progressPercentage.ToString("0.##") + "%"; // hesaplanan yüzde label'a aktarılıyor
            }
            else if(comboBox12.Text == "large cup(300ml)")
            {
                progressBar4.Value += 3;
                label33.Text = progressBar4.Value.ToString(); // kalori miktarını gösteren label
                double progressPercentage = (double)progressBar4.Value / progressBar4.Maximum * 100; // progressbar4'e göre yüzde hesaplama
                label34.Text = progressPercentage.ToString("0.##") + "%"; // hesaplanan yüzde label'a aktarılıyor
            }
        }
    }
}
