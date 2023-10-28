using System;
using System.Windows.Forms;

namespace Buoi04_1
{
    public partial class Form1 : Form
    {
        int rowchoose;
        string[] danhsachkhoa = { "CNTT", "QTKD", "Kế toán", "Ngoại ngữ" };

        public Form1()
        {
            InitializeComponent();
        }

        private void loadKhoa()
        {
            cbKhoa.DataSource = danhsachkhoa;
            cbKhoa.SelectedItem = 0;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dtpNgaySinh.MaxDate = DateTime.Now;
            loadKhoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMasv.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên phải có đúng 10 ký tự");
                }

                if (txtHoten.Text.Length < 2)
                {
                    throw new Exception("Họ tên sinh viên phải có ít nhất 2 ký tự");
                }

                // Lấy thông tin
                string masv = txtMasv.Text;
                string hoten = txtHoten.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;

                int rowIndex = dgvDanhSach.Rows.Add(); // Tạo mới một hàng, trả về vị trí thêm
                dgvDanhSach.Rows[rowIndex].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowIndex].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowIndex].Cells["Ngaysinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowIndex].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.RowIndex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }

                rowchoose = e.RowIndex;
                txtMasv.Text = dgvDanhSach.Rows[rowchoose].Cells["MaSV"].Value.ToString();
                txtHoten.Text = dgvDanhSach.Rows[rowchoose].Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Text = dgvDanhSach.Rows[rowchoose].Cells["Ngaysinh"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowchoose].Cells["Khoa"].Value.ToString();
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần cập nhật");
                }

                if (txtMasv.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên phải đúng 10 ký tự");
                }

                if (txtHoten.Text.Length < 2)
                {
                    throw new Exception("Họ tên sinh viên ít nhất 2 ký tự");
                }

                // Lấy thông tin
                string masv = txtMasv.Text;
                string hoten = txtHoten.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string khoa = cbKhoa.Text;

                // Lưu dữ liệu vào lưới
                dgvDanhSach.Rows[rowchoose].Cells["MaSV"].Value = masv;
                dgvDanhSach.Rows[rowchoose].Cells["HoTen"].Value = hoten;
                dgvDanhSach.Rows[rowchoose].Cells["Ngaysinh"].Value = ngaysinh;
                dgvDanhSach.Rows[rowchoose].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần xoá");
                }

                dgvDanhSach.Rows.RemoveAt(rowchoose);
                rowchoose = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
