using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Menu yeni = new Menu();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach(string crb in yeni.corbalar)
            {
                corbacmb.Items.Add(crb);
            }
            foreach(string ymk in yeni.yemekler)
            {
                yemekcmb.Items.Add(ymk);
            }
            foreach(string tatli in yeni.tatlilar)
            {
                tatlicmb.Items.Add(tatli);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Siparis_Btn_Click(object sender, EventArgs e)
        {
            CorbaList.Items.Add(yeni.birles_corba);
            YemekList.Items.Add(yeni.birles_yemek);
            TatliList.Items.Add(yeni.birles_tatli);
            MasaList.Items.Add(MasaNo.Value.ToString());
            //IcecekList.Items.Add(yeni.birles_icecek);

            if (Su_Radio.Checked)
            {
                IcecekList.Items.Add(yeni.birles_icecek);
            }
            else if (Cola_Radio.Checked)
            {
                IcecekList.Items.Add(yeni.birles_icecek);
            }
            else if (Ayran_Radio.Checked)
            {
                IcecekList.Items.Add(yeni.birles_icecek);
            }
            else 
            {
                MessageBox.Show("Secim Yapmadınız");
            }
            Toplam.Text = yeni.fatura_odeme();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CorbaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void corbacmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            yeni.corba_hesap(corbacmb.Text);
        }

        private void yemekcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            yeni.AnaYemek_hesap(yemekcmb.Text);
        }

        private void tatlicmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            yeni.tatli_hesap(tatlicmb.Text);
        }

        private void Toplam_Click(object sender, EventArgs e)
        {
            
        }

        private void IcecekList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
