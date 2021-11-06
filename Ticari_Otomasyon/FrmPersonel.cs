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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void personeller()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PERSONELLER", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
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
        void Temizle()
        {
            Txtid.Text = "";
            Txtad.Text = "";
            Txtsoyad.Text = "";
            Txtmail.Text = "";
            txtgorev.Text = "";
            Msktc.Text = "";
            Msktel1.Text = "";
            Rchadres.Text = "";
            Cmbil.Text= "";
            Cmbilce.Text= "";
        }
        bool durum;
        void tekrarkayitengelleme()
        {
            SqlCommand komut = new SqlCommand("select * from TBL_PERSONELLER where TC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            personeller();
            SehirListesii();
            Temizle();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            tekrarkayitengelleme();
            if (durum==true)
            {
                DialogResult dialogResult = MessageBox.Show("Müşteri Eklemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand kaydet = new SqlCommand("insert into TBL_PERSONELLER (AD,SOYAD,TELEFON,TC,MAİL,İL,İLCE,ADRES,GOREV) values" +
                        "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                    kaydet.Parameters.AddWithValue("@p1", Txtad.Text);
                    kaydet.Parameters.AddWithValue("@p2", Txtsoyad.Text);
                    kaydet.Parameters.AddWithValue("@p3", Msktel1.Text);
                    kaydet.Parameters.AddWithValue("@p4", Msktc.Text);
                    kaydet.Parameters.AddWithValue("@p5", Txtmail.Text);
                    kaydet.Parameters.AddWithValue("@p6", Cmbil.Text);
                    kaydet.Parameters.AddWithValue("@p7", Cmbilce.Text);
                    kaydet.Parameters.AddWithValue("@p8", Rchadres.Text);
                    kaydet.Parameters.AddWithValue("@p9", txtgorev.Text);
                    kaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Personel Başarı İle Eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    personeller();
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik Numarasına Ait Kayıtlı Personel Bulunmaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (data!=null)
            {
                Txtid.Text = data["ID"].ToString();
                Txtad.Text= data["AD"].ToString();
                Txtsoyad.Text= data["SOYAD"].ToString();
                Txtmail.Text= data["MAİL"].ToString();
                txtgorev.Text= data["GOREV"].ToString();
                Msktc.Text= data["TC"].ToString();
                Msktel1.Text= data["TELEFON"].ToString();
                Rchadres.Text= data["ADRES"].ToString();
                Cmbil.Text= data["İL"].ToString();
                Cmbilce.Text = data["İLCE"].ToString();
            }
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seçili Personeli Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("delete from TBL_PERSONELLER where ID=@p1", bgl.baglanti());
                sil.Parameters.AddWithValue("@p1",Txtid.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Seçili Personeli Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                personeller();
            }
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seçili Personelin Bilgilerini Güncellemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand guncelle = new SqlCommand("update TBL_PERSONELLER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAİL=@p5,İL=@p6,İLCE=@p7,ADRES=@p8,GOREV=@p9 where ID=@p10", bgl.baglanti());
                guncelle.Parameters.AddWithValue("@p1", Txtad.Text);
                guncelle.Parameters.AddWithValue("@p2", Txtsoyad.Text);
                guncelle.Parameters.AddWithValue("@p3", Msktel1.Text);
                guncelle.Parameters.AddWithValue("@p4", Msktc.Text);
                guncelle.Parameters.AddWithValue("@p5", Txtmail.Text);
                guncelle.Parameters.AddWithValue("@p6", Cmbil.Text);
                guncelle.Parameters.AddWithValue("@p7", Cmbilce.Text);
                guncelle.Parameters.AddWithValue("@p8", Rchadres.Text);
                guncelle.Parameters.AddWithValue("@p9", txtgorev.Text);
                guncelle.Parameters.AddWithValue("@p10", Txtid.Text);
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                personeller();
            }
        }
    }
}
