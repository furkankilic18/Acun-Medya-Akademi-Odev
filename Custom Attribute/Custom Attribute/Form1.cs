namespace Custom_Attribute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdýr_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci1 = new Ogrenci
            {
                Department = txtBolum.Text,
                name = txtAd.Text,
                lastName = txtSoyad.Text,
            };

            lblKisiBilgileri.Text = $"Adý : {txtAd.Text} \nSoyadý: {txtSoyad.Text} \nBölümü: {txtBolum.Text}";

            if (ZorunlulukKontrolu.dogrula(ogrenci1, out List<string> hatalar))
            {
                MessageBox.Show("Kayýt baþarýlý!");
            }
            else
            {
                MessageBox.Show("Hatalar:\n" + string.Join("\n", hatalar));
            }
        }
    }
}
