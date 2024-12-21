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
	public partial class YazarGüncelle : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public YazarGüncelle()
		{
			InitializeComponent();
			SirketleriYukle();
			YazarlariListele();
			YazarlariYukle();
		}

		private void btnyazargüncelle_Click(object sender, EventArgs e)
		{
			if (cbyazarid.SelectedValue == null)
			{
				MessageBox.Show("Güncellenecek yazarı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int yazarId = Convert.ToInt32(cbyazarid.SelectedValue);
			string yeniYazarAdi = yazaraditextbox.Text;
			string yeniYazarSoyadi = yazarsoyaditextbox.Text;

			string query = "UPDATE yazarlar SET yazaradi = @yazaradi, yazarsoyadi = @yazarsoyadi WHERE yazarid = @yazarid";

			try
			{
				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					conn.Open();
					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@yazarid", yazarId);
						cmd.Parameters.AddWithValue("@yazaradi", yeniYazarAdi);
						cmd.Parameters.AddWithValue("@yazarsoyadi", yeniYazarSoyadi);

						cmd.ExecuteNonQuery();
						MessageBox.Show("Yazar başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						YazarlariYukle(); // ComboBox'ı güncelle
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		private void SirketleriYukle()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT sirketid, sirketadi FROM sirket"; // Şirket bilgilerini çek
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					cbsirketid.DataSource = dt; // ComboBox'a veri kaynağı bağla
					cbsirketid.DisplayMember = "sirketadi"; // Görünecek alan
					cbsirketid.ValueMember = "sirketid";    // Seçilecek değer
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Şirketler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void YazarlariListele()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT * FROM yazarlar"; // Kitap tablosundaki tüm veriler
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridyazarlistele.DataSource = dt; // Veriyi DataGridView'e yükle
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void YazarlariYukle()
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
					cbyazarid.ValueMember = "yazarid";      // Arka plandaki değer
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Yazarlar yüklenirken hata oluştu: {ex.Message}");
				}
			}
		}

		private void btnyazarlistelegeridön_Click(object sender, EventArgs e)
		{
			YazarListele yazarlistele = new YazarListele();
			yazarlistele.Show();
			this.Hide();
		}
	}
}
