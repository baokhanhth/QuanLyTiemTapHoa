namespace QuanLyTiemTapHoa
{
    partial class frmHangHoa
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
            panelContent = new Guna.UI2.WinForms.Guna2Panel();
            tbtnThem = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            lblHangHoa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            dgvHangHoa = new Guna.UI2.WinForms.Guna2DataGridView();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(196, 217, 255);
            panelContent.Controls.Add(tbtnThem);
            panelContent.Controls.Add(btnExit);
            panelContent.Controls.Add(lblHangHoa);
            panelContent.Controls.Add(txtTimKiem);
            panelContent.Controls.Add(dgvHangHoa);
            panelContent.CustomizableEdges = customizableEdges6;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.ShadowDecoration.CustomizableEdges = customizableEdges7;
            panelContent.Size = new Size(1570, 1033);
            panelContent.TabIndex = 3;
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
            tbtnThem.Location = new Point(1328, 150);
            tbtnThem.Name = "tbtnThem";
            tbtnThem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbtnThem.Size = new Size(191, 58);
            tbtnThem.TabIndex = 24;
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
            btnExit.Location = new Point(1469, 41);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 21;
            btnExit.Click += btnExit_Click;
            // 
            // lblHangHoa
            // 
            lblHangHoa.BackColor = Color.Transparent;
            lblHangHoa.Font = new Font("Open Sans ExtraBold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHangHoa.ForeColor = Color.FromArgb(27, 20, 100);
            lblHangHoa.Location = new Point(637, 12);
            lblHangHoa.Name = "lblHangHoa";
            lblHangHoa.Size = new Size(300, 79);
            lblHangHoa.TabIndex = 13;
            lblHangHoa.Text = "HÀNG HÓA";
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
            txtTimKiem.Location = new Point(54, 150);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtTimKiem.Size = new Size(722, 58);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.TabStop = false;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvHangHoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHangHoa.BorderStyle = BorderStyle.FixedSingle;
            dgvHangHoa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHangHoa.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHangHoa.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHangHoa.GridColor = Color.FromArgb(231, 229, 255);
            dgvHangHoa.Location = new Point(54, 251);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.ReadOnly = true;
            dgvHangHoa.RowHeadersVisible = false;
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.Size = new Size(1465, 770);
            dgvHangHoa.TabIndex = 2;
            dgvHangHoa.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvHangHoa.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvHangHoa.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvHangHoa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvHangHoa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvHangHoa.ThemeStyle.BackColor = Color.White;
            dgvHangHoa.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvHangHoa.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvHangHoa.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvHangHoa.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvHangHoa.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvHangHoa.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHangHoa.ThemeStyle.HeaderStyle.Height = 29;
            dgvHangHoa.ThemeStyle.ReadOnly = true;
            dgvHangHoa.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvHangHoa.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHangHoa.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvHangHoa.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvHangHoa.ThemeStyle.RowsStyle.Height = 29;
            dgvHangHoa.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvHangHoa.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmHangHoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1033);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHangHoa";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.Manual;
            Text = "frmHangHoa";
            WindowState = FormWindowState.Maximized;
            Load += frmHangHoa_Load;
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHangHoa;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHangHoa;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbHangHoa;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbKhachHang;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbHomePage;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnHangHoa;
        //private Guna.UI2.WinForms.Guna2GradientTileButton btnTrangChu;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnThem;
    }
}