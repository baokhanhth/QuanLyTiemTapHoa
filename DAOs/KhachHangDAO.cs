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
    public class KhachHangDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        public List<KhachHang> GetAll()
        {
            var list = new List<KhachHang>();
            string sql = "SELECT MaKH, TenKH, DiaChi, SDT_KH FROM KhachHang"; 

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhachHang
                        {
                            MaKH = reader.IsDBNull(0) ? null : reader.GetString(0),
                            TenKH = reader.IsDBNull(1) ? null : reader.GetString(1),
                            DiaChi = reader.IsDBNull(2) ? null : reader.GetString(2),
                            SDT_KH = reader.IsDBNull(3) ? null : reader.GetString(3)
                        });
                    }
                }
            }
            return list;
        }

        public List<KhachHang> Search(string keyword)
        {
            var list = new List<KhachHang>();

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("sp_TimKiemKhachHang", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuKhoa", keyword);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhachHang
                        {
                            MaKH = reader.IsDBNull(0) ? null : reader.GetString(0),
                            TenKH = reader.IsDBNull(1) ? null : reader.GetString(1),
                            DiaChi = reader.IsDBNull(2) ? null : reader.GetString(2),
                            SDT_KH = reader.IsDBNull(3) ? null : reader.GetString(3)
                        });
                    }
                }
            }
            return list;
        }

        public KhachHang TimKhachHangTheoSDT(string sdt)
        {
            KhachHang khachHang = null;

            using (var conn = new SqlConnection(_cnn))
            {
                string query = "SELECT MaKH, TenKH, DiaChi, SDT_KH FROM KhachHang WHERE SDT_KH = @SDT";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SDT", sdt);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            khachHang = new KhachHang
                            {
                                MaKH = reader["MaKH"].ToString(),
                                TenKH = reader["TenKH"].ToString(),
                                DiaChi = reader["DiaChi"].ToString(),
                                SDT_KH = reader["SDT_KH"].ToString()
                            };
                        }
                    }
                }
            }
            return khachHang;
        }
    }
}
