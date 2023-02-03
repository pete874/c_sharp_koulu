namespace harjoitus7
{
    public partial class KuluLaskuri : Form
    {
        public KuluLaskuri()
        {
            InitializeComponent();
        }
        private void KilometritVuosiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //luodaan textboxeille muuttujat
            double laina, nesteet, vakuutusmaksut, muut, pesut, huollot, renkaat, kilometrit, lopputulos;

            // Convertoidaan textboxien stringi double numeroksi
            laina = Convert.ToDouble(LainanLyhennysTB.Text);
            nesteet = Convert.ToDouble(LisattavatNesteetTB.Text);
            vakuutusmaksut = Convert.ToDouble(VakuutusmaksutTB.Text);
            muut = Convert.ToDouble(MuutKulutTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            kilometrit = Convert.ToDouble(KilometritVuosiCB.Text);

            // Ja sitten lasketaan laskutoimitus ja tulostetaan sen kustannukset labeliin
            lopputulos = (laina + nesteet + vakuutusmaksut + muut + pesut + huollot + renkaat) / (kilometrit / 12);
            KustannuksetLB.Text = "Kustannukset kilometriä kohden ovat " + lopputulos + "€";
            KustannuksetLB.Visible = true;
        }
    }
}