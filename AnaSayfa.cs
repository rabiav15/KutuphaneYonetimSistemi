using KutuphaneYonetimSistemi;
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
	public partial class AnaSayfa : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public AnaSayfa()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.ShowDialog();
			this.Hide();


		}

		private void btnyazaragit_Click(object sender, EventArgs e)
		{
			YazarListele yazarlistele = new YazarListele();
			yazarlistele.Show();
			this.Hide();
		}

		private void btnkisileregit_Click(object sender, EventArgs e)
		{
			KisileriGörüntüle kisilerigörüntüle = new KisileriGörüntüle();
			kisilerigörüntüle.Show();
			this.Hide();
		}

		private void AnaSayfa_Load(object sender, EventArgs e)
		{

		}

		private void cıkısyapbuton_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Close();
		}

		private void btnkiralamaislemi_Click(object sender, EventArgs e)
		{
			KiralamGörüntüle k = new KiralamGörüntüle();
			k.Show();
			this.Hide();
		}

		private void btnkitapara_Click(object sender, EventArgs e)
		{
			string aramaHarfi = kitaparatextbox.Text.Trim().ToLower(); // Kullanıcının girdiği harfi al

			if (string.IsNullOrEmpty(aramaHarfi))
			{
				MessageBox.Show("Lütfen bir harf girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// SQL sorgusu ile kitapları arama
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = @"
                SELECT kitaplar.kitapid, kitaplar.kitapadi
                FROM kitaplar
                WHERE LOWER(kitaplar.kitapadi) LIKE @aramaHarfi
                ORDER BY kitaplar.kitapadi";

					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@aramaHarfi", aramaHarfi + "%"); // % işareti ile harfe göre eşleme

						NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);

						if (dt.Rows.Count > 0)
						{
							datagridKitaplar.DataSource = dt; // DataGridView'i güncelle
						}
						else
						{
							MessageBox.Show("Aradığınız harfe uygun kitap bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
							datagridKitaplar.DataSource = null;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kitap arama sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void datagridKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = datagridKitaplar.Rows[e.RowIndex];
				int kitapid = Convert.ToInt32(row.Cells["kitapid"].Value); // Kitap ID'sini al

				// KitapDetay formunu oluştur ve tıklanan kitabın detaylarını göster
				KitapDetay kitapDetayForm = new KitapDetay();
				kitapDetayForm.KitapDetayGoster(kitapid); // Kitap id'sini formun ilgili metoduna aktar
				kitapDetayForm.Show();
			}





		}
	}
}
