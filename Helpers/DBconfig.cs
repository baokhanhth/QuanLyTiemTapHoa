using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyTiemTapHoa.Helpers
{
    /// <summary>
    /// Helper class cung cấp chung connection string cho toàn ứng dụng.
    /// </summary>
    public static class DbConfig
    {
        /// <summary>
        /// Lấy connection string từ app.config (hoặc web.config).
        /// </summary>
        public static string ConnectionString =>
            ConfigurationManager
                .ConnectionStrings["QuanLyBanHang"]
                .ConnectionString;
    }
}
