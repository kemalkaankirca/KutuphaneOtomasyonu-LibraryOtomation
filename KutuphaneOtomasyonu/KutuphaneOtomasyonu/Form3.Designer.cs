namespace KutuphaneOtomasyonu
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

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
            this.txtUyeAd = new System.Windows.Forms.TextBox();
            this.txtUyeSoyad = new System.Windows.Forms.TextBox();
            this.txtUyeTelefon = new System.Windows.Forms.TextBox();
            this.txtUyeEmail = new System.Windows.Forms.TextBox();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.btnUyeGuncelle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUyeAd
            // 
            this.txtUyeAd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUyeAd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUyeAd.Location = new System.Drawing.Point(101, 30);
            this.txtUyeAd.Multiline = true;
            this.txtUyeAd.Name = "txtUyeAd";
            this.txtUyeAd.Size = new System.Drawing.Size(150, 44);
            this.txtUyeAd.TabIndex = 9;
            this.txtUyeAd.Text = "Üye Adı";
            this.txtUyeAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUyeAd.Enter += new System.EventHandler(this.txtUyeAd_Enter);
            this.txtUyeAd.Leave += new System.EventHandler(this.txtUyeAd_Leave);
            // 
            // txtUyeSoyad
            // 
            this.txtUyeSoyad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUyeSoyad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUyeSoyad.Location = new System.Drawing.Point(257, 30);
            this.txtUyeSoyad.Multiline = true;
            this.txtUyeSoyad.Name = "txtUyeSoyad";
            this.txtUyeSoyad.Size = new System.Drawing.Size(150, 44);
            this.txtUyeSoyad.TabIndex = 8;
            this.txtUyeSoyad.Text = "Üye Soyadı";
            this.txtUyeSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUyeSoyad.Enter += new System.EventHandler(this.txtUyeSoyad_Enter);
            this.txtUyeSoyad.Leave += new System.EventHandler(this.txtUyeSoyad_Leave);
            // 
            // txtUyeTelefon
            // 
            this.txtUyeTelefon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUyeTelefon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUyeTelefon.Location = new System.Drawing.Point(569, 30);
            this.txtUyeTelefon.Multiline = true;
            this.txtUyeTelefon.Name = "txtUyeTelefon";
            this.txtUyeTelefon.Size = new System.Drawing.Size(150, 44);
            this.txtUyeTelefon.TabIndex = 7;
            this.txtUyeTelefon.Text = "Telefon";
            this.txtUyeTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUyeTelefon.Enter += new System.EventHandler(this.txtUyeTelefon_Enter);
            this.txtUyeTelefon.Leave += new System.EventHandler(this.txtUyeTelefon_Leave);
            // 
            // txtUyeEmail
            // 
            this.txtUyeEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUyeEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUyeEmail.Location = new System.Drawing.Point(413, 30);
            this.txtUyeEmail.Multiline = true;
            this.txtUyeEmail.Name = "txtUyeEmail";
            this.txtUyeEmail.Size = new System.Drawing.Size(150, 44);
            this.txtUyeEmail.TabIndex = 6;
            this.txtUyeEmail.Text = "Üye Mail";
            this.txtUyeEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUyeEmail.Enter += new System.EventHandler(this.txtUyeEmail_Enter);
            this.txtUyeEmail.Leave += new System.EventHandler(this.txtUyeEmail_Leave);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUyeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeEkle.Location = new System.Drawing.Point(732, 174);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(150, 44);
            this.btnUyeEkle.TabIndex = 5;
            this.btnUyeEkle.Text = "Üye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = false;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUyeListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeListele.Location = new System.Drawing.Point(732, 110);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(150, 44);
            this.btnUyeListele.TabIndex = 4;
            this.btnUyeListele.Text = "Üyeleri Listele";
            this.btnUyeListele.UseVisualStyleBackColor = false;
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 393);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUyeSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeSil.Location = new System.Drawing.Point(732, 241);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(150, 44);
            this.btnUyeSil.TabIndex = 2;
            this.btnUyeSil.Text = "Üye Sil";
            this.btnUyeSil.UseVisualStyleBackColor = false;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // btnUyeGuncelle
            // 
            this.btnUyeGuncelle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUyeGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeGuncelle.Location = new System.Drawing.Point(732, 306);
            this.btnUyeGuncelle.Name = "btnUyeGuncelle";
            this.btnUyeGuncelle.Size = new System.Drawing.Size(150, 44);
            this.btnUyeGuncelle.TabIndex = 1;
            this.btnUyeGuncelle.Text = "Üye Güncelle";
            this.btnUyeGuncelle.UseVisualStyleBackColor = false;
            this.btnUyeGuncelle.Click += new System.EventHandler(this.btnUyeGuncelle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCikis.Location = new System.Drawing.Point(732, 459);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(150, 44);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(1030, 515);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnUyeGuncelle);
            this.Controls.Add(this.btnUyeSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUyeListele);
            this.Controls.Add(this.btnUyeEkle);
            this.Controls.Add(this.txtUyeEmail);
            this.Controls.Add(this.txtUyeTelefon);
            this.Controls.Add(this.txtUyeSoyad);
            this.Controls.Add(this.txtUyeAd);
            this.Name = "Form3";
            this.Text = "Üye İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtUyeAd;
        private System.Windows.Forms.TextBox txtUyeSoyad;
        private System.Windows.Forms.TextBox txtUyeTelefon;
        private System.Windows.Forms.TextBox txtUyeEmail;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.Button btnUyeGuncelle;
        private System.Windows.Forms.Button btnCikis;
    }
}
