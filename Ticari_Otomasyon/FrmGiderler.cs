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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void Temizle()
        {
            Txtid.Text = "";
            Cmbyil.Text = ""; 
            Cmbay.Text = "";
            Txtelektrik.Text = "";
            Txtdogalgaz.Text = "";
            Txtinternet.Text = "";
            Txtsu.Text = "";
            Txtmaas.Text = "";
            Txtekstra.Text = "";
            Rchadres.Text = "";
        }
        void GiderlerListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            GiderlerListesi();
            Temizle();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Gideri Kaydetmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand kaydet = new SqlCommand("insert into TBL_GIDERLER (AY,YIL,ELEKTRIK,SU,DOĞALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR)" +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
                kaydet.Parameters.AddWithValue("@p1",Cmbay.Text);
                kaydet.Parameters.AddWithValue("@p2",Cmbyil.Text);
                kaydet.Parameters.AddWithValue("@p3",Txtelektrik.Text);
                kaydet.Parameters.AddWithValue("@p4",Txtsu.Text);
                kaydet.Parameters.AddWithValue("@p5",Txtdogalgaz.Text);
                kaydet.Parameters.AddWithValue("@p6",Txtinternet.Text);
                kaydet.Parameters.AddWithValue("@p7",Txtmaas.Text);
                kaydet.Parameters.AddWithValue("@p8",Txtekstra.Text);
                kaydet.Parameters.AddWithValue("@p9",Rchadres.Text);
                kaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Gider Eklenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GiderlerListesi();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (data != null)
            {
                Txtid.Text= data["ID"].ToString();
                Cmbyil.Text = data["YIL"].ToString();
                Cmbay.Text= data["AY"].ToString();
                Txtelektrik.Text= data["ELEKTRIK"].ToString();
                Txtsu.Text= data["SU"].ToString();
                Txtdogalgaz.Text= data["DOĞALGAZ"].ToString();
                Txtinternet.Text= data["INTERNET"].ToString();
                Txtmaas.Text= data["MAASLAR"].ToString();
                Txtekstra.Text= data["EKSTRA"].ToString();
                Rchadres.Text= data["NOTLAR"].ToString();
            }
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silme İşlemine Devam Etmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult==DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("delete from TBL_GIDERLER where ID=@p1", bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", Txtid.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GiderlerListesi();
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Güncelleme İşlemine Devam Etmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("update TBL_GIDERLER set YIL=@p1,AY=@p2,ELEKTRIK=@p3,SU=@p4,DOĞALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 where ID=@p10", bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", Cmbyil.Text);
                sil.Parameters.AddWithValue("@p2", Cmbay.Text);
                sil.Parameters.AddWithValue("@p3", decimal.Parse(Txtelektrik.Text));
                sil.Parameters.AddWithValue("@p4", decimal.Parse(Txtsu.Text));
                sil.Parameters.AddWithValue("@p5", decimal.Parse(Txtdogalgaz.Text));
                sil.Parameters.AddWithValue("@p6", decimal.Parse(Txtinternet.Text));
                sil.Parameters.AddWithValue("@p7", decimal.Parse(Txtmaas.Text));
                sil.Parameters.AddWithValue("@p8", decimal.Parse(Txtekstra.Text));
                sil.Parameters.AddWithValue("@p9", Rchadres.Text);
                sil.Parameters.AddWithValue("@p10", Txtid.Text);
                sil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Gider Güncellenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GiderlerListesi();
            }
        }
    }
}
