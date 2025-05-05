namespace KutuphaneOtomasyonu
{
    partial class Form4
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
            this.cmbUye = new System.Windows.Forms.ComboBox();
            this.cmbKitap = new System.Windows.Forms.ComboBox();
            this.dtpAlisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpIadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.chkTeslimEdildi = new System.Windows.Forms.CheckBox();
            this.btnOduncEkle = new System.Windows.Forms.Button();
            this.btnOduncListele = new System.Windows.Forms.Button();
            this.btnOduncSil = new System.Windows.Forms.Button();
            this.btnOduncGuncelle = new System.Windows.Forms.Button();
            this.dataGridViewOdunc = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdunc)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUye
            // 
            this.cmbUye.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbUye.FormattingEnabled = true;
            this.cmbUye.Location = new System.Drawing.Point(82, 64);
            this.cmbUye.Name = "cmbUye";
            this.cmbUye.Size = new System.Drawing.Size(198, 24);
            this.cmbUye.TabIndex = 0;
            this.cmbUye.Text = "Üye seçimi";
            // 
            // cmbKitap
            // 
            this.cmbKitap.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbKitap.FormattingEnabled = true;
            this.cmbKitap.Location = new System.Drawing.Point(286, 64);
            this.cmbKitap.Name = "cmbKitap";
            this.cmbKitap.Size = new System.Drawing.Size(200, 24);
            this.cmbKitap.TabIndex = 1;
            this.cmbKitap.Text = "Kitap seçimi ";
            // 
            // dtpAlisTarihi
            // 
            this.dtpAlisTarihi.Location = new System.Drawing.Point(80, 106);
            this.dtpAlisTarihi.Name = "dtpAlisTarihi";
            this.dtpAlisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpAlisTarihi.TabIndex = 2;
            // 
            // dtpIadeTarihi
            // 
            this.dtpIadeTarihi.Location = new System.Drawing.Point(286, 106);
            this.dtpIadeTarihi.Name = "dtpIadeTarihi";
            this.dtpIadeTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpIadeTarihi.TabIndex = 3;
            this.dtpIadeTarihi.Tag = "";
            // 
            // chkTeslimEdildi
            // 
            this.chkTeslimEdildi.AutoSize = true;
            this.chkTeslimEdildi.Location = new System.Drawing.Point(514, 106);
            this.chkTeslimEdildi.Name = "chkTeslimEdildi";
            this.chkTeslimEdildi.Size = new System.Drawing.Size(107, 20);
            this.chkTeslimEdildi.TabIndex = 4;
            this.chkTeslimEdildi.Text = "Teslim Edildi";
            this.chkTeslimEdildi.UseVisualStyleBackColor = true;
            // 
            // btnOduncEkle
            // 
            this.btnOduncEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOduncEkle.Location = new System.Drawing.Point(82, 172);
            this.btnOduncEkle.Name = "btnOduncEkle";
            this.btnOduncEkle.Size = new System.Drawing.Size(145, 46);
            this.btnOduncEkle.TabIndex = 5;
            this.btnOduncEkle.Text = "Ödünç Ekle";
            this.btnOduncEkle.UseVisualStyleBackColor = false;
            this.btnOduncEkle.Click += new System.EventHandler(this.btnOduncEkle_Click_1);
            // 
            // btnOduncListele
            // 
            this.btnOduncListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOduncListele.Location = new System.Drawing.Point(233, 172);
            this.btnOduncListele.Name = "btnOduncListele";
            this.btnOduncListele.Size = new System.Drawing.Size(133, 46);
            this.btnOduncListele.TabIndex = 6;
            this.btnOduncListele.Text = "Ödünç Listele";
            this.btnOduncListele.UseVisualStyleBackColor = false;
            this.btnOduncListele.Click += new System.EventHandler(this.btnOduncListele_Click_1);
            // 
            // btnOduncSil
            // 
            this.btnOduncSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOduncSil.Location = new System.Drawing.Point(372, 172);
            this.btnOduncSil.Name = "btnOduncSil";
            this.btnOduncSil.Size = new System.Drawing.Size(125, 46);
            this.btnOduncSil.TabIndex = 7;
            this.btnOduncSil.Text = "Ödünç Sil";
            this.btnOduncSil.UseVisualStyleBackColor = false;
            this.btnOduncSil.Click += new System.EventHandler(this.btnOduncSil_Click);
            // 
            // btnOduncGuncelle
            // 
            this.btnOduncGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOduncGuncelle.Location = new System.Drawing.Point(503, 172);
            this.btnOduncGuncelle.Name = "btnOduncGuncelle";
            this.btnOduncGuncelle.Size = new System.Drawing.Size(134, 46);
            this.btnOduncGuncelle.TabIndex = 8;
            this.btnOduncGuncelle.Text = "Ödünç Güncelle";
            this.btnOduncGuncelle.UseVisualStyleBackColor = false;
            this.btnOduncGuncelle.Click += new System.EventHandler(this.btnOduncGuncelle_Click);
            // 
            // dataGridViewOdunc
            // 
            this.dataGridViewOdunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdunc.Location = new System.Drawing.Point(80, 224);
            this.dataGridViewOdunc.Name = "dataGridViewOdunc";
            this.dataGridViewOdunc.RowHeadersWidth = 51;
            this.dataGridViewOdunc.RowTemplate.Height = 24;
            this.dataGridViewOdunc.Size = new System.Drawing.Size(557, 244);
            this.dataGridViewOdunc.TabIndex = 9;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(823, 443);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(108, 39);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 508);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dataGridViewOdunc);
            this.Controls.Add(this.btnOduncGuncelle);
            this.Controls.Add(this.btnOduncSil);
            this.Controls.Add(this.btnOduncListele);
            this.Controls.Add(this.btnOduncEkle);
            this.Controls.Add(this.chkTeslimEdildi);
            this.Controls.Add(this.dtpIadeTarihi);
            this.Controls.Add(this.dtpAlisTarihi);
            this.Controls.Add(this.cmbKitap);
            this.Controls.Add(this.cmbUye);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUye;
        private System.Windows.Forms.ComboBox cmbKitap;
        private System.Windows.Forms.DateTimePicker dtpAlisTarihi;
        private System.Windows.Forms.DateTimePicker dtpIadeTarihi;
        private System.Windows.Forms.CheckBox chkTeslimEdildi;
        private System.Windows.Forms.Button btnOduncEkle;
        private System.Windows.Forms.Button btnOduncListele;
        private System.Windows.Forms.Button btnOduncSil;
        private System.Windows.Forms.Button btnOduncGuncelle;
        private System.Windows.Forms.DataGridView dataGridViewOdunc;
        private System.Windows.Forms.Button btnCikis;
    }
}