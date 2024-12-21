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
	public partial class Form2 : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public Form2()
		{
			InitializeComponent();
		}

		private void buttonKitapListele_Click(object sender, EventArgs e)
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT * FROM kitaplar"; // Kitap tablosundaki tüm veriler
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridViewKitaplar.DataSource = dt; // Veriyi DataGridView'e yükle
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			KitaplariListele();

		}
		private void kitapeklebutton_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			form3.Show();
			this.Hide();

		}
		private void kitapgüncellebutton_Click(object sender, EventArgs e)
		{
			KitapGüncelle kitapgüncelle = new KitapGüncelle();
			kitapgüncelle.Show();
			this.Hide();

		}



		private void kitapsilbutton_Click(object sender, EventArgs e)
		{
			KitapSil kitapSil = new KitapSil();
			kitapSil.Show();
			this.Hide();
		}

		private void KitaplariListele()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT * FROM kitaplar"; // Kitap tablosundaki tüm veriler
					NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					da.Fill(dt);
					dataGridViewKitaplar.DataSource = dt; // Veriyi DataGridView'e yükle
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AnaSayfa anasayfa = new AnaSayfa();
			anasayfa.Show();
			this.Hide();
		}
	}
}