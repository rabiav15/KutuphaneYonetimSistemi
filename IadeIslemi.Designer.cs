namespace KutuphaneYonetimSistemi
{
	partial class IadeIslemi
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
			cbKiralananIslemler = new ComboBox();
			kiralamayapanuyeadi = new Label();
			iadetarihi = new Label();
			dtpiadetarihi = new DateTimePicker();
			datagridkiralama = new DataGridView();
			btniadekaydet = new Button();
			btnanasayfadön = new Button();
			label1 = new Label();
			dtpkiralamatarihi = new DateTimePicker();
			((System.ComponentModel.ISupportInitialize)datagridkiralama).BeginInit();
			SuspendLayout();
			// 
			// cbKiralananIslemler
			// 
			cbKiralananIslemler.FormattingEnabled = true;
			cbKiralananIslemler.Location = new Point(36, 85);
			cbKiralananIslemler.Name = "cbKiralananIslemler";
			cbKiralananIslemler.Size = new Size(359, 33);
			cbKiralananIslemler.TabIndex = 7;
			// 
			// kiralamayapanuyeadi
			// 
			kiralamayapanuyeadi.AutoSize = true;
			kiralamayapanuyeadi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kiralamayapanuyeadi.Location = new Point(36, 46);
			kiralamayapanuyeadi.Name = "kiralamayapanuyeadi";
			kiralamayapanuyeadi.Size = new Size(304, 25);
			kiralamayapanuyeadi.TabIndex = 6;
			kiralamayapanuyeadi.Text = "Kiralama İşlemini Seçiniz:";
			// 
			// iadetarihi
			// 
			iadetarihi.AutoSize = true;
			iadetarihi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			iadetarihi.Location = new Point(36, 268);
			iadetarihi.Name = "iadetarihi";
			iadetarihi.Size = new Size(143, 25);
			iadetarihi.TabIndex = 13;
			iadetarihi.Text = "İade Tarihi:";
			// 
			// dtpiadetarihi
			// 
			dtpiadetarihi.CalendarFont = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
			dtpiadetarihi.Location = new Point(36, 307);
			dtpiadetarihi.Name = "dtpiadetarihi";
			dtpiadetarihi.Size = new Size(262, 31);
			dtpiadetarihi.TabIndex = 12;
			// 
			// datagridkiralama
			// 
			datagridkiralama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			datagridkiralama.Location = new Point(435, 46);
			datagridkiralama.Name = "datagridkiralama";
			datagridkiralama.RowHeadersWidth = 62;
			datagridkiralama.Size = new Size(488, 455);
			datagridkiralama.TabIndex = 14;
			// 
			// btniadekaydet
			// 
			btniadekaydet.BackColor = Color.FromArgb(255, 192, 128);
			btniadekaydet.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btniadekaydet.Location = new Point(36, 379);
			btniadekaydet.Name = "btniadekaydet";
			btniadekaydet.Size = new Size(286, 57);
			btniadekaydet.TabIndex = 15;
			btniadekaydet.Text = "İade İşlemini Kaydet";
			btniadekaydet.UseVisualStyleBackColor = false;
			btniadekaydet.Click += btniadekaydet_Click;
			// 
			// btnanasayfadön
			// 
			btnanasayfadön.BackColor = Color.FromArgb(128, 64, 64);
			btnanasayfadön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnanasayfadön.Location = new Point(36, 473);
			btnanasayfadön.Name = "btnanasayfadön";
			btnanasayfadön.Size = new Size(335, 57);
			btnanasayfadön.TabIndex = 16;
			btnanasayfadön.Text = "Kiralama Görüntüleye Dön";
			btnanasayfadön.UseVisualStyleBackColor = false;
			btnanasayfadön.Click += btnanasayfadön_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.Location = new Point(36, 157);
			label1.Name = "label1";
			label1.Size = new Size(191, 25);
			label1.TabIndex = 18;
			label1.Text = "Kiralama Tarihi:";
			// 
			// dtpkiralamatarihi
			// 
			dtpkiralamatarihi.CalendarFont = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
			dtpkiralamatarihi.Location = new Point(36, 196);
			dtpkiralamatarihi.Name = "dtpkiralamatarihi";
			dtpkiralamatarihi.Size = new Size(262, 31);
			dtpkiralamatarihi.TabIndex = 17;
			// 
			// IadeIslemi
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(948, 584);
			Controls.Add(label1);
			Controls.Add(dtpkiralamatarihi);
			Controls.Add(btnanasayfadön);
			Controls.Add(btniadekaydet);
			Controls.Add(datagridkiralama);
			Controls.Add(iadetarihi);
			Controls.Add(dtpiadetarihi);
			Controls.Add(cbKiralananIslemler);
			Controls.Add(kiralamayapanuyeadi);
			Name = "IadeIslemi";
			Text = "İade İşlemi";
			((System.ComponentModel.ISupportInitialize)datagridkiralama).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbKiralananIslemler;
		private Label kiralamayapanuyeadi;
		private Label iadetarihi;
		private DateTimePicker dtpiadetarihi;
		private DataGridView datagridkiralama;
		private Button btniadekaydet;
		private Button btnanasayfadön;
		private Label label1;
		private DateTimePicker dtpkiralamatarihi;
	}
}