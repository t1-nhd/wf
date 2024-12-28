using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyApp
{
    public partial class FormTaiKhoan : Form
    {
        private readonly string connectionString = StaticResource.connectionString();

        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
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

        private void ClearForm()
        {
            loginNameTb.Text = "";
            userNameTb.Text = "";
            roleCb.SelectedIndex = -1;
        }

        private void LoadData(string LGName = "", string UserName = "", string Role_user = "")
        {
            using (var con = getConnection())
            {
                con.Open();
                string query = @"
                        SELECT tk.LGName, tk.UserName, tk.Role_user
                        FROM TaiKhoan tk
                        WHERE (@LGName = '' OR tk.LGName LIKE '%' + @LGName + '%')
                        AND (@UserName = '' OR tk.UserName LIKE '%' + @UserName + '%')
                        AND (@Role_user = '' OR tk.Role_user LIKE '%' + @Role_user + '%')
                        ORDER BY tk.LGName ASC";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Thêm tham số với giá trị NULL nếu tham số không có giá trị
                    cmd.Parameters.AddWithValue("@LGName", LGName);
                    cmd.Parameters.AddWithValue("@UserName", UserName);
                    cmd.Parameters.AddWithValue("@Role_user", Role_user);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "TaiKhoan");
                    dgv_taiKhoan.DataSource = ds.Tables["TaiKhoan"];
                }
            }
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            if (!isClear())
            {
                Dictionary<string, string> request = getRequestData();
                LoadData(request["lgName"], request["userName"], request["role"]);
            }
        }

        private void dgv_taiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo người dùng nhấp vào hàng hợp lệ
            {
                string lgName = dgv_taiKhoan.Rows[e.RowIndex].Cells["LGName"].Value.ToString();
                loginNameTb.Text = lgName;
                userNameTb.Text = dgv_taiKhoan.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                roleCb.SelectedIndex = convertUserRole(dgv_taiKhoan.Rows[e.RowIndex].Cells["Role_user"].Value.ToString());

                this.loginNameTb.Enabled = false;
                this.updateBt.Enabled = true;

                if (lgName != StaticResource.getCurrentUser())
                {
                    this.deleteBt.Enabled = true;
                }
                else
                {
                    this.deleteBt.Enabled = false;
                }
            }
        }

        private int convertUserRole(string userRole)
        {
            switch (userRole)
            {
                case "Director": return 0;
                case "Inspection_staff": return 1;
                case "Sales_staff": return 2;
                case "Accountant": return 3;
                default: return -1;
            }
        }

        private Dictionary<string, string> getRequestData()
        {

            Dictionary<string, string> ls = new Dictionary<string, string>();
            ls["lgName"] = this.loginNameTb.Text;
            ls["userName"] = this.userNameTb.Text;
            ls["role"] = this.roleCb.Text;
            return ls;
        }

        private bool isClear()
        {
            if (this.loginNameTb.Text.Length == 0 &&
                this.userNameTb.Text.Length == 0 &&
                this.roleCb.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }

        private bool isAllFilled()
        {
            if (this.loginNameTb.Text.Length > 0 &&
                this.userNameTb.Text.Length > 0 &&
                this.roleCb.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }

        private void resetBt_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.loginNameTb.Enabled = true;
            LoadData();
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            if (!isAllFilled())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                Dictionary<string, string> request = getRequestData();
                using (var connection = getConnection())
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("sp_TaoTaiKhoan", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@LGName", request["lgName"]);
                    cmd.Parameters.AddWithValue("@Pass", "123");
                    cmd.Parameters.AddWithValue("@UserName", request["userName"]);
                    cmd.Parameters.AddWithValue("@Role", request["role"]);

                    SqlParameter retParam = new SqlParameter
                    {
                        ParameterName = "@ret",
                        SqlDbType = SqlDbType.Bit,
                        Direction = ParameterDirection.ReturnValue
                    };
                    retParam.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(retParam);

                    // Thực thi thủ tục
                    try
                    {
                        cmd.ExecuteNonQuery();

                        string message = string.Format(
                            "Thêm tài khoản thành công, thông tin tài khoản mới:\n" +
                            "- Login: {0}\n" +
                            "- Username: {1}\n" +
                            "- Role: {2}\n" +
                            "- Password: 123",
                            request["lgName"], request["userName"], request["role"]);
                        MessageBox.Show(message);
                        ClearForm();
                        LoadData();
                    }
                    catch
                    {
                        if ((int)retParam.Value == 1)
                        {
                            MessageBox.Show("Login name đã tồn tại! Vui lòng thử lại!");
                        }
                        if ((int)retParam.Value == 2)
                        {
                            MessageBox.Show("User name đã tồn tại! Vui lòng thử lại");
                        }
                    }
                }
            }
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMain(StaticResource.getCurrentRole()).Show();
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            if (!isAllFilled())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                Dictionary<string, string> request = getRequestData();
                using (var connection = getConnection())
                {
                    connection.Open();

                    string query = "UPDATE TaiKhoan SET UserName=@userName, Role_user=@role WHERE LGName=@lgName";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@lgName", request["lgName"]},
                        { "@userName" , request["userName"] },
                        { "@role" , request["role"] }
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
            }
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xóa tài khoản", MessageBoxButtons.OKCancel);
            string query = "DELETE FROM TaiKhoan WHERE LGName = @lgName";

            Dictionary<string, string> request = getRequestData();
            var parameters = new Dictionary<string, object>
            {
                { "@lgName", request["lgName"]},
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
}
