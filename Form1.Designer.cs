namespace Nabava
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
            this.zahtjevi = new System.Windows.Forms.DataGridView();
            this.nhuzjak20DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhuzjak20_DBDataSet = new Nabava.nhuzjak20_DBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhuzjak20DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhuzjak20_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // zahtjevi
            // 
            this.zahtjevi.AutoGenerateColumns = false;
            this.zahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zahtjevi.DataSource = this.nhuzjak20DBDataSetBindingSource;
            this.zahtjevi.Location = new System.Drawing.Point(33, 27);
            this.zahtjevi.Name = "zahtjevi";
            this.zahtjevi.RowHeadersWidth = 51;
            this.zahtjevi.RowTemplate.Height = 24;
            this.zahtjevi.Size = new System.Drawing.Size(732, 220);
            this.zahtjevi.TabIndex = 0;
            this.zahtjevi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nhuzjak20DBDataSetBindingSource
            // 
            this.nhuzjak20DBDataSetBindingSource.DataSource = this.nhuzjak20_DBDataSet;
            this.nhuzjak20DBDataSetBindingSource.Position = 0;
            // 
            // nhuzjak20_DBDataSet
            // 
            this.nhuzjak20_DBDataSet.DataSetName = "nhuzjak20_DBDataSet";
            this.nhuzjak20_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zahtjevi);
            this.Name = "Form1";
            this.Text = "Nabava";
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhuzjak20DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhuzjak20_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView zahtjevi;
        private System.Windows.Forms.BindingSource nhuzjak20DBDataSetBindingSource;
        private nhuzjak20_DBDataSet nhuzjak20_DBDataSet;
    }
}