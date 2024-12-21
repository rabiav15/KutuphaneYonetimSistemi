namespace KutuphaneYonetimSistemi
{
	partial class YazarListele
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
			btnyazarekle = new Button();
			btnyazarsil = new Button();
			btnyazargüncelle = new Button();
			btnyazarlistele = new Button();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridyazarlistele).BeginInit();
			SuspendLayout();
			// 
			// dataGridyazarlistele
			// 
			dataGridyazarlistele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridyazarlistele.Location = new Point(52, 118);
			dataGridyazarlistele.Name = "dataGridyazarlistele";
			dataGridyazarlistele.RowHeadersWidth = 62;
			dataGridyazarlistele.Size = new Size(814, 290);
			dataGridyazarlistele.TabIndex = 0;
			// 
			// btnyazarekle
			// 
			btnyazarekle.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnyazarekle.Location = new Point(257, 432);
			btnyazarekle.Name = "btnyazarekle";
			btnyazarekle.Size = new Size(175, 34);
			btnyazarekle.TabIndex = 1;
			btnyazarekle.Text = "Yazar Ekle";
			btnyazarekle.UseVisualStyleBackColor = true;
			btnyazarekle.Click += btnyazarekle_Click;
			// 
			// btnyazarsil
			// 
			btnyazarsil.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnyazarsil.Location = new Point(749, 432);
			btnyazarsil.Name = "btnyazarsil";
			btnyazarsil.Size = new Size(175, 34);
			btnyazarsil.TabIndex = 2;
			btnyazarsil.Text = "Yazar Sil";
			btnyazarsil.UseVisualStyleBackColor = true;
			btnyazarsil.Click += btnyazarsil_Click;
			// 
			// btnyazargüncelle
			// 
			btnyazargüncelle.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnyazargüncelle.Location = new Point(483, 432);
			btnyazargüncelle.Name = "btnyazargüncelle";
			btnyazargüncelle.Size = new Size(216, 34);
			btnyazargüncelle.TabIndex = 3;
			btnyazargüncelle.Text = "Yazar Güncelle";
			btnyazargüncelle.UseVisualStyleBackColor = true;
			btnyazargüncelle.Click += btnyazargüncelle_Click;
			// 
			// btnyazarlistele
			// 
			btnyazarlistele.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnyazarlistele.Location = new Point(367, 33);
			btnyazarlistele.Name = "btnyazarlistele";
			btnyazarlistele.Size = new Size(216, 56);
			btnyazarlistele.TabIndex = 4;
			btnyazarlistele.Text = "Yazarları  Listele";
			btnyazarlistele.UseVisualStyleBackColor = true;
			btnyazarlistele.Click += btnyazarlistele_Click;
			// 
			// button1
			// 
			button1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			button1.Location = new Point(12, 493);
			button1.Name = "button1";
			button1.Size = new Size(214, 34);
			button1.TabIndex = 6;
			button1.Text = "Ana Sayfaya Dön";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// YazarListele
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(936, 539);
			Controls.Add(button1);
			Controls.Add(btnyazarlistele);
			Controls.Add(btnyazargüncelle);
			Controls.Add(btnyazarsil);
			Controls.Add(btnyazarekle);
			Controls.Add(dataGridyazarlistele);
			Name = "YazarListele";
			Text = "Yazar Listele";
			((System.ComponentModel.ISupportInitialize)dataGridyazarlistele).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridyazarlistele;
		private Button btnyazarekle;
		private Button btnyazarsil;
		private Button btnyazargüncelle;
		private Button btnyazarlistele;
		private Button button1;
	}
}