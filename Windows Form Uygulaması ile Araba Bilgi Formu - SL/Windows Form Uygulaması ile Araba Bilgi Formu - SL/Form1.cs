namespace Windows_Form_Uygulaması_ile_Araba_Bilgi_Formu___SL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            MessageBox.Text = $"100km'de {txtbYakitMiktari.Text}L yakıt tüketen " +
                $"{cmbKapiSayisi.SelectedItem} Kapı, " +
                $"{cmbPencereSayisi.SelectedItem} Pencereli ," +
                $"{txtbRenk.Text} Renk " +
                $"{cmbMarka.SelectedItem} Marka " +
                $"{txtbModel.Text} Model aracınız sisteme kaydedilmiştir";
                
        }
    }
}
