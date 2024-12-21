namespace KutuphaneYonetimSistemi
{
	partial class KitapGüncelle
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
			cbkategoriid = new ComboBox();
			cbrafid = new ComboBox();
			cbyazarid = new ComboBox();
			stokadeditextbox = new MaskedTextBox();
			kitapaditextbox = new TextBox();
			isbntextbox = new MaskedTextBox();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label8 = new Label();
			label1 = new Label();
			güncellecekkitap = new ComboBox();
			güncellebutton = new Button();
			btnlistelegeridön = new Button();
			dataGridViewkitapekle = new DataGridView();
			kitapid = new DataGridViewTextBoxColumn();
			isbn = new DataGridViewTextBoxColumn();
			kitapadi = new DataGridViewTextBoxColumn();
			yazarid = new DataGridViewTextBoxColumn();
			rafid = new DataGridViewTextBoxColumn();
			kategoriid = new DataGridViewTextBoxColumn();
			stokadedi = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dataGridViewkitapekle).BeginInit();
			SuspendLayout();
			// 
			// cbkategoriid
			// 
			cbkategoriid.FormattingEnabled = true;
			cbkategoriid.Location = new Point(394, 532);
			cbkategoriid.Name = "cbkategoriid";
			cbkategoriid.Size = new Size(227, 33);
			cbkategoriid.TabIndex = 31;
			// 
			// cbrafid
			// 
			cbrafid.FormattingEnabled = true;
			cbrafid.Location = new Point(394, 443);
			cbrafid.Name = "cbrafid";
			cbrafid.Size = new Size(227, 33);
			cbrafid.TabIndex = 30;
			// 
			// cbyazarid
			// 
			cbyazarid.FormattingEnabled = true;
			cbyazarid.Location = new Point(26, 639);
			cbyazarid.Name = "cbyazarid";
			cbyazarid.Size = new Size(227, 33);
			cbyazarid.TabIndex = 29;
			// 
			// stokadeditextbox
			// 
			stokadeditextbox.Location = new Point(394, 641);
			stokadeditextbox.Mask = "00000";
			stokadeditextbox.Name = "stokadeditextbox";
			stokadeditextbox.Size = new Size(224, 31);
			stokadeditextbox.TabIndex = 28;
			stokadeditextbox.ValidatingType = typeof(int);
			// 
			// kitapaditextbox
			// 
			kitapaditextbox.Location = new Point(25, 534);
			kitapaditextbox.Name = "kitapaditextbox";
			kitapaditextbox.Size = new Size(228, 31);
			kitapaditextbox.TabIndex = 27;
			// 
			// isbntextbox
			// 
			isbntextbox.Location = new Point(25, 443);
			isbntextbox.Mask = "00000000000000000000";
			isbntextbox.Name = "isbntextbox";
			isbntextbox.Size = new Size(228, 31);
			isbntextbox.TabIndex = 26;
			isbntextbox.ValidatingType = typeof(int);
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label7.Location = new Point(394, 495);
			label7.Name = "label7";
			label7.Size = new Size(122, 25);
			label7.TabIndex = 25;
			label7.Text = "Kategori :";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label6.Location = new Point(394, 611);
			label6.Name = "label6";
			label6.Size = new Size(141, 25);
			label6.TabIndex = 24;
			label6.Text = "Stok Adedi:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label5.Location = new Point(394, 393);
			label5.Name = "label5";
			label5.Size = new Size(64, 25);
			label5.TabIndex = 23;
			label5.Text = "Raf :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label4.Location = new Point(26, 600);
			label4.Name = "label4";
			label4.Size = new Size(90, 25);
			label4.TabIndex = 22;
			label4.Text = "Yazar :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label3.Location = new Point(25, 495);
			label3.Name = "label3";
			label3.Size = new Size(122, 25);
			label3.TabIndex = 21;
			label3.Text = "Kitap Adı:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label8.Location = new Point(25, 393);
			label8.Name = "label8";
			label8.Size = new Size(141, 25);
			label8.TabIndex = 20;
			label8.Text = "ISBN Kodu:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.Location = new Point(25, 299);
			label1.Name = "label1";
			label1.Size = new Size(246, 25);
			label1.TabIndex = 32;
			label1.Text = "Güncellenecek Kitap:";
			// 
			// güncellecekkitap
			// 
			güncellecekkitap.FormattingEnabled = true;
			güncellecekkitap.Location = new Point(25, 338);
			güncellecekkitap.Name = "güncellecekkitap";
			güncellecekkitap.Size = new Size(227, 33);
			güncellecekkitap.TabIndex = 33;
			// 
			// güncellebutton
			// 
			güncellebutton.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			güncellebutton.Location = new Point(738, 580);
			güncellebutton.Name = "güncellebutton";
			güncellebutton.Size = new Size(235, 64);
			güncellebutton.TabIndex = 35;
			güncellebutton.Text = "Kitap Güncelle";
			güncellebutton.UseVisualStyleBackColor = true;
			güncellebutton.Click += güncellebutton_Click;
			// 
			// btnlistelegeridön
			// 
			btnlistelegeridön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnlistelegeridön.Location = new Point(738, 477);
			btnlistelegeridön.Name = "btnlistelegeridön";
			btnlistelegeridön.Size = new Size(236, 61);
			btnlistelegeridön.TabIndex = 36;
			btnlistelegeridön.Text = "Listeleye Geri Dön";
			btnlistelegeridön.UseVisualStyleBackColor = true;
			btnlistelegeridön.Click += btnlistelegeridön_Click;
			// 
			// dataGridViewkitapekle
			// 
			dataGridViewkitapekle.BackgroundColor = Color.Bisque;
			dataGridViewkitapekle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewkitapekle.Columns.AddRange(new DataGridViewColumn[] { kitapid, isbn, kitapadi, yazarid, rafid, kategoriid, stokadedi });
			dataGridViewkitapekle.Location = new Point(39, 12);
			dataGridViewkitapekle.Name = "dataGridViewkitapekle";
			dataGridViewkitapekle.RowHeadersWidth = 62;
			dataGridViewkitapekle.Size = new Size(868, 277);
			dataGridViewkitapekle.TabIndex = 37;
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
			// KitapGüncelle
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(1027, 690);
			Controls.Add(dataGridViewkitapekle);
			Controls.Add(btnlistelegeridön);
			Controls.Add(güncellebutton);
			Controls.Add(güncellecekkitap);
			Controls.Add(label1);
			Controls.Add(cbkategoriid);
			Controls.Add(cbrafid);
			Controls.Add(cbyazarid);
			Controls.Add(stokadeditextbox);
			Controls.Add(kitapaditextbox);
			Controls.Add(isbntextbox);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label8);
			Name = "KitapGüncelle";
			Text = "Kitap Güncelle";
			((System.ComponentModel.ISupportInitialize)dataGridViewkitapekle).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbkategoriid;
		private ComboBox cbrafid;
		private ComboBox cbyazarid;
		private MaskedTextBox stokadeditextbox;
		private TextBox kitapaditextbox;
		private MaskedTextBox isbntextbox;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label8;
		private Label label1;
		private ComboBox güncellecekkitap;
		private Button güncellebutton;
		private Button btnlistelegeridön;
		private DataGridView dataGridViewkitapekle;
		private DataGridViewTextBoxColumn kitapid;
		private DataGridViewTextBoxColumn isbn;
		private DataGridViewTextBoxColumn kitapadi;
		private DataGridViewTextBoxColumn yazarid;
		private DataGridViewTextBoxColumn rafid;
		private DataGridViewTextBoxColumn kategoriid;
		private DataGridViewTextBoxColumn stokadedi;
	}
}