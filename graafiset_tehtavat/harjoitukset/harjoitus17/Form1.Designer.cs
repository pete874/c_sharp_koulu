﻿namespace harjoitus17
{
    partial class Muistio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Muistio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaNimelläToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tulostuksenEsikatseluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tulostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muotoileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.kopioiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leikkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liitäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valitseKaikkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinKorostusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinRivitysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TekstilaatikkoTB = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menusToolStripMenuItem,
            this.muotoileToolStripMenuItem,
            this.apuaToolStripMenuItem,
            this.apuaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menusToolStripMenuItem
            // 
            this.menusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiToolStripMenuItem,
            this.avaaToolStripMenuItem,
            this.tallennaToolStripMenuItem,
            this.tallennaNimelläToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tulostuksenEsikatseluToolStripMenuItem,
            this.tulostaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.poistuToolStripMenuItem});
            this.menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            this.menusToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.menusToolStripMenuItem.Text = "&Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            this.uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            this.uusiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.uusiToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.uusiToolStripMenuItem.Text = "Uusi";
            this.uusiToolStripMenuItem.Click += new System.EventHandler(this.uusiToolStripMenuItem_Click);
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.avaaToolStripMenuItem.Text = "Avaa";
            this.avaaToolStripMenuItem.Click += new System.EventHandler(this.avaaToolStripMenuItem_Click);
            // 
            // tallennaToolStripMenuItem
            // 
            this.tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            this.tallennaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tallennaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.tallennaToolStripMenuItem.Text = "Tallenna";
            this.tallennaToolStripMenuItem.Click += new System.EventHandler(this.tallennaToolStripMenuItem_Click);
            // 
            // tallennaNimelläToolStripMenuItem
            // 
            this.tallennaNimelläToolStripMenuItem.Name = "tallennaNimelläToolStripMenuItem";
            this.tallennaNimelläToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.tallennaNimelläToolStripMenuItem.Text = "Tallenna nimellä";
            this.tallennaNimelläToolStripMenuItem.Click += new System.EventHandler(this.tallennaNimelläToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 6);
            // 
            // tulostuksenEsikatseluToolStripMenuItem
            // 
            this.tulostuksenEsikatseluToolStripMenuItem.Name = "tulostuksenEsikatseluToolStripMenuItem";
            this.tulostuksenEsikatseluToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.tulostuksenEsikatseluToolStripMenuItem.Text = "Tulostuksen esikatselu";
            this.tulostuksenEsikatseluToolStripMenuItem.Click += new System.EventHandler(this.tulostuksenEsikatseluToolStripMenuItem_Click);
            // 
            // tulostaToolStripMenuItem
            // 
            this.tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            this.tulostaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tulostaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.tulostaToolStripMenuItem.Text = "Tulosta";
            this.tulostaToolStripMenuItem.Click += new System.EventHandler(this.tulostaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // muotoileToolStripMenuItem
            // 
            this.muotoileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.kopioiToolStripMenuItem,
            this.leikkaaToolStripMenuItem,
            this.liitäToolStripMenuItem,
            this.poistaToolStripMenuItem,
            this.valitseKaikkiToolStripMenuItem});
            this.muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            this.muotoileToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.muotoileToolStripMenuItem.Text = "&Muokkaa";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 6);
            // 
            // kopioiToolStripMenuItem
            // 
            this.kopioiToolStripMenuItem.Name = "kopioiToolStripMenuItem";
            this.kopioiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopioiToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.kopioiToolStripMenuItem.Text = "Kopioi";
            this.kopioiToolStripMenuItem.Click += new System.EventHandler(this.kopioiToolStripMenuItem_Click);
            // 
            // leikkaaToolStripMenuItem
            // 
            this.leikkaaToolStripMenuItem.Name = "leikkaaToolStripMenuItem";
            this.leikkaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.leikkaaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.leikkaaToolStripMenuItem.Text = "Leikkaa";
            this.leikkaaToolStripMenuItem.Click += new System.EventHandler(this.leikkaaToolStripMenuItem_Click);
            // 
            // liitäToolStripMenuItem
            // 
            this.liitäToolStripMenuItem.Name = "liitäToolStripMenuItem";
            this.liitäToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.liitäToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.liitäToolStripMenuItem.Text = "Liitä";
            this.liitäToolStripMenuItem.Click += new System.EventHandler(this.liitäToolStripMenuItem_Click);
            // 
            // poistaToolStripMenuItem
            // 
            this.poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            this.poistaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.poistaToolStripMenuItem.Text = "Poista";
            this.poistaToolStripMenuItem.Click += new System.EventHandler(this.poistaToolStripMenuItem_Click);
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            this.valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            this.valitseKaikkiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.valitseKaikkiToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.valitseKaikkiToolStripMenuItem.Text = "Valitse Kaikki";
            this.valitseKaikkiToolStripMenuItem.Click += new System.EventHandler(this.valitseKaikkiToolStripMenuItem_Click);
            // 
            // apuaToolStripMenuItem
            // 
            this.apuaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kirjasinToolStripMenuItem,
            this.tekstinKorostusToolStripMenuItem,
            this.tekstinRivitysToolStripMenuItem});
            this.apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            this.apuaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.apuaToolStripMenuItem.Text = "M&uotoile";
            // 
            // kirjasinToolStripMenuItem
            // 
            this.kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            this.kirjasinToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kirjasinToolStripMenuItem.Text = "Kirjasin";
            this.kirjasinToolStripMenuItem.Click += new System.EventHandler(this.kirjasinToolStripMenuItem_Click);
            // 
            // tekstinKorostusToolStripMenuItem
            // 
            this.tekstinKorostusToolStripMenuItem.Name = "tekstinKorostusToolStripMenuItem";
            this.tekstinKorostusToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tekstinKorostusToolStripMenuItem.Text = "Tekstin korostus";
            this.tekstinKorostusToolStripMenuItem.Click += new System.EventHandler(this.tekstinKorostusToolStripMenuItem_Click);
            // 
            // tekstinRivitysToolStripMenuItem
            // 
            this.tekstinRivitysToolStripMenuItem.Name = "tekstinRivitysToolStripMenuItem";
            this.tekstinRivitysToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tekstinRivitysToolStripMenuItem.Text = "Tekstin rivitys";
            this.tekstinRivitysToolStripMenuItem.Click += new System.EventHandler(this.tekstinRivitysToolStripMenuItem_Click);
            // 
            // apuaToolStripMenuItem1
            // 
            this.apuaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tietoaToolStripMenuItem});
            this.apuaToolStripMenuItem1.Name = "apuaToolStripMenuItem1";
            this.apuaToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.apuaToolStripMenuItem1.Text = "&Apua";
            // 
            // tietoaToolStripMenuItem
            // 
            this.tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            this.tietoaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.tietoaToolStripMenuItem.Text = "Tietoa";
            this.tietoaToolStripMenuItem.Click += new System.EventHandler(this.tietoaToolStripMenuItem_Click);
            // 
            // TekstilaatikkoTB
            // 
            this.TekstilaatikkoTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TekstilaatikkoTB.Location = new System.Drawing.Point(0, 24);
            this.TekstilaatikkoTB.Name = "TekstilaatikkoTB";
            this.TekstilaatikkoTB.Size = new System.Drawing.Size(800, 426);
            this.TekstilaatikkoTB.TabIndex = 1;
            this.TekstilaatikkoTB.Text = "";
            this.TekstilaatikkoTB.TextChanged += new System.EventHandler(this.TekstilaatikkoTB_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Muistio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TekstilaatikkoTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Muistio";
            this.Text = "Muistio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menusToolStripMenuItem;
        private ToolStripMenuItem uusiToolStripMenuItem;
        private ToolStripMenuItem avaaToolStripMenuItem;
        private ToolStripMenuItem tallennaToolStripMenuItem;
        private ToolStripMenuItem tallennaNimelläToolStripMenuItem;
        private ToolStripMenuItem tulostuksenEsikatseluToolStripMenuItem;
        private ToolStripMenuItem tulostaToolStripMenuItem;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private RichTextBox TekstilaatikkoTB;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem muotoileToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem kopioiToolStripMenuItem;
        private ToolStripMenuItem leikkaaToolStripMenuItem;
        private ToolStripMenuItem liitäToolStripMenuItem;
        private ToolStripMenuItem poistaToolStripMenuItem;
        private ToolStripMenuItem valitseKaikkiToolStripMenuItem;
        private ToolStripMenuItem apuaToolStripMenuItem;
        private ToolStripMenuItem kirjasinToolStripMenuItem;
        private ToolStripMenuItem tekstinKorostusToolStripMenuItem;
        private ToolStripMenuItem tekstinRivitysToolStripMenuItem;
        private ToolStripMenuItem apuaToolStripMenuItem1;
        private ToolStripMenuItem tietoaToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}