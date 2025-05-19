//using Microsoft.Data.SqlClient;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace QuanLyTiemTapHoa
//{
//    public partial class frmKhachHang : Form
//    {
//        string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True;TrustServerCertificate=True";

//        public frmKhachHang()
//        {
//            InitializeComponent();
//            this.Load += frmKhachHang_Load;
//        }

//        private void btnExit_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            Program.frmLoginInstance.ResetForm();
//            Program.frmLoginInstance.Show();
//        }

//        private void btnThem_Click(object sender, EventArgs e)
//        {
//            frmThemKhachHang themForm = new frmThemKhachHang(this);
//            themForm.ShowDialog();
//        }

//        private void frmKhachHang_Load(object sender, EventArgs e)
//        {
//            LoadKhachHang();
//            dgvKhachHang.CellDoubleClick += dgvKhachHang_CellDoubleClick;
//        }

//        public void LoadKhachHang()
//        {
//            string query = "SELECT * FROM KhachHang";

//            using (SqlConnection conn = new SqlConnection(connectionString))
//            {
//                SqlDataAdapter da = new SqlDataAdapter(query, conn);
//                DataTable dt = new DataTable();



//                // Cấu hình hiển thị (trước khi load data)
//                dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 14, FontStyle.Bold);
//                dgvKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
//                dgvKhachHang.DefaultCellStyle.Font = new Font("Open Sans", 12, FontStyle.Regular);

//                dgvKhachHang.RowTemplate.Height = 60;
//                dgvKhachHang.ColumnHeadersHeight = 60;


//                // Load dữ liệu vào DataGridView

//                da.Fill(dt);
//                dgvKhachHang.DataSource = dt;

//                if (dgvKhachHang.Columns.Contains("MaKH"))
//                {
//                    dgvKhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
//                    dgvKhachHang.Columns["MaKH"].Width = 150;
//                    dgvKhachHang.Columns["MaKH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
//                }

//                if (dgvKhachHang.Columns.Contains("TenKH"))
//                {
//                    dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
//                    dgvKhachHang.Columns["TenKH"].Width = 250;
//                }

//                if (dgvKhachHang.Columns.Contains("DiaChi"))
//                {
//                    dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
//                    dgvKhachHang.Columns["DiaChi"].Width = 450;
//                }

//                if (dgvKhachHang.Columns.Contains("SDT_KH"))
//                {
//                    dgvKhachHang.Columns["SDT_KH"].HeaderText = "Số Điện Thoại";
//                    dgvKhachHang.Columns["SDT_KH"].Width = 250;
//                }
//            }
//        }

//        private void txtTimKiem_TextChanged(object sender, EventArgs e)
//        {
//            string keyword = txtTimKiem.Text.Trim();

//            if (string.IsNullOrEmpty(keyword))
//            {
//                LoadKhachHang();
//                return;
//            }

//            using (SqlConnection conn = new SqlConnection(connectionString))
//            using (SqlCommand cmd = new SqlCommand("sp_TimKiemKhachHang", conn))
//            {
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@TuKhoa", keyword);

//                SqlDataAdapter da = new SqlDataAdapter(cmd);
//                DataTable dt = new DataTable();
//                da.Fill(dt);
//                dgvKhachHang.DataSource = dt;
//            }
//        }
//        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex < 0) return;

//            DataRowView row = (DataRowView)dgvKhachHang.Rows[e.RowIndex].DataBoundItem;
//            string maKH = row["MaKH"].ToString();
//            string tenKH = row["TenKH"].ToString();
//            string diaChi = row["DiaChi"].ToString();
//            string sdt = row["SDT_KH"].ToString();

//            var frm = new frmThongTinKhachHang(maKH, tenKH, diaChi, sdt);
//            frm.ShowDialog();

//            LoadKhachHang();
//        }

//        private void btnTrangChu_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            frmTrangChu trangChuForm = new frmTrangChu();
//            trangChuForm.Show();
//        }
//    }
//}

