namespace HotelManagementSystem
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_account = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.btn_rooms = new System.Windows.Forms.Button();
            this.pb_reservation = new System.Windows.Forms.PictureBox();
            this.pb_rooms = new System.Windows.Forms.PictureBox();
            this.pb_personal = new System.Windows.Forms.PictureBox();
            this.pb_client = new System.Windows.Forms.PictureBox();
            this.pb_angel = new System.Windows.Forms.PictureBox();
            this.panel_client = new System.Windows.Forms.Panel();
            this.panel_rooms = new System.Windows.Forms.Panel();
            this.panel_reservation = new System.Windows.Forms.Panel();
            this.panel_team = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_personal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_angel)).BeginInit();
            this.panel_client.SuspendLayout();
            this.panel_rooms.SuspendLayout();
            this.panel_reservation.SuspendLayout();
            this.panel_team.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logo.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.ForeColor = System.Drawing.Color.White;
            this.lbl_logo.Location = new System.Drawing.Point(12, 100);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(109, 32);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "HoTeL";
            // 
            // lbl_account
            // 
            this.lbl_account.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.ForeColor = System.Drawing.Color.White;
            this.lbl_account.Location = new System.Drawing.Point(408, 156);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(206, 38);
            this.lbl_account.TabIndex = 0;
            this.lbl_account.Text = "Your Account";
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(32, 660);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(134, 44);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_client
            // 
            this.btn_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client.ForeColor = System.Drawing.Color.White;
            this.btn_client.Location = new System.Drawing.Point(12, 96);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(343, 32);
            this.btn_client.TabIndex = 1;
            this.btn_client.Text = "Client";
            this.btn_client.UseVisualStyleBackColor = false;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_personal
            // 
            this.btn_personal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_personal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_personal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personal.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_personal.ForeColor = System.Drawing.Color.White;
            this.btn_personal.Location = new System.Drawing.Point(13, 99);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(343, 32);
            this.btn_personal.TabIndex = 2;
            this.btn_personal.Text = "Personal Team";
            this.btn_personal.UseVisualStyleBackColor = false;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            // 
            // btn_reservation
            // 
            this.btn_reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservation.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservation.ForeColor = System.Drawing.Color.White;
            this.btn_reservation.Location = new System.Drawing.Point(12, 101);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(343, 32);
            this.btn_reservation.TabIndex = 4;
            this.btn_reservation.Text = "Reservation";
            this.btn_reservation.UseVisualStyleBackColor = false;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            // 
            // btn_rooms
            // 
            this.btn_rooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_rooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rooms.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rooms.ForeColor = System.Drawing.Color.White;
            this.btn_rooms.Location = new System.Drawing.Point(14, 99);
            this.btn_rooms.Name = "btn_rooms";
            this.btn_rooms.Size = new System.Drawing.Size(343, 32);
            this.btn_rooms.TabIndex = 3;
            this.btn_rooms.Text = "Rooms";
            this.btn_rooms.UseVisualStyleBackColor = false;
            this.btn_rooms.Click += new System.EventHandler(this.btn_rooms_Click);
            // 
            // pb_reservation
            // 
            this.pb_reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pb_reservation.Image = global::HotelManagementSystem.Properties.Resources.reserved;
            this.pb_reservation.Location = new System.Drawing.Point(150, 33);
            this.pb_reservation.Name = "pb_reservation";
            this.pb_reservation.Size = new System.Drawing.Size(75, 62);
            this.pb_reservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_reservation.TabIndex = 18;
            this.pb_reservation.TabStop = false;
            // 
            // pb_rooms
            // 
            this.pb_rooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pb_rooms.Image = global::HotelManagementSystem.Properties.Resources.living_room;
            this.pb_rooms.Location = new System.Drawing.Point(150, 31);
            this.pb_rooms.Name = "pb_rooms";
            this.pb_rooms.Size = new System.Drawing.Size(75, 62);
            this.pb_rooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_rooms.TabIndex = 17;
            this.pb_rooms.TabStop = false;
            // 
            // pb_personal
            // 
            this.pb_personal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pb_personal.Image = global::HotelManagementSystem.Properties.Resources.team;
            this.pb_personal.Location = new System.Drawing.Point(151, 34);
            this.pb_personal.Name = "pb_personal";
            this.pb_personal.Size = new System.Drawing.Size(75, 59);
            this.pb_personal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_personal.TabIndex = 16;
            this.pb_personal.TabStop = false;
            // 
            // pb_client
            // 
            this.pb_client.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pb_client.Image = global::HotelManagementSystem.Properties.Resources.user;
            this.pb_client.Location = new System.Drawing.Point(148, 31);
            this.pb_client.Name = "pb_client";
            this.pb_client.Size = new System.Drawing.Size(75, 59);
            this.pb_client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_client.TabIndex = 15;
            this.pb_client.TabStop = false;
            // 
            // pb_angel
            // 
            this.pb_angel.Image = global::HotelManagementSystem.Properties.Resources.angel_wings_cartoon_illustration_52777171_removebg_preview;
            this.pb_angel.Location = new System.Drawing.Point(12, 12);
            this.pb_angel.Name = "pb_angel";
            this.pb_angel.Size = new System.Drawing.Size(107, 107);
            this.pb_angel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_angel.TabIndex = 11;
            this.pb_angel.TabStop = false;
            // 
            // panel_client
            // 
            this.panel_client.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_client.Controls.Add(this.pb_client);
            this.panel_client.Controls.Add(this.btn_client);
            this.panel_client.Location = new System.Drawing.Point(83, 233);
            this.panel_client.Name = "panel_client";
            this.panel_client.Size = new System.Drawing.Size(367, 158);
            this.panel_client.TabIndex = 0;
            // 
            // panel_rooms
            // 
            this.panel_rooms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_rooms.Controls.Add(this.pb_rooms);
            this.panel_rooms.Controls.Add(this.btn_rooms);
            this.panel_rooms.Location = new System.Drawing.Point(83, 434);
            this.panel_rooms.Name = "panel_rooms";
            this.panel_rooms.Size = new System.Drawing.Size(367, 158);
            this.panel_rooms.TabIndex = 0;
            // 
            // panel_reservation
            // 
            this.panel_reservation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_reservation.Controls.Add(this.pb_reservation);
            this.panel_reservation.Controls.Add(this.btn_reservation);
            this.panel_reservation.Location = new System.Drawing.Point(555, 434);
            this.panel_reservation.Name = "panel_reservation";
            this.panel_reservation.Size = new System.Drawing.Size(367, 158);
            this.panel_reservation.TabIndex = 0;
            // 
            // panel_team
            // 
            this.panel_team.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_team.Controls.Add(this.pb_personal);
            this.panel_team.Controls.Add(this.btn_personal);
            this.panel_team.Location = new System.Drawing.Point(555, 233);
            this.panel_team.Name = "panel_team";
            this.panel_team.Size = new System.Drawing.Size(367, 158);
            this.panel_team.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1064, 727);
            this.Controls.Add(this.panel_team);
            this.Controls.Add(this.panel_reservation);
            this.Controls.Add(this.panel_rooms);
            this.Controls.Add(this.panel_client);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.lbl_logo);
            this.Controls.Add(this.pb_angel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_personal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_angel)).EndInit();
            this.panel_client.ResumeLayout(false);
            this.panel_rooms.ResumeLayout(false);
            this.panel_reservation.ResumeLayout(false);
            this.panel_team.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.PictureBox pb_angel;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pb_client;
        private System.Windows.Forms.PictureBox pb_personal;
        private System.Windows.Forms.PictureBox pb_rooms;
        private System.Windows.Forms.PictureBox pb_reservation;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.Button btn_rooms;
        private System.Windows.Forms.Panel panel_client;
        private System.Windows.Forms.Panel panel_rooms;
        private System.Windows.Forms.Panel panel_reservation;
        private System.Windows.Forms.Panel panel_team;
    }
}