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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void BankaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute BANKABİLGİLERİ", bgl.baglanti());
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
            Txtiban.Text= "";
            Txtsube.Text= "";
            Txtadres.Text= "";
            Txtyetkili.Text= "";
            Txthesapno.Text= "";
            txthesaptur.Text= "";
            Msktarih.Text= "";
            Msktel.Text= "";
            Luefirma.Text= "";
        }
        void FirmaListesi()
        {
            DataTable dt = new DataTable("");
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD From TBL_FİRMALAR",bgl.baglanti());
            da.Fill(dt);
            Luefirma.Properties.NullText = "Lütfen Bir Firma Seçiniz.";
            Luefirma.Properties.ValueMember = "ID";
            Luefirma.Properties.DisplayMember = "AD";
            Luefirma.Properties.DataSource = dt;
        }
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            BankaListesi();
            SehirListesii();
            FirmaListesi();
            Temizle();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bankayı Eklemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand kaydet = new SqlCommand("insert into (BANKAD,SUBE,IBAN,HESAPNO,YETKILI,TARIH,HESAPTURU,FIRMAID,İL,İLCE,TELEFON)"+
                   "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",bgl.baglanti());
                kaydet.Parameters.AddWithValue("@p1",Txtad.Text);
                kaydet.Parameters.AddWithValue("@p2",Txtsube.Text);
                kaydet.Parameters.AddWithValue("@p3",Txtiban.Text);
                kaydet.Parameters.AddWithValue("@p4",Txthesapno.Text);
                kaydet.Parameters.AddWithValue("@p5",Txtyetkili.Text);
                kaydet.Parameters.AddWithValue("@p6",Msktarih.Text);
                kaydet.Parameters.AddWithValue("@p7",txthesaptur.Text);
                kaydet.Parameters.AddWithValue("@p8",Luefirma.EditValue);
                kaydet.Parameters.AddWithValue("@p9",Cmbil.Text);
                kaydet.Parameters.AddWithValue("@p10",Cmbilce.Text);
                kaydet.Parameters.AddWithValue("@p11", Msktel.Text);
                kaydet.ExecuteNonQuery();
                MessageBox.Show("Bankayı Eklendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BankaListesi();
                Temizle();
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
            if (data != null)
            {
                Txtid.Text = data["ID"].ToString();
                Txtad.Text= data["BANKAD"].ToString();
                Txtsube.Text= data["SUBE"].ToString();
                Txtiban.Text= data["IBAN"].ToString();
                Txthesapno.Text= data["HESAPNO"].ToString();
                Txtyetkili.Text= data["YETKILI"].ToString();
                Msktarih.Text= data["TARIH"].ToString();
                txthesaptur.Text= data["HESAPTURU"].ToString();
                //Luefirma.EditValue= data["FIRMAID"].ToString();
                Cmbil.Text= data["İL"].ToString();
                Cmbilce.Text= data["İLCE"].ToString();
                Msktel.Text= data["TELEFON"].ToString();
            }
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bankayı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("delete from TBL_BANKALAR where ID=@p1",bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", Txtid.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Banka Silme İşlemi Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BankaListesi();
                Temizle();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Banka Bilgilerini Güncellemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand guncelle = new SqlCommand("update TBL_BANKALAR set BANKAD=@p1,SUBE=@p2,IBAN=@p3,HESAPNO=@p4,YETKILI=@p5,TARIH=@p6,HESAPTURU=@p7,FIRMAID=@p8,İL=@p9,İLCE=@p10,TELEFON=@p11 where ID=@p12",bgl.baglanti());
                guncelle.Parameters.AddWithValue("@p1",Txtad.Text);
                guncelle.Parameters.AddWithValue("@p2",Txtsube.Text);
                guncelle.Parameters.AddWithValue("@p3",Txtiban.Text);
                guncelle.Parameters.AddWithValue("@p4",Txthesapno.Text);
                guncelle.Parameters.AddWithValue("@p5",Txtyetkili.Text);
                guncelle.Parameters.AddWithValue("@p6",Msktarih.Text);
                guncelle.Parameters.AddWithValue("@p7",txthesaptur.Text);
                guncelle.Parameters.AddWithValue("@p8",Luefirma.EditValue);
                guncelle.Parameters.AddWithValue("@p9",Cmbil.Text);
                guncelle.Parameters.AddWithValue("@p10",Cmbilce.Text);
                guncelle.Parameters.AddWithValue("@p11",Msktel.Text);
                guncelle.Parameters.AddWithValue("@p12", Txtid.Text);
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Banka Bilgileri Güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
