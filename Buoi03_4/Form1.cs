using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi03_4
{
    public partial class Form1 : Form
    {
        private static int chon = -1;
        private static int sl = -1;
        List<int> ban = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSV();
            loadBan();
        }
        private void loadBan()
        {
            ban.Add(1);
            ban.Add(2);
            ban.Add(3);
            ban.Add(4);
            cbBan.DataSource = ban.ToList();
            cbBan.SelectedIndex = 0;
        }

        private void loadSV()
        {
            /*lvMon.Items.Add("Cơm chiên");
            lvMon.Items.Add("Lẩu thái");
            lvMon.Items.Add("Mực hấp");
            lvMon.Items.Add("Chân gà xả tắc");
            lvMon.Items.Add("Mì xào");*/
            cbBan.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (chon != -1 && sl != -1)
            {
                string tenMon = lvMon.SelectedItems[0].SubItems[1].Text;
                string gia = lvMon.SelectedItems[0].SubItems[2].Text;
                string sl = lbSoLuong.SelectedItem.ToString();
                string ban = cbBan.SelectedItem.ToString();
                ListViewItem item = new ListViewItem(ban);
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tenMon });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = sl });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = gia });
                lvDatMon.Items.Add(item);
                chon = -1;
                sl = -1;
            }
        }

        private void lvMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            chon = 1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvDatMon.Items)
            {
                if (item.Selected)
                {
                    lvDatMon.Items.Remove(item);
                }
            }
        }

        private void lbSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sl = 1;
        }
    }
}
