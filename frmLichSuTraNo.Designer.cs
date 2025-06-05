namespace QuanLyTiemTapHoa
{
    partial class frmLichSuTraNo
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuTraNo));
            lblLSTN = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            dgvLSTN = new Guna.UI2.WinForms.Guna2DataGridView();
            tbtnThem = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)dgvLSTN).BeginInit();
            SuspendLayout();
            // 
            // lblLSTN
            // 
            lblLSTN.BackColor = Color.Transparent;
            lblLSTN.Font = new Font("Open Sans ExtraBold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLSTN.ForeColor = Color.FromArgb(27, 20, 100);
            lblLSTN.Location = new Point(523, 12);
            lblLSTN.Name = "lblLSTN";
            lblLSTN.Size = new Size(442, 79);
            lblLSTN.TabIndex = 20;
            lblLSTN.Text = "LỊCH SỬ TRẢ NỢ";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 18;
            txtTimKiem.BorderThickness = 0;
            txtTimKiem.CustomizableEdges = customizableEdges1;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 12F);
            txtTimKiem.IconRight = Properties.Resources.search;
            txtTimKiem.IconRightSize = new Size(53, 53);
            txtTimKiem.Location = new Point(39, 138);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTimKiem.Size = new Size(722, 58);
            txtTimKiem.TabIndex = 21;
            // 
            // dgvLSTN
            // 
            dgvLSTN.AllowUserToAddRows = false;
            dgvLSTN.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvLSTN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLSTN.BorderStyle = BorderStyle.FixedSingle;
            dgvLSTN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLSTN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLSTN.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLSTN.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLSTN.GridColor = Color.FromArgb(231, 229, 255);
            dgvLSTN.Location = new Point(39, 233);
            dgvLSTN.Name = "dgvLSTN";
            dgvLSTN.ReadOnly = true;
            dgvLSTN.RowHeadersVisible = false;
            dgvLSTN.RowHeadersWidth = 51;
            dgvLSTN.Size = new Size(1465, 821);
            dgvLSTN.TabIndex = 22;
            dgvLSTN.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvLSTN.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvLSTN.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvLSTN.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvLSTN.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvLSTN.ThemeStyle.BackColor = Color.White;
            dgvLSTN.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvLSTN.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvLSTN.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLSTN.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvLSTN.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvLSTN.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLSTN.ThemeStyle.HeaderStyle.Height = 29;
            dgvLSTN.ThemeStyle.ReadOnly = true;
            dgvLSTN.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvLSTN.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLSTN.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvLSTN.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvLSTN.ThemeStyle.RowsStyle.Height = 29;
            dgvLSTN.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvLSTN.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // tbtnThem
            // 
            tbtnThem.BackColor = Color.Transparent;
            tbtnThem.BorderColor = Color.Transparent;
            tbtnThem.BorderRadius = 18;
            tbtnThem.CustomizableEdges = customizableEdges3;
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
            tbtnThem.Location = new Point(1313, 138);
            tbtnThem.Name = "tbtnThem";
            tbtnThem.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            btnExit.Location = new Point(1440, 12);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 25;
            btnExit.Click += btnExit_Click;
            // 
            // frmLichSuTraNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 217, 255);
            ClientSize = new Size(1570, 1080);
            Controls.Add(tbtnThem);
            Controls.Add(btnExit);
            Controls.Add(dgvLSTN);
            Controls.Add(txtTimKiem);
            Controls.Add(lblLSTN);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            Name = "frmLichSuTraNo";
            Text = "Form1";
            Load += frmLichSuTraNo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLSTN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLSTN;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLSTN;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnThem;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
    }
}