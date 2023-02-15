using System.Drawing.Printing;
using System.IO;
namespace harjoitus17
{
    public partial class Muistio : Form
    {
        string tiedostopolku = "";
        public Muistio()
        {
            InitializeComponent();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(TekstilaatikkoTB.Text != "")
            {
                tallennaToolStripMenuItem_Click(sender, e);
                TekstilaatikkoTB.Text = "";
            }
            else
            {
                TekstilaatikkoTB.Text = "";
            }
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // lis‰t‰‰n filteriin txt tiedostot pudotusvalikkoon, niin n‰hd‰‰n listalta tarvittaessa myˆs .txt p‰‰tteiset tiedostot
            using (OpenFileDialog atk = new OpenFileDialog() { Filter = "Rikastetekstiformaatti|*.rtf|TextDocument|.*txt", ValidateNames = true, Multiselect = false })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader jonolukija = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> text = jonolukija.ReadToEndAsync();
                        TekstilaatikkoTB.Text = text.Result;
                    }
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tiedostopolku))
            {
                using(SaveFileDialog ttk = new SaveFileDialog() {Filter = "Rikastetekstiformaatti|*.rtf|Tekstiformaatti|*.txt", ValidateNames=true})
                {
                    if(ttk.ShowDialog() == DialogResult.OK)
                    {
                        using(StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                        {
                            jonokirjoittaja.WriteLineAsync(TekstilaatikkoTB.Rtf);
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter jonokirjoittaja = new StreamWriter(tiedostopolku))
                {
                    jonokirjoittaja.WriteLineAsync(TekstilaatikkoTB.Rtf);
                }
            }
        }

        private void tallennaNimell‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog ttk = new SaveFileDialog() { Filter = "Rikastetekstiformaatti|*.rtf|Tekstiformaatti|*.txt", ValidateNames=true})
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    using(StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLine(TekstilaatikkoTB.Rtf);
                    }
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoTB.Cut();
        }

        private void liit‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoTB.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoTB.SelectAll();
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TekstilaatikkoTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinKorostusToolStripMenuItem.Checked == true)
            {
                tekstinKorostusToolStripMenuItem.Checked = false;
                TekstilaatikkoTB.SelectionBackColor = Color.Transparent;
            }
            else
            {
                tekstinKorostusToolStripMenuItem.Checked = true;
                TekstilaatikkoTB.SelectionBackColor = Color.Yellow;
            }
        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivitysToolStripMenuItem.Checked == true)
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                TekstilaatikkoTB.WordWrap = false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                TekstilaatikkoTB.WordWrap = true; 
            }
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tietoa tietoa = new tietoa();
            tietoa.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TekstilaatikkoTB.Text, TekstilaatikkoTB.Font, Brushes.Black, 12, 10);
        }

        private void TekstilaatikkoTB_TextChanged(object sender, EventArgs e)
        {
            if(TekstilaatikkoTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }
    }
}