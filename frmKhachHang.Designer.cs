// KhachHangForm.Designer.cs
using Microsoft.Data.SqlClient;

namespace QuanLyTiemTapHoa
{
    partial class frmKhachHang
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelSidebar;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnNhaCungCap;
        private Guna.UI2.WinForms.Guna2Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnHangHoa;
        private Guna.UI2.WinForms.Guna2Button btnLoHang;
        private Guna.UI2.WinForms.Guna2Button btnNhapHang;
        private Guna.UI2.WinForms.Guna2Button btnHDBan;
        private Guna.UI2.WinForms.Guna2Button btnTongNo;
        private Guna.UI2.WinForms.Guna2Button btnLichSu;
        private Guna.UI2.WinForms.Guna2Button btnChiTietNo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges41 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges42 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            cpbChiTietNo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cpbTongNo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cpbHDB = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cpbLichSu = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cpbNhapHang = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cpbLoHang = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cpbHangHoa = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cpbKhachHang = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cbpNCC = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            cpbHomePage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            btnNhaCungCap = new Guna.UI2.WinForms.Guna2Button();
            btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            btnHangHoa = new Guna.UI2.WinForms.Guna2Button();
            btnLoHang = new Guna.UI2.WinForms.Guna2Button();
            btnNhapHang = new Guna.UI2.WinForms.Guna2Button();
            btnHDBan = new Guna.UI2.WinForms.Guna2Button();
            btnTongNo = new Guna.UI2.WinForms.Guna2Button();
            btnLichSu = new Guna.UI2.WinForms.Guna2Button();
            btnChiTietNo = new Guna.UI2.WinForms.Guna2Button();
            panelContent = new Guna.UI2.WinForms.Guna2Panel();
            btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            LabelKhachHang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            dgvKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cpbChiTietNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpbTongNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpbHDB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpbLichSu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpbNhapHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpbLoHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpbHangHoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpbKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbpNCC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cpbHomePage).BeginInit();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.AutoScroll = true;
            panelSidebar.AutoScrollMinSize = new Size(0, 1160);
            panelSidebar.BackColor = Color.FromArgb(197, 186, 255);
            panelSidebar.Controls.Add(txtUser);
            panelSidebar.Controls.Add(cpbChiTietNo);
            panelSidebar.Controls.Add(cpbTongNo);
            panelSidebar.Controls.Add(cpbHDB);
            panelSidebar.Controls.Add(cpbLichSu);
            panelSidebar.Controls.Add(cpbNhapHang);
            panelSidebar.Controls.Add(cpbLoHang);
            panelSidebar.Controls.Add(cpbHangHoa);
            panelSidebar.Controls.Add(cpbKhachHang);
            panelSidebar.Controls.Add(cbpNCC);
            panelSidebar.Controls.Add(cpbHomePage);
            panelSidebar.Controls.Add(btnTrangChu);
            panelSidebar.Controls.Add(btnNhaCungCap);
            panelSidebar.Controls.Add(btnKhachHang);
            panelSidebar.Controls.Add(btnHangHoa);
            panelSidebar.Controls.Add(btnLoHang);
            panelSidebar.Controls.Add(btnNhapHang);
            panelSidebar.Controls.Add(btnHDBan);
            panelSidebar.Controls.Add(btnTongNo);
            panelSidebar.Controls.Add(btnLichSu);
            panelSidebar.Controls.Add(btnChiTietNo);
            panelSidebar.CustomizableEdges = customizableEdges33;
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.ShadowDecoration.CustomizableEdges = customizableEdges34;
            panelSidebar.Size = new Size(350, 1055);
            panelSidebar.TabIndex = 0;
            // 
            // txtUser
            // 
            txtUser.BorderColor = Color.Transparent;
            txtUser.BorderRadius = 18;
            txtUser.BorderThickness = 0;
            txtUser.CustomizableEdges = customizableEdges1;
            txtUser.DefaultText = "";
            txtUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUser.FillColor = Color.FromArgb(197, 186, 255);
            txtUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Font = new Font("Open Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.FromArgb(27, 20, 100);
            txtUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.IconLeft = (Image)resources.GetObject("txtUser.IconLeft");
            txtUser.IconLeftSize = new Size(74, 74);
            txtUser.Location = new Point(16, 46);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Người dùng";
            txtUser.SelectedText = "";
            txtUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUser.Size = new Size(306, 78);
            txtUser.TabIndex = 19;
            // 
            // cpbChiTietNo
            // 
            cpbChiTietNo.BackColor = Color.Transparent;
            cpbChiTietNo.FillColor = Color.Transparent;
            cpbChiTietNo.Image = (Image)resources.GetObject("cpbChiTietNo.Image");
            cpbChiTietNo.ImageRotate = 0F;
            cpbChiTietNo.Location = new Point(26, 1088);
            cpbChiTietNo.Name = "cpbChiTietNo";
            cpbChiTietNo.ShadowDecoration.CustomizableEdges = customizableEdges3;
            cpbChiTietNo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbChiTietNo.Size = new Size(58, 58);
            cpbChiTietNo.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbChiTietNo.TabIndex = 18;
            cpbChiTietNo.TabStop = false;
            cpbChiTietNo.UseTransparentBackground = true;
            // 
            // cpbTongNo
            // 
            cpbTongNo.BackColor = Color.Transparent;
            cpbTongNo.FillColor = Color.Transparent;
            cpbTongNo.Image = (Image)resources.GetObject("cpbTongNo.Image");
            cpbTongNo.ImageRotate = 0F;
            cpbTongNo.Location = new Point(31, 902);
            cpbTongNo.Name = "cpbTongNo";
            cpbTongNo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cpbTongNo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbTongNo.Size = new Size(58, 58);
            cpbTongNo.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbTongNo.TabIndex = 17;
            cpbTongNo.TabStop = false;
            cpbTongNo.UseTransparentBackground = true;
            // 
            // cpbHDB
            // 
            cpbHDB.BackColor = Color.Transparent;
            cpbHDB.FillColor = Color.Transparent;
            cpbHDB.Image = (Image)resources.GetObject("cpbHDB.Image");
            cpbHDB.ImageRotate = 0F;
            cpbHDB.Location = new Point(31, 810);
            cpbHDB.Name = "cpbHDB";
            cpbHDB.ShadowDecoration.CustomizableEdges = customizableEdges5;
            cpbHDB.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbHDB.Size = new Size(58, 58);
            cpbHDB.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbHDB.TabIndex = 16;
            cpbHDB.TabStop = false;
            cpbHDB.UseTransparentBackground = true;
            // 
            // cpbLichSu
            // 
            cpbLichSu.BackColor = Color.Transparent;
            cpbLichSu.FillColor = Color.Transparent;
            cpbLichSu.Image = (Image)resources.GetObject("cpbLichSu.Image");
            cpbLichSu.ImageRotate = 0F;
            cpbLichSu.Location = new Point(29, 996);
            cpbLichSu.Name = "cpbLichSu";
            cpbLichSu.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cpbLichSu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbLichSu.Size = new Size(58, 58);
            cpbLichSu.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbLichSu.TabIndex = 16;
            cpbLichSu.TabStop = false;
            cpbLichSu.UseTransparentBackground = true;
            // 
            // cpbNhapHang
            // 
            cpbNhapHang.BackColor = Color.Transparent;
            cpbNhapHang.FillColor = Color.Transparent;
            cpbNhapHang.Image = (Image)resources.GetObject("cpbNhapHang.Image");
            cpbNhapHang.ImageRotate = 0F;
            cpbNhapHang.Location = new Point(31, 708);
            cpbNhapHang.Name = "cpbNhapHang";
            cpbNhapHang.ShadowDecoration.CustomizableEdges = customizableEdges7;
            cpbNhapHang.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbNhapHang.Size = new Size(58, 58);
            cpbNhapHang.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbNhapHang.TabIndex = 15;
            cpbNhapHang.TabStop = false;
            cpbNhapHang.UseTransparentBackground = true;
            // 
            // cpbLoHang
            // 
            cpbLoHang.BackColor = Color.Transparent;
            cpbLoHang.FillColor = Color.Transparent;
            cpbLoHang.Image = (Image)resources.GetObject("cpbLoHang.Image");
            cpbLoHang.ImageRotate = 0F;
            cpbLoHang.Location = new Point(31, 617);
            cpbLoHang.Name = "cpbLoHang";
            cpbLoHang.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cpbLoHang.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbLoHang.Size = new Size(58, 58);
            cpbLoHang.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbLoHang.TabIndex = 14;
            cpbLoHang.TabStop = false;
            cpbLoHang.UseTransparentBackground = true;
            // 
            // cpbHangHoa
            // 
            cpbHangHoa.BackColor = Color.Transparent;
            cpbHangHoa.FillColor = Color.Transparent;
            cpbHangHoa.Image = (Image)resources.GetObject("cpbHangHoa.Image");
            cpbHangHoa.ImageRotate = 0F;
            cpbHangHoa.Location = new Point(31, 521);
            cpbHangHoa.Name = "cpbHangHoa";
            cpbHangHoa.ShadowDecoration.CustomizableEdges = customizableEdges9;
            cpbHangHoa.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbHangHoa.Size = new Size(58, 58);
            cpbHangHoa.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbHangHoa.TabIndex = 13;
            cpbHangHoa.TabStop = false;
            cpbHangHoa.UseTransparentBackground = true;
            cpbHangHoa.UseWaitCursor = true;
            // 
            // cpbKhachHang
            // 
            cpbKhachHang.BackColor = Color.Transparent;
            cpbKhachHang.FillColor = Color.Transparent;
            cpbKhachHang.Image = (Image)resources.GetObject("cpbKhachHang.Image");
            cpbKhachHang.ImageRotate = 0F;
            cpbKhachHang.Location = new Point(29, 428);
            cpbKhachHang.Name = "cpbKhachHang";
            cpbKhachHang.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cpbKhachHang.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbKhachHang.Size = new Size(58, 58);
            cpbKhachHang.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbKhachHang.TabIndex = 12;
            cpbKhachHang.TabStop = false;
            cpbKhachHang.UseTransparentBackground = true;
            cpbKhachHang.UseWaitCursor = true;
            // 
            // cbpNCC
            // 
            cbpNCC.BackColor = Color.Transparent;
            cbpNCC.FillColor = Color.Transparent;
            cbpNCC.Image = (Image)resources.GetObject("cbpNCC.Image");
            cbpNCC.ImageRotate = 0F;
            cbpNCC.Location = new Point(29, 329);
            cbpNCC.Name = "cbpNCC";
            cbpNCC.ShadowDecoration.CustomizableEdges = customizableEdges11;
            cbpNCC.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cbpNCC.Size = new Size(58, 58);
            cbpNCC.SizeMode = PictureBoxSizeMode.StretchImage;
            cbpNCC.TabIndex = 11;
            cbpNCC.TabStop = false;
            cbpNCC.UseTransparentBackground = true;
            // 
            // cpbHomePage
            // 
            cpbHomePage.BackColor = Color.Transparent;
            cpbHomePage.FillColor = Color.Transparent;
            cpbHomePage.Image = (Image)resources.GetObject("cpbHomePage.Image");
            cpbHomePage.ImageRotate = 0F;
            cpbHomePage.Location = new Point(31, 238);
            cpbHomePage.Name = "cpbHomePage";
            cpbHomePage.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cpbHomePage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            cpbHomePage.Size = new Size(58, 58);
            cpbHomePage.SizeMode = PictureBoxSizeMode.StretchImage;
            cpbHomePage.TabIndex = 10;
            cpbHomePage.TabStop = false;
            cpbHomePage.UseTransparentBackground = true;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.Transparent;
            btnTrangChu.BorderRadius = 18;
            btnTrangChu.CustomizableEdges = customizableEdges13;
            btnTrangChu.FillColor = Color.FromArgb(232, 249, 255);
            btnTrangChu.Font = new Font("Open Sans SemiBold", 16F, FontStyle.Bold);
            btnTrangChu.ForeColor = Color.FromArgb(28, 76, 119);
            btnTrangChu.Location = new Point(16, 228);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnTrangChu.Size = new Size(306, 78);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.TextOffset = new Point(25, -2);
            btnTrangChu.UseTransparentBackground = true;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.BackColor = Color.Transparent;
            btnNhaCungCap.BorderRadius = 18;
            btnNhaCungCap.CustomizableEdges = customizableEdges15;
            btnNhaCungCap.FillColor = Color.FromArgb(232, 249, 255);
            btnNhaCungCap.Font = new Font("Open Sans SemiBold", 16F, FontStyle.Bold);
            btnNhaCungCap.ForeColor = Color.FromArgb(28, 76, 119);
            btnNhaCungCap.Location = new Point(16, 319);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnNhaCungCap.Size = new Size(306, 78);
            btnNhaCungCap.TabIndex = 1;
            btnNhaCungCap.Text = "Nhà Cung Cấp";
            btnNhaCungCap.TextOffset = new Point(45, 0);
            btnNhaCungCap.UseTransparentBackground = true;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.Transparent;
            btnKhachHang.BorderRadius = 18;
            btnKhachHang.CustomizableEdges = customizableEdges17;
            btnKhachHang.FillColor = Color.FromArgb(196, 217, 255);
            btnKhachHang.Font = new Font("Open Sans SemiBold", 16F, FontStyle.Bold);
            btnKhachHang.ForeColor = Color.FromArgb(28, 76, 119);
            btnKhachHang.Location = new Point(16, 417);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnKhachHang.Size = new Size(306, 78);
            btnKhachHang.TabIndex = 2;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.TextOffset = new Point(34, 0);
            btnKhachHang.UseTransparentBackground = true;
            // 
            // btnHangHoa
            // 
            btnHangHoa.BackColor = Color.Transparent;
            btnHangHoa.BorderRadius = 18;
            btnHangHoa.CustomizableEdges = customizableEdges19;
            btnHangHoa.FillColor = Color.FromArgb(232, 249, 255);
            btnHangHoa.Font = new Font("Open Sans SemiBold", 16F, FontStyle.Bold);
            btnHangHoa.ForeColor = Color.FromArgb(28, 76, 119);
            btnHangHoa.Location = new Point(16, 510);
            btnHangHoa.Name = "btnHangHoa";
            btnHangHoa.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnHangHoa.Size = new Size(306, 78);
            btnHangHoa.TabIndex = 3;
            btnHangHoa.Text = "Hàng Hóa";
            btnHangHoa.TextOffset = new Point(22, 0);
            btnHangHoa.UseTransparentBackground = true;
            // 
            // btnLoHang
            // 
            btnLoHang.BackColor = Color.Transparent;
            btnLoHang.BorderRadius = 18;
            btnLoHang.CustomizableEdges = customizableEdges21;
            btnLoHang.FillColor = Color.FromArgb(232, 249, 255);
            btnLoHang.Font = new Font("Open Sans SemiBold", 16F, FontStyle.Bold);
            btnLoHang.ForeColor = Color.FromArgb(28, 76, 119);
            btnLoHang.Location = new Point(16, 605);
            btnLoHang.Name = "btnLoHang";
            btnLoHang.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnLoHang.Size = new Size(306, 78);
            btnLoHang.TabIndex = 4;
            btnLoHang.Text = "Lô Hàng";
            btnLoHang.TextOffset = new Point(15, 0);
            btnLoHang.UseTransparentBackground = true;
            // 
            // btnNhapHang
            // 
            btnNhapHang.BackColor = Color.Transparent;
            btnNhapHang.BorderRadius = 18;
            btnNhapHang.CustomizableEdges = customizableEdges23;
            btnNhapHang.FillColor = Color.FromArgb(232, 249, 255);
            btnNhapHang.Font = new Font("Open Sans SemiBold", 16F, FontStyle.Bold);
            btnNhapHang.ForeColor = Color.FromArgb(28, 76, 119);
            btnNhapHang.Location = new Point(16, 700);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnNhapHang.Size = new Size(306, 78);
            btnNhapHang.TabIndex = 5;
            btnNhapHang.Text = "Nhập Hàng";
            btnNhapHang.TextOffset = new Point(30, 0);
            btnNhapHang.UseTransparentBackground = true;
            // 
            // btnHDBan
            // 
            btnHDBan.BackColor = Color.Transparent;
            btnHDBan.BorderRadius = 18;
            btnHDBan.CustomizableEdges = customizableEdges25;
            btnHDBan.FillColor = Color.FromArgb(232, 249, 255);
            btnHDBan.Font = new Font("Open Sans SemiBold", 16F, FontStyle.Bold);
            btnHDBan.ForeColor = Color.FromArgb(28, 76, 119);
            btnHDBan.Location = new Point(16, 794);
            btnHDBan.Name = "btnHDBan";
            btnHDBan.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnHDBan.Size = new Size(306, 78);
            btnHDBan.TabIndex = 6;
            btnHDBan.Text = "Hóa Đơn Bán";
            btnHDBan.TextOffset = new Point(35, 0);
            btnHDBan.UseTransparentBackground = true;
            // 
            // btnTongNo
            // 
            btnTongNo.BackColor = Color.Transparent;
            btnTongNo.BorderRadius = 18;
            btnTongNo.CustomizableEdges = customizableEdges27;
            btnTongNo.FillColor = Color.FromArgb(232, 249, 255);
            btnTongNo.Font = new Font("Open Sans SemiBold", 16F, FontStyle.Bold);
            btnTongNo.ForeColor = Color.FromArgb(28, 76, 119);
            btnTongNo.Location = new Point(16, 892);
            btnTongNo.Name = "btnTongNo";
            btnTongNo.ShadowDecoration.CustomizableEdges = customizableEdges28;
            btnTongNo.Size = new Size(306, 78);
            btnTongNo.TabIndex = 7;
            btnTongNo.Text = "Tổng Nợ";
            btnTongNo.TextOffset = new Point(8, 0);
            btnTongNo.UseTransparentBackground = true;
            // 
            // btnLichSu
            // 
            btnLichSu.BackColor = Color.Transparent;
            btnLichSu.BorderRadius = 18;
            btnLichSu.CustomizableEdges = customizableEdges29;
            btnLichSu.FillColor = Color.FromArgb(232, 249, 255);
            btnLichSu.Font = new Font("Open Sans SemiBold", 16F, FontStyle.Bold);
            btnLichSu.ForeColor = Color.FromArgb(28, 76, 119);
            btnLichSu.Location = new Point(16, 986);
            btnLichSu.Name = "btnLichSu";
            btnLichSu.ShadowDecoration.CustomizableEdges = customizableEdges30;
            btnLichSu.Size = new Size(306, 78);
            btnLichSu.TabIndex = 8;
            btnLichSu.Text = "Lịch Sử";
            btnLichSu.UseTransparentBackground = true;
            // 
            // btnChiTietNo
            // 
            btnChiTietNo.BackColor = Color.Transparent;
            btnChiTietNo.BorderRadius = 18;
            btnChiTietNo.CustomizableEdges = customizableEdges31;
            btnChiTietNo.FillColor = Color.FromArgb(232, 249, 255);
            btnChiTietNo.Font = new Font("Open Sans SemiBold", 16F, FontStyle.Bold);
            btnChiTietNo.ForeColor = Color.FromArgb(28, 76, 119);
            btnChiTietNo.Location = new Point(16, 1079);
            btnChiTietNo.Name = "btnChiTietNo";
            btnChiTietNo.ShadowDecoration.CustomizableEdges = customizableEdges32;
            btnChiTietNo.Size = new Size(306, 78);
            btnChiTietNo.TabIndex = 9;
            btnChiTietNo.Text = "Chi Tiết Nợ";
            btnChiTietNo.TextOffset = new Point(25, 0);
            btnChiTietNo.UseTransparentBackground = true;
            // 
            // panelContent
            // 
            panelContent.AutoScroll = false;
            panelContent.BackColor = Color.FromArgb(196, 217, 255);
            panelContent.Controls.Add(btnExit);
            panelContent.Controls.Add(LabelKhachHang);
            panelContent.Controls.Add(guna2CirclePictureBox3);
            panelContent.Controls.Add(txtTimKiem);
            panelContent.Controls.Add(btnThem);
            panelContent.Controls.Add(dgvKhachHang);
            panelContent.CustomizableEdges = customizableEdges41;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.ShadowDecoration.CustomizableEdges = customizableEdges42;
            panelContent.Size = new Size(1920, 1055);
            panelContent.TabIndex = 1;
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
            btnExit.Location = new Point(1833, 12);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges35;
            btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 21;
            btnExit.Click += btnExit_Click;
            // 
            // LabelKhachHang
            // 
            LabelKhachHang.BackColor = Color.Transparent;
            LabelKhachHang.Font = new Font("Open Sans ExtraBold", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelKhachHang.ForeColor = Color.FromArgb(27, 20, 100);
            LabelKhachHang.Location = new Point(996, 46);
            LabelKhachHang.Name = "LabelKhachHang";
            LabelKhachHang.Size = new Size(369, 79);
            LabelKhachHang.TabIndex = 13;
            LabelKhachHang.Text = "KHÁCH HÀNG";
            // 
            // guna2CirclePictureBox3
            // 
            guna2CirclePictureBox3.BackColor = Color.Transparent;
            guna2CirclePictureBox3.FillColor = Color.Transparent;
            guna2CirclePictureBox3.Image = (Image)resources.GetObject("guna2CirclePictureBox3.Image");
            guna2CirclePictureBox3.ImageRotate = 0F;
            guna2CirclePictureBox3.Location = new Point(1676, 257);
            guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            guna2CirclePictureBox3.ShadowDecoration.CustomizableEdges = customizableEdges36;
            guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox3.Size = new Size(44, 44);
            guna2CirclePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox3.TabIndex = 12;
            guna2CirclePictureBox3.TabStop = false;
            guna2CirclePictureBox3.UseTransparentBackground = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderRadius = 18;
            txtTimKiem.BorderThickness = 0;
            txtTimKiem.CustomizableEdges = customizableEdges37;
            txtTimKiem.DefaultText = "";
            txtTimKiem.Font = new Font("Open Sans", 12F);
            txtTimKiem.IconRight = (Image)resources.GetObject("txtTimKiem.IconRight");
            txtTimKiem.IconRightSize = new Size(53, 53);
            txtTimKiem.Location = new Point(391, 248);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges38;
            txtTimKiem.Size = new Size(722, 58);
            txtTimKiem.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            btnThem.BorderRadius = 18;
            btnThem.CustomizableEdges = customizableEdges39;
            btnThem.FillColor = Color.Ivory;
            btnThem.Font = new Font("Open Sans Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(1665, 248);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges40;
            btnThem.Size = new Size(191, 58);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = HorizontalAlignment.Right;
            btnThem.Click += btnThem_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhachHang.BorderStyle = BorderStyle.FixedSingle;
            dgvKhachHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            dgvKhachHang.GridColor = Color.FromArgb(231, 229, 255);
            dgvKhachHang.Location = new Point(391, 323);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(1465, 1160);
            dgvKhachHang.TabIndex = 2;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvKhachHang.ThemeStyle.BackColor = Color.White;
            dgvKhachHang.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvKhachHang.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvKhachHang.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvKhachHang.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvKhachHang.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKhachHang.ThemeStyle.HeaderStyle.Height = 29;
            dgvKhachHang.ThemeStyle.ReadOnly = true;
            dgvKhachHang.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvKhachHang.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKhachHang.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvKhachHang.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvKhachHang.ThemeStyle.RowsStyle.Height = 29;
            dgvKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            
            // 
            // frmKhachHang
            // 
            ClientSize = new Size(1920, 1055);
            Controls.Add(panelSidebar);
            Controls.Add(panelContent);
            Name = "frmKhachHang";
            Text = "Khách Hàng";
            WindowState = FormWindowState.Maximized;
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cpbChiTietNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpbTongNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpbHDB).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpbLichSu).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpbNhapHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpbLoHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpbHangHoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpbKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbpNCC).EndInit();
            ((System.ComponentModel.ISupportInitialize)cpbHomePage).EndInit();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbHomePage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cbpNCC;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbKhachHang;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbChiTietNo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbTongNo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbHDB;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbLichSu;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbNhapHang;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbLoHang;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cpbHangHoa;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelKhachHang;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
    }
}
