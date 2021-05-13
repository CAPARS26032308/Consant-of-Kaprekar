using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje65_KaprekarSabiti
{
    public partial class Form1 : Form
    {
        Random rast = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            SayiUret();
        }
        public void SayiUret()
        {
            int[] RastgeleSayilar = new int[4];

            for (int i = 0; i <4; i++)
            {
                RastgeleSayilar[i] = rast.Next(0, 10);
            }
            label1.Text = RastgeleSayilar[0].ToString();
            label2.Text = RastgeleSayilar[1].ToString();
            label3.Text = RastgeleSayilar[2].ToString();
            label4.Text = RastgeleSayilar[3].ToString();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {           
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            txtByk1.Text = "";
            txtKck1.Text = "";
            txtFark1.Text = "";
            txtByk2.Text = "";
            txtKck2.Text = "";
            txtFark2.Text = "";
            txtByk3.Text = "";
            txtKck3.Text = "";
            txtFark3.Text = "";
            txtByk4.Text = "";
            txtKck4.Text = "";
            txtFark4.Text = "";
            txtByk5.Text = "";
            txtKck5.Text = "";
            txtFark5.Text = "";
            txtByk6.Text = "";
            txtKck6.Text = "";
            txtFark6.Text = "";
            txtByk7.Text = "";
            txtKck7.Text = "";
            txtFark7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int Fark1 = 0;
            Fark1 = Convert.ToInt32(txtByk1.Text) - Convert.ToInt32(txtKck1.Text);
            txtFark1.Text = Fark1.ToString();
            if (Fark1 != 6174)
            {
                MessageBox.Show("İşleme devam ediniz!");
            }
            else
                MessageBox.Show("Tebrikler!Kabrekar sabitini buldunuz");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Fark2 = 0;
            Fark2 = Convert.ToInt32(txtByk2.Text) - Convert.ToInt32(txtKck2.Text);
            txtFark2.Text = Fark2.ToString();
            if (Fark2 != 6174)
            {
                MessageBox.Show("İşleme devam ediniz!");
            }
            else                
            MessageBox.Show("Tebrikler!Kabrekar sabitini buldunuz");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Fark3 = 0;
            Fark3 = Convert.ToInt32(txtByk3.Text) - Convert.ToInt32(txtKck3.Text);
            txtFark3.Text = Fark3.ToString();
            if (Fark3 != 6174)
            {
                MessageBox.Show("İşleme devam ediniz!");
            }
            else
                MessageBox.Show("Tebrikler!Kabrekar sabitini buldunuz");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Fark4 = 0;
            Fark4 = Convert.ToInt32(txtByk4.Text) - Convert.ToInt32(txtKck4.Text);
            txtFark4.Text = Fark4.ToString();
            if (Fark4 != 6174)
            {
                MessageBox.Show("İşleme devam ediniz!");
            }
            else
                MessageBox.Show("Tebrikler!Kabrekar sabitini buldunuz");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Fark5 = 0;
            Fark5 = Convert.ToInt32(txtByk5.Text) - Convert.ToInt32(txtKck5.Text);
            txtFark5.Text = Fark5.ToString();
            if (Fark5 != 6174)
            {
                MessageBox.Show("İşleme devam ediniz!");
            }
            else
                MessageBox.Show("Tebrikler!Kabrekar sabitini buldunuz");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int Fark6 = 0;
            Fark6 = Convert.ToInt32(txtByk6.Text) - Convert.ToInt32(txtKck6.Text);
            txtFark6.Text = Fark6.ToString();
            if (Fark6 != 6174)
            {
                MessageBox.Show("İşleme devam ediniz!");
            }
            else
                MessageBox.Show("Tebrikler!Kabrekar sabitini buldunuz");
        }

        private void button8_Click(object sender, EventArgs e)
        {

            int Fark7 = 0;
            Fark7 = Convert.ToInt32(txtByk7.Text) - Convert.ToInt32(txtKck7.Text);
            txtFark7.Text = Fark7.ToString();
            if (Fark7 != 6174)
            {
                MessageBox.Show("İşleme devam ediniz!");
            }
            else
                MessageBox.Show("Tebrikler!Kabrekar sabitini buldunuz");
           
        }
    }
}
