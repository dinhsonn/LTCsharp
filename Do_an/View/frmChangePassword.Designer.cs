
namespace Do_an.View
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btPrimary = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btDanger = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu hiện tại";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(41, 95);
            this.tbCurrent.Multiline = true;
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(229, 34);
            this.tbCurrent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu mới";
            // 
            // tbNew
            // 
            this.tbNew.Location = new System.Drawing.Point(41, 165);
            this.tbNew.Multiline = true;
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(229, 34);
            this.tbNew.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 236);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 34);
            this.textBox1.TabIndex = 6;
            // 
            // btPrimary
            // 
            this.btPrimary.Location = new System.Drawing.Point(12, 290);
            this.btPrimary.Name = "btPrimary";
            this.btPrimary.Size = new System.Drawing.Size(79, 44);
            this.btPrimary.TabIndex = 8;
            this.btPrimary.Text = "Lưu";
            this.btPrimary.UseVisualStyleBackColor = true;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(207, 290);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(79, 44);
            this.btRefresh.TabIndex = 9;
            this.btRefresh.Text = "Làm mới";
            this.btRefresh.UseVisualStyleBackColor = true;
            // 
            // btDanger
            // 
            this.btDanger.Location = new System.Drawing.Point(110, 290);
            this.btDanger.Name = "btDanger";
            this.btDanger.Size = new System.Drawing.Size(79, 44);
            this.btDanger.TabIndex = 10;
            this.btDanger.Text = "Hủy";
            this.btDanger.UseVisualStyleBackColor = true;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 402);
            this.Controls.Add(this.btDanger);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btPrimary);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btPrimary;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btDanger;
    }
}