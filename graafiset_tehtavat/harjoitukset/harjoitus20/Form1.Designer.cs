namespace harjoitus20
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.EtunimiTB = new System.Windows.Forms.TextBox();
            this.SukunimiTB = new System.Windows.Forms.TextBox();
            this.PuhelinTB = new System.Windows.Forms.TextBox();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.NroTB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.PaivitaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ETUNIMI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "SUKUNIMI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "PUHELIN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(502, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "SÄHKÖPOSTI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "OPISKELIJANRO:";
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(190, 56);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(293, 20);
            this.IdTB.TabIndex = 6;
            // 
            // EtunimiTB
            // 
            this.EtunimiTB.Location = new System.Drawing.Point(190, 94);
            this.EtunimiTB.Name = "EtunimiTB";
            this.EtunimiTB.Size = new System.Drawing.Size(293, 20);
            this.EtunimiTB.TabIndex = 7;
            // 
            // SukunimiTB
            // 
            this.SukunimiTB.Location = new System.Drawing.Point(190, 132);
            this.SukunimiTB.Name = "SukunimiTB";
            this.SukunimiTB.Size = new System.Drawing.Size(293, 20);
            this.SukunimiTB.TabIndex = 8;
            // 
            // PuhelinTB
            // 
            this.PuhelinTB.Location = new System.Drawing.Point(718, 56);
            this.PuhelinTB.Name = "PuhelinTB";
            this.PuhelinTB.Size = new System.Drawing.Size(293, 20);
            this.PuhelinTB.TabIndex = 9;
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(718, 94);
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(293, 20);
            this.MailTB.TabIndex = 10;
            // 
            // NroTB
            // 
            this.NroTB.Location = new System.Drawing.Point(718, 132);
            this.NroTB.Name = "NroTB";
            this.NroTB.Size = new System.Drawing.Size(293, 20);
            this.NroTB.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TyhjennaBT.Location = new System.Drawing.Point(45, 186);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(196, 34);
            this.TyhjennaBT.TabIndex = 13;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // TallennaBT
            // 
            this.TallennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TallennaBT.Location = new System.Drawing.Point(297, 186);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(196, 34);
            this.TallennaBT.TabIndex = 14;
            this.TallennaBT.Text = "Tallenna";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // PaivitaBT
            // 
            this.PaivitaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaivitaBT.Location = new System.Drawing.Point(554, 186);
            this.PaivitaBT.Name = "PaivitaBT";
            this.PaivitaBT.Size = new System.Drawing.Size(196, 34);
            this.PaivitaBT.TabIndex = 15;
            this.PaivitaBT.Text = "Päivitä";
            this.PaivitaBT.UseVisualStyleBackColor = true;
            this.PaivitaBT.Click += new System.EventHandler(this.PaivitaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaBT.Location = new System.Drawing.Point(815, 186);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(196, 34);
            this.PoistaBT.TabIndex = 16;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 226);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(1328, 402);
            this.DataGrid.TabIndex = 17;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1352, 640);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.PaivitaBT);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.NroTB);
            this.Controls.Add(this.MailTB);
            this.Controls.Add(this.PuhelinTB);
            this.Controls.Add(this.SukunimiTB);
            this.Controls.Add(this.EtunimiTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opiskelijarekisterin ylläpito";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox EtunimiTB;
        private System.Windows.Forms.TextBox SukunimiTB;
        private System.Windows.Forms.TextBox PuhelinTB;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.TextBox NroTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.Button PaivitaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.DataGridView DataGrid;
    }
}

