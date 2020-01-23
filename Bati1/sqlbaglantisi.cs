using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bati1
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-090J43E4\\SQLEXPRESS;Initial Catalog=BiletSatis;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
