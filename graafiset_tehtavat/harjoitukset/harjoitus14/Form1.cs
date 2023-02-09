namespace harjoitus14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //luetaan ensiksi tiedoston sisältö ja tallennetaan muuttujaan.
            string teksti = File.ReadAllText("c:\\temp\\temp.txt");
            //lisätään muuttujan tekstisisältö syöttö textboxiin.
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("c:\\temp\\temp.txt");
            text.Write(teksti);
            text.Close();

            // päivitetään tallennettu teksti suoraan näytölle napin painalluksesta
            SyottoTB.Text = teksti;
        }

        private void SuljeBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}