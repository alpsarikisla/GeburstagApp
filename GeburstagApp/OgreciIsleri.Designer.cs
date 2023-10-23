namespace GeburstagApp
{
    partial class OgreciIsleri
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
            this.dtp_dogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_soyisim = new System.Windows.Forms.TextBox();
            this.tb_okulNo = new System.Windows.Forms.TextBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Ogrenciler = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ogrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_dogumTarihi
            // 
            this.dtp_dogumTarihi.Location = new System.Drawing.Point(446, 32);
            this.dtp_dogumTarihi.Name = "dtp_dogumTarihi";
            this.dtp_dogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtp_dogumTarihi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_soyisim);
            this.groupBox1.Controls.Add(this.tb_okulNo);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_dogumTarihi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(528, 58);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(118, 23);
            this.btn_Ekle.TabIndex = 4;
            this.btn_Ekle.Text = "Öğrenci Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doğum Tarihi=";
            // 
            // tb_soyisim
            // 
            this.tb_soyisim.Location = new System.Drawing.Point(89, 80);
            this.tb_soyisim.Name = "tb_soyisim";
            this.tb_soyisim.Size = new System.Drawing.Size(224, 20);
            this.tb_soyisim.TabIndex = 2;
            // 
            // tb_okulNo
            // 
            this.tb_okulNo.Location = new System.Drawing.Point(89, 32);
            this.tb_okulNo.Name = "tb_okulNo";
            this.tb_okulNo.Size = new System.Drawing.Size(224, 20);
            this.tb_okulNo.TabIndex = 2;
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(89, 56);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(224, 20);
            this.tb_isim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Okul No =";
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
            this.dgv_Ogrenciler.Size = new System.Drawing.Size(776, 286);
            this.dgv_Ogrenciler.TabIndex = 2;
            this.dgv_Ogrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ogrenciler_CellClick);
            // 
            // OgreciIsleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Ogrenciler);
            this.Controls.Add(this.groupBox1);
            this.Name = "OgreciIsleri";
            this.ShowIcon = false;
            this.Text = "Öğreci İşleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ogrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_dogumTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_soyisim;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Ogrenciler;
        private System.Windows.Forms.TextBox tb_okulNo;
        private System.Windows.Forms.Label label4;
    }
}