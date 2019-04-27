namespace HW4_ADO.NET_
{
    partial class Form4
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
            this.salesDBDataSet2 = new HW4_ADO.NET_.SalesDBDataSet2();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new HW4_ADO.NET_.SalesDBDataSet2TableAdapters.ItemsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sellerIdDataGridViewTextBoxColumn,
            this.buyerIdDataGridViewTextBoxColumn,
            this.priceItemsDataGridViewTextBoxColumn,
            this.dateDealDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(118, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // salesDBDataSet2
            // 
            this.salesDBDataSet2.DataSetName = "SalesDBDataSet2";
            this.salesDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.salesDBDataSet2;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerIdDataGridViewTextBoxColumn
            // 
            this.sellerIdDataGridViewTextBoxColumn.DataPropertyName = "SellerId";
            this.sellerIdDataGridViewTextBoxColumn.HeaderText = "SellerId";
            this.sellerIdDataGridViewTextBoxColumn.Name = "sellerIdDataGridViewTextBoxColumn";
            // 
            // buyerIdDataGridViewTextBoxColumn
            // 
            this.buyerIdDataGridViewTextBoxColumn.DataPropertyName = "BuyerId";
            this.buyerIdDataGridViewTextBoxColumn.HeaderText = "BuyerId";
            this.buyerIdDataGridViewTextBoxColumn.Name = "buyerIdDataGridViewTextBoxColumn";
            // 
            // priceItemsDataGridViewTextBoxColumn
            // 
            this.priceItemsDataGridViewTextBoxColumn.DataPropertyName = "PriceItems";
            this.priceItemsDataGridViewTextBoxColumn.HeaderText = "PriceItems";
            this.priceItemsDataGridViewTextBoxColumn.Name = "priceItemsDataGridViewTextBoxColumn";
            // 
            // dateDealDataGridViewTextBoxColumn
            // 
            this.dateDealDataGridViewTextBoxColumn.DataPropertyName = "DateDeal";
            this.dateDealDataGridViewTextBoxColumn.HeaderText = "DateDeal";
            this.dateDealDataGridViewTextBoxColumn.Name = "dateDealDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalesDBDataSet2 salesDBDataSet2;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SalesDBDataSet2TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDealDataGridViewTextBoxColumn;
    }
}