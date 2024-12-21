using Npgsql; // PostgreSQL için gerekli
using System.Data; // DataTable için gerekli

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
				sonuclabel.Text = "Hoþgeldiniz!!!";
				anasayfa.Show();
				this.Hide();
			}
			else
			{
				sonuclabel.Text = "Giriþ Baþarýsýz";

			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}