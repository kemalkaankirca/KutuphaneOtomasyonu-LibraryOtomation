using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form4 : Form
    {
        string connectionString = "Server=KIRCA;Database=KutuphaneDB;Trusted_Connection=True;";

        public Form4()
        {
            InitializeComponent();
            UyeYukle();
            KitapYukle();
        }

        private void UyeYukle()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT uye_id, ad FROM Uyeler", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbUye.Items.Add(new { Text = reader["ad"].ToString(), Value = reader["uye_id"] });
                }
            }
        }

        private void KitapYukle()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT kitap_id, isim FROM Kitaplar", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbKitap.Items.Add(new { Text = reader["isim"].ToString(), Value = reader["kitap_id"] });
                }
            }
        }

     

        private void OduncListele()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT o.odunc_id, u.ad AS uye_ad, k.isim AS kitap_ad, o.alis_tarihi, o.iade_tarihi, o.teslim_edildi_mi " +
                    "FROM Odunc o " +
                    "JOIN Uyeler u ON o.uye_id = u.uye_id " +
                    "JOIN Kitaplar k ON o.kitap_id = k.kitap_id", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewOdunc.DataSource = dt;
            }
        }



        


        private void btnOduncEkle_Click_1(object sender, EventArgs e)
        {
            {
                var uye = (dynamic)cmbUye.SelectedItem;
                var kitap = (dynamic)cmbKitap.SelectedItem;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Odunc (uye_id, kitap_id, alis_tarihi, iade_tarihi, teslim_edildi_mi) VALUES (@uye_id, @kitap_id, @alis, @iade, 0)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uye_id", uye.Value);
                    cmd.Parameters.AddWithValue("@kitap_id", kitap.Value);
                    cmd.Parameters.AddWithValue("@alis", dtpAlisTarihi.Value);
                    cmd.Parameters.AddWithValue("@iade", dtpIadeTarihi.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ödünç kaydı eklendi!");
                    OduncListele();
                }
            }
        }

        private void btnOduncListele_Click_1(object sender, EventArgs e)
        {
            {
                OduncListele();
            }
        }

        private void btnOduncSil_Click(object sender, EventArgs e)
        {
            {
                if (dataGridViewOdunc.SelectedRows.Count > 0)
                {
                    int oduncId = Convert.ToInt32(dataGridViewOdunc.SelectedRows[0].Cells["odunc_id"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Odunc WHERE odunc_id = @id", conn);
                        cmd.Parameters.AddWithValue("@id", oduncId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ödünç kaydı silindi!");
                        OduncListele();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçin!");
                }
            }
        }

        private void btnOduncGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewOdunc.SelectedRows.Count > 0)
            {
                int oduncId = Convert.ToInt32(dataGridViewOdunc.SelectedRows[0].Cells["odunc_id"].Value);

                DateTime alisTarihi = dtpAlisTarihi.Value;
                DateTime iadeTarihi = dtpIadeTarihi.Value;

                bool teslimEdildiMi = chkTeslimEdildi.Checked;

                if (alisTarihi > iadeTarihi)
                {
                    MessageBox.Show("İade tarihi, alış tarihinden önce olamaz!");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Odunc SET alis_tarihi = @alis, iade_tarihi = @iade, teslim_edildi_mi = @teslim WHERE odunc_id = @oduncId";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@alis", alisTarihi);
                        cmd.Parameters.AddWithValue("@iade", iadeTarihi);
                        cmd.Parameters.AddWithValue("@teslim", teslimEdildiMi);
                        cmd.Parameters.AddWithValue("@oduncId", oduncId);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Ödünç kaydı başarıyla güncellendi!");
                            OdunclariListele(); // varsa listeyi güncelle
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız oldu.");
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
                MessageBox.Show("Lütfen güncellenecek bir ödünç kaydı seçin.");
            }
        }

        private void OdunclariListele()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Odunc";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewOdunc.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeleme hatası: " + ex.ToString());
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
