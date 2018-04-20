using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMUygulamasi.Kutuphane.Sabitler;

namespace HMUygulamasi.Kutuphane.SayiTipleri
{
    public static class SayiFactory
    {
        public static dynamic YeniSayiOlustur(string sayiTipi)
        {
            dynamic yeniSayi = null;

            switch (sayiTipi)
            {
                case SayiTurleri.IntTuru:
                    yeniSayi = new SayiInt();
                    break;
                case SayiTurleri.DoubleTuru:
                    yeniSayi = new SayiDouble();
                    break;
                default:
                    yeniSayi = new SayiInt();
                    break;
            }

            return yeniSayi;
        }
    }
}
