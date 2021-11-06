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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void Musteriler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERİLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            Txtid.Text = "";
            Txtad.Text = "";
            Txtsoyad.Text = "";
            Txtmail.Text = "";
            Msktel1.Text = "";
            Msktel2.Text = "";
            Msktc.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            textEdit1.Text = "";
            Rchadres.Text = "";
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
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            Musteriler();
            SehirListesii();
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select İLCE From TBL_İLCELER where SEHİR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbil.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        bool durum;
        void tekrarkayitengelleme()
        {
            SqlCommand komut = new SqlCommand("select * from TBL_MUSTERİLER where TC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Msktc.Text);
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
        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            tekrarkayitengelleme();
            if (durum==true)
            {
                DialogResult dialogResult = MessageBox.Show("Müşteri Eklemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("insert into TBL_MUSTERİLER (AD,SOYAD,TELEFON,TELEFON2,TC,MAİL,İL,İLCE,ADRES,VERGİDAİRE)" +
                    "values (@p1,@p2,@p3,@p4,@p5,@p5,@p7,@p8,@p9,@p10)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", Txtad.Text);
                    komut.Parameters.AddWithValue("@p2", Txtsoyad.Text);
                    komut.Parameters.AddWithValue("@p3", Msktel1.Text);
                    komut.Parameters.AddWithValue("@p4", Msktel2.Text);
                    komut.Parameters.AddWithValue("@p5", Msktc.Text);
                    komut.Parameters.AddWithValue("@p6", Txtmail.Text);
                    komut.Parameters.AddWithValue("@p7", Cmbil.Text);
                    komut.Parameters.AddWithValue("@p8", Cmbilce.Text);
                    komut.Parameters.AddWithValue("@p9", Rchadres.Text);
                    komut.Parameters.AddWithValue("@p10", textEdit1.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Müşteri Kayıdı Başarılı Bir Şekilde Gerçekleşmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Musteriler();
                }
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik Numarasına Ait Kayıt Bulunmaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
         
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (data!=null)
            {
                Txtid.Text = data["ID"].ToString();
                Txtad.Text= data["AD"].ToString();
                Txtsoyad.Text= data["SOYAD"].ToString();
                Msktel1.Text= data["TELEFON"].ToString();
                Msktel2.Text= data["TELEFON2"].ToString();
                Msktc.Text= data["TC"].ToString();
                Cmbil.Text= data["İL"].ToString();
                Cmbilce.Text= data["İLCE"].ToString();
                Rchadres.Text= data["ADRES"].ToString();
                textEdit1.Text= data["VERGİDAİRE"].ToString();
                Txtmail.Text= data["MAİL"].ToString();
            }
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Müşteriyi Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_MUSTERİLER where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Müşteri Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Musteriler();

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Müşteri Bilgilerini Güncellemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand guncelle = new SqlCommand("update TBL_MUSTERİLER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC=@p5," +
                "MAİL=@p6,İL=@p7,İLCE=@p8,ADRES=@p9,VERGİDAİRE=@p10 where ID=@p11", bgl.baglanti());
                guncelle.Parameters.AddWithValue("@p1", Txtad.Text);
                guncelle.Parameters.AddWithValue("@p2", Txtsoyad.Text);
                guncelle.Parameters.AddWithValue("@p3", Msktel1.Text);
               guncelle.Parameters.AddWithValue("@p4", Msktel2.Text);
                guncelle.Parameters.AddWithValue("@p5", Msktc.Text);
                guncelle.Parameters.AddWithValue("@p6", Txtmail.Text);
                guncelle.Parameters.AddWithValue("@p7", Cmbil.Text);
                guncelle.Parameters.AddWithValue("@p8", Cmbilce.Text);
                guncelle.Parameters.AddWithValue("@p9", Rchadres.Text);
                guncelle.Parameters.AddWithValue("@p10", textEdit1.Text);
                guncelle.Parameters.AddWithValue("@p11", Txtid.Text);
                guncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri Bilgileri Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Musteriler();
            }
               
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
