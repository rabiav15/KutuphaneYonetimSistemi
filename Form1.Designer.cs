namespace KutuphaneYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			mailtextbox = new TextBox();
			girisyapbutton = new Button();
			panel1 = new Panel();
			sonuclabel = new Label();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(44, 52);
			label1.Name = "label1";
			label1.Size = new Size(459, 34);
			label1.TabIndex = 0;
			label1.Text = "Kütüphane Yönetim Sistemi";
			label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// mailtextbox
			// 
			mailtextbox.Location = new Point(56, 131);
			mailtextbox.Name = "mailtextbox";
			mailtextbox.Size = new Size(425, 31);
			mailtextbox.TabIndex = 1;
			// 
			// girisyapbutton
			// 
			girisyapbutton.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			girisyapbutton.ForeColor = SystemColors.ControlText;
			girisyapbutton.Location = new Point(56, 225);
			girisyapbutton.Name = "girisyapbutton";
			girisyapbutton.Size = new Size(425, 65);
			girisyapbutton.TabIndex = 2;
			girisyapbutton.Text = "Giriş Yap";
			girisyapbutton.UseVisualStyleBackColor = true;
			girisyapbutton.Click += girisyapbutton_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Bisque;
			panel1.Controls.Add(sonuclabel);
			panel1.Location = new Point(56, 347);
			panel1.Name = "panel1";
			panel1.Size = new Size(425, 249);
			panel1.TabIndex = 3;
			panel1.Paint += panel1_Paint;
			// 
			// sonuclabel
			// 
			sonuclabel.AutoSize = true;
			sonuclabel.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
			sonuclabel.Location = new Point(94, 99);
			sonuclabel.Name = "sonuclabel";
			sonuclabel.Size = new Size(0, 25);
			sonuclabel.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(532, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(436, 584);
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 64, 64);
			BackgroundImageLayout = ImageLayout.Center;
			ClientSize = new Size(1078, 629);
			Controls.Add(pictureBox1);
			Controls.Add(panel1);
			Controls.Add(girisyapbutton);
			Controls.Add(mailtextbox);
			Controls.Add(label1);
			Name = "Form1";
			Text = "KütüphaneYonetimSistemi";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox mailtextbox;
		private Button girisyapbutton;
		private Panel panel1;
		private Label sonuclabel;
		private PictureBox pictureBox1;
	}
}
