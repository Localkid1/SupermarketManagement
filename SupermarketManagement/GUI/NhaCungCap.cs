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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagement.GUI
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        NhaCungCapBUS supplierBUS = new NhaCungCapBUS();
        private void btnXoanhacungcap_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO supplier = new NhaCungCapDTO();
            supplier.OrderID = txtManhacungcap.Text;
            supplier.OrdderName = txtTennhacungcap.Text;
            supplier.Address = txtDiachi.Text;
            supplier.PhoneNumber = txtSodienthoai.Text;

            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                if (supplierBUS.DeleteSupplier(supplier))
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    NhaCungCap_Load(sender, e);
                    btnClear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại");
                }
            }
          
        }

     
        private void btnThemnhacungcap_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO supplier = new NhaCungCapDTO();
            supplier.OrderID = txtManhacungcap.Text;
            supplier.OrdderName = txtTennhacungcap.Text;
            supplier.Address = txtDiachi.Text;
            supplier.PhoneNumber = txtSodienthoai.Text;

            if (supplierBUS.AddSupplier(supplier))
            {
                MessageBox.Show("Thêm nhà cung cấp thành công");
                 NhaCungCap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp thất bại");
            }
        }

        private void btnSuanhacungcap_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO supplier = new NhaCungCapDTO();
            supplier.OrderID = txtManhacungcap.Text;
            supplier.OrdderName = txtTennhacungcap.Text;
            supplier.Address = txtDiachi.Text;
            supplier.PhoneNumber = txtSodienthoai.Text;

            if (supplierBUS.UpdateSupplier(supplier))
            {
                MessageBox.Show("Cập nhật nhà cung cấp thành công");
                NhaCungCap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Cập nhật nhà cung cấp thất bại");
            }
        }

        private void btnInnhacungcap_Click(object sender, EventArgs e)
        {
          
                List<NhaCungCapDTO> suppliers = supplierBUS.GetProductsToExport();

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet ws = null;
            ws = wb.ActiveSheet;
            ws.Name = "Danh sách nhà cung cấp";
            ws.Range["A:A"].ColumnWidth = 30;

            // Đặt kích thước các cột khác là 40
            ws.Range["B:XFD"].ColumnWidth = 25;

            // Ghi tiêu đề cột
            int columnIndex = 1;
                foreach (DataGridViewColumn column in dataGridViewNhacungcap.Columns)
                {
                    ws.Cells[1, columnIndex] = column.HeaderText;
                    columnIndex++;
                }

                // Ghi dữ liệu sản phẩm
                int rowIndex = 2;
                foreach (NhaCungCapDTO supplier in suppliers)
                {
                    columnIndex = 1;
                    ws.Cells[rowIndex, columnIndex] = supplier.OrderID;
                    columnIndex++;
                    ws.Cells[rowIndex, columnIndex] = supplier.OrdderName;
                    columnIndex++;
                    ws.Cells[rowIndex, columnIndex] = supplier.Address;
                    columnIndex++;
                    ws.Cells[rowIndex, columnIndex] = supplier.PhoneNumber;
                    columnIndex++;
                   
                    rowIndex++;
                }

                // Lưu file và đóng workbook và application
                SaveFileDialog saveDialog = new SaveFileDialog();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiachi.Clear();
            txtManhacungcap.Clear();
            txtTennhacungcap.Clear();
            txtSodienthoai.Clear();

        }

        private void btnTimkiemnhacungcap_Click(object sender, EventArgs e)
        {
            NhaCungCapBUS supplierBUS = new NhaCungCapBUS();
            string supplierName = txtTimkiemnhacungcap.Text;
            List<NhaCungCapDTO> suppliers = supplierBUS.GetProductsByName(supplierName);

            if (suppliers.Count > 0)
            {
                dataGridViewNhacungcap.DataSource = suppliers;
                foreach (NhaCungCapDTO supplier in suppliers)
                {
                    Console.WriteLine(supplier.OrdderName);
                    dataGridViewNhacungcap.Columns[0].Width = 100;
                    dataGridViewNhacungcap.Columns[1].Width = 200;
                    dataGridViewNhacungcap.Columns[2].Width = 200;
                    dataGridViewNhacungcap.Columns[3].Width = 220;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào.");
            }
        }

        void load_data()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from NhaCungCap", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
        }

      
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from NhaCungCap", con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewNhacungcap.AllowUserToAddRows = false;
            dataGridViewNhacungcap.RowTemplate.Height = 45;
            dataGridViewNhacungcap.DataSource = dt;
            dataGridViewNhacungcap.Columns[0].Width = 100;
            dataGridViewNhacungcap.Columns[1].Width = 200;
            dataGridViewNhacungcap.Columns[2].Width = 200;
            dataGridViewNhacungcap.Columns[3].Width = 220;
            // Đặt tên mới cho cột dữ liệu có chỉ số 1
            dataGridViewNhacungcap.Columns[0].HeaderText = "Mã nhà cung cấp";
            dataGridViewNhacungcap.Columns[1].HeaderText = "Tên nhà cung cấp";
            dataGridViewNhacungcap.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewNhacungcap.Columns[3].HeaderText = "Số điện thoại";



            con.Close();
            load_data();

        }

        private void dataGridViewNhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNhacungcap.CurrentRow != null)
            {
                txtManhacungcap.Text = dataGridViewNhacungcap.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTennhacungcap.Text = dataGridViewNhacungcap.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiachi.Text = dataGridViewNhacungcap.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSodienthoai.Text = dataGridViewNhacungcap.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else
            {
                txtManhacungcap.Text = "";
                txtTennhacungcap.Text = "";
                txtDiachi.Text = "";
                txtSodienthoai.Text = "";
            }
          

        }
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
      
        private void txtSodienthoai_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSodienthoai.Text) != true)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                txtSodienthoai.Text = "";
            }
        }
    }
}
