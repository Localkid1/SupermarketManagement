namespace SupermarketManagement.GUI
{
    partial class DoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartDoanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxDate = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhthu)).BeginInit();
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
            this.pictureBox1.Image = global::SupermarketManagement.Properties.Resources.grow_up;
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
            this.label1.Text = "Quản lý doanh thu";
            // 
            // chartDoanhthu
            // 
            this.chartDoanhthu.BackColor = System.Drawing.Color.LightCyan;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartDoanhthu.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.LightCyan;
            legend1.BorderColor = System.Drawing.Color.LightCyan;
            legend1.Name = "Legend1";
            this.chartDoanhthu.Legends.Add(legend1);
            this.chartDoanhthu.Location = new System.Drawing.Point(1, 79);
            this.chartDoanhthu.Name = "chartDoanhthu";
            this.chartDoanhthu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chartDoanhthu.Size = new System.Drawing.Size(1151, 487);
            this.chartDoanhthu.TabIndex = 3;
            this.chartDoanhthu.Text = "Doanh thu";
            this.chartDoanhthu.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            this.chartDoanhthu.MouseLeave += new System.EventHandler(this.chartDoanhthu_MouseLeave);
            this.chartDoanhthu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartDoanhthu_MouseMove);
            // 
            // cbxDate
            // 
            this.cbxDate.FormattingEnabled = true;
            this.cbxDate.Items.AddRange(new object[] {
            "Ngày (Tháng 1)",
            "Ngày (Tháng 2)",
            "Ngày (Tháng 3)",
            "Ngày (Tháng 4)",
            "Ngày (Tháng 5)",
            "Ngày (Tháng 6)",
            "Ngày (Tháng 7)",
            "Ngày (Tháng 8)",
            "Ngày (Tháng 9)",
            "Ngày (Tháng 10)",
            "Ngày (Tháng 11)",
            "Ngày (Tháng 12)",
            "Tháng",
            "Năm"});
            this.cbxDate.Location = new System.Drawing.Point(55, 598);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(195, 24);
            this.cbxDate.TabIndex = 4;
            this.cbxDate.SelectedValueChanged += new System.EventHandler(this.cbxDate_SelectedValueChanged);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 651);
            this.Controls.Add(this.cbxDate);
            this.Controls.Add(this.chartDoanhthu);
            this.Controls.Add(this.panel1);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhthu;
        private System.Windows.Forms.ComboBox cbxDate;
    }
}