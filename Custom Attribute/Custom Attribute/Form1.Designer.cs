namespace Custom_Attribute
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
            lblKisiBilgileri = new Label();
            lblAd = new Label();
            lblSoyad = new Label();
            lblbolum = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            btnYazdır = new Button();
            SuspendLayout();
            // 
            // lblKisiBilgileri
            // 
            lblKisiBilgileri.AutoSize = true;
            lblKisiBilgileri.Location = new Point(316, 302);
            lblKisiBilgileri.Name = "lblKisiBilgileri";
            lblKisiBilgileri.Size = new Size(0, 15);
            lblKisiBilgileri.TabIndex = 15;
            lblKisiBilgileri.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(243, 154);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(25, 15);
            lblAd.TabIndex = 14;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(224, 185);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(42, 15);
            lblSoyad.TabIndex = 13;
            lblSoyad.Text = "Soyad:";
            // 
            // lblbolum
            // 
            lblbolum.AutoSize = true;
            lblbolum.Location = new Point(222, 216);
            lblbolum.Name = "lblbolum";
            lblbolum.Size = new Size(45, 15);
            lblbolum.TabIndex = 12;
            lblbolum.Text = "Bölüm:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(297, 151);
            txtAd.Margin = new Padding(3, 2, 3, 2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(176, 23);
            txtAd.TabIndex = 11;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(297, 182);
            txtSoyad.Margin = new Padding(3, 2, 3, 2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(176, 23);
            txtSoyad.TabIndex = 10;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(297, 216);
            txtBolum.Margin = new Padding(3, 2, 3, 2);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(176, 23);
            txtBolum.TabIndex = 9;
            // 
            // btnYazdır
            // 
            btnYazdır.Location = new Point(332, 254);
            btnYazdır.Margin = new Padding(3, 2, 3, 2);
            btnYazdır.Name = "btnYazdır";
            btnYazdır.Size = new Size(66, 35);
            btnYazdır.TabIndex = 8;
            btnYazdır.Text = "Yazdır";
            btnYazdır.UseVisualStyleBackColor = true;
            btnYazdır.Click += btnYazdır_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKisiBilgileri);
            Controls.Add(lblAd);
            Controls.Add(lblSoyad);
            Controls.Add(lblbolum);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtBolum);
            Controls.Add(btnYazdır);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKisiBilgileri;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblbolum;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Button btnYazdır;
    }
}
