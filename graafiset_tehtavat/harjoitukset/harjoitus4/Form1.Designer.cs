namespace harjoitus4
{
    partial class Form1
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
            this.syntymaAika = new System.Windows.Forms.DateTimePicker();
            this.vuodetLB = new System.Windows.Forms.Label();
            this.tunnitLB = new System.Windows.Forms.Label();
            this.kuukaudetLB = new System.Windows.Forms.Label();
            this.minuutitLB = new System.Windows.Forms.Label();
            this.paivatLB = new System.Windows.Forms.Label();
            this.sekunnitLB = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // syntymaAika
            // 
            this.syntymaAika.Location = new System.Drawing.Point(22, 30);
            this.syntymaAika.Name = "syntymaAika";
            this.syntymaAika.Size = new System.Drawing.Size(200, 23);
            this.syntymaAika.TabIndex = 0;
            // 
            // vuodetLB
            // 
            this.vuodetLB.AutoSize = true;
            this.vuodetLB.Location = new System.Drawing.Point(24, 87);
            this.vuodetLB.Name = "vuodetLB";
            this.vuodetLB.Size = new System.Drawing.Size(13, 15);
            this.vuodetLB.TabIndex = 2;
            this.vuodetLB.Text = "x";
            this.vuodetLB.Visible = false;
            this.vuodetLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // tunnitLB
            // 
            this.tunnitLB.AutoSize = true;
            this.tunnitLB.Location = new System.Drawing.Point(192, 87);
            this.tunnitLB.Name = "tunnitLB";
            this.tunnitLB.Size = new System.Drawing.Size(13, 15);
            this.tunnitLB.TabIndex = 3;
            this.tunnitLB.Text = "x";
            this.tunnitLB.Visible = false;
            // 
            // kuukaudetLB
            // 
            this.kuukaudetLB.AutoSize = true;
            this.kuukaudetLB.Location = new System.Drawing.Point(22, 115);
            this.kuukaudetLB.Name = "kuukaudetLB";
            this.kuukaudetLB.Size = new System.Drawing.Size(13, 15);
            this.kuukaudetLB.TabIndex = 4;
            this.kuukaudetLB.Text = "x";
            this.kuukaudetLB.Visible = false;
            // 
            // minuutitLB
            // 
            this.minuutitLB.AutoSize = true;
            this.minuutitLB.Location = new System.Drawing.Point(192, 115);
            this.minuutitLB.Name = "minuutitLB";
            this.minuutitLB.Size = new System.Drawing.Size(13, 15);
            this.minuutitLB.TabIndex = 5;
            this.minuutitLB.Text = "x";
            this.minuutitLB.Visible = false;
            // 
            // paivatLB
            // 
            this.paivatLB.AutoSize = true;
            this.paivatLB.Location = new System.Drawing.Point(24, 144);
            this.paivatLB.Name = "paivatLB";
            this.paivatLB.Size = new System.Drawing.Size(13, 15);
            this.paivatLB.TabIndex = 6;
            this.paivatLB.Text = "x";
            this.paivatLB.Visible = false;
            // 
            // sekunnitLB
            // 
            this.sekunnitLB.AutoSize = true;
            this.sekunnitLB.Location = new System.Drawing.Point(192, 144);
            this.sekunnitLB.Name = "sekunnitLB";
            this.sekunnitLB.Size = new System.Drawing.Size(13, 15);
            this.sekunnitLB.TabIndex = 7;
            this.sekunnitLB.Text = "x";
            this.sekunnitLB.Visible = false;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(287, 32);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(75, 23);
            this.laskeBT.TabIndex = 8;
            this.laskeBT.Text = "laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.sekunnitLB);
            this.Controls.Add(this.paivatLB);
            this.Controls.Add(this.minuutitLB);
            this.Controls.Add(this.kuukaudetLB);
            this.Controls.Add(this.tunnitLB);
            this.Controls.Add(this.vuodetLB);
            this.Controls.Add(this.syntymaAika);
            this.Name = "Form1";
            this.Text = "x";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker syntymaAika;
        private Label vuodetLB;
        private Label tunnitLB;
        private Label kuukaudetLB;
        private Label minuutitLB;
        private Label paivatLB;
        private Label sekunnitLB;
        private Button laskeBT;
    }
}