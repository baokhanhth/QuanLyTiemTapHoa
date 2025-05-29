using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Models;
using QuanLyTiemTapHoa.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemTapHoa.DAOs
{
    public class BaoCaoDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        public List<DoanhThuTheoThang> LayDoanhThuTheoThang()
        {
            var list = new List<DoanhThuTheoThang>();

            using (SqlConnection conn = new SqlConnection(_cnn))
            using (SqlCommand cmd = new SqlCommand("usp_TaoBaoCaoDoanhThu", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DoanhThuTheoThang
                        {
                            Thang = reader.GetInt32(reader.GetOrdinal("Thang")),
                            Nam = reader.GetInt32(reader.GetOrdinal("Nam")),
                            TongDoanhThu = reader.GetDecimal(reader.GetOrdinal("TongDoanhThu"))
                        });
                    }
                }
            }

            return list;
        }
    }

}
