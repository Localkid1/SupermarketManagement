using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagement.GUI
{
    public partial class HoaDonBan : Form
    {
        public DataGridView dataGridViewHoaDon;

        public HoaDonBan()
        {
            InitializeComponent();
        }

        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            LoadDataToLabels();
            
        }
      
        private void LoadDataToLabels()
        {
            float tong = 0;
            // Lấy dữ liệu từ DataGridView của Form1 và đổ vào các Label
            for (int i = 0; i < dataGridViewHoaDon.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridViewHoaDon.Rows[i];
                ListViewItem item = new ListViewItem();

                if (row.Cells["ProductID"].Value != null && row.Cells["ProductName"].Value != null &&
                    row.Cells["Unit"].Value != null && row.Cells["ProductIndex"].Value != null &&
                    row.Cells["Price"].Value != null && row.Cells["TotalAmount"].Value != null)
                {
                    item.SubItems.Add(row.Cells["ProductID"].Value.ToString());
                    item.SubItems.Add(row.Cells["ProductName"].Value.ToString());
                    item.SubItems.Add(row.Cells["Unit"].Value.ToString());
                    item.SubItems.Add(row.Cells["ProductIndex"].Value.ToString());
                    item.SubItems.Add(row.Cells["Price"].Value.ToString());
                    item.SubItems.Add(row.Cells["TotalAmount"].Value.ToString());

                    item.SubItems[0].Text = row.Cells["ProductID"].Value.ToString();
                    item.SubItems[1].Text = row.Cells["ProductName"].Value.ToString();
                    item.SubItems[2].Text = row.Cells["Unit"].Value.ToString();
                    item.SubItems[3].Text = row.Cells["ProductIndex"].Value.ToString();
                    item.SubItems[4].Text = row.Cells["Price"].Value.ToString();
                    item.SubItems[5].Text = row.Cells["TotalAmount"].Value.ToString();

                    if (row.Cells["ProductIndex"].Value != null && row.Cells["Price"].Value != null)
                    {
                        float soluong = float.Parse(row.Cells["ProductIndex"].Value.ToString());
                        float gia = float.Parse(row.Cells["Price"].Value.ToString());
                        item.SubItems.Add((soluong * gia).ToString());
                        tong += soluong * gia;
                    }
                    listViewHoaDon.Items.Add(item);
                }
                lblTong.Text = tong.ToString();
            }                                        
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
         
            lblTime.Text = DateTime.Now.ToString();
            this.timer1.Enabled = false;

        }
    }
}
