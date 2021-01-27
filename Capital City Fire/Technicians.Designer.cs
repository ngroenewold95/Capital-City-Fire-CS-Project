
namespace Capital_City_Fire
{
    partial class Technicians
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
            this.home_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technicians_DataSet = new Capital_City_Fire.Technicians_DataSet();
            this.techniciansTableAdapter = new Capital_City_Fire.Technicians_DataSetTableAdapters.techniciansTableAdapter();
            this.new_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.techniciansTableAdapter1 = new Capital_City_Fire.Technicians_DataSetTableAdapters.techniciansTableAdapter();
            this.technicians_DataSet1 = new Capital_City_Fire.Technicians_DataSet();
            this.clear_button = new System.Windows.Forms.Button();
            this.view_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicians_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicians_DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(713, 12);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(75, 23);
            this.home_button.TabIndex = 0;
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
            this.Column1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.techniciansBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 317);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "technicianID";
            this.Column1.HeaderText = "Tech ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // techniciansBindingSource
            // 
            this.techniciansBindingSource.DataMember = "technicians";
            this.techniciansBindingSource.DataSource = this.technicians_DataSet;
            // 
            // technicians_DataSet
            // 
            this.technicians_DataSet.DataSetName = "Technicians_DataSet";
            this.technicians_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techniciansTableAdapter
            // 
            this.techniciansTableAdapter.ClearBeforeFill = true;
            // 
            // new_button
            // 
            this.new_button.Location = new System.Drawing.Point(12, 12);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(75, 23);
            this.new_button.TabIndex = 2;
            this.new_button.Text = "Add/Edit";
            this.new_button.UseVisualStyleBackColor = true;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // save_button
            // 
            this.save_button.Enabled = false;
            this.save_button.Location = new System.Drawing.Point(93, 12);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // techniciansTableAdapter1
            // 
            this.techniciansTableAdapter1.ClearBeforeFill = true;
            // 
            // technicians_DataSet1
            // 
            this.technicians_DataSet1.DataSetName = "Technicians_DataSet";
            this.technicians_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(174, 12);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(143, 23);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "Clear Unsaved Changes";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(12, 92);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(143, 23);
            this.view_button.TabIndex = 11;
            this.view_button.Text = "View Technicians Reports";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // Technicians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.home_button);
            this.Name = "Technicians";
            this.Text = "Capital City Fire - Technicians";
            this.Load += new System.EventHandler(this.Technicians_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicians_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicians_DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Technicians_DataSet technicians_DataSet;
        private System.Windows.Forms.BindingSource techniciansBindingSource;
        private Technicians_DataSetTableAdapters.techniciansTableAdapter techniciansTableAdapter;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button save_button;
        private Technicians_DataSetTableAdapters.techniciansTableAdapter techniciansTableAdapter1;
        private Technicians_DataSet technicians_DataSet1;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}