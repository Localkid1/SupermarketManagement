using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using Microsoft.Office.Interop.Excel;
using SupermarketManagement.DAO;
using SupermarketManagement.DTO;
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
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Vml;
using System.Text.RegularExpressions;

namespace SupermarketManagement.GUI
{
    public partial class BanHang : RoundedForm
    {
        public BanHang()
        {
            InitializeComponent();
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
        void load_data()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select SanPham.ProductID, ProductName,SanPham.Unit, SanPham.ProductIndex, SanPham.Price from SanPham", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            System.Data.DataTable dt = new System.Data.DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
        }
        private void BanHang_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select SanPham.ProductID, ProductName,SanPham.Unit, SanPham.ProductIndex, SanPham.Price from SanPham", con);
            con.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dataGridViewSpNhanvien.AllowUserToAddRows = false;
            dataGridViewSpNhanvien.RowTemplate.Height = 45;
            dataGridViewSpNhanvien.DataSource = dt;
            dataGridViewSpNhanvien.Columns[0].Width = 150;
            dataGridViewSpNhanvien.Columns[1].Width = 200;
            dataGridViewSpNhanvien.Columns[2].Width = 200;
            dataGridViewSpNhanvien.Columns[3].Width = 200;
            dataGridViewSpNhanvien.Columns[4].Width = 200;

            dataGridViewSpNhanvien.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridViewSpNhanvien.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridViewSpNhanvien.Columns[2].HeaderText = "Đơn vị tính";
            dataGridViewSpNhanvien.Columns[3].HeaderText = "Số lượng";
            dataGridViewSpNhanvien.Columns[4].HeaderText = "Giá";


           //EmployeeName();






            con.Close();
            load_data();
        }
        
