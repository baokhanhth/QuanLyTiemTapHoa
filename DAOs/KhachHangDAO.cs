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

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_LayTatCaKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new KhachHang
                {
                    MaKH = reader["MaKH"].ToString(),
                    TenKH = reader["TenKH"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    SDT_KH = reader["SDT_KH"].ToString()
                });
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
            using (var cmd = new SqlCommand("sp_LayKhachHangTheoSDT", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SDT", sdt);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        khachHang = new KhachHang
                        {
                            MaKH = reader["MaKH"].ToString(),
                            TenKH = reader["TenKH"].ToString(),
                            DiaChi = reader["DiaChi_MaHoa"].ToString(),
                            SDT_KH = reader["SDT_KH_MaHoa"].ToString()
                        };
                    }
                }
            }

            return khachHang;
        }
        public bool ThemKhachHang(KhachHang kh)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_ThemKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
            cmd.Parameters.AddWithValue("@TenKH", kh.TenKH ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@SDT_KH", kh.SDT_KH ?? (object)DBNull.Value);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
        public bool CapNhatKhachHang(KhachHang kh)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_CapNhatKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
            cmd.Parameters.AddWithValue("@TenKH", kh.TenKH ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@SDT_KH", kh.SDT_KH ?? (object)DBNull.Value);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
        public bool XoaKhachHang(string maKH)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_XoaKhachHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaKH", maKH);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
        public KhachHang GetById(string maKH)
        {
            KhachHang kh = null;

            using (SqlConnection conn = new SqlConnection(_cnn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("usp_GetKhachHangById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaKH", maKH);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kh = new KhachHang
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

            return kh;
        }
    }
}
