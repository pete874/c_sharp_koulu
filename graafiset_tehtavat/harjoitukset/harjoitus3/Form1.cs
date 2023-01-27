namespace harjoitus3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            float luku1 = float.Parse(luku1_field.Text);
            float luku2 = float.Parse(luku2_field.Text);
            float vastaus = 0;
            string lasku = laskun_valinta.Text;
            
            switch(lasku)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;

                case "-":
                    vastaus = luku1 - luku2;
                    break;

                case "*":
                    vastaus = luku1 * luku2;
                    break;

                case "/":
                    vastaus = luku1 / luku2;
                    break;

            }

            tulosLB.Text = Convert.ToString(vastaus);
            tulosLB.Visible = true;
        }
    }
}