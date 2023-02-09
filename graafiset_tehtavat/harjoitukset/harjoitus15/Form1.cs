using System.Diagnostics;


namespace harjoitus15
{
    public partial class Form1 : Form
    {
        private Stopwatch sekkari = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }
        private void StartBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }
        private void StopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Stopwatch sekkari = new Stopwatch();
        }

        private void Ajastin_Tick(object sender, EventArgs e)
        {
            AjastinLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }


    }
}