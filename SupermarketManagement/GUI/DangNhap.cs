using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketManagement.BUS;
using SupermarketManagement.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SupermarketManagement.GUI
{
    public partial class DangNhap : RoundedForm
    {

        DangNhapDTO login = new DangNhapDTO();
        DangNhapBUS loginbus = new DangNhapBUS();
        TrangChu trangChu = new TrangChu();
        BanHang banHang = new BanHang();

        
        public DangNhap()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin")
            {
                login.userName = txtUsername.Text;
                login.passWord = txtPassword.Text;
                string getuser = loginbus.CheckLogin(login);

                switch (getuser)
                {
                    case "requeid_username":
                        MessageBox.Show("Tài khoản không được để trống");
                        return;

                    case "requeid_password":
                        MessageBox.Show("Mật khẩu không được để trống");
                        return;

                    case "Tài khoản hoặc mật khẩu không chính xác!":
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                        return;
                }

                MessageBox.Show("Đăng nhập quyền quản lý");
                trangChu.Show();
            }
            else
            {
                login.userName = txtUsername.Text;
                login.passWord = txtPassword.Text;
                string getuser = loginbus.CheckLogin(login);

                switch (getuser)
                {
                    case "requeid_username":
                        MessageBox.Show("Tài khoản không được để trống");
                        return;

                    case "requeid_password":
                        MessageBox.Show("Mật khẩu không được để trống");
                        return;

                    case "Tài khoản hoặc mật khẩu không chính xác!":
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                        return;
                }
                MessageBox.Show("Đăng nhập quyền nhân viên");
                banHang.Show();
               
            }        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn đăng xuất ra màn hình trang chủ không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Hide();
                frmMain main = new frmMain();
                //this.Hide();
                main.ShowDialog();
                txtUsername.Clear();
                txtPassword.Clear();
               
            }
            
        }

       
    }
}
