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

            //testataan ensiksi, onko tekstikent�ss� mit��n tai onko radiobuttonit tyhji� tai onko
            //tekstikentt��n sy�tetty muutakuin numeroita(double tyyppisi� numeroita t�ss� tapauksessa)
            if ((AsteenSyottoTB.Text.Length <= 0) || (!CelsiusRB.Checked && !FahrenheitRB.Checked) || (double.TryParse(AsteenSyottoTB.Text, out double n) == false))
            {
                VastausLB.Text = "Sinulta puuttuu luku tai yksikk� tai olet sy�tt�nyt luvun sijasta kirjaimia";
                VastausLB.Visible = true;
            }
            else
            {
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
            }
        }
    }
}