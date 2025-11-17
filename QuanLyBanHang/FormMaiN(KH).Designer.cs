namespace QuanLyBanHang
{
    partial class FormMaiN_KH_
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.khuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Support = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LichSu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
<<<<<<< HEAD
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
=======
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
>>>>>>> 1ebf172715254f0a89018c149e4894dbf9980d27
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThong,
            this.SanPham,
            this.TimKiem,
            this.Support,
            this.LichSu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
<<<<<<< HEAD
            this.menuStrip1.Size = new System.Drawing.Size(1111, 30);
=======
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1250, 33);
>>>>>>> 1ebf172715254f0a89018c149e4894dbf9980d27
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HeThong
            // 
            this.HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.MnuDangNhap,
            this.MnuDangXuat,
            this.thoátToolStripMenuItem1});
            this.HeThong.Image = global::QuanLyBanHang.Properties.Resources.menu_burger;
            this.HeThong.Name = "HeThong";
<<<<<<< HEAD
            this.HeThong.Size = new System.Drawing.Size(105, 26);
=======
            this.HeThong.Size = new System.Drawing.Size(103, 29);
>>>>>>> 1ebf172715254f0a89018c149e4894dbf9980d27
            this.HeThong.Text = "Hệ thống";
            this.HeThong.Click += new System.EventHandler(this.HeThong_Click);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.thông_tin_cá_nhân;
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.đăngNhậpToolStripMenuItem.Text = "Thông tin cá nhân";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.ThongTinCaNhan);
            // 
            // MnuDangNhap
            // 
            this.MnuDangNhap.Name = "MnuDangNhap";
            this.MnuDangNhap.Size = new System.Drawing.Size(256, 34);
            this.MnuDangNhap.Text = "Đăng nhập";
            this.MnuDangNhap.Click += new System.EventHandler(this.DangNhap);
            // 
            // MnuDangXuat
            // 
            this.MnuDangXuat.Name = "MnuDangXuat";
            this.MnuDangXuat.Size = new System.Drawing.Size(256, 34);
            this.MnuDangXuat.Text = "Đăng xuất";
            this.MnuDangXuat.Click += new System.EventHandler(this.DangXuat);
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(256, 34);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // SanPham
            // 
            this.SanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khuyếnMãiToolStripMenuItem,
            this.hotToolStripMenuItem});
            this.SanPham.Name = "SanPham";
<<<<<<< HEAD
            this.SanPham.Size = new System.Drawing.Size(88, 26);
=======
            this.SanPham.Size = new System.Drawing.Size(107, 29);
>>>>>>> 1ebf172715254f0a89018c149e4894dbf9980d27
            this.SanPham.Text = "Sản Phẩm";
            // 
            // khuyếnMãiToolStripMenuItem
            // 
            this.khuyếnMãiToolStripMenuItem.Name = "khuyếnMãiToolStripMenuItem";
            this.khuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.khuyếnMãiToolStripMenuItem.Text = "Khuyến mãi";
            // 
            // hotToolStripMenuItem
            // 
            this.hotToolStripMenuItem.Name = "hotToolStripMenuItem";
            this.hotToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.hotToolStripMenuItem.Text = "Hot";
            // 
            // TimKiem
            // 
            this.TimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmToolStripMenuItem});
            this.TimKiem.Name = "TimKiem";
<<<<<<< HEAD
            this.TimKiem.Size = new System.Drawing.Size(86, 26);
=======
            this.TimKiem.Size = new System.Drawing.Size(101, 29);
>>>>>>> 1ebf172715254f0a89018c149e4894dbf9980d27
            this.TimKiem.Text = "Tìm Kiếm";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(194, 34);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // Support
            // 
            this.Support.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem,
            this.gToolStripMenuItem});
            this.Support.Name = "Support";
<<<<<<< HEAD
            this.Support.Size = new System.Drawing.Size(68, 26);
=======
            this.Support.Size = new System.Drawing.Size(82, 29);
>>>>>>> 1ebf172715254f0a89018c149e4894dbf9980d27
            this.Support.Text = "Lịch sử";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.hướngDẫnToolStripMenuItem.Text = "Mua hàng";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gToolStripMenuItem.Text = "Giỏ hàng";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // LichSu
            // 
            this.LichSu.Name = "LichSu";
<<<<<<< HEAD
            this.LichSu.Size = new System.Drawing.Size(98, 26);
=======
            this.LichSu.Size = new System.Drawing.Size(119, 29);
>>>>>>> 1ebf172715254f0a89018c149e4894dbf9980d27
            this.LichSu.Text = "Hướng dẫn";
            this.LichSu.Click += new System.EventHandler(this.LichSu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblHoTen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 824);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1250, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 25);
            this.lblTime.Text = "00:00";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(144, 25);
            this.lblHoTen.Text = "Chưa đăng nhập";
            this.lblHoTen.Click += new System.EventHandler(this.lblHoTen_Click);
            // 
            // FormMaiN_KH_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 856);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMaiN_KH_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaiN_KH_";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMaiN_KH__Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HeThong;
        private System.Windows.Forms.ToolStripMenuItem SanPham;
        private System.Windows.Forms.ToolStripMenuItem TimKiem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem MnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem Support;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LichSu;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuyếnMãiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripStatusLabel lblHoTen;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
    }
}