namespace AirPortProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uçakBakımBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muyaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muyaneRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelİşlemlerToolStripMenuItem,
            this.uçakBakımBilgileriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelİşlemlerToolStripMenuItem
            // 
            this.personelİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.personelSilToolStripMenuItem});
            this.personelİşlemlerToolStripMenuItem.Name = "personelİşlemlerToolStripMenuItem";
            this.personelİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelİşlemlerToolStripMenuItem.Text = "Personel İşlemleri";
            this.personelİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.personelİşlemlerToolStripMenuItem_Click);
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // personelSilToolStripMenuItem
            // 
            this.personelSilToolStripMenuItem.Name = "personelSilToolStripMenuItem";
            this.personelSilToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.personelSilToolStripMenuItem.Text = "Personel Güncelle/Sil";
            this.personelSilToolStripMenuItem.Click += new System.EventHandler(this.personelSilToolStripMenuItem_Click);
            // 
            // uçakBakımBilgileriToolStripMenuItem
            // 
            this.uçakBakımBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muyaneToolStripMenuItem,
            this.muyaneRaporlarıToolStripMenuItem});
            this.uçakBakımBilgileriToolStripMenuItem.Name = "uçakBakımBilgileriToolStripMenuItem";
            this.uçakBakımBilgileriToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.uçakBakımBilgileriToolStripMenuItem.Text = "Uçak Bilgileri";
            // 
            // muyaneToolStripMenuItem
            // 
            this.muyaneToolStripMenuItem.Name = "muyaneToolStripMenuItem";
            this.muyaneToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.muyaneToolStripMenuItem.Text = "Muyane Ekle";
            this.muyaneToolStripMenuItem.Click += new System.EventHandler(this.muyaneToolStripMenuItem_Click);
            // 
            // muyaneRaporlarıToolStripMenuItem
            // 
            this.muyaneRaporlarıToolStripMenuItem.Name = "muyaneRaporlarıToolStripMenuItem";
            this.muyaneRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.muyaneRaporlarıToolStripMenuItem.Text = "Muyane Raporları";
            this.muyaneRaporlarıToolStripMenuItem.Click += new System.EventHandler(this.muyaneRaporlarıToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uçakBakımBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muyaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muyaneRaporlarıToolStripMenuItem;
    }
}

