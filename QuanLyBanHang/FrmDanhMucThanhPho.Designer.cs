namespace QuanLyBanHang
{
    partial class FrmDanhMucThanhPho
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
            this.dgvThanhPho = new System.Windows.Forms.DataGridView();
            this.MaThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThanhPho
            // 
            this.dgvThanhPho.AllowUserToAddRows = false;
            this.dgvThanhPho.AllowUserToDeleteRows = false;
            this.dgvThanhPho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhPho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThanhPho,
            this.TenThanhPho});
            this.dgvThanhPho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThanhPho.Location = new System.Drawing.Point(0, 0);
            this.dgvThanhPho.Name = "dgvThanhPho";
            this.dgvThanhPho.ReadOnly = true;
            this.dgvThanhPho.RowHeadersWidth = 51;
            this.dgvThanhPho.RowTemplate.Height = 24;
            this.dgvThanhPho.Size = new System.Drawing.Size(800, 450);
            this.dgvThanhPho.TabIndex = 0;
            // 
            // MaThanhPho
            // 
            this.MaThanhPho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaThanhPho.DataPropertyName = "MaThanhPho";
            this.MaThanhPho.HeaderText = "MÃ THÀNH PHỐ";
            this.MaThanhPho.MinimumWidth = 6;
            this.MaThanhPho.Name = "MaThanhPho";
            this.MaThanhPho.ReadOnly = true;
            // 
            // TenThanhPho
            // 
            this.TenThanhPho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenThanhPho.DataPropertyName = "TenThanhPho";
            this.TenThanhPho.HeaderText = "TÊN THÀNH PHỐ";
            this.TenThanhPho.MinimumWidth = 6;
            this.TenThanhPho.Name = "TenThanhPho";
            this.TenThanhPho.ReadOnly = true;
            this.TenThanhPho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmDanhMucThanhPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvThanhPho);
            this.Name = "FrmDanhMucThanhPho";
            this.Text = "FrmDanhMucThanhPho";
            this.Load += new System.EventHandler(this.FrmDanhMucThanhPho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThanhPho;
    }
}