namespace harjoitus2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = viestiTB.Text;
            tulostusLB.Text = teksti;
            tulostusLB.Visible = true;
        }
    }
}