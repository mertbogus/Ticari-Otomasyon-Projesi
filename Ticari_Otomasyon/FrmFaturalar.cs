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

namespace Ticari_Otomasyon
{
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void FaturaListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURABİLGİ", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            Txtid.Text = "";
            Txtserino.Text= "";
            Txtsirano.Text= "";
            Msktarih.Text= ""; 
            Msksaat.Text= "";
            Txtvergid.Text= "";
            Txtalıcı.Text= "";
            Txtteslimeden.Text= "";
            Txtteslimalan.Text= "";
            TxtUrunıd.Text = "";
            Txturunad.Text = "";
            Txtmiktar.Text = "";
            Txttutar.Text = "";
            Txtfiyat.Text = "";
            Txtfaturaid.Text = "";
        }
        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            FaturaListele();
            Temizle();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            if (Txtfaturaid.Text == "")
            {
                DialogResult dialogResult = MessageBox.Show("Faturayı Kayıt Etmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand kaydet = new SqlCommand("insert into TBL_FATURABİLGİ (SERİ,SIRANO,TARİH,SAAT,VERGİDAİRE,ALICI,TESLİMEDEN,TESLİMALAN)" +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                    kaydet.Parameters.AddWithValue("@p1", Txtserino.Text);
                    kaydet.Parameters.AddWithValue("@p2", Txtsirano.Text);
                    kaydet.Parameters.AddWithValue("@p3", Msktarih.Text);
                    kaydet.Parameters.AddWithValue("@p4", Msksaat.Text);
                    kaydet.Parameters.AddWithValue("@p5", Txtvergid.Text);
                    kaydet.Parameters.AddWithValue("@p6", Txtalıcı.Text);
                    kaydet.Parameters.AddWithValue("@p7", Txtteslimeden.Text);
                    kaydet.Parameters.AddWithValue("@p8", Txtteslimalan.Text);
                    kaydet.ExecuteNonQuery();
                    MessageBox.Show("Fatura Kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FaturaListele();
                    Temizle();
                }
            }
            if (Txtfaturaid.Text != "")
            {
                int tutar;
                int miktar = Convert.ToInt32(Txtmiktar.Text);
                int fiyat = Convert.ToInt32(Txtfiyat.Text);
                tutar = fiyat * miktar;
                Txttutar.Text = tutar.ToString(); 
                DialogResult dialogResult2 = MessageBox.Show("Faturaya Ürün Kayıt Etmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult2 == DialogResult.Yes)
                {
                    SqlCommand kaydet2 = new SqlCommand("insert into TBL_FATURA (URUNAD,MİKTAR,FİYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                    kaydet2.Parameters.AddWithValue("@p1", Txturunad.Text);
                    kaydet2.Parameters.AddWithValue("@p2", Txtmiktar.Text);
                    kaydet2.Parameters.AddWithValue("@p3", Txtfiyat.Text);
                    kaydet2.Parameters.AddWithValue("@p4", Txttutar.Text);
                    kaydet2.Parameters.AddWithValue("@p5", Txtfaturaid.Text);
                    kaydet2.ExecuteNonQuery();
                    MessageBox.Show("Faturaya Ait Ürün Kayıt Edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (data != null)
            {
                Txtid.Text = data["FATURABILGIID"].ToString();
                Txtserino.Text= data["SERİ"].ToString();
                Txtsirano.Text= data["SIRANO"].ToString();
                Msktarih.Text= data["TARİH"].ToString();
                Msksaat.Text= data["SAAT"].ToString();
                Txtvergid.Text= data["VERGİDAİRE"].ToString();
                Txtalıcı.Text= data["ALICI"].ToString();
                Txtteslimeden.Text= data["TESLİMEDEN"].ToString();
                Txtteslimalan.Text= data["TESLİMALAN"].ToString();
            }
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult2 = MessageBox.Show("Faturayı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult2 == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("delete from TBL_FATURABİLGİ where FATURABILGIID=@p1",bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", Txtid.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Fatura Kaydı Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FaturaListele();
                Temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult2 = MessageBox.Show("Fatura Bilgilerini Güncellemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult2 == DialogResult.Yes)
            {
                SqlCommand guncelle = new SqlCommand("update TBL_FATURABİLGİ set SERİ=@p1,SIRANO=@p2,TARİH=@p3,SAAT=@p4,VERGİDAİRE=@p5,ALICI=@p6,TESLİMEDEN=@p7,TESLİMALAN=@p8 where FATURABILGIID=@p9",bgl.baglanti());
                guncelle.Parameters.AddWithValue("@p1", Txtserino.Text);
                guncelle.Parameters.AddWithValue("@p2", Txtsirano.Text);
                guncelle.Parameters.AddWithValue("@p3", Msktarih.Text);
                guncelle.Parameters.AddWithValue("@p4", Msksaat.Text);
                guncelle.Parameters.AddWithValue("@p5", Txtvergid.Text);
                guncelle.Parameters.AddWithValue("@p6", Txtalıcı.Text);
                guncelle.Parameters.AddWithValue("@p7", Txtteslimeden.Text);
                guncelle.Parameters.AddWithValue("@p8", Txtteslimalan.Text);
                guncelle.Parameters.AddWithValue("@p9", Txtid.Text);
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Fatura Bilgileri Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FaturaListele();
                Temizle();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay urundetay = new FrmFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                urundetay.ID = dr["FATURABILGIID"].ToString();
                urundetay.Show();
            }
        }
    }
}
