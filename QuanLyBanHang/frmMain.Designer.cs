using System;

namespace QuanLyBanHang
{
    partial class frmMain
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
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCHHT = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thànhPhốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDongHo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHoTenNhanVien = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.quảnLíToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1157, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCHHT,
            this.MnuDangNhap,
            this.MnuDangXuat,
            this.MnuThoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(117, 32);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // MnuCHHT
            // 
            this.MnuCHHT.Name = "MnuCHHT";
            this.MnuCHHT.Size = new System.Drawing.Size(269, 32);
            this.MnuCHHT.Text = "Cấu hình hệ thống";
            // 
            // MnuDangNhap
            // 
            this.MnuDangNhap.Name = "MnuDangNhap";
            this.MnuDangNhap.Size = new System.Drawing.Size(269, 32);
            this.MnuDangNhap.Text = "Đăng nhập";
            this.MnuDangNhap.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // MnuDangXuat
            // 
            this.MnuDangXuat.Name = "MnuDangXuat";
            this.MnuDangXuat.Size = new System.Drawing.Size(269, 32);
            this.MnuDangXuat.Text = "Đăng xuất";
            this.MnuDangXuat.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // MnuThoat
            // 
            this.MnuThoat.Name = "MnuThoat";
            this.MnuThoat.Size = new System.Drawing.Size(269, 32);
            this.MnuThoat.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thànhPhốToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem});
            this.danhMụcToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(119, 32);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // thànhPhốToolStripMenuItem
            // 
            this.thànhPhốToolStripMenuItem.Name = "thànhPhốToolStripMenuItem";
            this.thànhPhốToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.thànhPhốToolStripMenuItem.Text = "Thành phố";
            this.thànhPhốToolStripMenuItem.Click += new System.EventHandler(this.thànhPhốToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem1,
            this.muaHàngToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.hóaĐơnToolStripMenuItem.Text = "Lịch sử";
            // 
            // hóaĐơnToolStripMenuItem1
            // 
            this.hóaĐơnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtHóaĐơnToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem1.Name = "hóaĐơnToolStripMenuItem1";
            this.hóaĐơnToolStripMenuItem1.Size = new System.Drawing.Size(177, 32);
            this.hóaĐơnToolStripMenuItem1.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem1.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem1_Click);
            // 
            // chiTiếtHóaĐơnToolStripMenuItem
            // 
            this.chiTiếtHóaĐơnToolStripMenuItem.Name = "chiTiếtHóaĐơnToolStripMenuItem";
            this.chiTiếtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            // 
            // muaHàngToolStripMenuItem
            // 
            this.muaHàngToolStripMenuItem.Name = "muaHàngToolStripMenuItem";
            this.muaHàngToolStripMenuItem.Size = new System.Drawing.Size(177, 32);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem1,
            this.sảnPhẩmToolStripMenuItem1,
            this.đơnHàngToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem2});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(111, 32);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // kháchHàngToolStripMenuItem1
            // 
            this.kháchHàngToolStripMenuItem1.Name = "kháchHàngToolStripMenuItem1";
            this.kháchHàngToolStripMenuItem1.Size = new System.Drawing.Size(205, 32);
            this.kháchHàngToolStripMenuItem1.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem1.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem1_Click);
            // 
            // sảnPhẩmToolStripMenuItem1
            // 
            this.sảnPhẩmToolStripMenuItem1.Name = "sảnPhẩmToolStripMenuItem1";
            this.sảnPhẩmToolStripMenuItem1.Size = new System.Drawing.Size(205, 32);
            this.sảnPhẩmToolStripMenuItem1.Text = "Sản phẩm";
            // 
            // đơnHàngToolStripMenuItem
            // 
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.đơnHàngToolStripMenuItem.Text = "Đơn hàng";
            // 
            // hóaĐơnToolStripMenuItem2
            // 
            this.hóaĐơnToolStripMenuItem2.Name = "hóaĐơnToolStripMenuItem2";
            this.hóaĐơnToolStripMenuItem2.Size = new System.Drawing.Size(205, 32);
            this.hóaĐơnToolStripMenuItem2.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem2.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem2_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem,
            this.giớiThiệuChươngTrìnhToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(101, 32);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(311, 32);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // giớiThiệuChươngTrìnhToolStripMenuItem
            // 
            this.giớiThiệuChươngTrìnhToolStripMenuItem.Name = "giớiThiệuChươngTrìnhToolStripMenuItem";
            this.giớiThiệuChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(311, 32);
            this.giớiThiệuChươngTrìnhToolStripMenuItem.Text = "Giới thiệu chương trình";
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem2});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            this.quảnLíToolStripMenuItem.Click += new System.EventHandler(this.quảnLíToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem2
            // 
            this.kháchHàngToolStripMenuItem2.Name = "kháchHàngToolStripMenuItem2";
            this.kháchHàngToolStripMenuItem2.Size = new System.Drawing.Size(205, 32);
            this.kháchHàngToolStripMenuItem2.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem2.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDongHo,
            this.lblHoTenNhanVien});
            this.statusStrip1.Location = new System.Drawing.Point(0, 740);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1157, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDongHo
            // 
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(151, 20);
            this.lblDongHo.Text = "toolStripStatusLabel1";
            this.lblDongHo.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lblHoTenNhanVien
            // 
            this.lblHoTenNhanVien.Name = "lblHoTenNhanVien";
            this.lblHoTenNhanVien.Size = new System.Drawing.Size(123, 20);
            this.lblHoTenNhanVien.Text = "Chưa Đăng Nhập";
            this.lblHoTenNhanVien.Click += new System.EventHandler(this.lblHoTenNhanVien_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 766);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuCHHT;
        private System.Windows.Forms.ToolStripMenuItem MnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem MnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem MnuThoat;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thànhPhốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHoTenNhanVien;
        private System.Windows.Forms.ToolStripStatusLabel lblDongHo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muaHàngToolStripMenuItem;
    }
}