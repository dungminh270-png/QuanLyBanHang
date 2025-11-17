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
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThong,
            this.SanPham,
            this.TimKiem,
            this.Support,
            this.LichSu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1111, 28);
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
            this.HeThong.Name = "HeThong";
            this.HeThong.Size = new System.Drawing.Size(85, 24);
            this.HeThong.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Thông tin cá nhân";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.ThongTinCaNhan);
            // 
            // MnuDangNhap
            // 
            this.MnuDangNhap.Name = "MnuDangNhap";
            this.MnuDangNhap.Size = new System.Drawing.Size(224, 26);
            this.MnuDangNhap.Text = "Đăng nhập";
            this.MnuDangNhap.Click += new System.EventHandler(this.DangNhap);
            // 
            // MnuDangXuat
            // 
            this.MnuDangXuat.Name = "MnuDangXuat";
            this.MnuDangXuat.Size = new System.Drawing.Size(224, 26);
            this.MnuDangXuat.Text = "Đăng xuất";
            this.MnuDangXuat.Click += new System.EventHandler(this.DangXuat);
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // SanPham
            // 
            this.SanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khuyếnMãiToolStripMenuItem,
            this.hotToolStripMenuItem});
            this.SanPham.Name = "SanPham";
            this.SanPham.Size = new System.Drawing.Size(88, 24);
            this.SanPham.Text = "Sản Phẩm";
            // 
            // khuyếnMãiToolStripMenuItem
            // 
            this.khuyếnMãiToolStripMenuItem.Name = "khuyếnMãiToolStripMenuItem";
            this.khuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.khuyếnMãiToolStripMenuItem.Text = "Khuyến mãi";
            // 
            // hotToolStripMenuItem
            // 
            this.hotToolStripMenuItem.Name = "hotToolStripMenuItem";
            this.hotToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.hotToolStripMenuItem.Text = "Hot";
            // 
            // TimKiem
            // 
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(86, 24);
            this.TimKiem.Text = "Tìm Kiếm";
            // 
            // Support
            // 
            this.Support.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem,
            this.gToolStripMenuItem});
            this.Support.Name = "Support";
            this.Support.Size = new System.Drawing.Size(68, 24);
            this.Support.Text = "Lịch sử";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.hướngDẫnToolStripMenuItem.Text = "Mua hàng";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.gToolStripMenuItem.Text = "Giỏ hàng";
            // 
            // LichSu
            // 
            this.LichSu.Name = "LichSu";
            this.LichSu.Size = new System.Drawing.Size(98, 24);
            this.LichSu.Text = "Hướng dẫn";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblHoTen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1111, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 20);
            this.lblTime.Text = "00:00";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(118, 20);
            this.lblHoTen.Text = "Chưa đăng nhập";
            // 
            // FormMaiN_KH_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 685);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMaiN_KH_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaiN_KH_";
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
    }
}