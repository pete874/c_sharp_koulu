namespace harjoitus10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = Convert.ToDouble(PainoTB.Text);
            double pituus = Convert.ToDouble(PituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);
            VastausLB.Text = "Painoindeksisi on " + bmi;
            VastausLB.Visible = true;
        }
    }
}