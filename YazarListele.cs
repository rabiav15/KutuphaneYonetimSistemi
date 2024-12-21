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
	public partial class YazarListele : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public YazarListele()
		{
			InitializeComponent();
			YazarlariListele();

		}

		private void btnyazarlistele_Click(object sender, EventArgs e)
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT yazarid, yazaradi, yazarsoyadi ,sirketid , biyografi  FROM yazarlar"; // Yazar bilgilerini çek
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);

					dataGridyazarlistele.DataSource = dt; // DataGridView'e verileri yükle
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Yazarlar listelenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnyazarekle_Click(object sender, EventArgs e)
		{
			YazarEkle yazarekle = new YazarEkle();
			yazarekle.Show();
			this.Hide();

		}

		private void btnyazargüncelle_Click(object sender, EventArgs e)
		{
			YazarGüncelle yazargüncelle = new YazarGüncelle();
			yazargüncelle.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AnaSayfa anasayfa = new AnaSayfa();
			anasayfa.Show();
			this.Hide();
		}

		private void btnyazarsil_Click(object sender, EventArgs e)
		{
			YazarSil yazarsil = new YazarSil();
			yazarsil.Show();
			this.Hide();
		}

		private void YazarlariListele()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT * FROM yazarlar"; // Kitap tablosundaki tüm veriler
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridyazarlistele.DataSource = dt; // Veriyi DataGridView'e yükle
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
