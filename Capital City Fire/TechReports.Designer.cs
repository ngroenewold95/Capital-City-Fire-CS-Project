
namespace Capital_City_Fire
{
    partial class TechReports
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
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.reportTableAdapter();
            this.buildings_DataSet = new Capital_City_Fire.Buildings_DataSet();
            this.buildingsTableAdapter = new Capital_City_Fire.Buildings_DataSetTableAdapters.buildingsTableAdapter();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniciansTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.techniciansTableAdapter();
            this.reporttechBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report_techTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.report_techTableAdapter();
            this.report_dataGridView = new System.Windows.Forms.DataGridView();
            this.reportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tech_label = new System.Windows.Forms.Label();
            this.view_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporttechBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // capcityDataSet
            // 
            this.capcityDataSet.DataSetName = "CapcityDataSet";
            this.capcityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "report";
            this.reportBindingSource.DataSource = this.capcityDataSet;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // buildings_DataSet
            // 
            this.buildings_DataSet.DataSetName = "Buildings_DataSet";
            this.buildings_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "buildings";
            this.buildingsBindingSource.DataSource = this.buildings_DataSet;
            // 
            // techniciansBindingSource
            // 
            this.techniciansBindingSource.DataMember = "technicians";
            this.techniciansBindingSource.DataSource = this.capcityDataSet;
            // 
            // techniciansTableAdapter
            // 
            this.techniciansTableAdapter.ClearBeforeFill = true;
            // 
            // reporttechBindingSource
            // 
            this.reporttechBindingSource.DataMember = "report_tech";
            this.reporttechBindingSource.DataSource = this.capcityDataSet;
            // 
            // report_techTableAdapter
            // 
            this.report_techTableAdapter.ClearBeforeFill = true;
            // 
            // report_dataGridView
            // 
            this.report_dataGridView.AllowUserToAddRows = false;
            this.report_dataGridView.AllowUserToDeleteRows = false;
            this.report_dataGridView.AllowUserToResizeRows = false;
            this.report_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.report_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.report_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportID,
            this.address,
            this.dateOfReport});
            this.report_dataGridView.Location = new System.Drawing.Point(12, 128);
            this.report_dataGridView.Name = "report_dataGridView";
            this.report_dataGridView.ReadOnly = true;
            this.report_dataGridView.RowHeadersVisible = false;
            this.report_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.report_dataGridView.Size = new System.Drawing.Size(356, 310);
            this.report_dataGridView.TabIndex = 19;
            // 
            // reportID
            // 
            this.reportID.HeaderText = "Report ID";
            this.reportID.Name = "reportID";
            this.reportID.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // dateOfReport
            // 
            this.dateOfReport.HeaderText = "Date Of Report";
            this.dateOfReport.Name = "dateOfReport";
            this.dateOfReport.ReadOnly = true;
            // 
            // tech_label
            // 
            this.tech_label.AutoSize = true;
            this.tech_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tech_label.Location = new System.Drawing.Point(81, 9);
            this.tech_label.Name = "tech_label";
            this.tech_label.Size = new System.Drawing.Size(28, 31);
            this.tech_label.TabIndex = 20;
            this.tech_label.Text = "  ";
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(12, 99);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(75, 23);
            this.view_button.TabIndex = 21;
            this.view_button.Text = "View Report";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(293, 99);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 22;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // TechReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.tech_label);
            this.Controls.Add(this.report_dataGridView);
            this.Name = "TechReports";
            this.Text = "Capital City Fire - Technicians Reports";
            this.Load += new System.EventHandler(this.TechReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporttechBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CapcityDataSet capcityDataSet;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private CapcityDataSetTableAdapters.reportTableAdapter reportTableAdapter;
        private Buildings_DataSet buildings_DataSet;
        private Buildings_DataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private System.Windows.Forms.BindingSource techniciansBindingSource;
        private CapcityDataSetTableAdapters.techniciansTableAdapter techniciansTableAdapter;
        private System.Windows.Forms.BindingSource reporttechBindingSource;
        private CapcityDataSetTableAdapters.report_techTableAdapter report_techTableAdapter;
        private System.Windows.Forms.DataGridView report_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfReport;
        private System.Windows.Forms.Label tech_label;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.Button close_button;
    }
}