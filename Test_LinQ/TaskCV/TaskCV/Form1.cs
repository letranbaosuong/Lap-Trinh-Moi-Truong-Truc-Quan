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
        private List<TodoTodo> listTD;
        public Form1()
        {
            InitializeComponent();
        }
        public void addItem(string text, int mKey, bool isChecked)
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
            var idTodo = ((todo_item)sender).key;
            MessageBox.Show("Delete " + ((todo_item)sender).value);
            var DeleteID = from d in root.TodoTodos
                           where d.IdToDo == idTodo
                           select d;
            root.TodoTodos.DeleteAllOnSubmit(DeleteID);
            root.SubmitChanges();
            panel2.Controls.Clear();
            loadData();
        }

        private void Item_OnChange(object sender, EventArgs e)
        {
            /*panel2.Controls.Clear();
            loadData();*/
            var _idTodo = ((todo_item)sender).key;
            var _nameTodo = ((todo_item)sender).value;
            var _completedTodo = ((todo_item)sender).ckbTodoItem.Checked;

            MessageBox.Show(_idTodo + " " + _nameTodo + " " + _completedTodo);

            TodoTodo todoOld = new TodoTodo();
            todoOld.IdToDo = _idTodo;
            todoOld.NameTodo = _nameTodo;
            todoOld.Completed = _completedTodo;

            root = new TodoTodosDataContext();
            TodoTodo todoUpdate = new TodoTodo();
            todoUpdate = root.TodoTodos.Single(x => x.IdToDo == _idTodo);
            setTodoUpdate(todoUpdate, todoOld);
            root.SubmitChanges();
        }

        private TodoTodo setTodoUpdate(TodoTodo todoUpdate, TodoTodo todoOld)
        {
            todoUpdate.IdToDo = todoOld.IdToDo;
            todoUpdate.NameTodo = todoOld.NameTodo;
            todoUpdate.Completed = todoOld.Completed;

            return todoUpdate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            root = new TodoTodosDataContext();
            var todos = (from t in root.TodoTodos
                         select t).ToList<TodoTodo>();
            listTD = todos;
            for (int i = 0; i < listTD.Count(); i++)
            {
                //addItem(listTD[i].NameTodo, listTD[i].IdToDo, (listTD[i].Completed.ToString() == "1" ? true : false));
                addItem(listTD[i].NameTodo, listTD[i].IdToDo, listTD[i].Completed.Value);
            }
        }

        private void btnAddTodo_Click(object sender, EventArgs e)
        {
            string nameTodo = txtAddTodo.Text;
            addItem(nameTodo, 0, false);
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
