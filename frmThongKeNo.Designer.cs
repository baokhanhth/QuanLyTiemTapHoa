namespace QuanLyTiemTapHoa
{
    partial class frmThongKeNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeNo));
            txtthongke = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbdenngay = new Label();
            lbtungay = new Label();
            dttungay = new DateTimePicker();
            dtdenngay = new DateTimePicker();
            btok = new Guna.UI2.WinForms.Guna2Button();
            bthuy = new Guna.UI2.WinForms.Guna2Button();
            cCongNo = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            SuspendLayout();
            // 
            // txtthongke
            // 
            txtthongke.BackColor = Color.Transparent;
            txtthongke.Font = new Font("Open Sans ExtraBold", 24F, FontStyle.Bold);
            txtthongke.ForeColor = Color.FromArgb(27, 20, 100);
            txtthongke.Location = new Point(477, 12);
            txtthongke.Name = "txtthongke";
            txtthongke.Size = new Size(565, 60);
            txtthongke.TabIndex = 0;
            txtthongke.Text = "THỐNG KÊ NỢ THEO THÁNG";
            // 
            // lbdenngay
            // 
            lbdenngay.AutoSize = true;
            lbdenngay.BackColor = Color.Transparent;
            lbdenngay.Font = new Font("Open Sans ExtraBold", 13.8F, FontStyle.Bold);
            lbdenngay.Location = new Point(818, 94);
            lbdenngay.Name = "lbdenngay";
            lbdenngay.Size = new Size(128, 33);
            lbdenngay.TabIndex = 1;
            lbdenngay.Text = "Đến Ngày";
            // 
            // lbtungay
            // 
            lbtungay.AutoSize = true;
            lbtungay.BackColor = Color.Transparent;
            lbtungay.Font = new Font("Open Sans ExtraBold", 13.8F, FontStyle.Bold);
            lbtungay.Location = new Point(352, 92);
            lbtungay.Name = "lbtungay";
            lbtungay.Size = new Size(111, 33);
            lbtungay.TabIndex = 2;
            lbtungay.Text = "Từ ngày";
            // 
            // dttungay
            // 
            dttungay.Font = new Font("Open Sans SemiBold", 12F, FontStyle.Bold);
            dttungay.Format = DateTimePickerFormat.Short;
            dttungay.Location = new Point(492, 92);
            dttungay.Name = "dttungay";
            dttungay.Size = new Size(154, 35);
            dttungay.TabIndex = 3;
            dttungay.ValueChanged += dttungay_ValueChanged;
            // 
            // dtdenngay
            // 
            dtdenngay.Font = new Font("Open Sans SemiBold", 12F, FontStyle.Bold);
            dtdenngay.Format = DateTimePickerFormat.Short;
            dtdenngay.Location = new Point(991, 94);
            dtdenngay.Name = "dtdenngay";
            dtdenngay.Size = new Size(157, 35);
            dtdenngay.TabIndex = 4;
            dtdenngay.ValueChanged += dtdenngay_ValueChanged;
            // 
            // btok
            // 
            btok.BorderRadius = 20;
            btok.CustomizableEdges = customizableEdges1;
            btok.DisabledState.BorderColor = Color.DarkGray;
            btok.DisabledState.CustomBorderColor = Color.DarkGray;
            btok.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btok.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btok.FillColor = SystemColors.ButtonHighlight;
            btok.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btok.ForeColor = Color.Black;
            btok.Location = new Point(1294, 94);
            btok.Name = "btok";
            btok.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btok.Size = new Size(82, 35);
            btok.TabIndex = 5;
            btok.Text = "XEM";
            btok.Click += btok_Click;
            // 
            // bthuy
            // 
            bthuy.BorderRadius = 20;
            bthuy.CustomizableEdges = customizableEdges3;
            bthuy.DisabledState.BorderColor = Color.DarkGray;
            bthuy.DisabledState.CustomBorderColor = Color.DarkGray;
            bthuy.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bthuy.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bthuy.FillColor = SystemColors.ButtonHighlight;
            bthuy.Font = new Font("Open Sans ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bthuy.ForeColor = Color.Black;
            bthuy.Location = new Point(1432, 96);
            bthuy.Name = "bthuy";
            bthuy.ShadowDecoration.CustomizableEdges = customizableEdges4;
            bthuy.Size = new Size(82, 35);
            bthuy.TabIndex = 6;
            bthuy.Text = "HỦY";
            bthuy.Click += bthuy_Click;
            // 
            // cCongNo
            // 
            cCongNo.BackColor = Color.FromArgb(232, 249, 255);
            cCongNo.Location = new Point(64, 157);
            cCongNo.MatchAxesScreenDataRatio = false;
            cCongNo.Name = "cCongNo";
            cCongNo.Size = new Size(1450, 706);
            cCongNo.TabIndex = 7;
            // 
            // frmThongKeNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 217, 255);
            ClientSize = new Size(1570, 900);
            Controls.Add(cCongNo);
            Controls.Add(bthuy);
            Controls.Add(btok);
            Controls.Add(dtdenngay);
            Controls.Add(dttungay);
            Controls.Add(lbtungay);
            Controls.Add(lbdenngay);
            Controls.Add(txtthongke);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmThongKeNo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKeNo";
            Load += frmThongKeNo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtthongke;
        private Label lbdenngay;
        private Label lbtungay;
        private DateTimePicker dttungay;
        private DateTimePicker dtdenngay;
        private Guna.UI2.WinForms.Guna2Button btok;
        private Guna.UI2.WinForms.Guna2Button bthuy;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cCongNo;
    }
}