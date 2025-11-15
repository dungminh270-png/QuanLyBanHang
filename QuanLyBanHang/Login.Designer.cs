namespace QuanLyBanHang
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.Userlb = new System.Windows.Forms.Label();
            this.Passlb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.radNhanvien = new System.Windows.Forms.RadioButton();
            this.radKhachHang = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 594);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.Avatar;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 591);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(879, 134);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(183, 22);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(879, 190);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(183, 22);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // Userlb
            // 
            this.Userlb.AutoSize = true;
            this.Userlb.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlb.Location = new System.Drawing.Point(763, 134);
            this.Userlb.Name = "Userlb";
            this.Userlb.Size = new System.Drawing.Size(103, 20);
            this.Userlb.TabIndex = 2;
            this.Userlb.Text = "UserName";
            this.Userlb.Click += new System.EventHandler(this.Userlb_Click);
            // 
            // Passlb
            // 
            this.Passlb.AutoSize = true;
            this.Passlb.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlb.Location = new System.Drawing.Point(763, 192);
            this.Passlb.Name = "Passlb";
            this.Passlb.Size = new System.Drawing.Size(97, 20);
            this.Passlb.TabIndex = 2;
            this.Passlb.Text = "Password";
            this.Passlb.Click += new System.EventHandler(this.Passlb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(799, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME";
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Location = new System.Drawing.Point(880, 218);
            this.checkPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(125, 20);
            this.checkPass.TabIndex = 3;
            this.checkPass.Text = "Show Password";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(749, 425);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 46);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Location = new System.Drawing.Point(935, 425);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(125, 46);
            this.btnSignin.TabIndex = 4;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(877, 240);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // radNhanvien
            // 
            this.radNhanvien.AutoSize = true;
            this.radNhanvien.Location = new System.Drawing.Point(767, 284);
            this.radNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNhanvien.Name = "radNhanvien";
            this.radNhanvien.Size = new System.Drawing.Size(90, 20);
            this.radNhanvien.TabIndex = 6;
            this.radNhanvien.TabStop = true;
            this.radNhanvien.Text = "Nhân Viên";
            this.radNhanvien.UseVisualStyleBackColor = true;
            // 
            // radKhachHang
            // 
            this.radKhachHang.AutoSize = true;
            this.radKhachHang.Location = new System.Drawing.Point(935, 284);
            this.radKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radKhachHang.Name = "radKhachHang";
            this.radKhachHang.Size = new System.Drawing.Size(101, 20);
            this.radKhachHang.TabIndex = 6;
            this.radKhachHang.TabStop = true;
            this.radKhachHang.Text = "Khách Hàng";
            this.radKhachHang.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1097, 588);
            this.Controls.Add(this.radKhachHang);
            this.Controls.Add(this.radNhanvien);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.Passlb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Userlb);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label Userlb;
        private System.Windows.Forms.Label Passlb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton radNhanvien;
        private System.Windows.Forms.RadioButton radKhachHang;
    }
}