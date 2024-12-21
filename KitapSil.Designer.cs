namespace KutuphaneYonetimSistemi
{
	partial class KitapSil
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
			güncellecekkitap = new ComboBox();
			label1 = new Label();
			btnlisteledön = new Button();
			silbutton = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewkitapekle).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewkitapekle
			// 
			dataGridViewkitapekle.BackgroundColor = Color.Bisque;
			dataGridViewkitapekle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewkitapekle.Columns.AddRange(new DataGridViewColumn[] { kitapid, isbn, kitapadi, yazarid, rafid, kategoriid, stokadedi });
			dataGridViewkitapekle.Location = new Point(68, 24);
			dataGridViewkitapekle.Name = "dataGridViewkitapekle";
			dataGridViewkitapekle.RowHeadersWidth = 62;
			dataGridViewkitapekle.Size = new Size(868, 277);
			dataGridViewkitapekle.TabIndex = 40;
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
			// güncellecekkitap
			// 
			güncellecekkitap.FormattingEnabled = true;
			güncellecekkitap.Location = new Point(58, 389);
			güncellecekkitap.Name = "güncellecekkitap";
			güncellecekkitap.Size = new Size(227, 33);
			güncellecekkitap.TabIndex = 39;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.Location = new Point(58, 344);
			label1.Name = "label1";
			label1.Size = new Size(185, 25);
			label1.TabIndex = 38;
			label1.Text = "Silinecek Kitap:";
			// 
			// btnlisteledön
			// 
			btnlisteledön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnlisteledön.Location = new Point(672, 361);
			btnlisteledön.Name = "btnlisteledön";
			btnlisteledön.Size = new Size(236, 61);
			btnlisteledön.TabIndex = 42;
			btnlisteledön.Text = "Listeleye Geri Dön";
			btnlisteledön.UseVisualStyleBackColor = true;
			btnlisteledön.Click += btnlisteledön_Click;
			// 
			// silbutton
			// 
			silbutton.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			silbutton.Location = new Point(672, 464);
			silbutton.Name = "silbutton";
			silbutton.Size = new Size(235, 64);
			silbutton.TabIndex = 41;
			silbutton.Text = "Kitap Sil";
			silbutton.UseVisualStyleBackColor = true;
			silbutton.Click += silbutton_Click;
			// 
			// KitapSil
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(1008, 564);
			Controls.Add(btnlisteledön);
			Controls.Add(silbutton);
			Controls.Add(dataGridViewkitapekle);
			Controls.Add(güncellecekkitap);
			Controls.Add(label1);
			Name = "KitapSil";
			Text = "Kitap Sil";
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
		private ComboBox güncellecekkitap;
		private Label label1;
		private Button btnlisteledön;
		private Button silbutton;
	}
}