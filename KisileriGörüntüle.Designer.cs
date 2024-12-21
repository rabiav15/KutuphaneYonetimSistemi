namespace KutuphaneYonetimSistemi
{
	partial class KisileriGörüntüle
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
			dataGridkisilerigörüntüle = new DataGridView();
			btnpersonelleregit = new Button();
			btnuyeleregit = new Button();
			btnkisiekle = new Button();
			btnkisisil = new Button();
			btnkisidüzenle = new Button();
			btnanasayfayadön = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridkisilerigörüntüle).BeginInit();
			SuspendLayout();
			// 
			// dataGridkisilerigörüntüle
			// 
			dataGridkisilerigörüntüle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridkisilerigörüntüle.Location = new Point(21, 26);
			dataGridkisilerigörüntüle.Name = "dataGridkisilerigörüntüle";
			dataGridkisilerigörüntüle.RowHeadersWidth = 62;
			dataGridkisilerigörüntüle.Size = new Size(778, 421);
			dataGridkisilerigörüntüle.TabIndex = 0;
			// 
			// btnkisiekle
			// 
			btnkisiekle.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnkisiekle.Location = new Point(21, 474);
			btnkisiekle.Name = "btnkisiekle";
			btnkisiekle.Size = new Size(216, 56);
			btnkisiekle.TabIndex = 7;
			btnkisiekle.Text = "Kişi Ekle";
			btnkisiekle.UseVisualStyleBackColor = true;
			btnkisiekle.Click += btnkisiekle_Click;
			// 
			// btnkisisil
			// 
			btnkisisil.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnkisisil.Location = new Point(532, 474);
			btnkisisil.Name = "btnkisisil";
			btnkisisil.Size = new Size(216, 56);
			btnkisisil.TabIndex = 8;
			btnkisisil.Text = "Kişi Sil";
			btnkisisil.UseVisualStyleBackColor = true;
			btnkisisil.Click += btnkisisil_Click;
			// 
			// btnkisidüzenle
			// 
			btnkisidüzenle.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnkisidüzenle.Location = new Point(276, 474);
			btnkisidüzenle.Name = "btnkisidüzenle";
			btnkisidüzenle.Size = new Size(216, 56);
			btnkisidüzenle.TabIndex = 9;
			btnkisidüzenle.Text = "Kişi Düzenle";
			btnkisidüzenle.UseVisualStyleBackColor = true;
			btnkisidüzenle.Click += btnkisidüzenle_Click;
			// 
			// btnanasayfayadön
			// 
			btnanasayfayadön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnanasayfayadön.Location = new Point(822, 281);
			btnanasayfayadön.Name = "btnanasayfayadön";
			btnanasayfayadön.Size = new Size(216, 56);
			btnanasayfayadön.TabIndex = 10;
			btnanasayfayadön.Text = "Ana Sayfaya Dön";
			btnanasayfayadön.UseVisualStyleBackColor = true;
			btnanasayfayadön.Click += btnanasayfayadön_Click;
			// 
			// KisileriGörüntüle
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(1062, 607);
			Controls.Add(btnanasayfayadön);
			Controls.Add(btnkisidüzenle);
			Controls.Add(btnkisisil);
			Controls.Add(btnkisiekle);
			Controls.Add(btnuyeleregit);
			Controls.Add(btnpersonelleregit);
			Controls.Add(dataGridkisilerigörüntüle);
			Name = "KisileriGörüntüle";
			Text = "Kişileri Görüntüleme";
			((System.ComponentModel.ISupportInitialize)dataGridkisilerigörüntüle).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridkisilerigörüntüle;
		private Button btnpersonelleregit;
		private Button btnuyeleregit;
		private Button btnkisiekle;
		private Button btnkisisil;
		private Button btnkisidüzenle;
		private Button btnanasayfayadön;
	}
}