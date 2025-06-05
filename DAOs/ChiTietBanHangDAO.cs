using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;

namespace QuanLyTiemTapHoa.DAOs
{
    public class ChiTietBanHangDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        // 1. Lấy tất cả chi tiết bán hàng
        public List<ChiTietBanHang> GetAll()
        {
            var list = new List<ChiTietBanHang>();

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_ChiTietBanHang_GetAll", conn); // Đã sửa
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conn.Open();

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ChiTietBanHang
                {
                    MaBH = reader.IsDBNull(0) ? null : reader.GetString(0),
                    MaHang = reader.IsDBNull(1) ? null : reader.GetString(1),
                    SoLuongBan = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                    DonGB = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    BH_ThanhTien = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4)
                });
            }

            return list;
        }

        // 2. Thêm mới một chi tiết bán hàng
        public bool ThemChiTietBanHang(ChiTietBanHang ct)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_ChiTietBanHang_Them", conn); // Đã sửa
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaBH", ct.MaBH);
            cmd.Parameters.AddWithValue("@MaHang", ct.MaHang);
            cmd.Parameters.AddWithValue("@SoLuongBan", ct.SoLuongBan);
            cmd.Parameters.AddWithValue("@DonGB", ct.DonGB);
            cmd.Parameters.AddWithValue("@ThanhTien", ct.BH_ThanhTien);

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

        // 3. Lấy danh sách theo mã bán hàng
        public List<ChiTietBanHang> GetByMaBH(string maBH)
        {
            var list = new List<ChiTietBanHang>();
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_ChiTietBanHang_GetByMaBH", conn); // Đã sửa
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBH", maBH);
            conn.Open();

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ChiTietBanHang
                {
                    MaBH = reader.GetString(0),
                    MaHang = reader.GetString(1),
                    SoLuongBan = reader.GetInt32(2),
                    DonGB = reader.GetDecimal(3),
                    BH_ThanhTien = reader.GetDecimal(4)
                });
            }

            return list;
        }
    }
}
