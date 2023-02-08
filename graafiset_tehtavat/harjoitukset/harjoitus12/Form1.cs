namespace harjoitus12
{
    public partial class Form1 : Form
    {
        //string taulukkomuuttuja, johon lis‰t‰‰n vastaukset
        string[] vastaukset = new string[11];

        //string taulukkomuuttuja, johon on lis‰tty omavalintaiset oikeat vastaukset
        string[] oikeat = new string[11] {"", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };

        //int laskuri muuttuja, johon lis‰t‰‰n vastattujen kysymysten lukum‰‰r‰
        int laskuri = 0;

        //int oikein muuttuja, johon lis‰t‰‰n vastauksista oikeat vastaukset plussaamalla yksi
        int oikein = 0;

        //lis‰t‰‰n alla uusi eventhandler, jolla ajetaan alempana tehty funktio, joka kerta kun checkki muuttuu jossakin vastauksessa.
        public Form1()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausBRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausCRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            VastausDRB.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // itse funktio, joka ajetaan joka kerta kun vastausta klikataan.
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri <= 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                KysymysLB.Text = "Vastaus " + (laskuri) + ". Kysymykseen";
                laskuri++;
            }
            else
            {
                VastausLB.Text = "";
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                for(int i = 1; i <= 10; i++)
                {
                    if (vastaukset[i] == oikeat[i])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            //tyhj‰t‰‰n vastaus joka kerta kun checkedchanged, eli klikattu vastausta
            TyhjaaVastaus();
        }

        //tyhj‰t‰‰n edellinen vastaus t‰ss‰ funktiolla
        private void TyhjaaVastaus()
        {
            if(VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }
            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}