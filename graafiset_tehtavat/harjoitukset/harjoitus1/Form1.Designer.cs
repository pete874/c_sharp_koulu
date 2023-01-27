namespace harjoitus1
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.nappi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(27, 28);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(257, 40);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Tämä on otsikkko";
            // 
            // nappi
            // 
            this.nappi.Location = new System.Drawing.Point(79, 115);
            this.nappi.Name = "nappi";
            this.nappi.Size = new System.Drawing.Size(205, 23);
            this.nappi.TabIndex = 1;
            this.nappi.Text = "Vaihda teksti";
            this.nappi.UseVisualStyleBackColor = true;
            this.nappi.Click += new System.EventHandler(this.nappi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nappi);
            this.Controls.Add(this.otsikkoLB);
            this.Name = "Form1";
            this.Text = "Harjoitus1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private Button nappi;
    }
}