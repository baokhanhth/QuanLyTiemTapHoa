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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinLichSuTraNo));
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
            pnlBackground = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            cpbDelete = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cpbUpdate = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            txtMaNo = new Guna.UI2.WinForms.Guna2TextBox();
            txtNgayTra = new Guna.UI2.WinForms.Guna2TextBox();
            txtSoTienTra = new Guna.UI2.WinForms.Guna2TextBox();
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
            pnlBackground.Controls.Add(txtMaNo);
            pnlBackground.Controls.Add(txtNgayTra);
            pnlBackground.Controls.Add(txtSoTienTra);
            pnlBackground.Controls.Add(lblTitle);
            pnlBackground.Controls.Add(btnUpdate);
            pnlBackground.Controls.Add(btnDelete);
            pnlBackground.CustomizableEdges = customizableEdges14;
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.FillColor = Color.Violet;
            pnlBackground.FillColor2 = Color.PowderBlue;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.ShadowDecoration.CustomizableEdges = customizableEdges15;
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
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 10;
            btnClose.Click += BtnClose_Click;
            // 
            // cpbDelete
            // 
            cpbDelete.FillColor = Color.Transparent;
            cpbDelete.Image = (Image)resources.GetObject("cpbDelete.Image");
            cpbDelete.ImageRotate = 0F;
            cpbDelete.Location = new Point(280, 408);
            cpbDelete.Name = "cpbDelete";
            cpbDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cpbDelete.Size = new Size(38, 38);
            cpbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbDelete.TabIndex = 11;
            cpbDelete.TabStop = false;
            cpbDelete.UseTransparentBackground = true;
            // 
            // cpbUpdate
            // 
            cpbUpdate.FillColor = Color.Transparent;
            cpbUpdate.Image = (Image)resources.GetObject("cpbUpdate.Image");
            cpbUpdate.ImageRotate = 0F;
            cpbUpdate.Location = new Point(56, 407);
            cpbUpdate.Name = "cpbUpdate";
            cpbUpdate.ShadowDecoration.CustomizableEdges = customizableEdges3;
            cpbUpdate.Size = new Size(40, 40);
            cpbUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbUpdate.TabIndex = 12;
            cpbUpdate.TabStop = false;
            cpbUpdate.UseTransparentBackground = true;
            // 
            // txtMaNo
            // 
            txtMaNo.BorderRadius = 10;
            txtMaNo.CustomizableEdges = customizableEdges4;
            txtMaNo.DefaultText = "";
            txtMaNo.Font = new Font("Open Sans Extrabold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaNo.ForeColor = Color.Black;
            txtMaNo.Location = new Point(33, 154);
            txtMaNo.Margin = new Padding(3, 4, 3, 4);
            txtMaNo.Name = "txtMaNo";
            txtMaNo.PlaceholderText = "Mã Nợ";
            txtMaNo.ReadOnly = true;
            txtMaNo.SelectedText = "";
            txtMaNo.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtMaNo.Size = new Size(400, 40);
            txtMaNo.TabIndex = 0;
            // 
            // txtNgayTra
            // 
            txtNgayTra.BorderRadius = 10;
            txtNgayTra.CustomizableEdges = customizableEdges6;
            txtNgayTra.DefaultText = "";
            txtNgayTra.Font = new Font("Open Sans Extrabold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNgayTra.ForeColor = Color.Black;
            txtNgayTra.Location = new Point(33, 241);
            txtNgayTra.Margin = new Padding(3, 4, 3, 4);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.PlaceholderText = "Ngày Trả";
            txtNgayTra.ReadOnly = true;
            txtNgayTra.SelectedText = "";
            txtNgayTra.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtNgayTra.Size = new Size(400, 40);
            txtNgayTra.TabIndex = 1;
            txtNgayTra.TextChanged += txtNgayTra_TextChanged;
            // 
            // txtSoTienTra
            // 
            txtSoTienTra.BorderRadius = 10;
            txtSoTienTra.CustomizableEdges = customizableEdges8;
            txtSoTienTra.DefaultText = "";
            txtSoTienTra.Font = new Font("Open Sans Extrabold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSoTienTra.ForeColor = Color.Black;
            txtSoTienTra.Location = new Point(33, 329);
            txtSoTienTra.Margin = new Padding(3, 4, 3, 4);
            txtSoTienTra.Name = "txtSoTienTra";
            txtSoTienTra.PlaceholderText = "Số Tiền Trả";
            txtSoTienTra.ReadOnly = true;
            txtSoTienTra.SelectedText = "";
            txtSoTienTra.ShadowDecoration.CustomizableEdges = customizableEdges9;
            txtSoTienTra.Size = new Size(400, 50);
            txtSoTienTra.TabIndex = 2;
            txtSoTienTra.TextChanged += txtSoTienTra_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Open Sans Extrabold", 13.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(27, 20, 100);
            lblTitle.Location = new Point(80, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(293, 32);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "THÔNG TIN LỊCH SỬ TRẢ NỢ";
            // 
            // btnUpdate
            // 
            btnUpdate.BorderRadius = 18;
            btnUpdate.CustomizableEdges = customizableEdges10;
            btnUpdate.FillColor = Color.White;
            btnUpdate.Font = new Font("Open Sans Extrabold", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.FromArgb(27, 20, 100);
            btnUpdate.Location = new Point(56, 406);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnUpdate.Size = new Size(160, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.TextOffset = new Point(15, 0);
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 18;
            btnDelete.CustomizableEdges = customizableEdges12;
            btnDelete.FillColor = Color.White;
            btnDelete.Font = new Font("Open Sans Extrabold", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(27, 20, 100);
            btnDelete.Location = new Point(273, 407);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges13;
            btnDelete.Size = new Size(160, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
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
            ((System.ComponentModel.ISupportInitialize)cpbDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpbUpdate).EndInit();
            ResumeLayout(false);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}