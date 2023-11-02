using System;
using System.Windows.Forms;

namespace Buoi06_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SinhVienDAO svDao = new SinhVienDAO();
        KhoaDAO khDao = new KhoaDAO();
        string insertupdate = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            mtxtMaSV.Enabled = false;
            btnXoa.Enabled = false;

            LoadDSSinhVien();
            LoadDSKhoa();
            TongSinhVien();
        }
        private void LoadDSSinhVien()
        {
            dgvDanhSach.DataSource = svDao.GetList();
        }
        private void LoadDSKhoa()
        {
            cbKhoa.DataSource = khDao.GetList();
            cbKhoa.DisplayMember = "Tenkhoa";
            cbKhoa.ValueMember = "Makhoa";
        }


        private void TongSinhVien()
        {
            txtTongSV.Text = svDao.GetCount().ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
                insertupdate = "insert";
                btnLuu.Enabled = true;
                mtxtMaSV.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnLuu.Enabled = true;
            mtxtMaSV.Enabled = false;
        }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if (rowIndex < 0 || rowIndex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }

                mtxtMaSV.Text = dgvDanhSach.Rows[rowIndex].Cells["MaSV"].Value.ToString();
                txtHoTen.Text = dgvDanhSach.Rows[rowIndex].Cells["HoTen"].Value.ToString();
                cbKhoa.Text = dgvDanhSach.Rows[rowIndex].Cells["Tenkhoa"].Value.ToString();
                txtDiemTB.Text = dgvDanhSach.Rows[rowIndex].Cells["DiemTB"].Value.ToString();
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb = 0;
                if (mtxtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên phải có 10 ký tự số");
                }
                if (!double.TryParse(txtDiemTB.Text, out diemtb))
                {
                    throw new Exception("Điểm sinh viên phải là số");
                }
                string masv = mtxtMaSV.Text;
                string hoten = txtHoTen.Text;
                int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
                SinhVien sv = new SinhVien(masv, hoten, makhoa, diemtb);

                switch (insertupdate)
                {
                    case "insert":
                        svDao.Insert(sv);
                        LoadDSSinhVien();
                        TongSinhVien();
                        MessageBox.Show("Thêm thành công", "Thông báo");
                        break;
                    case "update":
                        svDao.Update(sv);
                        LoadDSSinhVien();
                        TongSinhVien();
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtxtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên không đúng");
                }
                string masv = mtxtMaSV.Text;
                svDao.Delete(masv);
                LoadDSSinhVien();
                TongSinhVien();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            int makhoa = int.Parse(cbKhoa.SelectedValue.ToString());
            dgvDanhSach.DataSource = svDao.GetList(makhoa);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
