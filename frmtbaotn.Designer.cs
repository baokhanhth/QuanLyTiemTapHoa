namespace QuanLyTiemTapHoa
{
    partial class frmtbaotn
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtbaotn));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            gradientPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel
            // 
            gradientPanel.Controls.Add(btnClose);
            gradientPanel.Controls.Add(guna2TextBox2);
            gradientPanel.Controls.Add(guna2HtmlLabel2);
            gradientPanel.CustomizableEdges = customizableEdges4;
            gradientPanel.Dock = DockStyle.Fill;
            gradientPanel.FillColor = Color.FromArgb(192, 192, 255);
            gradientPanel.FillColor2 = Color.LightBlue;
            gradientPanel.Location = new Point(0, 0);
            gradientPanel.Name = "gradientPanel";
            gradientPanel.ShadowDecoration.CustomizableEdges = customizableEdges5;
            gradientPanel.Size = new Size(800, 450);
            gradientPanel.TabIndex = 7;
            gradientPanel.Paint += gradientPanel_Paint;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageSize = new Size(50, 50);
            btnClose.Location = new Point(747, 15);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 2;
            btnClose.Click += btnClose_Click;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.BackColor = Color.Transparent;
            guna2TextBox2.BorderRadius = 18;
            guna2TextBox2.CustomizableEdges = customizableEdges2;
            guna2TextBox2.DefaultText = "Đã Cập Nhật Thông Tin!";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Open Sans SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2TextBox2.ForeColor = Color.Black;
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(171, 187);
            guna2TextBox2.Margin = new Padding(7, 10, 7, 10);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2TextBox2.Size = new Size(474, 143);
            guna2TextBox2.TabIndex = 1;
            guna2TextBox2.TextAlign = HorizontalAlignment.Center;
            guna2TextBox2.TextOffset = new Point(25, 5);
            guna2TextBox2.TextChanged += guna2TextBox2_TextChanged;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Open Sans ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            guna2HtmlLabel2.ForeColor = Color.Navy;
            guna2HtmlLabel2.Location = new Point(321, 66);
            guna2HtmlLabel2.Margin = new Padding(5);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(175, 60);
            guna2HtmlLabel2.TabIndex = 0;
            guna2HtmlLabel2.Text = "Tổng Nợ";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.TopRight;
            guna2HtmlLabel2.Click += guna2HtmlLabel2_Click;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BackColor = Color.Transparent;
            guna2TextBox1.BorderRadius = 18;
            guna2TextBox1.CustomizableEdges = customizableEdges6;
            guna2TextBox1.DefaultText = "Đã Cập Nhật Thông Tin!";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Open Sans SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2TextBox1.ForeColor = Color.Black;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(163, 226);
            guna2TextBox1.Margin = new Padding(7, 10, 7, 10);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2TextBox1.Size = new Size(474, 143);
            guna2TextBox1.TabIndex = 6;
            guna2TextBox1.TextAlign = HorizontalAlignment.Center;
            guna2TextBox1.TextOffset = new Point(25, 5);
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Open Sans ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            guna2HtmlLabel1.ForeColor = Color.Navy;
            guna2HtmlLabel1.Location = new Point(240, 81);
            guna2HtmlLabel1.Margin = new Padding(5);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(303, 60);
            guna2HtmlLabel1.TabIndex = 5;
            guna2HtmlLabel1.Text = "Lịch Sử Trả Nợ ";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.TopRight;
            // 
            // frmtbaotn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gradientPanel);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2HtmlLabel1);
            Name = "frmtbaotn";
            Text = "frmtbaotn";
            gradientPanel.ResumeLayout(false);
            gradientPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel gradientPanel;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}