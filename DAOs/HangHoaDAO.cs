using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;

namespace QuanLyTiemTapHoa.DAOs
{
    public class HangHoaDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;
        private static HangHoaDAO _instance;
        public static HangHoaDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HangHoaDAO();
                return _instance;
            }
        }

        // 0. Tạo mã hàng mới gọi proc sp_HangHoa_TaoMaHang
        public string TaoMaHang()
        {
            const string procName = "sp_HangHoa_TaoMaHang";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            var maHangMoi = cmd.ExecuteScalar()?.ToString();
            return maHangMoi;
        }

        // 1. Lấy tất cả hàng hóa
        public List<HangHoa> GetAll()
        {
            var list = new List<HangHoa>();
            const string procName = "sp_HangHoa_GetAll";

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new HangHoa
                {
                    MaHang = reader.IsDBNull(0) ? null : reader.GetString(0),
                    TenHang = reader.IsDBNull(1) ? null : reader.GetString(1),
                    DonVT = reader.IsDBNull(2) ? null : reader.GetString(2),
                    SoLuongTon = reader.IsDBNull(3) ? 0 : reader.GetInt64(3)
                });
            }
            return list;
        }

        // 2. Tìm kiếm theo từ khóa (MaHang hoặc TenHang)
        public List<HangHoa> Search(string keyword)
        {
            var list = new List<HangHoa>();
            const string procName = "sp_HangHoa_Search";

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new HangHoa
                {
                    MaHang = reader.IsDBNull(0) ? null : reader.GetString(0),
                    TenHang = reader.IsDBNull(1) ? null : reader.GetString(1),
                    DonVT = reader.IsDBNull(2) ? null : reader.GetString(2),
                    SoLuongTon = reader.IsDBNull(3) ? 0 : reader.GetInt64(3)
                });
            }
            return list;
        }
        public List<HangHoa> LayTenHang()
        {
            var list = new List<HangHoa>();
            const string procName = "sp_HangHoa_LayDanhSachHangHoa"; // kiểm tra proc này trả về gì

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new HangHoa
                {
                    MaHang = reader.IsDBNull(0) ? null : reader.GetString(0),
                    TenHang = reader.IsDBNull(1) ? null : reader.GetString(1),
                    // Xóa hoặc comment 2 dòng dưới nếu proc không trả 2 cột này:
                    //DonVT = reader.IsDBNull(2) ? null : reader.GetString(2),
                    //SoLuongTon = reader.IsDBNull(3) ? 0 : reader.GetInt64(3)
                });
            }
            return list;
        }
        // 3. Kiểm tra hàng hóa tồn tại theo mã
        public bool Exists(string maHang)
        {
            const string procName = "sp_HangHoa_Exists";

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHang", maHang);

            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        // 4. Thêm mới hàng hóa
        public void Insert(HangHoa hh)
        {
            const string procName = "sp_HangHoa_Insert";

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaHang", hh.MaHang);
            cmd.Parameters.AddWithValue("@TenHang", hh.TenHang);
            cmd.Parameters.AddWithValue("@DonVT", hh.DonVT);
            cmd.Parameters.AddWithValue("@SoLuongTon", hh.SoLuongTon);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // 5. Cập nhật hàng hóa
        public void Update(HangHoa hh)
        {
            const string procName = "sp_HangHoa_Update";

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaHang", hh.MaHang);
            cmd.Parameters.AddWithValue("@TenHang", hh.TenHang);
            cmd.Parameters.AddWithValue("@DonVT", hh.DonVT);
            cmd.Parameters.AddWithValue("@SoLuongTon", hh.SoLuongTon);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // 6. Xóa hàng hóa theo mã
        public void Delete(string maHang)
        {
            const string procName = "sp_HangHoa_Delete";

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaHang", maHang);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // 7. Lấy hàng hóa theo mã (chi tiết)
        public HangHoa GetById(string maHang)
        {
            const string procName = "sp_HangHoa_GetById";

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaHang", maHang);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new HangHoa
                {
                    MaHang = reader.IsDBNull(0) ? null : reader.GetString(0),
                    TenHang = reader.IsDBNull(1) ? null : reader.GetString(1),
                    DonVT = reader.IsDBNull(2) ? null : reader.GetString(2),
                    SoLuongTon = reader.IsDBNull(3) ? 0 : reader.GetInt64(3)
                };
            }
            return null;
        }

        // 8. Tìm theo tên hàng (autocomplete/đổ xuống)
        public List<HangHoa> TimTheoTenHang(string keyword)
        {
            var list = new List<HangHoa>();
            const string procName = "sp_HangHoa_TimTheoTenHang";

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new HangHoa
                {
                    MaHang = reader.GetString(0),
                    TenHang = reader.GetString(1)
                });
            }
            return list;
        }

        // 9. Lấy danh sách hàng hóa (MaHang, TenHang)
        public List<HangHoa> LayDanhSachHangHoa()
        {
            var list = new List<HangHoa>();
            const string procName = "sp_HangHoa_LayDanhSachHangHoa";

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new HangHoa
                {
                    MaHang = reader.GetString(0),
                    TenHang = reader.GetString(1),
                });
            }
            return list;
        }
    }
}

