using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
