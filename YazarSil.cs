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
	public partial class YazarSil : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public YazarSil()
		{
			InitializeComponent();
			YazarlariYukle();
		}

		private void btnyazarlistelegeridön_Click(object sender, EventArgs e)
		{
			YazarListele yazarlistele = new YazarListele();
			yazarlistele.Show();
			this.Hide();
		}

		private void btnyazarsil_Click(object sender, EventArgs e)
		{
			
		
			if (cbyazarid.SelectedValue == null)
			{
				MessageBox.Show("Lütfen silinecek yazarı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int yazarId = Convert.ToInt32(cbyazarid.SelectedValue);

			DialogResult result = MessageBox.Show("Seçili yazarı silmek istediğinizden emin misiniz?",
												  "Yazar Silme Onayı",
												  MessageBoxButtons.YesNo,
												  MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				string query = "DELETE FROM yazarlar WHERE yazarid = @yazarid";

				try
				{
					using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
					{
						conn.Open();
						using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
						{
							cmd.Parameters.AddWithValue("@yazarid", yazarId);

							cmd.ExecuteNonQuery();
							MessageBox.Show("Yazar başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
							YazarlariYukle(); // ComboBox'ı güncelle
						}
					}
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
	}
}
