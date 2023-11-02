using System;
using do_an.Controller;
using do_an.Library;
using do_an.Model;
using System.Windows.Forms;
using do_an.View.List;

namespace do_an.View
{
    public partial class fDashboard : Form
    {
        private bool isLogout = false;
        private bool isExitApplication = false;
        public fDashboard()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            tslImport.Visible = importItem.Visible = Temp.IsAdmin;
            tslInvoice.Visible = !Temp.IsAdmin;
            tslUsername.Text = Temp.IsAdmin ? new bAdmin().GetDetail(Temp.User).Name : new bUser().GetDetail(Temp.User).Name;
        }

        private void tslExit_Click(object sender, EventArgs e)
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

        private void tslLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            isLogout = true;
            this.Close();
        }

        private void tslUsername_Click(object sender, EventArgs e)
        {

        }

        private void tslChangePassword_Click(object sender, EventArgs e)
        {
            using (var frm = new frmChangePassword())
            {
                frm.ShowDialog();
            }
        }

        private void productItem_Click(object sender, EventArgs e)
        {
            new frmProduct__List().Show();
        }

        private void employeeItem_Click(object sender, EventArgs e)
        {
            new frmAccount__List().Show();
        }

        private void classifyItem_Click(object sender, EventArgs e)
        {
            new frmCatalog__List().Show();
        }

        private void customerItem_Click(object sender, EventArgs e)
        {
            new frmCustomer__List().Show();
        }
    }
}
