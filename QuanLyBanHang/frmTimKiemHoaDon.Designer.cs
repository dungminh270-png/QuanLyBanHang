namespace QuanLyBanHang
{
    partial class frmTimKiemHoaDon
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
            this.timKiemmHoaDonUserControl1 = new QuanLyBanHang.TimKiemmHoaDonUserControl();
            this.SuspendLayout();
            // 
            // timKiemmHoaDonUserControl1
            // 
            this.timKiemmHoaDonUserControl1.BackColor = System.Drawing.Color.Pink;
            this.timKiemmHoaDonUserControl1.Location = new System.Drawing.Point(0, -4);
            this.timKiemmHoaDonUserControl1.Name = "timKiemmHoaDonUserControl1";
            this.timKiemmHoaDonUserControl1.Size = new System.Drawing.Size(1106, 732);
            this.timKiemmHoaDonUserControl1.TabIndex = 0;
            // 
            // frmTimKiemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 750);
            this.Controls.Add(this.timKiemmHoaDonUserControl1);
            this.Name = "frmTimKiemHoaDon";
            this.Text = "frmTimKiemHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimKiemHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private QuanLyBanHang.TimKiemmHoaDonUserControl timKiemmHoaDonUserControl1;

    }
}