using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMUygulamasi.Kutuphane.Sabitler;
using HMUygulamasi.Kutuphane.SayiTipleri;

namespace HMUygulamasi.Kutuphane.IslemTipleri
{
    public class IslemToplama : Islem, IIslem
    {

        public IslemToplama()
        {
            this.IslemTipi = IslemTurleri.Toplama;
        }
        public ISayiTipi IslemUygula(ISayiTipi oncekiDeger, ISayiTipi aktifDeger)
        {
            ISayiTipi sonuc = SayiFactory.YeniSayiOlustur(aktifDeger.SayiTipiOku());
            if (oncekiDeger.TasmaVarMi() || aktifDeger.TasmaVarMi())
            {
                sonuc.TasmaVar();
            }
            else
            {                
                try
                {
                    sonuc.DegerAta(checked(oncekiDeger.SayiDegeriOku() + aktifDeger.SayiDegeriOku()).ToString());
                }
                catch (OverflowException)
                {
                    oncekiDeger.TasmaVar();
                    aktifDeger.TasmaVar();
                    sonuc.TasmaVar();
                }
                
            }
            return sonuc;
        }

    }
}
