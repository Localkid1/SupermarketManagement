using SupermarketManagement.DTO;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SupermarketManagement.GUI
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db.Supermarket;Integrated Security=True";

        private void DoanhThu_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 4 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 4");
            series.ChartType = SeriesChartType.Column;

            for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
            {
                series.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
            }
            while (reader.Read())
            {
                int ngayHoaDon = Convert.ToInt32(reader["Ngay"]);
                double tongTien = Convert.ToDouble(reader["TongTien"]);

                series.Points[ngayHoaDon - 1].SetValueY(tongTien);

            }
            chartDoanhthu.Series.Clear();
            chartDoanhthu.Series.Add(series);
            chartDoanhthu.Update();

            cbxDate_SelectedValueChanged(sender, e);
            reader.Close();
            connection.Close();



        }



        private void cbxDate_SelectedValueChanged(object sender, EventArgs e)
        {
            // System.Data.DataTable dataTable = new System.Data.DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            // Lặp qua tất cả các DataPoint trong chuỗi dữ liệu

            if (cbxDate.SelectedItem != null)
            {
                switch (cbxDate.SelectedItem.ToString())
                {
                    case "Ngày (Tháng 1)":


                        SqlCommand cmd = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 1 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader = cmd.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu theo tháng 1");
                        series.ChartType = SeriesChartType.Column;
                        foreach (DataPoint dataPoint in series.Points)
                        {
                            // Đặt màu cho cột dữ liệu là màu đỏ
                            dataPoint.Color = Color.Red;
                        }

                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader["Ngay"]);
                            double tongTien = Convert.ToDouble(reader["TongTien"]);

                            series.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series);

                        chartDoanhthu.Update();

                        reader.Close();
                        connection.Close();

                        break;

                    case "Ngày (Tháng 2)":


                        SqlCommand cmd3 = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 2 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader3 = cmd3.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 2");
                        series3.ChartType = SeriesChartType.Column;
                        foreach (DataPoint dataPoint in series3.Points)
                        {
                            // Đặt màu cho cột dữ liệu là màu đỏ
                            dataPoint.Color = Color.Red;
                        }

                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series3.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader3.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader3["Ngay"]);
                            double tongTien = Convert.ToDouble(reader3["TongTien"]);

                            series3.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series3);

                        chartDoanhthu.Update();

                        reader3.Close();
                        connection.Close();

                        break;

                    case "Ngày (Tháng 3)":


                        SqlCommand cmd4 = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 3 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader4 = cmd4.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 3");
                        series4.ChartType = SeriesChartType.Column;
                        foreach (DataPoint dataPoint in series4.Points)
                        {
                            // Đặt màu cho cột dữ liệu là màu đỏ
                            dataPoint.Color = Color.Red;
                        }

                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series4.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader4.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader4["Ngay"]);
                            double tongTien = Convert.ToDouble(reader4["TongTien"]);

                            series4.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series4);

                        chartDoanhthu.Update();

                        reader4.Close();
                        connection.Close();

                        break;

                    case "Ngày (Tháng 4)":


                        SqlCommand cmd5 = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 4 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader5 = cmd5.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 4");
                        series5.ChartType = SeriesChartType.Column;
                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series5.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader5.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader5["Ngay"]);
                            double tongTien = Convert.ToDouble(reader5["TongTien"]);

                            series5.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series5);

                        chartDoanhthu.Update();

                        reader5.Close();
                        connection.Close();

                        break;

                    case "Ngày (Tháng 5)":


                        SqlCommand cmd6 = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 5 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader6 = cmd6.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 5");
                        series6.ChartType = SeriesChartType.Column;
                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series6.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader6.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader6["Ngay"]);
                            double tongTien = Convert.ToDouble(reader6["TongTien"]);

                            series6.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series6);

                        chartDoanhthu.Update();

                        reader6.Close();
                        connection.Close();

                        break;

                    case "Ngày (Tháng 6)":


                        SqlCommand cmd7 = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 6 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader7 = cmd7.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 6");
                        series7.ChartType = SeriesChartType.Column;
                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series7.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader7.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader7["Ngay"]);
                            double tongTien = Convert.ToDouble(reader7["TongTien"]);

                            series7.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series7);

                        chartDoanhthu.Update();

                        reader7.Close();
                        connection.Close();

                        break;

                    case "Ngày (Tháng 7)":


                        SqlCommand cmd8 = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 7 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader8 = cmd8.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 7");
                        series8.ChartType = SeriesChartType.Column;
                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series8.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader8.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader8["Ngay"]);
                            double tongTien = Convert.ToDouble(reader8["TongTien"]);

                            series8.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series8);

                        chartDoanhthu.Update();

                        reader8.Close();
                        connection.Close();

                        break;

                    case "Ngày (Tháng 8)":


                        SqlCommand cmd9 = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 8 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader9 = cmd9.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 8");
                        series9.ChartType = SeriesChartType.Column;
                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series9.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader9.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader9["Ngay"]);
                            double tongTien = Convert.ToDouble(reader9["TongTien"]);

                            series9.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series9);

                        chartDoanhthu.Update();

                        reader9.Close();
                        connection.Close();

                        break;

                    case "Ngày (Tháng 9)":


                        SqlCommand cmd10 = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 9 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader10 = cmd10.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 9");
                        series10.ChartType = SeriesChartType.Column;
                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series10.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader10.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader10["Ngay"]);
                            double tongTien = Convert.ToDouble(reader10["TongTien"]);

                            series10.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series10);

                        chartDoanhthu.Update();

                        reader10.Close();
                        connection.Close();

                        break;

                    case "Ngày (Tháng 10)":


                        SqlCommand cmd11 = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 10 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader11 = cmd11.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 10");
                        series11.ChartType = SeriesChartType.Column;
                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series11.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader11.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader11["Ngay"]);
                            double tongTien = Convert.ToDouble(reader11["TongTien"]);

                            series11.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series11);

                        chartDoanhthu.Update();

                        reader11.Close();
                        connection.Close();

                        break;

                    case "Ngày (Tháng 11)":


                        SqlCommand cmd12 = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 11 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader12 = cmd12.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 11");
                        series12.ChartType = SeriesChartType.Column;
                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series12.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader12.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader12["Ngay"]);
                            double tongTien = Convert.ToDouble(reader12["TongTien"]);

                            series12.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series12);

                        chartDoanhthu.Update();

                        reader12.Close();
                        connection.Close();

                        break;

                    case "Ngày (Tháng 12)":


                        SqlCommand cmd13 = new SqlCommand("SELECT DAY(InvoiceDate) AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 12 GROUP BY DAY(InvoiceDate) ORDER BY DAY(InvoiceDate)", connection);

                        SqlDataReader reader13 = cmd13.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu tháng 12");
                        series13.ChartType = SeriesChartType.Column;
                        for (int i = 1; i <= 31; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series13.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader13.Read())
                        {
                            int ngayHoaDon = Convert.ToInt32(reader13["Ngay"]);
                            double tongTien = Convert.ToDouble(reader13["TongTien"]);

                            series13.Points[ngayHoaDon - 1].SetValueY(tongTien);

                        }

                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series13);

                        chartDoanhthu.Update();

                        reader13.Close();
                        connection.Close();

                        break;


                    case "Tháng":
                        // SqlConnection connection = new SqlConnection(connectionString);
                        SqlCommand cmd1 = new SqlCommand("SELECT MONTH(InvoiceDate) AS Tháng, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 GROUP BY MONTH(InvoiceDate) ORDER BY MONTH(InvoiceDate)", connection);
                        //  connection.Open();
                        SqlDataReader reader1 = cmd1.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu theo tháng");
                        series1.ChartType = SeriesChartType.Column;
                        for (int i = 1; i <= 12; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series1.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader1.Read())
                        {
                            int thangHoaDon = Convert.ToInt32(reader1["Tháng"]);
                            double tongTien = Convert.ToDouble(reader1["TongTien"]);

                            series1.Points[thangHoaDon - 1].SetValueY(tongTien); // Đặt giá trị y cho từng giá trị x tương ứng
                            //series1.Points.AddXY(ngayHoaDon, tongTien);
                        }
                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series1);
                        //    chartDoanhthu.ChartAreas[0].AxisY.Interval = 200000;
                        //    chartDoanhthu.ChartAreas[0].AxisY.LabelStyle.Format = "#,#";
                        chartDoanhthu.Update();

                        //  cbxDate_SelectedIndexChanged(sender, e);
                        reader1.Close();

                        break;
                    case "Năm":
                        SqlCommand cmd2 = new SqlCommand("SELECT YEAR(InvoiceDate) AS Năm, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1  GROUP BY YEAR(InvoiceDate) ORDER BY YEAR(InvoiceDate)", connection);
                        //  connection.Open();
                        SqlDataReader reader2 = cmd2.ExecuteReader();

                        System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh thu theo năm");
                        series2.ChartType = SeriesChartType.Column;
                        for (int i = 2015; i <= 2026; i++) // Thêm 12 giá trị cho trục ngang
                        {
                            series2.Points.AddXY(i, 0); // Giá trị y được đặt là 0 vì chúng ta sẽ thay đổi giá trị này sau này
                        }
                        while (reader2.Read())
                        {
                            int namHoaDon = Convert.ToInt32(reader2["Năm"]);
                            double tongTien = Convert.ToDouble(reader2["TongTien"]);

                            series2.Points.AddXY(namHoaDon, tongTien);
                        }
                        chartDoanhthu.Series.Clear();
                        chartDoanhthu.Series.Add(series2);


                        chartDoanhthu.Update();


                        reader2.Close();
                        break;
                }

            }
            connection.Close();
        }

        private void chartDoanhthu_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;

            // Tìm kiếm điểm dữ liệu ở gần tọa độ chuột nhất
            var hit = chartDoanhthu.HitTest(pos.X, pos.Y);

            // Nếu tìm thấy điểm dữ liệu là một cột
            if (hit.ChartElementType == ChartElementType.DataPoint && hit.Series.Points[hit.PointIndex].YValues[0] != 0)
            {
                // Lấy giá trị dữ liệu của cột
                double value = hit.Series.Points[hit.PointIndex].YValues[0];

                // Hiển thị giá trị dữ liệu trên đỉnh cột
                chartDoanhthu.Series[0].Points[hit.PointIndex].Label = value.ToString();
            }
        }

        private void chartDoanhthu_MouseLeave(object sender, EventArgs e)
        {
            // Xóa nhãn giá trị dữ liệu trên đỉnh cột khi chuột rời khỏi biểu đồ
            chartDoanhthu.Series[0].Points.ToList().ForEach(p => p.Label = "");
        }

        private void btnLapbaocao_Click(object sender, EventArgs e)
        {
            if (cbxDate.SelectedItem != null)
            {
                // Lấy giá trị được chọn từ combobox
                string selectedValue = cbxDate.SelectedItem.ToString();

                // Tạo câu truy vấn SQL tương ứng với giá trị được chọn từ combobox
                string query;
                switch (selectedValue)
                {
                    case "Ngày (Tháng 1)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 1 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    case "Ngày (Tháng 2)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 2 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    case "Ngày (Tháng 3)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 3 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    case "Ngày (Tháng 4)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 4 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    case "Ngày (Tháng 5)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 5 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    case "Ngày (Tháng 6)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 6 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    case "Ngày (Tháng 7)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 7 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    case "Ngày (Tháng 8)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 8 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    case "Ngày (Tháng 9)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 9 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    case "Ngày (Tháng 10)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 10 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    case "Ngày (Tháng 11)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 11 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    case "Ngày (Tháng 12)":
                        query = "SELECT InvoiceDate AS Ngay, SUM(TotalAmount1) AS TongTien FROM HoaDonBan1 WHERE DATEPART(month, InvoiceDate) = 12 GROUP BY InvoiceDate ORDER BY InvoiceDate";
                        break;
                    default:
                        MessageBox.Show("Vui lòng chọn lại mốc thời gian");
                        return;
                }

                // Kết nối tới SQL Server
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                // Thực hiện truy vấn SQL và đọc dữ liệu vào DataTable
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                // Đóng kết nối tới SQL Server
                connection.Close();

                // Kiểm tra nếu không có dữ liệu thì hiển thị thông báo
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất báo cáo");
                    return;
                }

                try
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel.Worksheet ws = null;
                    ws = wb.ActiveSheet;
                    ws.Name = "Doanh thu";
                    // Đặt kích thước cột đầu tiên là 50
                    ws.Range["A:A"].ColumnWidth = 35;

                    // Đặt kích thước các cột khác là 40
                    ws.Range["B:XFD"].ColumnWidth = 25;

                   
                    switch (selectedValue)
                    {
                        case "Ngày (Tháng 1)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 1:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = false;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        case "Ngày (Tháng 2)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 2:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = false;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        case "Ngày (Tháng 3)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 3:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = false;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        case "Ngày (Tháng 4)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 4:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = false;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        case "Ngày (Tháng 5)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 5:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = false;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        case "Ngày (Tháng 6)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 6:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = false;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        case "Ngày (Tháng 7)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 7:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = false;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        case "Ngày (Tháng 8)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 8:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = false;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        case "Ngày (Tháng 9)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 9:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = false;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        case "Ngày (Tháng 10)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 10:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = true;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        case "Ngày (Tháng 11)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 11:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = false;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        case "Ngày (Tháng 12)":
                            ws.Cells[1, 1].Value = "Báo cáo doanh thu tháng 12:";
                            // Set font style for a range of cells
                            ws.Cells[1, 1].Style.Font.Bold = false;
                            ws.Cells[1, 1].Style.Font.Size = 20;
                            break;
                        default:
                            MessageBox.Show("Vui lòng chọn lại mốc thời gian");
                            return;
                    }
                 
                    ws.Cells[3, 1].Value = "Thời gian";                  
                    ws.Cells[3, 2].Value = "Doanh thu";
                              
                    // Tiếp tục thêm tiêu đề cho các cột khác

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        ws.Cells[i + 4, 1].Value = dataTable.Rows[i]["Ngay"];
                        ws.Cells[i + 4, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        ws.Cells[i + 4, 1].Style.Font.Size = 12;// Canh giữa dữ liệu trong ô
                        ws.Cells[i + 4, 2].Value = dataTable.Rows[i]["TongTien"];
                        ws.Cells[i + 4, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Canh giữa dữ liệu trong ô
                        ws.Cells[i + 4, 2].Style.Font.Size = 12;
                        // Tiếp tục ghi dữ liệu cho các cột khác
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
                

                    // Hiển thị thông báo khi lưu file thành công
                  //  MessageBox.Show("Lưu file báo cáo thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");

                }
            }
        }            
    }
}
