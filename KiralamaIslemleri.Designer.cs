namespace KutuphaneYonetimSistemi
{
	partial class KiralamaIslemleri
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
			kitapadi = new Label();
			cmbkitap = new ComboBox();
			cmbuye = new ComboBox();
			uyeadi = new Label();
			cmbpersonel = new ComboBox();
			perosneladi = new Label();
			btnkaydet = new Button();
			dtpkiralamatarihi = new DateTimePicker();
			kiralamatarihi = new Label();
			baslık = new Label();
			btnanasayfadön = new Button();
			iadetarihi = new Label();
			dtpiadetarihi = new DateTimePicker();
			SuspendLayout();
			// 
			// kitapadi
			// 
			kitapadi.AutoSize = true;
			kitapadi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kitapadi.Location = new Point(38, 129);
			kitapadi.Name = "kitapadi";
			kitapadi.Size = new Size(115, 25);
			kitapadi.TabIndex = 0;
			kitapadi.Text = "Kitap Ad:";
			// 
			// cmbkitap
			// 
			cmbkitap.FormattingEnabled = true;
			cmbkitap.Location = new Point(38, 166);
			cmbkitap.Name = "cmbkitap";
			cmbkitap.Size = new Size(262, 33);
			cmbkitap.TabIndex = 1;
			// 
			// cmbuye
			// 
			cmbuye.FormattingEnabled = true;
			cmbuye.Location = new Point(38, 288);
			cmbuye.Name = "cmbuye";
			cmbuye.Size = new Size(262, 33);
			cmbuye.TabIndex = 3;
			// 
			// uyeadi
			// 
			uyeadi.AutoSize = true;
			uyeadi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			uyeadi.Location = new Point(38, 249);
			uyeadi.Name = "uyeadi";
			uyeadi.Size = new Size(99, 25);
			uyeadi.TabIndex = 2;
			uyeadi.Text = "Üye Ad:";
			// 
			// cmbpersonel
			// 
			cmbpersonel.FormattingEnabled = true;
			cmbpersonel.Location = new Point(38, 421);
			cmbpersonel.Name = "cmbpersonel";
			cmbpersonel.Size = new Size(262, 33);
			cmbpersonel.TabIndex = 5;
			// 
			// perosneladi
			// 
			perosneladi.AutoSize = true;
			perosneladi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			perosneladi.Location = new Point(38, 384);
			perosneladi.Name = "perosneladi";
			perosneladi.Size = new Size(262, 25);
			perosneladi.TabIndex = 4;
			perosneladi.Text = "İlgilenen Personel Ad:";
			// 
			// btnkaydet
			// 
			btnkaydet.BackColor = Color.FromArgb(255, 192, 128);
			btnkaydet.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnkaydet.Location = new Point(410, 397);
			btnkaydet.Name = "btnkaydet";
			btnkaydet.Size = new Size(160, 57);
			btnkaydet.TabIndex = 6;
			btnkaydet.Text = "Kaydet";
			btnkaydet.UseVisualStyleBackColor = false;
			btnkaydet.Click += btnkaydet_Click;
			// 
			// dtpkiralamatarihi
			// 
			dtpkiralamatarihi.CalendarFont = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
			dtpkiralamatarihi.Location = new Point(398, 168);
			dtpkiralamatarihi.Name = "dtpkiralamatarihi";
			dtpkiralamatarihi.Size = new Size(262, 31);
			dtpkiralamatarihi.TabIndex = 7;
			// 
			// kiralamatarihi
			// 
			kiralamatarihi.AutoSize = true;
			kiralamatarihi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			kiralamatarihi.Location = new Point(398, 129);
			kiralamatarihi.Name = "kiralamatarihi";
			kiralamatarihi.Size = new Size(191, 25);
			kiralamatarihi.TabIndex = 9;
			kiralamatarihi.Text = "Kiralama Tarihi:";
			// 
			// baslık
			// 
			baslık.AutoSize = true;
			baslık.BackColor = Color.Bisque;
			baslık.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			baslık.ForeColor = Color.Black;
			baslık.Location = new Point(38, 32);
			baslık.Name = "baslık";
			baslık.Size = new Size(797, 29);
			baslık.TabIndex = 12;
			baslık.Text = "KİTAP KİRALAMA İŞLEMLERİ BURADAN YAPILMAKTADIR.";
			// 
			// btnanasayfadön
			// 
			btnanasayfadön.BackColor = Color.FromArgb(128, 64, 64);
			btnanasayfadön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnanasayfadön.Location = new Point(525, 513);
			btnanasayfadön.Name = "btnanasayfadön";
			btnanasayfadön.Size = new Size(335, 57);
			btnanasayfadön.TabIndex = 13;
			btnanasayfadön.Text = "Kiralama Görüntüleye Dön";
			btnanasayfadön.UseVisualStyleBackColor = false;
			btnanasayfadön.Click += btnanasayfadön_Click;
			// 
			// iadetarihi
			// 
			iadetarihi.AutoSize = true;
			iadetarihi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			iadetarihi.Location = new Point(398, 249);
			iadetarihi.Name = "iadetarihi";
			iadetarihi.Size = new Size(143, 25);
			iadetarihi.TabIndex = 15;
			iadetarihi.Text = "İade Tarihi:";
		
			// 
			// dtpiadetarihi
			// 
			dtpiadetarihi.CalendarFont = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
			dtpiadetarihi.Location = new Point(398, 288);
			dtpiadetarihi.Name = "dtpiadetarihi";
			dtpiadetarihi.Size = new Size(262, 31);
			dtpiadetarihi.TabIndex = 14;
			dtpiadetarihi.ValueChanged += dtpiadetarihi_ValueChanged;
			// 
			// KiralamaIslemleri
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(872, 592);
			Controls.Add(iadetarihi);
			Controls.Add(dtpiadetarihi);
			Controls.Add(btnanasayfadön);
			Controls.Add(baslık);
			Controls.Add(kiralamatarihi);
			Controls.Add(dtpkiralamatarihi);
			Controls.Add(btnkaydet);
			Controls.Add(cmbpersonel);
			Controls.Add(perosneladi);
			Controls.Add(cmbuye);
			Controls.Add(uyeadi);
			Controls.Add(cmbkitap);
			Controls.Add(kitapadi);
			Name = "KiralamaIslemleri";
			Text = "Kiralama İşlemleri";
			Load += KiralamaIslemleri_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label kitapadi;
		private ComboBox cmbkitap;
		private ComboBox cmbuye;
		private Label uyeadi;
		private ComboBox cmbpersonel;
		private Label perosneladi;
		private Button btnkaydet;
		private DateTimePicker dtpkiralamatarihi;
		private Label kiralamatarihi;
		private Label baslık;
		private Button btnanasayfadön;
		private Label iadetarihi;
		private DateTimePicker dtpiadetarihi;
	}
}