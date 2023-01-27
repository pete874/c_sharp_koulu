namespace harjoitus2
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
            this.tulostusLB = new System.Windows.Forms.Label();
            this.viestiTB = new System.Windows.Forms.TextBox();
            this.tulostaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(25, 19);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(223, 33);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Tulostettava teksti:";
            // 
            // tulostusLB
            // 
            this.tulostusLB.AutoSize = true;
            this.tulostusLB.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tulostusLB.Location = new System.Drawing.Point(25, 81);
            this.tulostusLB.Name = "tulostusLB";
            this.tulostusLB.Size = new System.Drawing.Size(100, 33);
            this.tulostusLB.TabIndex = 1;
            this.tulostusLB.Text = "xxxxxx";
            this.tulostusLB.Visible = false;
            // 
            // viestiTB
            // 
            this.viestiTB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viestiTB.Location = new System.Drawing.Point(278, 15);
            this.viestiTB.Name = "viestiTB";
            this.viestiTB.Size = new System.Drawing.Size(306, 35);
            this.viestiTB.TabIndex = 2;
            // 
            // tulostaBT
            // 
            this.tulostaBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tulostaBT.Location = new System.Drawing.Point(297, 91);
            this.tulostaBT.Name = "tulostaBT";
            this.tulostaBT.Size = new System.Drawing.Size(223, 23);
            this.tulostaBT.TabIndex = 3;
            this.tulostaBT.Text = "tulosta teksti";
            this.tulostaBT.UseVisualStyleBackColor = true;
            this.tulostaBT.Click += new System.EventHandler(this.tulostaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tulostaBT);
            this.Controls.Add(this.viestiTB);
            this.Controls.Add(this.tulostusLB);
            this.Controls.Add(this.otsikkoLB);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "Form1";
            this.Text = "Harjoitus2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private Label tulostusLB;
        private TextBox viestiTB;
        private Button tulostaBT;
    }
}