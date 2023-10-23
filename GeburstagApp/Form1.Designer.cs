namespace GeburstagApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciVeliİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Ogrenciisleri = new System.Windows.Forms.ToolStripMenuItem();
            this.veliislemleri_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.öğrenciVeliİşlemleriToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Kapat});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // tsmi_Kapat
            // 
            this.tsmi_Kapat.Name = "tsmi_Kapat";
            this.tsmi_Kapat.Size = new System.Drawing.Size(104, 22);
            this.tsmi_Kapat.Text = "Kapat";
            this.tsmi_Kapat.Click += new System.EventHandler(this.tsmi_Kapat_Click);
            // 
            // öğrenciVeliİşlemleriToolStripMenuItem
            // 
            this.öğrenciVeliİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Ogrenciisleri,
            this.veliislemleri_TSMI});
            this.öğrenciVeliİşlemleriToolStripMenuItem.Name = "öğrenciVeliİşlemleriToolStripMenuItem";
            this.öğrenciVeliİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.öğrenciVeliİşlemleriToolStripMenuItem.Text = "Öğrenci Veli İşlemleri";
            // 
            // tsmi_Ogrenciisleri
            // 
            this.tsmi_Ogrenciisleri.Name = "tsmi_Ogrenciisleri";
            this.tsmi_Ogrenciisleri.Size = new System.Drawing.Size(180, 22);
            this.tsmi_Ogrenciisleri.Text = "Öğrenci İşlemleri";
            this.tsmi_Ogrenciisleri.Click += new System.EventHandler(this.tsmi_Ogrenciisleri_Click);
            // 
            // veliislemleri_TSMI
            // 
            this.veliislemleri_TSMI.Name = "veliislemleri_TSMI";
            this.veliislemleri_TSMI.Size = new System.Drawing.Size(180, 22);
            this.veliislemleri_TSMI.Text = "Veli İşlemleri";
            this.veliislemleri_TSMI.Click += new System.EventHandler(this.veliislemleri_TSMI_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 569);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Geburstag App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Kapat;
        private System.Windows.Forms.ToolStripMenuItem öğrenciVeliİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Ogrenciisleri;
        private System.Windows.Forms.ToolStripMenuItem veliislemleri_TSMI;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
    }
}

