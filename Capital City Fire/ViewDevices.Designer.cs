
namespace Capital_City_Fire
{
    partial class ViewDevices
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
            this.buildings_DataSet = new Capital_City_Fire.Buildings_DataSet();
            this.buildingsTableAdapter = new Capital_City_Fire.Buildings_DataSetTableAdapters.buildingsTableAdapter();
            this.capcityDataSet = new Capital_City_Fire.CapcityDataSet();
            this.bld_devTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.bld_devTableAdapter();
            this.deviceListTableAdapter = new Capital_City_Fire.Device_Types_DataSetTableAdapters.deviceListTableAdapter();
            this.device_Types_DataSet = new Capital_City_Fire.Device_Types_DataSet();
            this.dev_dataGridView = new System.Windows.Forms.DataGridView();
            this.deviceUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_device_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Types_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dev_dataGridView)).BeginInit();
            this.SuspendLayout();
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
            // capcityDataSet
            // 
            this.capcityDataSet.DataSetName = "CapcityDataSet";
            this.capcityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bld_devTableAdapter
            // 
            this.bld_devTableAdapter.ClearBeforeFill = true;
            // 
            // deviceListTableAdapter
            // 
            this.deviceListTableAdapter.ClearBeforeFill = true;
            // 
            // device_Types_DataSet
            // 
            this.device_Types_DataSet.DataSetName = "Device_Types_DataSet";
            this.device_Types_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dev_dataGridView
            // 
            this.dev_dataGridView.AllowDrop = true;
            this.dev_dataGridView.AllowUserToAddRows = false;
            this.dev_dataGridView.AllowUserToDeleteRows = false;
            this.dev_dataGridView.AllowUserToResizeColumns = false;
            this.dev_dataGridView.AllowUserToResizeRows = false;
            this.dev_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dev_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dev_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dev_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dev_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceUID,
            this.deviceID,
            this.deviceLocation,
            this.deviceCode,
            this.remarks});
            this.dev_dataGridView.Location = new System.Drawing.Point(12, 51);
            this.dev_dataGridView.MultiSelect = false;
            this.dev_dataGridView.Name = "dev_dataGridView";
            this.dev_dataGridView.RowHeadersVisible = false;
            this.dev_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dev_dataGridView.Size = new System.Drawing.Size(770, 286);
            this.dev_dataGridView.TabIndex = 86;
            // 
            // deviceUID
            // 
            this.deviceUID.HeaderText = "Device UID";
            this.deviceUID.Name = "deviceUID";
            this.deviceUID.ReadOnly = true;
            // 
            // deviceID
            // 
            this.deviceID.HeaderText = "deviceID";
            this.deviceID.Name = "deviceID";
            this.deviceID.ReadOnly = true;
            this.deviceID.Visible = false;
            // 
            // deviceLocation
            // 
            this.deviceLocation.HeaderText = "Device Location";
            this.deviceLocation.Name = "deviceLocation";
            this.deviceLocation.ReadOnly = true;
            // 
            // deviceCode
            // 
            this.deviceCode.HeaderText = "Device";
            this.deviceCode.Name = "deviceCode";
            this.deviceCode.ReadOnly = true;
            // 
            // remarks
            // 
            this.remarks.HeaderText = "Remarks";
            this.remarks.Name = "remarks";
            // 
            // add_device_button
            // 
            this.add_device_button.Location = new System.Drawing.Point(12, 22);
            this.add_device_button.Name = "add_device_button";
            this.add_device_button.Size = new System.Drawing.Size(80, 23);
            this.add_device_button.TabIndex = 87;
            this.add_device_button.Text = "Add Device";
            this.add_device_button.UseVisualStyleBackColor = true;
            this.add_device_button.Click += new System.EventHandler(this.add_device_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(98, 22);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(84, 23);
            this.delete_button.TabIndex = 96;
            this.delete_button.Text = "Delete Device";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(698, 22);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(84, 23);
            this.close_button.TabIndex = 97;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // ViewDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 349);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_device_button);
            this.Controls.Add(this.dev_dataGridView);
            this.Name = "ViewDevices";
            this.Text = "Capital City Fire - View Devices";
            this.Load += new System.EventHandler(this.ViewDevices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Types_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dev_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Buildings_DataSet buildings_DataSet;
        private Buildings_DataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
        private CapcityDataSet capcityDataSet;
        private CapcityDataSetTableAdapters.bld_devTableAdapter bld_devTableAdapter;
        private Device_Types_DataSetTableAdapters.deviceListTableAdapter deviceListTableAdapter;
        private Device_Types_DataSet device_Types_DataSet;
        private System.Windows.Forms.DataGridView dev_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.Button add_device_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button close_button;
    }
}