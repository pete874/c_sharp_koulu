namespace harjoitus16
{
    partial class AjastinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinutesCB = new System.Windows.Forms.ComboBox();
            this.SecondsCB = new System.Windows.Forms.ComboBox();
            this.TimerLB = new System.Windows.Forms.Label();
            this.TimerTM = new System.Windows.Forms.Timer(this.components);
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minuutit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekunnit:";
            // 
            // MinutesCB
            // 
            this.MinutesCB.FormattingEnabled = true;
            this.MinutesCB.Location = new System.Drawing.Point(36, 75);
            this.MinutesCB.Name = "MinutesCB";
            this.MinutesCB.Size = new System.Drawing.Size(56, 23);
            this.MinutesCB.TabIndex = 2;
            // 
            // SecondsCB
            // 
            this.SecondsCB.FormattingEnabled = true;
            this.SecondsCB.Location = new System.Drawing.Point(114, 75);
            this.SecondsCB.Name = "SecondsCB";
            this.SecondsCB.Size = new System.Drawing.Size(56, 23);
            this.SecondsCB.TabIndex = 3;
            // 
            // TimerLB
            // 
            this.TimerLB.AutoSize = true;
            this.TimerLB.Location = new System.Drawing.Point(83, 123);
            this.TimerLB.Name = "TimerLB";
            this.TimerLB.Size = new System.Drawing.Size(34, 15);
            this.TimerLB.TabIndex = 4;
            this.TimerLB.Text = "00:00";
            // 
            // TimerTM
            // 
            this.TimerTM.Interval = 1000;
            this.TimerTM.Tick += new System.EventHandler(this.TimerTM_Tick_1);
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(36, 156);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(56, 23);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(114, 156);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(56, 23);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AjastinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 239);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.TimerLB);
            this.Controls.Add(this.SecondsCB);
            this.Controls.Add(this.MinutesCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjastinForm";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.AjastinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox MinutesCB;
        private ComboBox SecondsCB;
        private Label TimerLB;
        private System.Windows.Forms.Timer TimerTM;
        private Button StartBT;
        private Button StopBT;
    }
}