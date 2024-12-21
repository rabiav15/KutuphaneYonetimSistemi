namespace KutuphaneYonetimSistemi
{
	partial class KisiSil
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
			cbsilinecekkisiid = new ComboBox();
			kisiid = new Label();
			dataGridkisilerigörüntüle = new DataGridView();
			btnkisileredön = new Button();
			btnkisisil = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridkisilerigörüntüle).BeginInit();
			SuspendLayout();
			// 
			// cbsilinecekkisiid
			// 
			cbsilinecekkisiid.FormattingEnabled = true;
			cbsilinecekkisiid.Location = new Point(39, 477);
			cbsilinecekkisiid.Name = "cbsilinecekkisiid";
			cbsilinecekkisiid.Size = new Size(182, 33);
			cbsilinecekkisiid.TabIndex = 30;
			// 
			// kisiid
			// 
			kisiid.AutoSize = true;
			kisiid.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kisiid.Location = new Point(39, 449);
			kisiid.Name = "kisiid";
			kisiid.Size = new Size(168, 25);
			kisiid.TabIndex = 29;
			kisiid.Text = "Silinecek Kişi:";
			// 
			// dataGridkisilerigörüntüle
			// 
			dataGridkisilerigörüntüle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridkisilerigörüntüle.Location = new Point(39, 22);
			dataGridkisilerigörüntüle.Name = "dataGridkisilerigörüntüle";
			dataGridkisilerigörüntüle.RowHeadersWidth = 62;
			dataGridkisilerigörüntüle.Size = new Size(723, 381);
			dataGridkisilerigörüntüle.TabIndex = 28;
			// 
			// btnkisileredön
			// 
			btnkisileredön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnkisileredön.Location = new Point(535, 467);
			btnkisileredön.Name = "btnkisileredön";
			btnkisileredön.Size = new Size(227, 49);
			btnkisileredön.TabIndex = 32;
			btnkisileredön.Text = "Kişilere Dön";
			btnkisileredön.UseVisualStyleBackColor = true;
			btnkisileredön.Click += btnkisileredön_Click;
			// 
			// btnkisisil
			// 
			btnkisisil.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnkisisil.Location = new Point(305, 449);
			btnkisisil.Name = "btnkisisil";
			btnkisisil.Size = new Size(191, 64);
			btnkisisil.TabIndex = 31;
			btnkisisil.Text = "Kişiyi Sil";
			btnkisisil.UseVisualStyleBackColor = true;
			btnkisisil.Click += btnkisisil_Click;
			// 
			// KisiSil
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(826, 585);
			Controls.Add(btnkisileredön);
			Controls.Add(btnkisisil);
			Controls.Add(cbsilinecekkisiid);
			Controls.Add(kisiid);
			Controls.Add(dataGridkisilerigörüntüle);
			Name = "KisiSil";
			Text = "Kişi Sil";
			((System.ComponentModel.ISupportInitialize)dataGridkisilerigörüntüle).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbsilinecekkisiid;
		private Label kisiid;
		private DataGridView dataGridkisilerigörüntüle;
		private Button btnkisileredön;
		private Button btnkisisil;
	}
}