namespace KutuphaneOtomasyonu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnUyeBilgileri = new System.Windows.Forms.Button();
            this.btnOduncIslemleri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(12, 280);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(143, 74);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Kitapları Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIsim.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtIsim.Location = new System.Drawing.Point(161, 298);
            this.txtIsim.Multiline = true;
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(142, 34);
            this.txtIsim.TabIndex = 2;
            this.txtIsim.Text = "Kitap Adı";
            this.txtIsim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIsim.Enter += new System.EventHandler(this.txtIsim_Enter);
            this.txtIsim.Leave += new System.EventHandler(this.txtIsim_Leave);
            // 
            // txtYazar
            // 
            this.txtYazar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtYazar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtYazar.Location = new System.Drawing.Point(309, 298);
            this.txtYazar.Multiline = true;
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(142, 34);
            this.txtYazar.TabIndex = 3;
            this.txtYazar.Text = "Yazar Adı";
            this.txtYazar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYazar.Enter += new System.EventHandler(this.txtYazar_Enter);
            this.txtYazar.Leave += new System.EventHandler(this.txtYazar_Leave);
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtYayinevi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtYayinevi.Location = new System.Drawing.Point(457, 298);
            this.txtYayinevi.Multiline = true;
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(142, 34);
            this.txtYayinevi.TabIndex = 4;
            this.txtYayinevi.Text = "Yayınevi";
            this.txtYayinevi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYayinevi.Enter += new System.EventHandler(this.txtYayinevi_Enter);
            this.txtYayinevi.Leave += new System.EventHandler(this.txtYayinevi_Leave);
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtISBN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtISBN.Location = new System.Drawing.Point(605, 298);
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(142, 34);
            this.txtISBN.TabIndex = 5;
            this.txtISBN.Text = "ISBN";
            this.txtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtISBN.Enter += new System.EventHandler(this.txtISBN_Enter);
            this.txtISBN.Leave += new System.EventHandler(this.txtISBN_Leave);
            // 
            // txtStok
            // 
            this.txtStok.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtStok.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtStok.Location = new System.Drawing.Point(753, 298);
            this.txtStok.Multiline = true;
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(142, 34);
            this.txtStok.TabIndex = 6;
            this.txtStok.Text = "Stok Sayısı";
            this.txtStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStok.TextChanged += new System.EventHandler(this.txtStok_TextChanged);
            this.txtStok.Enter += new System.EventHandler(this.txtStok_Enter);
            this.txtStok.Leave += new System.EventHandler(this.txtStok_Leave);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(161, 369);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Kitap Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(267, 369);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Kitap Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(373, 369);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(115, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Kitap Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(494, 369);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 22);
            this.txtAra.TabIndex = 10;
            this.txtAra.Text = "Kitap Ara";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAra.Location = new System.Drawing.Point(494, 397);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 42);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnUyeBilgileri
            // 
            this.btnUyeBilgileri.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnUyeBilgileri.FlatAppearance.BorderSize = 10;
            this.btnUyeBilgileri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnUyeBilgileri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnUyeBilgileri.Location = new System.Drawing.Point(21, 432);
            this.btnUyeBilgileri.Name = "btnUyeBilgileri";
            this.btnUyeBilgileri.Size = new System.Drawing.Size(111, 23);
            this.btnUyeBilgileri.TabIndex = 13;
            this.btnUyeBilgileri.Text = "Üye Bilgileri";
            this.btnUyeBilgileri.UseVisualStyleBackColor = true;
            this.btnUyeBilgileri.Click += new System.EventHandler(this.btnUyeBilgileri_Click_1);
            // 
            // btnOduncIslemleri
            // 
            this.btnOduncIslemleri.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOduncIslemleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnOduncIslemleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnOduncIslemleri.Location = new System.Drawing.Point(161, 432);
            this.btnOduncIslemleri.Name = "btnOduncIslemleri";
            this.btnOduncIslemleri.Size = new System.Drawing.Size(142, 23);
            this.btnOduncIslemleri.TabIndex = 14;
            this.btnOduncIslemleri.Text = "Ödünç İşlemleri";
            this.btnOduncIslemleri.UseVisualStyleBackColor = true;
            this.btnOduncIslemleri.Click += new System.EventHandler(this.btnOduncIslemleri_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1102, 500);
            this.Controls.Add(this.btnOduncIslemleri);
            this.Controls.Add(this.btnUyeBilgileri);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtYayinevi);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnUyeBilgileri;
        private System.Windows.Forms.Button btnOduncIslemleri;
    }
}
