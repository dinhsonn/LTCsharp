using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_2
{
    public partial class Form1 : Form
    {
        int rowindex = -1;
        string[] listKhoa = { "CNTT", "QTKD", "Kế Toán", "Ngoại Ngữ" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = listKhoa;
        }
        private void btnThem_Click(object sender, EventArgs e)
{
    double diemtb;
    
    try
    {
        if (mtxtMaSV.Text.Length != 10)
        {
            throw new Exception("Mã sinh viên phải có 10 ký tự");
        }
        
        if (this.checkMaSV(mtxtMaSV.Text))
        {
            throw new Exception("Mã sinh viên đã tồn tại");
        }

        if (string.IsNullOrEmpty(txtHoTen.Text))
        {
            throw new Exception("Họ tên không được để trống");
        }

        if (!double.TryParse(txtDiemTB.Text, out diemtb))
        {
            throw new Exception("Điểm TB phải là số");
        }

        string masv = mtxtMaSV.Text;
        string hoten = txtHoTen.Text;
        string khoa = cbKhoa.Text;

        int row = dgvDanhSach.Rows.Add();
        dgvDanhSach.Rows[row].Cells["MaSV"].Value = masv;
        dgvDanhSach.Rows[row].Cells["HoTen"].Value = hoten;
        dgvDanhSach.Rows[row].Cells["DiemTB"].Value = diemtb;
        dgvDanhSach.Rows[row].Cells["Khoa"].Value = khoa;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "Thông báo");
    }
}

    }
}
