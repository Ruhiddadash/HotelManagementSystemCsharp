using Npgsql;
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

namespace HotelManagementSystem
{
    public partial class Room : Form
    {
        public Room(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private string username;
        NpgsqlConnection con = new NpgsqlConnection("server = localHost; port = 5432; Database = hotel; user ID = postgres; password = ruhid2705");


        public void clear()
        {
            tb_roomNumber.Clear();
            tb_id.Clear();
            if (rb_busy.Checked || rb_free.Checked)
            {
                rb_free.Checked = false;
                rb_busy.Checked = false;
            }

            pb_room.Image = null;
            cb_catagory.Text = "Catagory";
            tb_price.Clear();

        }

        public void listing()
        {
            string selectQuery = "select * from rooms order by number";
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
        private void btn_choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pb_room.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int roomNumber = int.Parse(tb_roomNumber.Text.Trim());
            int roomPrice = int.Parse(tb_price.Text.Trim());
            string catagory = cb_catagory.SelectedItem.ToString();
            

            MemoryStream ms = new MemoryStream();
            pb_room.Image.Save(ms, pb_room.Image.RawFormat);
            byte[] img = ms.ToArray();

            string isFree;
            if (rb_free.Checked)
                isFree = "Free";
            else
                isFree = "Busy";

            con.Open();
            NpgsqlCommand command = new NpgsqlCommand("insert into rooms (number,name,condition,images,price) values (@number,@name,@cond,@image,@price)", con);
            command.Parameters.AddWithValue("@number", roomNumber);
            command.Parameters.AddWithValue("@name", catagory);
            command.Parameters.AddWithValue("@cond", isFree);
            command.Parameters.AddWithValue("@image", img);
            command.Parameters.AddWithValue("@price", roomPrice);
            command.ExecuteNonQuery();
            con.Close();
            listing();
            clear();

        }

        private void Room_Load(object sender, EventArgs e)
        {
            lbl_account.Text = username;
            tb_id.Visible = false;
            listing();
        }

        private void dataGridView_rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_rooms.CurrentRow.Selected = true;
            tb_id.Text = dataGridView_rooms.Rows[e.RowIndex].Cells["id"].Value.ToString();
            tb_roomNumber.Text = dataGridView_rooms.Rows[e.RowIndex].Cells["number"].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string delQuery = "delete from rooms where number = " + tb_roomNumber.Text + "";
            NpgsqlCommand delCommand = new NpgsqlCommand(delQuery, con);
            delCommand.ExecuteNonQuery();
            con.Close();
            listing();
            clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int roomNumber = int.Parse(tb_roomNumber.Text.Trim());
            int roomPrice = int.Parse(tb_price.Text.Trim());
            string catagory = cb_catagory.SelectedItem.ToString();
            string isFree;
            if (rb_free.Checked)
                isFree = "Free";
            else
                isFree = "Busy";
            con.Open();

            string editQuery = "update rooms set number = '" + roomNumber + "', name = '" + catagory + "',condition = '" + isFree + "',price = '" + roomPrice + "' where id = '" + int.Parse(tb_id.Text.Trim())+ "'";

            NpgsqlCommand editCommand = new NpgsqlCommand(editQuery, con);
            editCommand.ExecuteNonQuery();
            con.Close();
            listing();
            clear();

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
            else if(cb_search.SelectedIndex > -1)
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
            Main page = new Main(username);
            page.Show();
            this.Hide();
        }

        private void Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
