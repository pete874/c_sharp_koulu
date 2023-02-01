namespace harjoitus6
{
    partial class SalasananTarkistus
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
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.virheviestiLB = new System.Windows.Forms.Label();
            this.tarkistaBT = new System.Windows.Forms.Button();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SalasanaPanel.SuspendLayout();
            this.SalasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPanel.Controls.Add(this.virheviestiLB);
            this.SalasanaPanel.Controls.Add(this.tarkistaBT);
            this.SalasanaPanel.Controls.Add(this.salasanaTB);
            this.SalasanaPanel.Controls.Add(this.kayttajaTB);
            this.SalasanaPanel.Controls.Add(this.label2);
            this.SalasanaPanel.Controls.Add(this.label1);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(733, 393);
            this.SalasanaPanel.TabIndex = 0;
            // 
            // virheviestiLB
            // 
            this.virheviestiLB.AutoSize = true;
            this.virheviestiLB.ForeColor = System.Drawing.Color.Crimson;
            this.virheviestiLB.Location = new System.Drawing.Point(165, 242);
            this.virheviestiLB.Name = "virheviestiLB";
            this.virheviestiLB.Size = new System.Drawing.Size(78, 32);
            this.virheviestiLB.TabIndex = 5;
            this.virheviestiLB.Text = "label3";
            this.virheviestiLB.Visible = false;
            // 
            // tarkistaBT
            // 
            this.tarkistaBT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tarkistaBT.Location = new System.Drawing.Point(283, 153);
            this.tarkistaBT.Name = "tarkistaBT";
            this.tarkistaBT.Size = new System.Drawing.Size(152, 42);
            this.tarkistaBT.TabIndex = 4;
            this.tarkistaBT.Text = "Tarkista";
            this.tarkistaBT.UseVisualStyleBackColor = false;
            this.tarkistaBT.Click += new System.EventHandler(this.tarkistaBT_Click);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(373, 75);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(240, 39);
            this.salasanaTB.TabIndex = 3;
            this.salasanaTB.UseSystemPasswordChar = true;
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(373, 29);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(240, 39);
            this.kayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus";
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.BackColor = System.Drawing.Color.IndianRed;
            this.SalasanaOikeinPanel.Controls.Add(this.label3);
            this.SalasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(733, 393);
            this.SalasanaOikeinPanel.TabIndex = 1;
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(145, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa Sivuilleni";
            // 
            // SalasananTarkistus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 393);
            this.Controls.Add(this.SalasanaPanel);
            this.Controls.Add(this.SalasanaOikeinPanel);
            this.Name = "SalasananTarkistus";
            this.Text = "Salasanan Tarkistus";
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.SalasanaOikeinPanel.ResumeLayout(false);
            this.SalasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SalasanaPanel;
        private Label virheviestiLB;
        private Button tarkistaBT;
        private TextBox salasanaTB;
        private TextBox kayttajaTB;
        private Label label2;
        private Label label1;
        private Panel SalasanaOikeinPanel;
        private Label label3;
    }
}