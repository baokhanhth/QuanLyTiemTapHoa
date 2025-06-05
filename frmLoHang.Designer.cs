namespace QuanLyTiemTapHoa
{
    partial class frmLoHang
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLoHang;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoHang));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelContent = new Guna.UI2.WinForms.Guna2Panel();
            tbtnThem = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            lblLoHang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            dgvLoHang = new Guna.UI2.WinForms.Guna2DataGridView();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoHang).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(196, 217, 255);
            panelContent.Controls.Add(tbtnThem);
            panelContent.Controls.Add(btnExit);
            panelContent.Controls.Add(lblLoHang);
            panelContent.Controls.Add(txtTimKiem);
            panelContent.Controls.Add(dgvLoHang);
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
            tbtnThem.Location = new Point(1338, 172);
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
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageSize = new Size(50, 50);
            btnExit.Location = new Point(1479, 47);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 21;
            btnExit.Click += btnExit_Click;
            // 
            // lblLoHang
            // 
            lblLoHang.BackColor = Color.Transparent;
            lblLoHang.Font = new Font("Open Sans ExtraBold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoHang.ForeColor = Color.FromArgb(27, 20, 100);
            lblLoHang.Location = new Point(671, 27);
            lblLoHang.Name = "lblLoHang";
            lblLoHang.Size = new Size(252, 79);
            lblLoHang.TabIndex = 13;
            lblLoHang.Text = "LÔ HÀNG";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 18;
            txtTimKiem.BorderThickness = 0;
            txtTimKiem.CustomizableEdges = customizableEdges4;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Open Sans", 12F);
            txtTimKiem.IconRight = (Image)resources.GetObject("txtTimKiem.IconRight");
            txtTimKiem.IconRightSize = new Size(53, 53);
            txtTimKiem.Location = new Point(64, 172);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtTimKiem.Size = new Size(722, 58);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvLoHang
            // 
            dgvLoHang.AllowUserToAddRows = false;
            dgvLoHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvLoHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoHang.BorderStyle = BorderStyle.FixedSingle;
            dgvLoHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLoHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLoHang.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLoHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLoHang.GridColor = Color.FromArgb(231, 229, 255);
            dgvLoHang.Location = new Point(64, 290);
            dgvLoHang.Name = "dgvLoHang";
            dgvLoHang.ReadOnly = true;
            dgvLoHang.RowHeadersVisible = false;
            dgvLoHang.RowHeadersWidth = 51;
            dgvLoHang.Size = new Size(1465, 756);
            dgvLoHang.TabIndex = 2;
            dgvLoHang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvLoHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvLoHang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvLoHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvLoHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvLoHang.ThemeStyle.BackColor = Color.White;
            dgvLoHang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvLoHang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvLoHang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLoHang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvLoHang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvLoHang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLoHang.ThemeStyle.HeaderStyle.Height = 29;
            dgvLoHang.ThemeStyle.ReadOnly = true;
            dgvLoHang.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvLoHang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLoHang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvLoHang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvLoHang.ThemeStyle.RowsStyle.Height = 29;
            dgvLoHang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvLoHang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvLoHang.CellDoubleClick += dgvLoHang_CellDoubleClick;
            // 
            // frmLoHang
            // 
            ClientSize = new Size(1570, 1080);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLoHang";
            Text = "Lô Hàng";
            WindowState = FormWindowState.Maximized;
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoHang).EndInit();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoHang;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnThem;
    }
}