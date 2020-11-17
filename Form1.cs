using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikFonskiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void BtnMutlak_Click(object sender, EventArgs e)
        {
            int deger = Convert.ToInt32(textBox1.Text);
            int pozitif = Math.Abs(deger); //mutlak değer alma.
            label4.Text = pozitif.ToString();
        }

        private void BtnYukarı_Click(object sender, EventArgs e)
        {
            double deger = Convert.ToDouble(textBox1.Text);
            double yuvarla = Math.Ceiling(Convert.ToDouble(deger)); //bir üstteki rakama yuvarlar.
            label4.Text = yuvarla.ToString();
        }

        private void BtnAsagi_Click(object sender, EventArgs e)
        {
            double deger = Convert.ToDouble(textBox1.Text);
            double yuvarla = Math.Floor(Convert.ToDouble(deger)); //bir alttaki rakama yuvarlar.
            label4.Text = yuvarla.ToString();
        }

        private void BtnKok_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            double sonuc = Math.Sqrt(sayi); //sayının kökü
            label4.Text = sonuc.ToString();
        }

        private void BtnSin_Click(object sender, EventArgs e)
        {
            double deger = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Sin(deger);
            label4.Text = sonuc.ToString();
       }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            double deger = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Cos(deger);
            label4.Text = sonuc.ToString();
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            double deger = Convert.ToDouble(textBox1.Text);
            double sonuc = Math.Tan(deger);
            label4.Text = sonuc.ToString();
        }


        private void BtnPi_Click(object sender, EventArgs e)
        {
            double deger = Math.PI;
            label4.Text = deger.ToString();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox2.Text);
            double sayı2 = Convert.ToDouble(textBox3.Text);
            double buyukdeger = Math.Max(sayı1, sayı2);
            label5.Text = buyukdeger.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox2.Text);
            double sayı2 = Convert.ToDouble(textBox3.Text);
            double kucukdeger = Math.Min(sayı1, sayı2);
            label5.Text = kucukdeger.ToString();
        }

        private void BtnUs_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox2.Text);
            double sayı2 = Convert.ToDouble(textBox3.Text);
            double us = Math.Pow(sayı1, sayı2);
            label5.Text = us.ToString();
        }

        private void BtnKalan_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox2.Text);
            double sayı2 = Convert.ToDouble(textBox3.Text);
            double deger = Math.IEEERemainder(sayı1, sayı2);
            label5.Text = deger.ToString();
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            double sayı1 = Convert.ToDouble(textBox2.Text);
            double sayı2 = Convert.ToDouble(textBox3.Text);
            double logaritma = Math.Log(sayı1, sayı2);
            label5.Text = logaritma.ToString();

        }
    }
}
