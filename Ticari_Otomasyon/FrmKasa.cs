using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.Charts;

namespace Ticari_Otomasyon
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void MusteriHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute MÜSTERİHAREKETLERİ",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        public string ad;
        void FirmaHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute FİRMAHAREKETLER", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            MusteriHareket();
            FirmaHareket();

            //Toplam Tutarı Hesaplama
            SqlCommand komut = new SqlCommand("Select Sum(TUTAR) from TBL_FATURA", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Lblkasatoplam.Text = dr[0].ToString()+ "TL";
            }
            bgl.baglanti().Close();

            //Son Ayın Personel Maaşları
            SqlCommand komut3 = new SqlCommand("Select MAASLAR from TBL_GIDERLER order by ID asc",bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                Lblpersonelmaas.Text = dr3[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Musteri Sayisi
            SqlCommand komut4 = new SqlCommand("Select Count(*) From TBL_MUSTERİLER", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                Lblmüsterisayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();
            //Toplam Firma Sayisi
            SqlCommand komut5 = new SqlCommand("Select Count(Distinct(İL)) From TBL_FİRMALAR", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                Lblfirmasayisi.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();

            //Toplam Personel Sayisi
            SqlCommand komut6 = new SqlCommand("Select Count(*) From TBL_PERSONELLER", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                Lblpersonelsayisi.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut7 = new SqlCommand("Select Sum(ADET) From TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                Lblstoksayisi.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();
            Lblaktifkullanici.Text = ad;

           
        }
        public int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 0 && sayac <= 5)
            {
                label2.Text = "ELEKTİRİK";

                //1. Chart Kontrol
                SqlCommand komut8 = new SqlCommand("Select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr8 = komut8.ExecuteReader();
                while (dr8.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr8[0], dr8[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 5 && sayac <= 10)
            {
                label2.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                //2.Chart son 4 ayın su faturasını listeleme
                SqlCommand komut9 = new SqlCommand("Select top 4 AY,SU from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr9 = komut9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 11 && sayac <= 15)
            {
                label2.Text = "DOĞALGAZ";
                chartControl1.Series["Aylar"].Points.Clear();
                //2.Chart son 4 ayın su faturasını listeleme
                SqlCommand komut10 = new SqlCommand("Select top 4 AY,DOĞALGAZ from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 16 && sayac <= 20)
            {
                label2.Text = "İNTERNET";
                chartControl1.Series["Aylar"].Points.Clear();
                //2.Chart son 4 ayın su faturasını listeleme
                SqlCommand komut10 = new SqlCommand("Select top 4 AY,INTERNET from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac==21)
            {
                sayac = 0;
            }
        }

        int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 > 0 && sayac2 <= 5)
            {
                label2.Text = "ELEKTİRİK";

                //1. Chart Kontrol
                SqlCommand komut8 = new SqlCommand("Select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr8 = komut8.ExecuteReader();
                while (dr8.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr8[0], dr8[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 5 && sayac2 <= 10)
            {
                label2.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                //2.Chart son 4 ayın su faturasını listeleme
                SqlCommand komut9 = new SqlCommand("Select top 4 AY,SU from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr9 = komut9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr9[0], dr9[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 10 && sayac2 <= 15)
            {
                label2.Text = "DOĞALGAZ";
                chartControl1.Series["Aylar"].Points.Clear();
                //2.Chart son 4 ayın su faturasını listeleme
                SqlCommand komut10 = new SqlCommand("Select top 4 AY,DOĞALGAZ from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 15 && sayac2 <= 20)
            {
                label2.Text = "İNTERNET";
                chartControl1.Series["Aylar"].Points.Clear();
                //2.Chart son 4 ayın su faturasını listeleme
                SqlCommand komut10 = new SqlCommand("Select top 4 AY,INTERNET from TBL_GIDERLER order by ID desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2==21)
            {
                sayac2 = 0;
            }
        }
    }
}
