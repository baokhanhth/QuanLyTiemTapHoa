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
    public class NhaCungCapDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;
        public List<NhaCungCap> GetAll()
        {
            var list = new List<NhaCungCap>();
            string sql = "SELECT MaNCC, TenNCC, DiaChi, SDT FROM NhaCungCap"; 

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhaCungCap
                        {
                            MaNCC = reader.IsDBNull(0) ? null : reader.GetString(0),
                            TenNCC = reader.IsDBNull(1) ? null : reader.GetString(1),
                            DiaChi = reader.IsDBNull(2) ? null : reader.GetString(2),
                            SDT = reader.IsDBNull(3) ? null : reader.GetString(3)
                        });
                    }
                }
            }
            return list;
        }

        public NhaCungCap TimNhaCungCapTheoSDT(string sdt)
        {
            NhaCungCap nhaCungCap = null;

            using (var conn = new SqlConnection(_cnn))
            {
                string query = "SELECT MaNCC, TenNCC, DiaChi, SDT FROM NhaCungCap WHERE SDT = @SDT";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SDT", sdt);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nhaCungCap = new NhaCungCap
                            {
                                MaNCC = reader["MaNCC"].ToString(),
                                TenNCC = reader["TenNCC"].ToString(),
                                DiaChi = reader["DiaChi"].ToString(),
                                SDT = reader["SDT"].ToString()
                            };
                        }
                    }
                }
            }

            return nhaCungCap;
        }
    }
}
