namespace Library.WinUI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÖğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenlemeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniİşlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verilenKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencilerToolStripMenuItem,
            this.kitaplarToolStripMenuItem,
            this.ödünçİşlemleriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÖğrenciToolStripMenuItem,
            this.düzenlemeToolStripMenuItem});
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // yeniÖğrenciToolStripMenuItem
            // 
            this.yeniÖğrenciToolStripMenuItem.Name = "yeniÖğrenciToolStripMenuItem";
            this.yeniÖğrenciToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.yeniÖğrenciToolStripMenuItem.Text = "Yeni Öğrenci";
            this.yeniÖğrenciToolStripMenuItem.Click += new System.EventHandler(this.yeniÖğrenciToolStripMenuItem_Click);
            // 
            // düzenlemeToolStripMenuItem
            // 
            this.düzenlemeToolStripMenuItem.Name = "düzenlemeToolStripMenuItem";
            this.düzenlemeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.düzenlemeToolStripMenuItem.Text = "Düzenleme";
            this.düzenlemeToolStripMenuItem.Click += new System.EventHandler(this.düzenlemeToolStripMenuItem_Click);
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKitapToolStripMenuItem,
            this.düzenlemeToolStripMenuItem1});
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            // 
            // yeniKitapToolStripMenuItem
            // 
            this.yeniKitapToolStripMenuItem.Name = "yeniKitapToolStripMenuItem";
            this.yeniKitapToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.yeniKitapToolStripMenuItem.Text = "Yeni Kitap";
            this.yeniKitapToolStripMenuItem.Click += new System.EventHandler(this.yeniKitapToolStripMenuItem_Click);
            // 
            // düzenlemeToolStripMenuItem1
            // 
            this.düzenlemeToolStripMenuItem1.Name = "düzenlemeToolStripMenuItem1";
            this.düzenlemeToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.düzenlemeToolStripMenuItem1.Text = "Düzenleme";
            this.düzenlemeToolStripMenuItem1.Click += new System.EventHandler(this.düzenlemeToolStripMenuItem1_Click);
            // 
            // ödünçİşlemleriToolStripMenuItem
            // 
            this.ödünçİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniİşlemToolStripMenuItem,
            this.verilenKitaplarToolStripMenuItem});
            this.ödünçİşlemleriToolStripMenuItem.Name = "ödünçİşlemleriToolStripMenuItem";
            this.ödünçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.ödünçİşlemleriToolStripMenuItem.Text = "Ödünç İşlemleri";
            // 
            // yeniİşlemToolStripMenuItem
            // 
            this.yeniİşlemToolStripMenuItem.Name = "yeniİşlemToolStripMenuItem";
            this.yeniİşlemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniİşlemToolStripMenuItem.Text = "Yeni İşlem";
            this.yeniİşlemToolStripMenuItem.Click += new System.EventHandler(this.yeniİşlemToolStripMenuItem_Click);
            // 
            // verilenKitaplarToolStripMenuItem
            // 
            this.verilenKitaplarToolStripMenuItem.Name = "verilenKitaplarToolStripMenuItem";
            this.verilenKitaplarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verilenKitaplarToolStripMenuItem.Text = "Verilen Kitaplar";
            this.verilenKitaplarToolStripMenuItem.Click += new System.EventHandler(this.verilenKitaplarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÖğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenlemeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ödünçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniİşlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verilenKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

