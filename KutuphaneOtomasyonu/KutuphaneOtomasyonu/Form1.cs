using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=KIRCA;Database=KutuphaneDB;Trusted_Connection=True;";



        public Form1()
        {
            InitializeComponent();
            this.btnUyeBilgileri.FlatStyle = FlatStyle.Flat;
            this.btnUyeBilgileri.FlatAppearance.BorderSize = 0;
            this.btnUyeBilgileri.BackColor = Color.Transparent;
            this.btnUyeBilgileri.TabStop = false;

            this.btnOduncIslemleri.FlatStyle = FlatStyle.Flat;
            this.btnOduncIslemleri.FlatAppearance.BorderSize = 0;
            this.btnOduncIslemleri.BackColor = Color.Transparent;
            this.btnOduncIslemleri.TabStop = false;

            this.BackgroundImage = Image.FromFile("C:\\Users\\kemal\\Downloads\\kutupfoto1.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(1280, 720);

            using (Image originalImage = Image.FromFile(@"C:\Users\Kemal\Downloads\digital-book.png"))
            {
                int targetWidth = 36;  // istediğin genişlik
                int targetHeight = 36; // istediğin yükseklik

                Bitmap resizedImage = new Bitmap(originalImage, new Size(targetWidth, targetHeight));
                btnListele.Image = resizedImage;
            }

            btnListele.ImageAlign = ContentAlignment.MiddleLeft;
            btnListele.TextAlign = ContentAlignment.MiddleRight;
            btnListele.Text = " Kitapları Listele";
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.FlatAppearance.BorderSize = 0;
            //btnListele.BackColor = Color.FromArgb(128, 0, 0, 0); // yarı şeffaf siyah arka plan
            btnListele.ForeColor = Color.Gold;  // canlı sarı yazı
            btnListele.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnListele.ImageAlign = ContentAlignment.MiddleLeft;
            btnListele.TextAlign = ContentAlignment.MiddleRight;
            btnListele.Text = "  Kitapları Listele";
            // Başlangıçta %50 şeffaf siyah
            btnListele.BackColor = Color.FromArgb(128, 0, 0, 0);

            // Mouse üstüne gelince daha açık (%30 şeffaf)
            btnListele.MouseEnter += (s, e) =>
            {
                btnListele.BackColor = Color.FromArgb(77, 0, 0, 0);  // 77 ≈ %30 opaklık
            };

            // Mouse ayrılınca tekrar %50 şeffaf
            btnListele.MouseLeave += (s, e) =>
            {
                btnListele.BackColor = Color.FromArgb(128, 0, 0, 0);
            };


            btnUyeBilgileri.ImageAlign = ContentAlignment.MiddleLeft;
            btnUyeBilgileri.TextAlign = ContentAlignment.MiddleRight;
            //btnUyeBilgileri.Text = " Kitapları Listele";
            btnUyeBilgileri.FlatStyle = FlatStyle.Flat;
            btnUyeBilgileri.FlatAppearance.BorderSize = 0;
            //btnListele.BackColor = Color.FromArgb(128, 0, 0, 0); // yarı şeffaf siyah arka plan
            btnUyeBilgileri.ForeColor = Color.Gold;  // canlı sarı yazı
            btnUyeBilgileri.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnUyeBilgileri.ImageAlign = ContentAlignment.MiddleLeft;
            btnUyeBilgileri.TextAlign = ContentAlignment.MiddleRight;
            //btnUyeBilgileri.Text = "  Kitapları Listele";
            // Başlangıçta %50 şeffaf siyah
            btnUyeBilgileri.BackColor = Color.FromArgb(128, 0, 0, 0);

            // Mouse üstüne gelince daha açık (%30 şeffaf)
            btnUyeBilgileri.MouseEnter += (s, e) =>
            {
                btnUyeBilgileri.BackColor = Color.FromArgb(77, 0, 0, 0);  // 77 ≈ %30 opaklık
            };

            // Mouse ayrılınca tekrar %50 şeffaf
            btnUyeBilgileri.MouseLeave += (s, e) =>
            {
                btnUyeBilgileri.BackColor = Color.FromArgb(128, 0, 0, 0);
            };

            btnOduncIslemleri.ImageAlign = ContentAlignment.MiddleLeft;
            btnOduncIslemleri.TextAlign = ContentAlignment.MiddleRight;
            //btnOduncIslemleri.Text = " Kitapları Listele";
            btnOduncIslemleri.FlatStyle = FlatStyle.Flat;
            btnOduncIslemleri.FlatAppearance.BorderSize = 0;
            //btnListele.BackColor = Color.FromArgb(128, 0, 0, 0); // yarı şeffaf siyah arka plan
            btnOduncIslemleri.ForeColor = Color.Gold;  // canlı sarı yazı
            btnOduncIslemleri.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnOduncIslemleri.ImageAlign = ContentAlignment.MiddleLeft;
            btnOduncIslemleri.TextAlign = ContentAlignment.MiddleRight;
            //btnOduncIslemleri.Text = "  Kitapları Listele";
            // Başlangıçta %50 şeffaf siyah
            btnOduncIslemleri.BackColor = Color.FromArgb(128, 0, 0, 0);

            // Mouse üstüne gelince daha açık (%30 şeffaf)
            btnOduncIslemleri.MouseEnter += (s, e) =>
            {
                btnOduncIslemleri.BackColor = Color.FromArgb(77, 0, 0, 0);  // 77 ≈ %30 opaklık
            };

            // Mouse ayrılınca tekrar %50 şeffaf
            btnOduncIslemleri.MouseLeave += (s, e) =>
            {
                btnOduncIslemleri.BackColor = Color.FromArgb(128, 0, 0, 0);
            };

            





        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                txtIsim.Text = row.Cells["isim"].Value.ToString();
                txtYazar.Text = row.Cells["yazar"].Value.ToString();
                txtYayinevi.Text = row.Cells["yayinevi"].Value.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value.ToString();
                txtStok.Text = row.Cells["stok_sayisi"].Value.ToString();
            }
        }




        private void btnListele_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Kitaplar";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeleme hatası: " + ex.ToString());
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Kitaplar (isim, yazar, yayinevi, ISBN, stok_sayisi) VALUES (@isim, @yazar, @yayinevi, @ISBN, @stok)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@isim", txtIsim.Text);
                    cmd.Parameters.AddWithValue("@yazar", txtYazar.Text);
                    cmd.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@stok", int.Parse(txtStok.Text));
                    //foreach (DataGridViewColumn col in dataGridView1.Columns)
                    //{
                        //MessageBox.Show("Sütun adı: " + col.Name);
                    //}


                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Kitap başarıyla eklendi!");

                        txtIsim.Text = "Kitap Adı";
                        txtYazar.Text = "Yazar Adı";
                        txtYayinevi.Text = "Yayınevi";
                        txtISBN.Text = "ISBN";
                        txtStok.Text = "Stok Sayısı";

                       
                        this.ActiveControl = null;

                        btnListele.PerformClick();
                    }

                    else
                    {
                        MessageBox.Show("Kitap eklenemedi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ekleme hatası: " + ex.ToString());
                }
            }
        }

       

        private void txtIsim_Enter(object sender, EventArgs e)
        {
            if (txtIsim.Text == "Kitap Adı")
            {
                txtIsim.Text = "";
            }
        }

        private void txtIsim_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIsim.Text))
            {
                txtIsim.Text = "Kitap Adı";
            }
        }

        private void txtYazar_Enter(object sender, EventArgs e)
        {
            if (txtYazar.Text == "Yazar Adı")
            {
                txtYazar.Text = "";
            }
        }

        private void txtYazar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYazar.Text))
            {
                txtYazar.Text = "Yazar Adı";
            }
        }

        private void txtYayinevi_Enter(object sender, EventArgs e)
        {
            if (txtYayinevi.Text == "Yayınevi")
            {
                txtYayinevi.Text = "";
            }
        }

        private void txtYayinevi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYayinevi.Text))
            {
                txtYayinevi.Text = "Yayınevi";
            }
        }

        private void txtISBN_Enter(object sender, EventArgs e)
        {
            if (txtISBN.Text == "ISBN")
            {
                txtISBN.Text = "";
            }
        }

        private void txtISBN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                txtISBN.Text = "ISBN";
            }
        }

        private void txtStok_Enter(object sender, EventArgs e)
        {
            if (txtStok.Text == "Stok Sayısı")
            {
                txtStok.Text = "";
            }
        }

        private void txtStok_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStok.Text))
            {
                txtStok.Text = "Stok Sayısı";
            }
        }

        private void txtStok_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int kitapId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["kitap_id"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Kitaplar WHERE kitap_id = @kitapId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@kitapId", kitapId);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Kitap başarıyla silindi!");
                            btnListele.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Kitap silinemedi.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme hatası: " + ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color baseColor = Color.FromArgb(240, 240, 240); // açık gri
            Color hoverColor = Color.FromArgb(220, 220, 220); // biraz koyu gri
            Color textColor = Color.Black;

            foreach (Control ctrl in this.Controls)
            {

                // DataGridView tasarımı
                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.BackgroundColor = Color.FromArgb(240, 240, 240);


                dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);

                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                dataGridView1.RowTemplate.Height = 30;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.GridColor = Color.LightGray;
                if (ctrl is Button btn)
                {
                    //exclude btnUyeBilgileri and btnOduncIslemleri
                    if (btn == btnUyeBilgileri || btn == btnOduncIslemleri || btn == btnListele)
                        continue;
                    //make a cooler design
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = baseColor;
                    btn.ForeColor = textColor;
                    btn.FlatAppearance.BorderSize = 0;

                    // Hover efekti
                    btn.MouseEnter += (s, ev) =>
                    {
                        btn.BackColor = hoverColor;
                    };
                    btn.MouseLeave += (s, ev) =>
                    {
                        btn.BackColor = baseColor;
                    };
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int kitapId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["kitap_id"].Value);

                string isim = txtIsim.Text != "Kitap Adı" ? txtIsim.Text : dataGridView1.SelectedRows[0].Cells["isim"].Value.ToString();
                string yazar = txtYazar.Text != "Yazar Adı" ? txtYazar.Text : dataGridView1.SelectedRows[0].Cells["yazar"].Value.ToString();
                string yayinevi = txtYayinevi.Text != "Yayınevi" ? txtYayinevi.Text : dataGridView1.SelectedRows[0].Cells["yayinevi"].Value.ToString();
                string isbn = txtISBN.Text != "ISBN" ? txtISBN.Text : dataGridView1.SelectedRows[0].Cells["ISBN"].Value.ToString();

                if (!int.TryParse(txtStok.Text, out int stok))
                {
                    stok = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["stok_sayisi"].Value);
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Kitaplar SET isim = @isim, yazar = @yazar, yayinevi = @yayinevi, ISBN = @ISBN, stok_sayisi = @stok WHERE kitap_id = @kitapId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@isim", isim);
                        cmd.Parameters.AddWithValue("@yazar", yazar);
                        cmd.Parameters.AddWithValue("@yayinevi", yayinevi);
                        cmd.Parameters.AddWithValue("@ISBN", isbn);
                        cmd.Parameters.AddWithValue("@stok", stok);
                        cmd.Parameters.AddWithValue("@kitapId", kitapId);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Kitap başarıyla güncellendi!");
                            btnListele.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Kitap güncellenemedi.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Güncelleme hatası: " + ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek kitabı seçin.");
            }
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Kitaplar WHERE isim LIKE @ara OR yazar LIKE @ara";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ara", "%" + txtAra.Text + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arama hatası: " + ex.ToString());
                }
            }
        }

        private void btnUyeBilgileri_Click(object sender, EventArgs e)
        {
            Form3 uyeForm = new Form3();
            uyeForm.Show();
        }

        private void btnUyeBilgileri_Click_1(object sender, EventArgs e)
        {
            Form3 uyeForm = new Form3();
            uyeForm.Show();
        }

        private void btnOduncIslemleri_Click(object sender, EventArgs e)
        {
            Form4 oduncForm = new Form4();
            oduncForm.Show();
        }

       
    }

}