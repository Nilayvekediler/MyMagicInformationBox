using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CSharpSonProjem
{
    class Sql
    {
       
        public SqlConnection baglantiSagla()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GE4SKD8\SQLEXPRESS;Initial Catalog=Bilgiler;Integrated Security=True");
            baglanti.Open();
            return baglanti;

        }
      
    }
}
