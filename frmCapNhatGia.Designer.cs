namespace QuanLyTiemTapHoa
{
    partial class frmCapNhatGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatGia));
            PanelCapNhatGia = new Guna.UI2.WinForms.Guna2Panel();
            SuspendLayout();
            // 
            // PanelCapNhatGia
            // 
            PanelCapNhatGia.BackColor = Color.Transparent;
            PanelCapNhatGia.CustomizableEdges = customizableEdges1;
            PanelCapNhatGia.Location = new Point(2, 2);
            PanelCapNhatGia.Name = "PanelCapNhatGia";
            PanelCapNhatGia.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PanelCapNhatGia.Size = new Size(1440, 1160);
            PanelCapNhatGia.TabIndex = 0;
            PanelCapNhatGia.UseTransparentBackground = true;
            // 
            // frmCapNhatGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 1055);
            Controls.Add(PanelCapNhatGia);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCapNhatGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCapNhatGia";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelCapNhatGia;
    }
}