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
	public partial class KiralamaIslemleri : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public KiralamaIslemleri()
		{
			InitializeComponent();

		}


		private void KiralamaIslemleri_Load(object sender, EventArgs e)
		{
			KitaplariComboBoxaYukle();
			UyeleriComboBoxaYukle();
			PersonelleriComboBoxaYukle();

		}

		private void btnanasayfadön_Click(object sender, EventArgs e)
		{
			KiralamGörüntüle k = new KiralamGörüntüle();
			k.Show();
			this.Hide();

		}

		private void KitaplariComboBoxaYukle()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT kitapid, kitapadi FROM kitaplar WHERE stokadedi > 0"; // Stokta mevcut kitaplar
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					cmbkitap.DataSource = dt;
					cmbkitap.DisplayMember = "kitapadi"; // Görünen değer
					cmbkitap.ValueMember = "kitapid";   // Seçilen ID
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kitaplar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void UyeleriComboBoxaYukle()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT DISTINCT uyeler.uyeid, kisiler.kisiadi || ' ' || kisiler.kisisoyadi AS uyetamadi FROM uyeler INNER JOIN kisiler ON uyeler.kisiid = kisiler.kisiid";
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					cmbuye.DataSource = dt;
					cmbuye.DisplayMember = "uyetamadi";
					cmbuye.ValueMember = "uyeid";
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Üyeler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void PersonelleriComboBoxaYukle()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT DISTINCT personeller.personelid, kisiler.kisiadi || ' ' || kisiler.kisisoyadi AS personeltamadi FROM personeller INNER JOIN kisiler ON personeller.kisiid = kisiler.kisiid";
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					cmbpersonel.DataSource = dt;
					cmbpersonel.DisplayMember = "personeltamadi";
					cmbpersonel.ValueMember = "personelid";
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Personeller yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnkaydet_Click(object sender, EventArgs e)
		{
			// Butonu devre dışı bırak
			btnkaydet.Enabled = false;

			if (cmbkitap.SelectedValue == null || cmbuye.SelectedValue == null || cmbpersonel.SelectedValue == null)
			{
				MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				btnkaydet.Enabled = true;
				return;
			}

			int kitapID = Convert.ToInt32(cmbkitap.SelectedValue);
			int uyeID = Convert.ToInt32(cmbuye.SelectedValue);
			int personelID = Convert.ToInt32(cmbpersonel.SelectedValue);
			DateTime kiralamaTarihi = dtpkiralamatarihi.Value;
			DateTime iadetarihi = dtpiadetarihi.Value;


			string queryKiralama = "INSERT INTO kitapkiralamaislemi (kitapid, uyeid, personelid, kiralamatarihi, iadetarihi) " +
								   "VALUES (@kitapid, @uyeid, @personelid, @kiralamatarihi, @iadetarihi)";
			string queryStokAzalt = "UPDATE kitaplar SET stokadedi = stokadedi - 1 WHERE kitapid = @kitapid";

			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					using (NpgsqlTransaction transaction = conn.BeginTransaction())
					{
						// Kiralama İşlemini Kaydet
						using (NpgsqlCommand cmdKiralama = new NpgsqlCommand(queryKiralama, conn, transaction))
						{
							cmdKiralama.Parameters.AddWithValue("@kitapid", kitapID);
							cmdKiralama.Parameters.AddWithValue("@uyeid", uyeID);
							cmdKiralama.Parameters.AddWithValue("@personelid", personelID);
							cmdKiralama.Parameters.AddWithValue("@kiralamatarihi", kiralamaTarihi);
							cmdKiralama.Parameters.AddWithValue("@iadetarihi", iadetarihi);// İade tarihi burada bir gün sonrası olarak ayarlanır
							cmdKiralama.ExecuteNonQuery();
						}

						// Stoktan 1 Eksilt
						using (NpgsqlCommand cmdStokAzalt = new NpgsqlCommand(queryStokAzalt, conn, transaction))
						{
							cmdStokAzalt.Parameters.AddWithValue("@kitapid", kitapID);
							cmdStokAzalt.ExecuteNonQuery();
						}

						transaction.Commit();
						MessageBox.Show("Kiralama işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}

					// ComboBox'ları güncelle
					KitaplariComboBoxaYukle();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Kiralama işlemi sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					// Butonu tekrar etkinleştir
					btnkaydet.Enabled = true;
				}
			}
		}

		private void dtpiadetarihi_ValueChanged(object sender, EventArgs e)
		{

		}

	}
}
