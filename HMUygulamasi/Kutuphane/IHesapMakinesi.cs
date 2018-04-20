using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMUygulamasi.Kutuphane
{
    public interface IHesapMakinesi
    {
        void SayiTipiDegistir(string sayiTuru);
        void KarakterEkle(char karakter);
        string SonucHesapla();
        void PozitifNegatifYap();
        string AktifDegeriOku();
        char SistemSayiVirgulunuOku();

        void Temizle();
    }
}
