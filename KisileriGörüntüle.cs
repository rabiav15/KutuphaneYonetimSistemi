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
	public partial class KisileriGörüntüle : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public KisileriGörüntüle()
		{
			InitializeComponent();
			KisileriListele();
		}
		private void KisileriListele()
		{
			using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT  DISTINCT kisiid, kisituru, kisiadi, kisisoyadi, telefonno FROM kisiler";
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
		
		

		private void btnkisiekle_Click(object sender, EventArgs e)
		{
			KisiEkle kisi = new KisiEkle();	
			kisi.Show();
			this.Hide();
		}

		private void btnkisidüzenle_Click(object sender, EventArgs e)
		{
			KisiDuzenle kisi = new KisiDuzenle();
			kisi.Show();
			this.Hide();
		}

		private void btnkisisil_Click(object sender, EventArgs e)
		{
			KisiSil kisi = new KisiSil();
			kisi.Show();
			this.Hide();
		}

		private void btnanasayfayadön_Click(object sender, EventArgs e)
		{
			AnaSayfa a = new AnaSayfa();
			a.Show();
			this.Hide();
		}
	}
}
