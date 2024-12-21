namespace KutuphaneYonetimSistemi
{
	partial class YazarEkle
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			cbsirketid = new ComboBox();
			btnyazarlistelegeridön = new Button();
			btnYazarEkle = new Button();
			yazaraditextbox = new TextBox();
			label6 = new Label();
			yazarsoyadi = new Label();
			yazaradi = new Label();
			biyografi = new Label();
			yazarsoyaditextbox = new TextBox();
			biyografitextbox = new TextBox();
			dataGridyazarlistele = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridyazarlistele).BeginInit();
			SuspendLayout();
			// 
			// cbsirketid
			// 
			cbsirketid.FormattingEnabled = true;
			cbsirketid.Location = new Point(376, 411);
			cbsirketid.Name = "cbsirketid";
			cbsirketid.Size = new Size(227, 33);
			cbsirketid.TabIndex = 32;
			// 
			// btnyazarlistelegeridön
			// 
			btnyazarlistelegeridön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnyazarlistelegeridön.Location = new Point(802, 498);
			btnyazarlistelegeridön.Name = "btnyazarlistelegeridön";
			btnyazarlistelegeridön.Size = new Size(236, 34);
			btnyazarlistelegeridön.TabIndex = 30;
			btnyazarlistelegeridön.Text = "Listeleye Geri Dön";
			btnyazarlistelegeridön.UseVisualStyleBackColor = true;
			btnyazarlistelegeridön.Click += btnyazarlistelegeridön_Click;
			// 
			// btnYazarEkle
			// 
			btnYazarEkle.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnYazarEkle.Location = new Point(840, 390);
			btnYazarEkle.Name = "btnYazarEkle";
			btnYazarEkle.Size = new Size(167, 70);
			btnYazarEkle.TabIndex = 29;
			btnYazarEkle.Text = "Veriyi Ekle";
			btnYazarEkle.UseVisualStyleBackColor = true;
			btnYazarEkle.Click += btnYazarEkle_Click;
			// 
			// yazaraditextbox
			// 
			yazaraditextbox.Location = new Point(42, 411);
			yazaraditextbox.Name = "yazaraditextbox";
			yazaraditextbox.Size = new Size(228, 31);
			yazaraditextbox.TabIndex = 27;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label6.Location = new Point(375, 373);
			label6.Name = "label6";
			label6.Size = new Size(130, 25);
			label6.TabIndex = 24;
			label6.Text = "Şirket Adı:";
			// 
			// yazarsoyadi
			// 
			yazarsoyadi.AutoSize = true;
			yazarsoyadi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			yazarsoyadi.Location = new Point(42, 478);
			yazarsoyadi.Name = "yazarsoyadi";
			yazarsoyadi.Size = new Size(165, 25);
			yazarsoyadi.TabIndex = 22;
			yazarsoyadi.Text = "Yazar Soyadı:";
			// 
			// yazaradi
			// 
			yazaradi.AutoSize = true;
			yazaradi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			yazaradi.Location = new Point(42, 373);
			yazaradi.Name = "yazaradi";
			yazaradi.Size = new Size(127, 25);
			yazaradi.TabIndex = 21;
			yazaradi.Text = "Yazar Adı:";
			// 
			// biyografi
			// 
			biyografi.AutoSize = true;
			biyografi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			biyografi.Location = new Point(375, 478);
			biyografi.Name = "biyografi";
			biyografi.Size = new Size(221, 25);
			biyografi.TabIndex = 33;
			biyografi.Text = "Biyogragi(Kısaca):";
			// 
			// yazarsoyaditextbox
			// 
			yazarsoyaditextbox.Location = new Point(42, 520);
			yazarsoyaditextbox.Name = "yazarsoyaditextbox";
			yazarsoyaditextbox.Size = new Size(228, 31);
			yazarsoyaditextbox.TabIndex = 34;
			// 
			// biyografitextbox
			// 
			biyografitextbox.Location = new Point(375, 520);
			biyografitextbox.Name = "biyografitextbox";
			biyografitextbox.Size = new Size(228, 31);
			biyografitextbox.TabIndex = 35;
			// 
			// dataGridyazarlistele
			// 
			dataGridyazarlistele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridyazarlistele.Location = new Point(138, 32);
			dataGridyazarlistele.Name = "dataGridyazarlistele";
			dataGridyazarlistele.RowHeadersWidth = 62;
			dataGridyazarlistele.Size = new Size(814, 290);
			dataGridyazarlistele.TabIndex = 36;
			// 
			// YazarEkle
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(1109, 644);
			Controls.Add(dataGridyazarlistele);
			Controls.Add(biyografitextbox);
			Controls.Add(yazarsoyaditextbox);
			Controls.Add(biyografi);
			Controls.Add(cbsirketid);
			Controls.Add(btnyazarlistelegeridön);
			Controls.Add(btnYazarEkle);
			Controls.Add(yazaraditextbox);
			Controls.Add(label6);
			Controls.Add(yazarsoyadi);
			Controls.Add(yazaradi);
			Name = "YazarEkle";
			Text = "Yazar Ekle";
			((System.ComponentModel.ISupportInitialize)dataGridyazarlistele).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbsirketid;
		private Button btnyazarlistelegeridön;
		private Button btnYazarEkle;
		private TextBox yazaraditextbox;
		private Label label6;
		private Label yazarsoyadi;
		private Label yazaradi;
		private Label biyografi;
		private TextBox yazarsoyaditextbox;
		private TextBox biyografitextbox;
		private DataGridView dataGridyazarlistele;
	}
}