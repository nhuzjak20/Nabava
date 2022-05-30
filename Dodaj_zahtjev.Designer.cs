namespace Nabava
{
    partial class dodavanje_zahtjeva
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.naziv_podnositelja_box = new System.Windows.Forms.TextBox();
            this.način_financiranja_box = new System.Windows.Forms.ComboBox();
            this.razlog_zahtjev_box = new System.Windows.Forms.RichTextBox();
            this.nazad = new System.Windows.Forms.Button();
            this.podnesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv Podnositelja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Način Financiranja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razlog zahtjeva:";
            // 
            // naziv_podnositelja_box
            // 
            this.naziv_podnositelja_box.Location = new System.Drawing.Point(160, 21);
            this.naziv_podnositelja_box.Name = "naziv_podnositelja_box";
            this.naziv_podnositelja_box.Size = new System.Drawing.Size(184, 22);
            this.naziv_podnositelja_box.TabIndex = 3;
            // 
            // način_financiranja_box
            // 
            this.način_financiranja_box.FormattingEnabled = true;
            this.način_financiranja_box.Items.AddRange(new object[] {
            "1. Temeljeno financiranje znanosti \"5.000,00 kuna\" potpora",
            "2. Znanstveno-nastavno usavršavanje \"5.000,00 kuna\"",
            "3. Odluka - oprema - znan., nast. i surad. zvanja \"4.500,00kn + PDV\"",
            "4. EU projekt",
            "5. Komercijalni projekt",
            "6. Komercijalna djelatnost (edukacije, izrada aplikacije i dr.)",
            "7. Sredstva proračuna (opći prihodi i primici)",
            "8. Sredstva FOI(ostalo)"});
            this.način_financiranja_box.Location = new System.Drawing.Point(160, 49);
            this.način_financiranja_box.Name = "način_financiranja_box";
            this.način_financiranja_box.Size = new System.Drawing.Size(184, 24);
            this.način_financiranja_box.TabIndex = 6;
            // 
            // razlog_zahtjev_box
            // 
            this.razlog_zahtjev_box.Location = new System.Drawing.Point(160, 85);
            this.razlog_zahtjev_box.Name = "razlog_zahtjev_box";
            this.razlog_zahtjev_box.Size = new System.Drawing.Size(184, 194);
            this.razlog_zahtjev_box.TabIndex = 7;
            this.razlog_zahtjev_box.Text = "";
            // 
            // nazad
            // 
            this.nazad.Location = new System.Drawing.Point(63, 301);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(103, 29);
            this.nazad.TabIndex = 8;
            this.nazad.Text = "Vrati se";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // podnesi
            // 
            this.podnesi.Location = new System.Drawing.Point(223, 301);
            this.podnesi.Name = "podnesi";
            this.podnesi.Size = new System.Drawing.Size(99, 29);
            this.podnesi.TabIndex = 9;
            this.podnesi.Text = "Podnesi zahtjev";
            this.podnesi.UseVisualStyleBackColor = true;
            this.podnesi.Click += new System.EventHandler(this.podnesi_Click);
            // 
            // dodavanje_zahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 354);
            this.Controls.Add(this.podnesi);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.razlog_zahtjev_box);
            this.Controls.Add(this.način_financiranja_box);
            this.Controls.Add(this.naziv_podnositelja_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dodavanje_zahtjeva";
            this.Text = "Dodavanje Zahtjeva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox naziv_podnositelja_box;
        private System.Windows.Forms.ComboBox način_financiranja_box;
        private System.Windows.Forms.RichTextBox razlog_zahtjev_box;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button podnesi;
    }
}