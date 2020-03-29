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

namespace Bai_1
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
                    MessageBox.Show("Miles > 0!");
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
                        MessageBox.Show("Không chia được cho 0.");
                    }
                    else
                    {
                        efficieny = miles / galion;
                        txtEfficieny.Text = Math.Round(efficieny, 2).ToString();
                    }
                }
            }
            catch(FormatException ex)
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
