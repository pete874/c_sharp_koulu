namespace harjoitus6
{
    public partial class SalasananTarkistus : Form
    {
        public SalasananTarkistus()
        {
            InitializeComponent();
        }

        private void tarkistaBT_Click(object sender, EventArgs e)
        {
            //Määritetään if:n sisään haluttu salasana, joka samalla tarkistetaan, ja jos se on oikein, laitetaan jatkopaneeli näkyväksi
            if (kayttajaTB.Text == "Petri" && salasanaTB.Text == "J@K3KuLTa")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }

            // muussa tapauksessa ilmoitetaan väärästä salasanasta tai käyttäjätunnuksesta
            else
            {
                virheviestiLB.Text = "Väärä Salasana tai käyttäjätunnus";
                virheviestiLB.Visible = true;
            }
        }
    }
}