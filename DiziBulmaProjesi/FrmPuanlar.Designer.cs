namespace DiziBulmaProjesi
{
    partial class FrmPuanlar
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
            this.diziOtagProjesiDataSet = new DiziBulmaProjesi.DiziOtagProjesiDataSet();
            this.tblPuanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PuanlarTableAdapter = new DiziBulmaProjesi.DiziOtagProjesiDataSetTableAdapters.Tbl_PuanlarTableAdapter();
            this.diziOtagProjesiDataSet1 = new DiziBulmaProjesi.DiziOtagProjesiDataSet1();
            this.tblPuanlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PuanlarTableAdapter1 = new DiziBulmaProjesi.DiziOtagProjesiDataSet1TableAdapters.Tbl_PuanlarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diziOtagProjesiDataSet2 = new DiziBulmaProjesi.DiziOtagProjesiDataSet2();
            this.tblPuanlarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PuanlarTableAdapter2 = new DiziBulmaProjesi.DiziOtagProjesiDataSet2TableAdapters.Tbl_PuanlarTableAdapter();
            this.diziAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.türüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diziOtagProjesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPuanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziOtagProjesiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPuanlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziOtagProjesiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPuanlarBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // diziOtagProjesiDataSet
            // 
            this.diziOtagProjesiDataSet.DataSetName = "DiziOtagProjesiDataSet";
            this.diziOtagProjesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPuanlarBindingSource
            // 
            this.tblPuanlarBindingSource.DataMember = "Tbl_Puanlar";
            this.tblPuanlarBindingSource.DataSource = this.diziOtagProjesiDataSet;
            // 
            // tbl_PuanlarTableAdapter
            // 
            this.tbl_PuanlarTableAdapter.ClearBeforeFill = true;
            // 
            // diziOtagProjesiDataSet1
            // 
            this.diziOtagProjesiDataSet1.DataSetName = "DiziOtagProjesiDataSet1";
            this.diziOtagProjesiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPuanlarBindingSource1
            // 
            this.tblPuanlarBindingSource1.DataMember = "Tbl_Puanlar";
            this.tblPuanlarBindingSource1.DataSource = this.diziOtagProjesiDataSet1;
            // 
            // tbl_PuanlarTableAdapter1
            // 
            this.tbl_PuanlarTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diziAdiDataGridViewTextBoxColumn,
            this.türüDataGridViewTextBoxColumn,
            this.puanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPuanlarBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1115, 638);
            this.dataGridView1.TabIndex = 0;
            // 
            // diziOtagProjesiDataSet2
            // 
            this.diziOtagProjesiDataSet2.DataSetName = "DiziOtagProjesiDataSet2";
            this.diziOtagProjesiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPuanlarBindingSource2
            // 
            this.tblPuanlarBindingSource2.DataMember = "Tbl_Puanlar";
            this.tblPuanlarBindingSource2.DataSource = this.diziOtagProjesiDataSet2;
            // 
            // tbl_PuanlarTableAdapter2
            // 
            this.tbl_PuanlarTableAdapter2.ClearBeforeFill = true;
            // 
            // diziAdiDataGridViewTextBoxColumn
            // 
            this.diziAdiDataGridViewTextBoxColumn.DataPropertyName = "DiziAdi";
            this.diziAdiDataGridViewTextBoxColumn.HeaderText = "DiziAdi";
            this.diziAdiDataGridViewTextBoxColumn.MinimumWidth = 420;
            this.diziAdiDataGridViewTextBoxColumn.Name = "diziAdiDataGridViewTextBoxColumn";
            this.diziAdiDataGridViewTextBoxColumn.Width = 420;
            // 
            // türüDataGridViewTextBoxColumn
            // 
            this.türüDataGridViewTextBoxColumn.DataPropertyName = "Türü";
            this.türüDataGridViewTextBoxColumn.HeaderText = "Türü";
            this.türüDataGridViewTextBoxColumn.MinimumWidth = 420;
            this.türüDataGridViewTextBoxColumn.Name = "türüDataGridViewTextBoxColumn";
            this.türüDataGridViewTextBoxColumn.Width = 420;
            // 
            // puanDataGridViewTextBoxColumn
            // 
            this.puanDataGridViewTextBoxColumn.DataPropertyName = "Puan";
            this.puanDataGridViewTextBoxColumn.HeaderText = "Puan";
            this.puanDataGridViewTextBoxColumn.Name = "puanDataGridViewTextBoxColumn";
            // 
            // FrmPuanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1115, 638);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmPuanlar";
            this.Text = "FrmPuanlar";
            this.Load += new System.EventHandler(this.FrmPuanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diziOtagProjesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPuanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziOtagProjesiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPuanlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziOtagProjesiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPuanlarBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DiziOtagProjesiDataSet diziOtagProjesiDataSet;
        private System.Windows.Forms.BindingSource tblPuanlarBindingSource;
        private DiziOtagProjesiDataSetTableAdapters.Tbl_PuanlarTableAdapter tbl_PuanlarTableAdapter;
        private DiziOtagProjesiDataSet1 diziOtagProjesiDataSet1;
        private System.Windows.Forms.BindingSource tblPuanlarBindingSource1;
        private DiziOtagProjesiDataSet1TableAdapters.Tbl_PuanlarTableAdapter tbl_PuanlarTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DiziOtagProjesiDataSet2 diziOtagProjesiDataSet2;
        private System.Windows.Forms.BindingSource tblPuanlarBindingSource2;
        private DiziOtagProjesiDataSet2TableAdapters.Tbl_PuanlarTableAdapter tbl_PuanlarTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diziAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn türüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puanDataGridViewTextBoxColumn;
    }
}