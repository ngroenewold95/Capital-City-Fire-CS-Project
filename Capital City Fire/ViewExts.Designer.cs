
namespace Capital_City_Fire
{
    partial class ViewExts
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
            this.ext_dataGridView = new System.Windows.Forms.DataGridView();
            this.extID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.close_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_ext_button = new System.Windows.Forms.Button();
            this.buildings_DataSet = new Capital_City_Fire.Buildings_DataSet();
            this.buildingsTableAdapter = new Capital_City_Fire.Buildings_DataSetTableAdapters.buildingsTableAdapter();
            this.capcityDataSet = new Capital_City_Fire.CapcityDataSet();
            this.eXT_Types_DataSet = new Capital_City_Fire.EXT_Types_DataSet();
            this.bld_extTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.bld_extTableAdapter();
            this.extListTableAdapter = new Capital_City_Fire.EXT_Types_DataSetTableAdapters.extListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ext_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXT_Types_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ext_dataGridView
            // 
            this.ext_dataGridView.AllowUserToAddRows = false;
            this.ext_dataGridView.AllowUserToDeleteRows = false;
            this.ext_dataGridView.AllowUserToResizeColumns = false;
            this.ext_dataGridView.AllowUserToResizeRows = false;
            this.ext_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ext_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ext_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ext_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ext_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.extID,
            this.extUID,
            this.extLocation,
            this.sizeType,
            this.serial,
            this.mfgDate,
            this.srvDate,
            this.extRemarks});
            this.ext_dataGridView.Location = new System.Drawing.Point(12, 51);
            this.ext_dataGridView.MultiSelect = false;
            this.ext_dataGridView.Name = "ext_dataGridView";
            this.ext_dataGridView.RowHeadersVisible = false;
            this.ext_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ext_dataGridView.Size = new System.Drawing.Size(770, 286);
            this.ext_dataGridView.TabIndex = 90;
            // 
            // extID
            // 
            this.extID.HeaderText = "extID";
            this.extID.Name = "extID";
            this.extID.ReadOnly = true;
            this.extID.Visible = false;
            // 
            // extUID
            // 
            this.extUID.HeaderText = "Extinguisher UID";
            this.extUID.Name = "extUID";
            this.extUID.ReadOnly = true;
            // 
            // extLocation
            // 
            this.extLocation.HeaderText = "Location";
            this.extLocation.Name = "extLocation";
            this.extLocation.ReadOnly = true;
            // 
            // sizeType
            // 
            this.sizeType.HeaderText = "Size/Type";
            this.sizeType.Name = "sizeType";
            this.sizeType.ReadOnly = true;
            // 
            // serial
            // 
            this.serial.HeaderText = "Serial #";
            this.serial.Name = "serial";
            this.serial.ReadOnly = true;
            // 
            // mfgDate
            // 
            this.mfgDate.HeaderText = "Mfg Date";
            this.mfgDate.Name = "mfgDate";
            this.mfgDate.ReadOnly = true;
            // 
            // srvDate
            // 
            this.srvDate.HeaderText = "Srv Date";
            this.srvDate.Name = "srvDate";
            this.srvDate.ReadOnly = true;
            // 
            // extRemarks
            // 
            this.extRemarks.HeaderText = "Remarks";
            this.extRemarks.Name = "extRemarks";
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(698, 22);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(84, 23);
            this.close_button.TabIndex = 100;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(128, 22);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(116, 23);
            this.delete_button.TabIndex = 99;
            this.delete_button.Text = "Delete Extiguisher";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // add_ext_button
            // 
            this.add_ext_button.Location = new System.Drawing.Point(12, 22);
            this.add_ext_button.Name = "add_ext_button";
            this.add_ext_button.Size = new System.Drawing.Size(110, 23);
            this.add_ext_button.TabIndex = 98;
            this.add_ext_button.Text = "Add Extinguisher";
            this.add_ext_button.UseVisualStyleBackColor = true;
            this.add_ext_button.Click += new System.EventHandler(this.add_ext_button_Click);
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
            // eXT_Types_DataSet
            // 
            this.eXT_Types_DataSet.DataSetName = "EXT_Types_DataSet";
            this.eXT_Types_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bld_extTableAdapter
            // 
            this.bld_extTableAdapter.ClearBeforeFill = true;
            // 
            // extListTableAdapter
            // 
            this.extListTableAdapter.ClearBeforeFill = true;
            // 
            // ViewExts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 349);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_ext_button);
            this.Controls.Add(this.ext_dataGridView);
            this.Name = "ViewExts";
            this.Text = "Capital City Fire - View Extinguishers";
            this.Load += new System.EventHandler(this.ViewExts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ext_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eXT_Types_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ext_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn extID;
        private System.Windows.Forms.DataGridViewTextBoxColumn extUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn extLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn srvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn extRemarks;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_ext_button;
        private Buildings_DataSet buildings_DataSet;
        private Buildings_DataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
        private CapcityDataSet capcityDataSet;
        private EXT_Types_DataSet eXT_Types_DataSet;
        private CapcityDataSetTableAdapters.bld_extTableAdapter bld_extTableAdapter;
        private EXT_Types_DataSetTableAdapters.extListTableAdapter extListTableAdapter;
    }
}