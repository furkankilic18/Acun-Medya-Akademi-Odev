namespace Windows_Form_Uygulaması_ile_Araba_Bilgi_Formu___SL
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
            buttonBilgileriGoster = new Button();
            MessageBox = new TextBox();
            cmbPencereSayisi = new ComboBox();
            cmbKapiSayisi = new ComboBox();
            cmbMarka = new ComboBox();
            txtbYakitMiktari = new TextBox();
            txtbRenk = new TextBox();
            txtbModel = new TextBox();
            lblYakitMiktari = new Label();
            lblPencereSayisi = new Label();
            lblKapiSayisi = new Label();
            lblRenk = new Label();
            lblModel = new Label();
            lblMarka = new Label();
            SuspendLayout();
            // 
            // buttonBilgileriGoster
            // 
            buttonBilgileriGoster.Location = new Point(348, 364);
            buttonBilgileriGoster.Name = "buttonBilgileriGoster";
            buttonBilgileriGoster.Size = new Size(104, 23);
            buttonBilgileriGoster.TabIndex = 30;
            buttonBilgileriGoster.Text = "Bilgileri Göster";
            buttonBilgileriGoster.UseVisualStyleBackColor = true;
            buttonBilgileriGoster.Click += buttonKayit_Click;
            // 
            // MessageBox
            // 
            MessageBox.BackColor = SystemColors.HighlightText;
            MessageBox.Location = new Point(76, 321);
            MessageBox.Name = "MessageBox";
            MessageBox.Size = new Size(648, 23);
            MessageBox.TabIndex = 29;
            // 
            // cmbPencereSayisi
            // 
            cmbPencereSayisi.FormattingEnabled = true;
            cmbPencereSayisi.Items.AddRange(new object[] { "--Seçiniz", "0", "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbPencereSayisi.Location = new Point(326, 227);
            cmbPencereSayisi.Name = "cmbPencereSayisi";
            cmbPencereSayisi.Size = new Size(149, 23);
            cmbPencereSayisi.TabIndex = 28;
            // 
            // cmbKapiSayisi
            // 
            cmbKapiSayisi.FormattingEnabled = true;
            cmbKapiSayisi.Items.AddRange(new object[] { "--Seçiniz", "0", "1", "2", "3", "4", "5", "6", "7", "8" });
            cmbKapiSayisi.Location = new Point(326, 186);
            cmbKapiSayisi.Name = "cmbKapiSayisi";
            cmbKapiSayisi.Size = new Size(149, 23);
            cmbKapiSayisi.TabIndex = 27;
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Items.AddRange(new object[] { "--Seçiniz", "Audi", "BMW", "Chevrolet", "Fiat", "Ford", "Honda", "Hyundai", "Kia", "Mazda", "Mercedes", "Nissan", "Opel", "Peugeot", "Renault", "Seat", "Skoda", "Tesla", "Toyota", "Volkswagen", "Volvo" });
            cmbMarka.Location = new Point(326, 63);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(149, 23);
            cmbMarka.TabIndex = 26;
            // 
            // txtbYakitMiktari
            // 
            txtbYakitMiktari.Location = new Point(326, 268);
            txtbYakitMiktari.Name = "txtbYakitMiktari";
            txtbYakitMiktari.Size = new Size(149, 23);
            txtbYakitMiktari.TabIndex = 25;
            // 
            // txtbRenk
            // 
            txtbRenk.Location = new Point(326, 140);
            txtbRenk.Name = "txtbRenk";
            txtbRenk.Size = new Size(149, 23);
            txtbRenk.TabIndex = 24;
            // 
            // txtbModel
            // 
            txtbModel.Location = new Point(326, 99);
            txtbModel.Name = "txtbModel";
            txtbModel.Size = new Size(149, 23);
            txtbModel.TabIndex = 23;
            // 
            // lblYakitMiktari
            // 
            lblYakitMiktari.AutoSize = true;
            lblYakitMiktari.Location = new Point(177, 271);
            lblYakitMiktari.Name = "lblYakitMiktari";
            lblYakitMiktari.Size = new Size(128, 15);
            lblYakitMiktari.TabIndex = 22;
            lblYakitMiktari.Text = "100 km'de yaktığı litre :";
            // 
            // lblPencereSayisi
            // 
            lblPencereSayisi.AutoSize = true;
            lblPencereSayisi.Location = new Point(218, 230);
            lblPencereSayisi.Name = "lblPencereSayisi";
            lblPencereSayisi.Size = new Size(87, 15);
            lblPencereSayisi.TabIndex = 21;
            lblPencereSayisi.Text = "Pencere Sayısı :";
            // 
            // lblKapiSayisi
            // 
            lblKapiSayisi.AutoSize = true;
            lblKapiSayisi.Location = new Point(237, 189);
            lblKapiSayisi.Name = "lblKapiSayisi";
            lblKapiSayisi.Size = new Size(68, 15);
            lblKapiSayisi.TabIndex = 20;
            lblKapiSayisi.Text = "Kapı Sayısı :";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(266, 148);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(39, 15);
            lblRenk.TabIndex = 19;
            lblRenk.Text = "Renk :";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(258, 107);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(47, 15);
            lblModel.TabIndex = 18;
            lblModel.Text = "Model :";
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(259, 66);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(46, 15);
            lblMarka.TabIndex = 17;
            lblMarka.Text = "Marka :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBilgileriGoster);
            Controls.Add(MessageBox);
            Controls.Add(cmbPencereSayisi);
            Controls.Add(cmbKapiSayisi);
            Controls.Add(cmbMarka);
            Controls.Add(txtbYakitMiktari);
            Controls.Add(txtbRenk);
            Controls.Add(txtbModel);
            Controls.Add(lblYakitMiktari);
            Controls.Add(lblPencereSayisi);
            Controls.Add(lblKapiSayisi);
            Controls.Add(lblRenk);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBilgileriGoster;
        private TextBox MessageBox;
        private ComboBox cmbPencereSayisi;
        private ComboBox cmbKapiSayisi;
        private ComboBox cmbMarka;
        private TextBox txtbYakitMiktari;
        private TextBox txtbRenk;
        private TextBox txtbModel;
        private Label lblYakitMiktari;
        private Label lblPencereSayisi;
        private Label lblKapiSayisi;
        private Label lblRenk;
        private Label lblModel;
        private Label lblMarka;
    }
}
