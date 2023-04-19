using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace takımuygulaması
{
    public partial class Form1 : Form
    {
        #region oyuncu fotolar
        string[] kaleci = Directory.GetFiles(@"C:\Users\Osman ŞAHİN\Desktop\futbolcular\kaleciler", "*.jpg");
        string[] defans = Directory.GetFiles(@"C:\Users\Osman ŞAHİN\Desktop\futbolcular\defanslar", "*.jpg");
        string[] ortasaha = Directory.GetFiles(@"C:\Users\Osman ŞAHİN\Desktop\futbolcular\ortasaha", "*.jpg");
        string[] forvet = Directory.GetFiles(@"C:\Users\Osman ŞAHİN\Desktop\futbolcular\forvet", "*.jpg");
        string[] logolar = Directory.GetFiles(@"C:\Users\Osman ŞAHİN\Desktop\futbolcular\logolar", "*.jpg");
        int[] takım1 = new int[11];
        int[] takım2 = new int[11];
        #endregion
        static float win1(float min, float max)
        {
            System.Random random1 = new System.Random();
            double val1= (random1.NextDouble() * (max - min) + min);
            return (float)val1;
        }
        static float draw(float min, float max)
        {
            System.Random random2 = new System.Random();
            double val2 = (random2.NextDouble() * (max - min) + min);
            return (float)val2;
        }
        static float win2(float min, float max)
        {
            System.Random random3 = new System.Random();
            double val3 = (random3.NextDouble() * (max - min) + min);
            return (float)val3;
        }
        void takımgetir()
        {
            Random r = new Random();
            pictureBox1.ImageLocation = kaleci[r.Next(0, kaleci.Length)];
            pictureBox22.ImageLocation = kaleci[r.Next(0, kaleci.Length)];
            //defanslar
            pictureBox2.ImageLocation = defans[r.Next(0, defans.Length)];
            pictureBox3.ImageLocation = defans[r.Next(0, defans.Length)];
            pictureBox4.ImageLocation = defans[r.Next(0, defans.Length)];
            pictureBox5.ImageLocation = defans[r.Next(0, defans.Length)];

            pictureBox18.ImageLocation = defans[r.Next(0, defans.Length)];
            pictureBox19.ImageLocation = defans[r.Next(0, defans.Length)];
            pictureBox20.ImageLocation = defans[r.Next(0, defans.Length)];
            pictureBox21.ImageLocation = defans[r.Next(0, defans.Length)];
            //ortasaha
            pictureBox6.ImageLocation = ortasaha[r.Next(0, ortasaha.Length)];
            pictureBox7.ImageLocation = ortasaha[r.Next(0, ortasaha.Length)];
            pictureBox8.ImageLocation = ortasaha[r.Next(0, ortasaha.Length)];
            pictureBox9.ImageLocation = ortasaha[r.Next(0, ortasaha.Length)];
            pictureBox10.ImageLocation = ortasaha[r.Next(0, ortasaha.Length)];

            pictureBox13.ImageLocation = ortasaha[r.Next(0, ortasaha.Length)];
            pictureBox14.ImageLocation = ortasaha[r.Next(0, ortasaha.Length)];
            pictureBox15.ImageLocation = ortasaha[r.Next(0, ortasaha.Length)];
            pictureBox16.ImageLocation = ortasaha[r.Next(0, ortasaha.Length)];
            pictureBox17.ImageLocation = ortasaha[r.Next(0, ortasaha.Length)];
            //forvet
            pictureBox11.ImageLocation = forvet[r.Next(0, forvet.Length)];
            pictureBox12.ImageLocation = forvet[r.Next(0, forvet.Length)];
        }
        void logogetir()
        {
            //logo getirme:
            if (comboBox1.Text == "Galatasaray")
            {
                pictureBox24.ImageLocation = logolar[2];
            }
            else if (comboBox1.Text == "Beşiktaş")
            {
                pictureBox24.ImageLocation = logolar[1];
            }
            else if (comboBox1.Text == "Fenerbahçe")
            {
                pictureBox24.ImageLocation = logolar[0];
            }

            if (comboBox2.Text == "Galatasaray")
            {
                pictureBox23.ImageLocation = logolar[2];
            }
            else if (comboBox2.Text == "Beşiktaş")
            {
                pictureBox23.ImageLocation = logolar[1];
            }
            else if (comboBox2.Text == "Fenerbahçe")
            {
                pictureBox23.ImageLocation = logolar[0];
            }
        }
        void takımgucleri()
        {
            //takım güçleri 1. Takım

            for (int i = 0; i < takım1.Length; i++)
            {
                Random güç = new Random();
                int güçs = güç.Next(80, 90);
                takım1[i] = güçs;
            }
            int overal;
            int toplam = 0;

            for (int i = 0; i < takım1.Length; i++)
            {
                toplam = toplam + takım1[i];
            }
            overal = toplam / 11;
            label11.Text = Convert.ToString(overal);

            //takım güçleri 2.Takım

            for (int i = 0; i < takım2.Length; i++)
            {
                Random güç1 = new Random();
                int güçss = güç1.Next(80, 90);
                takım2[i] = güçss;
            }
            int overal1;
            int toplam1 = 0;

            for (int i = 0; i < takım2.Length; i++)
            {
                toplam1 = toplam1 + takım2[i];
            }
            overal1 = toplam1 / 10;
            label10.Text = Convert.ToString(overal1);
        }
        void skor()
        {
            Random skor = new Random();
            int sayi1 = skor.Next(0, 5);
            int sayi2 = skor.Next(0, 5);

            label5.Text = Convert.ToString(sayi1);
            label6.Text = Convert.ToString(sayi2);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                takımgetir();
                logogetir();
                takımgucleri();
                float x = 1, y = 2;
                oranlarlbl.Text = $"{Math.Round(win1(x, y), 2)}/{Math.Round(draw(x, y), 2)}/{Math.Round(win2(x, y), 2)}";
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        private void maçıbaşlatbuton_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
                skor();
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
