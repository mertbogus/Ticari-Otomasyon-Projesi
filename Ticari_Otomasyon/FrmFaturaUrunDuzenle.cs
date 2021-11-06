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
    public partial class FrmFaturaUrunDuzenle : Form
    {
        public FrmFaturaUrunDuzenle()
        {
            InitializeComponent();
        }
        public string urunid;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmFaturaUrunDuzenle_Load(object sender, EventArgs e)
        {
            TxtUrunıd.Text = urunid;
            SqlCommand komut = new SqlCommand("Select * From TBL_FATURA where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Txturunad.Text = dr[1].ToString();
                Txtmiktar.Text= dr[2].ToString();
                Txtfiyat.Text= dr[3].ToString();
                Txttutar.Text= dr[4].ToString();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            int tutar;
            int miktar = Convert.ToInt32(Txtmiktar.Text);
            int fiyat = Convert.ToInt32(Txtfiyat.Text);
            tutar = fiyat * miktar;
            Txttutar.Text = tutar.ToString();
            DialogResult dialogResult = MessageBox.Show("Ürünü Güncellemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand guncelle = new SqlCommand("update TBL_FATURA set URUNAD=@p1,MİKTAR=@p2,FİYAT=@p3,TUTAR=@p4 where FATURAURUNID=@p5", bgl.baglanti());
                guncelle.Parameters.AddWithValue("@p1",Txturunad.Text);
                guncelle.Parameters.AddWithValue("@p2",Txtmiktar.Text);
                guncelle.Parameters.AddWithValue("@p3",Txtfiyat.Text);
                guncelle.Parameters.AddWithValue("@p4",Txttutar.Text);
                guncelle.Parameters.AddWithValue("@p5",TxtUrunıd.Text);
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Ürün GGüncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ürünü Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("delete from TBL_FATURA where FATURAURUNID=@p1", bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", TxtUrunıd.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Ürün Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
