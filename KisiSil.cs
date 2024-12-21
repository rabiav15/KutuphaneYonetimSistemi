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
	public partial class KisiSil : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public KisiSil()
		{
			InitializeComponent();
			KisileriListele();
			KisileriComboBoxaYukle();
		}

		private void btnkisisil_Click(object sender, EventArgs e)
		{


			if (cbsilinecekkisiid.SelectedValue == null)
			{
				MessageBox.Show("Lütfen silinecek kişiyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int kisiid = Convert.ToInt32(cbsilinecekkisiid.SelectedValue);

			DialogResult result = MessageBox.Show("Seçili kişiyi silmek istediğinizden emin misiniz?",
												  "Kişiyi Silme Onayı",
												  MessageBoxButtons.YesNo,
												  MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				string query = "DELETE FROM kisiler WHERE kisiid = @kisiid";

				try
				{
					using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
					{
						conn.Open();
						using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
						{
							cmd.Parameters.AddWithValue("@kisiid", kisiid);

							cmd.ExecuteNonQuery();
							MessageBox.Show("Kişi başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
							KisileriListele(); // ComboBox'ı güncelle
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

					cbsilinecekkisiid.DataSource = dt;
					cbsilinecekkisiid.DisplayMember = "kisitamadi"; // Görünen kişi adı ve soyadı
					cbsilinecekkisiid.ValueMember = "kisiid";      // Arka planda kişi ID'si
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kişiler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void kisilerComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbsilinecekkisiid.SelectedValue != null)
			{
				int kisiid = Convert.ToInt32(cbsilinecekkisiid.SelectedValue);

				using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
				{
					try
					{
						conn.Open();
						string query = "SELECT kisiadi, kisisoyadi, telefonno, kisituru FROM kisiler WHERE kisiid = @kisiid";
						NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
						cmd.Parameters.AddWithValue("@kisiid", kisiid);


					}
					catch (Exception ex)
					{
						MessageBox.Show($"Kişi bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnkisileredön_Click(object sender, EventArgs e)
		{
			KisileriGörüntüle k = new KisileriGörüntüle();
			k.Show();
			this.Hide();
		}
	}
}
