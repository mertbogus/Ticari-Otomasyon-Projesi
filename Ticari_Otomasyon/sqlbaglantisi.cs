using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-KEJIT91;Initial Catalog=Dbo.TicariOtomasyon;Integrated Security=True");
            bgl.Open();
            return bgl;
        }
    }
}
