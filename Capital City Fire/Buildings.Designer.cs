
namespace Capital_City_Fire
{
    partial class Buildings
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
            this.new_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buildingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildings_DataSet = new Capital_City_Fire.Buildings_DataSet();
            this.buildingsTableAdapter = new Capital_City_Fire.Buildings_DataSetTableAdapters.buildingsTableAdapter();
            this.refresh_button = new System.Windows.Forms.Button();
            this.view_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // new_button
            // 
            this.new_button.Location = new System.Drawing.Point(12, 12);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(75, 23);
            this.new_button.TabIndex = 18;
            this.new_button.Text = "Add New";
            this.new_button.UseVisualStyleBackColor = true;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(713, 12);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(75, 23);
            this.home_button.TabIndex = 17;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.Home_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.buildingID,
            this.streetNumberDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.altNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buildingsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 350);
            this.dataGridView1.TabIndex = 16;
            // 
            // buildingID
            // 
            this.buildingID.DataPropertyName = "buildingID";
            this.buildingID.HeaderText = "buildingID";
            this.buildingID.Name = "buildingID";
            this.buildingID.ReadOnly = true;
            this.buildingID.Visible = false;
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            this.streetNumberDataGridViewTextBoxColumn.DataPropertyName = "streetNumber";
            this.streetNumberDataGridViewTextBoxColumn.HeaderText = "Street Number";
            this.streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            this.streetNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "postalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "Postal Code";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // altNameDataGridViewTextBoxColumn
            // 
            this.altNameDataGridViewTextBoxColumn.DataPropertyName = "altName";
            this.altNameDataGridViewTextBoxColumn.HeaderText = "Alternate Name";
            this.altNameDataGridViewTextBoxColumn.Name = "altNameDataGridViewTextBoxColumn";
            this.altNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "buildings";
            this.buildingsBindingSource.DataSource = this.buildings_DataSet;
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
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(632, 12);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 20;
            this.refresh_button.Text = "Refresh List";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(93, 12);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(156, 23);
            this.view_button.TabIndex = 21;
            this.view_button.Text = "View Selected Building";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // Buildings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Buildings";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Buildings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Buildings_DataSet buildings_DataSet;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private Buildings_DataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altNameDataGridViewTextBoxColumn;
    }
}