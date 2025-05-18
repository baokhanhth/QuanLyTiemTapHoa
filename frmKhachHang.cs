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
    public partial class frmKhachHang : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True;TrustServerCertificate=True";

        public frmKhachHang()
        {
            InitializeComponent();
            this.Load += frmKhachHang_Load;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmLoginInstance.ResetForm(); 
            Program.frmLoginInstance.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemKhachHang themForm = new frmThemKhachHang(this);
            themForm.ShowDialog();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            dgvKhachHang.CellDoubleClick += dgvKhachHang_CellDoubleClick;
        }

        public void LoadKhachHang()
        {
            string query = "SELECT * FROM KhachHang";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKhachHang.DataSource = dt;
                dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 12, FontStyle.Bold);
                dgvKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvKhachHang.ColumnHeadersHeight = 60;
                dgvKhachHang.RowTemplate.Height = 60;
                dgvKhachHang.DefaultCellStyle.Font = new Font("Open Sans", 10, FontStyle.Regular); 

                dgvKhachHang.Columns["DiaChi"].Width = 400;
                dgvKhachHang.Columns["SDT_KH"].Width = 200;
                dgvKhachHang.Columns["TenKH"].Width = 300;



                dgvKhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
                dgvKhachHang.Columns["MaKH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
                dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvKhachHang.Columns["SDT_KH"].HeaderText = "Số Điện Thoại";
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            string query = "";

            if (string.IsNullOrEmpty(keyword))
            {
                LoadKhachHang(); // Hiển thị lại toàn bộ nếu không nhập gì
                return;
            }

            // Tùy chọn logic nếu bạn muốn khác
            if (keyword.StartsWith("KH", StringComparison.OrdinalIgnoreCase) &&
                keyword.Length > 2 &&
                keyword.Substring(2).All(char.IsDigit))
            {
                query = "SELECT * FROM KhachHang WHERE MaKH LIKE @kw";
            }
            else
            {
                query = "SELECT * FROM KhachHang WHERE TenKH LIKE @kw";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKhachHang.DataSource = dt;

            }
        }
        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;  // header

            // Lấy DataRow hiện tại
            DataRowView row = (DataRowView)dgvKhachHang.Rows[e.RowIndex].DataBoundItem;
            string maKH = row["MaKH"].ToString();
            string tenKH = row["TenKH"].ToString();
            string diaChi = row["DiaChi"].ToString();
            string sdt = row["SDT_KH"].ToString();

            // Mở form chi tiết, truyền dữ liệu qua constructor hoặc properties
            var frm = new frmThongTinKhachHang(maKH, tenKH, diaChi, sdt);
            frm.ShowDialog();

            // Sau khi form đóng, load lại danh sách để cập nhật thay đổi
            LoadKhachHang();
        }

    }
}
