
namespace Capital_City_Fire
{
    partial class BuildingReports
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
            this.report_dataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.altname_text = new System.Windows.Forms.TextBox();
            this.province_text = new System.Windows.Forms.TextBox();
            this.city_text = new System.Windows.Forms.TextBox();
            this.postalcode_text = new System.Windows.Forms.TextBox();
            this.street_text = new System.Windows.Forms.TextBox();
            this.streetnumber_text = new System.Windows.Forms.TextBox();
            this.new_button = new System.Windows.Forms.Button();
            this.view_button = new System.Windows.Forms.Button();
            this.buildings_DataSet = new Capital_City_Fire.Buildings_DataSet();
            this.buildingsTableAdapter = new Capital_City_Fire.Buildings_DataSetTableAdapters.buildingsTableAdapter();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capcityDataSet = new Capital_City_Fire.CapcityDataSet();
            this.reportTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.reportTableAdapter();
            this.refresh_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.report_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // report_dataGridView
            // 
            this.report_dataGridView.AllowUserToAddRows = false;
            this.report_dataGridView.AllowUserToDeleteRows = false;
            this.report_dataGridView.AllowUserToResizeColumns = false;
            this.report_dataGridView.AllowUserToResizeRows = false;
            this.report_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.report_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.report_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportID,
            this.dateOfReport});
            this.report_dataGridView.Location = new System.Drawing.Point(378, 24);
            this.report_dataGridView.Name = "report_dataGridView";
            this.report_dataGridView.ReadOnly = true;
            this.report_dataGridView.RowHeadersVisible = false;
            this.report_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.report_dataGridView.Size = new System.Drawing.Size(175, 303);
            this.report_dataGridView.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Alternate Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Province";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Postal Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Street";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Street Number";
            // 
            // altname_text
            // 
            this.altname_text.Location = new System.Drawing.Point(254, 82);
            this.altname_text.Name = "altname_text";
            this.altname_text.Size = new System.Drawing.Size(100, 20);
            this.altname_text.TabIndex = 65;
            // 
            // province_text
            // 
            this.province_text.Location = new System.Drawing.Point(134, 82);
            this.province_text.Name = "province_text";
            this.province_text.Size = new System.Drawing.Size(100, 20);
            this.province_text.TabIndex = 61;
            // 
            // city_text
            // 
            this.city_text.Location = new System.Drawing.Point(11, 82);
            this.city_text.Name = "city_text";
            this.city_text.Size = new System.Drawing.Size(100, 20);
            this.city_text.TabIndex = 63;
            // 
            // postalcode_text
            // 
            this.postalcode_text.Location = new System.Drawing.Point(254, 40);
            this.postalcode_text.Name = "postalcode_text";
            this.postalcode_text.Size = new System.Drawing.Size(100, 20);
            this.postalcode_text.TabIndex = 59;
            // 
            // street_text
            // 
            this.street_text.Location = new System.Drawing.Point(134, 40);
            this.street_text.Name = "street_text";
            this.street_text.Size = new System.Drawing.Size(100, 20);
            this.street_text.TabIndex = 57;
            // 
            // streetnumber_text
            // 
            this.streetnumber_text.Location = new System.Drawing.Point(11, 40);
            this.streetnumber_text.Name = "streetnumber_text";
            this.streetnumber_text.Size = new System.Drawing.Size(100, 20);
            this.streetnumber_text.TabIndex = 55;
            // 
            // new_button
            // 
            this.new_button.Location = new System.Drawing.Point(279, 128);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(75, 23);
            this.new_button.TabIndex = 85;
            this.new_button.Text = "New Report";
            this.new_button.UseVisualStyleBackColor = true;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(279, 157);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(75, 23);
            this.view_button.TabIndex = 86;
            this.view_button.Text = "View Report";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
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
            // reportID
            // 
            this.reportID.HeaderText = "Report ID";
            this.reportID.Name = "reportID";
            this.reportID.ReadOnly = true;
            // 
            // dateOfReport
            // 
            this.dateOfReport.HeaderText = "Date Of Report";
            this.dateOfReport.Name = "dateOfReport";
            this.dateOfReport.ReadOnly = true;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataMember = "report";
            this.reportBindingSource.DataSource = this.capcityDataSet;
            // 
            // capcityDataSet
            // 
            this.capcityDataSet.DataSetName = "CapcityDataSet";
            this.capcityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportTableAdapter
            // 
            this.reportTableAdapter.ClearBeforeFill = true;
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(279, 186);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 87;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(279, 215);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 88;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // BuildingReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 342);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.altname_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.city_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.province_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.postalcode_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.street_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.streetnumber_text);
            this.Controls.Add(this.report_dataGridView);
            this.Name = "BuildingReports";
            this.Text = "Capital City Fire - Building Reports";
            this.Load += new System.EventHandler(this.BuildingReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView report_dataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox altname_text;
        private System.Windows.Forms.TextBox province_text;
        private System.Windows.Forms.TextBox city_text;
        private System.Windows.Forms.TextBox postalcode_text;
        private System.Windows.Forms.TextBox street_text;
        private System.Windows.Forms.TextBox streetnumber_text;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button view_button;
        private CapcityDataSet capcityDataSet;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private CapcityDataSetTableAdapters.reportTableAdapter reportTableAdapter;
        private Buildings_DataSet buildings_DataSet;
        private Buildings_DataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfReport;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button close_button;
    }
}