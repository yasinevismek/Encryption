﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiguvenligi
{
   
    public partial class Form1 : Form
    {
        public Form1()
        { 
       
            InitializeComponent();
            
        }

        
     
    private void Form1_Load(object sender, EventArgs e)
        {
           
            comboBox1.Items.Add("Ceasar");
            comboBox1.Items.Add("Sütun");
            comboBox1.Items.Add("Çit");
            comboBox1.Items.Add("MatrisYardımıyla");
            comboBox1.Items.Add("Polybius");
        }
        void CeasarCoz()
        {
            int anahtar = Convert.ToInt32(textBox3.Text);
            string sifrelimetin = textBox2.Text;
            string acikmetin = "";
            char[] chrText = sifrelimetin.ToCharArray();
            for (int i = 0; i < chrText.Length; i++)
            {
                acikmetin = acikmetin + (char)(chrText[i] - anahtar);
            }
            textBox5.Text = acikmetin;
        }
        void CitCoz()
        {
            string sifrelimetin = textBox2.Text;
            string ilk = "", son = "", acikmetin = "", xx = "";
            if (sifrelimetin.Length % 2 == 0)
            {
                ilk = sifrelimetin.Substring(0, sifrelimetin.Length / 2);
                son = sifrelimetin.Substring(sifrelimetin.Length / 2);
                for (int i = 0; i < sifrelimetin.Length / 2; i++)
                {
                    acikmetin += ilk[i].ToString() + son[i].ToString();
                }
                textBox5.Text = acikmetin;
            }
            else
            {
                ilk = sifrelimetin.Substring(0, (sifrelimetin.Length / 2) + 1);
                son = sifrelimetin.Substring((sifrelimetin.Length / 2) + 1);
                for (int i = 0; i < (sifrelimetin.Length / 2); i++)
                {
                    acikmetin += ilk[i].ToString() + son[i].ToString();
                }
                for (int i = 0; i < ilk.Length; i++)
                {
                    xx = ilk[i].ToString();
                }
                textBox5.Text = acikmetin + xx;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Ceasar")
            {
                CeasarCoz();
            }
            if(comboBox1.Text=="MatrisYardımıyla")
            {
                MessageBox.Show("Bu özellik bulunmuyor.");
            }
            if (comboBox1.Text == "Çit")
            {
                CitCoz();
            }
            if (comboBox1.Text == "Sütun")
            {
                MessageBox.Show("Bu özellik bulunmuyor.");
            }
            if (comboBox1.Text == "Polybius")
            {
                MessageBox.Show("Bu özellik bulunmuyor.");
            }
        }
       public string Ceasar(string acikmetin,int anahtar)
        {
            textBox4.Text = "";
            string sifrelimetin = "";
            char[] chrText = acikmetin.ToCharArray();
            for (int i = 0; i < chrText.Length; i++)
            {
                sifrelimetin = sifrelimetin + (char)(chrText[i] + anahtar);
            }
            textBox2.Text = sifrelimetin;
            return sifrelimetin;
        }
        public string Sutun(string acikmetin,int anahtar)
        {
            textBox3.Text = "";
            int sayac = 0;
            string sifrelimetin = "";
            Random rnd = new Random();
            int matrisboy = 0;
            if (acikmetin.Length % anahtar != 0)
            {
                matrisboy = ((acikmetin.Length / anahtar) + 1) * anahtar;
            }
            int s1 = matrisboy - acikmetin.Length;
            if (matrisboy > acikmetin.Length)
            {
                for (int i = 0; i < s1; i++)
                {
                    int kod = rnd.Next(97, 122);
                    acikmetin += Convert.ToChar(kod);
                }
            }

            char[] chrText = acikmetin.ToCharArray();
            char[,] matris = new char[chrText.Length / anahtar, anahtar];


            for (int i = 0; i < chrText.Length / anahtar; i++)
            {
                for (int j = 0; j < anahtar; j++)
                {
                    matris[i, j] = chrText[sayac];
                    sayac++;
                }
            }
            for (int i = 0; i < anahtar; i++)
            {
                for (int j = 0; j < chrText.Length / anahtar; j++)
                {
                    sifrelimetin += matris[j, i];
                }
            }
            textBox2.Text = sifrelimetin;
            return sifrelimetin;
        }
        public string Cit(string acikmetin)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            char[] chrText = acikmetin.ToCharArray();
            string tek = "";
            string cift = "";
            for (int i = 0; i < chrText.Length; i += 2)
            {
                tek += chrText[i].ToString();
            }
            for (int i = 1; i < chrText.Length; i = i + 2)
            {
                cift += chrText[i].ToString();
            }
            textBox2.Text = tek.ToString() + cift.ToString();
            return textBox2.Text;
        }
        public string  MatrisYardimiyla(string acikmetin)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            string metin = acikmetin.Replace(" ", "0");
            int matrisboy = 0;
            if (metin.Length % 3 != 0)
            {
                matrisboy = (((metin.Length / 3) + 1) * 3);
            }
            int s1 = matrisboy - metin.Length;
            if (matrisboy > metin.Length)
            {
                for (int i = 0; i < s1; i++)
                {
                    metin += 0;
                }
            }

            int[] alfabeindis = new int[metin.Length];
            for (int i = 0; i < metin.Length; i++)
            {
                alfabeindis[i] = metin[i];
                if (alfabeindis[i] == 48)
                    alfabeindis[i] = 0;
            }
            int sayac = 0;
            int[,] matris = new int[3, (alfabeindis.Length) / 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < (alfabeindis.Length) / 3; j++)
                {
                    matris[i, j] = alfabeindis[sayac];
                    sayac++;
                }
            }
            int[,] m = new int[3, 3] { { 3, 2, 2 }, { 0, 1, 0 }, { 1, 0, 1 } };
            int[,] sifreli = new int[m.GetUpperBound(0) + 1, matris.GetUpperBound(1) + 1];
            for (int i = 0; i <= m.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matris.GetUpperBound(1); j++)
                {
                    int toplam = 0;
                    for (int k = 0; k <= m.GetUpperBound(1); k++)
                    {
                        toplam += m[i, k] * matris[k, j];
                    }
                    sifreli[i, j] = toplam;
                }
            }
            string sifrelimetin = "";
            for (int i = 0; i < m.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matris.GetUpperBound(1) + 1; j++)
                {
                    sifrelimetin += sifreli[i, j].ToString();
                    //sifrelimetin += " ";
                }
                //sifrelimetin += Environment.NewLine;
            }
            textBox2.Text = sifrelimetin;
            return sifrelimetin;
        }
        public string Polybius(string acikmetin)
        {
            textBox4.Text = "";
            textBox3.Text = "";
            string acikmetin1 = acikmetin.Replace("ç", "c").Replace("ö", "o").Replace("ü", "u").Replace("ı", "i");
            char[] chrText = acikmetin1.ToCharArray();
            string[] sifrelimetin = new string[2 * (chrText.Length)];
            string sonuc = "";
            int sayac = 0;
            char[,] matrisalfabe = new char[5, 5] { { 'a', 'b', 'c', 'd', 'e' },{'f','g','h','i','j' },
                                                {'k','l','m','n','o'},{'p','r','s','ş','t' },
                                                { 'u','ü','v','y','z' } };


            for (int k = 0; k < chrText.Length; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (matrisalfabe[i, j] == chrText[k])
                        {

                            sifrelimetin[sayac] = Convert.ToString(i) + Convert.ToString(j);
                            sayac++;
                        }
                    }
                }
            }
            for (int i = 0; i < 2 * (chrText.Length); i++)
            {
                sonuc = sonuc + sifrelimetin[i] + " ";
            }
            sonuc = sonuc.Trim();
            textBox2.Text = sonuc;
            
            return sonuc;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text=="Ceasar")
            {
                Ceasar(textBox1.Text,Int32.Parse(textBox3.Text));
            }
           
            if (comboBox1.Text == "Sütun")
            {
                Sutun(textBox1.Text, Int32.Parse(textBox4.Text));   
            }
            if (comboBox1.Text == "Çit")
            {
                Cit(textBox1.Text);    
            }
            if (comboBox1.Text == "MatrisYardımıyla")
            {
                MatrisYardimiyla(textBox1.Text);
            }
            if (comboBox1.Text == "Polybius")
            {
                Polybius(textBox1.Text);
            }
        }
       
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
