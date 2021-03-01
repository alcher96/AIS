namespace AIS
{
    partial class lists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lists));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uTT_dbDataSet4 = new AIS.UTT_dbDataSet4();
            this.listsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listsTableAdapter = new AIS.UTT_dbDataSet4TableAdapters.listsTableAdapter();
            this.uTT_dbDataSet5 = new AIS.UTT_dbDataSet5();
            this.listsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listsTableAdapter1 = new AIS.UTT_dbDataSet5TableAdapters.listsTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTT_dbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTT_dbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.DataSource = this.listsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(357, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Реестр путевых листов";
            // 
            // uTT_dbDataSet4
            // 
            this.uTT_dbDataSet4.DataSetName = "UTT_dbDataSet4";
            this.uTT_dbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listsBindingSource
            // 
            this.listsBindingSource.DataMember = "lists";
            this.listsBindingSource.DataSource = this.uTT_dbDataSet4;
            // 
            // listsTableAdapter
            // 
            this.listsTableAdapter.ClearBeforeFill = true;
            // 
            // uTT_dbDataSet5
            // 
            this.uTT_dbDataSet5.DataSetName = "UTT_dbDataSet5";
            this.uTT_dbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listsBindingSource1
            // 
            this.listsBindingSource1.DataMember = "lists";
            this.listsBindingSource1.DataSource = this.uTT_dbDataSet5;
            // 
            // listsTableAdapter1
            // 
            this.listsTableAdapter1.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "list_date";
            this.Column1.HeaderText = "Дата выдачи";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "list_name";
            this.Column2.HeaderText = "Номер";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "list_organization";
            this.Column3.HeaderText = "Организация";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "list_vehicle_type";
            this.Column4.HeaderText = "Транспорт";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "list_driver_name";
            this.Column5.HeaderText = "Водитель";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "list_date_in";
            this.Column6.HeaderText = "Дата и время выезда";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "list_date_out";
            this.Column7.HeaderText = "Дата и время возвращения";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "list_marshryt";
            this.Column8.HeaderText = "Маршрут";
            this.Column8.Name = "Column8";
            // 
            // lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 294);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lists";
            this.Text = "Реестр путевых листов";
            this.Load += new System.EventHandler(this.lists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTT_dbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTT_dbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private UTT_dbDataSet4 uTT_dbDataSet4;
        private System.Windows.Forms.BindingSource listsBindingSource;
        private UTT_dbDataSet4TableAdapters.listsTableAdapter listsTableAdapter;
        private UTT_dbDataSet5 uTT_dbDataSet5;
        private System.Windows.Forms.BindingSource listsBindingSource1;
        private UTT_dbDataSet5TableAdapters.listsTableAdapter listsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}