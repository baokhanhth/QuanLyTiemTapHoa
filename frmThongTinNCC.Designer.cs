using QuanLyTiemTapHoa;

namespace QuanLiTiemTapHoa
{
    partial class frmThongTinNCC
    {
        private System.ComponentModel.IContainer components = null;

        // UI Controls
        private Guna.UI2.WinForms.Guna2GradientPanel pnlBackground;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNCC;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinNCC));
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
            pnlBackground = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            cpbDelete = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cpbUpdate = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            txtTenNCC = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaNCC = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle = new Label();
            btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cpbDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpbUpdate).BeginInit();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.Transparent;
            pnlBackground.BorderRadius = 20;
            pnlBackground.Controls.Add(btnClose);
            pnlBackground.Controls.Add(cpbDelete);
            pnlBackground.Controls.Add(cpbUpdate);
            pnlBackground.Controls.Add(txtDiaChi);
            pnlBackground.Controls.Add(txtSDT);
            pnlBackground.Controls.Add(txtTenNCC);
            pnlBackground.Controls.Add(txtMaNCC);
            pnlBackground.Controls.Add(lblTitle);
            pnlBackground.Controls.Add(btnUpdate);
            pnlBackground.Controls.Add(btnDelete);
            pnlBackground.CustomizableEdges = customizableEdges16;
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.FillColor = Color.Violet;
            pnlBackground.FillColor2 = Color.PowderBlue;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.ShadowDecoration.CustomizableEdges = customizableEdges17;
            pnlBackground.Size = new Size(500, 600);
            pnlBackground.TabIndex = 0;
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
            btnClose.Location = new Point(438, 12);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 10;
            //btnClose.Click += btnClose_Click;
            // 
            // cpbDelete
            // 
            cpbDelete.FillColor = Color.Transparent;
            cpbDelete.Image = (Image)resources.GetObject("cpbDelete.Image");
            cpbDelete.ImageRotate = 0F;
            cpbDelete.Location = new Point(280, 408);
            cpbDelete.Name = "cpbDelete";
            cpbDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cpbDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbDelete.Size = new Size(38, 38);
            cpbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbDelete.TabIndex = 9;
            cpbDelete.TabStop = false;
            cpbDelete.UseTransparentBackground = true;
            cpbDelete.UseWaitCursor = true;
            // 
            // cpbUpdate
            // 
            cpbUpdate.FillColor = Color.Transparent;
            cpbUpdate.Image = (Image)resources.GetObject("cpbUpdate.Image");
            cpbUpdate.ImageRotate = 0F;
            cpbUpdate.Location = new Point(56, 407);
            cpbUpdate.Name = "cpbUpdate";
            cpbUpdate.ShadowDecoration.CustomizableEdges = customizableEdges3;
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
            txtDiaChi.CustomizableEdges = customizableEdges4;
            txtDiaChi.DefaultText = "";
            txtDiaChi.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiaChi.ForeColor = Color.Black;
            txtDiaChi.Location = new Point(50, 235);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderForeColor = Color.Black;
            txtDiaChi.PlaceholderText = "Địa Chỉ";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.SelectedText = "";
            txtDiaChi.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtDiaChi.Size = new Size(400, 80);
            txtDiaChi.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.BorderRadius = 10;
            txtSDT.CustomizableEdges = customizableEdges6;
            txtSDT.DefaultText = "";
            txtSDT.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSDT.ForeColor = Color.Black;
            txtSDT.Location = new Point(50, 342);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.PlaceholderForeColor = Color.Black;
            txtSDT.PlaceholderText = "Số Điện Thoại";
            txtSDT.ReadOnly = true;
            txtSDT.SelectedText = "";
            txtSDT.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtSDT.Size = new Size(400, 35);
            txtSDT.TabIndex = 1;
            // 
            // txtTenNCC
            // 
            txtTenNCC.BorderRadius = 10;
            txtTenNCC.CustomizableEdges = customizableEdges8;
            txtTenNCC.DefaultText = "";
            txtTenNCC.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenNCC.ForeColor = Color.Black;
            txtTenNCC.Location = new Point(50, 171);
            txtTenNCC.Margin = new Padding(3, 4, 3, 4);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.PlaceholderForeColor = Color.Black;
            txtTenNCC.PlaceholderText = "Tên Nhà Cung Cấp";
            txtTenNCC.ReadOnly = true;
            txtTenNCC.SelectedText = "";
            txtTenNCC.ShadowDecoration.CustomizableEdges = customizableEdges9;
            txtTenNCC.Size = new Size(400, 37);
            txtTenNCC.TabIndex = 2;
            // 
            // txtMaNCC
            // 
            txtMaNCC.AutoSize = true;
            txtMaNCC.BorderRadius = 10;
            txtMaNCC.CustomizableEdges = customizableEdges10;
            txtMaNCC.DefaultText = "";
            txtMaNCC.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaNCC.ForeColor = Color.Black;
            txtMaNCC.Location = new Point(50, 109);
            txtMaNCC.Margin = new Padding(3, 4, 3, 4);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.PlaceholderForeColor = Color.Black;
            txtMaNCC.PlaceholderText = "Mã Nhà Cung Cấp";
            txtMaNCC.ReadOnly = true;
            txtMaNCC.SelectedText = "";
            txtMaNCC.ShadowDecoration.CustomizableEdges = customizableEdges11;
            txtMaNCC.Size = new Size(400, 37);
            txtMaNCC.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Open Sans Extrabold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(27, 20, 100);
            lblTitle.Location = new Point(80, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(334, 32);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.BorderRadius = 18;
            btnUpdate.CustomizableEdges = customizableEdges12;
            btnUpdate.FillColor = Color.White;
            btnUpdate.Font = new Font("Open Sans Extrabold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(27, 20, 100);
            btnUpdate.Location = new Point(56, 407);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges13;
            btnUpdate.Size = new Size(160, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.TextAlign = HorizontalAlignment.Right;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BorderRadius = 18;
            btnDelete.CustomizableEdges = customizableEdges14;
            btnDelete.FillColor = Color.White;
            btnDelete.Font = new Font("Open Sans Extrabold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(27, 20, 100);
            btnDelete.Location = new Point(273, 407);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges15;
            btnDelete.Size = new Size(160, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.TextAlign = HorizontalAlignment.Right;
            // 
            // frmThongTinNCC
            // 
            ClientSize = new Size(500, 600);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThongTinNCC";
            StartPosition = FormStartPosition.CenterScreen;
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cpbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpbUpdate).EndInit();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbDelete;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbUpdate;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
    }
} 
#endregion 