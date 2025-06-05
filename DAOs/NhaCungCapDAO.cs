using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyTiemTapHoa.DAOs
{
    public class NhaCungCapDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        public List<NhaCungCap> GetAll()
        {
            var list = new List<NhaCungCap>();
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_NCC_GetAll", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new NhaCungCap
                {
                    MaNCC = reader["MaNCC"].ToString(),
                    TenNCC = reader["TenNCC"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    SDT = reader["SDT"].ToString()
                });
            }
            return list;
        }

        public List<NhaCungCap> Search(string keyword)
        {
            var list = new List<NhaCungCap>();
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_NCC_Search", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@keyword", keyword);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new NhaCungCap
                {
                    MaNCC = reader["MaNCC"].ToString(),
                    TenNCC = reader["TenNCC"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    SDT = reader["SDT"].ToString()
                });
            }
            return list;
        }

        public bool Exists(string maNCC)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_NCC_Exists", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNCC", maNCC);

            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_NCC_Insert", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DiaChi", ncc.DiaChi ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@SDT", ncc.SDT ?? (object)DBNull.Value);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool CapNhatNhaCungCap(NhaCungCap ncc)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_NCC_Update", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DiaChi", ncc.DiaChi ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@SDT", ncc.SDT ?? (object)DBNull.Value);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool XoaNhaCungCap(string maNCC)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_NCC_Delete", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNCC", maNCC);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public NhaCungCap GetById(string maNCC)
        {
            NhaCungCap ncc = null;
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_NCC_GetById", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNCC", maNCC);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ncc = new NhaCungCap
                {
                    MaNCC = reader["MaNCC"].ToString(),
                    TenNCC = reader["TenNCC"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    SDT = reader["SDT"].ToString()
                };
            }
            return ncc;
        }
        public NhaCungCap TimNhaCungCapTheoSDT(string sdt)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_NCC_SearchBySDT", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SDT", sdt);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            if (reader.Read()) // chỉ lấy bản ghi đầu tiên
            {
                return new NhaCungCap
                {
                    MaNCC = reader["MaNCC"].ToString(),
                    TenNCC = reader["TenNCC"].ToString(),
                    DiaChi = reader["DiaChi"].ToString(),
                    SDT = reader["SDT"].ToString()
                };
            }
            return null;
        }
    }
}
