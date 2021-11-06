using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }
        Frmurunler urunler;
        private void Btnurunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urunler==null && urunler.IsDisposed)
            {
                urunler = new Frmurunler();
                urunler.MdiParent = this;
                urunler.Show();
            }
 

        }
        FrmMusteriler musteri;
        private void Btnmusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteri == null && musteri.IsDisposed)
            {
                musteri = new FrmMusteriler();
                musteri.MdiParent = this;
                musteri.Show();
            }
        }
        FrmFirmalar firmalar;
        private void Btnfirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (firmalar==null && firmalar.IsDisposed)
            {
                firmalar = new FrmFirmalar();
                firmalar.MdiParent = this;
                firmalar.Show();
            }
        }
        public string kullanici;
        private void FrmAnaModul_Load(object sender, EventArgs e)
        {
            if (anasayfa == null && anasayfa.IsDisposed)
            {
                anasayfa = new FrmAnaSayfa();
                anasayfa.MdiParent = this;
                anasayfa.Show();
            }
        }
        FrmPersonel personel;
        private void Btnpersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personel==null && personel.IsDisposed)
            {
                personel = new FrmPersonel();
                personel.MdiParent = this;
                personel.Show();
            }
            
        }
        FrmRehber rehber;
        private void Btnrehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rehber==null && rehber.IsDisposed)
            {
                rehber = new FrmRehber();
                rehber.MdiParent = this;
                rehber.Show();
            }
        }
        FrmGiderler giderler;
        private void Btngiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (giderler==null && giderler.IsDisposed)
            {
                giderler = new FrmGiderler();
                giderler.MdiParent = this;
                giderler.Show();
            }
        }
        FrmBankalar bankalar;
        private void Btnbankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bankalar==null && bankalar.IsDisposed)
            {
                bankalar = new FrmBankalar();
                bankalar.MdiParent = this;
                bankalar.Show();
            }
        }
        FrmFaturalar faturalar;
        private void Btnfaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (faturalar==null && faturalar.IsDisposed)
            {
                faturalar = new FrmFaturalar();
                faturalar.MdiParent = this;
                faturalar.Show();
            }
        }
        FrmNotlar notlar;
        private void Btnnotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (notlar==null && notlar.IsDisposed)
            {
                notlar = new FrmNotlar();
                notlar.MdiParent = this;
                notlar.Show();
            }
        }

        FrmHareketler hareketler;
        private void Btnhareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hareketler==null && hareketler.IsDisposed)
            {
                hareketler = new FrmHareketler();
                hareketler.MdiParent = this;
                hareketler.Show();
            }
        }
        FrmRaporlar rapor;
        private void BtnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rapor==null && rapor.IsDisposed)
            {
                rapor = new FrmRaporlar();
                rapor.MdiParent = this;
                rapor.Show();
            }
        }
        FrmStok stok;
        private void Btnstoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stok==null && stok.IsDisposed)
            {
                stok = new FrmStok();
                stok.MdiParent = this;
                stok.Show();
            }
        }
        FrmAyarlar ayarlar;
        private void Btnayarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ayarlar == null && ayarlar.IsDisposed)
            {
                ayarlar = new FrmAyarlar();
                ayarlar.Show();
            }
        }
        FrmKasa kasa;
        private void Btnkasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kasa == null && kasa.IsDisposed)
            {
                kasa = new FrmKasa();
                kasa.MdiParent = this;
                kasa.ad = kullanici;
                kasa.Show();
            }
        }
        FrmAnaSayfa anasayfa;
        private void Btnanasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anasayfa==null)
            {
               anasayfa = new FrmAnaSayfa();
                anasayfa.MdiParent = this;
                anasayfa.Show();
            }
        }
    }
}
