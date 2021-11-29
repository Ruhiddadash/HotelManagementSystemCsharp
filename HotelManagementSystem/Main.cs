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
    public partial class Main : Form
    {
        public Main(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private string username;

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_account.Text = username;
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Client page = new Client(username);
            page.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login page = new Login();
            page.Show();
            this.Hide();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            Personal page = new Personal(username);
            page.Show();
            this.Hide();
        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            Room page = new Room(username);
            page.Show();
            this.Hide();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            Reservation page = new Reservation(username);
            page.Show();
            this.Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
