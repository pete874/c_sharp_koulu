namespace harjoitus11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void heittoBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(noppa01PB);
            piirraNoppa(noppa02PB);
            piirraNoppa(noppa03PB);
            piirraNoppa(noppa04PB);
            piirraNoppa(noppa05PB);
            piirraNoppa(noppa06PB);
            piirraNoppa(noppa07PB);
            piirraNoppa(noppa08PB);
            piirraNoppa(noppa09PB);
            piirraNoppa(noppa10PB);  
            //Vastaus dian kysymykseen, kuinka monta rivi‰ tarvitaan koodia,
            //jos noppien m‰‰r‰ lis‰tt‰isi viiteen, on 3. Voimme k‰ytt‰‰ samaa metodia jokaiseen.
        }

        private void piirraNoppa(PictureBox NoppaBox)
        {
            Random satunnainen = new Random();    // Tallennetaan RNG muuttujaan
            int noppa = satunnainen.Next(1, 7);   // Tallennetaan noppa muuttujaan random kokonaislukujen range Nextill‰. 

            switch (noppa)
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.dice01;
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.dice06;
                    break;
            }
        }
    }
}