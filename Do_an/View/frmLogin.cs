using System;
using do_an.Controller;
using do_an.Library;
using do_an.Model;
using System.Windows.Forms;

namespace do_an.View
{
    public partial class frmLogin : Form
    {
        private string user, pass;
        private bool isExitApplication = false;

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                login();
            }
            catch (Exception ex)
            {
                ShowMessagebox.Exception(ex);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            try
            {
                isExitApplication = true;
                this.Close();
            }
            catch (Exception ex)
            {
                ShowMessagebox.Exception(ex);
            }
        }
        private void login()
        {
            bool result = checkAccount();

            if (!result) return;

            try
            {
                var frm = new fDashboard();
                this.Hide();
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.Yes)
                {
                    isExitApplication = true;
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox.Exception(ex);
            }
        }

        private bool checkAccount()
        {
            bool rs = check();

            if (!rs) return false;

            var checkAD = new bAdmin().CheckExists(user, pass);
            var checkEMP = new bUser().CheckExists(user, pass);

            if (!checkAD && !checkEMP)
            {
                ShowMessagebox.Error("Tài khoản hoặc mật khẩu không đúng!");
                return false;
            }

            Temp.User = user;
            Temp.IsAdmin = checkAD;

            return true;
        }

        private bool check()
        {
            user = tbUsername.Text.Trim();
            pass = tbPassword.Text.Trim();
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                ShowMessagebox.Error("Vui lòng nhập đầy đủ tài khoản và mật khẩu!");
                return false;
            }

            return true;
        }

        private bool checkText()
        {
            var user = tbUsername.Text.Trim();
            var pass = tbPassword.Text.Trim();

            return string.IsNullOrEmpty(user) && string.IsNullOrEmpty(pass);
        }



        public frmLogin()
        {
            InitializeComponent();
        }


    }
}
