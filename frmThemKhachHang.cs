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
    public partial class frmThemKhachHang : Form
    {
        private const string Cnn =
            @"Server=.;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;";
        public frmThemKhachHang()
        {
            InitializeComponent();
        }
        private void btnThemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            const string sql = "INSERT INTO KhachHang (MaKH, TenKH, SDT_KH, DiaChi)" +
                "VALUES (@ma, @ten, @sdt, @dc)";

            using var cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ma", txtMaKH.Text.Trim());
            cmd.Parameters.AddWithValue("@ten", txtTenKH.Text.Trim());
            cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
            cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text.Trim());

            try
            {
                cnn.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0
                        ? "Đã thêm khách hàng."
                        : "Thêm khách hàng không thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng");
            }

        }
    }
}
