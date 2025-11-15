namespace QuanLyBanHang
{
    partial class frmHuongDanSuDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHuongDanSuDung));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tctlMain = new System.Windows.Forms.TabControl();
            this.tpDonHang = new System.Windows.Forms.TabPage();
            this.tpSanPham = new System.Windows.Forms.TabPage();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.tpKhachHang = new System.Windows.Forms.TabPage();
            this.tpBanHang = new System.Windows.Forms.TabPage();
            this.tpBaoCao = new System.Windows.Forms.TabPage();
            this.tpHoaDon = new System.Windows.Forms.TabPage();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.sideBarPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tctlMain.SuspendLayout();
            this.tpDonHang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlTieuDe);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 753);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.sideBarPanel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel3);
            this.splitContainer2.Size = new System.Drawing.Size(1182, 626);
            this.splitContainer2.SplitterDistance = 249;
            this.splitContainer2.TabIndex = 0;
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.Controls.Add(this.label2);
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Name = "pnlTieuDe";
            this.pnlTieuDe.Size = new System.Drawing.Size(1182, 123);
            this.pnlTieuDe.TabIndex = 0;
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.Controls.Add(this.btnHoaDon);
            this.sideBarPanel.Controls.Add(this.btnBaoCao);
            this.sideBarPanel.Controls.Add(this.btnBanHang);
            this.sideBarPanel.Controls.Add(this.btnKhachHang);
            this.sideBarPanel.Controls.Add(this.btnSanPham);
            this.sideBarPanel.Controls.Add(this.btnDonHang);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBarPanel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(249, 626);
            this.sideBarPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tctlMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(929, 626);
            this.panel3.TabIndex = 0;
            // 
            // btnDonHang
            // 
            this.btnDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonHang.Location = new System.Drawing.Point(0, 0);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(249, 80);
            this.btnDonHang.TabIndex = 0;
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = true;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Location = new System.Drawing.Point(0, 80);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(249, 80);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 160);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(249, 80);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Location = new System.Drawing.Point(0, 240);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(249, 80);
            this.btnBanHang.TabIndex = 3;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 320);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(249, 80);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 81);
            this.label2.TabIndex = 1;
            this.label2.Text = "HƯỚNG DẪN SỬ DỤNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tctlMain
            // 
            this.tctlMain.Controls.Add(this.tpDonHang);
            this.tctlMain.Controls.Add(this.tpSanPham);
            this.tctlMain.Controls.Add(this.tpKhachHang);
            this.tctlMain.Controls.Add(this.tpBanHang);
            this.tctlMain.Controls.Add(this.tpBaoCao);
            this.tctlMain.Controls.Add(this.tpHoaDon);
            this.tctlMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tctlMain.Location = new System.Drawing.Point(3, 3);
            this.tctlMain.Name = "tctlMain";
            this.tctlMain.SelectedIndex = 0;
            this.tctlMain.Size = new System.Drawing.Size(926, 623);
            this.tctlMain.TabIndex = 0;
            // 
            // tpDonHang
            // 
            this.tpDonHang.BackColor = System.Drawing.Color.MistyRose;
            this.tpDonHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpDonHang.Controls.Add(this.textBox3);
            this.tpDonHang.Controls.Add(this.panel2);
            this.tpDonHang.Controls.Add(this.panel1);
            this.tpDonHang.Controls.Add(this.label3);
            this.tpDonHang.Controls.Add(this.label1);
            this.tpDonHang.Controls.Add(this.lbl1);
            this.tpDonHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDonHang.Location = new System.Drawing.Point(4, 37);
            this.tpDonHang.Name = "tpDonHang";
            this.tpDonHang.Padding = new System.Windows.Forms.Padding(3);
            this.tpDonHang.Size = new System.Drawing.Size(918, 582);
            this.tpDonHang.TabIndex = 0;
            this.tpDonHang.Text = "Đơn hàng";
            // 
            // tpSanPham
            // 
            this.tpSanPham.BackColor = System.Drawing.Color.FloralWhite;
            this.tpSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpSanPham.Location = new System.Drawing.Point(4, 37);
            this.tpSanPham.Name = "tpSanPham";
            this.tpSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tpSanPham.Size = new System.Drawing.Size(918, 582);
            this.tpSanPham.TabIndex = 1;
            this.tpSanPham.Text = "Sản phẩm";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 400);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(249, 80);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // tpKhachHang
            // 
            this.tpKhachHang.Location = new System.Drawing.Point(4, 37);
            this.tpKhachHang.Name = "tpKhachHang";
            this.tpKhachHang.Size = new System.Drawing.Size(918, 582);
            this.tpKhachHang.TabIndex = 2;
            this.tpKhachHang.Text = "Khách hàng";
            this.tpKhachHang.UseVisualStyleBackColor = true;
            // 
            // tpBanHang
            // 
            this.tpBanHang.Location = new System.Drawing.Point(4, 37);
            this.tpBanHang.Name = "tpBanHang";
            this.tpBanHang.Size = new System.Drawing.Size(918, 582);
            this.tpBanHang.TabIndex = 3;
            this.tpBanHang.Text = "Bán hàng";
            this.tpBanHang.UseVisualStyleBackColor = true;
            // 
            // tpBaoCao
            // 
            this.tpBaoCao.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tpBaoCao.Location = new System.Drawing.Point(4, 37);
            this.tpBaoCao.Name = "tpBaoCao";
            this.tpBaoCao.Size = new System.Drawing.Size(918, 582);
            this.tpBaoCao.TabIndex = 4;
            this.tpBaoCao.Text = "Báo cáo";
            // 
            // tpHoaDon
            // 
            this.tpHoaDon.Location = new System.Drawing.Point(4, 37);
            this.tpHoaDon.Name = "tpHoaDon";
            this.tpHoaDon.Size = new System.Drawing.Size(918, 582);
            this.tpHoaDon.TabIndex = 5;
            this.tpHoaDon.Text = "Hóa đơn";
            this.tpHoaDon.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(19, 11);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(106, 28);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Giới thiệu";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(24, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 77);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chức năng chính";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(24, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 100);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(862, 77);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Đây là nơi quản lý toàn bộ các yêu cầu đặt hàng của khách hàng, từ lúc phát sinh " +
    "đến khi hoàn tất hoặc hủy bỏ. Giúp theo dõi luồng xử lý hàng hóa và dịch vụ.";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(862, 103);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "- Tạo đơn hàng mới, bao gồm cả đơn hàng sỉ/lẻ.\r\n- Cập nhật trạng thái và thông ti" +
    "n đơn hàng. \r\n- Tìm kiếm và lọc đơn hàng theo nhiều tiêu chí.\r\n- Liên kết đơn hà" +
    "ng với giao dịch thanh toán và hóa đơn.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cách dùng";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(24, 359);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(862, 156);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmHuongDanSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "frmHuongDanSuDung";
            this.Text = "frmHuongDanSuDung";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.sideBarPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tctlMain.ResumeLayout(false);
            this.tpDonHang.ResumeLayout(false);
            this.tpDonHang.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tctlMain;
        private System.Windows.Forms.TabPage tpDonHang;
        private System.Windows.Forms.TabPage tpSanPham;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.TabPage tpKhachHang;
        private System.Windows.Forms.TabPage tpBanHang;
        private System.Windows.Forms.TabPage tpBaoCao;
        private System.Windows.Forms.TabPage tpHoaDon;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}