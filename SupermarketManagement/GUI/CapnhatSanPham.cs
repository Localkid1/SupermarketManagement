using SupermarketManagement.BUS;
using SupermarketManagement.DTO;
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
    public partial class ThemSanPham : Form 
    {   
      
        public static SanPham frm;
        public static SanPham getThemSanPham
        {
            get
            {
                if (frm == null)
                {
                    frm = new SanPham();
                }
                return frm;
            }
        } 

        private SanPhamBUS sanPhamBUS;
        
        public ThemSanPham()
        {
            InitializeComponent();
            sanPhamBUS = new SanPhamBUS();
          
        }


     

        private void btnThemsanpham_Click(object sender, EventArgs e)
        {
            
                SanPhamDTO sanPham = new SanPhamDTO();
                sanPham.ProductID = txtMasanpham.Text;
                sanPham.ProductName = txtTensanpham.Text;
                sanPham.ProductIndex = Convert.ToInt32(txtSoluong.Text);
                sanPham.Price = Convert.ToInt32(txtGia.Text);
               sanPham.Quanlity = txtChatluong.Text;
                sanPham.ExpirationDate = dtpNgayhethan.Value;
                sanPham.ProductPlace = txtNoisanxuat.Text;
                sanPham.Unit = txtDonvitinh.Text;

              
                if (sanPhamBUS.AddProduct(sanPham))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    ThemSanPham_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại");
                }
            
        }
        
      

        private void btnSuasanpham_Click(object sender, EventArgs e)
        {
            SanPhamDTO sanPham = new SanPhamDTO();
            sanPham.ProductID = txtMasanpham.Text;
            sanPham.ProductName = txtTensanpham.Text;
            sanPham.ProductIndex = Convert.ToInt32(txtSoluong.Text);
            sanPham.Price = Convert.ToInt32(txtGia.Text);
            sanPham.Quanlity = txtChatluong.Text;
            sanPham.ExpirationDate = dtpNgayhethan.Value;
            sanPham.ProductPlace = txtNoisanxuat.Text;
            sanPham.Unit = txtDonvitinh.Text;

            if (sanPhamBUS.UpdateProduct(sanPham))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công");
                ThemSanPham_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại");
            }
        }

        private void btnXoasanpham_Click(object sender, EventArgs e)
        {
            SanPhamDTO sanPham = new SanPhamDTO();
            sanPham.ProductID = txtMasanpham.Text;
            sanPham.ProductName = txtTensanpham.Text;
            sanPham.ProductIndex = Convert.ToInt32(txtSoluong.Text);
            sanPham.Price = Convert.ToInt32(txtGia.Text);
            sanPham.Quanlity = txtChatluong.Text;
            sanPham.ExpirationDate = dtpNgayhethan.Value;
            sanPham.ProductPlace = txtNoisanxuat.Text;
            sanPham.Unit = txtDonvitinh.Text;

            if (sanPhamBUS.DeleteProduct(sanPham))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                ThemSanPham_Load(sender, e);
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại");
            }
        }

        private void ThemSanPham_Load(object sender, EventArgs e)
        {
           

            if (SanPham.selectedRow != null) 
            {
                txtMasanpham.Text = SanPham.selectedRow.Cells[0].Value.ToString();
                txtTensanpham.Text = SanPham.selectedRow.Cells[1].Value.ToString();
                txtSoluong.Text = SanPham.selectedRow.Cells[2].Value.ToString();
                txtGia.Text = SanPham.selectedRow.Cells[3].Value.ToString();
                txtChatluong.Text = SanPham.selectedRow.Cells[4].Value.ToString();
                dtpNgayhethan.Text = SanPham.selectedRow.Cells[5].Value.ToString();
                txtNoisanxuat.Text = SanPham.selectedRow.Cells[6].Value.ToString();
                txtDonvitinh.Text = SanPham.selectedRow.Cells[7].Value.ToString();
            }
            else 
            {
                txtMasanpham.Text = "";
                txtTensanpham.Text = "";
                txtSoluong.Text = "";
                txtGia.Text = "";
                txtChatluong.Text = "";
                dtpNgayhethan.Text = "";
                txtNoisanxuat.Text = "";
                txtDonvitinh.Text = "";
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMasanpham.Clear();
            txtTensanpham.Clear();
            txtSoluong.Clear();
            txtGia.Clear();
            txtChatluong.Text = "";
            dtpNgayhethan.Text = "";
            txtNoisanxuat.Clear();
            txtDonvitinh.Clear();
            
        }

      
    }
}
