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
    public partial class RoomUser : Form
    {
        public RoomUser(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private string username;
        NpgsqlConnection con = new NpgsqlConnection("server = localHost; port = 5432; Database = hotel; user ID = postgres; password = ruhid2705");
        public void listing()
        {
            string selectQuery = "select * from rooms";
            NpgsqlCommand command = new NpgsqlCommand(selectQuery, con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);

            DataTable table = new DataTable();

            dataGridView_rooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_rooms.RowTemplate.Height = 100;
            dataGridView_rooms.AllowUserToAddRows = false;

            da.Fill(table);

            dataGridView_rooms.DataSource = table;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_rooms.Columns[4];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            da.Dispose();
            
        }
        private void RoomUser_Load(object sender, EventArgs e)
        {
            lbl_account.Text = username;
            listing();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            if (rb_search.Checked && cb_search.SelectedIndex > -1)
            {
                string searchQuery = "select * from rooms where name = '" + cb_search.SelectedItem.ToString() + "'and condition = '" + "Free" + "'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(searchQuery, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView_rooms.DataSource = ds.Tables[0];
                con.Close();
            }
            else if (cb_search.SelectedIndex > -1)
            {
                string searchQuery = "select * from rooms where name = '" + cb_search.SelectedItem.ToString() + "'";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(searchQuery, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView_rooms.DataSource = ds.Tables[0];
                con.Close();
            }
            else
            {
                MessageBox.Show("Please choose Catagory and search again");
                con.Close();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            listing();
            cb_search.Text = "Catagory";
            rb_search.Checked = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            UsersPanel page = new UsersPanel(username);
            page.Show();
            this.Hide();
        }

        private void RoomUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
