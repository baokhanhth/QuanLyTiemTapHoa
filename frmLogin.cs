using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            labelError.Visible = false;
        }
        public void ResetForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                labelError.Text = "Vui lòng nhập đầy đủ thông tin đăng nhập.";
                labelError.Visible = true;
                return;
            }

            string connStr = $"Data Source=Arus\\BAOKHANH;Initial Catalog=QuanLyBanHang;" +
                             $"User ID={username};Password={password};TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Lấy login name hiện tại
                    string sql = "SELECT SUSER_SNAME();";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    string currentLogin = (string)cmd.ExecuteScalar();

                    if (currentLogin == "ChuTiem")
                    {
                        // Gán tên hiển thị
                        string displayName = "CHỦ TIỆM";

                        this.Hide();
                        frmMain frm = new frmMain(displayName);
                        frm.Show();
                    }
                    else
                    {
                        labelError.Visible = true;
                        ResetForm();
                    }
                }
                catch (Exception ex)
                {
                    labelError.Visible = true;
                    ResetForm();
                }
            }
        }
    }
}
