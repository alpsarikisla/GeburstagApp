namespace GeburstagApp
{
    partial class VeliIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.dtp_dogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_soyisim = new System.Windows.Forms.TextBox();
            this.tb_okulNo = new System.Windows.Forms.TextBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Ogrenciler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Duzenle_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.Sil_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.mtb_GSM = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ogrenciler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(471, 58);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(118, 23);
            this.btn_Ekle.TabIndex = 4;
            this.btn_Ekle.Text = "Veli Düzenle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // dtp_dogumTarihi
            // 
            this.dtp_dogumTarihi.Location = new System.Drawing.Point(471, 32);
            this.dtp_dogumTarihi.Name = "dtp_dogumTarihi";
            this.dtp_dogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtp_dogumTarihi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mtb_GSM);
            this.groupBox1.Controls.Add(this.btn_iptal);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_soyisim);
            this.groupBox1.Controls.Add(this.tb_okulNo);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_dogumTarihi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veli Bilgileri";
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(595, 58);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(76, 23);
            this.btn_iptal.TabIndex = 4;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doğum Tarihi=";
            // 
            // tb_soyisim
            // 
            this.tb_soyisim.Location = new System.Drawing.Point(114, 80);
            this.tb_soyisim.Name = "tb_soyisim";
            this.tb_soyisim.Size = new System.Drawing.Size(224, 20);
            this.tb_soyisim.TabIndex = 2;
            // 
            // tb_okulNo
            // 
            this.tb_okulNo.Location = new System.Drawing.Point(114, 32);
            this.tb_okulNo.Name = "tb_okulNo";
            this.tb_okulNo.Size = new System.Drawing.Size(224, 20);
            this.tb_okulNo.TabIndex = 2;
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(114, 56);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(224, 20);
            this.tb_isim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yakınlık Durumu=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim = ";
            // 
            // dgv_Ogrenciler
            // 
            this.dgv_Ogrenciler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ogrenciler.Location = new System.Drawing.Point(12, 152);
            this.dgv_Ogrenciler.Name = "dgv_Ogrenciler";
            this.dgv_Ogrenciler.Size = new System.Drawing.Size(948, 413);
            this.dgv_Ogrenciler.TabIndex = 4;
            this.dgv_Ogrenciler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Ogrenciler_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Duzenle_TSMI,
            this.Sil_TSMI});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // Duzenle_TSMI
            // 
            this.Duzenle_TSMI.Name = "Duzenle_TSMI";
            this.Duzenle_TSMI.Size = new System.Drawing.Size(116, 22);
            this.Duzenle_TSMI.Text = "Düzenle";
            this.Duzenle_TSMI.Click += new System.EventHandler(this.Duzenle_TSMI_Click);
            // 
            // Sil_TSMI
            // 
            this.Sil_TSMI.Name = "Sil_TSMI";
            this.Sil_TSMI.Size = new System.Drawing.Size(116, 22);
            this.Sil_TSMI.Text = "Sil";
            this.Sil_TSMI.Click += new System.EventHandler(this.Sil_TSMI_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon Numarası=";
            // 
            // mtb_GSM
            // 
            this.mtb_GSM.Location = new System.Drawing.Point(114, 103);
            this.mtb_GSM.Mask = "(999) 000-0000";
            this.mtb_GSM.Name = "mtb_GSM";
            this.mtb_GSM.Size = new System.Drawing.Size(224, 20);
            this.mtb_GSM.TabIndex = 6;
            // 
            // VeliIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Ogrenciler);
            this.Name = "VeliIslemleri";
            this.Text = "Veli İşlemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ogrenciler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.DateTimePicker dtp_dogumTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_soyisim;
        private System.Windows.Forms.TextBox tb_okulNo;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Ogrenciler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Duzenle_TSMI;
        private System.Windows.Forms.ToolStripMenuItem Sil_TSMI;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtb_GSM;
    }
}