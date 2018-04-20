using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMUygulamasi.Presenters;

namespace HMUygulamasi.Views
{
    public interface IViewHesapMakinesi
    {
        HesapMakinesiPresenter Presenter { set; }

        string SayiKutusu { set; }
        string SayiTipi { get; }                        
        void PozitifNegatifYap();
        void SonucHesapla();
        void Temizle();
    }
}
