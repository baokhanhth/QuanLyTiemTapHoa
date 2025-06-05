namespace QuanLyTiemTapHoa
{
    partial class frmChiTietNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietNhapHang));
            PanelCapNhatGia = new Guna.UI2.WinForms.Guna2Panel();
            tbtnThem = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            lblChiTietNH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvChiTietNhapHang = new Guna.UI2.WinForms.Guna2DataGridView();
            PanelCapNhatGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietNhapHang).BeginInit();
            SuspendLayout();
            // 
            // PanelCapNhatGia
            // 
            PanelCapNhatGia.BackColor = Color.Transparent;
            PanelCapNhatGia.Controls.Add(tbtnThem);
            PanelCapNhatGia.Controls.Add(btnExit);
            PanelCapNhatGia.Controls.Add(lblChiTietNH);
            PanelCapNhatGia.Controls.Add(dgvChiTietNhapHang);
            PanelCapNhatGia.CustomizableEdges = customizableEdges4;
            PanelCapNhatGia.Location = new Point(1, -2);
            PanelCapNhatGia.Name = "PanelCapNhatGia";
            PanelCapNhatGia.ShadowDecoration.CustomizableEdges = customizableEdges5;
            PanelCapNhatGia.Size = new Size(980, 756);
            PanelCapNhatGia.TabIndex = 2;
            PanelCapNhatGia.UseTransparentBackground = true;
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
            tbtnThem.Location = new Point(752, 102);
            tbtnThem.Name = "tbtnThem";
            tbtnThem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbtnThem.Size = new Size(191, 58);
            tbtnThem.TabIndex = 26;
            tbtnThem.Text = "Thêm";
            tbtnThem.TextOffset = new Point(40, -30);
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
            btnExit.Location = new Point(893, 10);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 25;
            btnExit.Click += btnExit_Click;
            // 
            // lblChiTietNH
            // 
            lblChiTietNH.BackColor = Color.Transparent;
            lblChiTietNH.Font = new Font("Open Sans ExtraBold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChiTietNH.ForeColor = Color.FromArgb(27, 20, 100);
            lblChiTietNH.Location = new Point(191, 10);
            lblChiTietNH.Name = "lblChiTietNH";
            lblChiTietNH.Size = new Size(565, 79);
            lblChiTietNH.TabIndex = 14;
            lblChiTietNH.Text = "CHI TIẾT NHẬP HÀNG";
            // 
            // dgvChiTietNhapHang
            // 
            dgvChiTietNhapHang.AllowUserToAddRows = false;
            dgvChiTietNhapHang.AllowUserToDeleteRows = false;
            dgvChiTietNhapHang.AllowUserToResizeColumns = false;
            dgvChiTietNhapHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dgvChiTietNhapHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietNhapHang.BackgroundColor = Color.FromArgb(232, 249, 255);
            dgvChiTietNhapHang.BorderStyle = BorderStyle.FixedSingle;
            dgvChiTietNhapHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvChiTietNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTietNhapHang.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvChiTietNhapHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgvChiTietNhapHang.GridColor = Color.FromArgb(231, 229, 255);
            dgvChiTietNhapHang.Location = new Point(40, 177);
            dgvChiTietNhapHang.Name = "dgvChiTietNhapHang";
            dgvChiTietNhapHang.ReadOnly = true;
            dgvChiTietNhapHang.RowHeadersVisible = false;
            dgvChiTietNhapHang.RowHeadersWidth = 51;
            dgvChiTietNhapHang.Size = new Size(903, 540);
            dgvChiTietNhapHang.TabIndex = 3;
            dgvChiTietNhapHang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvChiTietNhapHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvChiTietNhapHang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvChiTietNhapHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvChiTietNhapHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvChiTietNhapHang.ThemeStyle.BackColor = Color.FromArgb(232, 249, 255);
            dgvChiTietNhapHang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvChiTietNhapHang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvChiTietNhapHang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvChiTietNhapHang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvChiTietNhapHang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvChiTietNhapHang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvChiTietNhapHang.ThemeStyle.HeaderStyle.Height = 29;
            dgvChiTietNhapHang.ThemeStyle.ReadOnly = true;
            dgvChiTietNhapHang.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvChiTietNhapHang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChiTietNhapHang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvChiTietNhapHang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvChiTietNhapHang.ThemeStyle.RowsStyle.Height = 29;
            dgvChiTietNhapHang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvChiTietNhapHang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmChiTietNhapHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 217, 255);
            ClientSize = new Size(982, 753);
            Controls.Add(PanelCapNhatGia);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmChiTietNhapHang";
            Text = "frmChiTietNhapHang";
            PanelCapNhatGia.ResumeLayout(false);
            PanelCapNhatGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietNhapHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelCapNhatGia;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnThem;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChiTietNH;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChiTietNhapHang;
    }
}