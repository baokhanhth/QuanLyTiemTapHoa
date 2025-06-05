namespace QuanLyTiemTapHoa
{
    partial class frmTongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTongNo));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelContent = new Guna.UI2.WinForms.Guna2Panel();
            tbtnThem = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            LabelTongNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            dgvTongNo = new Guna.UI2.WinForms.Guna2DataGridView();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTongNo).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(196, 217, 255);
            panelContent.BackgroundImageLayout = ImageLayout.Stretch;
            panelContent.Controls.Add(tbtnThem);
            panelContent.Controls.Add(btnExit);
            panelContent.Controls.Add(LabelTongNo);
            panelContent.Controls.Add(txtTimKiem);
            panelContent.Controls.Add(dgvTongNo);
            panelContent.CustomizableEdges = customizableEdges6;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.ShadowDecoration.CustomizableEdges = customizableEdges7;
            panelContent.Size = new Size(1570, 1080);
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
            tbtnThem.Location = new Point(1324, 156);
            tbtnThem.Name = "tbtnThem";
            tbtnThem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbtnThem.Size = new Size(191, 58);
            tbtnThem.TabIndex = 26;
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
            btnExit.Location = new Point(1465, 32);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 21;
            btnExit.Click += btnExit_Click;
            // 
            // LabelTongNo
            // 
            LabelTongNo.BackColor = Color.Transparent;
            LabelTongNo.Font = new Font("Open Sans ExtraBold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTongNo.ForeColor = Color.FromArgb(27, 20, 100);
            LabelTongNo.Location = new Point(708, 42);
            LabelTongNo.Name = "LabelTongNo";
            LabelTongNo.Size = new Size(262, 79);
            LabelTongNo.TabIndex = 13;
            LabelTongNo.Text = "TỔNG NỢ";
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
            txtTimKiem.Location = new Point(50, 156);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtTimKiem.Size = new Size(814, 58);
            txtTimKiem.TabIndex = 0;
            // 
            // dgvTongNo
            // 
            dgvTongNo.AllowUserToAddRows = false;
            dgvTongNo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvTongNo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTongNo.BorderStyle = BorderStyle.FixedSingle;
            dgvTongNo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTongNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTongNo.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTongNo.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTongNo.GridColor = Color.FromArgb(231, 229, 255);
            dgvTongNo.ImeMode = ImeMode.NoControl;
            dgvTongNo.Location = new Point(50, 246);
            dgvTongNo.Name = "dgvTongNo";
            dgvTongNo.ReadOnly = true;
            dgvTongNo.RowHeadersVisible = false;
            dgvTongNo.RowHeadersWidth = 51;
            dgvTongNo.Size = new Size(1465, 802);
            dgvTongNo.TabIndex = 2;
            dgvTongNo.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTongNo.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTongNo.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTongNo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTongNo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTongNo.ThemeStyle.BackColor = Color.White;
            dgvTongNo.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvTongNo.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTongNo.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTongNo.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvTongNo.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTongNo.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTongNo.ThemeStyle.HeaderStyle.Height = 29;
            dgvTongNo.ThemeStyle.ReadOnly = true;
            dgvTongNo.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTongNo.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTongNo.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvTongNo.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTongNo.ThemeStyle.RowsStyle.Height = 29;
            dgvTongNo.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTongNo.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmTongNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1080);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTongNo";
            Text = "LabelKhachHang";
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTongNo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelTongNo;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTongNo;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnThem;
    }
}