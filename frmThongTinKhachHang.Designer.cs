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
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinKhachHang));
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlBackground = new Guna.UI2.WinForms.Guna2GradientPanel();
            cpbDelete = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cpbUpdate = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle = new Label();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cpbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpbUpdate).BeginInit();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.Transparent;
            pnlBackground.BorderRadius = 20;
            pnlBackground.Controls.Add(cpbDelete);
            pnlBackground.Controls.Add(cpbUpdate);
            pnlBackground.Controls.Add(txtDiaChi);
            pnlBackground.Controls.Add(txtSDT);
            pnlBackground.Controls.Add(txtTenKH);
            pnlBackground.Controls.Add(txtMaKH);
            pnlBackground.Controls.Add(lblTitle);
            pnlBackground.Controls.Add(btnClose);
            pnlBackground.Controls.Add(btnUpdate);
            pnlBackground.Controls.Add(btnDelete);
            pnlBackground.CustomizableEdges = customizableEdges17;
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.FillColor = Color.Violet;
            pnlBackground.FillColor2 = Color.PowderBlue;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.ShadowDecoration.CustomizableEdges = customizableEdges18;
            pnlBackground.Size = new Size(500, 600);
            pnlBackground.TabIndex = 0;
            // 
            // cpbDelete
            // 
            cpbDelete.FillColor = Color.Transparent;
            cpbDelete.Image = (Image)resources.GetObject("cpbDelete.Image");
            cpbDelete.ImageLocation = "0";
            cpbDelete.ImageRotate = 0F;
            cpbDelete.Location = new Point(290, 408);
            cpbDelete.Name = "cpbDelete";
            cpbDelete.ShadowDecoration.CustomizableEdges = customizableEdges1;
            cpbDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbDelete.Size = new Size(38, 38);
            cpbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbDelete.TabIndex = 9;
            cpbDelete.TabStop = false;
            cpbDelete.UseTransparentBackground = true;
            // 
            // cpbUpdate
            // 
            cpbUpdate.FillColor = Color.Transparent;
            cpbUpdate.Image = Properties.Resources.updated;
            cpbUpdate.ImageRotate = 0F;
            cpbUpdate.Location = new Point(56, 407);
            cpbUpdate.Name = "cpbUpdate";
            cpbUpdate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cpbUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbUpdate.Size = new Size(40, 40);
            cpbUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbUpdate.TabIndex = 8;
            cpbUpdate.TabStop = false;
            cpbUpdate.UseTransparentBackground = true;
            cpbUpdate.UseWaitCursor = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderRadius = 10;
            txtDiaChi.CustomizableEdges = customizableEdges3;
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
            txtDiaChi.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDiaChi.Size = new Size(400, 80);
            txtDiaChi.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.BorderRadius = 10;
            txtSDT.CustomizableEdges = customizableEdges5;
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
            txtSDT.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSDT.Size = new Size(400, 35);
            txtSDT.TabIndex = 1;
            // 
            // txtTenKH
            // 
            txtTenKH.BorderRadius = 10;
            txtTenKH.CustomizableEdges = customizableEdges7;
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
            txtTenKH.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtTenKH.Size = new Size(400, 35);
            txtTenKH.TabIndex = 2;
            // 
            // txtMaKH
            // 
            txtMaKH.AutoSize = true;
            txtMaKH.BorderRadius = 10;
            txtMaKH.CustomizableEdges = customizableEdges9;
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
            txtMaKH.ShadowDecoration.CustomizableEdges = customizableEdges10;
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
            btnClose.CustomizableEdges = customizableEdges11;
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.cancel_50px;
            btnClose.ImageSize = new Size(50, 50);
            btnClose.Location = new Point(438, 21);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.BorderRadius = 18;
            btnUpdate.CustomizableEdges = customizableEdges13;
            btnUpdate.FillColor = Color.White;
            btnUpdate.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(27, 20, 100);
            btnUpdate.Location = new Point(56, 407);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnUpdate.Size = new Size(160, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.TextAlign = HorizontalAlignment.Right;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BorderRadius = 18;
            btnDelete.CustomizableEdges = customizableEdges15;
            btnDelete.FillColor = Color.White;
            btnDelete.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(27, 20, 100);
            btnDelete.Location = new Point(273, 407);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnDelete.Size = new Size(160, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.TextAlign = HorizontalAlignment.Right;
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
            ((System.ComponentModel.ISupportInitialize)cpbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpbUpdate).EndInit();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbDelete;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbUpdate;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
        #endregion


