namespace KutuphaneYonetimSistemi
{
	partial class CezaGoruntule
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
			dataGridcezalar = new DataGridView();
			cbKiralananIslemler = new ComboBox();
			kiralamayapanuyeadi = new Label();
			btncezakaydet = new Button();
			btnanasayfadön = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridcezalar).BeginInit();
			SuspendLayout();
			// 
			// dataGridcezalar
			// 
			dataGridcezalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridcezalar.Location = new Point(30, 113);
			dataGridcezalar.Name = "dataGridcezalar";
			dataGridcezalar.RowHeadersWidth = 62;
			dataGridcezalar.Size = new Size(864, 359);
			dataGridcezalar.TabIndex = 0;
			// 
			// cbKiralananIslemler
			// 
			cbKiralananIslemler.FormattingEnabled = true;
			cbKiralananIslemler.Location = new Point(30, 74);
			cbKiralananIslemler.Name = "cbKiralananIslemler";
			cbKiralananIslemler.Size = new Size(359, 33);
			cbKiralananIslemler.TabIndex = 9;
			// 
			// kiralamayapanuyeadi
			// 
			kiralamayapanuyeadi.AutoSize = true;
			kiralamayapanuyeadi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kiralamayapanuyeadi.Location = new Point(30, 35);
			kiralamayapanuyeadi.Name = "kiralamayapanuyeadi";
			kiralamayapanuyeadi.Size = new Size(304, 25);
			kiralamayapanuyeadi.TabIndex = 8;
			kiralamayapanuyeadi.Text = "Kiralama İşlemini Seçiniz:";
			// 
			// btncezakaydet
			// 
			btncezakaydet.BackColor = Color.FromArgb(255, 192, 128);
			btncezakaydet.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btncezakaydet.Location = new Point(598, 50);
			btncezakaydet.Name = "btncezakaydet";
			btncezakaydet.Size = new Size(286, 57);
			btncezakaydet.TabIndex = 16;
			btncezakaydet.Text = "Ceza İşlemini Kaydet";
			btncezakaydet.UseVisualStyleBackColor = false;
			btncezakaydet.Click += btncezakaydet_Click;
			// 
			// btnanasayfadön
			// 
			btnanasayfadön.BackColor = Color.FromArgb(128, 64, 64);
			btnanasayfadön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnanasayfadön.Location = new Point(559, 513);
			btnanasayfadön.Name = "btnanasayfadön";
			btnanasayfadön.Size = new Size(335, 57);
			btnanasayfadön.TabIndex = 17;
			btnanasayfadön.Text = "Kiralama Görüntüleye Dön";
			btnanasayfadön.UseVisualStyleBackColor = false;
			btnanasayfadön.Click += btnanasayfadön_Click;
			// 
			// CezaGoruntule
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(922, 599);
			Controls.Add(btnanasayfadön);
			Controls.Add(btncezakaydet);
			Controls.Add(cbKiralananIslemler);
			Controls.Add(kiralamayapanuyeadi);
			Controls.Add(dataGridcezalar);
			Name = "CezaGoruntule";
			Text = "Ceza Görüntüle";
			Load += CezaGoruntule_Load;
			((System.ComponentModel.ISupportInitialize)dataGridcezalar).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridcezalar;
		private ComboBox cbKiralananIslemler;
		private Label kiralamayapanuyeadi;
		private Button btncezakaydet;
		private Button btnanasayfadön;
	}
}