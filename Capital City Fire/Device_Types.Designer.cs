
namespace Capital_City_Fire
{
    partial class Device_Types
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
            this.clear_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deviceCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.device_Types_DataSet = new Capital_City_Fire.Device_Types_DataSet();
            this.deviceListTableAdapter = new Capital_City_Fire.Device_Types_DataSetTableAdapters.deviceListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Types_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(174, 12);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(143, 23);
            this.clear_button.TabIndex = 15;
            this.clear_button.Text = "Clear Unsaved Changes";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // save_button
            // 
            this.save_button.Enabled = false;
            this.save_button.Location = new System.Drawing.Point(93, 12);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 14;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // new_button
            // 
            this.new_button.Location = new System.Drawing.Point(12, 12);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(75, 23);
            this.new_button.TabIndex = 12;
            this.new_button.Text = "Add/Edit";
            this.new_button.UseVisualStyleBackColor = true;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(713, 12);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(75, 23);
            this.home_button.TabIndex = 11;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.Home_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceCodeDataGridViewTextBoxColumn,
            this.aDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.dDataGridViewTextBoxColumn,
            this.eDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deviceListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 317);
            this.dataGridView1.TabIndex = 10;
            // 
            // deviceCodeDataGridViewTextBoxColumn
            // 
            this.deviceCodeDataGridViewTextBoxColumn.DataPropertyName = "deviceCode";
            this.deviceCodeDataGridViewTextBoxColumn.HeaderText = "Device";
            this.deviceCodeDataGridViewTextBoxColumn.Name = "deviceCodeDataGridViewTextBoxColumn";
            this.deviceCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.DataPropertyName = "a";
            this.aDataGridViewTextBoxColumn.HeaderText = "Installed Correctly";
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            this.aDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "b";
            this.bDataGridViewTextBoxColumn.HeaderText = "Required Service";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "c";
            this.cDataGridViewTextBoxColumn.HeaderText = "Alarm Operation Confirmed";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDataGridViewTextBoxColumn
            // 
            this.dDataGridViewTextBoxColumn.DataPropertyName = "d";
            this.dDataGridViewTextBoxColumn.HeaderText = "Annunciation Indication Confirmed";
            this.dDataGridViewTextBoxColumn.Name = "dDataGridViewTextBoxColumn";
            this.dDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eDataGridViewTextBoxColumn
            // 
            this.eDataGridViewTextBoxColumn.DataPropertyName = "e";
            this.eDataGridViewTextBoxColumn.HeaderText = "Circuit Number or Address (Zone)";
            this.eDataGridViewTextBoxColumn.Name = "eDataGridViewTextBoxColumn";
            this.eDataGridViewTextBoxColumn.ReadOnly = true;
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
            // deviceListTableAdapter
            // 
            this.deviceListTableAdapter.ClearBeforeFill = true;
            // 
            // Device_Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Device_Types";
            this.Text = "Capital City Fire - Device Types";
            this.Load += new System.EventHandler(this.Device_Types_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.device_Types_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Device_Types_DataSet device_Types_DataSet;
        private System.Windows.Forms.BindingSource deviceListBindingSource;
        private Device_Types_DataSetTableAdapters.deviceListTableAdapter deviceListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDataGridViewTextBoxColumn;
    }
}