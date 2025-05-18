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
    public partial class frmThemNCC : Form
    {
        private const string Cnn =
              @"Server=.;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;Intergrated Security=True; TrustServerCertificate=True";
        public frmThemNCC()
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
            const string sql = "INSERT INTO NhaCungCap (MaNCC, TenNCC, SDT, DiaChi)" +
                "VALUES (@ma, @ten, @sdt, @dc)";


            using var cmd = new SqlCommand(sql, cnn);
            // Truyền string thẳng cho cột varchar, nvarchar
            cmd.Parameters.AddWithValue("@ma", txtMaNCC.Text.Trim());
            cmd.Parameters.AddWithValue("@ten", txtTenNCC.Text.Trim());
            cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
            cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text.Trim());

            try
            {
                cnn.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0
                        ? "Đã thêm nhà cung cấp ."
                        : "Thêm nhà cung cấp không thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp");
            }

        }

        private void cpbAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

