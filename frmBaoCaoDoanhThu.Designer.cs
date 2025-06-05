namespace QuanLyTiemTapHoa
{
    partial class frmBaoCaoDoanhThu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoDoanhThu));
            cDoanhThu = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            txtBaoCao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtbatdau = new DateTimePicker();
            dtketthuc = new DateTimePicker();
            txtbatdau = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtketthuc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnOk = new Guna.UI2.WinForms.Guna2Button();
            btnHuy = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // cDoanhThu
            // 
            cDoanhThu.BackColor = Color.FromArgb(232, 249, 255);
            cDoanhThu.Location = new Point(59, 123);
            cDoanhThu.MatchAxesScreenDataRatio = false;
            cDoanhThu.Name = "cDoanhThu";
            cDoanhThu.Size = new Size(1357, 747);
            cDoanhThu.TabIndex = 0;
            cDoanhThu.Load += cDoanhThu_Load;
            // 
            // txtBaoCao
            // 
            txtBaoCao.BackColor = Color.Transparent;
            txtBaoCao.Font = new Font("Open Sans ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBaoCao.ForeColor = Color.FromArgb(27, 20, 100);
            txtBaoCao.Location = new Point(400, 27);
            txtBaoCao.Name = "txtBaoCao";
            txtBaoCao.Size = new Size(447, 60);
            txtBaoCao.TabIndex = 1;
            txtBaoCao.Text = "BÁO CÁO DOANH THU";
            // 
            // dtbatdau
            // 
            dtbatdau.Font = new Font("Open Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtbatdau.Format = DateTimePickerFormat.Short;
            dtbatdau.Location = new Point(1112, 68);
            dtbatdau.Name = "dtbatdau";
            dtbatdau.Size = new Size(127, 35);
            dtbatdau.TabIndex = 2;
            dtbatdau.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtketthuc
            // 
            dtketthuc.Font = new Font("Open Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtketthuc.Format = DateTimePickerFormat.Short;
            dtketthuc.Location = new Point(1287, 68);
            dtketthuc.Name = "dtketthuc";
            dtketthuc.Size = new Size(129, 35);
            dtketthuc.TabIndex = 3;
            dtketthuc.ValueChanged += dtketthuc_ValueChanged;
            // 
            // txtbatdau
            // 
            txtbatdau.BackColor = Color.Transparent;
            txtbatdau.Font = new Font("Open Sans ExtraBold", 13.8F, FontStyle.Bold);
            txtbatdau.ForeColor = SystemColors.ActiveCaptionText;
            txtbatdau.Location = new Point(1112, 27);
            txtbatdau.Name = "txtbatdau";
            txtbatdau.Size = new Size(103, 35);
            txtbatdau.TabIndex = 4;
            txtbatdau.Text = "Từ Ngày";
            // 
            // txtketthuc
            // 
            txtketthuc.BackColor = Color.Transparent;
            txtketthuc.Font = new Font("Open Sans ExtraBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtketthuc.Location = new Point(1287, 27);
            txtketthuc.Name = "txtketthuc";
            txtketthuc.Size = new Size(116, 35);
            txtketthuc.TabIndex = 5;
            txtketthuc.Text = "Đến Ngày";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(451, 361);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = null;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Transparent;
            btnOk.BorderRadius = 20;
            btnOk.CustomizableEdges = customizableEdges1;
            btnOk.DisabledState.BorderColor = Color.DarkGray;
            btnOk.DisabledState.CustomBorderColor = Color.DarkGray;
            btnOk.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnOk.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnOk.FillColor = Color.FromArgb(232, 249, 255);
            btnOk.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOk.ForeColor = Color.Black;
            btnOk.Location = new Point(1459, 328);
            btnOk.Name = "btnOk";
            btnOk.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnOk.Size = new Size(79, 48);
            btnOk.TabIndex = 7;
            btnOk.Text = "XEM";
            btnOk.Click += btnOk_Click;
            // 
            // btnHuy
            // 
            btnHuy.BorderRadius = 20;
            btnHuy.CustomizableEdges = customizableEdges3;
            btnHuy.DisabledState.BorderColor = Color.DarkGray;
            btnHuy.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHuy.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnHuy.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHuy.FillColor = Color.FromArgb(232, 249, 255);
            btnHuy.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.Black;
            btnHuy.Location = new Point(1459, 444);
            btnHuy.Name = "btnHuy";
            btnHuy.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnHuy.Size = new Size(83, 48);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "HỦY";
            btnHuy.Click += btnHuy_Click;
            // 
            // frmBaoCaoDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 217, 255);
            ClientSize = new Size(1570, 900);
            Controls.Add(btnHuy);
            Controls.Add(btnOk);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(txtketthuc);
            Controls.Add(txtbatdau);
            Controls.Add(dtketthuc);
            Controls.Add(dtbatdau);
            Controls.Add(txtBaoCao);
            Controls.Add(cDoanhThu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBaoCaoDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBaoCaoDoanhThu";
            Load += frmBaoCaoDoanhThu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cDoanhThu;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtBaoCao;
        private DateTimePicker dtbatdau;
        private DateTimePicker dtketthuc;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtbatdau;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtketthuc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnOk;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}