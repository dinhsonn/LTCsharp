
namespace do_an.View
{
    partial class frmChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.chbShowPassword = new System.Windows.Forms.CheckBox();
            this.btPrimary = new System.Windows.Forms.Button();
            this.btDanger = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(19, 64);
            this.tbCurrent.Multiline = true;
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(252, 34);
            this.tbCurrent.TabIndex = 4;
            // 
            // tbNew
            // 
            this.tbNew.Location = new System.Drawing.Point(19, 141);
            this.tbNew.Multiline = true;
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(252, 34);
            this.tbNew.TabIndex = 5;
            // 
            // tbConfirm
            // 
            this.tbConfirm.Location = new System.Drawing.Point(19, 217);
            this.tbConfirm.Multiline = true;
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(252, 34);
            this.tbConfirm.TabIndex = 6;
            // 
            // chbShowPassword
            // 
            this.chbShowPassword.AutoSize = true;
            this.chbShowPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbShowPassword.Location = new System.Drawing.Point(19, 263);
            this.chbShowPassword.Name = "chbShowPassword";
            this.chbShowPassword.Size = new System.Drawing.Size(147, 21);
            this.chbShowPassword.TabIndex = 7;
            this.chbShowPassword.Text = "Hiển thị mật khẩu";
            this.chbShowPassword.UseVisualStyleBackColor = true;
            this.chbShowPassword.CheckedChanged += new System.EventHandler(this.chbShowPassword_CheckedChanged);
            // 
            // btPrimary
            // 
            this.btPrimary.Location = new System.Drawing.Point(12, 361);
            this.btPrimary.Name = "btPrimary";
            this.btPrimary.Size = new System.Drawing.Size(93, 52);
            this.btPrimary.TabIndex = 8;
            this.btPrimary.Text = "Lưu";
            this.btPrimary.UseVisualStyleBackColor = true;
            this.btPrimary.Click += new System.EventHandler(this.btPrimary_Click);
            // 
            // btDanger
            // 
            this.btDanger.Location = new System.Drawing.Point(133, 361);
            this.btDanger.Name = "btDanger";
            this.btDanger.Size = new System.Drawing.Size(93, 52);
            this.btDanger.TabIndex = 9;
            this.btDanger.Text = "Hủy";
            this.btDanger.UseVisualStyleBackColor = true;
            this.btDanger.Click += new System.EventHandler(this.btDanger_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(255, 361);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(93, 52);
            this.btRefresh.TabIndex = 10;
            this.btRefresh.Text = "Làm mới";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.label2);
            this.pnContent.Controls.Add(this.tbCurrent);
            this.pnContent.Controls.Add(this.label4);
            this.pnContent.Controls.Add(this.tbNew);
            this.pnContent.Controls.Add(this.chbShowPassword);
            this.pnContent.Controls.Add(this.label3);
            this.pnContent.Controls.Add(this.tbConfirm);
            this.pnContent.Location = new System.Drawing.Point(12, 68);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(336, 287);
            this.pnContent.TabIndex = 11;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btDanger);
            this.Controls.Add(this.btPrimary);
            this.Controls.Add(this.label1);
            this.Name = "frmChangePassword";
            this.Text = "Đổi mật khẩu";
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.CheckBox chbShowPassword;
        private System.Windows.Forms.Button btPrimary;
        private System.Windows.Forms.Button btDanger;
        private System.Windows.Forms.Button btRefresh;
        
    }
}