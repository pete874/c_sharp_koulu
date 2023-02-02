namespace harjoitus9
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
            this.AsteenSyottoTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CelsiusRB = new System.Windows.Forms.RadioButton();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AsteenSyottoTB
            // 
            this.AsteenSyottoTB.Location = new System.Drawing.Point(39, 100);
            this.AsteenSyottoTB.Name = "AsteenSyottoTB";
            this.AsteenSyottoTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AsteenSyottoTB.Size = new System.Drawing.Size(104, 23);
            this.AsteenSyottoTB.TabIndex = 0;
            this.AsteenSyottoTB.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anna asteet:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(39, 168);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(67, 21);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "vastaus";
            this.VastausLB.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(206, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anna muunnettava yksikkö";
            // 
            // CelsiusRB
            // 
            this.CelsiusRB.AutoSize = true;
            this.CelsiusRB.Location = new System.Drawing.Point(230, 95);
            this.CelsiusRB.Name = "CelsiusRB";
            this.CelsiusRB.Size = new System.Drawing.Size(62, 19);
            this.CelsiusRB.TabIndex = 4;
            this.CelsiusRB.TabStop = true;
            this.CelsiusRB.Text = "Celsius";
            this.CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Location = new System.Drawing.Point(230, 120);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(81, 19);
            this.FahrenheitRB.TabIndex = 5;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "Fahrenheit";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Location = new System.Drawing.Point(517, 105);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(123, 34);
            this.MuunnaBT.TabIndex = 6;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(760, 267);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.FahrenheitRB);
            this.Controls.Add(this.CelsiusRB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AsteenSyottoTB);
            this.Name = "Form1";
            this.Text = "Asteiden muunnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox AsteenSyottoTB;
        private Label label1;
        private Label VastausLB;
        private Label label2;
        private RadioButton CelsiusRB;
        private RadioButton FahrenheitRB;
        private Button MuunnaBT;
    }
}