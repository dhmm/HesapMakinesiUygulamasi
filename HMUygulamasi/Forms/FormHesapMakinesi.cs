using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HMUygulamasi.Views;
using HMUygulamasi.Presenters;
using HMUygulamasi.Kutuphane.Sabitler;

namespace HMUygulamasi.Forms
{
    public partial class FormHesapMakinesi : Form , IViewHesapMakinesi
    {
        private HesapMakinesiPresenter presenter;
        
                 
        #region IViewHesapMakinesi
        public HesapMakinesiPresenter Presenter
        {
            set { presenter = value; }
        }
        public string SayiTipi
        {
            get
            {
                if (rdoInt.Checked)
                {
                    return SayiTurleri.IntTuru;
                }
                else if (rdoDouble.Checked)
                {
                    return SayiTurleri.DoubleTuru;
                }
                else
                {
                    return SayiTurleri.IntTuru;
                }
            }
        }
        public string SayiKutusu
        {
            set
            {
                this.lblAktifDeger.Text = value;
            }
        }
        public string Sonuc
        {
            set
            {
                lblAktifDeger.Text = value;
            }
        }                
        public void PozitifNegatifYap()
        {
            presenter.PozitifNegatifYap();
        }
        public void SonucHesapla()
        {

            presenter.SonucHesapla();

        }
        public void Temizle()
        {
            presenter.Temizle();
        }
        #endregion

        public FormHesapMakinesi()
        {
            InitializeComponent();
        }

        private void btnKarakterEkle_Click(object sender, EventArgs e)
        {
            presenter.KarakterEkle(((Button)sender).Text.ToString()[0]);
            presenter.AktifDegerGoster();
        }
        private void FormHesapMakinesi_Load(object sender, EventArgs e)
        {
            this.btnVirgul.Text = Karakterler.Virgul.ToString();
        }
        private void rdoSayiTipi_CheckedChanged(object sender, EventArgs e)
        {
            presenter.SayiTipiDegistir();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            presenter.SonucHesapla();
        }
        private void btnPozitifNegatifYap_Click(object sender, EventArgs e)
        {
            presenter.PozitifNegatifYap();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            presenter.Temizle();
        }

        
    }
}
