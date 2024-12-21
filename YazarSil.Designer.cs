namespace KutuphaneYonetimSistemi
{
	partial class YazarSil
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
			cbyazarid = new ComboBox();
			label1 = new Label();
			dataGridyazarlistele = new DataGridView();
			btnyazarsil = new Button();
			btnyazarlistelegeridön = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridyazarlistele).BeginInit();
			SuspendLayout();
			// 
			// cbyazarid
			// 
			cbyazarid.FormattingEnabled = true;
			cbyazarid.Location = new Point(53, 403);
			cbyazarid.Name = "cbyazarid";
			cbyazarid.Size = new Size(227, 33);
			cbyazarid.TabIndex = 41;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.Location = new Point(53, 358);
			label1.Name = "label1";
			label1.Size = new Size(190, 25);
			label1.TabIndex = 40;
			label1.Text = "Silinecek Yazar:";
			// 
			// dataGridyazarlistele
			// 
			dataGridyazarlistele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridyazarlistele.Location = new Point(34, 25);
			dataGridyazarlistele.Name = "dataGridyazarlistele";
			dataGridyazarlistele.RowHeadersWidth = 62;
			dataGridyazarlistele.Size = new Size(814, 290);
			dataGridyazarlistele.TabIndex = 42;
			// 
			// btnyazarsil
			// 
			btnyazarsil.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnyazarsil.Location = new Point(661, 437);
			btnyazarsil.Name = "btnyazarsil";
			btnyazarsil.Size = new Size(175, 58);
			btnyazarsil.TabIndex = 43;
			btnyazarsil.Text = "Yazar Sil";
			btnyazarsil.UseVisualStyleBackColor = true;
			btnyazarsil.Click += btnyazarsil_Click;
			// 
			// btnyazarlistelegeridön
			// 
			btnyazarlistelegeridön.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			btnyazarlistelegeridön.Location = new Point(540, 377);
			btnyazarlistelegeridön.Name = "btnyazarlistelegeridön";
			btnyazarlistelegeridön.Size = new Size(296, 34);
			btnyazarlistelegeridön.TabIndex = 44;
			btnyazarlistelegeridön.Text = "Listelemeye Geri Dön";
			btnyazarlistelegeridön.UseVisualStyleBackColor = true;
			btnyazarlistelegeridön.Click += btnyazarlistelegeridön_Click;
			// 
			// YazarSil
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			ClientSize = new Size(883, 544);
			Controls.Add(btnyazarlistelegeridön);
			Controls.Add(btnyazarsil);
			Controls.Add(dataGridyazarlistele);
			Controls.Add(cbyazarid);
			Controls.Add(label1);
			Name = "YazarSil";
			Text = "Yazar Sil";
			((System.ComponentModel.ISupportInitialize)dataGridyazarlistele).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbyazarid;
		private Label label1;
		private DataGridView dataGridyazarlistele;
		private Button btnyazarsil;
		private Button btnyazarlistelegeridön;
	}
}