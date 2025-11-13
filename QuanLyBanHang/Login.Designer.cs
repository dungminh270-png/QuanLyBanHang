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
            this.btnSignup = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 742);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.Avatar;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 739);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(989, 168);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(204, 26);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(989, 238);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(204, 26);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // Userlb
            // 
            this.Userlb.AutoSize = true;
            this.Userlb.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlb.Location = new System.Drawing.Point(858, 168);
            this.Userlb.Name = "Userlb";
<<<<<<< HEAD
            this.Userlb.Size = new System.Drawing.Size(128, 25);
=======
            this.Userlb.Size = new System.Drawing.Size(102, 20);
>>>>>>> 0c7ebc1614cb12ab722fa9d50996ff8c7ba21a22
            this.Userlb.TabIndex = 2;
            this.Userlb.Text = "UserName";
            this.Userlb.Click += new System.EventHandler(this.Userlb_Click);
            // 
            // Passlb
            // 
            this.Passlb.AutoSize = true;
            this.Passlb.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlb.Location = new System.Drawing.Point(858, 240);
            this.Passlb.Name = "Passlb";
            this.Passlb.Size = new System.Drawing.Size(118, 25);
            this.Passlb.TabIndex = 2;
            this.Passlb.Text = "Password";
            this.Passlb.Click += new System.EventHandler(this.Passlb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(899, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME";
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Location = new System.Drawing.Point(990, 272);
            this.checkPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(148, 24);
            this.checkPass.TabIndex = 3;
            this.checkPass.Text = "Show Password";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(863, 414);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(136, 56);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(1052, 414);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(142, 56);
            this.btnSignup.TabIndex = 4;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
<<<<<<< HEAD
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(986, 301);
=======
            this.linkLabel1.Location = new System.Drawing.Point(876, 241);
>>>>>>> 0c7ebc1614cb12ab722fa9d50996ff8c7ba21a22
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1234, 735);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.Passlb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Userlb);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Login";
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
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

