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
    public class HoaDonBanDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        public List<HoaDonBan> GetAll()
        {
            var list = new List<HoaDonBan>();
            string sql = "SELECT MaBH, MaKH, NgayBan, BH_TongCong FROM BanHang";

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(sql, conn))
            {
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

        public List<HoaDonBan> Search(string keyword)
        {
            var list = new List<HoaDonBan>();
            string sql = @"SELECT MaBH, MaKH, NgayBan, BH_TongCong
                            FROM BanHang
                            WHERE MaBH LIKE @p
                               OR MaKH LIKE @p
                               OR NgayBan LIKE @p";

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(sql, conn))
            {
                string p = "%" + keyword + "%";
                cmd.Parameters.AddWithValue("@p", p);

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
        public bool Exists(string maBH)
        {
            const string sql = "SELECT COUNT(1) FROM BanHang WHERE MaBH = @MaBH";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaBH", maBH);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }
        public void Insert(HoaDonBan bh)
        {
            const string sql = @"
                INSERT INTO BanHang (MaBH, NgayBan, BH_TongCong, MaKH)
                VALUES(@MaBH, @NgayBan, @BH_TongCong, @MaKH)";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaBH", bh.MaBH);
            cmd.Parameters.AddWithValue("@NgayBan", bh.NgayBan);
            cmd.Parameters.AddWithValue("@BH_TongCong", bh.BH_TongCong);
            cmd.Parameters.AddWithValue("@MaKH", bh.MaKH);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Update(HoaDonBan bh)
        {
            const string sql = @"
                UPDATE  BanHang
                SET MaBH = @BH,
                    MaNCC = @NgayBan,
                    BH_TongCong = @BH_TongCong,
                    MaKH = @MaKH
                    WHERE MaBH = @MaBH";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaBH", bh.MaBH);
            cmd.Parameters.AddWithValue("@NgayBan", bh.NgayBan);
            cmd.Parameters.AddWithValue("@BH_TongCong", bh.BH_TongCong);
            cmd.Parameters.AddWithValue("@MaKH", bh.MaKH);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(string maBH)
        {
            const string sql = "DELETE FROM BanHang WHERE MaBH = @MaBH";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaBH", maBH);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
