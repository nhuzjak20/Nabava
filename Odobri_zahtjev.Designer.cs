namespace Nabava
{
    partial class Odobri_zahtjev
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
            this.promjeni_odobrenje_gmb = new System.Windows.Forms.Button();
            this.odaberi_id_num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.odustani_gmb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.odaberi_id_num)).BeginInit();
            this.SuspendLayout();
            // 
            // promjeni_odobrenje_gmb
            // 
            this.promjeni_odobrenje_gmb.Location = new System.Drawing.Point(181, 97);
            this.promjeni_odobrenje_gmb.Name = "promjeni_odobrenje_gmb";
            this.promjeni_odobrenje_gmb.Size = new System.Drawing.Size(75, 23);
            this.promjeni_odobrenje_gmb.TabIndex = 1;
            this.promjeni_odobrenje_gmb.Text = "Promjeni odobrenje";
            this.promjeni_odobrenje_gmb.UseVisualStyleBackColor = true;
            this.promjeni_odobrenje_gmb.Click += new System.EventHandler(this.promjeni_odobrenje_gmb_Click);
            // 
            // odaberi_id_num
            // 
            this.odaberi_id_num.Location = new System.Drawing.Point(91, 28);
            this.odaberi_id_num.Name = "odaberi_id_num";
            this.odaberi_id_num.Size = new System.Drawing.Size(165, 22);
            this.odaberi_id_num.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberi ID: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odaberi odobrenje";
            // 
            // odustani_gmb
            // 
            this.odustani_gmb.Location = new System.Drawing.Point(59, 97);
            this.odustani_gmb.Name = "odustani_gmb";
            this.odustani_gmb.Size = new System.Drawing.Size(82, 23);
            this.odustani_gmb.TabIndex = 6;
            this.odustani_gmb.Text = "Odustani";
            this.odustani_gmb.UseVisualStyleBackColor = true;
            // 
            // Odobri_zahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 146);
            this.Controls.Add(this.odustani_gmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odaberi_id_num);
            this.Controls.Add(this.promjeni_odobrenje_gmb);
            this.Name = "Odobri_zahtjev";
            this.Text = "Odobri zahtjev";
            ((System.ComponentModel.ISupportInitialize)(this.odaberi_id_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button promjeni_odobrenje_gmb;
        private System.Windows.Forms.NumericUpDown odaberi_id_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button odustani_gmb;
    }
}