using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemTapHoa.Models
{
    public class CapNhatGia
    {
        public string MaHang { get; set; }
        public string MaLo { get; set; }
        public DateTime? NgayBD { get; set; }
        public DateTime? NgayKT { get; set; }
        public decimal DonGN { get; set; }
    }
}
