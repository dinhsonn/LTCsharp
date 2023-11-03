using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "jpg|*.jpg|png|*.png|gif|*.gif |bmp|*.bmp | Tất cả| *.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                String pathFile = openFile.FileName;
                pbHinh.Image = new Bitmap(pathFile);
            }
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Document|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFile.FileName, FileMode.Open);//mở và chỉ đọc
                StreamReader stream = new StreamReader(fs, Encoding.UTF8);
                txtNoiDung.Text = stream.ReadToEnd();

            }
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "txt";//đặt phần mở rộng tệp mặc định thành ".txt" cho tệp đã lưu.Nếu người dùng không chỉ định tiện ích mở rộng khi lưu tệp
            saveFile.Filter = "Text Document |*.txt";
            saveFile.AddExtension = true;//nếu người dùng nhập "myfile" mà không có phần mở rộng, hộp thoại sẽ tự động thêm phần mở rộng tệp đã chọn (ví dụ: ".txt" hoặc ".jpg") vào tên tệp.
            saveFile.RestoreDirectory = true;//nhớ thư mục đã chọn trước đó và khi hộp thoại được mở lại, nó sẽ bắt đầu trong thư mục được chọn cuối cùng.
            saveFile.Title = "Where do you want to save the file?";
            saveFile.InitialDirectory = @"C:/";//hộp thoại ban đầu sẽ mở trong thư mục ổ C: khi nó được hiển thị.
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFile.FileName, FileMode.Create);//mở và ghi tệp
                StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
                writer.WriteLine(txtNoiDung.Text);
                writer.Flush();
                fs.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Bạn muốn thoát :<",
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
