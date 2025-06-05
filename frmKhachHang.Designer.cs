// KhachHangForm.Designer.cs
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Microsoft.Data.SqlClient;

namespace QuanLyTiemTapHoa
{
    partial class frmKhachHang
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhachHang;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            CustomizableEdges customizableEdges6 = new CustomizableEdges();
            CustomizableEdges customizableEdges7 = new CustomizableEdges();
            CustomizableEdges customizableEdges1 = new CustomizableEdges();
            CustomizableEdges customizableEdges2 = new CustomizableEdges();
            CustomizableEdges customizableEdges3 = new CustomizableEdges();
            CustomizableEdges customizableEdges4 = new CustomizableEdges();
            CustomizableEdges customizableEdges5 = new CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            panelContent = new Guna2Panel();
            tbtnThem = new Guna2GradientTileButton();
            btnExit = new Guna2CircleButton();
            LabelKhachHang = new Guna2HtmlLabel();
            txtTimKiem = new Guna2TextBox();
            dgvKhachHang = new Guna2DataGridView();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(196, 217, 255);
            panelContent.Controls.Add(tbtnThem);
            panelContent.Controls.Add(btnExit);
            panelContent.Controls.Add(LabelKhachHang);
            panelContent.Controls.Add(txtTimKiem);
            panelContent.Controls.Add(dgvKhachHang);
            panelContent.CustomizableEdges = customizableEdges6;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.ShadowDecoration.CustomizableEdges = customizableEdges7;
            panelContent.Size = new Size(1570, 1080);
            panelContent.TabIndex = 1;
            // 
            // tbtnThem
            // 
            tbtnThem.BackColor = Color.Transparent;
            tbtnThem.BorderColor = Color.Transparent;
            tbtnThem.BorderRadius = 18;
            tbtnThem.CustomizableEdges = customizableEdges1;
            tbtnThem.DisabledState.BorderColor = Color.DarkGray;
            tbtnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            tbtnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tbtnThem.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            tbtnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tbtnThem.FillColor = Color.White;
            tbtnThem.FillColor2 = Color.White;
            tbtnThem.Font = new Font("Open Sans ExtraBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbtnThem.ForeColor = Color.FromArgb(28, 76, 119);
            tbtnThem.Image = Properties.Resources.plus;
            tbtnThem.ImageAlign = HorizontalAlignment.Left;
            tbtnThem.ImageOffset = new Point(5, 28);
            tbtnThem.ImageSize = new Size(44, 44);
            tbtnThem.ImeMode = ImeMode.NoControl;
            tbtnThem.Location = new Point(1325, 169);
            tbtnThem.Name = "tbtnThem";
            tbtnThem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbtnThem.Size = new Size(191, 58);
            tbtnThem.TabIndex = 25;
            tbtnThem.Text = "Thêm";
            tbtnThem.TextOffset = new Point(40, -30);
            tbtnThem.Click += tbtnThem_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Transparent;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Image = Properties.Resources.cancel_50px;
            btnExit.ImageSize = new Size(50, 50);
            btnExit.Location = new Point(1466, 12);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 21;
            btnExit.Click += btnExit_Click;
            // 
            // LabelKhachHang
            // 
            LabelKhachHang.BackColor = Color.Transparent;
            LabelKhachHang.Font = new Font("Open Sans ExtraBold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelKhachHang.ForeColor = Color.FromArgb(27, 20, 100);
            LabelKhachHang.Location = new Point(637, 24);
            LabelKhachHang.Name = "LabelKhachHang";
            LabelKhachHang.Size = new Size(369, 79);
            LabelKhachHang.TabIndex = 13;
            LabelKhachHang.Text = "KHÁCH HÀNG";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 18;
            txtTimKiem.BorderThickness = 0;
            txtTimKiem.CustomizableEdges = customizableEdges4;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Open Sans", 12F);
            txtTimKiem.IconRight = Properties.Resources.search;
            txtTimKiem.IconRightSize = new Size(53, 53);
            txtTimKiem.Location = new Point(51, 169);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtTimKiem.Size = new Size(722, 58);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhachHang.BorderStyle = BorderStyle.FixedSingle;
            dgvKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgvKhachHang.GridColor = Color.FromArgb(231, 229, 255);
            dgvKhachHang.Location = new Point(51, 263);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(1465, 787);
            dgvKhachHang.TabIndex = 2;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvKhachHang.ThemeStyle.BackColor = Color.White;
            dgvKhachHang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvKhachHang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvKhachHang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvKhachHang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvKhachHang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKhachHang.ThemeStyle.HeaderStyle.Height = 29;
            dgvKhachHang.ThemeStyle.ReadOnly = true;
            dgvKhachHang.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvKhachHang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKhachHang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvKhachHang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvKhachHang.ThemeStyle.RowsStyle.Height = 29;
            dgvKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmKhachHang
            // 
            ClientSize = new Size(1570, 1080);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmKhachHang";
            Text = "Khách Hàng";
            WindowState = FormWindowState.Maximized;
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2HtmlLabel LabelKhachHang;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna2GradientTileButton tbtnThem;
    }
}
