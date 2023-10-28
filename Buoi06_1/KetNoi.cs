using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Buoi06_1
{
    class KetNoi
    {
        string sqlConnect;

        public KetNoi()
        {
            sqlConnect = ConfigurationManager.ConnectionStrings["ChuoiKN"].ToString();
        }

        public SqlConnection GetConnect()
        {
            SqlConnection conn = new SqlConnection(sqlConnect);
            return conn;
        }
    }
}
