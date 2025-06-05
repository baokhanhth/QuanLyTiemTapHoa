namespace QuanLyTiemTapHoa
{
    partial class frmThongTinKhachHang
    {
        private System.ComponentModel.IContainer components = null;

        // UI Controls
        private Guna.UI2.WinForms.Guna2GradientPanel pnlBackground;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinKhachHang));
            pnlBackground = new Guna.UI2.WinForms.Guna2GradientPanel();
            tbtnUpdate = new Guna.UI2.WinForms.Guna2GradientTileButton();
            tbtnDelete = new Guna.UI2.WinForms.Guna2GradientTileButton();
            txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle = new Label();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pnlBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.Transparent;
            pnlBackground.BorderRadius = 20;
            pnlBackground.Controls.Add(tbtnUpdate);
            pnlBackground.Controls.Add(tbtnDelete);
            pnlBackground.Controls.Add(txtDiaChi);
            pnlBackground.Controls.Add(txtSDT);
            pnlBackground.Controls.Add(txtTenKH);
            pnlBackground.Controls.Add(txtMaKH);
            pnlBackground.Controls.Add(lblTitle);
            pnlBackground.Controls.Add(btnClose);
            pnlBackground.CustomizableEdges = customizableEdges15;
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.FillColor = Color.Violet;
            pnlBackground.FillColor2 = Color.PowderBlue;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.ShadowDecoration.CustomizableEdges = customizableEdges16;
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
            tbtnUpdate.Location = new Point(61, 407);
            tbtnUpdate.Name = "tbtnUpdate";
            tbtnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbtnUpdate.Size = new Size(160, 40);
            tbtnUpdate.TabIndex = 26;
            tbtnUpdate.Text = "Cập nhật";
            tbtnUpdate.TextOffset = new Point(25, -25);
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
            tbtnDelete.Location = new Point(270, 407);
            tbtnDelete.Name = "tbtnDelete";
            tbtnDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbtnDelete.Size = new Size(160, 40);
            tbtnDelete.TabIndex = 25;
            tbtnDelete.Text = "Xóa";
            tbtnDelete.TextOffset = new Point(20, -22);
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderRadius = 10;
            txtDiaChi.CustomizableEdges = customizableEdges5;
            txtDiaChi.DefaultText = "";
            txtDiaChi.Font = new Font("Open Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiaChi.ForeColor = Color.Black;
            txtDiaChi.Location = new Point(50, 235);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderForeColor = Color.Black;
            txtDiaChi.PlaceholderText = "Địa Chỉ";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.SelectedText = "";
            txtDiaChi.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtDiaChi.Size = new Size(400, 80);
            txtDiaChi.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.BorderRadius = 10;
            txtSDT.CustomizableEdges = customizableEdges7;
            txtSDT.DefaultText = "";
            txtSDT.Font = new Font("Open Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSDT.ForeColor = Color.Black;
            txtSDT.Location = new Point(50, 342);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderForeColor = Color.Black;
            txtSDT.PlaceholderText = "Số Điện Thoại";
            txtSDT.ReadOnly = true;
            txtSDT.SelectedText = "";
            txtSDT.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSDT.Size = new Size(400, 35);
            txtSDT.TabIndex = 1;
            // 
            // txtTenKH
            // 
            txtTenKH.BorderRadius = 10;
            txtTenKH.CustomizableEdges = customizableEdges9;
            txtTenKH.DefaultText = "";
            txtTenKH.Font = new Font("Open Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenKH.ForeColor = Color.Black;
            txtTenKH.Location = new Point(50, 171);
            txtTenKH.Margin = new Padding(3, 4, 3, 4);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.PlaceholderForeColor = Color.Black;
            txtTenKH.PlaceholderText = "Tên Khách Hàng";
            txtTenKH.ReadOnly = true;
            txtTenKH.SelectedText = "";
            txtTenKH.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtTenKH.Size = new Size(400, 35);
            txtTenKH.TabIndex = 2;
            // 
            // txtMaKH
            // 
            txtMaKH.AutoSize = true;
            txtMaKH.BorderRadius = 10;
            txtMaKH.CustomizableEdges = customizableEdges11;
            txtMaKH.DefaultText = "";
            txtMaKH.Font = new Font("Open Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaKH.ForeColor = Color.Black;
            txtMaKH.Location = new Point(50, 109);
            txtMaKH.Margin = new Padding(3, 4, 3, 4);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.PlaceholderForeColor = Color.Black;
            txtMaKH.PlaceholderText = "Mã Khách Hàng";
            txtMaKH.ReadOnly = true;
            txtMaKH.SelectedText = "";
            txtMaKH.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtMaKH.Size = new Size(400, 42);
            txtMaKH.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Open Sans ExtraBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(27, 20, 100);
            lblTitle.Location = new Point(80, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(315, 33);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 12;
            btnClose.CustomizableEdges = customizableEdges13;
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.cancel_50px;
            btnClose.ImageSize = new Size(50, 50);
            btnClose.Location = new Point(438, 21);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 5;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmThongTinKhachHang
            // 
            ClientSize = new Size(500, 600);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmThongTinKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ResumeLayout(false);
        }

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnDelete;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnUpdate;
    }
}
#endregion


