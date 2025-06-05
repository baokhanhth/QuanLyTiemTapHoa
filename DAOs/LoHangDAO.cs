using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyTiemTapHoa.DAOs
{
    public class LoHangDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        public List<LoHang> GetAll()
        {
            var list = new List<LoHang>();
            string sql = "SELECT MaLo, MaHang, NgaySX, HSD, SoLuongDongGoi FROM LoHang";

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new LoHang
                        {
                            MaLo = reader.IsDBNull(0) ? null : reader.GetString(0),
                            MaHang = reader.IsDBNull(1) ? null : reader.GetString(1),
                            NgaySX = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                            HSD = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                            SoLuongDongGoi = reader.IsDBNull(4) ? 0 : reader.GetInt32(4)
                        });
                    }
                }
            }
            return list;
        }

        public List<LoHang> Search(string keyword)
        {
            var list = new List<LoHang>();

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("sp_TimKiemLoHang", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuKhoa", keyword);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new LoHang
                        {
                            MaLo = reader.GetString(0),
                            MaHang = reader.GetString(1),
                            NgaySX = reader.GetDateTime(2),
                            HSD = reader.GetDateTime(3),
                            SoLuongDongGoi = reader.GetInt32(4)
                        });
                    }
                }
            }

            return list;
        }

        public LoHang GetByMaLo(string maLo)
        {
            LoHang loHang = null;

            using (var conn = new SqlConnection(_cnn))
            {
                string query = "SELECT MaLo, MaHang, NgaySX, HSD, SoLuongDongGoi FROM LoHang WHERE MaLo = @MaLo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLo", maLo);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            loHang = new LoHang
                            {
                                MaLo = reader.GetString(0),
                                MaHang = reader.GetString(1),
                                NgaySX = reader.GetDateTime(2),
                                HSD = reader.GetDateTime(3),
                                SoLuongDongGoi = reader.GetInt32(4)
                            };
                        }
                    }
                }
            }

            return loHang;
        }

        public bool Insert(LoHang loHang)
        {
            using var conn = new SqlConnection(_cnn);
            const string sql = @"
            INSERT INTO LoHang (MaLo, MaHang, NgaySX, HSD, SoLuongDongGoi)
            VALUES (@MaLo, @MaHang, @NgaySX, @HSD, @SoLuongDongGoi)";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaLo", loHang.MaLo);
            cmd.Parameters.AddWithValue("@MaHang", loHang.MaHang);
            cmd.Parameters.AddWithValue("@NgaySX", loHang.NgaySX);
            cmd.Parameters.AddWithValue("@HSD", loHang.HSD);
            cmd.Parameters.AddWithValue("@SoLuongDongGoi", loHang.SoLuongDongGoi);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Update(LoHang loHang)
        {
            using (var conn = new SqlConnection(_cnn))
            {
                string query = @"
            UPDATE LoHang 
            SET MaHang = @MaHang, NgaySX = @NgaySX, HSD = @HSD, SoLuongDongGoi = @SoLuong 
            WHERE MaLo = @MaLo";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHang", loHang.MaHang);
                    cmd.Parameters.AddWithValue("@NgaySX", loHang.NgaySX);
                    cmd.Parameters.AddWithValue("@HSD", loHang.HSD);
                    cmd.Parameters.AddWithValue("@SoLuong", loHang.SoLuongDongGoi);
                    cmd.Parameters.AddWithValue("@MaLo", loHang.MaLo);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool Delete(string maLo)
        {
            using (var conn = new SqlConnection(_cnn))
            {
                string query = "DELETE FROM LoHang WHERE MaLo = @MaLo";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLo", maLo);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

    }
}
