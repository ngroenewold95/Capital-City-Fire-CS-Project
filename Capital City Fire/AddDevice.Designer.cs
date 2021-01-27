
namespace Capital_City_Fire
{
    partial class AddDevice
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
            this.deviceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.device_Types_DataSet = new Capital_City_Fire.Device_Types_DataSet();
            this.blddevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capcityDataSet = new Capital_City_Fire.CapcityDataSet();
            this.deviceListTableAdapter = new Capital_City_Fire.Device_Types_DataSetTableAdapters.deviceListTableAdapter();
            this.bld_devTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.bld_devTableAdapter();
            this.save_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.location_text = new System.Windows.Forms.TextBox();
            this.device_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remarks_text = new System.Windows.Forms.TextBox();
            this.added_label = new System.Windows.Forms.Label();
            this.buildingsTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.buildingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Types_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blddevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceListBindingSource
            // 
            this.deviceListBindingSource.DataMember = "deviceList";
            this.deviceListBindingSource.DataSource = this.device_Types_DataSet;
            // 
            // device_Types_DataSet
            // 
            this.device_Types_DataSet.DataSetName = "Device_Types_DataSet";
            this.device_Types_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blddevBindingSource
            // 
            this.blddevBindingSource.DataMember = "bld_dev";
            this.blddevBindingSource.DataSource = this.capcityDataSet;
            // 
            // capcityDataSet
            // 
            this.capcityDataSet.DataSetName = "CapcityDataSet";
            this.capcityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deviceListTableAdapter
            // 
            this.deviceListTableAdapter.ClearBeforeFill = true;
            // 
            // bld_devTableAdapter
            // 
            this.bld_devTableAdapter.ClearBeforeFill = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(400, 91);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 20;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(319, 91);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 21;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Location";
            // 
            // location_text
            // 
            this.location_text.Location = new System.Drawing.Point(12, 36);
            this.location_text.Name = "location_text";
            this.location_text.Size = new System.Drawing.Size(100, 20);
            this.location_text.TabIndex = 22;
            // 
            // device_comboBox
            // 
            this.device_comboBox.DataSource = this.deviceListBindingSource;
            this.device_comboBox.DisplayMember = "deviceCode";
            this.device_comboBox.FormattingEnabled = true;
            this.device_comboBox.Location = new System.Drawing.Point(118, 35);
            this.device_comboBox.Name = "device_comboBox";
            this.device_comboBox.Size = new System.Drawing.Size(98, 21);
            this.device_comboBox.TabIndex = 24;
            this.device_comboBox.ValueMember = "deviceID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Device";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Remarks";
            // 
            // remarks_text
            // 
            this.remarks_text.Location = new System.Drawing.Point(222, 36);
            this.remarks_text.Name = "remarks_text";
            this.remarks_text.Size = new System.Drawing.Size(253, 20);
            this.remarks_text.TabIndex = 26;
            // 
            // added_label
            // 
            this.added_label.AutoSize = true;
            this.added_label.Location = new System.Drawing.Point(9, 71);
            this.added_label.Name = "added_label";
            this.added_label.Size = new System.Drawing.Size(283, 65);
            this.added_label.TabIndex = 28;
            this.added_label.Text = "Device added to building. \r\n\r\nContinue saving new devices or click Close when fin" +
    "ished.\r\n\r\n\r\n";
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 136);
            this.Controls.Add(this.added_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.remarks_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.device_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location_text);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.save_button);
            this.Name = "AddDevice";
            this.Text = "Capital City Fire - Add Devices to Building";
            this.Load += new System.EventHandler(this.AddDevices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Types_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blddevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Device_Types_DataSet device_Types_DataSet;
        private System.Windows.Forms.BindingSource deviceListBindingSource;
        private Device_Types_DataSetTableAdapters.deviceListTableAdapter deviceListTableAdapter;
        private CapcityDataSet capcityDataSet;
        private System.Windows.Forms.BindingSource blddevBindingSource;
        private CapcityDataSetTableAdapters.bld_devTableAdapter bld_devTableAdapter;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox location_text;
        private System.Windows.Forms.ComboBox device_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remarks_text;
        private System.Windows.Forms.Label added_label;
        private CapcityDataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
    }
}