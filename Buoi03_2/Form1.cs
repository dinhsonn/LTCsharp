    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Buoi03_2
    {
        public partial class Form1 : Form
        {
            private int stt = 1;
            public Form1()
            {
                InitializeComponent();
            }

            private void btnThem_Click(object sender, EventArgs e)
            {
                try
                {
                    if (txtHoTen.Text.Length.Equals(0))
                    {
                        throw new Exception("Họ tên sinh viên không để trống");
                    }
                    string hoten = txtHoTen.Text;
                    string masv = mtxMaSV.Text;
                    string ngaysinh = mtxNgaySinh.Text;
                    string gioitinh = (rbNam.Checked) ? "Nam" : "Nữ";
                    string sothich = null;
                    if (chbDuLich.Checked)
                    {
                        sothich += "Du Lịch";
                    }
                    if (chbTheThao.Checked)
                    {
                        sothich += "Thể Thao";
                    }   
                    if (chbMuaSam.Checked)
                    {
                        sothich += "Mua Sắm";
                    }
                    if (sothich != null)
                    {
                        sothich = "Sở thích: " + sothich;
                    }
                    txtDanhSach.Text += stt + " Họ tên: " + hoten + " Ngày sinh: " + ngaysinh + " Giới tính: " + gioitinh + " " + sothich + "\r\n";
                    stt++;
                }catch(Exception ex)
                {
                    lblThongBao.Text = ex.Message;
                }
            }

            private void btnXoa_Click(object sender, EventArgs e)
            {
                txtDanhSach.Text = "";
            }


        private void mtxNgaySinh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {
                string pattern = @"^\d{2}/\d{2}/\d{4}$"; // Ngày sinh phải có định dạng "dd/MM/yyyy"
                string inputText = mtxNgaySinh.Text.Replace("_", ""); // Lấy dữ liệu trong MaskedTextBox và loại bỏ ký tự '_'

                if (!System.Text.RegularExpressions.Regex.IsMatch(inputText, pattern))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập lại theo đúng mẫu (dd/MM/yyyy).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void txtHoTen_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                {
                    MessageBox.Show("Họ tên bắt buộc phải nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
