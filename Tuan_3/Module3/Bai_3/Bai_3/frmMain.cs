using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtBanKinh.Text == "")
            {
                MessageBox.Show("Nhập Bán Kính!");
                txtBanKinh.SelectAll();
                txtBanKinh.Focus();
            }
            else
            {
                double chuVi, banKinh = 0;
                banKinh = Double.Parse(txtBanKinh.Text.Trim(), CultureInfo.InvariantCulture);
                if (banKinh <= 0)
                {
                    MessageBox.Show("Bán kính phải > 0");
                    txtBanKinh.SelectAll();
                    txtBanKinh.Focus();
                }
                else
                {
                    chuVi = 2 * Math.PI * banKinh;
                    txtChuVi.Text = chuVi.ToString();
                }
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtChuVi.Clear();
            txtBanKinh.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Muốn Thoát Hả?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes) Close();
        }

        private void txtBanKinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
