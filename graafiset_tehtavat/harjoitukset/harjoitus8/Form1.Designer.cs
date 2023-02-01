namespace harjoitus8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(616, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna numero välillä 1 - 3999, niin muutan sen roomalaiseksi numeroksi:";
            // 
            // NumeroTB
            // 
            this.NumeroTB.Location = new System.Drawing.Point(645, 130);
            this.NumeroTB.Name = "NumeroTB";
            this.NumeroTB.Size = new System.Drawing.Size(111, 23);
            this.NumeroTB.TabIndex = 2;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(79, 198);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(52, 21);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "label3";
            // 
            // MuutaBT
            // 
            this.MuutaBT.Location = new System.Drawing.Point(489, 196);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(75, 23);
            this.MuutaBT.TabIndex = 4;
            this.MuutaBT.Text = "Muunna";
            this.MuutaBT.UseVisualStyleBackColor = true;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.NumeroTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Roomalaiset numerot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NumeroTB;
        private Label VastausLB;
        private Button MuutaBT;
    }
}