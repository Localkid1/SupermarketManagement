using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagement.GUI
{
    public partial class TrangChu : RoundedForm
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlTrangChu.Controls.Add(childForm);
            pnlTrangChu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
            }

        } 

        private void TrangChu_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SanPham());
        }

    

        private void btnNhacungcap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhaCungCap());
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Nhanvien());
          
        }

        private void btnNhapkho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhapKho());
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoanhThu());
        }

        private void pnlTrangChu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                Application.Exit();
            }
        }
    }
}
