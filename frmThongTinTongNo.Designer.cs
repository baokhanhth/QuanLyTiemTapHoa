namespace QuanLyTiemTapHoa
{
    partial class frmThongTinTongNo
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlBackground;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNo;
        private Guna.UI2.WinForms.Guna2TextBox mNgayTra;
        private Guna.UI2.WinForms.Guna2TextBox txtTongNo;
        private Guna.UI2.WinForms.Guna2TextBox txtTrangThai;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbDelete;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbUpdate;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinTongNo));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlBackground = new Guna.UI2.WinForms.Guna2GradientPanel();
            tbtnUpdate = new Guna.UI2.WinForms.Guna2GradientTileButton();
            tbtnDelete = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            txtMaNo = new Guna.UI2.WinForms.Guna2TextBox();
            mNgayTra = new Guna.UI2.WinForms.Guna2TextBox();
            txtTongNo = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle = new Label();
            txtTrangThai = new Guna.UI2.WinForms.Guna2TextBox();
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
            pnlBackground.Controls.Add(mNgayTra);
            pnlBackground.Controls.Add(txtTongNo);
            pnlBackground.Controls.Add(lblTitle);
            pnlBackground.CustomizableEdges = customizableEdges23;
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.FillColor = Color.Violet;
            pnlBackground.FillColor2 = Color.PowderBlue;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.ShadowDecoration.CustomizableEdges = customizableEdges24;
            pnlBackground.Size = new Size(500, 600);
            pnlBackground.TabIndex = 0;
            // 
            // tbtnUpdate
            // 
            tbtnUpdate.BackColor = Color.Transparent;
            tbtnUpdate.BorderColor = Color.Transparent;
            tbtnUpdate.BorderRadius = 18;
            tbtnUpdate.CustomizableEdges = customizableEdges13;
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
            tbtnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges14;
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
            tbtnDelete.CustomizableEdges = customizableEdges15;
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
            tbtnDelete.ShadowDecoration.CustomizableEdges = customizableEdges16;
            tbtnDelete.Size = new Size(160, 40);
            tbtnDelete.TabIndex = 25;
            tbtnDelete.Text = "Xóa";
            tbtnDelete.TextOffset = new Point(20, -22);
            // 
            // btnClose
            // 
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageSize = new Size(50, 50);
            btnClose.Location = new Point(438, 12);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges15;
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 10;
            // 
            // txtMaNo
            // 
            txtMaNo.BorderRadius = 10;
            txtMaNo.CustomizableEdges = customizableEdges17;
            txtMaNo.DefaultText = "";
            txtMaNo.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaNo.ForeColor = Color.Black;
            txtMaNo.Location = new Point(33, 154);
            txtMaNo.Margin = new Padding(3, 4, 3, 4);
            txtMaNo.Name = "txtMaNo";
            txtMaNo.PlaceholderText = "Mã Nợ";
            txtMaNo.ReadOnly = true;
            txtMaNo.SelectedText = "";
            txtMaNo.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtMaNo.Size = new Size(400, 40);
            txtMaNo.TabIndex = 0;
            // 
            // mNgayTra
            // 
            mNgayTra.BorderRadius = 10;
            mNgayTra.CustomizableEdges = customizableEdges19;
            mNgayTra.DefaultText = "";
            mNgayTra.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mNgayTra.ForeColor = Color.Black;
            mNgayTra.Location = new Point(33, 241);
            mNgayTra.Margin = new Padding(3, 4, 3, 4);
            mNgayTra.Name = "mNgayTra";
            mNgayTra.PlaceholderText = "Ngày Trả";
            mNgayTra.ReadOnly = true;
            mNgayTra.SelectedText = "";
            mNgayTra.ShadowDecoration.CustomizableEdges = customizableEdges20;
            mNgayTra.Size = new Size(400, 40);
            mNgayTra.TabIndex = 1;
            // 
            // txtTongNo
            // 
            txtTongNo.BorderRadius = 10;
            txtTongNo.CustomizableEdges = customizableEdges21;
            txtTongNo.DefaultText = "";
            txtTongNo.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTongNo.ForeColor = Color.Black;
            txtTongNo.Location = new Point(33, 329);
            txtTongNo.Margin = new Padding(3, 4, 3, 4);
            txtTongNo.Name = "txtTongNo";
            txtTongNo.PlaceholderText = "Số Tiền Nợ";
            txtTongNo.ReadOnly = true;
            txtTongNo.SelectedText = "";
            txtTongNo.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtTongNo.Size = new Size(400, 50);
            txtTongNo.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Open Sans ExtraBold", 13.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 20, 100);
            lblTitle.Location = new Point(97, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(266, 33);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "THÔNG TIN TỔNG NỢ";
            // 
            // txtTrangThai
            // 
            txtTrangThai.BorderRadius = 10;
            txtTrangThai.CustomizableEdges = customizableEdges9;
            txtTrangThai.DefaultText = "";
            txtTrangThai.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTrangThai.ForeColor = Color.Black;
            txtTrangThai.Location = new Point(33, 329);
            txtTrangThai.Margin = new Padding(3, 4, 3, 4);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.PlaceholderText = "Số Tiền Còn Nợ";
            txtTrangThai.ReadOnly = true;
            txtTrangThai.SelectedText = "";
            txtTrangThai.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtTrangThai.Size = new Size(400, 50);
            txtTrangThai.TabIndex = 2;
            // 
            // frmThongTinTongNo
            // 
            ClientSize = new Size(500, 600);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThongTinTongNo";
            StartPosition = FormStartPosition.CenterScreen;
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnDelete;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnUpdate;
    }
}