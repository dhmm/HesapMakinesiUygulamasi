using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMUygulamasi.Kutuphane.Yardimcilar;
using HMUygulamasi.Kutuphane.Sabitler;

namespace HMUygulamasi.Kutuphane.SayiTipleri
{
    public class SayiDouble : Sayi , ISayiTipi
    {
        public string SayiTuru = SayiTurleri.DoubleTuru;        

        public SayiDouble()
            : base()
        {
            this.VirgulIcerirMi = true;            
        }

        #region ISayiTipi
        public bool TasmaVarMi()
        {
            return this.TasmaVarmi;
        }
        public void TasmaVar()
        {
            this.TasmaVarmi = true;
            this.Deger = Degerler.TasmaDegeri;
        }
        public void KarakterEkle(char karakter)
        {
            if (KarakterFiltresi.RakamMi(karakter))
            {
                this.RakamEkle(karakter);
            }
            else if (KarakterFiltresi.VirgulMu(karakter))
            {
                this.VirgulEkle();
            }
        }
        public string DegerOku()
        {
            return this.Deger;
        }
        public void DegerAta(string deger)
        {
            if (this.SayiDogruMu(deger))
            {
                this.Deger = deger;
            }
        }
        public dynamic SayiDegeriOku()
        {
            if (this.Deger != Degerler.TasmaDegeri)
            {
                return double.Parse(this.Deger);
            }
            return 0;
        }
        public string SayiTipiOku()
        {
            return this.SayiTuru;
        }
        public void PozitifNegatifYap()
        {
            double d = this.SayiDegeriOku();
            d *= -1;
            this.DegerAta(d.ToString());
        }
        #endregion

        private void RakamEkle(char karakter)
        {
            string tempDeger = this.Deger + karakter;
            if (SayiDogruMu(tempDeger))
            {
                if (this.Deger.Equals("0"))
                {
                    this.Deger = karakter.ToString();
                }
                else
                {
                    this.Deger += karakter;
                }
            }           
        }
        private bool SayiDogruMu(string yeniDeger)
        {
            try
            {
                double sayi = double.Parse(yeniDeger);
                return true;
            }
            catch (OverflowException)
            {
                TasmaVarmi = true;
                this.Deger = Degerler.TasmaDegeri;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }        
    }
}
