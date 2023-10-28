using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Buoi06_1
{
    class KhoaDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi kn = new KetNoi();

        public DataTable GetList()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = kn.GetConnect())
            {
                string sql = "SELECT * FROM Khoa";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataAdapter apt = new SqlDataAdapter(cmd))
                {
                    apt.Fill(dt);
                }
            }

            return dt;
        }
    }
}
