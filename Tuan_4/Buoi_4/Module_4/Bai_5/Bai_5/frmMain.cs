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

namespace Bai_5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cldlg = new ColorDialog();
            cldlg.Color = rtBox.ForeColor;

            if (cldlg.ShowDialog() == DialogResult.OK)
                rtBox.ForeColor = cldlg.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog ftDialog = new
               FontDialog();
            ftDialog.Font = rtBox.Font;
            if (ftDialog.ShowDialog() ==
                 DialogResult.OK)
            {
                rtBox.Font = ftDialog.Font;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "(*.txt)|*.txt|(All)|*.*";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                rtBox.LoadFile(openDlg.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "(*.txt)|*.txt|(All)|*.*";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                rtBox.SaveFile(saveDlg.FileName, RichTextBoxStreamType.PlainText);
                /*Stream stream = saveDlg.OpenFile();//Open to Write
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(rtBox.Text);
                writer.Close();*/
            }

        }
    }
}
