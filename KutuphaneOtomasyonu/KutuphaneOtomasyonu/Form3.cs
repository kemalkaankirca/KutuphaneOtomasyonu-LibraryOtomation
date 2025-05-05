using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form3 : Form
    {
        string connectionString = "Server=KIRCA;Database=KutuphaneDB;Trusted_Connection=True;";

        public Form3()
        {
            InitializeComponent();
            UyeListele();

            txtUyeAd.Text = "Üye Adı";
            txtUyeSoyad.Text = "Üye Soyadı";
            txtUyeTelefon.Text = "Telefon";
            txtUyeEmail.Text = "Üye Mail";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            UyeListele();
            Color baseColor = Color.FromArgb(30, 136, 229);         // mavi
            Color hoverColor = Color.FromArgb(100, 181, 246);       // açık mavi
            Color textColor = Color.White;                          // beyaz yazı

            // Tüm butonlar için
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = baseColor;
                    btn.ForeColor = textColor;
                    btn.FlatAppearance.BorderSize = 0;

                    btn.MouseEnter += (s, ev) => { btn.BackColor = hoverColor; };
                    btn.MouseLeave += (s, ev) => { btn.BackColor = baseColor; };
                }
            }

            // DataGridView için
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
        }

        private void UyeListele()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Uyeler";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeleme hatası: " + ex.Message);
                }
            }
        }



        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Uyeler (ad, soyad, telefon, eposta) VALUES (@ad, @soyad, @telefon, @eposta)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ad", txtUyeAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtUyeSoyad.Text);
                    cmd.Parameters.AddWithValue("@telefon", txtUyeTelefon.Text);
                    cmd.Parameters.AddWithValue("@eposta", txtUyeEmail.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Üye başarıyla eklendi!");

                        // BURASI: Ekleme sonrası kutuları sıfırla
                        txtUyeAd.Text = "Üye Adı";
                        txtUyeSoyad.Text = "Üye Soyadı";
                        txtUyeTelefon.Text = "Telefon";
                        txtUyeEmail.Text = "Üye Mail";

                        UyeListele();
                    }
                    else
                    {
                        MessageBox.Show("Üye eklenemedi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Üye ekleme hatası: " + ex.Message);
                }
            }
        }


        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int uyeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["uye_id"].Value);

                DialogResult dialog = MessageBox.Show("Seçili üyeyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM Uyeler WHERE uye_id = @uyeId";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@uyeId", uyeId);

                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                                MessageBox.Show("Üye başarıyla silindi!");
                            }
                            else
                            {
                                MessageBox.Show("Üye silinemedi.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Silme hatası: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int uyeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["uye_id"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Uyeler SET ad = @ad, soyad = @soyad, telefon = @telefon, eposta = @eposta WHERE uye_id = @uyeId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ad", txtUyeAd.Text);
                        cmd.Parameters.AddWithValue("@soyad", txtUyeSoyad.Text);
                        cmd.Parameters.AddWithValue("@telefon", txtUyeTelefon.Text);
                        cmd.Parameters.AddWithValue("@eposta", txtUyeEmail.Text);
                        cmd.Parameters.AddWithValue("@uyeId", uyeId);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Üye başarıyla güncellendi!");
                            UyeListele();
                        }
                        else
                        {
                            MessageBox.Show("Üye güncellenemedi.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Güncelleme hatası: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir satır seçin.");
            }
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            UyeListele();
        }

        private void txtUyeAd_Enter(object sender, EventArgs e)
        {
            if (txtUyeAd.Text == "Üye Adı")
                txtUyeAd.Text = "";
        }

        private void txtUyeAd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUyeAd.Text))
                txtUyeAd.Text = "Üye Adı";
        }

        private void txtUyeSoyad_Enter(object sender, EventArgs e)
        {
            if (txtUyeSoyad.Text == "Üye Soyadı")
                txtUyeSoyad.Text = "";
        }

        private void txtUyeSoyad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUyeSoyad.Text))
                txtUyeSoyad.Text = "Üye Soyadı";
        }

        private void txtUyeTelefon_Enter(object sender, EventArgs e)
        {
            if (txtUyeTelefon.Text == "Telefon")
                txtUyeTelefon.Text = "";
        }

        private void txtUyeTelefon_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUyeTelefon.Text))
                txtUyeTelefon.Text = "Telefon";
        }

        private void txtUyeEmail_Enter(object sender, EventArgs e)
        {
            if (txtUyeEmail.Text == "Üye Mail")
                txtUyeEmail.Text = "";
        }

        private void txtUyeEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUyeEmail.Text))
                txtUyeEmail.Text = "Üye Mail";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
