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
    public partial class UsersPanel : Form
    {
        public UsersPanel(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private string username;
        private void btn_rooms_Click(object sender, EventArgs e)
        {
            RoomUser page = new RoomUser(username);
            page.Show();
            this.Hide();
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            ReservationUser page = new ReservationUser(username);
            page.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login page = new Login();
            page.Show();
            this.Hide();
        }

        private void UsersPanel_Load(object sender, EventArgs e)
        {
            lbl_account.Text = username;
        }

        private void UsersPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
