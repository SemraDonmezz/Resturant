using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant
{
    internal class Menu
    {
       public string[] corbalar = { "Ezo Gelin", "Mercimek", "Tavuk Suyu", "Paca" };
        private int[] fiyat_corba = { 20, 15, 25, 30 }; 
       public string[] yemekler = { "Sulu Köfte", "Ciger Sote", "Coban Kavurma", "Tas kebabı" };
        private int[] fiyat_yemek = { 25, 20, 35, 30 };
       public string[] tatlilar = { "Sutlac", "Baklava", "Kazandibi" };
        private int[] fiyat_tatli = {15,20,25};
        public string[] icecekler = { "Su", "Cola", "Ayran", "Soda" };
        private int[] fiyat_icecek = { 5, 10, 10, 7 };

        public int corba_fiyat;
        public int tatli_fiyat;
        public int yemek_fiyat;
        public int icecek_fiyat;

        public string birles_corba;
        public string birles_yemek;
        public string birles_tatli;
        public string birles_icecek;

        public void corba_hesap(string deger)
        {
            int sira = Array.IndexOf(corbalar, deger);
            this.corba_fiyat = this.fiyat_corba[sira];
            this.birles_corba = deger + " " + corba_fiyat;
        }

        public void AnaYemek_hesap(string deger)
        {
            int sira = Array.IndexOf(yemekler, deger);
            this.yemek_fiyat = this.fiyat_yemek[sira];
            this.birles_yemek = deger + " " + yemek_fiyat;
        }

        public void tatli_hesap(string deger)
        {
            int sira = Array.IndexOf(tatlilar, deger);
            this.tatli_fiyat = this.fiyat_tatli[sira];
            this.birles_tatli = deger + " " + tatli_fiyat;
        }

        public void icecek_hesap(string deger)
        {
            int sira = Array.IndexOf(icecekler,deger);
            this.icecek_fiyat = this.fiyat_icecek[sira];
            this.birles_icecek = deger + " " + icecek_fiyat;

        }

        public string fatura_odeme()
        {
            return Convert.ToString(this.yemek_fiyat + this.corba_fiyat + this.tatli_fiyat+this.icecek_fiyat);
        }
    }
}
