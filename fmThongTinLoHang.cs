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
    public partial class frmThongTinLoHang : Form
    {
        private readonly string _maLo;
  

        // Chuỗi kết nối: thêm Encrypt=False để tránh lỗi SSL
        private const string Cnn =
            @"Server=.;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;";

        public frmThongTinLoHang(string maLo)
        {
            _maLo = maLo;
            InitializeComponent();

            Load += Frm_Load;
            btnClose.Click += (_, __) => Close();
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        //  Load dữ liệu LoHang khi form mở
        //
        private void Frm_Load(object? sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            using var cmd = new SqlCommand(
                "SELECT MaLo, MaHang, NgaySX, HSD, SoLuongDongGoi FROM LoHang WHERE MaLo = @ma", cnn);

            cmd.Parameters.AddWithValue("@ma", _maLo);

            cnn.Open();
            using var rd = cmd.ExecuteReader();

            if (!rd.Read()) return;

            txtMaLo.Text = rd.GetString(0);
            txtMaHang.Text = rd.GetString(1);
            txtNgaySX.Text = rd.GetDateTime(2).ToString("yyyy-MM-dd");  // hoặc định dạng khác tùy ý
            txtHSD.Text = rd.GetDateTime(3).ToString("yyyy-MM-dd");
            txtSoLuongDongGoi.Text = rd.GetInt32(4).ToString();


            // Cho phép chỉnh sửa
            txtMaHang.ReadOnly = false;
            txtNgaySX.ReadOnly = false;
            txtHSD.ReadOnly = false;
            txtSoLuongDongGoi.ReadOnly = false;
        }

        // 
        //  Cập nhật lô hàng
        // 
        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            const string sql =
                "UPDATE LoHang " +
                "SET MaHang=@mahang, MaLo=@malo, NgaySX=@ngaysx, HSD=@hsd, SoLuongDongGoi=@sldg " +
                "WHERE Malo=@ma";

            using var cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ma", _maLo);
            cmd.Parameters.AddWithValue("@mahang", txtMaHang.Text.Trim());
            cmd.Parameters.AddWithValue("@ngaysx", txtNgaySX.Text.Trim());
            cmd.Parameters.AddWithValue("@hsd", txtHSD.Text.Trim());
            cmd.Parameters.AddWithValue("@sldg", txtSoLuongDongGoi.Text.Trim());

            cnn.Open();
            int rows = cmd.ExecuteNonQuery();

            MessageBox.Show(rows > 0
                    ? "Đã cập nhật lô hàng."
                    : "Cập nhật không thành công.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 
        //  Xóa LÔ Hàng
        // 
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa lô hàng này?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using var cnn = new SqlConnection(Cnn);
            using var cmd = new SqlCommand(
                "DELETE FROM Lohang WHERE MaLo = @ma", cnn);

            cmd.Parameters.AddWithValue("@ma", _maLo);

            cnn.Open();
            int rows = cmd.ExecuteNonQuery();

            MessageBox.Show(rows > 0
                    ? "Đã xóa lô hàng."
                    : "Xóa thất bại.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (rows > 0) Close();
        }
    }
}
