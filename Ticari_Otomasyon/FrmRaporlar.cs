using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'Dbo_TicariOtomasyonDataSet1.TBL_GIDERLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_GIDERLERTableAdapter.Fill(this.Dbo_TicariOtomasyonDataSet1.TBL_GIDERLER);
            // TODO: Bu kod satırı 'TicariOtomasyonMüsteriDataSet.TBL_MUSTERİLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_MUSTERİLERTableAdapter.Fill(this.TicariOtomasyonMüsteriDataSet.TBL_MUSTERİLER);
            // TODO: Bu kod satırı 'TicariOtomasyonDataSet.TBL_FİRMALAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_FİRMALARTableAdapter.Fill(this.TicariOtomasyonDataSet.TBL_FİRMALAR);
            reportViewer2.RefreshReport();
            reportViewer1.RefreshReport();
            reportViewer4.RefreshReport();

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer4_Load(object sender, EventArgs e)
        {

        }
    }
}
