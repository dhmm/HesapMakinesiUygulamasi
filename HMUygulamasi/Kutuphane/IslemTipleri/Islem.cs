using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMUygulamasi.Kutuphane.IslemTipleri
{
    public class Islem
    {
        protected char IslemTipi { set; get; }
        protected Islem()
        {
        }
        public char IslemTipiOku()
        {
            return this.IslemTipi;
        }
    }
}
