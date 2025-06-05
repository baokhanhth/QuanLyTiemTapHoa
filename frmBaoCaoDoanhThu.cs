using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.DAO;


namespace QuanLyTiemTapHoa
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void dtketthuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            DateTime tuNgay = dtbatdau.Value.Date;
            DateTime denNgay = dtketthuc.Value.Date;

            var duLieu = BaoCaoDAO.LayBaoCaoDoanhThu(tuNgay, denNgay);
            var labels = duLieu.Select(x => x.ThangNam).ToList();
            var values = duLieu.Select(x => x.TongDoanhThu).ToList();

            // Vẽ biểu đồ
            cDoanhThu.Series = new ISeries[]
            {
        new ColumnSeries<decimal>
        {
            Values = values,
            Name = "Doanh thu"
        }
            };

            cDoanhThu.XAxes = new Axis[]
            {
        new Axis
        {
            Labels = labels,
            Name = "Tháng-Năm",
            LabelsRotation = 15
        }
            };

            cDoanhThu.YAxes = new Axis[]
            {
        new Axis
        {
            Name = "Tổng doanh thu"
        }
            };
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}