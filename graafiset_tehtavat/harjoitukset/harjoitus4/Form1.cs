namespace harjoitus4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DateTime synttarit = syntymaAika.Value;
            DateTime aikaNyt = DateTime.Now;
            double erotus = Math.Round((aikaNyt - synttarit).TotalDays);

            vuodetLB.Text = Math.Ceiling(erotus / 365.25) + " Vuotta";
        }
    }
}