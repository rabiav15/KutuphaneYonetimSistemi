namespace KutuphaneYonetimSistemi
{
	partial class KiralamGörüntüle
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
			datagridkiralama = new DataGridView();
			btnanasayfadön = new Button();
			btnkiralamayagit = new Button();
			button1 = new Button();
			btncezagoruntule = new Button();
			((System.ComponentModel.ISupportInitialize)datagridkiralama).BeginInit();
			SuspendLayout();
			// 
			// datagridkiralama
			// 
			datagridkiralama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			datagridkiralama.Location = new Point(137, 12);
			datagridkiralama.Name = "datagridkiralama";
			datagridkiralama.RowHeadersWidth = 62;
			datagridkiralama.Size = new Size(706, 353);
			datagridkiralama.TabIndex = 0;
			// 
			// btnanasayfadön
			// 
			btnanasayfadön.BackColor = Color.FromArgb(128, 64, 64);
			btnanasayfadön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnanasayfadön.Location = new Point(709, 571);
			btnanasayfadön.Name = "btnanasayfadön";
			btnanasayfadön.Size = new Size(238, 57);
			btnanasayfadön.TabIndex = 14;
			btnanasayfadön.Text = "Ana Sayfaya Dön";
			btnanasayfadön.UseVisualStyleBackColor = false;
			btnanasayfadön.Click += btnanasayfadön_Click;
			// 
			// btnkiralamayagit
			// 
			btnkiralamayagit.BackColor = Color.FromArgb(128, 64, 64);
			btnkiralamayagit.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnkiralamayagit.Location = new Point(191, 371);
			btnkiralamayagit.Name = "btnkiralamayagit";
			btnkiralamayagit.Size = new Size(556, 57);
			btnkiralamayagit.TabIndex = 15;
			btnkiralamayagit.Text = "Kiralama İşlemi Yapmak İçin Lütfen Tıklayınız";
			btnkiralamayagit.UseVisualStyleBackColor = false;
			btnkiralamayagit.Click += btnkiralamayagit_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(128, 64, 64);
			button1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			button1.Location = new Point(191, 443);
			button1.Name = "button1";
			button1.Size = new Size(556, 57);
			button1.TabIndex = 16;
			button1.Text = "İade İşlemi Yapmak İçin Lütfen Tıklayınız";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// btncezagoruntule
			// 
			btncezagoruntule.BackColor = Color.FromArgb(128, 64, 64);
			btncezagoruntule.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btncezagoruntule.Location = new Point(191, 508);
			btncezagoruntule.Name = "btncezagoruntule";
			btncezagoruntule.Size = new Size(556, 57);
			btncezagoruntule.TabIndex = 17;
			btncezagoruntule.Text = "Cezaları Görüntülemek İçin Lütfen Tıklayınız";
			btncezagoruntule.UseVisualStyleBackColor = false;
			btncezagoruntule.Click += btncezagoruntule_Click;
			// 
			// KiralamGörüntüle
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(969, 640);
			Controls.Add(btncezagoruntule);
			Controls.Add(button1);
			Controls.Add(btnkiralamayagit);
			Controls.Add(btnanasayfadön);
			Controls.Add(datagridkiralama);
			Name = "KiralamGörüntüle";
			Text = "Kiralama Görüntüle";
			((System.ComponentModel.ISupportInitialize)datagridkiralama).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView datagridkiralama;
		private Button btnanasayfadön;
		private Button btnkiralamayagit;
		private Button button1;
		private Button btncezagoruntule;
	}
}