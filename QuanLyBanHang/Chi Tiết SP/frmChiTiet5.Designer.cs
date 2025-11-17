namespace QuanLyBanHang.Chi_Tiết_SP
{
    partial class frmChiTiet5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhanMua5 = new System.Windows.Forms.Button();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.bút_đẹp;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(868, 230);
            this.label2.TabIndex = 20;
            this.label2.Text = "- Giá: 20.000VND\r\n- Bút viết phổ thông giá hời\r\n- Mực gel cực đậm, khô nhanh, khô" +
    "ng lem tay\r\n- Đầu bi 0.38mm cho nét chữ chi tiết cực đẹp\r\n- Phù hợp viết notes, " +
    "bullet journal, vẽ sketch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 138);
            this.label1.TabIndex = 21;
            this.label1.Text = "- Vận Chuyển: trong ngày\r\n- Khu vực: TP Hồ Chí Minh\r\n\r\n";
            // 
            // btnXacNhanMua5
            // 
            this.btnXacNhanMua5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanMua5.Location = new System.Drawing.Point(486, 390);
            this.btnXacNhanMua5.Name = "btnXacNhanMua5";
            this.btnXacNhanMua5.Size = new System.Drawing.Size(152, 62);
            this.btnXacNhanMua5.TabIndex = 22;
            this.btnXacNhanMua5.Text = "Xác Nhận Mua";
            this.btnXacNhanMua5.UseVisualStyleBackColor = true;
            this.btnXacNhanMua5.Click += new System.EventHandler(this.btnXacNhanMua5_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.Location = new System.Drawing.Point(774, 390);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(151, 35);
            this.numericUpDown5.TabIndex = 23;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // frmChiTiet5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1755, 719);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.btnXacNhanMua5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmChiTiet5";
            this.Text = "frmChiTiet5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacNhanMua5;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
    }
}