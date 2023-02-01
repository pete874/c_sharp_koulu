namespace harjoitus8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4;
            string vastaus = "";

            if(NumeroTB.Text.Length > 3 ) //tuhannet
            {
                luku1 = Convert.ToInt32(NumeroTB.Text.Substring(0, 1));
                luku2 = Convert.ToInt32(NumeroTB.Text.Substring(1, 1));
                luku3 = Convert.ToInt32(NumeroTB.Text.Substring(2, 1));
                luku4 = Convert.ToInt32(NumeroTB.Text.Substring(3, 1));

                if (luku1 % 3 == 0)
                {
                    vastaus += "MMM";
                }
                else if(luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if (luku1 % 1 == 0)
                {
                    vastaus += "M";
                }
                else
                {
                    vastaus += "";
                }
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if(NumeroTB.Text.Length > 2) //sataset
            {
                luku2 = Convert.ToInt32(NumeroTB.Text.Substring(0, 1));
                luku3 = Convert.ToInt32(NumeroTB.Text.Substring(1, 1));
                luku4 = Convert.ToInt32(NumeroTB.Text.Substring(2, 1));
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if(NumeroTB.Text.Length > 1) //kympit
            {
                luku3 = Convert.ToInt32(NumeroTB.Text.Substring(0, 1));
                luku4 = Convert.ToInt32(NumeroTB.Text.Substring(1, 1));
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if(NumeroTB.Text.Length > 0) //yköset
            {
                luku4 = Convert.ToInt32(NumeroTB.Text.Substring(0, 1));
                vastaus += ykkoset(luku4, vastaus);
            }
            VastausLB.Text = vastaus;
            VastausLB.Visible = true;
        }
        // alhaalle stringit ykkösille,kympeille ja satasille
        private string sataset(int luku2, string vastaus)
        {
            if(luku2 % 9 == 0 && luku2 != 0)
            {
                return "CM";
            }
            else if (luku2 % 8 == 0 && luku2 != 0)
            {
                return "DCCC";
            }
            else if (luku2 % 7 == 0 && luku2 != 0)
            {
                return "DCC";
            }
            else if (luku2 % 6 == 0 && luku2 != 0)
            {
                return "DC";
            }
            else if (luku2 % 5 == 0 && luku2 != 0)
            {
                return "D";
            }
            else if (luku2 % 4 == 0 && luku2 != 0)
            {
                return "CD";
            }
            else if (luku2 % 3 == 0 && luku2 != 0)
            {
                return "CCC";
            }
            else if (luku2 % 2 == 0 && luku2 != 0)
            {
                return "CC";
            }
            else if (luku2 % 1 == 0 && luku2 != 0)
            {
                return "C";
            }
            else
            {
                return "";
            }
        }
    }
}