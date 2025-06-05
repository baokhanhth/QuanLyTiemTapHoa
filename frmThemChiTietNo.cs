using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
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
    public partial class frmThemChiTietNo : Form
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        public frmThemChiTietNo()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtMaNo.Text))
            {
                MessageBox.Show("Mã nợ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtmabh.Text))
            {
                MessageBox.Show("Mã hóa đơn không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txttcn.Text.Trim(), out decimal soTienConNo))
            {
                MessageBox.Show("Số tiền còn nợ không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var cnn = new SqlConnection(_cnn);

            // Sửa lại câu lệnh SQL: thiếu dấu phẩy giữa tham số, và tên tham số đúng
            const string sql = "INSERT INTO ChiTiet_No (MaNo, MaBH, SoTienConNo) " +
                               "VALUES (@mano, @mabh, @sotienconno)";

            using var cmd = new SqlCommand(sql, cnn);

            cmd.Parameters.AddWithValue("@mano", txtMaNo.Text.Trim());
            cmd.Parameters.AddWithValue("@mabh", txtmabh.Text.Trim());
            cmd.Parameters.AddWithValue("@sotienconno", soTienConNo);

            try
            {
                cnn.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0
                        ? "Đã thêm xong chi tiết nợ."
                        : "Thêm không thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (rows > 0)
                {
                    this.Close(); // Đóng form nếu thêm thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết nợ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
