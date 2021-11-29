namespace HotelManagementSystem
{
    partial class Room
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_roomnumber = new System.Windows.Forms.Label();
            this.tb_roomNumber = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView_rooms = new System.Windows.Forms.DataGridView();
            this.rb_free = new System.Windows.Forms.RadioButton();
            this.rb_busy = new System.Windows.Forms.RadioButton();
            this.cb_catagory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_choose = new System.Windows.Forms.Button();
            this.pb_room = new System.Windows.Forms.PictureBox();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.rb_search = new System.Windows.Forms.RadioButton();
            this.lbl_price = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_account = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_room)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(777, 26);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(91, 41);
            this.btn_refresh.TabIndex = 13;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_roomnumber
            // 
            this.lbl_roomnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_roomnumber.AutoSize = true;
            this.lbl_roomnumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomnumber.ForeColor = System.Drawing.Color.White;
            this.lbl_roomnumber.Location = new System.Drawing.Point(1184, 139);
            this.lbl_roomnumber.Name = "lbl_roomnumber";
            this.lbl_roomnumber.Size = new System.Drawing.Size(136, 23);
            this.lbl_roomnumber.TabIndex = 36;
            this.lbl_roomnumber.Text = "Room Number";
            // 
            // tb_roomNumber
            // 
            this.tb_roomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_roomNumber.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_roomNumber.Location = new System.Drawing.Point(1185, 167);
            this.tb_roomNumber.Multiline = true;
            this.tb_roomNumber.Name = "tb_roomNumber";
            this.tb_roomNumber.Size = new System.Drawing.Size(328, 41);
            this.tb_roomNumber.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(680, 26);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(91, 41);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(1371, 678);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(139, 52);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(1371, 740);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(139, 52);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(1197, 740);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(139, 52);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView_rooms
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridView_rooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_rooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_rooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(96)))));
            this.dataGridView_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_rooms.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_rooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(96)))));
            this.dataGridView_rooms.Location = new System.Drawing.Point(12, 87);
            this.dataGridView_rooms.Name = "dataGridView_rooms";
            this.dataGridView_rooms.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_rooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_rooms.RowHeadersWidth = 51;
            this.dataGridView_rooms.RowTemplate.Height = 24;
            this.dataGridView_rooms.Size = new System.Drawing.Size(1146, 705);
            this.dataGridView_rooms.TabIndex = 0;
            this.dataGridView_rooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_rooms_CellClick);
            // 
            // rb_free
            // 
            this.rb_free.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_free.AutoSize = true;
            this.rb_free.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.rb_free.ForeColor = System.Drawing.Color.White;
            this.rb_free.Location = new System.Drawing.Point(1197, 430);
            this.rb_free.Name = "rb_free";
            this.rb_free.Size = new System.Drawing.Size(75, 27);
            this.rb_free.TabIndex = 4;
            this.rb_free.TabStop = true;
            this.rb_free.Text = "Free";
            this.rb_free.UseVisualStyleBackColor = true;
            // 
            // rb_busy
            // 
            this.rb_busy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_busy.AutoSize = true;
            this.rb_busy.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.rb_busy.ForeColor = System.Drawing.Color.White;
            this.rb_busy.Location = new System.Drawing.Point(1322, 430);
            this.rb_busy.Name = "rb_busy";
            this.rb_busy.Size = new System.Drawing.Size(81, 27);
            this.rb_busy.TabIndex = 5;
            this.rb_busy.TabStop = true;
            this.rb_busy.Text = "Busy";
            this.rb_busy.UseVisualStyleBackColor = true;
            // 
            // cb_catagory
            // 
            this.cb_catagory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_catagory.Font = new System.Drawing.Font("Arial", 16.2F);
            this.cb_catagory.FormattingEnabled = true;
            this.cb_catagory.Items.AddRange(new object[] {
            "Honeymoon Suite",
            "Family Room",
            "Single Room"});
            this.cb_catagory.Location = new System.Drawing.Point(1185, 241);
            this.cb_catagory.Name = "cb_catagory";
            this.cb_catagory.Size = new System.Drawing.Size(328, 40);
            this.cb_catagory.TabIndex = 2;
            this.cb_catagory.Text = "Catagory";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1181, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Condition";
            // 
            // btn_choose
            // 
            this.btn_choose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_choose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choose.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choose.ForeColor = System.Drawing.Color.White;
            this.btn_choose.Location = new System.Drawing.Point(1197, 678);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(139, 52);
            this.btn_choose.TabIndex = 6;
            this.btn_choose.Text = "Choose";
            this.btn_choose.UseVisualStyleBackColor = false;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // pb_room
            // 
            this.pb_room.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_room.Location = new System.Drawing.Point(1191, 469);
            this.pb_room.Name = "pb_room";
            this.pb_room.Size = new System.Drawing.Size(342, 191);
            this.pb_room.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_room.TabIndex = 43;
            this.pb_room.TabStop = false;
            // 
            // cb_search
            // 
            this.cb_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_search.Font = new System.Drawing.Font("Arial", 16.2F);
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Honeymoon Suite",
            "Family Room",
            "Single Room"});
            this.cb_search.Location = new System.Drawing.Point(298, 23);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(243, 40);
            this.cb_search.TabIndex = 10;
            this.cb_search.Text = "Catagory";
            // 
            // rb_search
            // 
            this.rb_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rb_search.AutoSize = true;
            this.rb_search.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.rb_search.ForeColor = System.Drawing.Color.White;
            this.rb_search.Location = new System.Drawing.Point(574, 32);
            this.rb_search.Name = "rb_search";
            this.rb_search.Size = new System.Drawing.Size(75, 27);
            this.rb_search.TabIndex = 11;
            this.rb_search.TabStop = true;
            this.rb_search.Text = "Free";
            this.rb_search.UseVisualStyleBackColor = true;
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(1187, 303);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(113, 23);
            this.lbl_price.TabIndex = 48;
            this.lbl_price.Text = "Room Price";
            // 
            // tb_price
            // 
            this.tb_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_price.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(1188, 331);
            this.tb_price.Multiline = true;
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(328, 41);
            this.tb_price.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 16);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(89, 43);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_account
            // 
            this.lbl_account.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_account.AutoSize = true;
            this.lbl_account.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.ForeColor = System.Drawing.Color.White;
            this.lbl_account.Location = new System.Drawing.Point(1250, 26);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(206, 38);
            this.lbl_account.TabIndex = 50;
            this.lbl_account.Text = "Your Account";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(1185, 87);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 27);
            this.tb_id.TabIndex = 51;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1564, 804);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.rb_search);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.pb_room);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_catagory);
            this.Controls.Add(this.rb_busy);
            this.Controls.Add(this.rb_free);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lbl_roomnumber);
            this.Controls.Add(this.tb_roomNumber);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView_rooms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Room_FormClosing);
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_roomnumber;
        private System.Windows.Forms.TextBox tb_roomNumber;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dataGridView_rooms;
        private System.Windows.Forms.RadioButton rb_free;
        private System.Windows.Forms.RadioButton rb_busy;
        private System.Windows.Forms.ComboBox cb_catagory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_room;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.RadioButton rb_search;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.TextBox tb_id;
    }
}