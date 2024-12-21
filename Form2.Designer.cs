namespace KutuphaneYonetimSistemi
{
	partial class Form2
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
			dataGridViewKitaplar = new DataGridView();
			buttonKitapListele = new Button();
			kitapeklebutton = new Button();
			kitapgüncellebutton = new Button();
			kitapsilbutton = new Button();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewKitaplar
			// 
			dataGridViewKitaplar.BackgroundColor = Color.Bisque;
			dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewKitaplar.GridColor = Color.Bisque;
			dataGridViewKitaplar.Location = new Point(47, 92);
			dataGridViewKitaplar.Name = "dataGridViewKitaplar";
			dataGridViewKitaplar.RowHeadersWidth = 62;
			dataGridViewKitaplar.Size = new Size(903, 445);
			dataGridViewKitaplar.TabIndex = 0;
			// 
			// buttonKitapListele
			// 
			buttonKitapListele.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonKitapListele.Location = new Point(359, 22);
			buttonKitapListele.Name = "buttonKitapListele";
			buttonKitapListele.Size = new Size(254, 46);
			buttonKitapListele.TabIndex = 1;
			buttonKitapListele.Text = "Kitapları Listele";
			buttonKitapListele.UseVisualStyleBackColor = true;
			buttonKitapListele.Click += buttonKitapListele_Click;
			// 
			// kitapeklebutton
			// 
			kitapeklebutton.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kitapeklebutton.Location = new Point(407, 557);
			kitapeklebutton.Name = "kitapeklebutton";
			kitapeklebutton.Size = new Size(171, 34);
			kitapeklebutton.TabIndex = 2;
			kitapeklebutton.Text = "Kitap Ekle";
			kitapeklebutton.UseVisualStyleBackColor = true;
			kitapeklebutton.Click += kitapeklebutton_Click;
			// 
			// kitapgüncellebutton
			// 
			kitapgüncellebutton.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kitapgüncellebutton.Location = new Point(597, 557);
			kitapgüncellebutton.Name = "kitapgüncellebutton";
			kitapgüncellebutton.Size = new Size(193, 34);
			kitapgüncellebutton.TabIndex = 3;
			kitapgüncellebutton.Text = "Kitap Güncelle";
			kitapgüncellebutton.UseVisualStyleBackColor = true;
			kitapgüncellebutton.Click += kitapgüncellebutton_Click;
			// 
			// kitapsilbutton
			// 
			kitapsilbutton.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kitapsilbutton.Location = new Point(807, 557);
			kitapsilbutton.Name = "kitapsilbutton";
			kitapsilbutton.RightToLeft = RightToLeft.No;
			kitapsilbutton.Size = new Size(143, 34);
			kitapsilbutton.TabIndex = 4;
			kitapsilbutton.Text = "Kitap Sil";
			kitapsilbutton.UseVisualStyleBackColor = true;
			kitapsilbutton.Click += kitapsilbutton_Click;
			// 
			// button1
			// 
			button1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			button1.Location = new Point(12, 593);
			button1.Name = "button1";
			button1.Size = new Size(214, 34);
			button1.TabIndex = 5;
			button1.Text = "Ana Sayfaya Dön";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(989, 655);
			Controls.Add(button1);
			Controls.Add(kitapsilbutton);
			Controls.Add(kitapgüncellebutton);
			Controls.Add(kitapeklebutton);
			Controls.Add(buttonKitapListele);
			Controls.Add(dataGridViewKitaplar);
			Name = "Form2";
			Text = "KitaplarSayfası";
			Load += Form2_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridViewKitaplar;
		private Button buttonKitapListele;
		private Button kitapeklebutton;
		private Button kitapgüncellebutton;
		private Button kitapsilbutton;
		private Button button1;
	}
}