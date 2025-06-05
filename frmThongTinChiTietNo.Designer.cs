using QuanLiTiemTapHoa;

namespace QuanLyTiemTapHoa
{
    partial class frmThongTinChiTietNo
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlBackground;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNo;
        private Guna.UI2.WinForms.Guna2TextBox txtMaBH;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTienConNo;
        private System.Windows.Forms.Label lblTitle;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinChiTietNo));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlBackground = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            txtMaNo = new Guna.UI2.WinForms.Guna2TextBox();
            txtMaBH = new Guna.UI2.WinForms.Guna2TextBox();
            txtSoTienConNo = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle = new Label();
            tbtnUpdate = new Guna.UI2.WinForms.Guna2GradientTileButton();
            tbtnDelete = new Guna.UI2.WinForms.Guna2GradientTileButton();
            pnlBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.Transparent;
            pnlBackground.BorderRadius = 20;
            pnlBackground.Controls.Add(tbtnUpdate);
            pnlBackground.Controls.Add(btnClose);
            pnlBackground.Controls.Add(tbtnDelete);
            pnlBackground.Controls.Add(txtMaNo);
            pnlBackground.Controls.Add(txtMaBH);
            pnlBackground.Controls.Add(txtSoTienConNo);
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
            // btnClose
            // 
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageSize = new Size(50, 50);
            btnClose.Location = new Point(438, 12);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 10;
            btnClose.Click += BtnClose_Click;
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
            // txtMaBH
            // 
            txtMaBH.BorderRadius = 10;
            txtMaBH.CustomizableEdges = customizableEdges8;
            txtMaBH.DefaultText = "";
            txtMaBH.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaBH.ForeColor = Color.Black;
            txtMaBH.Location = new Point(33, 241);
            txtMaBH.Margin = new Padding(3, 4, 3, 4);
            txtMaBH.Name = "txtMaBH";
            txtMaBH.PlaceholderText = "Mã Bán Hàng";
            txtMaBH.ReadOnly = true;
            txtMaBH.SelectedText = "";
            txtMaBH.ShadowDecoration.CustomizableEdges = customizableEdges9;
            txtMaBH.Size = new Size(400, 40);
            txtMaBH.TabIndex = 1;
            // 
            // txtSoTienConNo
            // 
            txtSoTienConNo.BorderRadius = 10;
            txtSoTienConNo.CustomizableEdges = customizableEdges10;
            txtSoTienConNo.DefaultText = "";
            txtSoTienConNo.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoTienConNo.ForeColor = Color.Black;
            txtSoTienConNo.Location = new Point(33, 329);
            txtSoTienConNo.Margin = new Padding(3, 4, 3, 4);
            txtSoTienConNo.Name = "txtSoTienConNo";
            txtSoTienConNo.PlaceholderText = "Số Tiền Còn Nợ";
            txtSoTienConNo.ReadOnly = true;
            txtSoTienConNo.SelectedText = "";
            txtSoTienConNo.ShadowDecoration.CustomizableEdges = customizableEdges11;
            txtSoTienConNo.Size = new Size(400, 50);
            txtSoTienConNo.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Open Sans ExtraBold", 13.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 20, 100);
            lblTitle.Location = new Point(80, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 33);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "THÔNG TIN CHI TIẾT NỢ";
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
            tbtnUpdate.Location = new Point(49, 413);
            tbtnUpdate.Name = "tbtnUpdate";
            tbtnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbtnUpdate.Size = new Size(160, 40);
            tbtnUpdate.TabIndex = 30;
            tbtnUpdate.Text = "Cập nhật";
            tbtnUpdate.TextOffset = new Point(25, -25);
            tbtnUpdate.Click += tbtnUpdate_Click;
            // 
            // tbtnDelete
            // 
            tbtnDelete.BackColor = Color.Transparent;
            tbtnDelete.BorderColor = Color.Transparent;
            tbtnDelete.BorderRadius = 18;
            tbtnDelete.CustomizableEdges = customizableEdges4;
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
            tbtnDelete.Location = new Point(258, 413);
            tbtnDelete.Name = "tbtnDelete";
            tbtnDelete.ShadowDecoration.CustomizableEdges = customizableEdges5;
            tbtnDelete.Size = new Size(160, 40);
            tbtnDelete.TabIndex = 29;
            tbtnDelete.Text = "Xóa";
            tbtnDelete.TextOffset = new Point(20, -22);
            tbtnDelete.Click += tbtnDelete_Click;
            // 
            // frmThongTinChiTietNo
            // 
            ClientSize = new Size(500, 600);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThongTinChiTietNo";
            StartPosition = FormStartPosition.CenterScreen;
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ResumeLayout(false);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnUpdate;
        private Guna.UI2.WinForms.Guna2GradientTileButton tbtnDelete;
    }
}

