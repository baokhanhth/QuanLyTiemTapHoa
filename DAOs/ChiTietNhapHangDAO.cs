using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;

namespace QuanLyTiemTapHoa.DAOs
{
    public class ChiTietNhapHangDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        public List<ChiTietNhapHang> GetAll()
        {
            var list = new List<ChiTietNhapHang>();
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_ChiTietNhapHang_GetAll", conn);  // giả sử có proc này
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ChiTietNhapHang
                {
                    MaNH = reader.IsDBNull(0) ? null : reader.GetString(0),
                    MaLo = reader.IsDBNull(1) ? null : reader.GetString(1),
                    NgayNhap = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                    SoLuongNhap = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                    GiaNhap = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    NH_ThanhTien = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5)
                });
            }
            return list;
        }

        // 2. Thêm mới chi tiết nhập hàng bằng stored procedure
        public bool ThemChiTietNhapHang(ChiTietNhapHang ct)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_ChiTietNhapHang_Them", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNH", ct.MaNH);
            cmd.Parameters.AddWithValue("@MaLo", ct.MaLo);
            cmd.Parameters.AddWithValue("@NgayNhap", ct.NgayNhap);
            cmd.Parameters.AddWithValue("@SoLuongNhap", ct.SoLuongNhap);
            cmd.Parameters.AddWithValue("@GiaNhap", ct.GiaNhap);
            cmd.Parameters.AddWithValue("@NH_ThanhTien", ct.NH_ThanhTien);

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }

        // 3. Lấy danh sách theo mã nhập hàng dùng stored procedure
        public List<ChiTietNhapHang> GetByMaNH(string maNH)
        {
            var list = new List<ChiTietNhapHang>();
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_ChiTietNhapHang_GetByMaNH", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNH", maNH);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ChiTietNhapHang
                {
                    MaNH = reader.GetString(0),
                    MaLo = reader.GetString(1),
                    NgayNhap = reader.GetDateTime(2),
                    SoLuongNhap = reader.GetInt32(3),
                    GiaNhap = reader.GetDecimal(4),
                    NH_ThanhTien = reader.GetDecimal(5)
                });
            }
            return list;
        }

        // 4. Cập nhật chi tiết nhập hàng bằng stored procedure
        public bool CapNhatChiTietNhapHang(ChiTietNhapHang ct)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_ChiTietNhapHang_Update", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNH", ct.MaNH);
            cmd.Parameters.AddWithValue("@MaLo", ct.MaLo);
            cmd.Parameters.AddWithValue("@NgayNhap", ct.NgayNhap);
            cmd.Parameters.AddWithValue("@SoLuongNhap", ct.SoLuongNhap);
            cmd.Parameters.AddWithValue("@GiaNhap", ct.GiaNhap);
            cmd.Parameters.AddWithValue("@NH_ThanhTien", ct.NH_ThanhTien);

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }

        // 5. Xóa chi tiết nhập hàng theo MaNH và MaLo (nếu cần)
        public bool XoaChiTietNhapHang(string maNH, string maLo)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_ChiTietNhapHang_Delete", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaNH", maNH);
            cmd.Parameters.AddWithValue("@MaLo", maLo);

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
        }

        // 6. Tìm kiếm chi tiết nhập hàng (nếu cần)
        public List<ChiTietNhapHang> TimKiem(string keyword)
        {
            var list = new List<ChiTietNhapHang>();
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_ChiTietNhapHang_Search", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ChiTietNhapHang
                {
                    MaNH = reader.IsDBNull(0) ? null : reader.GetString(0),
                    MaLo = reader.IsDBNull(1) ? null : reader.GetString(1),
                    NgayNhap = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                    SoLuongNhap = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                    GiaNhap = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    NH_ThanhTien = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5)
                });
            }
            return list;
        }
    }
}
