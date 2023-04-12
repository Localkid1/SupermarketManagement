namespace SupermarketManagement.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTrangChu = new System.Windows.Forms.PictureBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTrangChu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTrangChu
            // 
            this.pnlTrangChu.Image = global::SupermarketManagement.Properties.Resources._11_1st_store_in_Hai_Phong;
            this.pnlTrangChu.Location = new System.Drawing.Point(-6, 88);
            this.pnlTrangChu.Name = "pnlTrangChu";
            this.pnlTrangChu.Size = new System.Drawing.Size(1463, 700);
            this.pnlTrangChu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnlTrangChu.TabIndex = 3;
            this.pnlTrangChu.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1402, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(47, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1459, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýNhàCungCấpToolStripMenuItem,
            this.thôngTinHóaĐơnToolStripMenuItem,
            this.quảnLýDoanhThuToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýNhàCungCấpToolStripMenuItem
            // 
            this.quảnLýNhàCungCấpToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
            this.quảnLýNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.quảnLýNhàCungCấpToolStripMenuItem.Text = "Quản lý nhà cung cấp";
            this.quảnLýNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàCungCấpToolStripMenuItem_Click);
            // 
            // thôngTinHóaĐơnToolStripMenuItem
            // 
            this.thôngTinHóaĐơnToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.thôngTinHóaĐơnToolStripMenuItem.Name = "thôngTinHóaĐơnToolStripMenuItem";
            this.thôngTinHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.thôngTinHóaĐơnToolStripMenuItem.Text = "Thông tin hóa đơn";
            this.thôngTinHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinHóaĐơnToolStripMenuItem_Click);
            // 
            // quảnLýDoanhThuToolStripMenuItem
            // 
            this.quảnLýDoanhThuToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.quảnLýDoanhThuToolStripMenuItem.Name = "quảnLýDoanhThuToolStripMenuItem";
            this.quảnLýDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.quảnLýDoanhThuToolStripMenuItem.Text = "Quản lý doanh thu";
            this.quảnLýDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.quảnLýDoanhThuToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýBánHàngToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // quảnLýBánHàngToolStripMenuItem
            // 
            this.quảnLýBánHàngToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.quảnLýBánHàngToolStripMenuItem.Name = "quảnLýBánHàngToolStripMenuItem";
            this.quảnLýBánHàngToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.quảnLýBánHàngToolStripMenuItem.Text = "Quản lý bán hàng";
            this.quảnLýBánHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýBánHàngToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1461, 764);
            this.Controls.Add(this.pnlTrangChu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChuPM";
            ((System.ComponentModel.ISupportInitialize)(this.pnlTrangChu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.PictureBox pnlTrangChu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBánHàngToolStripMenuItem;
    }
}