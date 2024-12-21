namespace KutuphaneYonetimSistemi
{
	partial class KitapDetay
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
			labelKitapAdi = new Label();
			labelStokAdedi = new Label();
			labelYazarAdi = new Label();
			labelIsbn = new Label();
			panel1 = new Panel();
			panel2 = new Panel();
			panel5 = new Panel();
			panel6 = new Panel();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel5.SuspendLayout();
			panel6.SuspendLayout();
			SuspendLayout();
			// 
			// labelKitapAdi
			// 
			labelKitapAdi.AutoSize = true;
			labelKitapAdi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			labelKitapAdi.ForeColor = Color.FromArgb(128, 64, 0);
			labelKitapAdi.Location = new Point(346, 21);
			labelKitapAdi.Name = "labelKitapAdi";
			labelKitapAdi.Size = new Size(174, 25);
			labelKitapAdi.TabIndex = 46;
			labelKitapAdi.Text = "Aratılan Kitap:";
			// 
			// labelStokAdedi
			// 
			labelStokAdedi.AutoSize = true;
			labelStokAdedi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			labelStokAdedi.ForeColor = Color.FromArgb(128, 64, 0);
			labelStokAdedi.Location = new Point(346, 21);
			labelStokAdedi.Name = "labelStokAdedi";
			labelStokAdedi.Size = new Size(141, 25);
			labelStokAdedi.TabIndex = 38;
			labelStokAdedi.Text = "Stok Adedi:";
			labelStokAdedi.Click += labelStokAdedi_Click;
			// 
			// labelYazarAdi
			// 
			labelYazarAdi.AutoSize = true;
			labelYazarAdi.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			labelYazarAdi.ForeColor = Color.FromArgb(128, 64, 0);
			labelYazarAdi.Location = new Point(346, 25);
			labelYazarAdi.Name = "labelYazarAdi";
			labelYazarAdi.Size = new Size(90, 25);
			labelYazarAdi.TabIndex = 36;
			labelYazarAdi.Text = "Yazar :";
			// 
			// labelIsbn
			// 
			labelIsbn.AutoSize = true;
			labelIsbn.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			labelIsbn.ForeColor = Color.FromArgb(128, 64, 0);
			labelIsbn.Location = new Point(346, 17);
			labelIsbn.Name = "labelIsbn";
			labelIsbn.Size = new Size(141, 25);
			labelIsbn.TabIndex = 34;
			labelIsbn.Text = "ISBN Kodu:";
			// 
			// panel1
			// 
			panel1.BackColor = Color.PeachPuff;
			panel1.Controls.Add(label2);
			panel1.Controls.Add(labelKitapAdi);
			panel1.Location = new Point(32, 12);
			panel1.Name = "panel1";
			panel1.Size = new Size(618, 73);
			panel1.TabIndex = 47;
			// 
			// panel2
			// 
			panel2.BackColor = Color.PeachPuff;
			panel2.Controls.Add(label3);
			panel2.Controls.Add(labelYazarAdi);
			panel2.Location = new Point(32, 196);
			panel2.Name = "panel2";
			panel2.Size = new Size(618, 69);
			panel2.TabIndex = 48;
			// 
			// panel5
			// 
			panel5.BackColor = Color.PeachPuff;
			panel5.Controls.Add(label4);
			panel5.Controls.Add(labelStokAdedi);
			panel5.Location = new Point(32, 289);
			panel5.Name = "panel5";
			panel5.Size = new Size(615, 68);
			panel5.TabIndex = 48;
			// 
			// panel6
			// 
			panel6.BackColor = Color.PeachPuff;
			panel6.Controls.Add(label1);
			panel6.Controls.Add(labelIsbn);
			panel6.Location = new Point(32, 108);
			panel6.Name = "panel6";
			panel6.Size = new Size(618, 67);
			panel6.TabIndex = 48;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.ForeColor = Color.FromArgb(128, 64, 0);
			label1.Location = new Point(18, 17);
			label1.Name = "label1";
			label1.Size = new Size(141, 25);
			label1.TabIndex = 35;
			label1.Text = "ISBN Kodu:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.ForeColor = Color.FromArgb(128, 64, 0);
			label2.Location = new Point(21, 21);
			label2.Name = "label2";
			label2.Size = new Size(174, 25);
			label2.TabIndex = 47;
			label2.Text = "Aratılan Kitap:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label3.ForeColor = Color.FromArgb(128, 64, 0);
			label3.Location = new Point(21, 25);
			label3.Name = "label3";
			label3.Size = new Size(90, 25);
			label3.TabIndex = 37;
			label3.Text = "Yazar :";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label4.ForeColor = Color.FromArgb(128, 64, 0);
			label4.Location = new Point(18, 21);
			label4.Name = "label4";
			label4.Size = new Size(141, 25);
			label4.TabIndex = 39;
			label4.Text = "Stok Adedi:";
			// 
			// KitapDetay
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 64, 0);
			ClientSize = new Size(662, 405);
			Controls.Add(panel5);
			Controls.Add(panel6);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "KitapDetay";
			Text = "Aratılan Kitap";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label labelKitapAdi;
		private Label labelStokAdedi;
		private Label labelYazarAdi;
		private Label labelIsbn;
		private Panel panel1;
		private Panel panel2;
		private Panel panel5;
		private Panel panel6;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label1;
	}
}