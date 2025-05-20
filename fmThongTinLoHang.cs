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
        // Chuỗi kết nối đến SQL Server (thay bằng của bạn)
        private string connectionString = "Data Source=SERVER_NAME;Initial Catalog=DATABASE_NAME;Integrated Security=True";

        // Constructor nhận các tham số và gán vào các điều khiển
        public frmThongTinLoHang(string maLo, string maHang, DateTime ngaySX, DateTime hsd, int soLuong)
        {
            InitializeComponent(); // Khởi tạo các điều khiển (designer-generated)

            // Gán giá trị vào TextBox/DateTimePicker
            txtMaLo.Text = maLo;
            txtMaHang.Text = maHang;
            txtNgaySX.Value = ngaySX;
            txtHSD.Value = hsd;
            txtMaLo.Text = soLuong.ToString();
        }

        // Xử lý sự kiện bấm nút Cập nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Lấy giá trị mới từ các điều khiển
            string maLo = txtMaLo.Text;
            string maHang = txtMaHang.Text;
            DateTime ngaySX = txtNgaySX.Value.Date;
            DateTime hsd = txtHSD.Value.Date;
            int soLuong;
            if (!int.TryParse(txtMaLo.Text, out soLuong))
            {
                MessageBox.Show("Giá trị Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        UPDATE LoHang 
                        SET MaHang=@MaHang, NgaySX=@NgaySX, HSD=@HSD, SoLuongDongGoi=@SoLuong 
                        WHERE MaLo=@MaLo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số để tránh SQL Injection
                        cmd.Parameters.AddWithValue("@MaHang", maHang);
                        cmd.Parameters.AddWithValue("@NgaySX", ngaySX);
                        cmd.Parameters.AddWithValue("@HSD", hsd);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@MaLo", maLo);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Không tìm thấy bản ghi cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện bấm nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLo = txtMaLo.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM LoHang WHERE MaLo=@MaLo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLo", maLo);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Không tìm thấy bản ghi cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    //public partial class frmThongTinLoHang : Form
    //{
    //    private readonly string _maLo;


    //    // Chuỗi kết nối: thêm Encrypt=False để tránh lỗi SSL
    //    private const string Cnn =
    //        @"Server=.;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;";

    //    public frmThongTinLoHang(string maLo,string maHang, DateTime ngaySX, DateTime hsd,int soLuong)
    //    {
    //        _maLo = _maLo;
    //        InitializeComponent();

    //        Load += Frm_Load;
    //        btnClose.Click += (_, __) => Close();
    //        btnUpdate.Click += BtnUpdate_Click;
    //        btnDelete.Click += BtnDelete_Click;
    //        string malo = dgvLoHang.Rows[e.RowIndex].Cells["MaLo"].Value.ToString();
    //        var frm = new frmThongTinLoHang(maLo);
    //        frm.ShowDialog();

    //    }

    //    //  Load dữ liệu LoHang khi form mở
    //    //
    //    private void Frm_Load(object? sender, EventArgs e)
    //    {
    //        using var cnn = new SqlConnection(Cnn);
    //        using var cmd = new SqlCommand(
    //            "SELECT MaLo, MaHang, NgaySX, HSD, SoLuongDongGoi FROM LoHang WHERE MaLo = @ma", cnn);

    //        cmd.Parameters.AddWithValue("@ma", _maLo);

    //        cnn.Open();
    //        using var rd = cmd.ExecuteReader();

    //        if (!rd.Read()) return;

    //        txtMaLo.Text = rd.GetString(0);
    //        txtMaHang.Text = rd.GetString(1);
    //        txtNgaySX.Text = rd.GetDateTime(2).ToString("yyyy-MM-dd");  // hoặc định dạng khác tùy ý
    //        txtHSD.Text = rd.GetDateTime(3).ToString("yyyy-MM-dd");
    //        txtSoLuongDongGoi.Text = rd.GetInt32(4).ToString();


    //        // Cho phép chỉnh sửa
    //        txtMaHang.ReadOnly = false;
    //        txtNgaySX.ReadOnly = false;
    //        txtHSD.ReadOnly = false;
    //        txtSoLuongDongGoi.ReadOnly = false;
    //    }

    //    // 
    //    //  Cập nhật lô hàng
    //    // 
    //    private void BtnUpdate_Click(object? sender, EventArgs e)
    //    {
    //        using var cnn = new SqlConnection(Cnn);
    //        const string sql =
    //            "UPDATE LoHang " +
    //            "SET MaHang=@mahang, MaLo=@malo, NgaySX=@ngaysx, HSD=@hsd, SoLuongDongGoi=@sldg " +
    //            "WHERE Malo=@ma";

    //        using var cmd = new SqlCommand(sql, cnn);
    //        cmd.Parameters.AddWithValue("@ma", _maLo);
    //        cmd.Parameters.AddWithValue("@mahang", txtMaHang.Text.Trim());
    //        cmd.Parameters.AddWithValue("@ngaysx", txtNgaySX.Text.Trim());
    //        cmd.Parameters.AddWithValue("@hsd", txtHSD.Text.Trim());
    //        cmd.Parameters.AddWithValue("@sldg", txtSoLuongDongGoi.Text.Trim());

    //        cnn.Open();
    //        int rows = cmd.ExecuteNonQuery();

    //        MessageBox.Show(rows > 0
    //                ? "Đã cập nhật lô hàng."
    //                : "Cập nhật không thành công.",
    //            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //    }

    //    // 
    //    //  Xóa LÔ Hàng
    //    // 
    //    private void BtnDelete_Click(object? sender, EventArgs e)
    //    {
    //        var confirm = MessageBox.Show(
    //            "Bạn có chắc muốn xóa lô hàng này?",
    //            "Xóa",
    //            MessageBoxButtons.YesNo,
    //            MessageBoxIcon.Warning);

    //        if (confirm != DialogResult.Yes) return;

    //        using var cnn = new SqlConnection(Cnn);
    //        using var cmd = new SqlCommand(
    //            "DELETE FROM Lohang WHERE MaLo = @ma", cnn);

    //        cmd.Parameters.AddWithValue("@ma", _maLo);

    //        cnn.Open();
    //        int rows = cmd.ExecuteNonQuery();

    //        MessageBox.Show(rows > 0
    //                ? "Đã xóa lô hàng."
    //                : "Xóa thất bại.",
    //            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

    //        if (rows > 0) Close();
    //    }
    //}
}
