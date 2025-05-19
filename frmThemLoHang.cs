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
    public partial class frmThemLoHang : Form
    {
        private const string Cnn =
            @"Server=.;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;Intergrated Security=True; TrustServerCertificate=True";
        //private const string Cnn = @"Server=.;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;Integrated Security=True;TrustServerCertificate=True";
        public frmThemLoHang()
        {
            InitializeComponent();
        }

        private void txtNgaySX_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            const string sql = "INSERT INTO Lo Hang (MaLo, MaHang, NgaySX,HSD,SoLuongDongGoi)" +
                "VALUES (@malo, @mahang, @ngaysx, @hsd, @sldg)";


            using var cmd = new SqlCommand(sql, cnn);
            // Truyền string thẳng cho cột varchar, nvarchar
            cmd.Parameters.AddWithValue("@malo", txtMaLo.Text.Trim());
            cmd.Parameters.AddWithValue("@mahang", txtMaHang.Text.Trim());
            cmd.Parameters.AddWithValue("@ngaysx", txtNgaySX.Text.Trim());
            cmd.Parameters.AddWithValue("@hsd", txtHSD.Text.Trim());
            cmd.Parameters.AddWithValue("@sldg", txtSLDG.Text.Trim());
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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
