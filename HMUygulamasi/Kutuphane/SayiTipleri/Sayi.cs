using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMUygulamasi.Kutuphane.Sabitler;


namespace HMUygulamasi.Kutuphane.SayiTipleri
{
    public class Sayi
    {        
        protected string Deger { set; get; }        
        protected bool VirgulIcerirMi { set; get; }
        protected bool TasmaVarmi { set; get; }

        protected Sayi()
        {
            this.Deger = "0";
            this.TasmaVarmi = false;
        }

        internal void VirgulEkle()
        {
            if (VirgulIcerirMi)
            {
                if (!VirgulVarMi())
                {
                    this.Deger += Karakterler.Virgul;
                }
            }
        }
        internal bool VirgulVarMi()
        {
            return this.Deger.Contains(Karakterler.Virgul);
        }

        
    }
}
