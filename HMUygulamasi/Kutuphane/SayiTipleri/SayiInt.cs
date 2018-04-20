using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMUygulamasi.Kutuphane.Sabitler;
using HMUygulamasi.Kutuphane.Yardimcilar;

namespace HMUygulamasi.Kutuphane.SayiTipleri
{
    public class SayiInt : Sayi,  ISayiTipi
    {
        public string SayiTuru = SayiTurleri.IntTuru;        
                
        public SayiInt()
            :base()
        {            
            this.VirgulIcerirMi = false;            
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
            if(KarakterFiltresi.RakamMi(karakter))
            {
                this.RakamEkle(karakter);
            }
            else if(KarakterFiltresi.VirgulMu(karakter))
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
                return int.Parse(this.Deger);
            }
            return 0;
        }
        public string SayiTipiOku()
        {
            return this.SayiTuru;
        }
        public void PozitifNegatifYap()
        {
            int i = this.SayiDegeriOku();
            i *= -1;
            this.DegerAta(i.ToString());
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
                int sayi = int.Parse(yeniDeger);
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
