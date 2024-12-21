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
	public partial class KitapSil : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";

		public KitapSil()
		{
			InitializeComponent();
			KitaplariYukle();
		}

		private void silbutton_Click(object sender, EventArgs e)
		{
			if (güncellecekkitap.SelectedValue == null)
			{
				MessageBox.Show("Lütfen silinecek kitabı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int kitapid = Convert.ToInt32(güncellecekkitap.SelectedValue); // Seçilen kitabın ID'si

			DialogResult result = MessageBox.Show("Seçili kitabı silmek istediğinizden emin misiniz?",
												  "Kitap Silme Onayı",
												  MessageBoxButtons.YesNo,
												  MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				string query = "DELETE FROM kitaplar WHERE kitapid = @kitapid";

				try
				{
					using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
					{
						conn.Open();
						using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
						{
							cmd.Parameters.AddWithValue("@kitapid", kitapid);

							int affectedRows = cmd.ExecuteNonQuery();
							if (affectedRows > 0)
							{
								MessageBox.Show("Kitap başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
								KitaplariYukle(); // ComboBox'taki kitapları yeniden yükle
							}
							else
							{
								MessageBox.Show("Kitap silinemedi. Lütfen tekrar deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
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

		private void btnlisteledön_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.Show();
			this.Hide();
		}
	}
}

