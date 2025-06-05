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
    public class CapNhatGiaDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        private static CapNhatGiaDAO _instance;
        public static CapNhatGiaDAO Instance => _instance ??= new CapNhatGiaDAO();

        // 1. Lấy tất cả cập nhật giá
        public List<CapNhatGia> GetAll()
        {
            var list = new List<CapNhatGia>();

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("usp_GetAllCapNhatGia", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CapNhatGia
                        {
                            MaHang = reader.IsDBNull(0) ? null : reader.GetString(0),
                            MaLo = reader.IsDBNull(1) ? null : reader.GetString(1),
                            NgayBD = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2),
                            NgayKT = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3),
                            DonGN = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4)
                        });
                    }
                }
            }

            return list;
        }

        // 2. Thêm cập nhật giá mới
        public bool ThemGiaNhapMoi(string maHang, string maLo, DateTime ngayBD, DateTime ngayKT, decimal donGiaNhap)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("usp_ThemCapNhatGia", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@maHang", maHang);
            cmd.Parameters.AddWithValue("@maLo", maLo);
            cmd.Parameters.AddWithValue("@ngayBD", ngayBD);
            cmd.Parameters.AddWithValue("@ngayKT", ngayKT);
            cmd.Parameters.AddWithValue("@donGN", donGiaNhap);

            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch
            {
                // Ghi log lỗi tại đây nếu cần
                return false;
            }
        }

        // 3. Lấy đơn giá nhập gần nhất của một mặt hàng
        public decimal LayDonGiaNhapGanNhat(string maHang)
        {
            decimal donGiaNhap = 0;

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("usp_LayDonGiaNhapGanNhat", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maHang", maHang);

                try
                {
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        donGiaNhap = Convert.ToDecimal(result);
                    }
                }
                catch
                {
                    // Ghi log lỗi nếu cần
                    donGiaNhap = 0;
                }
            }

            return donGiaNhap;
        }
    }
}
