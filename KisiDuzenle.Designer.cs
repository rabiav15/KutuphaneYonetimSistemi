namespace KutuphaneYonetimSistemi
{
	partial class KisiDuzenle
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
			btnkisileredön = new Button();
			dataGridkisilerigörüntüle = new DataGridView();
			cbkisituru = new ComboBox();
			kisituru = new Label();
			telefonnotextBox = new TextBox();
			telefonno = new Label();
			kisisoyaditextbox = new TextBox();
			kisisoyadi = new Label();
			kisiaditextbox = new TextBox();
			kisiadi = new Label();
			btnkisigüncelle = new Button();
			kisiid = new Label();
			cbguncellecekkisiid = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dataGridkisilerigörüntüle).BeginInit();
			SuspendLayout();
			// 
			// btnkisileredön
			// 
			btnkisileredön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnkisileredön.Location = new Point(803, 552);
			btnkisileredön.Name = "btnkisileredön";
			btnkisileredön.Size = new Size(227, 49);
			btnkisileredön.TabIndex = 21;
			btnkisileredön.Text = "Kişilere Dön";
			btnkisileredön.UseVisualStyleBackColor = true;
			btnkisileredön.Click += btnkisileredön_Click;
			// 
			// dataGridkisilerigörüntüle
			// 
			dataGridkisilerigörüntüle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridkisilerigörüntüle.Location = new Point(32, 21);
			dataGridkisilerigörüntüle.Name = "dataGridkisilerigörüntüle";
			dataGridkisilerigörüntüle.RowHeadersWidth = 62;
			dataGridkisilerigörüntüle.Size = new Size(723, 381);
			dataGridkisilerigörüntüle.TabIndex = 20;
			// 
			// cbkisituru
			// 
			cbkisituru.FormattingEnabled = true;
			cbkisituru.Location = new Point(545, 478);
			cbkisituru.Name = "cbkisituru";
			cbkisituru.Size = new Size(182, 33);
			cbkisituru.TabIndex = 19;
			// 
			// kisituru
			// 
			kisituru.AutoSize = true;
			kisituru.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kisituru.Location = new Point(545, 448);
			kisituru.Name = "kisituru";
			kisituru.Size = new Size(120, 25);
			kisituru.TabIndex = 18;
			kisituru.Text = "Kişi Türü:";
			// 
			// telefonnotextBox
			// 
			telefonnotextBox.Location = new Point(308, 589);
			telefonnotextBox.Name = "telefonnotextBox";
			telefonnotextBox.Size = new Size(182, 31);
			telefonnotextBox.TabIndex = 17;
			// 
			// telefonno
			// 
			telefonno.AutoSize = true;
			telefonno.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			telefonno.Location = new Point(308, 552);
			telefonno.Name = "telefonno";
			telefonno.Size = new Size(217, 25);
			telefonno.TabIndex = 16;
			telefonno.Text = "Telefon Numarası:";
			// 
			// kisisoyaditextbox
			// 
			kisisoyaditextbox.Location = new Point(308, 478);
			kisisoyaditextbox.Name = "kisisoyaditextbox";
			kisisoyaditextbox.Size = new Size(182, 31);
			kisisoyaditextbox.TabIndex = 15;
			// 
			// kisisoyadi
			// 
			kisisoyadi.AutoSize = true;
			kisisoyadi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kisisoyadi.Location = new Point(308, 448);
			kisisoyadi.Name = "kisisoyadi";
			kisisoyadi.Size = new Size(143, 25);
			kisisoyadi.TabIndex = 14;
			kisisoyadi.Text = "Kişi Soyadı:";
			// 
			// kisiaditextbox
			// 
			kisiaditextbox.Location = new Point(32, 589);
			kisiaditextbox.Name = "kisiaditextbox";
			kisiaditextbox.Size = new Size(182, 31);
			kisiaditextbox.TabIndex = 13;
			// 
			// kisiadi
			// 
			kisiadi.AutoSize = true;
			kisiadi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kisiadi.Location = new Point(32, 552);
			kisiadi.Name = "kisiadi";
			kisiadi.Size = new Size(105, 25);
			kisiadi.TabIndex = 12;
			kisiadi.Text = "Kişi Adı:";
			// 
			// btnkisigüncelle
			// 
			btnkisigüncelle.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnkisigüncelle.Location = new Point(851, 194);
			btnkisigüncelle.Name = "btnkisigüncelle";
			btnkisigüncelle.Size = new Size(191, 64);
			btnkisigüncelle.TabIndex = 11;
			btnkisigüncelle.Text = "Kişiyi Güncelle";
			btnkisigüncelle.UseVisualStyleBackColor = true;
			btnkisigüncelle.Click += btnkisigüncelle_Click;
			// 
			// kisiid
			// 
			kisiid.AutoSize = true;
			kisiid.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kisiid.Location = new Point(32, 448);
			kisiid.Name = "kisiid";
			kisiid.Size = new Size(216, 25);
			kisiid.TabIndex = 22;
			kisiid.Text = "Güncellencek Kişi:";
			// 
			// cbguncellecekkisiid
			// 
			cbguncellecekkisiid.FormattingEnabled = true;
			cbguncellecekkisiid.Location = new Point(32, 476);
			cbguncellecekkisiid.Name = "cbguncellecekkisiid";
			cbguncellecekkisiid.Size = new Size(182, 33);
			cbguncellecekkisiid.TabIndex = 23;
			// 
			// KisiDuzenle
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(1068, 678);
			Controls.Add(cbguncellecekkisiid);
			Controls.Add(kisiid);
			Controls.Add(btnkisileredön);
			Controls.Add(dataGridkisilerigörüntüle);
			Controls.Add(cbkisituru);
			Controls.Add(kisituru);
			Controls.Add(telefonnotextBox);
			Controls.Add(telefonno);
			Controls.Add(kisisoyaditextbox);
			Controls.Add(kisisoyadi);
			Controls.Add(kisiaditextbox);
			Controls.Add(kisiadi);
			Controls.Add(btnkisigüncelle);
			Name = "KisiDuzenle";
			Text = "Kişi Düzenle";
			((System.ComponentModel.ISupportInitialize)dataGridkisilerigörüntüle).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnkisileredön;
		private DataGridView dataGridkisilerigörüntüle;
		private ComboBox cbkisituru;
		private Label kisituru;
		private TextBox telefonnotextBox;
		private Label telefonno;
		private TextBox kisisoyaditextbox;
		private Label kisisoyadi;
		private TextBox kisiaditextbox;
		private Label kisiadi;
		private Button btnkisigüncelle;
		private Label kisiid;
		private ComboBox cbguncellecekkisiid;
	}
}