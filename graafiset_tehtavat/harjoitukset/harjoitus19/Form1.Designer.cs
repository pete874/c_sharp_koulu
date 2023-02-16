namespace harjoitus19
{
    partial class ruokalistaForm
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
            this.vasenPL = new System.Windows.Forms.Panel();
            this.ylaPL = new System.Windows.Forms.Panel();
            this.meistaPL = new System.Windows.Forms.Panel();
            this.herkutPL = new System.Windows.Forms.Panel();
            this.koriPL = new System.Windows.Forms.Panel();
            this.juomatPL = new System.Windows.Forms.Panel();
            this.ruoatPL = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // vasenPL
            // 
            this.vasenPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(172)))), ((int)(((byte)(64)))));
            this.vasenPL.Dock = System.Windows.Forms.DockStyle.Left;
            this.vasenPL.Location = new System.Drawing.Point(0, 0);
            this.vasenPL.Name = "vasenPL";
            this.vasenPL.Size = new System.Drawing.Size(135, 300);
            this.vasenPL.TabIndex = 0;
            // 
            // ylaPL
            // 
            this.ylaPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(2)))));
            this.ylaPL.Dock = System.Windows.Forms.DockStyle.Top;
            this.ylaPL.Location = new System.Drawing.Point(135, 0);
            this.ylaPL.Name = "ylaPL";
            this.ylaPL.Size = new System.Drawing.Size(515, 40);
            this.ylaPL.TabIndex = 1;
            // 
            // meistaPL
            // 
            this.meistaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meistaPL.Location = new System.Drawing.Point(135, 40);
            this.meistaPL.Name = "meistaPL";
            this.meistaPL.Size = new System.Drawing.Size(515, 260);
            this.meistaPL.TabIndex = 2;
            // 
            // herkutPL
            // 
            this.herkutPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.herkutPL.Location = new System.Drawing.Point(135, 40);
            this.herkutPL.Name = "herkutPL";
            this.herkutPL.Size = new System.Drawing.Size(515, 260);
            this.herkutPL.TabIndex = 3;
            // 
            // koriPL
            // 
            this.koriPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.koriPL.Location = new System.Drawing.Point(135, 40);
            this.koriPL.Name = "koriPL";
            this.koriPL.Size = new System.Drawing.Size(515, 260);
            this.koriPL.TabIndex = 3;
            // 
            // juomatPL
            // 
            this.juomatPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.juomatPL.Location = new System.Drawing.Point(135, 40);
            this.juomatPL.Name = "juomatPL";
            this.juomatPL.Size = new System.Drawing.Size(515, 260);
            this.juomatPL.TabIndex = 3;
            // 
            // ruoatPL
            // 
            this.ruoatPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ruoatPL.Location = new System.Drawing.Point(135, 40);
            this.ruoatPL.Name = "ruoatPL";
            this.ruoatPL.Size = new System.Drawing.Size(515, 260);
            this.ruoatPL.TabIndex = 3;
            // 
            // ruokalistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(650, 300);
            this.Controls.Add(this.koriPL);
            this.Controls.Add(this.juomatPL);
            this.Controls.Add(this.ruoatPL);
            this.Controls.Add(this.herkutPL);
            this.Controls.Add(this.meistaPL);
            this.Controls.Add(this.ylaPL);
            this.Controls.Add(this.vasenPL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ruokalistaForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel vasenPL;
        private Panel ylaPL;
        private Panel meistaPL;
        private Panel herkutPL;
        private Panel koriPL;
        private Panel juomatPL;
        private Panel ruoatPL;
    }
}