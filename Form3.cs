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
	public partial class Form3 : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public Form3()
		{
			InitializeComponent();
			YazarlarYukle();
			KategorilerYukle();
			RaflarYukle();
			KitaplariListele();
		}

		private void btnKitapEkle_Click(object sender, EventArgs e)
		{
			
			

			if (string.IsNullOrWhiteSpace(isbntextbox.Text) ||
	  string.IsNullOrWhiteSpace(kitapaditextbox.Text) ||
	  string.IsNullOrEmpty(stokadeditextbox.Text))
			{
				MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!!");
				return;

			}
			else
			{
				string isbn = isbntextbox.Text.Trim();
				string kitapadi = kitapaditextbox.Text.Trim();
				int yazarid = Convert.ToInt32(cbyazarid.SelectedValue);
				int kategoriid = Convert.ToInt32(cbkategoriid.SelectedValue);
				int rafid = Convert.ToInt32(cbrafid.SelectedValue);
				int stokadedi = Convert.ToInt32(stokadeditextbox.Text);

				
			}


			string query = "INSERT INTO kitaplar (isbn, kitapadi, yazarid, kategoriid, rafid, stokadedi) " +
						   "VALUES (@isbn, @kitapadi, @yazarid, @kategoriid, @rafid, @stokadedi)";

			try
			{
				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					conn.Open();
					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@isbn", isbn);
						cmd.Parameters.AddWithValue("@kitapadi", kitapadi);
						cmd.Parameters.AddWithValue("@yazarid", yazarid);
						cmd.Parameters.AddWithValue("@kategoriid", kategoriid);
						cmd.Parameters.AddWithValue("@rafid", rafid);
						cmd.Parameters.AddWithValue("@stokadedi", stokadedi);

						cmd.ExecuteNonQuery();
						MessageBox.Show("Kitap başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						KitaplariListele(); // Listeyi yenile
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

	}
}
