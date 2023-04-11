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
    public partial class frmMain : RoundedForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          
            Application.Exit();
        }

          
        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Đóng form hiện tại
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show(); // Hiển thị form Đăng nhập
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Đóng form hiện tại
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show(); // Hiển thị form Đăng nhập
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Đóng form hiện tại
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show(); // Hiển thị form Đăng nhập
        }

        private void thôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Đóng form hiện tại
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show(); // Hiển thị form Đăng nhập
        }

        private void quảnLýDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Đóng form hiện tại
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show(); // Hiển thị form Đăng nhập
        }

        private void quảnLýBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Đóng form hiện tại
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show(); // Hiển thị form Đăng nhập
        }
    }
}
