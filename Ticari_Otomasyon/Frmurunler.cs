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
    public partial class Frmurunler : Form
    {
        public Frmurunler()
        {
            InitializeComponent();
        }
        Frmurunler urunler;
        sqlbaglantisi bgl = new sqlbaglantisi();
        void UrunListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            Txtad.Text = "";
            Txtalis.Text = "";
            Txtfiyat.Text = "";
            Txtmarka.Text = "";
            Txtmodel.Text = "";
            Rchdetay.Text = "";
            Nudadet.Value = 0;
            Mskyil.Text = "";

        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Frmurunler_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALİSFİYAT,SATİSFİYAT,DETAY) values" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",Txtad.Text);
            komut.Parameters.AddWithValue("@p2",Txtmarka.Text);
            komut.Parameters.AddWithValue("@p3",Txtmodel.Text);
            komut.Parameters.AddWithValue("@p4",Mskyil.Text);
            komut.Parameters.AddWithValue("@p5",int.Parse((Nudadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6",decimal.Parse(Txtalis.Text));
            komut.Parameters.AddWithValue("@p7",decimal.Parse(Txtfiyat.Text));
            komut.Parameters.AddWithValue("@p8",Rchdetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Başarılı Bir Şekilde Eklenmiştir.","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Temizle();
            UrunListele();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
          
            DialogResult dialogResult = MessageBox.Show("Seçili Ürün Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_URUNLER where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Seçili Ürün Başarılı Bir Şekilde Silinmiştir.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            
     
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data =gridView1.GetDataRow(gridView1.FocusedRowHandle);
            Txtid.Text = data["ID"].ToString();
            Txtad.Text = data["URUNAD"].ToString();
            Txtmarka.Text= data["MARKA"].ToString();
            Txtmodel.Text= data["MODEL"].ToString();
            Mskyil.Text= data["YIL"].ToString();
            Nudadet.Value = int.Parse(data["ADET"].ToString());
            Txtalis.Text= data["ALİSFİYAT"].ToString();
           Txtfiyat.Text= data["SATİSFİYAT"].ToString();
            Rchdetay.Text= data["DETAY"].ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seçili Ürün Güncellensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALİSFİYAT=@p6,SATİSFİYAT=@p7,DETAY=@p8 where ID=@p9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtad.Text);
                komut.Parameters.AddWithValue("@p2", Txtmarka.Text);
                komut.Parameters.AddWithValue("@p3", Txtmodel.Text);
                komut.Parameters.AddWithValue("@p4", Mskyil.Text);
                komut.Parameters.AddWithValue("@p5", int.Parse((Nudadet.Value).ToString()));
                komut.Parameters.AddWithValue("@p6", decimal.Parse(Txtalis.Text));
                komut.Parameters.AddWithValue("@p7", decimal.Parse(Txtfiyat.Text));
                komut.Parameters.AddWithValue("@p8", Rchdetay.Text);
                komut.Parameters.AddWithValue("@p9", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün Başarılı Bir Şekilde Güncellenmiştir.", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UrunListele();
            }
            

        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
