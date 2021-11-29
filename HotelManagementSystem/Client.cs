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
    public partial class Client : Form
    {
        public Client(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private string username;
        NpgsqlConnection con = new NpgsqlConnection("server = localHost; port = 5432; Database = hotel; user ID = postgres; password = ruhid2705");
        public void listing()
        {
            con.Open();
            string query = "select id,username,email from users order by id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_client.DataSource = ds.Tables[0];
            con.Close();
        }
        public void clear()
        {
            tb_id.Clear();
            tb_email.Clear();
            tb_username.Clear();
            tb_password.Clear();

        }
        private void Client_Load(object sender, EventArgs e)
        {
            lbl_account.Text = username;
            listing();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text.Trim();
            string username = tb_username.Text.Trim();
            string password = tb_password.Text.Trim();
            

            con.Open();
            NpgsqlCommand command = new NpgsqlCommand("insert into users (username,password,email) values (@user,@pass,@email)", con);
            
            command.Parameters.AddWithValue("@user", username);
            command.Parameters.AddWithValue("@pass", password);
            command.Parameters.AddWithValue("@email", email);
            command.ExecuteNonQuery();
            con.Close();
            clear();
            listing();
        }


        private void dataGridView_client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_client.CurrentRow.Selected = true;
            tb_id.Text = dataGridView_client.Rows[e.RowIndex].Cells["id"].Value.ToString();
            tb_email.Text = dataGridView_client.Rows[e.RowIndex].Cells["email"].Value.ToString();
            tb_username.Text = dataGridView_client.Rows[e.RowIndex].Cells["username"].Value.ToString();
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string delQuery = "delete from users where id = " +tb_id.Text+"";
            NpgsqlCommand delCommand = new NpgsqlCommand(delQuery, con);
            delCommand.ExecuteNonQuery();
            con.Close();
            clear();
            listing();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            string editQuery = "update users set username = '" + tb_username.Text + "',email = '" + tb_email.Text + "'," +
                "password = '" + tb_password.Text + "' where id = " + tb_id.Text + ";";
            NpgsqlCommand editCommand = new NpgsqlCommand(editQuery, con);
            editCommand.ExecuteNonQuery();
            con.Close();
            clear();
            listing();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            string searchQuery = "select id,username,email from users where username like '%" +tb_search.Text+"%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(searchQuery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_client.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            listing();
            tb_search.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main page = new Main(username);
            page.Show();
            this.Hide();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
