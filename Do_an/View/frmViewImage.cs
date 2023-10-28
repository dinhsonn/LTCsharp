using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace Do_an.View
{
    public partial class frmViewImage : Form
    {
        public frmViewImage(string path)
        {
            InitializeComponent();
            setImage(path);
            this.Text = $"{this.Tag}: {Path.GetFileName(path)}";
        }
        private void setImage(string path)
        {
            if (File.Exists(path)) picMain.Image = Image.FromFile(path);
            else picMain.Image = Properties.Resources.image_preview_icon_picture_placeholder_vector_31284806;
        }
        private void frmViewImage_Load(object sender, EventArgs e)
        {

        }
    }
}
