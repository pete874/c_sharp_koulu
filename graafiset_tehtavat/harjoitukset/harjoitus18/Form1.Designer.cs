namespace harjoitus18
{
    partial class AvoinhenkilotForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.OppilaitoksetCB = new System.Windows.Forms.ComboBox();
            this.VastuuhenkilotCB = new System.Windows.Forms.ComboBox();
            this.KatuosoiteLB = new System.Windows.Forms.Label();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.SijaintiLB = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.PhoneLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(288, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valitse vastuuhenkilö";
            // 
            // OppilaitoksetCB
            // 
            this.OppilaitoksetCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OppilaitoksetCB.FormattingEnabled = true;
            this.OppilaitoksetCB.Location = new System.Drawing.Point(59, 125);
            this.OppilaitoksetCB.Name = "OppilaitoksetCB";
            this.OppilaitoksetCB.Size = new System.Drawing.Size(121, 23);
            this.OppilaitoksetCB.TabIndex = 3;
            this.OppilaitoksetCB.SelectedIndexChanged += new System.EventHandler(this.OppilaitoksetCB_SelectedIndexChanged);
            // 
            // VastuuhenkilotCB
            // 
            this.VastuuhenkilotCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VastuuhenkilotCB.FormattingEnabled = true;
            this.VastuuhenkilotCB.Location = new System.Drawing.Point(288, 125);
            this.VastuuhenkilotCB.Name = "VastuuhenkilotCB";
            this.VastuuhenkilotCB.Size = new System.Drawing.Size(156, 23);
            this.VastuuhenkilotCB.TabIndex = 4;
            this.VastuuhenkilotCB.TextChanged += new System.EventHandler(this.VastuuhenkilotCB_TextChanged);
            // 
            // KatuosoiteLB
            // 
            this.KatuosoiteLB.AutoSize = true;
            this.KatuosoiteLB.Location = new System.Drawing.Point(59, 167);
            this.KatuosoiteLB.Name = "KatuosoiteLB";
            this.KatuosoiteLB.Size = new System.Drawing.Size(38, 15);
            this.KatuosoiteLB.TabIndex = 5;
            this.KatuosoiteLB.Text = "label4";
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.Location = new System.Drawing.Point(59, 195);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.Size = new System.Drawing.Size(38, 15);
            this.PostinumeroLB.TabIndex = 6;
            this.PostinumeroLB.Text = "label5";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(59, 226);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(38, 15);
            this.PostitoimipaikkaLB.TabIndex = 7;
            this.PostitoimipaikkaLB.Text = "label6";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(59, 256);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(38, 15);
            this.PuhelinLB.TabIndex = 8;
            this.PuhelinLB.Text = "label7";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(288, 167);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(38, 15);
            this.TitteliLB.TabIndex = 9;
            this.TitteliLB.Text = "label8";
            // 
            // SijaintiLB
            // 
            this.SijaintiLB.AutoSize = true;
            this.SijaintiLB.Location = new System.Drawing.Point(288, 195);
            this.SijaintiLB.Name = "SijaintiLB";
            this.SijaintiLB.Size = new System.Drawing.Size(38, 15);
            this.SijaintiLB.TabIndex = 10;
            this.SijaintiLB.Text = "label9";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Location = new System.Drawing.Point(288, 226);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(44, 15);
            this.EmailLB.TabIndex = 11;
            this.EmailLB.Text = "label10";
            // 
            // PhoneLB
            // 
            this.PhoneLB.AutoSize = true;
            this.PhoneLB.Location = new System.Drawing.Point(288, 256);
            this.PhoneLB.Name = "PhoneLB";
            this.PhoneLB.Size = new System.Drawing.Size(44, 15);
            this.PhoneLB.TabIndex = 12;
            this.PhoneLB.Text = "label11";
            // 
            // AvoinhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(522, 403);
            this.Controls.Add(this.PhoneLB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.SijaintiLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.PostinumeroLB);
            this.Controls.Add(this.KatuosoiteLB);
            this.Controls.Add(this.VastuuhenkilotCB);
            this.Controls.Add(this.OppilaitoksetCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AvoinhenkilotForm";
            this.Text = "Avainhenkilöt";
            this.Load += new System.EventHandler(this.AvoinhenkilotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox OppilaitoksetCB;
        private ComboBox VastuuhenkilotCB;
        private Label KatuosoiteLB;
        private Label PostinumeroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private Label TitteliLB;
        private Label SijaintiLB;
        private Label EmailLB;
        private Label PhoneLB;
    }
}