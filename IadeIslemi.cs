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
	public partial class IadeIslemi : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";

		public IadeIslemi()
		{
			InitializeComponent();
			KiralamalariGoruntule();
			cbKiralananIslemlerYukle();
		}

		private void btniadekaydet_Click(object sender, EventArgs e)
		{
			if (cbKiralananIslemler.SelectedValue == null)
			{
				MessageBox.Show("Lütfen kiralama işlemi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int kiralamaid = Convert.ToInt32(cbKiralananIslemler.SelectedValue);
			DateTime iadeTarihi = dtpiadetarihi.Value;

			string updateQuery = @"
                UPDATE kitapkiralamaislemi
                SET iadetarihi = @iadetarihi, durum = 'true'
                WHERE kiralamaid = @kiralamaid";

			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();

					using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, conn))
					{
						cmd.Parameters.AddWithValue("@iadetarihi", iadeTarihi);
						cmd.Parameters.AddWithValue("@kiralamaid", kiralamaid);
						cmd.ExecuteNonQuery();
					}

					MessageBox.Show("İade tarihi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

					// DataGridView'i güncelle
					KiralamalariGoruntule();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"İade tarihi güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void KiralamalariGoruntule()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = @"
                        SELECT DISTINCT
                            kiralama.kiralamaid,
                            kitaplar.kitapadi AS ""Kitap Adı"",
                            kisiler.kisiadi || ' ' || kisiler.kisisoyadi AS ""Üye Tam Adı"",
                            p.kisiadi || ' ' || p.kisisoyadi AS ""Personel Tam Adı"",
                            kiralama.kiralamatarihi AS ""Kiralama Tarihi"",
                            kiralama.iadetarihi AS ""İade Tarihi""
                           
                        FROM 
                            kitapkiralamaislemi kiralama
                        INNER JOIN kitaplar ON kiralama.kitapid = kitaplar.kitapid
                        INNER JOIN uyeler ON kiralama.uyeid = uyeler.uyeid
                        INNER JOIN kisiler ON uyeler.kisiid = kisiler.kisiid
                        LEFT JOIN personeller ON kiralama.personelid = personeller.personelid
                        LEFT JOIN kisiler p ON personeller.kisiid = p.kisiid
                        ORDER BY kiralamaid";

					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					if (dt.Rows.Count > 0)
					{
						datagridkiralama.DataSource = dt;
					}
					else
					{
						MessageBox.Show("Hiç kiralama işlemi bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						datagridkiralama.DataSource = null;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kiralamalar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void cbKiralananIslemlerYukle()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();

					// Sorgu: Kiralama işlemleri için gerekli bilgileri getir
					string query = @"
                        SELECT kitapkiralamaislemi.kiralamaid, 
                               CONCAT(uyeler.kisiadi, ' ', uyeler.kisisoyadi, ' - ', kitaplar.kitapadi) AS kiralamaBilgisi
                        FROM kitapkiralamaislemi
                        INNER JOIN uyeler ON uyeler.uyeid = kitapkiralamaislemi.uyeid
                        INNER JOIN kitaplar ON kitaplar.kitapid = kitapkiralamaislemi.kitapid";

					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					// Eğer sonuç döndürülmüyorsa bilgi mesajı göster
					if (dt.Rows.Count == 0)
					{
						MessageBox.Show("Kiralanan işlemler için veri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}

					// ComboBox ayarlarını yap
					cbKiralananIslemler.DisplayMember = "kiralamaBilgisi"; // Görünen veri
					cbKiralananIslemler.ValueMember = "kiralamaid";       // Değer olarak kullanılacak veri
					cbKiralananIslemler.DataSource = dt;                  // Veriyi bağla
				}
				catch (Exception ex)
				{
					// Hata durumunda kullanıcıyı bilgilendir
					MessageBox.Show($"Kiralanan işlemler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnanasayfadön_Click(object sender, EventArgs e)
		{
			KiralamGörüntüle k = new KiralamGörüntüle();
			k.Show();
			this.Hide();
		}

	}
}