using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPostgreSQL
{
    public partial class frmLogin : Form
    {
        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", "5432", "postgres", "suong123", "Demo");
        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from login(:_username, :_password)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_username", txtUserName.Text);
                cmd.Parameters.AddWithValue("_password", txtPassword.Text);

                int result = (int)cmd.ExecuteScalar();
                if (result == 1)
                {
                    this.Hide();
                    new frmMain(txtUserName.Text).Show();
                }
                else
                {
                    MessageBox.Show("Please check your username or password!", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
