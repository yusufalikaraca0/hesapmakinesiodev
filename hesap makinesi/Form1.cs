using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void temizle()
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            sayi1 = 0;
            sayi2 = 0;

        }
        public  int sayi1;
        public  int sayi2;
        public  string islemturu;
        class islemler
        {

            public int sayi1;
            public int sayi2;
            public string islemturu;
            void debug()
            {
             
            }
            
            public  int carpma()
            {
                
                int toplam = sayi1 * sayi2;
                return toplam;
            }
            public int toplama()
            {
                int toplam = sayi1 + sayi2;
                return toplam;
            }
            public  int bolme()
            {
                int toplam=0;
                try
                {
                     toplam = sayi1 / sayi2;
                    
                }
                catch (System.DivideByZeroException)
                {
                    toplam = 0;
                    MessageBox.Show("Hatalı Sözdizimi Lütfen Tekrar Deneyiniz");
                    return toplam;
                    

                }
                return toplam;
                
                    
                
                



            }
           public int cikarma()
            {
                int toplam = sayi1 - sayi2;
                return toplam;
            }

       
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (sonrakitustatemizle)
                textBox1.Text = button1.Text;
            else
            textBox1.Text += button1.Text;
            sonrakitustatemizle = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sonrakitustatemizle)
                textBox1.Text = button10.Text;
            else
            textBox1.Text += button10.Text;
            sonrakitustatemizle = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sonrakitustatemizle)
                textBox1.Text = button9.Text;
            else
            textBox1.Text += button9.Text;
            sonrakitustatemizle = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (sonrakitustatemizle)
                textBox1.Text = button6.Text;
            else
            textBox1.Text += button6.Text;
            sonrakitustatemizle = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sonrakitustatemizle)
                textBox1.Text = button8.Text;
            else
            textBox1.Text += button8.Text;
            sonrakitustatemizle = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sonrakitustatemizle)
                textBox1.Text = button7.Text;
            else
            textBox1.Text += button7.Text;
            sonrakitustatemizle = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sonrakitustatemizle)
                textBox1.Text = button5.Text;
            else
            textBox1.Text += button5.Text;
            sonrakitustatemizle = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sonrakitustatemizle)
                textBox1.Text = button4.Text;
            else
            textBox1.Text += button4.Text;
            sonrakitustatemizle = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sonrakitustatemizle)
                textBox1.Text = button3.Text;
            else
            textBox1.Text += button3.Text;
            sonrakitustatemizle = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sonrakitustatemizle)
                textBox1.Text = button2.Text;
            else
            textBox1.Text += button2.Text;
            sonrakitustatemizle = false;
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            islemturu = "carpma";
            sayi1 = int.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            label2.Text = islemturu;
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islemturu = "bolme";
            sayi1 = int.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            label2.Text = islemturu;
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            islemturu = "toplama";
            sayi1 = int.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            label2.Text = islemturu;
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islemturu = "cikarma";
            sayi1 = int.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            textBox1.Text = "";
        }
        bool sonrakitustatemizle;
        private void button15_Click(object sender, EventArgs e)
        {

           
            if(label1.Text !="" && islemturu !=""&& textBox1.Text !="") {
                sayi1 = int.Parse(label1.Text);
                sayi2 = int.Parse(textBox1.Text);
                islemler islemim = new islemler();
                islemim.sayi1 = sayi1;
                islemim.sayi2 = sayi2;
                islemim.islemturu = islemturu;


                if (islemim.islemturu == "toplama")
                    textBox1.Text = islemim.toplama().ToString();
                if (islemim.islemturu == "cikarma")
                    textBox1.Text = islemim.cikarma().ToString();
                if (islemim.islemturu == "carpma")
                    textBox1.Text = islemim.carpma().ToString();
                if (islemim.islemturu == "bolme")
                    textBox1.Text=islemim.bolme().ToString();

                sayi1 = 0;
                sayi2 = 0;
                label1.Text = "";
                label2.Text = "";
                sonrakitustatemizle = true;

            }
            else { MessageBox.Show("Lütfen Sayı giriniz..");}
            
       




        }
       
        private void button16_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length -1);
        }
    }
}
