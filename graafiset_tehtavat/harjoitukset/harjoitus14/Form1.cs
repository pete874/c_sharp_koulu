namespace harjoitus14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //luetaan ensiksi tiedoston sis�lt� ja tallennetaan muuttujaan.
            string teksti = File.ReadAllText("c:\\temp\\temp.txt");
            //lis�t��n muuttujan tekstisis�lt� sy�tt� textboxiin.
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

            // p�ivitet��n tallennettu teksti suoraan n�yt�lle napin painalluksesta
            SyottoTB.Text = teksti;
        }

        private void SuljeBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}