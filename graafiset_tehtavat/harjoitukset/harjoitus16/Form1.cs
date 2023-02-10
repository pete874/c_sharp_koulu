using System.Diagnostics;


namespace harjoitus16
{
    public partial class AjastinForm : Form
    {
        private int kokonaisaika;
        public AjastinForm()
        {
            InitializeComponent();
        }

        private void AjastinForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;

            for(int i = 0; i < 60; i++)
            {
                MinutesCB.Items.Add(i.ToString()); //minuutit stringeiksi muutettuna comboboksiin
                SecondsCB.Items.Add(i.ToString());  //sekunniks stringeinä comboboksiin
            }

            MinutesCB.SelectedIndex = 0;
            SecondsCB.SelectedIndex = 20;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;

            int minuutit = int.Parse(MinutesCB.SelectedItem.ToString());
            int sekunnit = int.Parse(SecondsCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            TimerTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            TimerTM.Enabled = false;
            TimerLB.Text = "00:00";
        }

        private void TimerTM_Tick_1(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                TimerLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                TimerTM.Stop();
                MessageBox.Show("Aikasi loppui");
            }
        }
    }
}