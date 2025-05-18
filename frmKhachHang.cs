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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            this.Load += frmKhachHang_Load;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemKhachHang themForm = new frmThemKhachHang();
            themForm.ShowDialog();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM KhachHang";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKhachHang.DataSource = dt;
                dgvKhachHang.RowTemplate.Height = 40;
                dgvKhachHang.Columns["DiaChi"].Width = 400;     
                dgvKhachHang.Columns["SDT_KH"].Width = 150;


                dgvKhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
                dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
                dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvKhachHang.Columns["SDT_KH"].HeaderText = "Số Điện Thoại";
            }
        }

    }
}
