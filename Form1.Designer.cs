namespace Nabava
{
    partial class PrikazZahtjeva
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
            this.PrikazaniZahtjevi = new System.Windows.Forms.DataGridView();
            this.huzjaknikola_bazaDataSet = new Nabava.huzjaknikola_bazaDataSet();
            this.huzjaknikolabazaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjeviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjeviTableAdapter = new Nabava.huzjaknikola_bazaDataSetTableAdapters.zahtjeviTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivpodnositeljaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacinfinanciranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dekanpotvrdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PrikazaniZahtjevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzjaknikola_bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzjaknikolabazaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PrikazaniZahtjevi
            // 
            this.PrikazaniZahtjevi.AutoGenerateColumns = false;
            this.PrikazaniZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrikazaniZahtjevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivpodnositeljaDataGridViewTextBoxColumn,
            this.nacinfinanciranjaDataGridViewTextBoxColumn,
            this.dekanpotvrdaDataGridViewTextBoxColumn});
            this.PrikazaniZahtjevi.DataSource = this.zahtjeviBindingSource;
            this.PrikazaniZahtjevi.Location = new System.Drawing.Point(12, 12);
            this.PrikazaniZahtjevi.Name = "PrikazaniZahtjevi";
            this.PrikazaniZahtjevi.RowHeadersWidth = 51;
            this.PrikazaniZahtjevi.RowTemplate.Height = 24;
            this.PrikazaniZahtjevi.Size = new System.Drawing.Size(735, 150);
            this.PrikazaniZahtjevi.TabIndex = 0;
            // 
            // huzjaknikola_bazaDataSet
            // 
            this.huzjaknikola_bazaDataSet.DataSetName = "huzjaknikola_bazaDataSet";
            this.huzjaknikola_bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // huzjaknikolabazaDataSetBindingSource
            // 
            this.huzjaknikolabazaDataSetBindingSource.DataSource = this.huzjaknikola_bazaDataSet;
            this.huzjaknikolabazaDataSetBindingSource.Position = 0;
            // 
            // zahtjeviBindingSource
            // 
            this.zahtjeviBindingSource.DataMember = "zahtjevi";
            this.zahtjeviBindingSource.DataSource = this.huzjaknikolabazaDataSetBindingSource;
            // 
            // zahtjeviTableAdapter
            // 
            this.zahtjeviTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Broj Zahtjeva";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivpodnositeljaDataGridViewTextBoxColumn
            // 
            this.nazivpodnositeljaDataGridViewTextBoxColumn.DataPropertyName = "naziv_podnositelja";
            this.nazivpodnositeljaDataGridViewTextBoxColumn.HeaderText = "Naziv Podnositelja";
            this.nazivpodnositeljaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivpodnositeljaDataGridViewTextBoxColumn.Name = "nazivpodnositeljaDataGridViewTextBoxColumn";
            this.nazivpodnositeljaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nacinfinanciranjaDataGridViewTextBoxColumn
            // 
            this.nacinfinanciranjaDataGridViewTextBoxColumn.DataPropertyName = "nacin_financiranja";
            this.nacinfinanciranjaDataGridViewTextBoxColumn.HeaderText = "Način Financiranja";
            this.nacinfinanciranjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nacinfinanciranjaDataGridViewTextBoxColumn.Name = "nacinfinanciranjaDataGridViewTextBoxColumn";
            this.nacinfinanciranjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dekanpotvrdaDataGridViewTextBoxColumn
            // 
            this.dekanpotvrdaDataGridViewTextBoxColumn.DataPropertyName = "dekan_potvrda";
            this.dekanpotvrdaDataGridViewTextBoxColumn.HeaderText = "Potvrda Dekana";
            this.dekanpotvrdaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dekanpotvrdaDataGridViewTextBoxColumn.Name = "dekanpotvrdaDataGridViewTextBoxColumn";
            this.dekanpotvrdaDataGridViewTextBoxColumn.Width = 125;
            // 
            // PrikazZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrikazaniZahtjevi);
            this.Name = "PrikazZahtjeva";
            this.Text = "Prikaz zahtjeva";
            this.Load += new System.EventHandler(this.PrikazZahtjeva_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PrikazaniZahtjevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzjaknikola_bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzjaknikolabazaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PrikazaniZahtjevi;
        private System.Windows.Forms.BindingSource huzjaknikolabazaDataSetBindingSource;
        private huzjaknikola_bazaDataSet huzjaknikola_bazaDataSet;
        private System.Windows.Forms.BindingSource zahtjeviBindingSource;
        private huzjaknikola_bazaDataSetTableAdapters.zahtjeviTableAdapter zahtjeviTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivpodnositeljaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacinfinanciranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dekanpotvrdaDataGridViewTextBoxColumn;
    }
}