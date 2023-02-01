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
            if (kayttajaTB.Text == "Petri" && salasanaTB.Text == "J@K3KuLTa")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                virheviestiLB.Text = "V‰‰r‰ Salasana tai k‰ytt‰j‰tunnus";
                virheviestiLB.Visible = true;
            }
        }
    }
}