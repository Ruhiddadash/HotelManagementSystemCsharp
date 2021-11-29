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

namespace HotelManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("server = localHost; port = 5432; Database = hotel; user ID = postgres; password = ruhid2705");
        private NpgsqlCommand command;
        private string sql = null;
        private void btn_register_Click(object sender, EventArgs e)
        {
            Register page = new Register();
            page.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Welcome page = new Welcome();
            page.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();
            try
            {
                if(cb_personal.Checked)
                {
                    con.Open();
                    sql = @"select * from p_login(:_username, :_password)";
                    command = new NpgsqlCommand(sql, con);

                    command.Parameters.AddWithValue("_username", username);
                    command.Parameters.AddWithValue("_password", password);

                    int result = (int)command.ExecuteScalar();
                    con.Close();

                    if (result == 1)
                    {
                        Main page = new Main(username);
                        page.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login or Password wrong!", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    con.Open();
                    sql = @"select * from u_login(:_username, :_password)";
                    command = new NpgsqlCommand(sql, con);

                    command.Parameters.AddWithValue("_username", username);
                    command.Parameters.AddWithValue("_password", password);

                    int result = (int)command.ExecuteScalar();
                    con.Close();

                    if (result == 1)
                    {
                        UsersPanel page = new UsersPanel(username);
                        page.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login or Password wrong!", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '•';
        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_showPass.Checked ? '\0' : '•';
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
