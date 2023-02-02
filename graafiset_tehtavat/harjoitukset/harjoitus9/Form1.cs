namespace harjoitus9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteenSyottoTB.Text);


            if (CelsiusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                VastausLB.Text = asteet + " celsiusta on " + vastaus + " fahrenheit-astetta";
                VastausLB.Visible = true;
            }

            else if (FahrenheitRB.Checked)
            {
                vastaus = (asteet - 32) / 1.8;
                VastausLB.Text = asteet + " fahrenheittia on " + vastaus + " celsius-astetta";
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Syötä luku";
                VastausLB.Visible = true;
            }
        }
    }
}