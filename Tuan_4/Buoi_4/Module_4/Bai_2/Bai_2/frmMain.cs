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

namespace Bai_2
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
                    txtMiles.Focus();
                    txtMiles.SelectAll();
                    errorProviderMiles.SetError(txtMiles, "Miles > 0!");
                }
                else if(miles >= 0)
                {
                    errorProviderMiles.SetError(txtMiles, null);
                    if (galion < 0)
                    {
                        txtGalion.Focus();
                        txtGalion.SelectAll();
                        errorProviderGalions.SetError(txtGalion, "Galions > 0!");
                    }
                    else if (galion >= 0)
                    {
                        errorProviderGalions.SetError(txtGalion, null);
                        if (galion == 0)
                        {
                            MessageBox.Show("Không chia được cho 0.");
                        }
                        else
                        {
                            efficieny = miles / galion;
                            txtEfficieny.Text = Math.Round(efficieny, 2).ToString();
                        }
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
    }
}
