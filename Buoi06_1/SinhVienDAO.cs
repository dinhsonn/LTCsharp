using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Buoi06_1
{
    class SinhVienDAO
    {
        SqlCommand cmd = null;
        SqlConnection conn = null;
        KetNoi kn = new KetNoi();
        SqlDataAdapter apt = null;

        public SinhVienDAO()
        {
            conn = kn.GetConnect();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public DataTable GetList(int? makhoa = null)
        {
            string sql = null;
            if (makhoa == null)
            {
                sql = "SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.DiemTB, Khoa.TenKhoa ";
                sql += "FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa = SinhVien.MaKhoa";
            }
            else
            {
                sql = "SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.DiemTB, Khoa.TenKhoa ";
                sql += "FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa = SinhVien.MaKhoa WHERE SinhVien.Makhoa = '" + makhoa + "'";
            }
            cmd = new SqlCommand(sql, conn); // Sử dụng biến conn đã khai báo và khởi tạo ở cấp độ lớp.
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
        public int GetCount()
        {
            string sql = "SELECT COUNT(SinhVien.MaSV) FROM SinhVien INNER JOIN Khoa ON Khoa.Makhoa = SinhVien.Makhoa";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        public DataRow GetRow(string masv)
        {
            string sql = "SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.DiemTB, Khoa.TenKhoa ";
            sql += "FROM SinhVien INNER JOIN Khoa ON Khoa.Makhoa = SinhVien.MaKhoa WHERE SinhVien.MaSV = '" + masv + "'";

            cmd = new SqlCommand(sql, conn);
            apt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return row;
            }

            return null;
        }
        public void Insert(SinhVien sv)
        {
            string sql = "INSERT INTO Sinhvien (MaSV, HoTen, Makhoa, DiemTB) ";
            sql += "VALUES('" + sv.MaSV + "', N'" + sv.HoTen + "', " + sv.Makhoa + ", " + sv.DiemTB + ")";

            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Update(SinhVien sv)
        {
            string sql = "UPDATE Sinhvien SET HoTen=N'" + sv.HoTen + "', Makhoa=" + sv.Makhoa + ", DiemTB=" + sv.DiemTB;
            sql += " WHERE MaSV='" + sv.MaSV + "'";

            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Delete(string masv)
        {
            string sql = "DELETE FROM SinhVien WHERE MaSV = '" + masv + "'";

            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }



    }
}
