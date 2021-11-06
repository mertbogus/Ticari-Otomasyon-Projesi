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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void FirmaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FİRMALAR",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
            Temizle();
            SehirListesii();
            CarikodAcıklamalar();
        }
        void SehirListesii()
        {
            SqlCommand komut = new SqlCommand("Select Sehir From TBL_İLLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void CarikodAcıklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 From TBL_KODLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Rchkod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        void Temizle()
        {
            Txtid.Text = "";
            Txtad.Text = "";
            Txtmail.Text = "";
            Txtozel1.Text = "";
            Txtozel2.Text = "";
            Txtozel3.Text = "";
            Txtsektor.Text = "";
            Txtstatü.Text = "";
            Txtvergidaire.Text = "";
            Txtyetkili.Text = "";
            Mskfaks.Text = "";
            Msktc.Text = "";
            Txtozel1.Text = "";
            Txtozel2.Text = "";
            Txtozel3.Text = "";
            Rchadres.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            Txtad.Focus();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow da = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (da!=null)
            {
                Txtid.Text = da["ID"].ToString();
                Txtad.Text= da["AD"].ToString();
                Txtsektor.Text= da["SEKTOR"].ToString();
                Txtyetkili.Text= da["YETKİLİADSOYAD"].ToString();
                Txtstatü.Text= da["YETKİLİ"].ToString();
                Msktc.Text= da["YETKILITC"].ToString();
                Msktel1.Text= da["TELEFON1"].ToString();
                Msktel2.Text= da["TELEFON2"].ToString();
                Msktel3.Text= da["TELEFON3"].ToString();
                Mskfaks.Text= da["FAKS"].ToString();
                Cmbil.Text= da["İL"].ToString();
                Cmbilce.Text= da["İLCE"].ToString();
                Txtvergidaire.Text= da["VERGİDAİRE"].ToString();
                Rchadres.Text= da["ADRES"].ToString();
                Txtozel1.Text= da["OZELKOD1"].ToString();
                Txtozel2.Text = da["OZELKOD2"].ToString();
                Txtozel3.Text = da["OZELKOD3"].ToString();
            }
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Firma Eklemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand kaydet = new SqlCommand("insert into TBL_FİRMALAR (AD,YETKİLİ,YETKİLİADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAİL,FAKS,İL,İLCE,VERGİDAİRE,ADRES,YETKILITC,OZELKOD1,OZELKOD2,OZELKOD3,SEKTOR)" +
                "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
                kaydet.Parameters.AddWithValue("@p1", Txtad.Text);
                kaydet.Parameters.AddWithValue("@p2", Txtstatü.Text);
                kaydet.Parameters.AddWithValue("@p3", Txtyetkili.Text);
                kaydet.Parameters.AddWithValue("@p4", Msktel1.Text);
                kaydet.Parameters.AddWithValue("@p5", Msktel2.Text);
                kaydet.Parameters.AddWithValue("@p6", Msktel3.Text);
                kaydet.Parameters.AddWithValue("@p7", Txtmail.Text);
                kaydet.Parameters.AddWithValue("@p8", Mskfaks.Text);
                kaydet.Parameters.AddWithValue("@p9", Cmbil.Text);
                kaydet.Parameters.AddWithValue("@p10", Cmbilce.Text);
                kaydet.Parameters.AddWithValue("@p11", Txtvergidaire.Text);
                kaydet.Parameters.AddWithValue("@p12", Rchadres.Text);
                kaydet.Parameters.AddWithValue("@p13", Msktc.Text);
                kaydet.Parameters.AddWithValue("@p14", Txtozel1.Text);
                kaydet.Parameters.AddWithValue("@p15", Txtozel2.Text);
                kaydet.Parameters.AddWithValue("@p16", Txtozel3.Text);
                kaydet.Parameters.AddWithValue("@p17", Txtsektor.Text);
                kaydet.ExecuteNonQuery();
                MessageBox.Show("Firma Kaydı Başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FirmaListesi();
                
            }
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select İLCE From TBL_İLCELER where SEHİR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seçili Firmayı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from  TBL_FİRMALAR where ID=@p1 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                FirmaListesi();
                MessageBox.Show("Firma Kaydı Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seçili Firmayı Güncellemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("update TBL_FİRMALAR set AD=@p1,YETKILI=@p2,YETKILIADSOYAD=@p3,TELEFON1=@p4,TELEFON2=@p5,TELEFON3=@p6,MAİL=@p7,FAKS=@p8,İL=@p9,İLCE=@p10,VERGİDAİRE=@p11,ADRES=@p12,YETKILITC=@p13,OZELKOD1=@p14,OZELKOD2=@p15,OZELKOD3=@p16,SEKTOR=@p17 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtad.Text);
                komut.Parameters.AddWithValue("@p2", Txtstatü.Text);
                komut.Parameters.AddWithValue("@p3", Txtyetkili.Text);
                komut.Parameters.AddWithValue("@p4", Msktel1.Text);
                komut.Parameters.AddWithValue("@p5", Msktel2.Text);
                komut.Parameters.AddWithValue("@p6", Msktel3.Text);
                komut.Parameters.AddWithValue("@p7", Txtmail.Text);
                komut.Parameters.AddWithValue("@p8", Mskfaks.Text);
                komut.Parameters.AddWithValue("@p9", Cmbil.Text);
                komut.Parameters.AddWithValue("@p10", Cmbilce.Text);
                komut.Parameters.AddWithValue("@p11", Txtvergidaire.Text);
                komut.Parameters.AddWithValue("@p12", Rchadres.Text);
                komut.Parameters.AddWithValue("@p13", Msktc.Text);
                komut.Parameters.AddWithValue("@p14", Txtozel1.Text);
                komut.Parameters.AddWithValue("@p15", Txtozel2.Text);
                komut.Parameters.AddWithValue("@p16", Txtozel3.Text);
                komut.Parameters.AddWithValue("@p17", Txtsektor.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Firma Kaydı Başarılı Bir Şekilde Güncellenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FirmaListesi();
            }
        }
    }
}
