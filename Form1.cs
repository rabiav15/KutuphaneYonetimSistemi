using Npgsql; // PostgreSQL i�in gerekli
using System.Data; // DataTable i�in gerekli

namespace KutuphaneYonetimSistemi
{
	public partial class Form1 : Form
	{
		


		public Form1()
		{
			InitializeComponent();

		}

		private void girisyapbutton_Click(object sender, EventArgs e)
		{

			AnaSayfa anasayfa = new AnaSayfa();
			string istenilenMail = "b";
			string mail = mailtextbox.Text;


			if (mail == istenilenMail)
			{
				sonuclabel.Text = "Ho�geldiniz!!!";
				anasayfa.Show();
				this.Hide();
			}
			else
			{
				sonuclabel.Text = "Giri� Ba�ar�s�z";

			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}