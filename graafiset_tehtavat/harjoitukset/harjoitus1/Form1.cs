namespace harjoitus1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nappi_Click(object sender, EventArgs e)
        {
            if (otsikkoLB.Text == "T�m� on otsikko")
            {
                otsikkoLB.Text = "Hei maailma";
            }
            else
            {
                otsikkoLB.Text = "T�m� on otsikko";
            }
        }
    }
}