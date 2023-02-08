namespace harjoitus13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastusBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;

            //haetaan ladatut tiedostot tytot.txt ja pojat.txt muuttujiin
            string[] pojat = File.ReadAllLines("E:/koulutehtävät/Ohjelmointi/c_sharp_koulu/c_sharp_koulu/graafiset_tehtavat/harjoitukset/harjoitus13/pojat.txt");
            string[] tytot = File.ReadAllLines("E:/koulutehtävät/Ohjelmointi/c_sharp_koulu/c_sharp_koulu/graafiset_tehtavat/harjoitukset/harjoitus13/tytot.txt");

            string nimi = NimenSyottoTB.Text;



            int laskurip = 1;
            int laskurit = 1;
            foreach(string poika in pojat)
            {
                if (nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ".suosituin poikien nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach(string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta";
                VastausLB.Visible = true;
            }

        }
    }
}