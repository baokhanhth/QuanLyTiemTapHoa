using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;   // sử dụng provider mới

namespace QuanLyTiemTapHoa
{
    public partial class frmThongTinKhachHang : Form
    {
        private readonly string _maKH;

        // Chuỗi kết nối: thêm Encrypt=False để tránh lỗi SSL
        private const string Cnn =
            @"Server=.;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;";

        public frmThongTinKhachHang(string maKH, string tenKH, string diaChi, string sdt)
        {
            InitializeComponent();
            _maKH = maKH;

            // Gán lên các TextBox trên form
            txtMaKH.Text = maKH;
            txtTenKH.Text = tenKH;
            txtDiaChi.Text = diaChi;
            txtSDT.Text = sdt;
            Load += Frm_Load;
            btnClose.Click += (_, __) => Close();
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        //  Load dữ liệu khách hàng khi form mở
        //
        private void Frm_Load(object? sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            using var cmd = new SqlCommand(
                "SELECT MaKH, TenKH, SDT_KH, DiaChi FROM KhachHang WHERE MaKH = @ma", cnn);

            cmd.Parameters.AddWithValue("@ma", _maKH);

            cnn.Open();
            using var rd = cmd.ExecuteReader();

            if (!rd.Read()) return;

            txtMaKH.Text = rd.IsDBNull(0) ? "" : rd.GetString(0);
            txtTenKH.Text = rd.IsDBNull(1) ? "" : rd.GetString(1);
            txtSDT.Text = rd.IsDBNull(2) ? "" : rd.GetString(2);
            txtDiaChi.Text = rd.IsDBNull(3) ? "" : rd.GetString(3);

            // Cho phép chỉnh sửa
            txtTenKH.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
        }

        // 
        //  Cập nhật khách hàng
        // 
        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            const string sql =
                "UPDATE KhachHang " +
                "SET TenKH=@ten, SDT_KH=@sdt, DiaChi=@dc " +
                "WHERE MaKH=@ma";

            using var cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ma", _maKH);
            cmd.Parameters.AddWithValue("@ten", txtTenKH.Text.Trim());
            cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
            cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text.Trim());

            cnn.Open();
            int rows = cmd.ExecuteNonQuery();

            MessageBox.Show(rows > 0
                    ? "Đã cập nhật khách hàng."
                    : "Cập nhật không thành công.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 
        //  Xóa khách hàng
        // 
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa khách hàng này?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using var cnn = new SqlConnection(Cnn);
            using var cmd = new SqlCommand(
                "DELETE FROM KhachHang WHERE MaKH = @ma", cnn);

            cmd.Parameters.AddWithValue("@ma", _maKH);

            cnn.Open();
            int rows = cmd.ExecuteNonQuery();

            MessageBox.Show(rows > 0
                    ? "Đã xóa khách hàng."
                    : "Xóa thất bại.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (rows > 0) Close();
        }
    }
}
