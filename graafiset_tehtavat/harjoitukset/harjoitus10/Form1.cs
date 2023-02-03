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


            if (bmi < 18.5)
            {
                VastausLB.Text = "Painoindeksisi on " + bmi;
                VastausLB.Visible = true;
                Vastaus2LB.Text = "Alipaino";
                Vastaus2LB.ForeColor = Color.Yellow;
                Vastaus2LB.Visible = true;
            }

            else if (bmi < 25)
            {
                VastausLB.Text = "Painoindeksisi on " + bmi;
                VastausLB.Visible = true;
                Vastaus2LB.Text = "Normaalipaino";
                Vastaus2LB.ForeColor = Color.LightGreen;
                Vastaus2LB.Visible = true;
            }

            else if (bmi < 40)
            {
                VastausLB.Text = "Painoindeksisi on " + bmi;
                VastausLB.Visible = true;
                Vastaus2LB.Text = "Ylipaino";
                Vastaus2LB.ForeColor = Color.OrangeRed;
                Vastaus2LB.Visible = true;
            }

            else
            {
                VastausLB.Text = "Painoindeksisi on " + bmi;
                VastausLB.Visible = true;
                Vastaus2LB.Text = "Huomattava ylipaino";
                Vastaus2LB.ForeColor = Color.Red;
                Vastaus2LB.Visible = true;
            }
        }
    }
}