namespace SupermarketManagement.GUI
{
    partial class Nhanvien
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
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimkiemnhacungcap = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTennhavnien = new System.Windows.Forms.TextBox();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.dataGridViewNhanvien = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.cbxVitri = new System.Windows.Forms.ComboBox();
            this.btnTimkiemnhanvien = new FontAwesome.Sharp.IconButton();
            this.btnInnhanvien = new FontAwesome.Sharp.IconButton();
            this.btnXoanhanvien = new FontAwesome.Sharp.IconButton();
            this.btnSuanhanvien = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnThemnhanvien = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanvien)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SupermarketManagement.Properties.Resources.employees;
            this.pictureBox1.Location = new System.Drawing.Point(22, 10);
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
            this.label1.Text = "Quản lý nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.Location = new System.Drawing.Point(16, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(19, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Vị trí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(16, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtTimkiemnhacungcap
            // 
            this.txtTimkiemnhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimkiemnhacungcap.Location = new System.Drawing.Point(864, 493);
            this.txtTimkiemnhacungcap.Multiline = true;
            this.txtTimkiemnhacungcap.Name = "txtTimkiemnhacungcap";
            this.txtTimkiemnhacungcap.Size = new System.Drawing.Size(257, 38);
            this.txtTimkiemnhacungcap.TabIndex = 20;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSodienthoai.Location = new System.Drawing.Point(151, 294);
            this.txtSodienthoai.Multiline = true;
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(202, 38);
            this.txtSodienthoai.TabIndex = 21;
            this.txtSodienthoai.TextChanged += new System.EventHandler(this.txtSodienthoai_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(16, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mã nhân viên";
            // 
            // txtTennhavnien
            // 
            this.txtTennhavnien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTennhavnien.Location = new System.Drawing.Point(151, 167);
            this.txtTennhavnien.Multiline = true;
            this.txtTennhavnien.Name = "txtTennhavnien";
            this.txtTennhavnien.Size = new System.Drawing.Size(202, 38);
            this.txtTennhavnien.TabIndex = 23;
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Enabled = false;
            this.txtManhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManhanvien.Location = new System.Drawing.Point(151, 95);
            this.txtManhanvien.Multiline = true;
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(202, 38);
            this.txtManhanvien.TabIndex = 24;
            // 
            // dataGridViewNhanvien
            // 
            this.dataGridViewNhanvien.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNhanvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanvien.Location = new System.Drawing.Point(366, 95);
            this.dataGridViewNhanvien.Name = "dataGridViewNhanvien";
            this.dataGridViewNhanvien.RowHeadersWidth = 51;
            this.dataGridViewNhanvien.RowTemplate.Height = 24;
            this.dataGridViewNhanvien.Size = new System.Drawing.Size(755, 383);
            this.dataGridViewNhanvien.TabIndex = 19;
            this.dataGridViewNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanvien_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(19, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiachi.Location = new System.Drawing.Point(151, 361);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(202, 38);
            this.txtDiachi.TabIndex = 35;
            // 
            // cbxVitri
            // 
            this.cbxVitri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxVitri.FormattingEnabled = true;
            this.cbxVitri.Items.AddRange(new object[] {
            "Bán hàng"});
            this.cbxVitri.Location = new System.Drawing.Point(151, 232);
            this.cbxVitri.Name = "cbxVitri";
            this.cbxVitri.Size = new System.Drawing.Size(202, 33);
            this.cbxVitri.TabIndex = 37;
            // 
            // btnTimkiemnhanvien
            // 
            this.btnTimkiemnhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnTimkiemnhanvien.FlatAppearance.BorderSize = 0;
            this.btnTimkiemnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiemnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemnhanvien.ForeColor = System.Drawing.Color.White;
            this.btnTimkiemnhanvien.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnTimkiemnhanvien.IconColor = System.Drawing.Color.White;
            this.btnTimkiemnhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimkiemnhanvien.IconSize = 30;
            this.btnTimkiemnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiemnhanvien.Location = new System.Drawing.Point(665, 493);
            this.btnTimkiemnhanvien.Name = "btnTimkiemnhanvien";
            this.btnTimkiemnhanvien.Size = new System.Drawing.Size(158, 40);
            this.btnTimkiemnhanvien.TabIndex = 34;
            this.btnTimkiemnhanvien.Text = "Tìm kiếm";
            this.btnTimkiemnhanvien.UseVisualStyleBackColor = false;
            this.btnTimkiemnhanvien.Click += new System.EventHandler(this.btnTimkiemnhanvien_Click);
            // 
            // btnInnhanvien
            // 
            this.btnInnhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnInnhanvien.FlatAppearance.BorderSize = 0;
            this.btnInnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInnhanvien.ForeColor = System.Drawing.Color.White;
            this.btnInnhanvien.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnInnhanvien.IconColor = System.Drawing.Color.White;
            this.btnInnhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInnhanvien.IconSize = 30;
            this.btnInnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInnhanvien.Location = new System.Drawing.Point(968, 572);
            this.btnInnhanvien.Name = "btnInnhanvien";
            this.btnInnhanvien.Size = new System.Drawing.Size(153, 53);
            this.btnInnhanvien.TabIndex = 33;
            this.btnInnhanvien.Text = "In";
            this.btnInnhanvien.UseVisualStyleBackColor = false;
            this.btnInnhanvien.Click += new System.EventHandler(this.btnInnhanvien_Click);
            // 
            // btnXoanhanvien
            // 
            this.btnXoanhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnXoanhanvien.FlatAppearance.BorderSize = 0;
            this.btnXoanhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoanhanvien.ForeColor = System.Drawing.Color.White;
            this.btnXoanhanvien.IconChar = FontAwesome.Sharp.IconChar.CableCar;
            this.btnXoanhanvien.IconColor = System.Drawing.Color.White;
            this.btnXoanhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoanhanvien.IconSize = 30;
            this.btnXoanhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoanhanvien.Location = new System.Drawing.Point(725, 572);
            this.btnXoanhanvien.Name = "btnXoanhanvien";
            this.btnXoanhanvien.Size = new System.Drawing.Size(143, 53);
            this.btnXoanhanvien.TabIndex = 32;
            this.btnXoanhanvien.Text = "Xóa";
            this.btnXoanhanvien.UseVisualStyleBackColor = false;
            this.btnXoanhanvien.Click += new System.EventHandler(this.btnXoanhanvien_Click);
            // 
            // btnSuanhanvien
            // 
            this.btnSuanhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnSuanhanvien.FlatAppearance.BorderSize = 0;
            this.btnSuanhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuanhanvien.ForeColor = System.Drawing.Color.White;
            this.btnSuanhanvien.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnSuanhanvien.IconColor = System.Drawing.Color.White;
            this.btnSuanhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuanhanvien.IconSize = 30;
            this.btnSuanhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuanhanvien.Location = new System.Drawing.Point(491, 572);
            this.btnSuanhanvien.Name = "btnSuanhanvien";
            this.btnSuanhanvien.Size = new System.Drawing.Size(129, 53);
            this.btnSuanhanvien.TabIndex = 31;
            this.btnSuanhanvien.Text = "Sửa";
            this.btnSuanhanvien.UseVisualStyleBackColor = false;
            this.btnSuanhanvien.Click += new System.EventHandler(this.btnSuanhanvien_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnClear.IconColor = System.Drawing.Color.White;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 30;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(16, 572);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 53);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Nhập lại";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnThemnhanvien
            // 
            this.btnThemnhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnThemnhanvien.FlatAppearance.BorderSize = 0;
            this.btnThemnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnhanvien.ForeColor = System.Drawing.Color.White;
            this.btnThemnhanvien.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnThemnhanvien.IconColor = System.Drawing.Color.White;
            this.btnThemnhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemnhanvien.IconSize = 30;
            this.btnThemnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemnhanvien.Location = new System.Drawing.Point(265, 572);
            this.btnThemnhanvien.Name = "btnThemnhanvien";
            this.btnThemnhanvien.Size = new System.Drawing.Size(129, 53);
            this.btnThemnhanvien.TabIndex = 30;
            this.btnThemnhanvien.Text = "Thêm";
            this.btnThemnhanvien.UseVisualStyleBackColor = false;
            this.btnThemnhanvien.Click += new System.EventHandler(this.btnThemnhanvien_Click);
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 651);
            this.Controls.Add(this.cbxVitri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.btnTimkiemnhanvien);
            this.Controls.Add(this.btnInnhanvien);
            this.Controls.Add(this.btnXoanhanvien);
            this.Controls.Add(this.btnSuanhanvien);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnThemnhanvien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimkiemnhacungcap);
            this.Controls.Add(this.txtSodienthoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTennhavnien);
            this.Controls.Add(this.txtManhanvien);
            this.Controls.Add(this.dataGridViewNhanvien);
            this.Controls.Add(this.panel1);
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnTimkiemnhanvien;
        private FontAwesome.Sharp.IconButton btnInnhanvien;
        private FontAwesome.Sharp.IconButton btnXoanhanvien;
        private FontAwesome.Sharp.IconButton btnSuanhanvien;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnThemnhanvien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimkiemnhacungcap;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTennhavnien;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.DataGridView dataGridViewNhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.ComboBox cbxVitri;
    }
}