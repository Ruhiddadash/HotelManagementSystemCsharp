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
    public partial class Reservation : Form
    {
        public Reservation(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private string username;
        NpgsqlConnection con = new NpgsqlConnection("server = localHost; port = 5432; Database = hotel; user ID = postgres; password = ruhid2705");

        DateTime today;
        public void clear()
        {
            tb_id.Clear();

            cb_rooms.Text = "Rooms";
            cb_user.SelectedIndex = 0;
            enter_date.Value = today;
            end_date.Value = today;

        }
        public void listing()
        {
            con.Open();
            string query = "select * from reservation order by id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_reservations.DataSource = ds.Tables[0];
            con.Close();
        }
        
        public  void fillRoom()
        {
            con.Open();
            string fillQuary = "select * from rooms where condition = " + "'Free' order by number";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(fillQuary, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_rooms.DisplayMember = "number";
            cb_rooms.ValueMember = "number";
            cb_rooms.DataSource = dt;
            con.Close();
        }
        public void fillUser()
        {
            con.Open();
            string fillQuary = "select * from users order by id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(fillQuary, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_user.DisplayMember = "username";
            cb_user.ValueMember = "username";
            cb_user.DataSource = dt;
            con.Close();
        }
        private void Reservation_Load(object sender, EventArgs e)
        {
            lbl_account.Text = username;
            today = enter_date.Value;
            listing();
            fillRoom();
            fillUser();
        }

        private void enter_date_ValueChanged(object sender, EventArgs e)
        {
            int result = DateTime.Compare(enter_date.Value, today);
            if (result < 0)
            {
                MessageBox.Show("Wrong Date");
                enter_date.Value = today;
            }
                
        }

        private void end_date_ValueChanged(object sender, EventArgs e)
        {
            int result = DateTime.Compare(end_date.Value,enter_date.Value);
            if (result < 0)
            {
                MessageBox.Show("Wrong Date");
                end_date.Value = today;
            }
        }
        public void addRoom()
        {
            string conditionB = "Busy";
            
            int roomNumberB = int.Parse(cb_rooms.SelectedValue.ToString());
            

            con.Open();
            string editQuery = "update rooms set condition = '" + conditionB + "' where number = " + roomNumberB + ";";
            
            NpgsqlCommand editCommand = new NpgsqlCommand(editQuery, con);
            
            editCommand.ExecuteNonQuery();
           
            con.Close();
            fillRoom();
        }
        public void updateRoom()
        {
            string conditionB = "Busy";
            string conditionF = "Free";
            int roomNumberB = int.Parse(cb_rooms.SelectedValue.ToString());
            int roomNumberF = int.Parse(dataGridView_reservations.SelectedRows[0].Cells[2].Value.ToString());
            con.Open();
            string editQuery = "update rooms set condition = '" + conditionB + "' where number = " + roomNumberB + ";";
            NpgsqlCommand editCommand = new NpgsqlCommand(editQuery, con);
            editCommand.ExecuteNonQuery(); 
            con.Close();
            con.Open();
            
            string editQueryF = "update rooms set condition = '" + conditionF + "' where number = " + roomNumberF + ";";
            NpgsqlCommand editCommandF = new NpgsqlCommand(editQueryF, con);
            editCommandF.ExecuteNonQuery();
            con.Close();
            fillRoom();
        }
        public void deleteRoom()
        {
            string condition = "Free";
            int roomNumber = int.Parse(dataGridView_reservations.SelectedRows[0].Cells[2].Value.ToString());
            con.Open();
            string editQuery = "update rooms set condition = '" + condition + "' where number = " + roomNumber + ";";
            NpgsqlCommand editCommand = new NpgsqlCommand(editQuery, con);
            editCommand.ExecuteNonQuery();
            con.Close();
            fillRoom();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            
            con.Open();
            NpgsqlCommand command = new NpgsqlCommand("insert into reservation (client,room,enter,exit) values (@client,@room,@enter,@end)", con);
            command.Parameters.AddWithValue("@client", cb_user.SelectedValue.ToString());
            command.Parameters.AddWithValue("@room",int.Parse(cb_rooms.SelectedValue.ToString()));
            command.Parameters.AddWithValue("@enter", enter_date.Value.ToString());
            command.Parameters.AddWithValue("@end", end_date.Value.ToString());
            command.ExecuteNonQuery();
            con.Close();
            addRoom();
            listing();
            clear();
        }

        private void dataGridView_reservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_reservations.CurrentRow.Selected = true;
            tb_id.Text = dataGridView_reservations.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string delQuery = "delete from reservation where id = " + tb_id.Text + "";
            NpgsqlCommand delCommand = new NpgsqlCommand(delQuery, con);
            delCommand.ExecuteNonQuery();
            con.Close();
            deleteRoom();
            listing();
            clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            string editQuery = "update reservation set client = '" + cb_user.SelectedValue.ToString() + "',room = '" + int.Parse(cb_rooms.SelectedValue.ToString()) + "'," +
                "enter = '" + enter_date.Value.ToString() + "',exit = '"+end_date.Value.ToString()+"' where id = " + tb_id.Text + ";";
            NpgsqlCommand editCommand = new NpgsqlCommand(editQuery, con);
            editCommand.ExecuteNonQuery();
            con.Close();
            updateRoom();
            listing();
            clear();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            con.Open();
            string searchQuery = "select * from reservation where client like '%" + tb_search.Text + "%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(searchQuery, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView_reservations.DataSource = ds.Tables[0];
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

        private void Reservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
