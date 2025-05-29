using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemTapHoa.Models
{
    public class DoanhThuTheoThang
    {
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal TongDoanhThu { get; set; }

        // (Tuỳ chọn) Format để hiển thị trục X dễ dàng
        public string ThangNam => $"{Thang:D2}/{Nam}";
    }
}
