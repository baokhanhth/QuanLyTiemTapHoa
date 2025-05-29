using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemTapHoa.DAOs
{
    public class CapNhatGiaDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        // 1. Lấy tất cả cập nhật giá
        public List<CapNhatGia> GetAll()
        {
            var list = new List<CapNhatGia>();
            string sql = "SELECT MaHang, MaLo, NgayBD, NgayKT, DonGN FROM CapNhatGia";

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(sql, conn))
            {
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

        // 2 Thêm cập nhật giá mới
        public bool ThemGiaNhapMoi(string maHang, string maLo, DateTime ngayBD, DateTime ngayKT, decimal donGiaNhap)
        {
            const string sql = "INSERT INTO CapNhatGia (MaHang, MaLo, NgayBD, NgayKT, DonGN) " +
                               "VALUES (@maHang, @maLo, @ngayBD, @ngayKT, @donGN)";

            using var cnn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, cnn);

            cmd.Parameters.AddWithValue("@maHang", maHang);
            cmd.Parameters.AddWithValue("@maLo", maLo);
            cmd.Parameters.AddWithValue("@ngayBD", ngayBD);
            cmd.Parameters.AddWithValue("@ngayKT", ngayKT);
            cmd.Parameters.AddWithValue("@donGN", donGiaNhap);

            try
            {
                cnn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch
            {
                // Bạn có thể ghi log lỗi ở đây
                return false;
            }
        }
    }
}
