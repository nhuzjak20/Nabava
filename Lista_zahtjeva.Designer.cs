namespace Nabava
{
    partial class Lista_zahtjeva
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
            this.zahtjeviBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjeviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.podnesi_zahtjev_gmb = new System.Windows.Forms.Button();
            this.zahtjeviBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjeviBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.podaci_za_faks = new Nabava.Podaci_za_faks();
            this.zahtjeviTableAdapter3 = new Nabava.Podaci_za_faksTableAdapters.zahtjeviTableAdapter();
            this.osvjezi_gmb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaci_za_faks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // zahtjeviBindingSource1
            // 
            this.zahtjeviBindingSource1.DataMember = "zahtjevi";
            // 
            // zahtjeviBindingSource
            // 
            this.zahtjeviBindingSource.DataMember = "zahtjevi";
            // 
            // podnesi_zahtjev_gmb
            // 
            this.podnesi_zahtjev_gmb.Location = new System.Drawing.Point(31, 277);
            this.podnesi_zahtjev_gmb.Name = "podnesi_zahtjev_gmb";
            this.podnesi_zahtjev_gmb.Size = new System.Drawing.Size(132, 28);
            this.podnesi_zahtjev_gmb.TabIndex = 1;
            this.podnesi_zahtjev_gmb.Text = "Podnesi Zahtjev";
            this.podnesi_zahtjev_gmb.UseVisualStyleBackColor = true;
            this.podnesi_zahtjev_gmb.Click += new System.EventHandler(this.podnesi_zahtjev_gmb_Click);
            // 
            // zahtjeviBindingSource2
            // 
            this.zahtjeviBindingSource2.DataMember = "zahtjevi";
            // 
            // zahtjeviBindingSource3
            // 
            this.zahtjeviBindingSource3.DataMember = "zahtjevi";
            this.zahtjeviBindingSource3.DataSource = this.podaci_za_faks;
            // 
            // podaci_za_faks
            // 
            this.podaci_za_faks.DataSetName = "Podaci_za_faks";
            this.podaci_za_faks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjeviTableAdapter3
            // 
            this.zahtjeviTableAdapter3.ClearBeforeFill = true;
            // 
            // osvjezi_gmb
            // 
            this.osvjezi_gmb.Location = new System.Drawing.Point(869, 277);
            this.osvjezi_gmb.Name = "osvjezi_gmb";
            this.osvjezi_gmb.Size = new System.Drawing.Size(72, 28);
            this.osvjezi_gmb.TabIndex = 3;
            this.osvjezi_gmb.Text = "Osvježi";
            this.osvjezi_gmb.UseVisualStyleBackColor = true;
            this.osvjezi_gmb.Click += new System.EventHandler(this.osvjezi_gmb_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(895, 218);
            this.dataGridView1.TabIndex = 4;
            // 
            // Lista_zahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.osvjezi_gmb);
            this.Controls.Add(this.podnesi_zahtjev_gmb);
            this.Name = "Lista_zahtjeva";
            this.Text = "Lista_zahtjeva";
            this.Load += new System.EventHandler(this.Lista_zahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podaci_za_faks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private huzjaknikola_bazaDataSet huzjaknikola_bazaDataSet;
        private System.Windows.Forms.BindingSource zahtjeviBindingSource;
        private huzjaknikola_bazaDataSetTableAdapters.zahtjeviTableAdapter zahtjeviTableAdapter;
        private System.Windows.Forms.Button podnesi_zahtjev_gmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivpodnositeljaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacinfinanciranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razlogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dekanpotvrdaDataGridViewTextBoxColumn;
        private huzjaknikola_bazaDataSet huzjaknikola_bazaDataSet1;
        private System.Windows.Forms.BindingSource zahtjeviBindingSource1;
        private huzjaknikola_bazaDataSetTableAdapters.zahtjeviTableAdapter zahtjeviTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private huzjaknikola_bazaDataSet huzjaknikola_bazaDataSet2;
        private System.Windows.Forms.BindingSource zahtjeviBindingSource2;
        private huzjaknikola_bazaDataSetTableAdapters.zahtjeviTableAdapter zahtjeviTableAdapter2;
        private Podaci_za_faks podaci_za_faks;
        private System.Windows.Forms.BindingSource zahtjeviBindingSource3;
        private Podaci_za_faksTableAdapters.zahtjeviTableAdapter zahtjeviTableAdapter3;
        private System.Windows.Forms.Button osvjezi_gmb;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}