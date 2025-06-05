using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemTapHoa.DAOs
{
    public class HoaDonBanDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        // 1. Lấy tất cả hóa đơn bán hàng
        public List<HoaDonBan> GetAll()
        {
            var list = new List<HoaDonBan>();

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("usp_BanHang_GetAll", conn)) // đã sửa
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HoaDonBan
                        {
                            MaBH = reader.IsDBNull(0) ? null : reader.GetString(0),
                            MaKH = reader.IsDBNull(1) ? null : reader.GetString(1),
                            NgayBan = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                            BH_TongCong = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3)
                        });
                    }
                }
            }
            return list;
        }

        // 2. Tìm kiếm hóa đơn bán
        public List<HoaDonBan> Search(string keyword)
        {
            var list = new List<HoaDonBan>();

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("usp_BanHang_Search", conn)) // đã sửa
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HoaDonBan
                        {
                            MaBH = reader.IsDBNull(0) ? null : reader.GetString(0),
                            MaKH = reader.IsDBNull(1) ? null : reader.GetString(1),
                            NgayBan = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                            BH_TongCong = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3)
                        });
                    }
                }
            }
            return list;
        }

        // 3. Kiểm tra mã BH có tồn tại
        public bool Exists(string maBH)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_BanHang_Exists", conn); // đã sửa
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBH", maBH);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        // 4. Thêm mới hóa đơn bán
        public void Insert(HoaDonBan bh)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_BanHang_Insert", conn); // đã sửa
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaBH", (bh.MaBH ?? "").Trim());
            cmd.Parameters.AddWithValue("@NgayBan", bh.NgayBan);
            cmd.Parameters.AddWithValue("@BH_TongCong_MaHoa", bh.BH_TongCong);
            cmd.Parameters.AddWithValue("@MaKH", string.IsNullOrEmpty(bh.MaKH) ? (object)DBNull.Value : bh.MaKH);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // 5. Cập nhật hóa đơn
        public void Update(HoaDonBan bh)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_BanHang_Update", conn); // đã sửa
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaBH", bh.MaBH);
            cmd.Parameters.AddWithValue("@NgayBan", bh.NgayBan);
            cmd.Parameters.AddWithValue("@BH_TongCong_MaHoa", bh.BH_TongCong);
            cmd.Parameters.AddWithValue("@MaKH", bh.MaKH);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // 6. Xóa hóa đơn
        public void Delete(string maBH)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_BanHang_Delete", conn); // đã sửa
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBH", maBH);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // 7. Tạo mã hóa đơn bán mới
        public string LayMaBanHangMoi()
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_LayMaBanHangMoi", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            var result = cmd.ExecuteScalar();

            return result != null ? result.ToString() : "BH00000001";
        }


        // 8. Tính tổng tiền từ chi tiết hóa đơn
        public decimal TinhTongTienTheoMaBH(string maBH)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_TinhTongTienTheoMaBH", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaBH", maBH);

            conn.Open();
            var result = cmd.ExecuteScalar();

            return result != DBNull.Value && result != null ? Convert.ToDecimal(result) : 0;
        }
        public bool LuuBanHang(HoaDonBan banHang, List<ChiTietBanHang> chiTietList)
        {
            using var conn = new SqlConnection(_cnn);
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                // Insert BanHang (hóa đơn tổng)
                using (var cmd = new SqlCommand("usp_BanHang_Insert", conn, transaction))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaBH", banHang.MaBH);
                    cmd.Parameters.AddWithValue("@MaKH", banHang.MaKH ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@NgayBan", banHang.NgayBan);
                    cmd.Parameters.AddWithValue("@BH_TongCong_MaHoa", banHang.BH_TongCong); // Mã hóa tổng cộng ở đây
                    cmd.ExecuteNonQuery();
                }

                // Insert từng ChiTietBanHang (chi tiết)
                foreach (var ct in chiTietList)
                {
                    using var cmdCT = new SqlCommand("usp_ChiTietBanHang_Them", conn, transaction);
                    cmdCT.CommandType = CommandType.StoredProcedure;

                    cmdCT.Parameters.AddWithValue("@MaBH", ct.MaBH);
                    cmdCT.Parameters.AddWithValue("@MaHang", ct.MaHang);
                    cmdCT.Parameters.AddWithValue("@SoLuongBan", ct.SoLuongBan);
                    cmdCT.Parameters.AddWithValue("@DonGB", ct.DonGB); // Giá bán đơn vị (chưa mã hóa)
                    cmdCT.Parameters.AddWithValue("@DonGB_MaHoa", ct.DonGB);  // Giá bán đơn vị mã hóa nếu có
                    cmdCT.Parameters.AddWithValue("@BH_ThanhTien", ct.BH_ThanhTien);
                    cmdCT.Parameters.AddWithValue("@BH_ThanhTien_MaHoa", ct.BH_ThanhTien); // Thành tiền mã hóa ở đây

                    cmdCT.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Lỗi lưu dữ liệu bán hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return false;
            }
        }
    }
    }
