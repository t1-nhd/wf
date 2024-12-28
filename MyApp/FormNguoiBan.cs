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

namespace MyApp
{
    public partial class FormNguoiBan : Form
    {
        private readonly string connectionString = StaticResource.connectionString();
        public FormNguoiBan()
        {
            InitializeComponent();
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        //phương thức gọi thủ tục lấy mã người bán mới
        private string GetNewMaNB()
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand("spNew_MaNB", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Thêm tham số output để nhận mã NB mới
                    var outputParam = new SqlParameter("@new_MaNB", SqlDbType.VarChar, 9)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    cmd.ExecuteNonQuery();
                    return outputParam.Value.ToString();
                }
            }
        }

        //phương thức thêm mới người bán
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                // Lấy mã người bán mới từ thủ tục
                string newMaNB = GetNewMaNB();
                txtMaNB.Text = newMaNB; // Hiển thị mã mới trong form (nếu cần)

                string query = "INSERT INTO NguoiBan VALUES (@MaNB, @TenNB, @DiaChi)";
                var parameters = new Dictionary<string, object>
                {
                    { "@MaNB", newMaNB },
                    { "@TenNB", txtTenNB.Text },
                    { "@DiaChi", txtDiaChi.Text }
                };

                ExecuteNonQuery(query, parameters);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm mới không thành công: " + ex.Message, "Thông báo lỗi");
            }
        }


        // Phương thức thực thi câu lệnh không trả về dữ liệu
        private void ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (var con = GetConnection())
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

        // Phương thức kiểm tra dữ liệu đầu vào
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtTenNB.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return false;
            }
            return true;
        }

        // Phương thức xóa dữ liệu trong form
        private void ClearForm()
        {
            txtMaNB.Text = "";
            txtTenNB.Text = "";
            txtDiaChi.Text = "";
            txtMaNB.Enabled = true;
        }

        // Phương thức tải dữ liệu vào DataGridView
        private void LoadData()
        {
            using (var con = GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM NguoiBan nb order by nb.MaNB DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "NguoiBan");
                dataGridView1.DataSource = ds.Tables["NguoiBan"];
            }
        }

        private void FormNguoiBan_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Thông báo lỗi");
            }
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            string query = "UPDATE NguoiBan SET TenNB=@TenNB, DiaChi=@DiaChi WHERE MaNB=@MaNB";
            var parameters = new Dictionary<string, object>
            {
                { "@MaNB", txtMaNB.Text },
                { "@TenNB", txtTenNB.Text },
                { "@DiaChi", txtDiaChi.Text }
            };

            try
            {
                ExecuteNonQuery(query, parameters);
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công: " + ex.Message, "Thông báo lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNB.Text))
            {
                MessageBox.Show("Vui lòng nhập mã người bán để xóa!", "Thông báo");
                return;
            }

            DialogResult ret = MessageBox.Show("Bạn chắc chắn muốn xóa người bán này?", "Thông báo", MessageBoxButtons.OKCancel);
            if (ret == DialogResult.OK)
            {
                string query = "DELETE FROM NguoiBan WHERE MaNB = @MaNB";
                var parameters = new Dictionary<string, object>
                {
                    { "@MaNB", txtMaNB.Text }
                };

                try
                {
                    ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    ClearForm();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công: " + ex.Message, "Thông báo lỗi");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng nhấp vào hàng hợp lệ
            {
                txtMaNB.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNB"].Value.ToString();
                txtTenNB.Text = dataGridView1.Rows[e.RowIndex].Cells["TenNB"].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtMaNB.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain(StaticResource.getCurrentRole()).Show();
        }
    }
}
