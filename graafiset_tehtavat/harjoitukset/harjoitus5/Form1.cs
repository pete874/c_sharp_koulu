namespace harjoitus5
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Enter painalluksen testaus
            if (e.KeyChar == (char)Keys.Enter)
            {
                //-999 numerolla tulostetaan kaikki aikaisemmin jonoon tallennetut numerot
                if (uusiLukuTB.Text == "-999")
                {
                    vastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach(var jasen in taulukko)
                    {
                        vastausLB.Text += jasen + " ";
                    }
                    vastausLB.Visible = true;
                }
                //muussa tapauksessa lis�ill��n jonoon numeroita niin kauan kun k�ytt�j� ei sy�t� numeroa -999
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = "";
                }
            }
            // esc-napilla lomake tyhj�kke
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }
    }
}