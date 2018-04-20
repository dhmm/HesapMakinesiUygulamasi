using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMUygulamasi.Kutuphane.Sabitler;

namespace HMUygulamasi.Kutuphane.Yardimcilar
{
    public static class KarakterFiltresi
    {
        public static bool RakamMi(char karakter)
        {
            return char.IsDigit(karakter);
        }
        public static bool VirgulMu(char karakter)
        {
            return karakter == Karakterler.Virgul;
        }
        
    }
}
