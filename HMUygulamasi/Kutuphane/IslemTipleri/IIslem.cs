using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMUygulamasi.Kutuphane.SayiTipleri;

namespace HMUygulamasi.Kutuphane.IslemTipleri
{
    public interface IIslem
    {
        char IslemTipiOku();
        ISayiTipi IslemUygula(ISayiTipi oncekiDeger, ISayiTipi aktifDeger);
    }
}
