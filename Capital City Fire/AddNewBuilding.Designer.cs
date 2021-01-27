
namespace Capital_City_Fire
{
    partial class AddNewBuilding
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
            this.streetnumber_text = new System.Windows.Forms.TextBox();
            this.streetnumber_label = new System.Windows.Forms.Label();
            this.street_label = new System.Windows.Forms.Label();
            this.street_text = new System.Windows.Forms.TextBox();
            this.postalcode_label = new System.Windows.Forms.Label();
            this.postalcode_text = new System.Windows.Forms.TextBox();
            this.province_label = new System.Windows.Forms.Label();
            this.city_label = new System.Windows.Forms.Label();
            this.city_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.altname_text = new System.Windows.Forms.TextBox();
            this.company_label = new System.Windows.Forms.Label();
            this.invoice_combobox = new System.Windows.Forms.ComboBox();
            this.companiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companies_DataSet = new Capital_City_Fire.Companies_DataSet();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice_label = new System.Windows.Forms.Label();
            this.firedept_label = new System.Windows.Forms.Label();
            this.fire_combobox = new System.Windows.Forms.ComboBox();
            this.fireDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireDepartmentsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fire_Departments_DataSet = new Capital_City_Fire.Fire_Departments_DataSet();
            this.company_combobox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.propertymanager_text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.onsitecontact_text = new System.Windows.Forms.TextBox();
            this.notes_richtext = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ladder_combobox = new System.Windows.Forms.ComboBox();
            this.fireDepartmentTableAdapter = new Capital_City_Fire.Fire_Departments_DataSetTableAdapters.fireDepartmentTableAdapter();
            this.companiesTableAdapter = new Capital_City_Fire.Companies_DataSetTableAdapters.companiesTableAdapter();
            this.save_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buildings_DataSet = new Capital_City_Fire.Buildings_DataSet();
            this.buildingsTableAdapter = new Capital_City_Fire.Buildings_DataSetTableAdapters.buildingsTableAdapter();
            this.province_comboBox = new System.Windows.Forms.ComboBox();
            this.required_label = new System.Windows.Forms.Label();
            this.invalidpostal_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companies_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireDepartmentsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire_Departments_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // streetnumber_text
            // 
            this.streetnumber_text.Location = new System.Drawing.Point(25, 41);
            this.streetnumber_text.Name = "streetnumber_text";
            this.streetnumber_text.Size = new System.Drawing.Size(100, 20);
            this.streetnumber_text.TabIndex = 0;
            // 
            // streetnumber_label
            // 
            this.streetnumber_label.AutoSize = true;
            this.streetnumber_label.Location = new System.Drawing.Point(37, 25);
            this.streetnumber_label.Name = "streetnumber_label";
            this.streetnumber_label.Size = new System.Drawing.Size(75, 13);
            this.streetnumber_label.TabIndex = 1;
            this.streetnumber_label.Text = "Street Number";
            // 
            // street_label
            // 
            this.street_label.AutoSize = true;
            this.street_label.Location = new System.Drawing.Point(183, 25);
            this.street_label.Name = "street_label";
            this.street_label.Size = new System.Drawing.Size(35, 13);
            this.street_label.TabIndex = 3;
            this.street_label.Text = "Street";
            // 
            // street_text
            // 
            this.street_text.Location = new System.Drawing.Point(148, 41);
            this.street_text.Name = "street_text";
            this.street_text.Size = new System.Drawing.Size(100, 20);
            this.street_text.TabIndex = 2;
            // 
            // postalcode_label
            // 
            this.postalcode_label.AutoSize = true;
            this.postalcode_label.Location = new System.Drawing.Point(280, 25);
            this.postalcode_label.Name = "postalcode_label";
            this.postalcode_label.Size = new System.Drawing.Size(64, 13);
            this.postalcode_label.TabIndex = 5;
            this.postalcode_label.Text = "Postal Code";
            // 
            // postalcode_text
            // 
            this.postalcode_text.Location = new System.Drawing.Point(268, 41);
            this.postalcode_text.Name = "postalcode_text";
            this.postalcode_text.Size = new System.Drawing.Size(100, 20);
            this.postalcode_text.TabIndex = 4;
            // 
            // province_label
            // 
            this.province_label.AutoSize = true;
            this.province_label.Location = new System.Drawing.Point(524, 25);
            this.province_label.Name = "province_label";
            this.province_label.Size = new System.Drawing.Size(49, 13);
            this.province_label.TabIndex = 7;
            this.province_label.Text = "Province";
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(399, 25);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(24, 13);
            this.city_label.TabIndex = 9;
            this.city_label.Text = "City";
            // 
            // city_text
            // 
            this.city_text.Location = new System.Drawing.Point(384, 41);
            this.city_text.Name = "city_text";
            this.city_text.Size = new System.Drawing.Size(100, 20);
            this.city_text.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alternate Name";
            // 
            // altname_text
            // 
            this.altname_text.Location = new System.Drawing.Point(631, 41);
            this.altname_text.Name = "altname_text";
            this.altname_text.Size = new System.Drawing.Size(100, 20);
            this.altname_text.TabIndex = 10;
            // 
            // company_label
            // 
            this.company_label.AutoSize = true;
            this.company_label.Location = new System.Drawing.Point(46, 82);
            this.company_label.Name = "company_label";
            this.company_label.Size = new System.Drawing.Size(51, 13);
            this.company_label.TabIndex = 13;
            this.company_label.Text = "Company";
            // 
            // invoice_combobox
            // 
            this.invoice_combobox.DataSource = this.companiesBindingSource1;
            this.invoice_combobox.DisplayMember = "companyName";
            this.invoice_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invoice_combobox.FormattingEnabled = true;
            this.invoice_combobox.Location = new System.Drawing.Point(148, 98);
            this.invoice_combobox.Name = "invoice_combobox";
            this.invoice_combobox.Size = new System.Drawing.Size(100, 21);
            this.invoice_combobox.TabIndex = 14;
            this.invoice_combobox.ValueMember = "companyID";
            // 
            // companiesBindingSource1
            // 
            this.companiesBindingSource1.DataMember = "companies";
            this.companiesBindingSource1.DataSource = this.companies_DataSet;
            // 
            // companies_DataSet
            // 
            this.companies_DataSet.DataSetName = "Companies_DataSet";
            this.companies_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "companies";
            this.companiesBindingSource.DataSource = this.companies_DataSet;
            // 
            // invoice_label
            // 
            this.invoice_label.AutoSize = true;
            this.invoice_label.Location = new System.Drawing.Point(160, 82);
            this.invoice_label.Name = "invoice_label";
            this.invoice_label.Size = new System.Drawing.Size(58, 13);
            this.invoice_label.TabIndex = 15;
            this.invoice_label.Text = "Invoice To";
            // 
            // firedept_label
            // 
            this.firedept_label.AutoSize = true;
            this.firedept_label.Location = new System.Drawing.Point(628, 82);
            this.firedept_label.Name = "firedept_label";
            this.firedept_label.Size = new System.Drawing.Size(82, 13);
            this.firedept_label.TabIndex = 17;
            this.firedept_label.Text = "Fire Department";
            // 
            // fire_combobox
            // 
            this.fire_combobox.DataSource = this.fireDepartmentBindingSource;
            this.fire_combobox.DisplayMember = "fireDepartment";
            this.fire_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fire_combobox.FormattingEnabled = true;
            this.fire_combobox.Location = new System.Drawing.Point(631, 98);
            this.fire_combobox.Name = "fire_combobox";
            this.fire_combobox.Size = new System.Drawing.Size(100, 21);
            this.fire_combobox.TabIndex = 16;
            this.fire_combobox.ValueMember = "fireDeptID";
            // 
            // fireDepartmentBindingSource
            // 
            this.fireDepartmentBindingSource.DataMember = "fireDepartment";
            this.fireDepartmentBindingSource.DataSource = this.fireDepartmentsDataSetBindingSource;
            // 
            // fireDepartmentsDataSetBindingSource
            // 
            this.fireDepartmentsDataSetBindingSource.DataSource = this.fire_Departments_DataSet;
            this.fireDepartmentsDataSetBindingSource.Position = 0;
            // 
            // fire_Departments_DataSet
            // 
            this.fire_Departments_DataSet.DataSetName = "Fire_Departments_DataSet";
            this.fire_Departments_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // company_combobox
            // 
            this.company_combobox.DataSource = this.companiesBindingSource;
            this.company_combobox.DisplayMember = "companyName";
            this.company_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.company_combobox.FormattingEnabled = true;
            this.company_combobox.Location = new System.Drawing.Point(25, 98);
            this.company_combobox.Name = "company_combobox";
            this.company_combobox.Size = new System.Drawing.Size(100, 21);
            this.company_combobox.TabIndex = 18;
            this.company_combobox.ValueMember = "companyID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Property Manager";
            // 
            // propertymanager_text
            // 
            this.propertymanager_text.Location = new System.Drawing.Point(268, 99);
            this.propertymanager_text.Name = "propertymanager_text";
            this.propertymanager_text.Size = new System.Drawing.Size(100, 20);
            this.propertymanager_text.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(381, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "On Site Contact";
            // 
            // onsitecontact_text
            // 
            this.onsitecontact_text.Location = new System.Drawing.Point(384, 99);
            this.onsitecontact_text.Name = "onsitecontact_text";
            this.onsitecontact_text.Size = new System.Drawing.Size(100, 20);
            this.onsitecontact_text.TabIndex = 21;
            // 
            // notes_richtext
            // 
            this.notes_richtext.Location = new System.Drawing.Point(25, 162);
            this.notes_richtext.Name = "notes_richtext";
            this.notes_richtext.Size = new System.Drawing.Size(223, 55);
            this.notes_richtext.TabIndex = 23;
            this.notes_richtext.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Notes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ladder Required";
            // 
            // ladder_combobox
            // 
            this.ladder_combobox.FormattingEnabled = true;
            this.ladder_combobox.Items.AddRange(new object[] {
            " ",
            "Vulcan",
            "6\' or 8\'",
            "25\'",
            "Scissor Lift"});
            this.ladder_combobox.Location = new System.Drawing.Point(268, 162);
            this.ladder_combobox.Name = "ladder_combobox";
            this.ladder_combobox.Size = new System.Drawing.Size(100, 21);
            this.ladder_combobox.TabIndex = 25;
            // 
            // fireDepartmentTableAdapter
            // 
            this.fireDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(631, 232);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 23);
            this.save_button.TabIndex = 27;
            this.save_button.Text = "Save Building";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Close w/o Saving";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.close_button_Click);
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
            // province_comboBox
            // 
            this.province_comboBox.FormattingEnabled = true;
            this.province_comboBox.Items.AddRange(new object[] {
            "AB",
            "BC",
            "MB",
            "NB",
            "NL",
            "NT",
            "NS",
            "NU",
            "ON",
            "PE",
            "QC",
            "SK",
            "YT"});
            this.province_comboBox.Location = new System.Drawing.Point(512, 40);
            this.province_comboBox.Name = "province_comboBox";
            this.province_comboBox.Size = new System.Drawing.Size(82, 21);
            this.province_comboBox.TabIndex = 29;
            // 
            // required_label
            // 
            this.required_label.AutoSize = true;
            this.required_label.ForeColor = System.Drawing.Color.Red;
            this.required_label.Location = new System.Drawing.Point(509, 162);
            this.required_label.Name = "required_label";
            this.required_label.Size = new System.Drawing.Size(116, 13);
            this.required_label.TabIndex = 30;
            this.required_label.Text = "Red fields are required!";
            this.required_label.Visible = false;
            // 
            // invalidpostal_label
            // 
            this.invalidpostal_label.AutoSize = true;
            this.invalidpostal_label.ForeColor = System.Drawing.Color.Red;
            this.invalidpostal_label.Location = new System.Drawing.Point(509, 193);
            this.invalidpostal_label.Name = "invalidpostal_label";
            this.invalidpostal_label.Size = new System.Drawing.Size(101, 13);
            this.invalidpostal_label.TabIndex = 31;
            this.invalidpostal_label.Text = "Invalid Postal Code!";
            this.invalidpostal_label.Visible = false;
            // 
            // AddNewBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.invalidpostal_label);
            this.Controls.Add(this.required_label);
            this.Controls.Add(this.province_comboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ladder_combobox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.notes_richtext);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.onsitecontact_text);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.propertymanager_text);
            this.Controls.Add(this.company_combobox);
            this.Controls.Add(this.firedept_label);
            this.Controls.Add(this.fire_combobox);
            this.Controls.Add(this.invoice_label);
            this.Controls.Add(this.invoice_combobox);
            this.Controls.Add(this.company_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.altname_text);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.city_text);
            this.Controls.Add(this.province_label);
            this.Controls.Add(this.postalcode_label);
            this.Controls.Add(this.postalcode_text);
            this.Controls.Add(this.street_label);
            this.Controls.Add(this.street_text);
            this.Controls.Add(this.streetnumber_label);
            this.Controls.Add(this.streetnumber_text);
            this.Name = "AddNewBuilding";
            this.Text = "Capital City Fire - New Building";
            this.Load += new System.EventHandler(this.AddNewBuilding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companies_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireDepartmentsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire_Departments_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox streetnumber_text;
        private System.Windows.Forms.Label streetnumber_label;
        private System.Windows.Forms.Label street_label;
        private System.Windows.Forms.TextBox street_text;
        private System.Windows.Forms.Label postalcode_label;
        private System.Windows.Forms.TextBox postalcode_text;
        private System.Windows.Forms.Label province_label;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox city_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox altname_text;
        private System.Windows.Forms.Label company_label;
        private System.Windows.Forms.ComboBox invoice_combobox;
        private Companies_DataSet companies_DataSet;
        private System.Windows.Forms.Label invoice_label;
        private System.Windows.Forms.Label firedept_label;
        private System.Windows.Forms.ComboBox fire_combobox;
        private System.Windows.Forms.ComboBox company_combobox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox propertymanager_text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox onsitecontact_text;
        private System.Windows.Forms.RichTextBox notes_richtext;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ladder_combobox;
        private System.Windows.Forms.BindingSource fireDepartmentsDataSetBindingSource;
        private Fire_Departments_DataSet fire_Departments_DataSet;
        private System.Windows.Forms.BindingSource fireDepartmentBindingSource;
        private Fire_Departments_DataSetTableAdapters.fireDepartmentTableAdapter fireDepartmentTableAdapter;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private Companies_DataSetTableAdapters.companiesTableAdapter companiesTableAdapter;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button button1;
        private Buildings_DataSet buildings_DataSet;
        private Buildings_DataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.BindingSource companiesBindingSource1;
        private System.Windows.Forms.ComboBox province_comboBox;
        private System.Windows.Forms.Label required_label;
        private System.Windows.Forms.Label invalidpostal_label;
    }
}