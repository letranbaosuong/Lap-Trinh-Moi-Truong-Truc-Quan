using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskCV.Models;

namespace TaskCV
{
    public partial class Form1 : Form
    {
        private TodoTodosDataContext root;
        private int poss = 10;
        public Form1()
        {
            InitializeComponent();
        }
        public void addItem(string text, string mKey, bool isChecked)
        {
            todo_item item = new TaskCV.todo_item(text, mKey, isChecked);
            panel2.Controls.Add(item);
            item.onChange += Item_OnChange;
            item.onDelete += Item_OnDelete;
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }

        private void Item_OnDelete(object sender, EventArgs e)
        {
            MessageBox.Show("Delete");
        }

        private void Item_OnChange(object sender, EventArgs e)
        {
            MessageBox.Show("Update");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            root = new TodoTodosDataContext();
            var todos = from t in root.TodoTodos
                      select t;

            MessageBox.Show(todos.ToString());
        }

        private void btnAddTodo_Click(object sender, EventArgs e)
        {
            string nameTodo = txtAddTodo.Text;
            addItem(nameTodo, "0", false);
            txtAddTodo.Text = "";
            using (root)
            {
                root = new TodoTodosDataContext();
                TodoTodo todo = new TodoTodo
                {
                    NameTodo = nameTodo,
                    Completed = false
                };

                root.TodoTodos.InsertOnSubmit(todo);
                root.SubmitChanges();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
