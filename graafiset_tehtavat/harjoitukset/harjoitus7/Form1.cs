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
            double laina, nesteet, vakuutusmaksut, muut, pesut, huollot, renkaat, kilometrit, lopputulos;
            laina = Convert.ToDouble(LainanLyhennysTB.Text);
            nesteet = Convert.ToDouble(LisattavatNesteetTB.Text);
            vakuutusmaksut = Convert.ToDouble(VakuutusmaksutTB.Text);
            muut = Convert.ToDouble(MuutKulutTB.Text);
            pesut = Convert.ToDouble(PesutTB.Text);
            huollot = Convert.ToDouble(HuollotTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            kilometrit = Convert.ToDouble(KilometritVuosiCB.Text);
            lopputulos = (laina + nesteet + vakuutusmaksut + muut + pesut + huollot + renkaat) / (kilometrit / 12);
            KustannuksetLB.Text = "Kustannukset kilometriä kohden ovat " + lopputulos + "€";
            KustannuksetLB.Visible = true;
        }
    }
}