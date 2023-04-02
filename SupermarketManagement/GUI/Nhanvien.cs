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
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;

namespace SupermarketManagement.GUI
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        NhanvienBUS employeeBUS = new NhanvienBUS();
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


        private void btnThemnhanvien_Click(object sender, EventArgs e)
        {
            NhanvienDTO employee = new NhanvienDTO();
            employee.EmployeeID = txtManhanvien.Text;
            employee.EmployeeName = txtTennhavnien.Text;
            employee.Position = cbxVitri.Text;
            employee.Address = txtDiachi.Text;
            employee.PhoneNumber = txtSodienthoai.Text;

            if (employeeBUS.AddEmployee(employee))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                Nhanvien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Nhanvien", con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewNhanvien.AllowUserToAddRows = false;
            dataGridViewNhanvien.RowTemplate.Height = 45;
            dataGridViewNhanvien.DataSource = dt;
            dataGridViewNhanvien.Columns[0].Width = 100;
            dataGridViewNhanvien.Columns[1].Width = 200;
            dataGridViewNhanvien.Columns[2].Width = 200;
            dataGridViewNhanvien.Columns[3].Width = 220;
            dataGridViewNhanvien.Columns[4].Width = 220;

            dataGridViewNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dataGridViewNhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dataGridViewNhanvien.Columns[2].HeaderText = "Vị trí";
            dataGridViewNhanvien.Columns[3].HeaderText = "Địa chỉ";
            dataGridViewNhanvien.Columns[4].HeaderText = "Số điện thoại";


            con.Close();
            load_data();
        }

        private void btnSuanhanvien_Click(object sender, EventArgs e)
        {

            NhanvienDTO employee = new NhanvienDTO();
            employee.EmployeeID = txtManhanvien.Text;
            employee.EmployeeName = txtTennhavnien.Text;
            employee.Position = cbxVitri.Text;
            employee.Address = txtDiachi.Text;
            employee.PhoneNumber = txtSodienthoai.Text;

            if (employeeBUS.UpdateEmployee(employee))
            {
                MessageBox.Show("Sửa nhân viên thành công");
                Nhanvien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
        }

        private void btnXoanhanvien_Click(object sender, EventArgs e)
        {
            NhanvienDTO employee = new NhanvienDTO();
            employee.EmployeeID = txtManhanvien.Text;
            employee.EmployeeName = txtTennhavnien.Text;
            employee.Position = cbxVitri.Text;
            employee.Address = txtDiachi.Text;
            employee.PhoneNumber = txtSodienthoai.Text;

            if (employeeBUS.DeleteEmployee(employee))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                Nhanvien_Load(sender, e);
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtManhanvien.Clear();
            txtTennhavnien.Clear();
            cbxVitri.Text = "";
            txtDiachi.Clear();
            txtSodienthoai.Clear();
        }

        private void btnTimkiemnhanvien_Click(object sender, EventArgs e)
        {
            NhanvienBUS employeeBUS = new NhanvienBUS();
            string employeeName = txtTimkiemnhacungcap.Text;
            List<NhanvienDTO> employees = employeeBUS.GetEmployeesByName(employeeName);

            if (employees.Count > 0)
            {
                dataGridViewNhanvien.DataSource = employees;
                foreach (NhanvienDTO employee in employees)
                {
                    Console.WriteLine(employee.EmployeeName);
                    dataGridViewNhanvien.Columns[0].Width = 100;
                    dataGridViewNhanvien.Columns[1].Width = 200;
                    dataGridViewNhanvien.Columns[2].Width = 200;
                    dataGridViewNhanvien.Columns[3].Width = 220;
                    dataGridViewNhanvien.Columns[4].Width = 220;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên nào.");
            }
        }

        private void dataGridViewNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNhanvien.CurrentRow != null)
            {
                txtManhanvien.Text = dataGridViewNhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTennhavnien.Text = dataGridViewNhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbxVitri.Text = dataGridViewNhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiachi.Text = dataGridViewNhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSodienthoai.Text = dataGridViewNhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else
            {
                txtManhanvien.Text = "";
                txtTennhavnien.Text = "";
                cbxVitri.Text = "";      
                txtDiachi.Text = "";
                txtSodienthoai.Text = "";
            }
        }

        private void btnInnhanvien_Click(object sender, EventArgs e)
        {
            List<NhanvienDTO> employees = employeeBUS.GetEmployeesToExport();

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet ws = null;
            ws = wb.ActiveSheet;
            ws.Name = "Danh sách nhân viên";
            // Đặt kích thước cột đầu tiên là 50
            ws.Range["A:A"].ColumnWidth = 20;

            // Đặt kích thước các cột khác là 40
            ws.Range["B:XFD"].ColumnWidth =25;


            // Ghi tiêu đề cột
            int columnIndex = 1;
            foreach (DataGridViewColumn column in dataGridViewNhanvien.Columns)
            {
                ws.Cells[1, columnIndex] = column.HeaderText;
                columnIndex++;
            }

            // Ghi dữ liệu sản phẩm
            int rowIndex = 2;
            foreach (NhanvienDTO employee in employees)
            {
                columnIndex = 1;
                ws.Cells[rowIndex, columnIndex] = employee.EmployeeID;
                columnIndex++;
                ws.Cells[rowIndex, columnIndex] = employee.EmployeeName;
                columnIndex++;
                ws.Cells[rowIndex, columnIndex] = employee.Position;
                columnIndex++;
                ws.Cells[rowIndex, columnIndex] = employee.Address;
                columnIndex++;
                ws.Cells[rowIndex, columnIndex] = employee.PhoneNumber;
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
    }
}
