using SupermarketManagement.BUS;
using SupermarketManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupermarketManagement.GUI
{   
    
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
          
        }
    

        private void btnCapnhatsanpham_Click(object sender, EventArgs e)
        {
            GUI.ThemSanPham themsanpham = new ThemSanPham();
            themsanpham.ShowDialog();
            SanPham_Load(sender, e);
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from SanPham", con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSanpham.AllowUserToAddRows = false;
            dataGridViewSanpham.RowTemplate.Height = 45;
            dataGridViewSanpham.DataSource = dt;
            dataGridViewSanpham.Columns[0].Width = 150;
            dataGridViewSanpham.Columns[5].Width = 200;
            dataGridViewSanpham.Columns[6].Width = 200;
            dataGridViewSanpham.Columns[7].Width = 200;

            dataGridViewSanpham.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridViewSanpham.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridViewSanpham.Columns[2].HeaderText = "Số lượng";
            dataGridViewSanpham.Columns[3].HeaderText = "Giá";
            dataGridViewSanpham.Columns[4].HeaderText = "Chất lượng";
            dataGridViewSanpham.Columns[5].HeaderText = "Ngày hết hạn";
            dataGridViewSanpham.Columns[6].HeaderText = "Nơi sản xuất";
            dataGridViewSanpham.Columns[7].HeaderText = "Đơn vị tính";

            con.Close();
            load_data();

        }

        public static DataGridViewRow selectedRow;





        private void dataGridViewSanpham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataGridViewSanpham.Rows[e.RowIndex];
                
            }
        }

        void load_data()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from SanPham", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
          
            con.Close();
        }
      
        private void btnTimkiemsanpham_Click(object sender, EventArgs e)
        {
            SanPhamBUS productBUS = new SanPhamBUS();
            string productName = txtTimkiemsanpham.Text;
            List<SanPhamDTO> products = productBUS.GetProductsByName(productName);

            if (products.Count > 0)
            {
                dataGridViewSanpham.DataSource = products;
                foreach (SanPhamDTO product in products)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào.");
            }
        }


        SanPhamBUS productBUS = new SanPhamBUS();
        private void btnInsanpham_Click(object sender, EventArgs e)
        {
            List<SanPhamDTO> products = productBUS.GetProductsToExport();

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet ws = null;
            ws = wb.ActiveSheet;
            ws.Name = "Danh sách sản phẩm";

            // Ghi tiêu đề cột
            int columnIndex = 1;
            foreach (DataGridViewColumn column in dataGridViewSanpham.Columns)
            {
                ws.Cells[1, columnIndex] = column.HeaderText;
                columnIndex++;
            }

            // Ghi dữ liệu sản phẩm
            int rowIndex = 2;
            foreach (SanPhamDTO product in products)
            {   
                columnIndex = 1;
                ws.Cells[rowIndex, columnIndex] = product.ProductID;
                columnIndex++;
                ws.Cells[rowIndex, columnIndex] = product.ProductName;
                columnIndex++;
                ws.Cells[rowIndex, columnIndex] = product.ProductIndex;
                columnIndex++;
                ws.Cells[rowIndex, columnIndex] = product.Price;
                columnIndex++;
                ws.Cells[rowIndex, columnIndex] = product.Quanlity;
                columnIndex++;
                ws.Cells[rowIndex, columnIndex] = product.ExpirationDate;
                ws.Cells[rowIndex, columnIndex].NumberFormat = "dd/MM/yyyy";
                ws.Cells[rowIndex, columnIndex] = product.ExpirationDate.ToString("dd/MM/yyyy");
                columnIndex++;
                ws.Cells[rowIndex, columnIndex] = product.ProductPlace;
                columnIndex++;
                ws.Cells[rowIndex, columnIndex] = product.Unit;
                columnIndex++;

                rowIndex++;
            }

            // Lưu file và đóng workbook và application
            SaveFileDialog saveDialog = new SaveFileDialog();
            //Tăng chiều dài của từng thuộc tính khi đổ dữ liệu ra tư sql
           // dataGridViewSanpham.Columns[0].Width = 150;
          //  dataGridViewSanpham.Columns[5].Width = 200;
          //  dataGridViewSanpham.Columns[6].Width = 200;
         //   dataGridViewSanpham.Columns[7].Width = 200;
            saveDialog.Filter = "Excel Workbook|*.xlsx";
            saveDialog.Title = "Save Excel file";
            saveDialog.InitialDirectory = "C:\\Users\\Admin\\Documents\\Excel";
            saveDialog.ShowDialog();


            if (saveDialog.FileName != "")
            {
                wb.SaveAs(saveDialog.FileName);
                MessageBox.Show("Đã lưu file thành công!");
            }

            wb.Close();
            app.Quit();
            Marshal.ReleaseComObject(ws);
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(app);


        }
    }
}
