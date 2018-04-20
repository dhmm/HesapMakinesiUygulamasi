using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using HMUygulamasi.Kutuphane;
using HMUygulamasi.Forms;
using HMUygulamasi.Presenters;

namespace HMUygulamasi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            IHesapMakinesi hesapMakinesi = new HesapMakinesi();
            FormHesapMakinesi anaForm = new FormHesapMakinesi();
            HesapMakinesiPresenter presenter = new HesapMakinesiPresenter(hesapMakinesi, anaForm);
            Application.Run(anaForm);            

            #region Testing



            /*SayiInt sayi = new SayiInt();

            sayi.KarakterEkle('1');
            sayi.KarakterEkle('1');
            sayi.KarakterEkle('0');
            sayi.KarakterEkle('3');
            sayi.KarakterEkle('4');
            sayi.KarakterEkle(',');
            sayi.KarakterEkle('5');
            sayi.KarakterEkle('5');*/

            /*TESTING
            HesapMakinesi hesapMakinesi = new HesapMakinesi("Double");            
            hesapMakinesi.KarakterEkle('5');
            hesapMakinesi.KarakterEkle(',');
            hesapMakinesi.KarakterEkle('5');
            hesapMakinesi.KarakterEkle('+');
            hesapMakinesi.KarakterEkle('2');           
            hesapMakinesi.KarakterEkle(',');
            hesapMakinesi.KarakterEkle('5');    
            //5,5 + 2,5 = 8
            Debug.WriteLine(hesapMakinesi.SonucHesapla());
            
            hesapMakinesi.KarakterEkle('+');
            hesapMakinesi.KarakterEkle('2');
            hesapMakinesi.KarakterEkle(',');
            hesapMakinesi.KarakterEkle('5');
            //8 + 2,5 = 10,5
            Debug.WriteLine(hesapMakinesi.SonucHesapla());

            hesapMakinesi.KarakterEkle('2');
            hesapMakinesi.KarakterEkle(',');
            hesapMakinesi.KarakterEkle('5');
            hesapMakinesi.KarakterEkle('+');
            hesapMakinesi.KarakterEkle('2');
            hesapMakinesi.KarakterEkle(',');
            hesapMakinesi.KarakterEkle('5');
            //2,5+2,5 = 5
            Debug.WriteLine(hesapMakinesi.SonucHesapla());

            hesapMakinesi.KarakterEkle('2');
            hesapMakinesi.PozitifNegatifYap();
            hesapMakinesi.KarakterEkle('-');
            hesapMakinesi.KarakterEkle('4');
            hesapMakinesi.PozitifNegatifYap();
            hesapMakinesi.PozitifNegatifYap();
            Debug.WriteLine(hesapMakinesi.SonucHesapla());
             * */

            #endregion
        }
    }
}
