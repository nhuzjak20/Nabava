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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.huzjaknikola_bazaDataSet = new Nabava.huzjaknikola_bazaDataSet();
            this.zahtjeviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjeviTableAdapter = new Nabava.huzjaknikola_bazaDataSetTableAdapters.zahtjeviTableAdapter();
            this.podnesi_zahtjev_gmb = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivpodnositeljaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacinfinanciranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razlogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dekanpotvrdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzjaknikola_bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivpodnositeljaDataGridViewTextBoxColumn,
            this.nacinfinanciranjaDataGridViewTextBoxColumn,
            this.razlogDataGridViewTextBoxColumn,
            this.dekanpotvrdaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zahtjeviBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // huzjaknikola_bazaDataSet
            // 
            this.huzjaknikola_bazaDataSet.DataSetName = "huzjaknikola_bazaDataSet";
            this.huzjaknikola_bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjeviBindingSource
            // 
            this.zahtjeviBindingSource.DataMember = "zahtjevi";
            this.zahtjeviBindingSource.DataSource = this.huzjaknikola_bazaDataSet;
            // 
            // zahtjeviTableAdapter
            // 
            this.zahtjeviTableAdapter.ClearBeforeFill = true;
            // 
            // podnesi_zahtjev_gmb
            // 
            this.podnesi_zahtjev_gmb.Location = new System.Drawing.Point(47, 265);
            this.podnesi_zahtjev_gmb.Name = "podnesi_zahtjev_gmb";
            this.podnesi_zahtjev_gmb.Size = new System.Drawing.Size(132, 28);
            this.podnesi_zahtjev_gmb.TabIndex = 1;
            this.podnesi_zahtjev_gmb.Text = "Podnesi Zahtjev";
            this.podnesi_zahtjev_gmb.UseVisualStyleBackColor = true;
            this.podnesi_zahtjev_gmb.Click += new System.EventHandler(this.podnesi_zahtjev_gmb_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID zahtjeva";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // razlogDataGridViewTextBoxColumn
            // 
            this.razlogDataGridViewTextBoxColumn.DataPropertyName = "razlog";
            this.razlogDataGridViewTextBoxColumn.HeaderText = "Zahtjev";
            this.razlogDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.razlogDataGridViewTextBoxColumn.Name = "razlogDataGridViewTextBoxColumn";
            this.razlogDataGridViewTextBoxColumn.Width = 125;
            // 
            // dekanpotvrdaDataGridViewTextBoxColumn
            // 
            this.dekanpotvrdaDataGridViewTextBoxColumn.DataPropertyName = "dekan_potvrda";
            this.dekanpotvrdaDataGridViewTextBoxColumn.HeaderText = "Potvrda dekana";
            this.dekanpotvrdaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dekanpotvrdaDataGridViewTextBoxColumn.Name = "dekanpotvrdaDataGridViewTextBoxColumn";
            this.dekanpotvrdaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Lista_zahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.podnesi_zahtjev_gmb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lista_zahtjeva";
            this.Text = "Lista_zahtjeva";
            this.Load += new System.EventHandler(this.Lista_zahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzjaknikola_bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private huzjaknikola_bazaDataSet huzjaknikola_bazaDataSet;
        private System.Windows.Forms.BindingSource zahtjeviBindingSource;
        private huzjaknikola_bazaDataSetTableAdapters.zahtjeviTableAdapter zahtjeviTableAdapter;
        private System.Windows.Forms.Button podnesi_zahtjev_gmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivpodnositeljaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacinfinanciranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razlogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dekanpotvrdaDataGridViewTextBoxColumn;
    }
}