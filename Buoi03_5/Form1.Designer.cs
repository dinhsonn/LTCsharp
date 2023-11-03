
namespace Buoi03_5
{
    partial class Form1
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
            this.lblThongBao = new System.Windows.Forms.Label();
            this.gbDS = new System.Windows.Forms.GroupBox();
            this.txtDS = new System.Windows.Forms.TextBox();
            this.gbNhapTT = new System.Windows.Forms.GroupBox();
            this.mtxtMaSach = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTTSV = new System.Windows.Forms.Label();
            this.gbDS.SuspendLayout();
            this.gbNhapTT.SuspendLayout();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(53, 56);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(79, 29);
            this.lblThongBao.TabIndex = 9;
            this.lblThongBao.Text = "label1";
            // 
            // gbDS
            // 
            this.gbDS.Controls.Add(this.txtDS);
            this.gbDS.Location = new System.Drawing.Point(390, 186);
            this.gbDS.Name = "gbDS";
            this.gbDS.Size = new System.Drawing.Size(363, 235);
            this.gbDS.TabIndex = 8;
            this.gbDS.TabStop = false;
            this.gbDS.Text = "Danh sách";
            // 
            // txtDS
            // 
            this.txtDS.Location = new System.Drawing.Point(20, 33);
            this.txtDS.Multiline = true;
            this.txtDS.Name = "txtDS";
            this.txtDS.ReadOnly = true;
            this.txtDS.Size = new System.Drawing.Size(337, 196);
            this.txtDS.TabIndex = 0;
            // 
            // gbNhapTT
            // 
            this.gbNhapTT.Controls.Add(this.mtxtMaSach);
            this.gbNhapTT.Controls.Add(this.label5);
            this.gbNhapTT.Controls.Add(this.label4);
            this.gbNhapTT.Controls.Add(this.txtSoLuong);
            this.gbNhapTT.Controls.Add(this.txtGia);
            this.gbNhapTT.Controls.Add(this.txtTenSach);
            this.gbNhapTT.Controls.Add(this.label3);
            this.gbNhapTT.Controls.Add(this.label2);
            this.gbNhapTT.Location = new System.Drawing.Point(47, 97);
            this.gbNhapTT.Name = "gbNhapTT";
            this.gbNhapTT.Size = new System.Drawing.Size(315, 324);
            this.gbNhapTT.TabIndex = 7;
            this.gbNhapTT.TabStop = false;
            this.gbNhapTT.Text = "Nhập thông tin ";
            // 
            // mtxtMaSach
            // 
            this.mtxtMaSach.Location = new System.Drawing.Point(95, 47);
            this.mtxtMaSach.Mask = "000000";
            this.mtxtMaSach.Name = "mtxtMaSach";
            this.mtxtMaSach.Size = new System.Drawing.Size(186, 22);
            this.mtxtMaSach.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(95, 250);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(186, 22);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(95, 177);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(186, 22);
            this.txtGia.TabIndex = 1;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(95, 113);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(186, 22);
            this.txtTenSach.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.btnThoat);
            this.gb.Controls.Add(this.btnXoa);
            this.gb.Controls.Add(this.btnThem);
            this.gb.Location = new System.Drawing.Point(390, 97);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(363, 63);
            this.gb.TabIndex = 6;
            this.gb.TabStop = false;
            this.gb.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(256, 27);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 30);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(142, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 30);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa DS";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm vào DS";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTTSV
            // 
            this.lblTTSV.AutoSize = true;
            this.lblTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTSV.ForeColor = System.Drawing.Color.Red;
            this.lblTTSV.Location = new System.Drawing.Point(299, 29);
            this.lblTTSV.Name = "lblTTSV";
            this.lblTTSV.Size = new System.Drawing.Size(184, 29);
            this.lblTTSV.TabIndex = 5;
            this.lblTTSV.Text = "Thông tin sách";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.gbDS);
            this.Controls.Add(this.gbNhapTT);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.lblTTSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDS.ResumeLayout(false);
            this.gbDS.PerformLayout();
            this.gbNhapTT.ResumeLayout(false);
            this.gbNhapTT.PerformLayout();
            this.gb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.GroupBox gbDS;
        private System.Windows.Forms.TextBox txtDS;
        private System.Windows.Forms.GroupBox gbNhapTT;
        private System.Windows.Forms.MaskedTextBox mtxtMaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTTSV;
    }
}

