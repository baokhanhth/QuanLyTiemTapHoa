namespace QuanLyTiemTapHoa
{
    partial class frmtbaolstn
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtbaolstn));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            gradientPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel
            // 
            gradientPanel.Controls.Add(btnClose);
            gradientPanel.Controls.Add(guna2TextBox1);
            gradientPanel.Controls.Add(guna2HtmlLabel1);
            gradientPanel.CustomizableEdges = customizableEdges9;
            gradientPanel.Dock = DockStyle.Fill;
            gradientPanel.FillColor = Color.FromArgb(192, 192, 255);
            gradientPanel.FillColor2 = Color.LightBlue;
            gradientPanel.Location = new Point(0, 0);
            gradientPanel.Name = "gradientPanel";
            gradientPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            gradientPanel.Size = new Size(800, 450);
            gradientPanel.TabIndex = 1;
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
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnClose.Size = new Size(50, 50);
            btnClose.TabIndex = 2;
            btnClose.Click += btnClose_Click;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BackColor = Color.Transparent;
            guna2TextBox1.BorderRadius = 18;
            guna2TextBox1.CustomizableEdges = customizableEdges7;
            guna2TextBox1.DefaultText = "Đã Cập Nhật Thông Tin!";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Open Sans SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2TextBox1.ForeColor = Color.Black;
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(171, 187);
            guna2TextBox1.Margin = new Padding(7, 10, 7, 10);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2TextBox1.Size = new Size(474, 143);
            guna2TextBox1.TabIndex = 1;
            guna2TextBox1.TextAlign = HorizontalAlignment.Center;
            guna2TextBox1.TextOffset = new Point(25, 5);
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Open Sans ExtraBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            guna2HtmlLabel1.ForeColor = Color.Navy;
            guna2HtmlLabel1.Location = new Point(248, 42);
            guna2HtmlLabel1.Margin = new Padding(5);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(303, 60);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Lịch Sử Trả Nợ ";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.TopRight;
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // frmtbaolstn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gradientPanel);
            Name = "frmtbaolstn";
            Text = "frmtbaolstn";
            gradientPanel.ResumeLayout(false);
            gradientPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel gradientPanel;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}