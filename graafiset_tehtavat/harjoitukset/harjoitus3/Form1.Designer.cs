namespace harjoitus3
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
            this.luku1_field = new System.Windows.Forms.TextBox();
            this.luku2_field = new System.Windows.Forms.TextBox();
            this.laskun_valinta = new System.Windows.Forms.ComboBox();
            this.tulosLB = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.onMerkki = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // luku1_field
            // 
            this.luku1_field.Location = new System.Drawing.Point(26, 32);
            this.luku1_field.Name = "luku1_field";
            this.luku1_field.Size = new System.Drawing.Size(100, 23);
            this.luku1_field.TabIndex = 0;
            // 
            // luku2_field
            // 
            this.luku2_field.Location = new System.Drawing.Point(224, 32);
            this.luku2_field.Name = "luku2_field";
            this.luku2_field.Size = new System.Drawing.Size(100, 23);
            this.luku2_field.TabIndex = 1;
            // 
            // laskun_valinta
            // 
            this.laskun_valinta.FormattingEnabled = true;
            this.laskun_valinta.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.laskun_valinta.Location = new System.Drawing.Point(147, 32);
            this.laskun_valinta.Name = "laskun_valinta";
            this.laskun_valinta.Size = new System.Drawing.Size(57, 23);
            this.laskun_valinta.TabIndex = 2;
            // 
            // tulosLB
            // 
            this.tulosLB.AutoSize = true;
            this.tulosLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tulosLB.Location = new System.Drawing.Point(382, 25);
            this.tulosLB.Name = "tulosLB";
            this.tulosLB.Size = new System.Drawing.Size(25, 30);
            this.tulosLB.TabIndex = 3;
            this.tulosLB.Text = "X";
            this.tulosLB.Visible = false;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(451, 33);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(75, 23);
            this.laskeBT.TabIndex = 4;
            this.laskeBT.Text = "laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // onMerkki
            // 
            this.onMerkki.AutoSize = true;
            this.onMerkki.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.onMerkki.Location = new System.Drawing.Point(349, 25);
            this.onMerkki.Name = "onMerkki";
            this.onMerkki.Size = new System.Drawing.Size(27, 30);
            this.onMerkki.TabIndex = 5;
            this.onMerkki.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.onMerkki);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.tulosLB);
            this.Controls.Add(this.laskun_valinta);
            this.Controls.Add(this.luku2_field);
            this.Controls.Add(this.luku1_field);
            this.Name = "Form1";
            this.Text = "Yksinkertainen nelilaskin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox luku1_field;
        private TextBox luku2_field;
        private ComboBox laskun_valinta;
        private Label tulosLB;
        private Button laskeBT;
        private Label onMerkki;
    }
}