 using MyApp.Model;
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
using MyApp.Repository;

namespace MyApp
{
    public partial class FormNhap : Form
    {
        private string connectionString = StaticResource.connectionString();
        SqlConnection connection;
        DataTable dataTable;
        NhapRepository nhapRepository = new NhapRepository();
        HangRepository hangRepository = new HangRepository();

        public FormNhap()
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
                List<Nhap> nhaps = nhapRepository.getListNhap();
                dataTable = new DataTable();

                dataTable.Columns.Add("MaHD");
                dataTable.Columns.Add("TenNB");
                dataTable.Columns.Add("NgayNhap");
                dataTable.Columns.Add("CongTH");
                dataTable.Columns.Add("ThueSuatGTGT");
                dataTable.Columns.Add("TongTT");

                foreach (Nhap nhap in nhaps)
                {
                    var row = dataTable.NewRow();

                    row["MaHD"] = nhap.MaHD;
                    row["TenNB"] = nhapRepository.getTenNB(nhap.MaNB);
                    row["NgayNhap"] = nhap.NgayNhap.ToString("dd/MM/yyyy");
                    row["CongTH"] = nhap.CongTH;
                    row["ThueSuatGTGT"] = nhap.ThueSuatGTGT;
                    row["TongTT"] = nhap.TongTT;

                    dataTable.Rows.Add(row);
                }

                this.dataGridNhap.DataSource = dataTable;
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

        private void button1_Click(object sender, EventArgs e)
        {
            new frmMain(StaticResource.getCurrentRole()).Show();
            this.Close();
        }

        private void createXuatBt_Click(object sender, EventArgs e)
        {
            FormThemNhap formThemNhap = new FormThemNhap();
            formThemNhap.CreateSuccessfully += new EventHandler(FormCreateHoaDonNhap_CreateSuccessfully);
            formThemNhap.Show();
            this.Hide();
        }
        private void FormCreateHoaDonNhap_CreateSuccessfully(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridNhap_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHD = dataGridNhap.Rows[e.RowIndex].Cells["MaHD"].Value.ToString();
                List<NhapChiTiet> ncts = nhapRepository.getListNhapChiTiet(maHD);
                try
                {
                    connection.Open();
                    DataTable nhapDT = new DataTable();

                    nhapDT.Columns.Add("STT");
                    nhapDT.Columns.Add("TenH");
                    nhapDT.Columns.Add("DonGia");
                    nhapDT.Columns.Add("SoLuong");
                    nhapDT.Columns.Add("ThanhTien");

                    int index = 0;
                    foreach (NhapChiTiet nct in ncts)
                    {
                        var row = nhapDT.NewRow();
                        Hang hang = hangRepository.getHang(nct.MaH);

                        row["STT"] = ++index;
                        row["TenH"] = hang.TenH;
                        row["DonGia"] = StaticResource.vndMoneyFormat(Decimal.Parse(StaticResource.convertDecimalToIntString(hang.DonGia.ToString())));
                        row["SoLuong"] = nct.SoLuong;
                        row["ThanhTien"] = StaticResource.vndMoneyFormat(Decimal.Parse(StaticResource.convertDecimalToIntString((hang.DonGia * nct.SoLuong).ToString())));

                        nhapDT.Rows.Add(row);
                    }
                    FormCTHD formCTHD = new FormCTHD(nhapDT, "Hóa đơn nhập " + maHD);
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
