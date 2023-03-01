using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harjoitus20
{
    public partial class Form1 : Form
    {
        ASIAKAS opiskelija = new ASIAKAS();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGrid.DataSource = opiskelija.haeOpiskelijat();
        }

        //tyhjennä nappi
        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            EtunimiTB.Text = "";
            SukunimiTB.Text = "";
            PuhelinTB.Text = "";
            MailTB.Text = "";
            NroTB.Text = "";
        }
        
        //tallenna nappi
        private void TallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String puhelin = PuhelinTB.Text;
            String mail = MailTB.Text;
            int oNro = Int32.Parse(NroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || mail.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE Täytä kaikki kentät paitsi ID", "Tyhjä Kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, mail, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty lisäämään", "Opiskelijan Lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            DataGrid.DataSource = opiskelija.haeOpiskelijat();
        }
        //päivitä nappi.
        private void PaivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = EtunimiTB.Text;
            String snimi = SukunimiTB.Text;
            String puhelin = PuhelinTB.Text;
            String mail = MailTB.Text;
            int oNro = int.Parse(NroTB.Text);
            int oid = Int32.Parse(IdTB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || mail.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE Täytä kaikki kentät paitsi ID", "Tyhjä Kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, mail, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DataGrid.DataSource = opiskelija.haeOpiskelijat();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = IdTB.Text;
            if(opiskelija.poistaOpiskelija(ktunnus))
            {
                DataGrid.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else
            {
                MessageBox.Show("Opiskelija ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = DataGrid.CurrentRow.Cells[0].Value.ToString();
            EtunimiTB.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
            SukunimiTB.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
            PuhelinTB.Text = DataGrid.CurrentRow.Cells[3].Value.ToString();
            MailTB.Text = DataGrid.CurrentRow.Cells[4].Value.ToString();
            NroTB.Text = DataGrid.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
