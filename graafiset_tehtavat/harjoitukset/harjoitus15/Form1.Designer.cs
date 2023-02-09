namespace harjoitus15
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
            this.components = new System.ComponentModel.Container();
            this.AjastinLB = new System.Windows.Forms.Label();
            this.Ajastin = new System.Windows.Forms.Timer(this.components);
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AjastinLB
            // 
            this.AjastinLB.AutoSize = true;
            this.AjastinLB.Location = new System.Drawing.Point(123, 87);
            this.AjastinLB.Name = "AjastinLB";
            this.AjastinLB.Size = new System.Drawing.Size(0, 15);
            this.AjastinLB.TabIndex = 0;
            // 
            // Ajastin
            // 
            this.Ajastin.Enabled = true;
            this.Ajastin.Tick += new System.EventHandler(this.Ajastin_Tick);
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(67, 228);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(75, 23);
            this.StartBT.TabIndex = 1;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(195, 228);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(75, 23);
            this.StopBT.TabIndex = 2;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.Location = new System.Drawing.Point(332, 228);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(75, 23);
            this.ResetBT.TabIndex = 3;
            this.ResetBT.Text = "Reset";
            this.ResetBT.UseVisualStyleBackColor = true;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.AjastinLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AjastinLB;
        private System.Windows.Forms.Timer Ajastin;
        private Button StartBT;
        private Button StopBT;
        private Button ResetBT;
    }
}