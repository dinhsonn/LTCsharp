using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_3
{
    public partial class Form1 : Form
    {
        int rowindex = -1;
        String[] listLoaiSP = { "Mỹ Phẩm", "Quần Áo", "Đồ ăn", "Nước" };
        String[] listDVTinh = { "Cái", "Thùng", "Ly", "Phần" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double sl;
            double gia;
            try
            {
                if (txtMaSP.Text.Length.Equals(0))
                {
                    throw new Exception("Mã sản phẩm không được để trống");
                }
                if (this.checkMaSP(txtMaSP.Text) == false)
                {
                    throw new Exception("Mã sản phẩm đã tồn tại");
                }
                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Tên sản phẩm không được để trống");
                }
                if (!double.TryParse(txtSoLuong.Text, out sl))
                {
                    throw new Exception("Số lượng không phải số");
                }
                if (!double.TryParse(txtGia.Text, out gia))
                {
                    throw new Exception("Giá không phải số");
                }
                string masv = txtMaSP.Text;
                string ten = txtTenSP.Text;
                string loai = cbLoaiSP.Text;
                string dvTinh = cbDVTinh.Text;
                int row = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[row].Cells["MaSP"].Value = masv;
                dgvDanhSach.Rows[row].Cells["TenSP"].Value = ten;
                dgvDanhSach.Rows[row].Cells["LoaiSP"].Value = loai;
                dgvDanhSach.Rows[row].Cells["SoLuong"].Value = sl;
                dgvDanhSach.Rows[row].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[row].Cells["DVTinh"].Value = dvTinh;
                dgvDanhSach.Rows[row].Cells["ThanhTien"].Value = gia * sl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadLoai();
            loadDVTinh();
        }
        private void loadDVTinh()
        {
            cbDVTinh.DataSource = listDVTinh;
            cbDVTinh.SelectedItem = 0;
        }
        private void loadLoai()
        {
            cbLoaiSP.DataSource = listLoaiSP;
            cbLoaiSP.SelectedItem = 0;
        }
        public bool checkMaSP(string masv)
        {
            if (dgvDanhSach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvDanhSach.Rows.Count - 1; row++)
            {
                if (dgvDanhSach.Rows[row].Cells["MaSP"].Value.ToString() == masv)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            double sl;
            double gia;
            try
            {
                if (this.checkMaSP(txtMaSP.Text) == false && txtMaSP.Text != dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString())
                {
                    throw new Exception("Mã sản phẩm đã tồn tại");
                }
                if (txtMaSP.Text.Length.Equals(0))
                {
                    throw new Exception("Mã sản phẩm không được để trống");
                }

                if (txtTenSP.Text.Length.Equals(0))
                {
                    throw new Exception("Tên sản phẩm không được để trống");
                }
                if (!double.TryParse(txtSoLuong.Text, out sl))
                {
                    throw new Exception("Số lượng không phải số");
                }
                if (!double.TryParse(txtGia.Text, out gia))
                {
                    throw new Exception("Giá không phải số");
                }
                string masv = txtMaSP.Text;
                string ten = txtTenSP.Text;
                string loai = cbLoaiSP.Text;
                string dvTinh = cbDVTinh.Text;

                dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value = masv;
                dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value = ten;
                dgvDanhSach.Rows[rowindex].Cells["LoaiSP"].Value = loai;
                dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value = sl;
                dgvDanhSach.Rows[rowindex].Cells["Gia"].Value = gia;
                dgvDanhSach.Rows[rowindex].Cells["DVTinh"].Value = dvTinh;
                dgvDanhSach.Rows[rowindex].Cells["ThanhTien"].Value = gia * sl;
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
                if (rowindex == -1 || rowindex >= dgvDanhSach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sản phẩm cần xóa");
                }
                dgvDanhSach.Rows.RemoveAt(rowindex);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                       "Bạn có muốn thoát:<",
                        "Thông báo",
                         MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
   );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 && rowindex < dgvDanhSach.Rows.Count - 1)
            {
                txtMaSP.Text = dgvDanhSach.Rows[rowindex].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgvDanhSach.Rows[rowindex].Cells["TenSP"].Value.ToString();
                string loai = dgvDanhSach.Rows[rowindex].Cells["LoaiSP"].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.Rows[rowindex].Cells["SoLuong"].Value.ToString();
                txtGia.Text = dgvDanhSach.Rows[rowindex].Cells["Gia"].Value.ToString();
                string dvTinh = dgvDanhSach.Rows[rowindex].Cells["DVTinh"].Value.ToString();
                int i = 0;
                while (i < listLoaiSP.Length && listLoaiSP[i] != loai)
                {
                    i++;
                }
                cbLoaiSP.SelectedIndex = i;
                int j = 0;
                while (j < listDVTinh.Length && listDVTinh[j] != dvTinh)
                {
                    j++;
                }
                cbDVTinh.SelectedIndex = j;
            }
        }
    }
}
