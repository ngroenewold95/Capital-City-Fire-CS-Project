
namespace Capital_City_Fire
{
    partial class Companies
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
            this.tableAdapterManager1 = new Capital_City_Fire.Technicians_DataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companies_DataSet = new Capital_City_Fire.Companies_DataSet();
            this.companiesTableAdapter = new Capital_City_Fire.Companies_DataSetTableAdapters.companiesTableAdapter();
            this.save_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companies_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.techniciansTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Capital_City_Fire.Technicians_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.companyNameDataGridViewTextBoxColumn,
            this.companyPhoneDataGridViewTextBoxColumn,
            this.companyEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 317);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "companyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyPhoneDataGridViewTextBoxColumn
            // 
            this.companyPhoneDataGridViewTextBoxColumn.DataPropertyName = "companyPhone";
            this.companyPhoneDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.companyPhoneDataGridViewTextBoxColumn.Name = "companyPhoneDataGridViewTextBoxColumn";
            this.companyPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyEmailDataGridViewTextBoxColumn
            // 
            this.companyEmailDataGridViewTextBoxColumn.DataPropertyName = "companyEmail";
            this.companyEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.companyEmailDataGridViewTextBoxColumn.Name = "companyEmailDataGridViewTextBoxColumn";
            this.companyEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "companies";
            this.companiesBindingSource.DataSource = this.companies_DataSet;
            // 
            // companies_DataSet
            // 
            this.companies_DataSet.DataSetName = "Companies_DataSet";
            this.companies_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // save_button
            // 
            this.save_button.Enabled = false;
            this.save_button.Location = new System.Drawing.Point(93, 12);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // new_button
            // 
            this.new_button.Location = new System.Drawing.Point(12, 12);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(75, 23);
            this.new_button.TabIndex = 6;
            this.new_button.Text = "Add/Edit";
            this.new_button.UseVisualStyleBackColor = true;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(713, 12);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(75, 23);
            this.home_button.TabIndex = 5;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.Home_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(174, 12);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(143, 23);
            this.clear_button.TabIndex = 9;
            this.clear_button.Text = "Clear Unsaved Changes";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Companies";
            this.Text = "Capital City Fire - Companies";
            this.Load += new System.EventHandler(this.Companies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companies_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Technicians_DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Companies_DataSet companies_DataSet;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private Companies_DataSetTableAdapters.companiesTableAdapter companiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button clear_button;
    }
}