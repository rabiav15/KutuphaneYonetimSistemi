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
	public partial class KiralamGörüntüle : Form
	{
		private string connectionString = "Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=15091112;";
		public KiralamGörüntüle()
		{
			InitializeComponent();
			KiralamalariGoruntule();
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

		private void btnanasayfadön_Click(object sender, EventArgs e)
		{
			AnaSayfa anasayfa = new AnaSayfa();
			anasayfa.Show();
			this.Hide();
		}

		private void btnkiralamayagit_Click(object sender, EventArgs e)
		{
			KiralamaIslemleri k = new KiralamaIslemleri();
			k.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			IadeIslemi i = new IadeIslemi();
			i.Show();
			this.Hide();
		}

		private void btncezagoruntule_Click(object sender, EventArgs e)
		{
			CezaGoruntule c = new CezaGoruntule();
			c.Show();
			this.Hide();
		}
	}
}
