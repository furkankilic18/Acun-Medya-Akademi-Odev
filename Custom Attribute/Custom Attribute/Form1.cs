namespace Custom_Attribute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazd�r_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci1 = new Ogrenci
            {
                Department = txtBolum.Text,
                name = txtAd.Text,
                lastName = txtSoyad.Text,
            };

            lblKisiBilgileri.Text = $"Ad� : {txtAd.Text} \nSoyad�: {txtSoyad.Text} \nB�l�m�: {txtBolum.Text}";

            if (ZorunlulukKontrolu.dogrula(ogrenci1, out List<string> hatalar))
            {
                MessageBox.Show("Kay�t ba�ar�l�!");
            }
            else
            {
                MessageBox.Show("Hatalar:\n" + string.Join("\n", hatalar));
            }
        }
    }
}
