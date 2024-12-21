namespace KutuphaneYonetimSistemi
{
	partial class YazarGüncelle
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
			dataGridyazarlistele = new DataGridView();
			biyografitextbox = new TextBox();
			yazarsoyaditextbox = new TextBox();
			biyografi = new Label();
			cbsirketid = new ComboBox();
			btnyazarlistelegeridön = new Button();
			btnyazargüncelle = new Button();
			yazaraditextbox = new TextBox();
			label6 = new Label();
			yazarsoyadi = new Label();
			yazaradi = new Label();
			cbyazarid = new ComboBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridyazarlistele).BeginInit();
			SuspendLayout();
			// 
			// dataGridyazarlistele
			// 
			dataGridyazarlistele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridyazarlistele.Location = new Point(129, 32);
			dataGridyazarlistele.Name = "dataGridyazarlistele";
			dataGridyazarlistele.RowHeadersWidth = 62;
			dataGridyazarlistele.Size = new Size(814, 290);
			dataGridyazarlistele.TabIndex = 47;
			// 
			// biyografitextbox
			// 
			biyografitextbox.Location = new Point(361, 492);
			biyografitextbox.Name = "biyografitextbox";
			biyografitextbox.Size = new Size(228, 31);
			biyografitextbox.TabIndex = 46;
			// 
			// yazarsoyaditextbox
			// 
			yazarsoyaditextbox.Location = new Point(33, 568);
			yazarsoyaditextbox.Name = "yazarsoyaditextbox";
			yazarsoyaditextbox.Size = new Size(228, 31);
			yazarsoyaditextbox.TabIndex = 45;
			// 
			// biyografi
			// 
			biyografi.AutoSize = true;
			biyografi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			biyografi.Location = new Point(361, 450);
			biyografi.Name = "biyografi";
			biyografi.Size = new Size(221, 25);
			biyografi.TabIndex = 44;
			biyografi.Text = "Biyogragi(Kısaca):";
			// 
			// cbsirketid
			// 
			cbsirketid.FormattingEnabled = true;
			cbsirketid.Location = new Point(362, 383);
			cbsirketid.Name = "cbsirketid";
			cbsirketid.Size = new Size(227, 33);
			cbsirketid.TabIndex = 43;
			// 
			// btnyazarlistelegeridön
			// 
			btnyazarlistelegeridön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnyazarlistelegeridön.Location = new Point(793, 498);
			btnyazarlistelegeridön.Name = "btnyazarlistelegeridön";
			btnyazarlistelegeridön.Size = new Size(236, 34);
			btnyazarlistelegeridön.TabIndex = 42;
			btnyazarlistelegeridön.Text = "Listeleye Geri Dön";
			btnyazarlistelegeridön.UseVisualStyleBackColor = true;
			btnyazarlistelegeridön.Click += btnyazarlistelegeridön_Click;
			// 
			// btnyazargüncelle
			// 
			btnyazargüncelle.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnyazargüncelle.Location = new Point(793, 390);
			btnyazargüncelle.Name = "btnyazargüncelle";
			btnyazargüncelle.Size = new Size(236, 70);
			btnyazargüncelle.TabIndex = 41;
			btnyazargüncelle.Text = "Yazarı Güncelle";
			btnyazargüncelle.UseVisualStyleBackColor = true;
			btnyazargüncelle.Click += btnyazargüncelle_Click;
			// 
			// yazaraditextbox
			// 
			yazaraditextbox.Location = new Point(33, 473);
			yazaraditextbox.Name = "yazaraditextbox";
			yazaraditextbox.Size = new Size(228, 31);
			yazaraditextbox.TabIndex = 40;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label6.Location = new Point(361, 345);
			label6.Name = "label6";
			label6.Size = new Size(130, 25);
			label6.TabIndex = 39;
			label6.Text = "Şirket Adı:";
			// 
			// yazarsoyadi
			// 
			yazarsoyadi.AutoSize = true;
			yazarsoyadi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			yazarsoyadi.Location = new Point(33, 526);
			yazarsoyadi.Name = "yazarsoyadi";
			yazarsoyadi.Size = new Size(165, 25);
			yazarsoyadi.TabIndex = 38;
			yazarsoyadi.Text = "Yazar Soyadı:";
			// 
			// yazaradi
			// 
			yazaradi.AutoSize = true;
			yazaradi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			yazaradi.Location = new Point(33, 435);
			yazaradi.Name = "yazaradi";
			yazaradi.Size = new Size(127, 25);
			yazaradi.TabIndex = 37;
			yazaradi.Text = "Yazar Adı:";
			// 
			// cbyazarid
			// 
			cbyazarid.FormattingEnabled = true;
			cbyazarid.Location = new Point(34, 383);
			cbyazarid.Name = "cbyazarid";
			cbyazarid.Size = new Size(227, 33);
			cbyazarid.TabIndex = 49;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.Location = new Point(33, 345);
			label1.Name = "label1";
			label1.Size = new Size(251, 25);
			label1.TabIndex = 48;
			label1.Text = "Güncellenecek Yazar:";
			// 
			// YazarGüncelle
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(1068, 648);
			Controls.Add(cbyazarid);
			Controls.Add(label1);
			Controls.Add(dataGridyazarlistele);
			Controls.Add(biyografitextbox);
			Controls.Add(yazarsoyaditextbox);
			Controls.Add(biyografi);
			Controls.Add(cbsirketid);
			Controls.Add(btnyazarlistelegeridön);
			Controls.Add(btnyazargüncelle);
			Controls.Add(yazaraditextbox);
			Controls.Add(label6);
			Controls.Add(yazarsoyadi);
			Controls.Add(yazaradi);
			Name = "YazarGüncelle";
			Text = "Yazar Güncelle";
			((System.ComponentModel.ISupportInitialize)dataGridyazarlistele).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridyazarlistele;
		private TextBox biyografitextbox;
		private TextBox yazarsoyaditextbox;
		private Label biyografi;
		private ComboBox cbsirketid;
		private Button btnyazarlistelegeridön;
		private Button btnyazargüncelle;
		private TextBox yazaraditextbox;
		private Label label6;
		private Label yazarsoyadi;
		private Label yazaradi;
		private ComboBox cbyazarid;
		private Label label1;
	}
}