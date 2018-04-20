using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMUygulamasi.Kutuphane;
using HMUygulamasi.Views;
using HMUygulamasi.Kutuphane.Sabitler;

namespace HMUygulamasi.Presenters
{
    public class HesapMakinesiPresenter
    {
        private readonly IHesapMakinesi HesapMakinesi;
        private readonly IViewHesapMakinesi View;

        public HesapMakinesiPresenter(IHesapMakinesi hesapMakinesi, IViewHesapMakinesi view)
        {
            view.Presenter = this;
            this.HesapMakinesi = hesapMakinesi;
            this.View = view;
        }

        public void KarakterEkle(char karakter)
        {
            HesapMakinesi.KarakterEkle(karakter);
        }
        public void SayiTipiDegistir()
        {
            HesapMakinesi.Temizle();
            HesapMakinesi.SayiTipiDegistir(View.SayiTipi);
            View.SayiKutusu = HesapMakinesi.AktifDegeriOku();
        }

        public void PozitifNegatifYap()
        {
            HesapMakinesi.PozitifNegatifYap();
            View.SayiKutusu = HesapMakinesi.AktifDegeriOku();
        }
        public void SonucHesapla()
        {
            try
            {
                View.SayiKutusu = HesapMakinesi.SonucHesapla();
            }
            catch (Exception ex)
            {
                View.SayiKutusu = "Sifira Bolme :(";
            }

            
        }
        public void AktifDegerGoster()
        {
            View.SayiKutusu = HesapMakinesi.AktifDegeriOku();
        }        
        public void Temizle()
        {
            HesapMakinesi.Temizle();
            View.SayiKutusu = HesapMakinesi.AktifDegeriOku();
        }
        
    }
}
