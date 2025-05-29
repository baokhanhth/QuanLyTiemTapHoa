using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyTiemTapHoa.DAOs;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace QuanLyTiemTapHoa
{
    public partial class frmTrangChu : Form
    {
        private readonly BaoCaoDAO _baoCaoDAO = new BaoCaoDAO();

        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            VeBieuDoDoanhThu();
        }

        private void VeBieuDoDoanhThu()
        {
            var ds = _baoCaoDAO.LayDoanhThuTheoThang();
            if (ds == null || ds.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu doanh thu để hiển thị.");
                return;
            }

            // Lấy dữ liệu giá trị và label
            var values = ds.Select(d => Convert.ToDouble(d.TongDoanhThu)).ToArray();
            var labels = ds.Select(d => d.ThangNam).ToArray();

            // Tạo paint màu đen cho text
            var dataLabelPaint = new SolidColorPaint(SKColors.Black);
            var axisLabelPaint = new SolidColorPaint(SKColors.Black);
            var axisTitlePaint = new SolidColorPaint(SKColors.Black);

            var series = new ColumnSeries<double>
            {
                Values = values,
                Name = "Doanh thu",
                DataLabelsPaint = dataLabelPaint,
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Top
            };

            cDoanhThu.Series = new ISeries[] { series };

            cDoanhThu.XAxes = new[]
            {
                new Axis
                {
                    Labels = labels,
                    LabelsRotation = 45,
                    Name = "Tháng/Năm",
                    LabelsPaint = axisLabelPaint,
                    NamePaint = axisTitlePaint
                }
            };

            cDoanhThu.YAxes = new[]
            {
                new Axis
                {
                    Name = "Doanh thu (VND)",
                    LabelsPaint = axisLabelPaint,
                    NamePaint = axisTitlePaint
                }
            };

            cDoanhThu.Update();
        }
    }
}
