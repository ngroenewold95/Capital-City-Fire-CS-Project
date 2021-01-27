
namespace Capital_City_Fire
{
    partial class Reports
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
            this.capcityDataSet = new Capital_City_Fire.CapcityDataSet();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companiesTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.companiesTableAdapter();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.buildingsTableAdapter();
            this.report_dataGridView = new System.Windows.Forms.DataGridView();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report_button = new System.Windows.Forms.Button();
            this.reportTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.reportTableAdapter();
            this.home_button = new System.Windows.Forms.Button();
            this.buildingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfReportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eluCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // capcityDataSet
            // 
            this.capcityDataSet.DataSetName = "CapcityDataSet";
            this.capcityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "companies";
            this.companiesBindingSource.DataSource = this.capcityDataSet;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "buildings";
            this.buildingsBindingSource.DataSource = this.capcityDataSet;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // report_dataGridView
            // 
            this.report_dataGridView.AllowUserToAddRows = false;
            this.report_dataGridView.AllowUserToDeleteRows = false;
            this.report_dataGridView.AllowUserToResizeColumns = false;
            this.report_dataGridView.AllowUserToResizeRows = false;
            this.report_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report_dataGridView.AutoGenerateColumns = false;
            this.report_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.report_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.report_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingIDDataGridViewTextBoxColumn,
            this.reportIDDataGridViewTextBoxColumn,
            this.address,
            this.dateOfReportDataGridViewTextBoxColumn,
            this.deviceCommentsDataGridViewTextBoxColumn,
            this.eluCommentsDataGridViewTextBoxColumn,
            this.extCommentsDataGridViewTextBoxColumn});
            this.report_dataGridView.DataSource = this.reportBindingSource;
            this.report_dataGridView.Location = new System.Drawing.Point(12, 88);
            this.report_dataGridView.Name = "report_dataGridView";
            this.report_dataGridView.ReadOnly = true;
            this.report_dataGridView.RowHeadersVisible = false;
            this.report_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.report_dataGridView.Size = new System.Drawing.Size(776, 350);
            this.report_dataGridView.TabIndex = 17;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "report";
            this.reportBindingSource.DataSource = this.capcityDataSet;
            // 
            // report_button
            // 
            this.report_button.Location = new System.Drawing.Point(622, 32);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(75, 23);
            this.report_button.TabIndex = 18;
            this.report_button.Text = "View Report";
            this.report_button.UseVisualStyleBackColor = true;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(703, 32);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(75, 23);
            this.home_button.TabIndex = 19;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // buildingIDDataGridViewTextBoxColumn
            // 
            this.buildingIDDataGridViewTextBoxColumn.DataPropertyName = "buildingID";
            this.buildingIDDataGridViewTextBoxColumn.HeaderText = "buildingID";
            this.buildingIDDataGridViewTextBoxColumn.Name = "buildingIDDataGridViewTextBoxColumn";
            this.buildingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.buildingIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // reportIDDataGridViewTextBoxColumn
            // 
            this.reportIDDataGridViewTextBoxColumn.DataPropertyName = "reportID";
            this.reportIDDataGridViewTextBoxColumn.HeaderText = "Report ID";
            this.reportIDDataGridViewTextBoxColumn.Name = "reportIDDataGridViewTextBoxColumn";
            this.reportIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // dateOfReportDataGridViewTextBoxColumn
            // 
            this.dateOfReportDataGridViewTextBoxColumn.DataPropertyName = "dateOfReport";
            this.dateOfReportDataGridViewTextBoxColumn.HeaderText = "Date of Report";
            this.dateOfReportDataGridViewTextBoxColumn.Name = "dateOfReportDataGridViewTextBoxColumn";
            this.dateOfReportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceCommentsDataGridViewTextBoxColumn
            // 
            this.deviceCommentsDataGridViewTextBoxColumn.DataPropertyName = "deviceComments";
            this.deviceCommentsDataGridViewTextBoxColumn.HeaderText = "Device Comments";
            this.deviceCommentsDataGridViewTextBoxColumn.Name = "deviceCommentsDataGridViewTextBoxColumn";
            this.deviceCommentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eluCommentsDataGridViewTextBoxColumn
            // 
            this.eluCommentsDataGridViewTextBoxColumn.DataPropertyName = "eluComments";
            this.eluCommentsDataGridViewTextBoxColumn.HeaderText = "ELU Comments";
            this.eluCommentsDataGridViewTextBoxColumn.Name = "eluCommentsDataGridViewTextBoxColumn";
            this.eluCommentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extCommentsDataGridViewTextBoxColumn
            // 
            this.extCommentsDataGridViewTextBoxColumn.DataPropertyName = "extComments";
            this.extCommentsDataGridViewTextBoxColumn.HeaderText = "Ext Comments";
            this.extCommentsDataGridViewTextBoxColumn.Name = "extCommentsDataGridViewTextBoxColumn";
            this.extCommentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.report_dataGridView);
            this.Name = "Reports";
            this.Text = "Capital City Fire - Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CapcityDataSet capcityDataSet;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private CapcityDataSetTableAdapters.companiesTableAdapter companiesTableAdapter;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private CapcityDataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.DataGridView report_dataGridView;
        private System.Windows.Forms.Button report_button;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private CapcityDataSetTableAdapters.reportTableAdapter reportTableAdapter;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfReportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceCommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eluCommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extCommentsDataGridViewTextBoxColumn;
    }
}