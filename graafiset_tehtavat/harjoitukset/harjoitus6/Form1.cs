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
            //M‰‰ritet‰‰n if:n sis‰‰n haluttu salasana, joka samalla tarkistetaan, ja jos se on oikein, laitetaan jatkopaneeli n‰kyv‰ksi
            if (kayttajaTB.Text == "Petri" && salasanaTB.Text == "J@K3KuLTa")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }

            // muussa tapauksessa ilmoitetaan v‰‰r‰st‰ salasanasta tai k‰ytt‰j‰tunnuksesta
            else
            {
                virheviestiLB.Text = "V‰‰r‰ Salasana tai k‰ytt‰j‰tunnus";
                virheviestiLB.Visible = true;
            }
        }
    }
}