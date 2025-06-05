namespace QuanLyTiemTapHoa
{
    partial class fBaoCaoTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBaoCaoTonKho));
            txtsltonkho = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btxem = new Guna.UI2.WinForms.Guna2Button();
            btthoat = new Guna.UI2.WinForms.Guna2Button();
            dgvsltonkho = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvsltonkho).BeginInit();
            SuspendLayout();
            // 
            // txtsltonkho
            // 
            txtsltonkho.BackColor = Color.Transparent;
            txtsltonkho.Font = new Font("Open Sans ExtraBold", 24F, FontStyle.Bold);
            txtsltonkho.ForeColor = Color.FromArgb(27, 20, 100);
            txtsltonkho.Location = new Point(392, 12);
            txtsltonkho.Name = "txtsltonkho";
            txtsltonkho.Size = new Size(556, 60);
            txtsltonkho.TabIndex = 0;
            txtsltonkho.Text = "SỐ LƯỢNG HÀNG TỒN KHO";
            // 
            // btxem
            // 
            btxem.BorderRadius = 20;
            btxem.CustomizableEdges = customizableEdges1;
            btxem.DisabledState.BorderColor = Color.DarkGray;
            btxem.DisabledState.CustomBorderColor = Color.DarkGray;
            btxem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btxem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btxem.FillColor = SystemColors.InactiveBorder;
            btxem.Font = new Font("Open Sans ExtraBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btxem.ForeColor = Color.Black;
            btxem.Location = new Point(1247, 31);
            btxem.Name = "btxem";
            btxem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btxem.Size = new Size(106, 40);
            btxem.TabIndex = 1;
            btxem.Text = "XEM";
            btxem.Click += btxem_Click;
            // 
            // btthoat
            // 
            btthoat.BorderRadius = 20;
            btthoat.CustomizableEdges = customizableEdges3;
            btthoat.DisabledState.BorderColor = Color.DarkGray;
            btthoat.DisabledState.CustomBorderColor = Color.DarkGray;
            btthoat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btthoat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btthoat.FillColor = SystemColors.InactiveBorder;
            btthoat.Font = new Font("Open Sans ExtraBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btthoat.ForeColor = Color.Black;
            btthoat.Location = new Point(1402, 31);
            btthoat.Name = "btthoat";
            btthoat.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btthoat.Size = new Size(106, 41);
            btthoat.TabIndex = 2;
            btthoat.Text = "THOÁT";
            btthoat.Click += btthoat_Click;
            // 
            // dgvsltonkho
            // 
            dgvsltonkho.BackgroundColor = Color.FromArgb(232, 249, 255);
            dgvsltonkho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsltonkho.Location = new Point(79, 99);
            dgvsltonkho.Name = "dgvsltonkho";
            dgvsltonkho.RowHeadersWidth = 51;
            dgvsltonkho.ShowRowErrors = false;
            dgvsltonkho.Size = new Size(1429, 768);
            dgvsltonkho.TabIndex = 3;
            // 
            // fBaoCaoTonKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 217, 255);
            ClientSize = new Size(1570, 900);
            Controls.Add(dgvsltonkho);
            Controls.Add(btthoat);
            Controls.Add(btxem);
            Controls.Add(txtsltonkho);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "fBaoCaoTonKho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fBaoCaoTonKho";
            ((System.ComponentModel.ISupportInitialize)dgvsltonkho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtsltonkho;
        private Guna.UI2.WinForms.Guna2Button btxem;
        private Guna.UI2.WinForms.Guna2Button btthoat;
        private DataGridView dgvsltonkho;
    }
}