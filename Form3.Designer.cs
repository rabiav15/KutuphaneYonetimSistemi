namespace KutuphaneYonetimSistemi
{
	partial class Form3
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
			dataGridViewkitapekle = new DataGridView();
			kitapid = new DataGridViewTextBoxColumn();
			isbn = new DataGridViewTextBoxColumn();
			kitapadi = new DataGridViewTextBoxColumn();
			yazarid = new DataGridViewTextBoxColumn();
			rafid = new DataGridViewTextBoxColumn();
			kategoriid = new DataGridViewTextBoxColumn();
			stokadedi = new DataGridViewTextBoxColumn();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			isbntextbox = new MaskedTextBox();
			kitapaditextbox = new TextBox();
			stokadeditextbox = new MaskedTextBox();
			btnKitapEkle = new Button();
			btnlistelegeridön = new Button();
			cbyazarid = new ComboBox();
			cbrafid = new ComboBox();
			cbkategoriid = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dataGridViewkitapekle).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewkitapekle
			// 
			dataGridViewkitapekle.BackgroundColor = Color.Bisque;
			dataGridViewkitapekle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewkitapekle.Columns.AddRange(new DataGridViewColumn[] { kitapid, isbn, kitapadi, yazarid, rafid, kategoriid, stokadedi });
			dataGridViewkitapekle.Location = new Point(12, 25);
			dataGridViewkitapekle.Name = "dataGridViewkitapekle";
			dataGridViewkitapekle.RowHeadersWidth = 62;
			dataGridViewkitapekle.Size = new Size(1098, 295);
			dataGridViewkitapekle.TabIndex = 0;
			// 
			// kitapid
			// 
			kitapid.HeaderText = "Kitap Id";
			kitapid.MinimumWidth = 8;
			kitapid.Name = "kitapid";
			kitapid.Width = 150;
			// 
			// isbn
			// 
			isbn.HeaderText = "ISBN Kodu";
			isbn.MinimumWidth = 8;
			isbn.Name = "isbn";
			isbn.Width = 150;
			// 
			// kitapadi
			// 
			kitapadi.HeaderText = "Kitap Adı";
			kitapadi.MinimumWidth = 8;
			kitapadi.Name = "kitapadi";
			kitapadi.Width = 150;
			// 
			// yazarid
			// 
			yazarid.HeaderText = "Yazar Id ";
			yazarid.MinimumWidth = 8;
			yazarid.Name = "yazarid";
			yazarid.Width = 150;
			// 
			// rafid
			// 
			rafid.HeaderText = "Raf Id";
			rafid.MinimumWidth = 8;
			rafid.Name = "rafid";
			rafid.Width = 150;
			// 
			// kategoriid
			// 
			kategoriid.HeaderText = "Kategori Id";
			kategoriid.MinimumWidth = 8;
			kategoriid.Name = "kategoriid";
			kategoriid.Width = 150;
			// 
			// stokadedi
			// 
			stokadedi.HeaderText = "Stok Adedi";
			stokadedi.MinimumWidth = 8;
			stokadedi.Name = "stokadedi";
			stokadedi.Width = 150;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.Location = new Point(24, 351);
			label2.Name = "label2";
			label2.Size = new Size(141, 25);
			label2.TabIndex = 3;
			label2.Text = "ISBN Kodu:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label3.Location = new Point(23, 453);
			label3.Name = "label3";
			label3.Size = new Size(122, 25);
			label3.TabIndex = 4;
			label3.Text = "Kitap Adı:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label4.Location = new Point(23, 558);
			label4.Name = "label4";
			label4.Size = new Size(90, 25);
			label4.TabIndex = 5;
			label4.Text = "Yazar :";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label5.Location = new Point(461, 351);
			label5.Name = "label5";
			label5.Size = new Size(64, 25);
			label5.TabIndex = 6;
			label5.Text = "Raf :";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label6.Location = new Point(461, 558);
			label6.Name = "label6";
			label6.Size = new Size(141, 25);
			label6.TabIndex = 7;
			label6.Text = "Stok Adedi:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label7.Location = new Point(461, 453);
			label7.Name = "label7";
			label7.Size = new Size(122, 25);
			label7.TabIndex = 8;
			label7.Text = "Kategori :";
			// 
			// isbntextbox
			// 
			isbntextbox.Location = new Point(23, 399);
			isbntextbox.Mask = "00000000000000000000";
			isbntextbox.Name = "isbntextbox";
			isbntextbox.Size = new Size(228, 31);
			isbntextbox.TabIndex = 9;
			isbntextbox.ValidatingType = typeof(int);
			// 
			// kitapaditextbox
			// 
			kitapaditextbox.Location = new Point(23, 490);
			kitapaditextbox.Name = "kitapaditextbox";
			kitapaditextbox.Size = new Size(228, 31);
			kitapaditextbox.TabIndex = 10;
			// 
			// stokadeditextbox
			// 
			stokadeditextbox.Location = new Point(461, 597);
			stokadeditextbox.Mask = "00000";
			stokadeditextbox.Name = "stokadeditextbox";
			stokadeditextbox.Size = new Size(224, 31);
			stokadeditextbox.TabIndex = 14;
			stokadeditextbox.ValidatingType = typeof(int);
			// 
			// btnKitapEkle
			// 
			btnKitapEkle.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnKitapEkle.Location = new Point(875, 399);
			btnKitapEkle.Name = "btnKitapEkle";
			btnKitapEkle.Size = new Size(167, 70);
			btnKitapEkle.TabIndex = 15;
			btnKitapEkle.Text = "Veriyi Ekle";
			btnKitapEkle.UseVisualStyleBackColor = true;
			btnKitapEkle.Click += btnKitapEkle_Click;
			// 
			// btnlistelegeridön
			// 
			btnlistelegeridön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnlistelegeridön.Location = new Point(837, 507);
			btnlistelegeridön.Name = "btnlistelegeridön";
			btnlistelegeridön.Size = new Size(236, 34);
			btnlistelegeridön.TabIndex = 16;
			btnlistelegeridön.Text = "Listeleye Geri Dön";
			btnlistelegeridön.UseVisualStyleBackColor = true;
			btnlistelegeridön.Click += btnlistelegeridön_Click;
			// 
			// cbyazarid
			// 
			cbyazarid.FormattingEnabled = true;
			cbyazarid.Location = new Point(24, 597);
			cbyazarid.Name = "cbyazarid";
			cbyazarid.Size = new Size(227, 33);
			cbyazarid.TabIndex = 17;
			// 
			// cbrafid
			// 
			cbrafid.FormattingEnabled = true;
			cbrafid.Location = new Point(461, 399);
			cbrafid.Name = "cbrafid";
			cbrafid.Size = new Size(227, 33);
			cbrafid.TabIndex = 18;
			// 
			// cbkategoriid
			// 
			cbkategoriid.FormattingEnabled = true;
			cbkategoriid.Location = new Point(461, 490);
			cbkategoriid.Name = "cbkategoriid";
			cbkategoriid.Size = new Size(227, 33);
			cbkategoriid.TabIndex = 19;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(1124, 655);
			Controls.Add(cbkategoriid);
			Controls.Add(cbrafid);
			Controls.Add(cbyazarid);
			Controls.Add(btnlistelegeridön);
			Controls.Add(btnKitapEkle);
			Controls.Add(stokadeditextbox);
			Controls.Add(kitapaditextbox);
			Controls.Add(isbntextbox);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(dataGridViewkitapekle);
			Name = "Form3";
			Text = "Kitap Ekle";
			((System.ComponentModel.ISupportInitialize)dataGridViewkitapekle).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridViewkitapekle;
		private DataGridViewTextBoxColumn kitapid;
		private DataGridViewTextBoxColumn isbn;
		private DataGridViewTextBoxColumn kitapadi;
		private DataGridViewTextBoxColumn yazarid;
		private DataGridViewTextBoxColumn rafid;
		private DataGridViewTextBoxColumn kategoriid;
		private DataGridViewTextBoxColumn stokadedi;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private MaskedTextBox isbntextbox;
		private TextBox kitapaditextbox;
		private MaskedTextBox stokadeditextbox;
		private Button btnKitapEkle;
		private Button btnlistelegeridön;
		private ComboBox cbyazarid;
		private ComboBox cbrafid;
		private ComboBox cbkategoriid;
	}
}