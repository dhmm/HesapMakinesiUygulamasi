using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMUygulamasi.Kutuphane.SayiTipleri;
using HMUygulamasi.Kutuphane.Sabitler;
using HMUygulamasi.Kutuphane.IslemTipleri;

namespace HMUygulamasi.Kutuphane
{
    public class HesapMakinesi : IHesapMakinesi
    {
        private const int MaksKarakterSayisi = 13;

        string GecerliSayiTipi;
        ISayiTipi OncekiDeger { set; get; }
        ISayiTipi AktifDeger { set; get; }
        ISayiTipi Sonuc { set; get; }
        IIslem Islem { set; get; }
        private bool SonIslemdeSonucAlindi { set; get; }

        public HesapMakinesi(string sayiTuru = SayiTurleri.IntTuru)
        {
            SayiTipiDegistir(sayiTuru);
            Sifirla();
            IslemSifirla();            
        }

        #region IHesapMakinesi
        public void SayiTipiDegistir(string sayiTuru)
        {
            this.GecerliSayiTipi = sayiTuru;
            this.Temizle();                      
        }
        public void KarakterEkle(char karakter)
        {
            if (TasmaVarMi() == false)
            {
                if (IslemKarakteriMi(karakter))
                {
                    IslemKarakteriEkle(karakter);
                }
                else
                {
                    RakamEkle(karakter);
                }
            }
        }
        public string SonucHesapla()
        {
            if (Islem == null)
            {
                return AktifDeger.DegerOku();
            }
            else
            {
                this.Sonuc =  Islem.IslemUygula(OncekiDeger, AktifDeger);
                SonIslemdeSonucAlindi = true;
                return Sonuc.DegerOku();
            }            
        }
        public void PozitifNegatifYap()
        {
            this.AktifDeger.PozitifNegatifYap();
        }
        public string AktifDegeriOku()
        {
            return this.AktifDeger.DegerOku();
        }
        public char SistemSayiVirgulunuOku()
        {
            return Karakterler.Virgul;
        }
        public void Temizle()
        {
            this.OncekiDeger = SayiFactory.YeniSayiOlustur(this.GecerliSayiTipi);
            this.AktifDeger = SayiFactory.YeniSayiOlustur(this.GecerliSayiTipi);
            this.Sonuc = SayiFactory.YeniSayiOlustur(this.GecerliSayiTipi);
            this.SonIslemdeSonucAlindi = false;
            this.Islem = null;
        }
        #endregion

        private void Sifirla()
        {
            this.OncekiDeger.DegerAta("0");
            this.AktifDeger.DegerAta("0");
            this.Sonuc.DegerAta("0");
            SonIslemdeSonucAlindi = false;
        }
        private void IslemSifirla()
        {
            this.Islem = null;
        }
        private bool IslemKarakteriMi(char karakter)
        {
            return char.Equals(karakter,IslemTurleri.Toplama) ||
                   char.Equals(karakter,IslemTurleri.Cikarma) ||
                   char.Equals(karakter,IslemTurleri.Bolme) ||
                   char.Equals(karakter,IslemTurleri.Carpma) ;
        }
        private void IslemKarakteriEkle(char islemKarakteri)
        {
            Islem = IslemFactory.IslemOlustur(islemKarakteri);
            if (SonIslemdeSonucAlindi)
            {
                OncekiDeger.DegerAta(Sonuc.DegerOku());
                Sonuc.DegerAta("0");
            }
            else
            {
                OncekiDeger.DegerAta(AktifDeger.DegerOku());
            }
            AktifDeger.DegerAta("0");
            SonIslemdeSonucAlindi = false;
        }
        private void RakamEkle(char karakter)
        {
            if (SonIslemdeSonucAlindi)
            {
                this.Islem = null;
                this.OncekiDeger.DegerAta("0");
                this.AktifDeger.DegerAta("0");
            }
            if (this.AktifDeger.DegerOku().Length < MaksKarakterSayisi )
            {
                this.AktifDeger.KarakterEkle(karakter);
                SonIslemdeSonucAlindi = false;
            }
        }
        private bool TasmaVarMi()
        {
            return OncekiDeger.TasmaVarMi() || AktifDeger.TasmaVarMi() || Sonuc.TasmaVarMi();
        }
    }
}
