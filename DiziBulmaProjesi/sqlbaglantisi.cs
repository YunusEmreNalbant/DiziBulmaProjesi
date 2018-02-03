using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DiziBulmaProjesi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-S04O6JB\\SQLEXPRESS;Initial Catalog=DiziOtagProjesi;Integrated Security=True");
            baglan.Open();
            return baglan;

        }


    }
}
