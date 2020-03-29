using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "(*.txt)|*.txt|(All)|*.*";
            saveDlg.FileName = txtFileName.Text;
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveDlg.OpenFile();//Open to Write
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(txtTextSave.Text);
                writer.Close();
            }

        }
    }
}
