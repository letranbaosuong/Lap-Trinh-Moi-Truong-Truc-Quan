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

namespace Bai_4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double miles, galion, efficieny;
                miles = Double.Parse(txtMiles.Text.Trim(), CultureInfo.InvariantCulture);
                galion = Double.Parse(txtGalion.Text.Trim(), CultureInfo.InvariantCulture);

                if (miles < 0)
                {
                    MessageBox.Show("Miles => 0!");
                    txtMiles.SelectAll();
                    txtMiles.Focus();
                }
                else if (galion < 0)
                {
                    MessageBox.Show("Galions > 0!");
                    txtGalion.SelectAll();
                    txtGalion.Focus();
                }
                else
                {
                    if (galion == 0)
                    {
                        txtGalion.SelectAll();
                        txtGalion.Focus();
                        errorProviderGalions.SetError(txtGalion, "Không chia được cho 0.");
                    }
                    else
                    {
                        errorProviderGalions.SetError(txtGalion, null);
                        efficieny = miles / galion;
                        txtEfficieny.Text = Math.Round(efficieny, 2).ToString();
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Sai định dạng đầu vào!");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Không chia được cho 0.");
            }
        }

        private void txtMiles_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMiles.Text))
            {
                e.Cancel = true;
                txtMiles.SelectAll();
                txtMiles.Focus();
                errorProviderMiles.SetError(txtMiles, "Không được bỏ trống Miles!");
            }
            else
            {
                e.Cancel = false;
                errorProviderMiles.SetError(txtMiles, null);
            }
        }

        private void txtGalion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGalion.Text))
            {
                e.Cancel = true;
                txtGalion.SelectAll();
                txtGalion.Focus();
                errorProviderGalions.SetError(txtGalion, "Không được bỏ trống Galions!");
            }
            else
            {
                e.Cancel = false;
                errorProviderGalions.SetError(txtGalion, null);
            }
        }
    }
}
