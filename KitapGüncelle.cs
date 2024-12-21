using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
	public partial class KitapGüncelle : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";

		public KitapGüncelle()
		{
			InitializeComponent();
			KitaplariYukle(); // ComboBox'a kitapları yükle
			YazarlarYukle();  // ComboBox'a yazarları yükle
			KategorilerYukle(); // ComboBox'a kategorileri yükle
			RaflarYukle();
			KitaplariListele();
		}

		private void kitapgüncellebutton_Click(object sender, EventArgs e)
		{
			int kitapid = Convert.ToInt32(güncellecekkitap.Text); // Güncellenecek kitabın ID'si
			string isbn = isbntextbox.Text;
			string kitapadi = kitapaditextbox.Text;
			int yazarid = Convert.ToInt32(cbyazarid.SelectedValue);
			int rafid = Convert.ToInt32(cbrafid.SelectedValue);
			int kategoriid = Convert.ToInt32(cbkategoriid.SelectedValue);
			int stokadedi = Convert.ToInt32(stokadeditextbox.Text);

			// SQL sorgusu
			string query = "UPDATE kitaplar " +
						   "SET isbn = @isbn, kitapadi = @kitapadi, yazarid = @yazarid, " +
						   "rafid = @rafid, kategoriid = @kategoriid, stokadedi = @stokadedi " +
						   "WHERE kitapid = @kitapid";

			try
			{
				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					conn.Open();
					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						// Parametre atamaları
						cmd.Parameters.AddWithValue("@kitapid", kitapid);
						cmd.Parameters.AddWithValue("@isbn", isbn);
						cmd.Parameters.AddWithValue("@kitapadi", kitapadi);
						cmd.Parameters.AddWithValue("@yazarid", yazarid);
						cmd.Parameters.AddWithValue("@rafid", rafid);
						cmd.Parameters.AddWithValue("@kategoriid", kategoriid);
						cmd.Parameters.AddWithValue("@stokadedi", stokadedi);

						int affectedRows = cmd.ExecuteNonQuery();
						if (affectedRows > 0)
						{
							MessageBox.Show("Kitap başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
							KitaplariListele(); // Kitapları yeniden listele
						}
						else
						{
							MessageBox.Show("Kitap güncellenemedi. Lütfen kitap ID'sini kontrol edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void KitaplariYukle()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT kitapid, kitapadi FROM kitaplar";
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					güncellecekkitap.DataSource = dt;
					güncellecekkitap.DisplayMember = "kitapadi"; // Görünecek isim
					güncellecekkitap.ValueMember = "kitapid";   // Arka plandaki değer
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kitaplar yüklenirken hata oluştu: {ex.Message}");
				}
			}
		}
		private void KitaplariListele()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT * FROM kitaplar"; // Kitap tablosundaki tüm veriler
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridViewkitapekle.DataSource = dt; // Veriyi DataGridView'e yükle
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		// Yazarları ComboBox'a yükle
		private void YazarlarYukle()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT yazarid, yazaradi || ' ' || yazarsoyadi AS yazartamadi FROM yazarlar";
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					cbyazarid.DataSource = dt;
					cbyazarid.DisplayMember = "yazartamadi"; // Görünecek değer
					cbyazarid.ValueMember = "yazarid";   // Arka plandaki değer
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Yazarlar yüklenirken hata oluştu: {ex.Message}");
				}
			}
		}

		// Kategorileri ComboBox'a yükle
		private void KategorilerYukle()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT kategoriid, kategoriadi FROM kategoriler";
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					cbkategoriid.DataSource = dt;
					cbkategoriid.DisplayMember = "kategoriadi";
					cbkategoriid.ValueMember = "kategoriid";
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kategoriler yüklenirken hata oluştu: {ex.Message}");
				}
			}
		}

		// Rafları ComboBox'a yükle
		private void RaflarYukle()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT rafid, konum FROM raflar";
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					cbrafid.DataSource = dt;
					cbrafid.DisplayMember = "konum";
					cbrafid.ValueMember = "rafid";
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Raflar yüklenirken hata oluştu: {ex.Message}");
				}
			}
		}

		private void güncellebutton_Click(object sender, EventArgs e)
		{
			int kitapid = Convert.ToInt32(güncellecekkitap.SelectedValue); // Seçili kitabın ID'si
			string isbn = isbntextbox.Text; // Kullanıcıdan alınan ISBN
			string kitapadi = kitapaditextbox.Text; // Kullanıcıdan alınan kitap adı
			int yazarid = Convert.ToInt32(cbyazarid.SelectedValue); // Seçili yazarın ID'si
			int rafid = Convert.ToInt32(cbrafid.SelectedValue); // Seçili rafın ID'si
			int kategoriid = Convert.ToInt32(cbkategoriid.SelectedValue); // Seçili kategorinin ID'si
			int stokadedi = Convert.ToInt32(stokadeditextbox.Text); // Kullanıcıdan alınan stok adedi

			string query = "UPDATE kitaplar " +
						   "SET isbn = @isbn, kitapadi = @kitapadi, yazarid = @yazarid, " +
						   "rafid = @rafid, kategoriid = @kategoriid, stokadedi = @stokadedi " +
						   "WHERE kitapid = @kitapid";

			try
			{
				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					conn.Open();
					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						// Parametreler atanıyor
						cmd.Parameters.AddWithValue("@kitapid", kitapid);
						cmd.Parameters.AddWithValue("@isbn", isbn);
						cmd.Parameters.AddWithValue("@kitapadi", kitapadi);
						cmd.Parameters.AddWithValue("@yazarid", yazarid);
						cmd.Parameters.AddWithValue("@rafid", rafid);
						cmd.Parameters.AddWithValue("@kategoriid", kategoriid);
						cmd.Parameters.AddWithValue("@stokadedi", stokadedi);

						int affectedRows = cmd.ExecuteNonQuery();
						if (affectedRows > 0)
						{
							MessageBox.Show("Kitap başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
							KitaplariYukle(); // Kitapları yeniden yükle
						}
						else
						{
							MessageBox.Show("Kitap güncellenemedi. Lütfen bilgileri kontrol edin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnlistelegeridön_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.Show();
			this.Hide();
		}
	}
}

