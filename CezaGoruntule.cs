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
	public partial class CezaGoruntule : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public CezaGoruntule()
		{

			InitializeComponent();
			CezalariGoruntule();
			cbKiralananIslemlerYukle();

		}



		private void CezaGoruntule_Load(object sender, EventArgs e)
		{

		}
		private void CezalariGoruntule()
		{


			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = @"
                SELECT DISTINCT cezalar.cezaid, 
                       kitaplar.kitapadi AS ""Kitap Adı"", 
                       kisiler.kisiadi || ' ' || kisiler.kisisoyadi AS ""Üye Adı"", 
                       cezalar.cezatutari AS ""Ceza Tutarı"",
                       cezalar.odemedurumu AS ""Ödeme Durumu""
                FROM cezalar
                INNER JOIN kitapkiralamaislemi kiralama ON cezalar.kiralamaid = kiralama.kiralamaid
                INNER JOIN kitaplar ON kiralama.kitapid = kitaplar.kitapid
                INNER JOIN uyeler ON kiralama.uyeid = uyeler.uyeid
                INNER JOIN kisiler ON uyeler.kisiid = kisiler.kisiid
                ORDER BY cezalar.cezaid";

					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					if (dt.Rows.Count > 0)
					{
						dataGridcezalar.DataSource = dt;
					}
					else
					{
						MessageBox.Show("Hiç ceza kaydı bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						dataGridcezalar.DataSource = null;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ceza verileri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}


		private void CezaHesaplaVeKaydet(int kiralamaid)
		{
			// Kiralama işlemi bilgilerini al
			string query = @"
        SELECT kiralama.kiralamatarihi, kiralama.iadetarihi
        FROM kitapkiralamaislemi kiralama
        WHERE kiralama.kiralamaid = @kiralamaid";

			// Yeni bağlantı açılacak
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();

					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@kiralamaid", kiralamaid);

						using (NpgsqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								DateTime kiralamaTarihi = reader.GetDateTime(0);
								DateTime? iadeTarihi = reader.IsDBNull(1) ? (DateTime?)null : reader.GetDateTime(1);

								if (iadeTarihi.HasValue)
								{
									// Ceza hesaplama
									TimeSpan fark = iadeTarihi.Value - kiralamaTarihi;
									int cezaGunu = (int)fark.TotalDays;

									if (cezaGunu > 0)
									{
										decimal cezaTutari = cezaGunu * 5; // Gün başına 5 TL ceza

										// Ceza kaydını cezalar tablosuna ekle
										string cezaQuery = @"
                                    INSERT INTO cezalar (kiralamaid, cezatutari, odemedurumu)
                                    VALUES (@kiralamaid, @cezatutari, @odemedurumu)";

										// Yeni bağlantı açarak ceza ekle
										using (NpgsqlConnection conn2 = new NpgsqlConnection(connectionString))
										{
											conn2.Open();
											using (NpgsqlCommand cezaCmd = new NpgsqlCommand(cezaQuery, conn2))
											{
												cezaCmd.Parameters.AddWithValue("@kiralamaid", kiralamaid);
												cezaCmd.Parameters.AddWithValue("@cezatutari", cezaTutari);
												cezaCmd.Parameters.AddWithValue("@odemedurumu", true); // Ödeme durumu "evet"
												cezaCmd.ExecuteNonQuery();
											}
										}

										MessageBox.Show("Ceza başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
									else
									{
										MessageBox.Show("İade tarihi kiralama tarihinden önceki bir tarihe ait.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
									}
								}
								else
								{
									MessageBox.Show("İade tarihi henüz belirlenmemiş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ceza hesaplama ve kaydetme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					string query = @"
                SELECT kitapkiralamaislemi.kiralamaid, 
                       CONCAT(uyeler.kisiadi, ' ', uyeler.kisisoyadi, ' - ', kitaplar.kitapadi) AS kiralamaBilgisi
                FROM kitapkiralamaislemi
                INNER JOIN uyeler ON uyeler.uyeid = kitapkiralamaislemi.uyeid
                INNER JOIN kitaplar ON kitaplar.kitapid = kitapkiralamaislemi.kitapid";

					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					// ComboBox ayarlarını yap
					cbKiralananIslemler.DisplayMember = "kiralamaBilgisi"; // Görünen veri
					cbKiralananIslemler.ValueMember = "kiralamaid";       // Değer olarak kullanılacak veri
					cbKiralananIslemler.DataSource = dt;                  // Veriyi bağla
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kiralanan işlemler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void btncezakaydet_Click(object sender, EventArgs e)
		{
			// Seçilen kiralama işlemi ID'sini al
			if (cbKiralananIslemler.SelectedValue == null)
			{
				MessageBox.Show("Lütfen bir kiralama işlemi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int kiralamaid = Convert.ToInt32(cbKiralananIslemler.SelectedValue);

			// Ceza hesapla ve kaydet
			CezaHesaplaVeKaydet(kiralamaid);
		}
		private void cbKiralananIslemler_SelectedValueChanged(object sender, EventArgs e)
		{
			// Seçilen kiralama işlemi ID'sini al
			if (cbKiralananIslemler.SelectedValue != null)
			{
				int kiralamaid = Convert.ToInt32(cbKiralananIslemler.SelectedValue);

				// Ceza hesapla ve kaydet
				CezaHesaplaVeKaydet(kiralamaid);
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
