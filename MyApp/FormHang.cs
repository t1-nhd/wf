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
using System.Xml.Linq;

namespace MyApp
{
    public partial class FormHang : Form
    {
        private readonly string connectionString = StaticResource.connectionString();
        private DataTable dataTable;
        private string maH;
        public FormHang()
        {
            InitializeComponent();
            LoadData();
        }

        public SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void LoadData(string tenH = "")
        {
            using (var con = getConnection())
            {
                con.Open();
                string query = @"
                        SELECT *
                        FROM Hang h
                        WHERE (@tenH = '' OR h.TenH LIKE '%' + @tenH + '%')
                        ORDER BY h.MaH DESC";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Thêm tham số với giá trị NULL nếu tham số không có giá trị
                    cmd.Parameters.AddWithValue("@tenH", tenH);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Hang");

                    dataTable = ds.Tables["Hang"];
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string donGia = row["DonGia"].ToString().Replace(".", "");
                        row["DonGia"] = Decimal.Parse(StaticResource.convertDecimalToIntString(row["DonGia"].ToString()));
                    }
                    dgv_hang.DataSource = dataTable;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain(StaticResource.getCurrentRole()).Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tenHangTb.Text = dgv_hang.Rows[e.RowIndex].Cells["TenH"].Value.ToString();
                donGiaTb.Value = Decimal.Parse((dgv_hang.Rows[e.RowIndex].Cells["DonGia"].Value.ToString()));
                maH = dgv_hang.Rows[e.RowIndex].Cells["MaH"].Value.ToString();
                maHtb.Text = maH;
            }
        }

        private void ClearForm()
        {
            tenHangTb.Text = "";
            donGiaTb.Value = donGiaTb.Minimum;
        }

        private string GetNewMaNB()
        {
            using (var con = getConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand("spNew_MaH", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Thêm tham số output để nhận mã NB mới
                    var outputParam = new SqlParameter("@new_MaH", SqlDbType.VarChar, 9)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    cmd.ExecuteNonQuery();
                    return outputParam.Value.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (var con = getConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand(query, con))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            if (tenHangTb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (dataTable.AsEnumerable().Any(row => row.Field<string>("TenH") == tenHangTb.Text))
                {
                    MessageBox.Show("Tên hàng vừa nhập đã tồn tại", "Thông báo");
                }
                else
                {
                    using (var connection = getConnection())
                    {
                        connection.Open();
                        string query = "INSERT INTO Hang VALUES (@MaH, @TenH, @DonGia)";
                        var parameters = new Dictionary<string, object>
                            {
                                { "@MaH", this.GetNewMaNB() },
                                { "@TenH", tenHangTb.Text },
                                { "@DonGia", donGiaTb.Value }
                            };

                        try
                        {
                            ExecuteNonQuery(query, parameters);
                            MessageBox.Show("Thêm sản phẩm mới thành công");
                            ClearForm();
                            LoadData();
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            if (tenHangTb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (dataTable.AsEnumerable().Any(row => row.Field<string>("TenH") == tenHangTb.Text))
                {
                    MessageBox.Show("Tên hàng vừa nhập đã tồn tại", "Thông báo");
                }
                else
                {
                    using (var connection = getConnection())
                    {
                        connection.Open();
                        string query = "UPDATE hang SET TenH=@TenH, DonGia=@DonGia WHERE MaH=@MaH";
                        var parameters = new Dictionary<string, object>
                            {
                                { "@MaH", this.maH },
                                { "@TenH", tenHangTb.Text },
                                { "@DonGia", donGiaTb.Value }
                            };

                        try
                        {
                            ExecuteNonQuery(query, parameters);
                            MessageBox.Show("Cập nhật sản phẩm thành công");
                            ClearForm();
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }
    }
}
