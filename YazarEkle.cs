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
	public partial class YazarEkle : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public YazarEkle()
		{
			InitializeComponent();
			SirketleriYukle();
			YazarlariListele();
		}

		private void btnYazarEkle_Click(object sender, EventArgs e)
		{
			string yazaradi = yazaraditextbox.Text;         // Kullanıcıdan yazar adı alınır
			string yazarsoyadi = yazarsoyaditextbox.Text;   // Kullanıcıdan yazar soyadı alınır
			int sirketid = Convert.ToInt32(cbsirketid.SelectedValue); // Şirket seçimi
			string biyografi = biyografitextbox.Text; // Kullanıcıdan biyografi alınır


			if (string.IsNullOrWhiteSpace(yazaradi) ||
	  string.IsNullOrWhiteSpace(yazarsoyadi) ||
	  string.IsNullOrWhiteSpace(biyografi))
			{
				MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}


			string query = "INSERT INTO yazarlar (yazaradi, yazarsoyadi, sirketid, biyografi) " +
						   "VALUES (@yazaradi, @yazarsoyadi, @sirketid, @biyografi)";

			try
			{
				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					conn.Open();
					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@yazaradi", yazaradi);
						cmd.Parameters.AddWithValue("@yazarsoyadi",yazarsoyadi);
						cmd.Parameters.AddWithValue("@sirketid", sirketid);
						cmd.Parameters.AddWithValue("@biyografi", biyografi);

						cmd.ExecuteNonQuery();
						MessageBox.Show("Yazar başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Yazar eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnyazarlistelegeridön_Click(object sender, EventArgs e)
		{
			YazarListele yazarlistele = new YazarListele();
			yazarlistele.Show();
			this.Hide();

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


	}
}
