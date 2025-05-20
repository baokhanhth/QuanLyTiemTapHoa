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
    public partial class frmThongTinTongNo: Form
    {
        private readonly string _maNo;
        private const string Cnn =
            @"Server=.;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;";
        public frmThongTinTongNo(string maNo)
        {
            _maNo = maNo;
            InitializeComponent();

            Load += Frm_Load;
            btnClose.Click += (_, __) => Close();
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        //  Load dữ liệu CTN khi form mở
        //
        private void Frm_Load(object? sender, EventArgs e)
        {
            try
            {
                using var cnn = new SqlConnection(Cnn);
                using var cmd = new SqlCommand(
                    "SELECT MaNo, MaKH, TongNo, TrangThai FROM TongNo WHERE MaNo = @ma", cnn);

                cmd.Parameters.AddWithValue("@ma", _maNo);

                cnn.Open();
                using var rd = cmd.ExecuteReader();

                if (!rd.Read())
                {
                    MessageBox.Show("Không tìm thấy dữ liệu với mã nợ: " + _maNo);
                    return;
                }

                txtMaNo.Text = rd.GetString(0);
                txtMaKH.Text = rd.GetString(1);
                txtTongNo.Text = rd.GetDecimal(2).ToString();
                txtTrangThai.Text = rd.GetString(3);

                txtMaNo.ReadOnly = false;
                txtMaKH.ReadOnly = false;
                txtTongNo.ReadOnly = false;
                txtTrangThai.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        // 
        //  Cập nhật tổng nợ
        // 
        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            const string sql =
                "UPDATE TongNo " +
                "SET MaNo=@mano, MaKH=@makh, TongNo=@tongno, TrangThai=@trangthai " +
                "WHERE MaNo=@ma";

            using var cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@mano", txtMaNo.Text.Trim());
            cmd.Parameters.AddWithValue("@makh", txtMaKH.Text.Trim());
            cmd.Parameters.AddWithValue("@tongno", txtTongNo.Text.Trim());
            cmd.Parameters.AddWithValue("@trangthai", txtTrangThai.Text.Trim());

            if (!decimal.TryParse(txtTongNo.Text.Trim(), out var soTien))
            {
                MessageBox.Show("Tổng nợ không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmd.Parameters.AddWithValue("@tongno", soTien);

            cmd.Parameters.AddWithValue("@ma", _maNo);

            cnn.Open();
            int rows = cmd.ExecuteNonQuery();

            MessageBox.Show(rows > 0
                    ? "Đã cập nhật tổng nợ."
                    : "Cập nhật không thành công.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // 
        //  Xóa tổng nợ
        // 
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa tổng nợ này?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using var cnn = new SqlConnection(Cnn);
            using var cmd = new SqlCommand(
                "DELETE FROM TongNo WHERE MaNo = @ma", cnn);

            cmd.Parameters.AddWithValue("@ma", _maNo);

            cnn.Open();
            int rows = cmd.ExecuteNonQuery();

            MessageBox.Show(rows > 0
                    ? "Đã xóa tổng nợ."
                    : "Xóa thất bại.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (rows > 0) Close();
        }

        private void txtTongNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
