using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMUygulamasi.Kutuphane.Sabitler
{
    public class IslemTurleri
    {
        public const char Toplama = '+';
        public const char Cikarma = '-';
        public const char Carpma = '*';
        public const char Bolme = '/';  
        public const char Bilinmeyen = ' ';

        public static char IslemTuruHangisi(char karakter)
        {
            char tur = Bilinmeyen;
            switch(karakter)
            {
                case Toplama:
                    tur=Toplama;
                    break;
                case Cikarma:
                    tur=Cikarma;
                    break;
                case Bolme :
                    tur = Bolme;
                    break;
                case Carpma:
                    tur = Carpma;
                    break;
                default:
                    tur = Bilinmeyen;
                    break;
            }
            return tur;
        }
    }
}
