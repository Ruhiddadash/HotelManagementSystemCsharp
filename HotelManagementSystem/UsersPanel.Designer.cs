namespace HotelManagementSystem
{
    partial class UsersPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersPanel));
            this.btn_rooms = new System.Windows.Forms.Button();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.pb_reservation = new System.Windows.Forms.PictureBox();
            this.pb_rooms = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_account = new System.Windows.Forms.Label();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pb_angel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_angel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rooms
            // 
            this.btn_rooms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_rooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rooms.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rooms.ForeColor = System.Drawing.Color.White;
            this.btn_rooms.Location = new System.Drawing.Point(380, 290);
            this.btn_rooms.Name = "btn_rooms";
            this.btn_rooms.Size = new System.Drawing.Size(343, 32);
            this.btn_rooms.TabIndex = 1;
            this.btn_rooms.Text = "Rooms";
            this.btn_rooms.UseVisualStyleBackColor = false;
            this.btn_rooms.Click += new System.EventHandler(this.btn_rooms_Click);
            // 
            // btn_reservation
            // 
            this.btn_reservation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservation.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservation.ForeColor = System.Drawing.Color.White;
            this.btn_reservation.Location = new System.Drawing.Point(380, 462);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Size = new System.Drawing.Size(343, 32);
            this.btn_reservation.TabIndex = 2;
            this.btn_reservation.Text = "My Reservation";
            this.btn_reservation.UseVisualStyleBackColor = false;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            // 
            // pb_reservation
            // 
            this.pb_reservation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_reservation.Image = global::HotelManagementSystem.Properties.Resources.reserved;
            this.pb_reservation.Location = new System.Drawing.Point(517, 394);
            this.pb_reservation.Name = "pb_reservation";
            this.pb_reservation.Size = new System.Drawing.Size(75, 62);
            this.pb_reservation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_reservation.TabIndex = 30;
            this.pb_reservation.TabStop = false;
            // 
            // pb_rooms
            // 
            this.pb_rooms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_rooms.Image = global::HotelManagementSystem.Properties.Resources.living_room;
            this.pb_rooms.Location = new System.Drawing.Point(517, 222);
            this.pb_rooms.Name = "pb_rooms";
            this.pb_rooms.Size = new System.Drawing.Size(75, 62);
            this.pb_rooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_rooms.TabIndex = 29;
            this.pb_rooms.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(23, 672);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(134, 44);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_account
            // 
            this.lbl_account.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.ForeColor = System.Drawing.Color.White;
            this.lbl_account.Location = new System.Drawing.Point(455, 81);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(206, 38);
            this.lbl_account.TabIndex = 0;
            this.lbl_account.Text = "Your Account";
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logo.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.ForeColor = System.Drawing.Color.White;
            this.lbl_logo.Location = new System.Drawing.Point(23, 99);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(109, 32);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "HoTeL";
            // 
            // pb_angel
            // 
            this.pb_angel.Image = global::HotelManagementSystem.Properties.Resources.angel_wings_cartoon_illustration_52777171_removebg_preview;
            this.pb_angel.Location = new System.Drawing.Point(22, 12);
            this.pb_angel.Name = "pb_angel";
            this.pb_angel.Size = new System.Drawing.Size(107, 107);
            this.pb_angel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_angel.TabIndex = 23;
            this.pb_angel.TabStop = false;
            // 
            // UsersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1050, 738);
            this.Controls.Add(this.pb_rooms);
            this.Controls.Add(this.btn_rooms);
            this.Controls.Add(this.pb_reservation);
            this.Controls.Add(this.btn_reservation);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.lbl_logo);
            this.Controls.Add(this.pb_angel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersPanel_FormClosing);
            this.Load += new System.EventHandler(this.UsersPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_reservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_angel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rooms;
        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.PictureBox pb_reservation;
        private System.Windows.Forms.PictureBox pb_rooms;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.PictureBox pb_angel;
    }
}