        void EmployeeName()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT EmployeeName FROM Nhanvien WHERE EmployeeName = 'Nguyễn Thị A'", con);
            SqlCommand cmd1 = new SqlCommand("SELECT username FROM TaiKhoan WHERE username = 'nhanvien'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            con.Open();
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader.HasRows && reader1.HasRows)
            {   
                
                while (reader.Read() && reader1.Read())
                {
                    lblNhanvien.Text = reader1.GetString(0); // gán giá trị "Nguyen Van A" vào lblNhanvien
                }
            }
            else
            {
                lblNhanvien.Text = "";
            }
            con.Close();
            con.Close();

        }
        private void dataGridViewSpNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSpNhanvien.CurrentRow != null)
            {
                txtMasanpham.Text = dataGridViewSpNhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTensanpham.Text = dataGridViewSpNhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonvitinh.Text = dataGridViewSpNhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoluong.Text = dataGridViewSpNhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGiaban.Text = dataGridViewSpNhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();

                txtMasanpham.Enabled = false;
                txtTensanpham.Enabled = false;
                txtDonvitinh.Enabled = false;
                txtSoluong.Enabled = false;
                txtGiaban.Enabled = false;
            }
            else
            {
                txtMasanpham.Text = "";
                txtTensanpham.Text = "";
                txtDonvitinh.Text = "";
                txtSoluong.Text = "";
                txtGiaban.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewHoadon.Rows.Clear();
            txtSoluongnhap.Clear();
            txtMasanpham.Clear();
            txtTensanpham.Clear();
            txtSoluong.Clear();
            txtDonvitinh.Clear();
            txtGiaban.Clear();
            lblTongtien.Text = "";
         
         
        }

        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }

        private void txtSoluongnhap_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtSoluongnhap.Text) != true)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                txtSoluongnhap.Text = "";
            }
        }

        private void btnThemsanpham_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            if (dataGridViewSpNhanvien.SelectedRows.Count > 0)
            {
                string maSanPham = dataGridViewSpNhanvien.SelectedRows[0].Cells["ProductID"]?.Value?.ToString();
                string tenSanPham = dataGridViewSpNhanvien.SelectedRows[0].Cells["ProductName"]?.Value?.ToString();
                string donviTinh = dataGridViewSpNhanvien.SelectedRows[0].Cells["Unit"]?.Value?.ToString();

                if (int.TryParse(txtSoluong.Text, out int soLuong) && double.TryParse(txtGiaban.Text, out double giaBan))
                {
                    if (!dataGridViewHoadon.Columns.Contains("ProductID"))
                    {
                        dataGridViewHoadon.Columns.Add("ProductID", "Mã sản phẩm");
                        dataGridViewHoadon.Columns.Add("ProductName", "Tên sản phẩm");
                        dataGridViewHoadon.Columns.Add("Unit", "Đơn vị tính");
                        dataGridViewHoadon.Columns.Add("ProductIndex", "Số lượng");
                        dataGridViewHoadon.Columns.Add("Price", "Giá");
                        dataGridViewHoadon.Columns.Add("TotalAmount", "Tổng tiền");

                        dataGridViewHoadon.Columns[0].Width = 150;
                        dataGridViewHoadon.Columns[1].Width = 200;
                        dataGridViewHoadon.Columns[2].Width = 150;
                        dataGridViewHoadon.Columns[3].Width = 100;
                        dataGridViewHoadon.Columns[4].Width = 200;
                        dataGridViewHoadon.Columns[5].Width = 200;
                    }
                    int.TryParse(txtSoluongnhap.Text, out int soLuongNhap);

                    int soLuongTong;
                    soLuongTong = (soLuong - soLuongNhap);

                    if (soLuongNhap == 0)
                    {
                        MessageBox.Show("Vui lòng nhập lại");
                        return;
                    }
                    if (soLuong < soLuongNhap)
                    {
                        MessageBox.Show("Vui lòng nhập món hàng khác");
                        return;
                    }
                    double thanhTien = soLuongNhap * giaBan;

                    double tongTien = 0;


                    DataGridViewRow newRow = new DataGridViewRow();


                    newRow.CreateCells(dataGridViewHoadon);
                    newRow.Cells[0].Value = maSanPham;
                    newRow.Cells[1].Value = tenSanPham;
                    newRow.Cells[2].Value = donviTinh;
                    newRow.Cells[3].Value = soLuongNhap;
                    newRow.Cells[4].Value = giaBan;
                    newRow.Cells[5].Value = thanhTien;

                  
                    // Lấy mã sản phẩm của sản phẩm vừa thêm vào bảng dataGridViewHoadon
                    maSanPham = newRow.Cells[0].Value.ToString();

                    DataGridViewRow spNhanvienRow = dataGridViewSpNhanvien.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(row => row.Cells["ProductID"].Value.ToString() == maSanPham);


                    // Tìm kiếm cột có tên tương ứng với DataPropertyName "ProductIndex"
                    var columnIndex = dataGridViewSpNhanvien.Columns
                        .Cast<DataGridViewColumn>()
                        .FirstOrDefault(col => col.DataPropertyName == "ProductIndex")
                        ?.Index;

                    // Nếu tìm thấy, cập nhật giá trị của cột Soluong
                    if (spNhanvienRow != null)
                    {
                        int soLuongTrongKho = int.Parse(spNhanvienRow.Cells["ProductIndex"].Value.ToString());
                        spNhanvienRow.Cells[columnIndex.Value].Value = soLuongTrongKho - soLuongNhap;

                    }

               
                    string sql1 = "DELETE FROM HoaDonBan1 WHERE HoaDonBan1.InvoiceInformation NOT LIKE '%|%' ";
                    SqlCommand cmd1 = new SqlCommand(sql1, connection);
                    cmd1.ExecuteNonQuery();


                    string invoiceInfo = string.Empty;
         
                    foreach (DataGridViewRow row in dataGridViewHoadon.Rows)
                    {
                        if (
                        row.Cells["ProductName"].Value != null &&
                        row.Cells["ProductIndex"].Value != null)
                        {
                            string productname = row.Cells[1].Value.ToString();
                            string productIndex = row.Cells[3].Value.ToString();
                            string productInfo = $"{productname} - {productIndex}";
                            invoiceInfo += $"| {productInfo}";
                        }
                    }
                    invoiceInfo = invoiceInfo.TrimStart('|'); // Xóa dấu '|' ở đầu chuỗi
                    double tongTien1 = 0;

                    for (int i = 0; i < dataGridViewHoadon.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = dataGridViewHoadon.Rows[i];
                        double thanhTien1 = Convert.ToDouble(row.Cells[4].Value);
                        tongTien1 += thanhTien1;
                    }

                    string sql = "INSERT INTO HoaDonBan1 (InvoiceInformation, TotalAmount1)" + "VALUES (@InvoiceInformation,@TotalAmount1);";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                   
                    cmd.Parameters.AddWithValue("@InvoiceInformation", invoiceInfo);
                    cmd.Parameters.AddWithValue("@TotalAmount1", tongTien1);

                    cmd.ExecuteNonQuery();





                    dataGridViewHoadon.Rows.Add(newRow);


                    for (int i = 0; i < dataGridViewHoadon.Rows.Count; i++)
                    {
                        thanhTien = Convert.ToDouble(dataGridViewHoadon.Rows[i].Cells["TotalAmount"].Value);
                        tongTien += thanhTien;
                        lblTongtien.Text = tongTien.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng hoặc giá bán không hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thêm vào hóa đơn!");
            }
            connection.Close();


        }
        public DataGridView dataGridViewHoaDon;
        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            GUI.HoaDonBan hoaDon = new HoaDonBan();
            if (dataGridViewHoadon.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn trống, hãy nhập sản phẩm vào hóa đơn trước khi in");
            }
            else
            {
                hoaDon.dataGridViewHoaDon = this.dataGridViewHoadon;
                hoaDon.ShowDialog();
            }
         

        }

        private void btnLuuhoadon_Click(object sender, EventArgs e)
        {
            SaveToExcel(dataGridViewHoadon);

        }

        private void SaveToExcel(DataGridView dataGridView)
        {
            // Khởi tạo ứng dụng Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(saveFileDialog.FileName, SpreadsheetDocumentType.Workbook))
                {
                    WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                    workbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                    WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                    worksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(new SheetData());

                    DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>(new DocumentFormat.OpenXml.Spreadsheet.Sheets());
                    Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet 1" };
                    sheets.Append(sheet);

                    SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
                    Row headerRow = new Row();
                    for (int j = 0; j < dataGridViewHoadon.Columns.Count; j++)
                    {
                        string columnName = dataGridViewHoadon.Columns[j].HeaderText;
                        Cell cell = new Cell() { CellValue = new CellValue(columnName), DataType = new EnumValue<CellValues>(CellValues.String) };
                        headerRow.AppendChild(cell);
                    }
                    sheetData.AppendChild(headerRow);
                    double total = 0;
                    // Lưu dữ liệu từ DataGridView vào SheetData
                    for (int i = 0; i < dataGridViewHoadon.Rows.Count; i++)
                    {
                        if (dataGridViewHoadon.Columns[i].HeaderText == "TotalAmount")
                        {
                            double tongTien = (double)dataGridViewHoadon.Rows[i].Cells["TotalAmount"].Value;
                            total += tongTien;
                        }
                        Row row = new Row();
                        for (int j = 0; j < dataGridViewHoadon.Columns.Count; j++)
                        {
                            if (dataGridViewHoadon.Rows[i].Cells[j].Value != null)
                            {
                                string value = dataGridViewHoadon.Rows[i].Cells[j].Value.ToString();
                                Cell cell = new Cell() { CellValue = new CellValue(value), DataType = new EnumValue<CellValues>(CellValues.String) };
                                row.AppendChild(cell);

                               
                            }
                               
                        }
                        sheetData.AppendChild(row);
                    }
                    Row totalRow = new Row();
                    Cell totalCell = new Cell() { CellValue = new CellValue(total.ToString()), DataType = new EnumValue<CellValues>(CellValues.Number) };
                    totalRow.AppendChild(totalCell);
                    sheetData.AppendChild(totalRow);

                 
                    workbookPart.Workbook.Save();
                  
                    spreadsheetDocument.Close();
                }
            }
        }

       
    }
}

