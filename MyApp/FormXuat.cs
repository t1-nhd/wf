using MyApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyApp.Model;

namespace MyApp
{
    public partial class FormXuat : Form
    {
        string connectionString = StaticResource.connectionString();
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dataTable;
        XuatRepository xuatRepository = new XuatRepository();
        HangRepository hangRepository = new HangRepository();
        KhachHangRepository KhachHangRepository = new KhachHangRepository();

        public FormXuat()
        {
            InitializeComponent();
            InitConnectDb();
            loadData();
        }

        public void InitConnectDb()
        {
            connection = new SqlConnection(connectionString);
        }

        public void loadData()
        {
            try
            {
                connection.Open();
                adapter = new SqlDataAdapter("select * from Xuat x order by x.MaHDX DESC", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                dataTable = new DataTable();
                adapter.Fill(dataTable);
                this.dataTableChangeFormat(dataTable);

                this.dataTable.Columns["MaKH"].ColumnName = "TenKH";
                this.dataGridXuat.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Failed to load data" + ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public void dataTableChangeFormat(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                string maKH = row["MaKH"].ToString();
                string tenKH = KhachHangRepository.getTenKH(maKH);
                row["MaKH"] = tenKH; // Thay thế giá trị MaNB bằng TenNB }

                DateTime ngayNX = (DateTime)row["NgayXK"];
                row["NgayXK"] = ngayNX.ToString("dd/MM/yyyy");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmMain(StaticResource.getCurrentRole()).Show();
            this.Close();
        }

        private void createXuatBt_Click(object sender, EventArgs e)
        {
            FormThemXuat formThemXuat = new FormThemXuat();
            formThemXuat.Show();
            formThemXuat.CreateSuccessfully += new EventHandler(FormCreateHoaDonXuat_CreateSuccessfully);
            this.Hide();
        }

        private void FormCreateHoaDonXuat_CreateSuccessfully(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridXuat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHDX = dataGridXuat.Rows[e.RowIndex].Cells["MaHDX"].Value.ToString();
                List<XuatChiTiet> ncts = xuatRepository.getListXuatChiTiet(maHDX);
                try
                {
                    connection.Open();
                    DataTable xuatDT = new DataTable();

                    xuatDT.Columns.Add("STT");
                    xuatDT.Columns.Add("TenH");
                    xuatDT.Columns.Add("DonGia");
                    xuatDT.Columns.Add("SoLuong");
                    xuatDT.Columns.Add("ThanhTien");

                    int index = 0;
                    foreach (XuatChiTiet nct in ncts)
                    {
                        var row = xuatDT.NewRow();
                        Hang hang = hangRepository.getHang(nct.MaH);

                        row["STT"] = ++index;
                        row["TenH"] = hang.TenH;
                        row["DonGia"] = StaticResource.vndMoneyFormat(Decimal.Parse(StaticResource.convertDecimalToIntString(hang.DonGia.ToString())));
                        row["SoLuong"] = nct.SoLuong;
                        row["ThanhTien"] = StaticResource.vndMoneyFormat(Decimal.Parse(StaticResource.convertDecimalToIntString((hang.DonGia * nct.SoLuong).ToString())));

                        xuatDT.Rows.Add(row);
                    }
                    FormCTHD formCTHD = new FormCTHD(xuatDT, "Hóa đơn xuất " + maHDX);
                    formCTHD.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Failed to load data" + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
