
namespace Do_an.View
{
    partial class frmViewImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picMain);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 441);
            this.panel1.TabIndex = 0;
            // 
            // picMain
            // 
            this.picMain.Image = global::Do_an.Properties.Resources.image_preview_icon_picture_placeholder_vector_31284806;
            this.picMain.Location = new System.Drawing.Point(9, 10);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(775, 425);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // frmViewImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmViewImage";
            this.Text = "frmViewImage";
            this.Load += new System.EventHandler(this.frmViewImage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMain;
    }
}