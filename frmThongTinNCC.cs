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

namespace QuanLiTiemTapHoa
{
    public partial class frmThongTinNCC : Form
    {
        private readonly string _maNCC;

        // Chuỗi kết nối: thêm Encrypt=False để tránh lỗi SSL
        private const string Cnn =
            @"Server=.;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;";

        public frmThongTinNCC(string maNCC)
        {
            _maNCC = maNCC;
            InitializeComponent();

            Load += Frm_Load;
            btnClose.Click += (_, __) => Close();
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        //  Load dữ liệu NCC khi form mở
        //
        private void Frm_Load(object? sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            using var cmd = new SqlCommand(
                "SELECT MaNCC, TenNCC, SDT, DiaChi FROM NhaCungCap WHERE MaNCC = @ma", cnn);

            cmd.Parameters.AddWithValue("@ma", _maNCC);

            cnn.Open();
            using var rd = cmd.ExecuteReader();

            if (!rd.Read()) return;

            txtMaNCC.Text = rd.GetString(0);
            txtTenNCC.Text = rd.GetString(1);
            txtSDT.Text = rd.GetString(2);
            txtDiaChi.Text = rd.GetString(3);

            // Cho phép chỉnh sửa
            txtTenNCC.ReadOnly = false;
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
                "UPDATE NhaCungCap " +
                "SET TenNCC=@ten, SDT=@sdt, DiaChi=@dc " +
                "WHERE MaNCC=@ma";

            using var cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ma", _maNCC);
            cmd.Parameters.AddWithValue("@ten", txtTenNCC.Text.Trim());
            cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
            cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text.Trim());

            cnn.Open();
            int rows = cmd.ExecuteNonQuery();

            MessageBox.Show(rows > 0
                    ? "Đã cập nhật nhà cung cấp."
                    : "Cập nhật không thành công.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 
        //  Xóa NCC
        // 
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa nhà cung cấp này?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using var cnn = new SqlConnection(Cnn);
            using var cmd = new SqlCommand(
                "DELETE FROM NhaCungCap WHERE MaNCC = @ma", cnn);

            cmd.Parameters.AddWithValue("@ma", _maNCC);

            cnn.Open();
            int rows = cmd.ExecuteNonQuery();

            MessageBox.Show(rows > 0
                    ? "Đã xóa nhà cung cấp."
                    : "Xóa thất bại.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (rows > 0) Close();
        }
    }
}
