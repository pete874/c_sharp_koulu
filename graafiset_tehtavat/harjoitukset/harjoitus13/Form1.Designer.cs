namespace harjoitus13
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
            this.VastausLB = new System.Windows.Forms.Label();
            this.NimenSyottoTB = new System.Windows.Forms.TextBox();
            this.TarkastusBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna nimesi, niin tarkistetaan, onko se 50 suosituimman joukossa:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(12, 85);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(78, 25);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "vastaus";
            this.VastausLB.Visible = false;
            // 
            // NimenSyottoTB
            // 
            this.NimenSyottoTB.Location = new System.Drawing.Point(611, 35);
            this.NimenSyottoTB.Name = "NimenSyottoTB";
            this.NimenSyottoTB.Size = new System.Drawing.Size(284, 23);
            this.NimenSyottoTB.TabIndex = 2;
            // 
            // TarkastusBT
            // 
            this.TarkastusBT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TarkastusBT.Location = new System.Drawing.Point(647, 73);
            this.TarkastusBT.Name = "TarkastusBT";
            this.TarkastusBT.Size = new System.Drawing.Size(197, 37);
            this.TarkastusBT.TabIndex = 3;
            this.TarkastusBT.Text = "Tarkastus";
            this.TarkastusBT.UseVisualStyleBackColor = true;
            this.TarkastusBT.Click += new System.EventHandler(this.TarkastusBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(964, 189);
            this.Controls.Add(this.TarkastusBT);
            this.Controls.Add(this.NimenSyottoTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label VastausLB;
        private TextBox NimenSyottoTB;
        private Button TarkastusBT;
    }
}