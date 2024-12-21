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
	public partial class KitapDetay : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public KitapDetay()
		{
			InitializeComponent();

		}


		public void KitapDetayGoster(int kitapid)
		{

			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = @"
                SELECT kitaplar.kitapid,
                       kitaplar.isbn,
                       kitaplar.kitapadi,
                       yazarlar.yazaradi || ' ' || yazarlar.yazarsoyadi AS yazaradi, 
                       kitaplar.stokadedi
                FROM kitaplar
                INNER JOIN yazarlar yazarlar ON kitaplar.yazarid = yazarlar.yazarid
                INNER JOIN raflar raflar ON kitaplar.rafid = raflar.rafid
                INNER JOIN kategoriler kategoriler ON kitaplar.kategoriid = kategoriler.kategoriid
                WHERE kitaplar.kitapid = @kitapid";

					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@kitapid", kitapid);

						NpgsqlDataReader reader = cmd.ExecuteReader();

						if (reader.Read())
						{
							// Panel içindeki label'lara bilgileri aktarın
							labelKitapAdi.Text = reader.GetString(2);  // Kitap Adı

							// ISBN
							labelIsbn.Text = reader.GetString(1); // ISBN

							// Yazar Adı Soyadı
							labelYazarAdi.Text = reader.GetString(3);  // Yazar Adı ve Soyadı


							// Stok Adedi
							labelStokAdedi.Text = reader.IsDBNull(reader.GetOrdinal("stokadedi"))
				  ? "0"
				  : reader.GetInt32(reader.GetOrdinal("stokadedi")).ToString();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kitap detayları yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void labelStokAdedi_Click(object sender, EventArgs e)
		{

		}
	}
}

