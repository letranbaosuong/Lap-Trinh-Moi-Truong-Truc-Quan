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
            this.ActiveControl = txtA;
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Muốn thoát hả?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes) Close();
        }

        private void btnTimNghiem_Click(object sender, EventArgs e)
        {
            double heSoA = 0, heSoB = 0;
            if (txtA.Text == "")
            {
                MessageBox.Show("Nhập a!");
                txtA.SelectAll();
                txtA.Focus();
            }
            else if (txtA.Text == "")
            {
                MessageBox.Show("Nhập b!");
                txtB.SelectAll();
                txtB.Focus();
            }
            else
            {
                heSoA = Double.Parse(txtA.Text.Trim(), CultureInfo.InvariantCulture);
                heSoB = Double.Parse(txtB.Text.Trim(), CultureInfo.InvariantCulture);

                if (heSoA == 0)
                {
                    if (heSoB == 0)
                    {
                        txtNghiem.Text = "Phương trình vô số nghiệm.";
                    }
                    else
                    {
                        txtNghiem.Text = "Phương trình vô nghiệm.";
                    }
                }
                else
                {
                    if (heSoB == 0)
                    {
                        txtNghiem.Text = ("Phương trình có 1 nghiệm x = 0");
                    }
                    else
                    {
                        double x = -heSoB / heSoA;
                        txtNghiem.Text = ("Phương trình có 1 nghiệm x = " + Math.Round(x, 1));
                    }
                }
            }
        }

        private void btnTimNghiemPTB2_Click(object sender, EventArgs e)
        {
            double heSoA = 0, heSoB = 0, heSoC = 0;
            if (txtHSA.Text == "")
            {
                MessageBox.Show("Nhập a!");
                txtHSA.SelectAll();
                txtHSA.Focus();
            }
            else if (txtHSC.Text == "")
            {
                MessageBox.Show("Nhập b!");
                txtHSC.SelectAll();
                txtHSC.Focus();
            }
            else if (txtHSB.Text == "")
            {
                MessageBox.Show("Nhập b!");
                txtHSB.SelectAll();
                txtHSB.Focus();
            }
            else
            {
                heSoA = Double.Parse(txtHSA.Text.Trim(), CultureInfo.InvariantCulture);
                heSoB = Double.Parse(txtHSC.Text.Trim(), CultureInfo.InvariantCulture);
                heSoC = Double.Parse(txtHSB.Text.Trim(), CultureInfo.InvariantCulture);

                if (heSoA == 0)
                {
                    if (heSoB == 0)
                    {
                        if (heSoC == 0)
                        {
                            txtNghiemPTB2.Text = "Phương trình vô số nghiệm.";
                        }
                        else
                        {
                            txtNghiemPTB2.Text = "Phương trình vô nghiệm.";
                        }
                    }
                    else
                    {
                        if (heSoC == 0)
                        {
                            txtNghiemPTB2.Text = ("Phương trình có 1 nghiệm x = 0");
                        }
                        else
                        {
                            double x = -heSoC / heSoB;
                            txtNghiemPTB2.Text = ("Phương trình có 1 nghiệm x = " + Math.Round(x, 1));
                        }
                    }
                }
                else
                {
                    double d, x1, x2;
                    d = Math.Pow(heSoB, 2) - 4 * heSoA * heSoC;
                    if (d == 0)
                    {
                        txtNghiemPTB2.Text = ("Phương tình có nghiệm kép x1 = x2 = " + Math.Round((-heSoB / (2.0 * heSoA)), 2));
                    }
                    else if (d > 0)
                    {
                        x1 = (-heSoB - Math.Sqrt(d)) / (2 * heSoA);
                        x2 = (-heSoB + Math.Sqrt(d)) / (2 * heSoA);

                        txtNghiemPTB2.Text = ("x1 = " + Math.Round(x1, 2) + ", x2 = " + Math.Round(x2, 2));
                    }
                    else
                        txtNghiemPTB2.Text = ("Phương trình vô nghiệm.");
                }
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                // Allow Digits
            }
            else if (Char.IsControl(e.KeyChar))
            {
                // Allow Control
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains('.'))
            {
                //Allows only one Dot Char
            }
            else if (e.KeyChar == '-' && !((TextBox)sender).Text.Contains('-'))
            {
                //Allows only one - Char
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnTiepTucB1_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtNghiem.Clear();
            txtA.Focus();
        }

        private void btnTiepTucB2_Click(object sender, EventArgs e)
        {
            txtHSA.Clear();
            txtHSB.Clear();
            txtHSC.Clear();
            txtNghiemPTB2.Clear();
            txtHSA.Focus();
        }
    }
}
