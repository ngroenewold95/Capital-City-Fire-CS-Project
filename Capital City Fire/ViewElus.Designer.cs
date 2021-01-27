
namespace Capital_City_Fire
{
    partial class ViewElus
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
            this.elu_dataGridView = new System.Windows.Forms.DataGridView();
            this.close_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_elu_button = new System.Windows.Forms.Button();
            this.eluID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eluUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eluLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eluRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildings_DataSet = new Capital_City_Fire.Buildings_DataSet();
            this.buildingsTableAdapter = new Capital_City_Fire.Buildings_DataSetTableAdapters.buildingsTableAdapter();
            this.capcityDataSet = new Capital_City_Fire.CapcityDataSet();
            this.bld_eluTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.bld_eluTableAdapter();
            this.eluListTableAdapter = new Capital_City_Fire.ELU_Types_DataSetTableAdapters.eluListTableAdapter();
            this.eLU_Types_DataSet = new Capital_City_Fire.ELU_Types_DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.elu_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLU_Types_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // elu_dataGridView
            // 
            this.elu_dataGridView.AllowUserToAddRows = false;
            this.elu_dataGridView.AllowUserToDeleteRows = false;
            this.elu_dataGridView.AllowUserToResizeColumns = false;
            this.elu_dataGridView.AllowUserToResizeRows = false;
            this.elu_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elu_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.elu_dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.elu_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elu_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eluID,
            this.eluUID,
            this.eluLocation,
            this.type,
            this.voltage,
            this.eluRemarks});
            this.elu_dataGridView.Location = new System.Drawing.Point(12, 51);
            this.elu_dataGridView.MultiSelect = false;
            this.elu_dataGridView.Name = "elu_dataGridView";
            this.elu_dataGridView.RowHeadersVisible = false;
            this.elu_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.elu_dataGridView.Size = new System.Drawing.Size(770, 286);
            this.elu_dataGridView.TabIndex = 89;
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(699, 22);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(84, 23);
            this.close_button.TabIndex = 100;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(99, 22);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(84, 23);
            this.delete_button.TabIndex = 99;
            this.delete_button.Text = "Delete ELU";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // add_elu_button
            // 
            this.add_elu_button.Location = new System.Drawing.Point(13, 22);
            this.add_elu_button.Name = "add_elu_button";
            this.add_elu_button.Size = new System.Drawing.Size(80, 23);
            this.add_elu_button.TabIndex = 98;
            this.add_elu_button.Text = "Add ELU";
            this.add_elu_button.UseVisualStyleBackColor = true;
            this.add_elu_button.Click += new System.EventHandler(this.add_elu_button_Click);
            // 
            // eluID
            // 
            this.eluID.HeaderText = "eluID";
            this.eluID.Name = "eluID";
            this.eluID.ReadOnly = true;
            this.eluID.Visible = false;
            // 
            // eluUID
            // 
            this.eluUID.HeaderText = "ELU UID";
            this.eluUID.Name = "eluUID";
            this.eluUID.ReadOnly = true;
            // 
            // eluLocation
            // 
            this.eluLocation.HeaderText = "Location";
            this.eluLocation.Name = "eluLocation";
            this.eluLocation.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // voltage
            // 
            this.voltage.HeaderText = "Voltage/Size";
            this.voltage.Name = "voltage";
            this.voltage.ReadOnly = true;
            // 
            // eluRemarks
            // 
            this.eluRemarks.HeaderText = "Remarks";
            this.eluRemarks.Name = "eluRemarks";
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
            // bld_eluTableAdapter
            // 
            this.bld_eluTableAdapter.ClearBeforeFill = true;
            // 
            // eluListTableAdapter
            // 
            this.eluListTableAdapter.ClearBeforeFill = true;
            // 
            // eLU_Types_DataSet
            // 
            this.eLU_Types_DataSet.DataSetName = "ELU_Types_DataSet";
            this.eLU_Types_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewElus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 349);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_elu_button);
            this.Controls.Add(this.elu_dataGridView);
            this.Name = "ViewElus";
            this.Text = "Capital City Fire - View ELUs";
            this.Load += new System.EventHandler(this.ViewElus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elu_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLU_Types_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView elu_dataGridView;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_elu_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn eluID;
        private System.Windows.Forms.DataGridViewTextBoxColumn eluUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn eluLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltage;
        private System.Windows.Forms.DataGridViewTextBoxColumn eluRemarks;
        private Buildings_DataSet buildings_DataSet;
        private Buildings_DataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
        private CapcityDataSet capcityDataSet;
        private CapcityDataSetTableAdapters.bld_eluTableAdapter bld_eluTableAdapter;
        private ELU_Types_DataSetTableAdapters.eluListTableAdapter eluListTableAdapter;
        private ELU_Types_DataSet eLU_Types_DataSet;
    }
}