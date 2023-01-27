namespace harjoitus4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttarit = synttariAika.Value;
            DateTime aikanyt = DateTime.Now;
            double erotus = Math.Round((aikanyt - synttarit).TotalDays);

            vuodetLB.Visible = true;
            vuodetLB.Text = Math.Floor(erotus / 365.25) + " vuotta";

            kuukaudetLB.Visible = true;
            kuukaudetLB.Text = Math.Ceiling((erotus * 12) / 365.25) + " kuukautta";

            paivatLB.Visible = true;
            paivatLB.Text = erotus + " P‰iv‰‰";

            tunnitLB.Visible = true;
            tunnitLB.Text = (erotus * 24) + " Tuntia";

            minuutitLB.Visible = true;
            minuutitLB.Text = (erotus * 24 * 60) + " Minuuttia";

            sekunnitLB.Visible = true;
            sekunnitLB.Text = (erotus * 24 * 60 * 60) + " Sekunttia";
        }
    }
}