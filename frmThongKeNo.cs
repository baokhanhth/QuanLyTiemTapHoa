using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiemTapHoa.Models;
using QuanLyTiemTapHoa.DAO;

namespace QuanLyTiemTapHoa
{
    public partial class frmThongKeNo : Form
    {
        public frmThongKeNo()
        {
            InitializeComponent();
        }

        private void btok_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dttungay.Value.Date;
            DateTime denNgay = dtdenngay.Value.Date;

            var duLieu = ThongKeNoDAO.LayDuLieuThongKeNo(tuNgay, denNgay);
            var labels = duLieu.Select(x => x.ThangNam).ToList();
            var values = duLieu.Select(x => x.TongNo).ToList();

            // Tạo biểu đồ cột công nợ theo tháng
            cCongNo.Series = new ISeries[]
            {
        new ColumnSeries<decimal>
        {
            Values = values,
            Name = "Công nợ"
        }
            };

            // Cập nhật trục X
            cCongNo.XAxes = new Axis[]
            {
        new Axis
        {
            Labels = labels,
            Name = "Tháng-Năm",
            LabelsRotation = 15
        }
            };

            // Cập nhật trục Y
            cCongNo.YAxes = new Axis[]
            {
        new Axis
        {
            Name = "Tổng công nợ"
        }
            };
        }
        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dttungay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtdenngay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmThongKeNo_Load(object sender, EventArgs e)
        {

        }
    }
}
