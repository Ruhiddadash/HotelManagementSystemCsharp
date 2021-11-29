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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("server = localHost; port = 5432; Database = hotel; user ID = postgres; password = ruhid2705");

        private void btn_register_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text.Trim();
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();
            string confirmPassword = tb_confirmPass.Text.Trim();

            if(username != "" && password != "" && confirmPassword != "")
            {
                if (password == confirmPassword)
                {
                    if (cb_personal.Checked)
                    {
                        con.Open();
                        NpgsqlCommand checkCommand = new NpgsqlCommand("select count(*) from personal where username = @user", con);
                        checkCommand.Parameters.AddWithValue("@user", username);
                        int userExist = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (userExist == 0)
                        {
                            NpgsqlCommand command = new NpgsqlCommand("insert into personal (username,password,email) values (@user,@pass,@email)", con);
                            command.Parameters.AddWithValue("@user", username);
                            command.Parameters.AddWithValue("@pass", password);
                            command.Parameters.AddWithValue("@email", email);
                            command.ExecuteNonQuery();
                            con.Close();
                            Login page = new Login();
                            page.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username already exist!", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            con.Close();
                        }
                      
                    }
                    else
                    {
                        con.Open();
                        NpgsqlCommand checkCommand = new NpgsqlCommand("select count(*) from users where username = @user", con);
                        checkCommand.Parameters.AddWithValue("@user", username);
                        int userExist = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (userExist == 0)
                        {
                            NpgsqlCommand command = new NpgsqlCommand("insert into users (username,password,email) values (@user,@pass,@email)", con);
                            command.Parameters.AddWithValue("@user", username);
                            command.Parameters.AddWithValue("@pass", password);
                            command.Parameters.AddWithValue("@email", email);
                            command.ExecuteNonQuery();
                            con.Close();
                            Login page = new Login();
                            page.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username already exist!", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            con.Close();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Password doesn`t match!", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Use valid data", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Welcome page = new Welcome();
            page.Show();
            this.Hide();

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_showPass.Checked ? '\0' : '•';
            tb_confirmPass.PasswordChar = cb_showPass.Checked ? '\0' : '•';
        }

        private void Register_Load(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '•';
            tb_confirmPass.PasswordChar = '•';
        }
    }
}
