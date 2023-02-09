namespace harjoitus14
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
            this.SyottoTB = new System.Windows.Forms.RichTextBox();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.SuljeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyottoTB
            // 
            this.SyottoTB.Location = new System.Drawing.Point(12, 12);
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(776, 180);
            this.SyottoTB.TabIndex = 0;
            this.SyottoTB.Text = "";
            // 
            // TallennaBT
            // 
            this.TallennaBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TallennaBT.Location = new System.Drawing.Point(104, 224);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(243, 53);
            this.TallennaBT.TabIndex = 1;
            this.TallennaBT.Text = "Tallenna päiväkirjaan";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // SuljeBT
            // 
            this.SuljeBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SuljeBT.Location = new System.Drawing.Point(460, 224);
            this.SuljeBT.Name = "SuljeBT";
            this.SuljeBT.Size = new System.Drawing.Size(243, 53);
            this.SuljeBT.TabIndex = 2;
            this.SuljeBT.Text = "Sulje päiväkirja";
            this.SuljeBT.UseVisualStyleBackColor = true;
            this.SuljeBT.Click += new System.EventHandler(this.SuljeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.SuljeBT);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.SyottoTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox SyottoTB;
        private Button TallennaBT;
        private Button SuljeBT;
    }
}