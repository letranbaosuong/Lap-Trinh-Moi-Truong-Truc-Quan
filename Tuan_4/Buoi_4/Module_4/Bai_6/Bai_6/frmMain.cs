using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Muốn thoát hả?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes) Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtUserName.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                e.Cancel = false;
                txtUserName.SelectAll();
                txtUserName.Focus();
                errorProvider.SetError(txtUserName, "Không được để trống hoặc chứa khoảng trắng!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUserName, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
           if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = false;
                txtPassword.SelectAll();
                txtPassword.Focus();
                errorProvider.SetError(txtPassword, "Không được để trống hoặc chứa khoảng trắng!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPassword, null);
            }
        }
    }
}
