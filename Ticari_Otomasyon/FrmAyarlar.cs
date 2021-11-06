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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_ADMİN",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource=dt;
        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            Listele();
            Txtkullaniciadi.Text = "";
            Txtsifre.Text = "";
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            if (Btnkaydet.Text=="Kaydet")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_ADMİN values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtkullaniciadi.Text);
                komut.Parameters.AddWithValue("@p2", Txtsifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Kullanıcı Kayıt Edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            if (Btnkaydet.Text=="Güncelle")
            {
                SqlCommand komut2 = new SqlCommand("update TBL_ADMİN set Sifre=@p2 where Kullaniciad=@p1 ", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", Txtkullaniciadi.Text);
                komut2.Parameters.AddWithValue("@p2", Txtsifre.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kullanıcı Bilgileri Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                Txtkullaniciadi.Text = dr["KullaniciAd"].ToString();
                Txtsifre.Text= dr["Sifre"].ToString();
            }
        }

        private void Txtkullaniciadi_TextChanged(object sender, EventArgs e)
        {
            if (Txtkullaniciadi.Text!="")
            {
                Btnkaydet.Text = "Güncelle";
                Btnkaydet.BackColor = Color.YellowGreen;
            }
            else
            {
                Btnkaydet.Text = "Kaydet";
            }
        }
    }
}
