using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMUygulamasi.Kutuphane.Sabitler;

namespace HMUygulamasi.Kutuphane.IslemTipleri
{
    public static class IslemFactory
    {
        public static dynamic IslemOlustur(char islemKarakteri)
        {
            dynamic islemTipi = null;
            
            switch(IslemTurleri.IslemTuruHangisi(islemKarakteri))
            {
                case IslemTurleri.Toplama:
                    islemTipi = new IslemToplama();
                    break;
                case IslemTurleri.Cikarma:
                    islemTipi = new IslemCikarma();
                    break;
                case IslemTurleri.Carpma:
                    islemTipi = new IslemCarpma();
                    break;
                case IslemTurleri.Bolme:
                    islemTipi = new IslemBolme();
                    break;
            }

            return islemTipi;
        }
    }
}
