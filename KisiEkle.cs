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
	public partial class KisiEkle : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public KisiEkle()
		{
			InitializeComponent();
			KisiTurleriniYukle();

		}

		private void btnkisiekle_Click(object sender, EventArgs e)
		{
			string kisiadi = kisiaditextbox.Text.Trim();
			string kisisoyadi = kisisoyaditextbox.Text.Trim();
			string kisituru = cbkisituru.SelectedItem?.ToString();
			long? telefonno = null;

			if (!string.IsNullOrWhiteSpace(telefonnotextBox.Text))
			{
				if (!long.TryParse(telefonnotextBox.Text.Trim(), out long parsedTelefonno))
				{
					MessageBox.Show("Telefon numarası yalnızca sayılardan oluşmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				telefonno = parsedTelefonno;
			}

			if (string.IsNullOrWhiteSpace(kisiadi) || string.IsNullOrWhiteSpace(kisisoyadi) || string.IsNullOrWhiteSpace(kisituru))
			{
				MessageBox.Show("Lütfen tüm zorunlu alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string query = "INSERT INTO kisiler (kisituru,kisiadi, kisisoyadi,telefonno) " +
						   "VALUES (@kisituru, @kisiadi, @kisisoyadi, @telefonno)";

			try
			{
				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					conn.Open();
					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@kisituru", kisituru);
						cmd.Parameters.AddWithValue("@kisiadi", kisiadi);
						cmd.Parameters.AddWithValue("@kisisoyadi", kisisoyadi);
						cmd.Parameters.AddWithValue("@telefonno", (object)telefonno ?? DBNull.Value);

						cmd.ExecuteNonQuery();
						MessageBox.Show("Kişi başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						KisileriListele(); // Listeyi güncelle
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void KisileriListele()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT kisiid, kisituru, kisiadi, kisisoyadi, telefonno FROM kisiler";
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridkisilerigörüntüle.DataSource = dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kişiler listesi yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void KisiTurleriniYukle()
		{
			cbkisituru.Items.Clear();
			cbkisituru.Items.Add("Üye");
			cbkisituru.Items.Add("Personel");
			cbkisituru.SelectedIndex = 0; // Varsayılan olarak ilk öğeyi seç
		}

		private void button1_Click(object sender, EventArgs e)
		{
			KisileriGörüntüle k = new KisileriGörüntüle();
			k.Show();
			this.Hide();
		}
	}
}
