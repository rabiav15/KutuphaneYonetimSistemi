namespace KutuphaneYonetimSistemi
{
	partial class KisiEkle
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
			btnkisiekle = new Button();
			kisiadi = new Label();
			kisiaditextbox = new TextBox();
			kisisoyaditextbox = new TextBox();
			kisisoyadi = new Label();
			telefonnotextBox = new TextBox();
			telefonno = new Label();
			kisituru = new Label();
			cbkisituru = new ComboBox();
			dataGridkisilerigörüntüle = new DataGridView();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridkisilerigörüntüle).BeginInit();
			SuspendLayout();
			// 
			// btnkisiekle
			// 
			btnkisiekle.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnkisiekle.Location = new Point(850, 164);
			btnkisiekle.Name = "btnkisiekle";
			btnkisiekle.Size = new Size(152, 64);
			btnkisiekle.TabIndex = 0;
			btnkisiekle.Text = "Kişiyi Ekle";
			btnkisiekle.UseVisualStyleBackColor = true;
			btnkisiekle.Click += btnkisiekle_Click;
			// 
			// kisiadi
			// 
			kisiadi.AutoSize = true;
			kisiadi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kisiadi.Location = new Point(36, 436);
			kisiadi.Name = "kisiadi";
			kisiadi.Size = new Size(105, 25);
			kisiadi.TabIndex = 1;
			kisiadi.Text = "Kişi Adı:";
			// 
			// kisiaditextbox
			// 
			kisiaditextbox.Location = new Point(36, 476);
			kisiaditextbox.Name = "kisiaditextbox";
			kisiaditextbox.Size = new Size(182, 31);
			kisiaditextbox.TabIndex = 2;
			// 
			// kisisoyaditextbox
			// 
			kisisoyaditextbox.Location = new Point(36, 590);
			kisisoyaditextbox.Name = "kisisoyaditextbox";
			kisisoyaditextbox.Size = new Size(182, 31);
			kisisoyaditextbox.TabIndex = 4;
			// 
			// kisisoyadi
			// 
			kisisoyadi.AutoSize = true;
			kisisoyadi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kisisoyadi.Location = new Point(36, 538);
			kisisoyadi.Name = "kisisoyadi";
			kisisoyadi.Size = new Size(143, 25);
			kisisoyadi.TabIndex = 3;
			kisisoyadi.Text = "Kişi Soyadı:";
			// 
			// telefonnotextBox
			// 
			telefonnotextBox.Location = new Point(328, 476);
			telefonnotextBox.Name = "telefonnotextBox";
			telefonnotextBox.Size = new Size(182, 31);
			telefonnotextBox.TabIndex = 6;
			// 
			// telefonno
			// 
			telefonno.AutoSize = true;
			telefonno.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			telefonno.Location = new Point(328, 436);
			telefonno.Name = "telefonno";
			telefonno.Size = new Size(217, 25);
			telefonno.TabIndex = 5;
			telefonno.Text = "Telefon Numarası:";
			// 
			// kisituru
			// 
			kisituru.AutoSize = true;
			kisituru.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kisituru.Location = new Point(328, 538);
			kisituru.Name = "kisituru";
			kisituru.Size = new Size(120, 25);
			kisituru.TabIndex = 7;
			kisituru.Text = "Kişi Türü:";
			// 
			// cbkisituru
			// 
			cbkisituru.FormattingEnabled = true;
			cbkisituru.Location = new Point(328, 588);
			cbkisituru.Name = "cbkisituru";
			cbkisituru.Size = new Size(182, 33);
			cbkisituru.TabIndex = 8;
			// 
			// dataGridkisilerigörüntüle
			// 
			dataGridkisilerigörüntüle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridkisilerigörüntüle.Location = new Point(73, 12);
			dataGridkisilerigörüntüle.Name = "dataGridkisilerigörüntüle";
			dataGridkisilerigörüntüle.RowHeadersWidth = 62;
			dataGridkisilerigörüntüle.Size = new Size(723, 381);
			dataGridkisilerigörüntüle.TabIndex = 9;
			// 
			// button1
			// 
			button1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			button1.Location = new Point(775, 563);
			button1.Name = "button1";
			button1.Size = new Size(227, 49);
			button1.TabIndex = 10;
			button1.Text = "Kişilere Dön";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// KisiEkle
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(1052, 644);
			Controls.Add(button1);
			Controls.Add(dataGridkisilerigörüntüle);
			Controls.Add(cbkisituru);
			Controls.Add(kisituru);
			Controls.Add(telefonnotextBox);
			Controls.Add(telefonno);
			Controls.Add(kisisoyaditextbox);
			Controls.Add(kisisoyadi);
			Controls.Add(kisiaditextbox);
			Controls.Add(kisiadi);
			Controls.Add(btnkisiekle);
			Name = "KisiEkle";
			Text = "Kisi Ekle";
			((System.ComponentModel.ISupportInitialize)dataGridkisilerigörüntüle).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnkisiekle;
		private Label kisiadi;
		private TextBox kisiaditextbox;
		private TextBox kisisoyaditextbox;
		private Label kisisoyadi;
		private TextBox telefonnotextBox;
		private Label telefonno;
		private Label kisituru;
		private ComboBox cbkisituru;
		private DataGridView dataGridkisilerigörüntüle;
		private Button button1;
	}
}