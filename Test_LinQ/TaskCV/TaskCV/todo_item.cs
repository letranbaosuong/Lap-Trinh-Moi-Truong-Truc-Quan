using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskCV
{
    public partial class todo_item : UserControl
    {
        // event
        public event EventHandler onChange = null;
        public event EventHandler onDelete = null;
        public string key = null;
        public string value = null;
        public todo_item()
        {
            InitializeComponent();
        }
        public todo_item(string text,string mKey, bool isChecked)
        {
            key = mKey;
            value = text;
            InitializeComponent();
            lblTodoItem.Text = text;
            ckbTodoItem.Checked = isChecked;
        }

        private void ckbTodoItem_OnChange(object sender, EventArgs e)
        {
            if (ckbTodoItem.Checked)
            {
                lblTodoItem.Font = new Font(lblTodoItem.Font.Name, lblTodoItem.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                lblTodoItem.Font = new Font(lblTodoItem.Font.Name, lblTodoItem.Font.SizeInPoints, FontStyle.Regular);
            }
            if (onChange != null)
            {
                onChange.Invoke(this, new EventArgs());
            }
        }

        private void btnDelTodoItem_Click(object sender, EventArgs e)
        {
            if (onDelete != null)
            {
                onDelete.Invoke(this, new EventArgs());
            }
        }

        private void todo_item_Load(object sender, EventArgs e)
        {
            if (ckbTodoItem.Checked)
            {
                lblTodoItem.Font = new Font(lblTodoItem.Font.Name, lblTodoItem.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                lblTodoItem.Font = new Font(lblTodoItem.Font.Name, lblTodoItem.Font.SizeInPoints, FontStyle.Regular);
            }
        }
    }
}
