namespace QuanLyTiemTapHoa
{
    partial class frmNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNCC));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            lblNCC = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            dgvNCC = new Guna.UI2.WinForms.Guna2DataGridView();
            panelContent = new Guna.UI2.WinForms.Guna2Panel();
            tbtnThem = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ((System.ComponentModel.ISupportInitialize)dgvNCC).BeginInit();
            panelContent.SuspendLayout();
            SuspendLayout();
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
            btnExit.Location = new Point(1483, 12);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 21;
            btnExit.Click += btnExit_Click;
            // 
            // lblNCC
            // 
            lblNCC.BackColor = Color.Transparent;
            lblNCC.Font = new Font("Open Sans ExtraBold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNCC.ForeColor = Color.FromArgb(27, 20, 100);
            lblNCC.Location = new Point(634, 24);
            lblNCC.Name = "lblNCC";
            lblNCC.Size = new Size(416, 79);
            lblNCC.TabIndex = 13;
            lblNCC.Text = "NHÀ CUNG CẤP";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 18;
            txtTimKiem.BorderThickness = 0;
            txtTimKiem.CustomizableEdges = customizableEdges2;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            txtTimKiem.IconRight = (Image)resources.GetObject("txtTimKiem.IconRight");
            txtTimKiem.IconRightSize = new Size(53, 53);
            txtTimKiem.Location = new Point(77, 165);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtTimKiem.Size = new Size(722, 58);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvNCC
            // 
            dgvNCC.AllowUserToAddRows = false;
            dgvNCC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvNCC.BorderStyle = BorderStyle.FixedSingle;
            dgvNCC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNCC.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNCC.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNCC.GridColor = Color.FromArgb(231, 229, 255);
            dgvNCC.Location = new Point(77, 265);
            dgvNCC.Name = "dgvNCC";
            dgvNCC.ReadOnly = true;
            dgvNCC.RowHeadersVisible = false;
            dgvNCC.RowHeadersWidth = 51;
            dgvNCC.Size = new Size(1465, 790);
            dgvNCC.TabIndex = 2;
            dgvNCC.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvNCC.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvNCC.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvNCC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvNCC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvNCC.ThemeStyle.BackColor = Color.White;
            dgvNCC.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvNCC.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvNCC.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvNCC.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvNCC.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvNCC.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNCC.ThemeStyle.HeaderStyle.Height = 29;
            dgvNCC.ThemeStyle.ReadOnly = true;
            dgvNCC.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvNCC.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNCC.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvNCC.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvNCC.ThemeStyle.RowsStyle.Height = 29;
            dgvNCC.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvNCC.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(196, 217, 255);
            panelContent.Controls.Add(tbtnThem);
            panelContent.Controls.Add(btnExit);
            panelContent.Controls.Add(lblNCC);
            panelContent.Controls.Add(txtTimKiem);
            panelContent.Controls.Add(dgvNCC);
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
            tbtnThem.CustomizableEdges = customizableEdges4;
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
            tbtnThem.Location = new Point(1342, 165);
            tbtnThem.Name = "tbtnThem";
            tbtnThem.ShadowDecoration.CustomizableEdges = customizableEdges5;
            tbtnThem.Size = new Size(191, 58);
            tbtnThem.TabIndex = 26;
            tbtnThem.Text = "Thêm";
            tbtnThem.TextOffset = new Point(40, -30);
            tbtnThem.Click += tbtnThem_Click;
            // 
            // frmNCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1080);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNCC";
            Text = "frmNCC";
            Load += frmNCC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNCC).EndInit();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNCC;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnThem;
    }
}