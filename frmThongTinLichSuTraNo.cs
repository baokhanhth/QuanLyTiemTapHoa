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
    public partial class frmThongTinLichSuTraNo: Form
    {
        private readonly string _maNo;
        private const string Cnn =
            @"Server=.;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;";
        public frmThongTinLichSuTraNo(string maNo)
        {
            _maNo = maNo;
            InitializeComponent();

            Load += Frm_Load;
            btnClose.Click += (_, __) => Close();
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        //  Load dữ liệu LSTN khi form mở
        //
        private void Frm_Load(object? sender, EventArgs e)
        {
            try
            {
                using var cnn = new SqlConnection(Cnn);
                using var cmd = new SqlCommand(
                    "SELECT MaNo, NgayTra, SoTienTra FROM LichSuTraNo WHERE MaNo = @ma", cnn);

                cmd.Parameters.AddWithValue("@ma", _maNo);

                cnn.Open();
                using var rd = cmd.ExecuteReader();

                if (!rd.Read())
                {
                    MessageBox.Show("Không tìm thấy dữ liệu với mã nợ: " + _maNo);
                    return;
                }

                txtMaNo.Text = rd.GetString(0);
                txtNgayTra.Text = rd.GetString(1);
                txtSoTienTra.Text = rd.GetDecimal(2).ToString();

                txtMaNo.ReadOnly = false;
                txtSoTienTra.ReadOnly = false;
                txtNgayTra.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        // 
        //  Cập nhật LSTN
        // 
        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            const string sql =
                "UPDATE LichSuTraNo " +
                "SET MaNo=@mano, NgayTra=@ngaytra, SoTienTra=@stt " +
                "WHERE MaNo=@ma";

            using var cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@mano", txtMaNo.Text.Trim());
            cmd.Parameters.AddWithValue("@ngaytra", txtNgayTra.Text.Trim());
            cmd.Parameters.AddWithValue("@stt", txtSoTienTra.Text.Trim());

            if (!decimal.TryParse(txtSoTienTra.Text.Trim(), out var soTien))
            {
                MessageBox.Show("Số tiền trả không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmd.Parameters.AddWithValue("@stt", soTien);

            cmd.Parameters.AddWithValue("@ma", _maNo);

            cnn.Open();
            int rows = cmd.ExecuteNonQuery();

            MessageBox.Show(rows > 0
                    ? "Đã cập nhật lịch sử trả nợ."
                    : "Cập nhật không thành công.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // 
        //  Xóa LSTN
        // 
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa lịch sử trả nợ này?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using var cnn = new SqlConnection(Cnn);
            using var cmd = new SqlCommand(
                "DELETE FROM LichSuTraNo WHERE MaNo = @ma", cnn);

            cmd.Parameters.AddWithValue("@ma", _maNo);

            cnn.Open();
            int rows = cmd.ExecuteNonQuery();

            MessageBox.Show(rows > 0
                    ? "Đã xóa lịch sử trả nợ."
                    : "Xóa thất bại.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (rows > 0) Close();
        }

        private void txtSoTienTra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayTra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
