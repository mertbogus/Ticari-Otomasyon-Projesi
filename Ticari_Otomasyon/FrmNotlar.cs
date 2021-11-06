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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Temizle()
        {
            Txtid.Text = "";
            Msktarih.Text = "";
            Msksaat.Text = "";
            Txtbaslik.Text = "";
            Txthitap.Text = "";
            Txtolusturan.Text = "";
            Rchadres.Text = "";
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Firma Eklemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand save = new SqlCommand("insert into TBL_NOTLAR (TARİH,SAAT,NOTBASLIK,NOTDETAY,NOTOLUSTURAN,HITAP) values" +
                "(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                save.Parameters.AddWithValue("@p1", Msktarih.Text);
                save.Parameters.AddWithValue("@p2", Msksaat.Text);
                save.Parameters.AddWithValue("@p3", Txtbaslik.Text);
                save.Parameters.AddWithValue("@p4", Rchadres.Text);
                save.Parameters.AddWithValue("@p5", Txtolusturan.Text);
                save.Parameters.AddWithValue("@p6", Txthitap.Text);
                save.ExecuteNonQuery();
                MessageBox.Show("Not Başarıyla Eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow da = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (da != null)
            {
                Txtid.Text = da["ID"].ToString();
                Msktarih.Text= da["TARİH"].ToString();
                Msksaat.Text= da["SAAT"].ToString();
                Txtbaslik.Text= da["NOTBASLIK"].ToString();
                Txtolusturan.Text= da["NOTOLUSTURAN"].ToString(); 
                Txthitap.Text= da["HITAP"].ToString();
                Rchadres.Text= da["NOTDETAY"].ToString();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Notu Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand delete = new SqlCommand("delete from TBL_NOTLAR where ID=@p1",bgl.baglanti());
                delete.Parameters.AddWithValue("@p1",Txtid.Text);
                delete.ExecuteNonQuery();
                MessageBox.Show("Not Başarıyla Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
                
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Notu Güncellemek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand save = new SqlCommand("update TBL_NOTLAR set TARİH=@p1,SAAT=@p2,NOTBASLIK=@p3,NOTDETAY=@p4,NOTOLUSTURAN=@p5,HITAP=@p6", bgl.baglanti());
                save.Parameters.AddWithValue("@p1", Msktarih.Text);
                save.Parameters.AddWithValue("@p2", Msksaat.Text);
                save.Parameters.AddWithValue("@p3", Txtbaslik.Text);
                save.Parameters.AddWithValue("@p4", Rchadres.Text);
                save.Parameters.AddWithValue("@p5", Txtolusturan.Text);
                save.Parameters.AddWithValue("@p6", Txthitap.Text);
                save.ExecuteNonQuery();
                MessageBox.Show("Not Başarıyla Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay detay = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                detay.metin = dr["NOTDETAY"].ToString();
            }
            detay.Show();
        }
    }
}
