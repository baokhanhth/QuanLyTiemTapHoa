namespace QuanLyTiemTapHoa
{
    partial class frmThongTinLichSuTraNo
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlBackground;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNo;
        private Guna.UI2.WinForms.Guna2TextBox txtNgayTra;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTienTra;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinLichSuTraNo));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlBackground = new Guna.UI2.WinForms.Guna2GradientPanel();
            tbtnUpdate = new Guna.UI2.WinForms.Guna2GradientTileButton();
            tbtnDelete = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            txtMaNo = new Guna.UI2.WinForms.Guna2TextBox();
            txtNgayTra = new Guna.UI2.WinForms.Guna2TextBox();
            txtSoTienTra = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle = new Label();
            pnlBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.Transparent;
            pnlBackground.BorderRadius = 20;
            pnlBackground.Controls.Add(tbtnUpdate);
            pnlBackground.Controls.Add(tbtnDelete);
            pnlBackground.Controls.Add(btnClose);
            pnlBackground.Controls.Add(txtMaNo);
            pnlBackground.Controls.Add(txtNgayTra);
            pnlBackground.Controls.Add(txtSoTienTra);
            pnlBackground.Controls.Add(lblTitle);
            pnlBackground.CustomizableEdges = customizableEdges12;
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.FillColor = Color.Violet;
            pnlBackground.FillColor2 = Color.PowderBlue;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.ShadowDecoration.CustomizableEdges = customizableEdges13;
            pnlBackground.Size = new Size(500, 600);
            pnlBackground.TabIndex = 0;
            // 
            // tbtnUpdate
            // 
            tbtnUpdate.BackColor = Color.Transparent;
            tbtnUpdate.BorderColor = Color.Transparent;
            tbtnUpdate.BorderRadius = 18;
            tbtnUpdate.CustomizableEdges = customizableEdges1;
            tbtnUpdate.DisabledState.BorderColor = Color.DarkGray;
            tbtnUpdate.DisabledState.CustomBorderColor = Color.DarkGray;
            tbtnUpdate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tbtnUpdate.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            tbtnUpdate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tbtnUpdate.FillColor = Color.White;
            tbtnUpdate.FillColor2 = Color.White;
            tbtnUpdate.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbtnUpdate.ForeColor = Color.FromArgb(28, 76, 119);
            tbtnUpdate.Image = Properties.Resources.updated;
            tbtnUpdate.ImageAlign = HorizontalAlignment.Left;
            tbtnUpdate.ImageOffset = new Point(0, 22);
            tbtnUpdate.ImageSize = new Size(40, 40);
            tbtnUpdate.ImeMode = ImeMode.NoControl;
            tbtnUpdate.Location = new Point(59, 439);
            tbtnUpdate.Name = "tbtnUpdate";
            tbtnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbtnUpdate.Size = new Size(160, 40);
            tbtnUpdate.TabIndex = 29;
            tbtnUpdate.Text = "Cập nhật";
            tbtnUpdate.TextOffset = new Point(25, -25);
            tbtnUpdate.Click += tbtnUpdate_Click;
            // 
            // tbtnDelete
            // 
            tbtnDelete.BackColor = Color.Transparent;
            tbtnDelete.BorderColor = Color.Transparent;
            tbtnDelete.BorderRadius = 18;
            tbtnDelete.CustomizableEdges = customizableEdges3;
            tbtnDelete.DisabledState.BorderColor = Color.DarkGray;
            tbtnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            tbtnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tbtnDelete.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            tbtnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tbtnDelete.FillColor = Color.White;
            tbtnDelete.FillColor2 = Color.White;
            tbtnDelete.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbtnDelete.ForeColor = Color.FromArgb(28, 76, 119);
            tbtnDelete.Image = Properties.Resources.delete;
            tbtnDelete.ImageAlign = HorizontalAlignment.Left;
            tbtnDelete.ImageOffset = new Point(0, 20);
            tbtnDelete.ImageSize = new Size(38, 38);
            tbtnDelete.ImeMode = ImeMode.NoControl;
            tbtnDelete.Location = new Point(273, 439);
            tbtnDelete.Name = "tbtnDelete";
            tbtnDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbtnDelete.Size = new Size(160, 40);
            tbtnDelete.TabIndex = 28;
            tbtnDelete.Text = "Xóa";
            tbtnDelete.TextOffset = new Point(20, -22);
            tbtnDelete.Click += tbtnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BorderColor = Color.Transparent;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageSize = new Size(50, 50);
            btnClose.Location = new Point(438, 13);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 14;
            //btnClose.Click += btnClose_Click_1;
            // 
            // txtMaNo
            // 
            txtMaNo.BorderRadius = 10;
            txtMaNo.CustomizableEdges = customizableEdges6;
            txtMaNo.DefaultText = "";
            txtMaNo.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaNo.ForeColor = Color.Black;
            txtMaNo.Location = new Point(33, 154);
            txtMaNo.Margin = new Padding(3, 4, 3, 4);
            txtMaNo.Name = "txtMaNo";
            txtMaNo.PlaceholderText = "Mã Nợ";
            txtMaNo.ReadOnly = true;
            txtMaNo.SelectedText = "";
            txtMaNo.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtMaNo.Size = new Size(400, 40);
            txtMaNo.TabIndex = 0;
            // 
            // txtNgayTra
            // 
            txtNgayTra.BorderRadius = 10;
            txtNgayTra.CustomizableEdges = customizableEdges8;
            txtNgayTra.DefaultText = "";
            txtNgayTra.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNgayTra.ForeColor = Color.Black;
            txtNgayTra.Location = new Point(33, 241);
            txtNgayTra.Margin = new Padding(3, 4, 3, 4);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.PlaceholderText = "Ngày Trả";
            txtNgayTra.ReadOnly = true;
            txtNgayTra.SelectedText = "";
            txtNgayTra.ShadowDecoration.CustomizableEdges = customizableEdges9;
            txtNgayTra.Size = new Size(400, 40);
            txtNgayTra.TabIndex = 1;
            //txtNgayTra.TextChanged += txtNgayTra_TextChanged;
            // 
            // txtSoTienTra
            // 
            txtSoTienTra.BorderRadius = 10;
            txtSoTienTra.CustomizableEdges = customizableEdges10;
            txtSoTienTra.DefaultText = "";
            txtSoTienTra.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoTienTra.ForeColor = Color.Black;
            txtSoTienTra.Location = new Point(33, 329);
            txtSoTienTra.Margin = new Padding(3, 4, 3, 4);
            txtSoTienTra.Name = "txtSoTienTra";
            txtSoTienTra.PlaceholderText = "Số Tiền Trả";
            txtSoTienTra.ReadOnly = true;
            txtSoTienTra.SelectedText = "";
            txtSoTienTra.ShadowDecoration.CustomizableEdges = customizableEdges11;
            txtSoTienTra.Size = new Size(400, 50);
            txtSoTienTra.TabIndex = 2;
            txtSoTienTra.TextChanged += txtSoTienTra_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Open Sans ExtraBold", 13.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 20, 100);
            lblTitle.Location = new Point(59, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(345, 33);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "THÔNG TIN LỊCH SỬ TRẢ NỢ";
            // 
            // frmThongTinLichSuTraNo
            // 
            ClientSize = new Size(500, 600);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThongTinLichSuTraNo";
            StartPosition = FormStartPosition.CenterScreen;
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ResumeLayout(false);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnDelete;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnUpdate;
    }
}