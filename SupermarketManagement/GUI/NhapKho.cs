using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SupermarketManagement.GUI
{
    public partial class NhapKho : Form
    {
        public NhapKho()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True";
      
        private void NhapKho_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from HoaDonBan1", connection);
            connection.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewHoadonban.AllowUserToAddRows = false;
            dataGridViewHoadonban.RowTemplate.Height = 45;
            dataGridViewHoadonban.DataSource = dt;
            dataGridViewHoadonban.Columns[1].Width = 250;
            dataGridViewHoadonban.Columns[3].Width = 150;
            dataGridViewHoadonban.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridViewHoadonban.Columns[1].HeaderText = "Tên sản phẩm và số lượng";
            dataGridViewHoadonban.Columns[2].HeaderText = "Ngày hóa đơn";
            dataGridViewHoadonban.Columns[3].HeaderText = "Thanh toán";

            txtMahoadon.Enabled = false;
            txtThongtinhoadon.Enabled = false;
            txtNgayhoadon.Enabled = false;
            txtThanhtoan.Enabled = false;

            connection.Close();
        }
        void load_data()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Select * from HoaDonBan1", connection);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            connection.Open();
            da.Fill(dt);
            connection.Close();
        }



        private void dataGridViewHoadonban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewHoadonban.CurrentRow != null)
            {
                txtMahoadon.Text = dataGridViewHoadonban.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtThongtinhoadon.Text = dataGridViewHoadonban.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNgayhoadon.Text = dataGridViewHoadonban.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtThanhtoan.Text = dataGridViewHoadonban.Rows[e.RowIndex].Cells[3].Value.ToString();
               
            }
            else
            {
                txtMahoadon.Text = "";
                txtThongtinhoadon.Text = "";
                txtNgayhoadon.Text = "";
                txtThanhtoan.Text = "";
            }
        }

        private void btnTimkiemhoadon_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDonBan1 WHERE InvoiceInformation LIKE '%" + txtTimkiemhoadon.Text + "%'", connection);
            DataTable dt = new DataTable();      
            connection.Open();
            da.Fill(dt);
            dataGridViewHoadonban.DataSource = dt;
            connection.Close();
        }

    

        private void cbxSort_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            if (cbxSort.SelectedItem != null)
            {
                switch (cbxSort.SelectedItem.ToString())
                {
                    case "Tên: A-Z":
                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDonBan1 ORDER BY HoaDonBan1.InvoiceInformation ASC  ", connection);
                        DataTable dt = new DataTable();                       
                        da.Fill(dt);
                        dataGridViewHoadonban.DataSource = dt;
                    break;

                    case "Tên: Z-A":
                        SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM HoaDonBan1 ORDER BY HoaDonBan1.InvoiceInformation DESC  ", connection);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        dataGridViewHoadonban.DataSource = dt1;
                        break;

                    case "Thành tiền: Tăng dần":
                        SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM HoaDonBan1 ORDER BY HoaDonBan1.TotalAmount1 ASC ", connection);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        dataGridViewHoadonban.DataSource = dt2;
                        break;

                    case "Thành tiền: Giảm dần":
                        SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM HoaDonBan1 ORDER BY HoaDonBan1.TotalAmount1 DESC ", connection);
                        DataTable dt3 = new DataTable();
                        da3.Fill(dt3);
                        dataGridViewHoadonban.DataSource = dt3;
                        break;

                    case "Thời gian: Mới nhất":
                        SqlDataAdapter da4 = new SqlDataAdapter("SELECT * FROM HoaDonBan1 ORDER BY HoaDonBan1.InvoiceDate DESC  ", connection);
                        DataTable dt4 = new DataTable();
                        da4.Fill(dt4);
                        dataGridViewHoadonban.DataSource = dt4;
                        break;

                    case "Thời gian: Cũ nhất":
                        SqlDataAdapter da5 = new SqlDataAdapter("SELECT * FROM HoaDonBan1 ORDER BY HoaDonBan1.InvoiceDate ASC  ", connection);
                        DataTable dt5 = new DataTable();
                        da5.Fill(dt5);
                        dataGridViewHoadonban.DataSource = dt5;
                        break;
                }
            }
            connection.Close();
        }

      
    }
}
