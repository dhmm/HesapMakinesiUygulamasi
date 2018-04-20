using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMUygulamasi.Kutuphane.SayiTipleri
{
    public interface ISayiTipi
    {
        bool TasmaVarMi();
        void TasmaVar();
        void KarakterEkle(char karakter);
        string DegerOku();
        void DegerAta(string deger);
        string SayiTipiOku();
        dynamic SayiDegeriOku();
        void PozitifNegatifYap();
    }
}
