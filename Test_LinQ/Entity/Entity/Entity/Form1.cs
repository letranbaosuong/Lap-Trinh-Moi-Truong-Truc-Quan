using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (TaskCVEntitiesNe context = new TaskCVEntitiesNe())
            {
                //Get the List of Departments from Database
                var departmentList = from d in context.todos
                                     select d;

                foreach (var dept in departmentList)
                {
                    MessageBox.Show(dept.nameTodo);
                }

            }
        }
    }
}
