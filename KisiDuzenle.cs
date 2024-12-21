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
	public partial class KisiDuzenle : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public KisiDuzenle()
		{
			InitializeComponent();
			KisiTurleriniYukle();
			KisileriComboBoxaYukle();
			KisileriListele();
		}

		private void btnkisigüncelle_Click(object sender, EventArgs e)
		{
			if (cbguncellecekkisiid.SelectedValue == null)
			{
				MessageBox.Show("Lütfen güncellenecek kişiyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int kisiid = Convert.ToInt32(cbguncellecekkisiid.SelectedValue);
			string kisiadi = kisiaditextbox.Text.Trim();
			string kisisoyadi = kisisoyaditextbox.Text.Trim();
			string kisituru = cbkisituru.SelectedItem.ToString();
			long telefonno;

			// Telefon numarası boş olabilir veya long'a çevrilebilir olmalı
			if (!long.TryParse(telefonnotextBox.Text.Trim(), out telefonno))
			{
				telefonno = 0; // Eğer boş bırakılmışsa veya çevrilemezse 0 atanabilir.
			}

			if (string.IsNullOrWhiteSpace(kisiadi) || string.IsNullOrWhiteSpace(kisisoyadi) || string.IsNullOrWhiteSpace(kisituru))
			{
				MessageBox.Show("Lütfen tüm zorunlu alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string query = "UPDATE kisiler SET kisiadi = @kisiadi, kisisoyadi = @kisisoyadi, telefonno = @telefonno, kisituru = @kisituru WHERE kisiid = @kisiid";

			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@kisiid", kisiid);
					cmd.Parameters.AddWithValue("@kisiadi", kisiadi);
					cmd.Parameters.AddWithValue("@kisisoyadi", kisisoyadi);
					cmd.Parameters.AddWithValue("@telefonno", telefonno == 0 ? (object)DBNull.Value : telefonno);
					cmd.Parameters.AddWithValue("@kisituru", kisituru);

					cmd.ExecuteNonQuery();
					MessageBox.Show("Kişi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

					KisileriComboBoxaYukle(); // Güncellenen kişiyi ComboBox'a tekrar yükle
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kişi güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
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

		private void btnkisileredön_Click(object sender, EventArgs e)
		{

			KisileriGörüntüle k = new KisileriGörüntüle();
			k.Show();
			this.Hide();
		}
		private void KisileriComboBoxaYukle()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT kisiid, kisiadi || ' ' || kisisoyadi AS kisitamadi FROM kisiler";
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					cbguncellecekkisiid.DataSource = dt;
					cbguncellecekkisiid.DisplayMember = "kisitamadi"; // Görünen kişi adı ve soyadı
					cbguncellecekkisiid.ValueMember = "kisiid";      // Arka planda kişi ID'si
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kişiler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void kisilerComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbguncellecekkisiid.SelectedValue != null)
			{
				int kisiid = Convert.ToInt32(cbguncellecekkisiid.SelectedValue);

				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					try
					{
						conn.Open();
						string query = "SELECT kisiadi, kisisoyadi, telefonno, kisituru FROM kisiler WHERE kisiid = @kisiid";
						NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
						cmd.Parameters.AddWithValue("@kisiid", kisiid);

						using (NpgsqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								kisisoyadi.Text = reader["kisiadi"].ToString();
								kisisoyaditextbox.Text = reader["kisisoyadi"].ToString();
								telefonnotextBox.Text = reader["telefonno"] != DBNull.Value
														? reader["telefonno"].ToString()
														: string.Empty;
								cbkisituru.SelectedItem = reader["kisituru"].ToString();
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Kişi bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

	}
}
