namespace SupermarketManagement.GUI
{
    partial class SanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCapnhatsanpham = new FontAwesome.Sharp.IconButton();
            this.dataGridViewSanpham = new System.Windows.Forms.DataGridView();
            this.txtTimkiemsanpham = new System.Windows.Forms.TextBox();
            this.btnTimkiemsanpham = new FontAwesome.Sharp.IconButton();
            this.btnInsanpham = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 71);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SupermarketManagement.Properties.Resources.box;
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sản phẩm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCapnhatsanpham);
            this.panel2.Location = new System.Drawing.Point(716, 583);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 56);
            this.panel2.TabIndex = 4;
            // 
            // btnCapnhatsanpham
            // 
            this.btnCapnhatsanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnCapnhatsanpham.FlatAppearance.BorderSize = 0;
            this.btnCapnhatsanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapnhatsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhatsanpham.ForeColor = System.Drawing.Color.White;
            this.btnCapnhatsanpham.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnCapnhatsanpham.IconColor = System.Drawing.Color.White;
            this.btnCapnhatsanpham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapnhatsanpham.IconSize = 30;
            this.btnCapnhatsanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapnhatsanpham.Location = new System.Drawing.Point(0, 0);
            this.btnCapnhatsanpham.Name = "btnCapnhatsanpham";
            this.btnCapnhatsanpham.Size = new System.Drawing.Size(169, 53);
            this.btnCapnhatsanpham.TabIndex = 3;
            this.btnCapnhatsanpham.Text = "Cập nhật";
            this.btnCapnhatsanpham.UseVisualStyleBackColor = false;
            this.btnCapnhatsanpham.Click += new System.EventHandler(this.btnCapnhatsanpham_Click);
            // 
            // dataGridViewSanpham
            // 
            this.dataGridViewSanpham.AllowDrop = true;
            this.dataGridViewSanpham.AllowUserToOrderColumns = true;
            this.dataGridViewSanpham.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSanpham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSanpham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanpham.Location = new System.Drawing.Point(1, 70);
            this.dataGridViewSanpham.Name = "dataGridViewSanpham";
            this.dataGridViewSanpham.RowHeadersWidth = 51;
            this.dataGridViewSanpham.RowTemplate.Height = 24;
            this.dataGridViewSanpham.Size = new System.Drawing.Size(1151, 460);
            this.dataGridViewSanpham.TabIndex = 5;
            this.dataGridViewSanpham.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSanpham_CellMouseClick);
            // 
            // txtTimkiemsanpham
            // 
            this.txtTimkiemsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtTimkiemsanpham.Location = new System.Drawing.Point(434, 586);
            this.txtTimkiemsanpham.Multiline = true;
            this.txtTimkiemsanpham.Name = "txtTimkiemsanpham";
            this.txtTimkiemsanpham.Size = new System.Drawing.Size(248, 46);
            this.txtTimkiemsanpham.TabIndex = 8;
            // 
            // btnTimkiemsanpham
            // 
            this.btnTimkiemsanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnTimkiemsanpham.FlatAppearance.BorderSize = 0;
            this.btnTimkiemsanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiemsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemsanpham.ForeColor = System.Drawing.Color.White;
            this.btnTimkiemsanpham.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnTimkiemsanpham.IconColor = System.Drawing.Color.White;
            this.btnTimkiemsanpham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimkiemsanpham.IconSize = 30;
            this.btnTimkiemsanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiemsanpham.Location = new System.Drawing.Point(235, 583);
            this.btnTimkiemsanpham.Name = "btnTimkiemsanpham";
            this.btnTimkiemsanpham.Size = new System.Drawing.Size(169, 53);
            this.btnTimkiemsanpham.TabIndex = 9;
            this.btnTimkiemsanpham.Text = "Tìm kiếm";
            this.btnTimkiemsanpham.UseVisualStyleBackColor = false;
            this.btnTimkiemsanpham.Click += new System.EventHandler(this.btnTimkiemsanpham_Click);
            // 
            // btnInsanpham
            // 
            this.btnInsanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnInsanpham.FlatAppearance.BorderSize = 0;
            this.btnInsanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsanpham.ForeColor = System.Drawing.Color.White;
            this.btnInsanpham.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnInsanpham.IconColor = System.Drawing.Color.White;
            this.btnInsanpham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsanpham.IconSize = 30;
            this.btnInsanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsanpham.Location = new System.Drawing.Point(22, 583);
            this.btnInsanpham.Name = "btnInsanpham";
            this.btnInsanpham.Size = new System.Drawing.Size(169, 53);
            this.btnInsanpham.TabIndex = 10;
            this.btnInsanpham.Text = "In";
            this.btnInsanpham.UseVisualStyleBackColor = false;
            this.btnInsanpham.Click += new System.EventHandler(this.btnInsanpham_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 651);
            this.Controls.Add(this.btnInsanpham);
            this.Controls.Add(this.btnTimkiemsanpham);
            this.Controls.Add(this.txtTimkiemsanpham);
            this.Controls.Add(this.dataGridViewSanpham);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCapnhatsanpham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewSanpham;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimkiemsanpham;
        private FontAwesome.Sharp.IconButton btnTimkiemsanpham;
        private FontAwesome.Sharp.IconButton btnInsanpham;
    }
}