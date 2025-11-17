namespace QuanLyBanHang.Chi_Tiết_SP
{
    partial class frmChiTiet6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTiet6));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhanMua6 = new System.Windows.Forms.Button();
            this.SoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.bút_viết_mực;
            this.pictureBox1.Location = new System.Drawing.Point(11, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1060, 195);
            this.label2.TabIndex = 20;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 117);
            this.label1.TabIndex = 21;
            this.label1.Text = "- Vận Chuyển: trong ngày\r\n- Khu vực: TP Hồ Chí Minh\r\n\r\n";
            // 
            // btnXacNhanMua6
            // 
            this.btnXacNhanMua6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanMua6.Location = new System.Drawing.Point(432, 312);
            this.btnXacNhanMua6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhanMua6.Name = "btnXacNhanMua6";
            this.btnXacNhanMua6.Size = new System.Drawing.Size(135, 50);
            this.btnXacNhanMua6.TabIndex = 22;
            this.btnXacNhanMua6.Text = "Xác Nhận Mua";
            this.btnXacNhanMua6.UseVisualStyleBackColor = true;
            this.btnXacNhanMua6.Click += new System.EventHandler(this.btnXacNhanMua6_Click);
            // 
            // SoLuong
            // 
            this.SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.Location = new System.Drawing.Point(713, 312);
            this.SoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(134, 30);
            this.SoLuong.TabIndex = 23;
            this.SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmChiTiet6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 573);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.btnXacNhanMua6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChiTiet6";
            this.Text = "frmChiTiet6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhanMua6;
        private System.Windows.Forms.NumericUpDown SoLuong;
    }
}