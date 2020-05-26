namespace At_yarisi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnTekrar = new System.Windows.Forms.Button();
            this.lblPara = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblBahis = new System.Windows.Forms.Label();
            this.tbxBahis = new System.Windows.Forms.TextBox();
            this.btnBahis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxAt1 = new System.Windows.Forms.PictureBox();
            this.pbxAt2 = new System.Windows.Forms.PictureBox();
            this.pbxAt3 = new System.Windows.Forms.PictureBox();
            this.lblAt = new System.Windows.Forms.Label();
            this.tbxAt = new System.Windows.Forms.TextBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnBastanBasla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAt3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1501, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Location = new System.Drawing.Point(-1, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1519, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Location = new System.Drawing.Point(-1, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1519, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label4.Location = new System.Drawing.Point(-1, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1519, 23);
            this.label4.TabIndex = 0;
            // 
            // lblBitis
            // 
            this.lblBitis.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblBitis.Location = new System.Drawing.Point(1488, -1);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(30, 485);
            this.lblBitis.TabIndex = 0;
            // 
            // lblBilgi
            // 
            this.lblBilgi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBilgi.Location = new System.Drawing.Point(283, 594);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(724, 64);
            this.lblBilgi.TabIndex = 1;
            // 
            // btnBaslat
            // 
            this.btnBaslat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBaslat.Location = new System.Drawing.Point(36, 505);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(221, 63);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnTekrar
            // 
            this.btnTekrar.Location = new System.Drawing.Point(36, 594);
            this.btnTekrar.Name = "btnTekrar";
            this.btnTekrar.Size = new System.Drawing.Size(221, 63);
            this.btnTekrar.TabIndex = 2;
            this.btnTekrar.Text = "Tekrar Başlat";
            this.btnTekrar.UseVisualStyleBackColor = true;
            this.btnTekrar.Click += new System.EventHandler(this.btnTekrar_Click);
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPara.Location = new System.Drawing.Point(1027, 529);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(73, 29);
            this.lblPara.TabIndex = 5;
            this.lblPara.Text = "Para:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(1134, 529);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(55, 29);
            this.lblMiktar.TabIndex = 5;
            this.lblMiktar.Text = "100";
            // 
            // lblBahis
            // 
            this.lblBahis.AutoSize = true;
            this.lblBahis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBahis.Location = new System.Drawing.Point(1027, 628);
            this.lblBahis.Name = "lblBahis";
            this.lblBahis.Size = new System.Drawing.Size(84, 29);
            this.lblBahis.TabIndex = 5;
            this.lblBahis.Text = "Bahis:";
            // 
            // tbxBahis
            // 
            this.tbxBahis.Location = new System.Drawing.Point(1139, 629);
            this.tbxBahis.Name = "tbxBahis";
            this.tbxBahis.Size = new System.Drawing.Size(133, 22);
            this.tbxBahis.TabIndex = 6;
            // 
            // btnBahis
            // 
            this.btnBahis.Location = new System.Drawing.Point(1032, 686);
            this.btnBahis.Name = "btnBahis";
            this.btnBahis.Size = new System.Drawing.Size(109, 43);
            this.btnBahis.TabIndex = 7;
            this.btnBahis.Text = "Bahis Gir";
            this.btnBahis.UseVisualStyleBackColor = true;
            this.btnBahis.Click += new System.EventHandler(this.btnBahis_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxAt1
            // 
            this.pbxAt1.BackColor = System.Drawing.Color.Transparent;
            this.pbxAt1.Image = ((System.Drawing.Image)(resources.GetObject("pbxAt1.Image")));
            this.pbxAt1.Location = new System.Drawing.Point(2, 37);
            this.pbxAt1.Name = "pbxAt1";
            this.pbxAt1.Size = new System.Drawing.Size(123, 93);
            this.pbxAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAt1.TabIndex = 8;
            this.pbxAt1.TabStop = false;
            // 
            // pbxAt2
            // 
            this.pbxAt2.BackColor = System.Drawing.Color.Transparent;
            this.pbxAt2.Image = ((System.Drawing.Image)(resources.GetObject("pbxAt2.Image")));
            this.pbxAt2.Location = new System.Drawing.Point(2, 190);
            this.pbxAt2.Name = "pbxAt2";
            this.pbxAt2.Size = new System.Drawing.Size(123, 93);
            this.pbxAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAt2.TabIndex = 8;
            this.pbxAt2.TabStop = false;
            // 
            // pbxAt3
            // 
            this.pbxAt3.BackColor = System.Drawing.Color.Transparent;
            this.pbxAt3.Image = ((System.Drawing.Image)(resources.GetObject("pbxAt3.Image")));
            this.pbxAt3.Location = new System.Drawing.Point(2, 347);
            this.pbxAt3.Name = "pbxAt3";
            this.pbxAt3.Size = new System.Drawing.Size(123, 93);
            this.pbxAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAt3.TabIndex = 8;
            this.pbxAt3.TabStop = false;
            // 
            // lblAt
            // 
            this.lblAt.AutoSize = true;
            this.lblAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAt.Location = new System.Drawing.Point(1027, 581);
            this.lblAt.Name = "lblAt";
            this.lblAt.Size = new System.Drawing.Size(44, 29);
            this.lblAt.TabIndex = 5;
            this.lblAt.Text = "At:";
            // 
            // tbxAt
            // 
            this.tbxAt.Location = new System.Drawing.Point(1139, 581);
            this.tbxAt.Name = "tbxAt";
            this.tbxAt.Size = new System.Drawing.Size(133, 22);
            this.tbxAt.TabIndex = 6;
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDurum.Location = new System.Drawing.Point(1186, 669);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(280, 70);
            this.lblDurum.TabIndex = 1;
            // 
            // btnBastanBasla
            // 
            this.btnBastanBasla.Location = new System.Drawing.Point(36, 676);
            this.btnBastanBasla.Name = "btnBastanBasla";
            this.btnBastanBasla.Size = new System.Drawing.Size(221, 63);
            this.btnBastanBasla.TabIndex = 2;
            this.btnBastanBasla.Text = "Baştan Başla";
            this.btnBastanBasla.UseVisualStyleBackColor = true;
            this.btnBastanBasla.Click += new System.EventHandler(this.btnBastanBasla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1696, 753);
            this.Controls.Add(this.pbxAt3);
            this.Controls.Add(this.pbxAt2);
            this.Controls.Add(this.pbxAt1);
            this.Controls.Add(this.btnBahis);
            this.Controls.Add(this.tbxAt);
            this.Controls.Add(this.tbxBahis);
            this.Controls.Add(this.lblAt);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblBahis);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.btnBastanBasla);
            this.Controls.Add(this.btnTekrar);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAt3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnTekrar;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblBahis;
        private System.Windows.Forms.TextBox tbxBahis;
        private System.Windows.Forms.Button btnBahis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbxAt1;
        private System.Windows.Forms.PictureBox pbxAt2;
        private System.Windows.Forms.PictureBox pbxAt3;
        private System.Windows.Forms.Label lblAt;
        private System.Windows.Forms.TextBox tbxAt;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnBastanBasla;
    }
}

