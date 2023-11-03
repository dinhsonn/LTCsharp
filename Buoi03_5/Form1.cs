using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_5
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
                if (txtTenSach.Text.Length.Equals(0))
                {
                    throw new Exception("Tên sách không được để trống");
                }
                string ten = txtTenSach.Text;
                string masach = mtxtMaSach.Text;
                string gia = txtGia.Text;
                string soLuong = txtSoLuong.Text;
                txtDS.Text += stt + " Tên sách: " + ten + " Gia: " + gia + " Số lượng: " + soLuong + "\r\n";
                stt++;
            }
            catch (Exception ex)
            {
                lblThongBao.Text = ex.Message;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDS.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
