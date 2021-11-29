namespace HotelManagementSystem
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel_register = new System.Windows.Forms.Panel();
            this.cb_personal = new System.Windows.Forms.CheckBox();
            this.tb_confirmPass = new System.Windows.Forms.TextBox();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.cb_showPass = new System.Windows.Forms.CheckBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pb_angel = new System.Windows.Forms.PictureBox();
            this.panel_register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_angel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_register
            // 
            this.panel_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel_register.Controls.Add(this.cb_personal);
            this.panel_register.Controls.Add(this.tb_confirmPass);
            this.panel_register.Controls.Add(this.lbl_confirm);
            this.panel_register.Controls.Add(this.tb_password);
            this.panel_register.Controls.Add(this.lbl_password);
            this.panel_register.Controls.Add(this.cb_showPass);
            this.panel_register.Controls.Add(this.tb_email);
            this.panel_register.Controls.Add(this.btn_register);
            this.panel_register.Controls.Add(this.lbl_username);
            this.panel_register.Controls.Add(this.tb_username);
            this.panel_register.Controls.Add(this.lbl_email);
            this.panel_register.Location = new System.Drawing.Point(381, 36);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(487, 568);
            this.panel_register.TabIndex = 11;
            // 
            // cb_personal
            // 
            this.cb_personal.AutoSize = true;
            this.cb_personal.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_personal.ForeColor = System.Drawing.Color.White;
            this.cb_personal.Location = new System.Drawing.Point(258, 408);
            this.cb_personal.Name = "cb_personal";
            this.cb_personal.Size = new System.Drawing.Size(86, 20);
            this.cb_personal.TabIndex = 6;
            this.cb_personal.Text = "Personal";
            this.cb_personal.UseVisualStyleBackColor = true;
            // 
            // tb_confirmPass
            // 
            this.tb_confirmPass.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirmPass.Location = new System.Drawing.Point(47, 344);
            this.tb_confirmPass.Multiline = true;
            this.tb_confirmPass.Name = "tb_confirmPass";
            this.tb_confirmPass.Size = new System.Drawing.Size(388, 41);
            this.tb_confirmPass.TabIndex = 4;
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm.ForeColor = System.Drawing.Color.White;
            this.lbl_confirm.Location = new System.Drawing.Point(45, 318);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(172, 23);
            this.lbl_confirm.TabIndex = 0;
            this.lbl_confirm.Text = "Confirm Password";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(49, 257);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(388, 41);
            this.tb_password.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(46, 231);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(98, 23);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Password";
            // 
            // cb_showPass
            // 
            this.cb_showPass.AutoSize = true;
            this.cb_showPass.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showPass.ForeColor = System.Drawing.Color.White;
            this.cb_showPass.Location = new System.Drawing.Point(51, 407);
            this.cb_showPass.Name = "cb_showPass";
            this.cb_showPass.Size = new System.Drawing.Size(129, 20);
            this.cb_showPass.TabIndex = 5;
            this.cb_showPass.Text = "Show Password";
            this.cb_showPass.UseVisualStyleBackColor = true;
            this.cb_showPass.CheckedChanged += new System.EventHandler(this.cb_showPass_CheckedChanged);
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(47, 89);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(388, 41);
            this.tb_email.TabIndex = 1;
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(161, 473);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(169, 52);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(45, 147);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(99, 23);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(48, 175);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(388, 41);
            this.tb_username.TabIndex = 2;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(44, 63);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(58, 23);
            this.lbl_email.TabIndex = 0;
            this.lbl_email.Text = "Email";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(44)))), ((int)(((byte)(117)))));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(23, 598);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(87, 44);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logo.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.ForeColor = System.Drawing.Color.White;
            this.lbl_logo.Location = new System.Drawing.Point(10, 100);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(109, 32);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "HoTeL";
            // 
            // pb_angel
            // 
            this.pb_angel.Image = global::HotelManagementSystem.Properties.Resources.angel_wings_cartoon_illustration_52777171_removebg_preview;
            this.pb_angel.Location = new System.Drawing.Point(12, 12);
            this.pb_angel.Name = "pb_angel";
            this.pb_angel.Size = new System.Drawing.Size(107, 107);
            this.pb_angel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_angel.TabIndex = 13;
            this.pb_angel.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(14)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1132, 654);
            this.Controls.Add(this.lbl_logo);
            this.Controls.Add(this.pb_angel);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel_register);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel_register.ResumeLayout(false);
            this.panel_register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_angel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.TextBox tb_confirmPass;
        private System.Windows.Forms.Label lbl_confirm;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.CheckBox cb_showPass;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.CheckBox cb_personal;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.PictureBox pb_angel;
    }
}