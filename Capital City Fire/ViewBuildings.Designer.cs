
namespace Capital_City_Fire
{
    partial class ViewBuildings
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
            this.buildings_DataSet = new Capital_City_Fire.Buildings_DataSet();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsTableAdapter = new Capital_City_Fire.Buildings_DataSetTableAdapters.buildingsTableAdapter();
            this.close_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companies_DataSet = new Capital_City_Fire.Companies_DataSet();
            this.fireDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fire_Departments_DataSet = new Capital_City_Fire.Fire_Departments_DataSet();
            this.companiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companiesTableAdapter = new Capital_City_Fire.Companies_DataSetTableAdapters.companiesTableAdapter();
            this.fireDepartmentTableAdapter = new Capital_City_Fire.Fire_Departments_DataSetTableAdapters.fireDepartmentTableAdapter();
            this.edit_button = new System.Windows.Forms.Button();
            this.reports_button = new System.Windows.Forms.Button();
            this.invalidpostal_label = new System.Windows.Forms.Label();
            this.required_label = new System.Windows.Forms.Label();
            this.province_comboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ladder_combobox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.notes_richtext = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.onsitecontact_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.propertymanager_text = new System.Windows.Forms.TextBox();
            this.company_combobox = new System.Windows.Forms.ComboBox();
            this.firedept_label = new System.Windows.Forms.Label();
            this.fire_combobox = new System.Windows.Forms.ComboBox();
            this.invoice_label = new System.Windows.Forms.Label();
            this.invoice_combobox = new System.Windows.Forms.ComboBox();
            this.company_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.altname_text = new System.Windows.Forms.TextBox();
            this.city_label = new System.Windows.Forms.Label();
            this.city_text = new System.Windows.Forms.TextBox();
            this.province_label = new System.Windows.Forms.Label();
            this.postalcode_label = new System.Windows.Forms.Label();
            this.postalcode_text = new System.Windows.Forms.TextBox();
            this.street_label = new System.Windows.Forms.Label();
            this.street_text = new System.Windows.Forms.TextBox();
            this.streetnumber_label = new System.Windows.Forms.Label();
            this.streetnumber_text = new System.Windows.Forms.TextBox();
            this.devices_button = new System.Windows.Forms.Button();
            this.elu_button = new System.Windows.Forms.Button();
            this.ext_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companies_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire_Departments_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buildings_DataSet
            // 
            this.buildings_DataSet.DataSetName = "Buildings_DataSet";
            this.buildings_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "buildings";
            this.buildingsBindingSource.DataSource = this.buildings_DataSet;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(688, 252);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(100, 23);
            this.close_button.TabIndex = 56;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(135, 252);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 23);
            this.save_button.TabIndex = 55;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
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
            // fireDepartmentBindingSource
            // 
            this.fireDepartmentBindingSource.DataMember = "fireDepartment";
            this.fireDepartmentBindingSource.DataSource = this.fire_Departments_DataSet;
            // 
            // fire_Departments_DataSet
            // 
            this.fire_Departments_DataSet.DataSetName = "Fire_Departments_DataSet";
            this.fire_Departments_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companiesBindingSource1
            // 
            this.companiesBindingSource1.DataMember = "companies";
            this.companiesBindingSource1.DataSource = this.companies_DataSet;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // fireDepartmentTableAdapter
            // 
            this.fireDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(12, 252);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(100, 23);
            this.edit_button.TabIndex = 58;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // reports_button
            // 
            this.reports_button.Location = new System.Drawing.Point(14, 223);
            this.reports_button.Name = "reports_button";
            this.reports_button.Size = new System.Drawing.Size(100, 23);
            this.reports_button.TabIndex = 59;
            this.reports_button.Text = "View Reports";
            this.reports_button.UseVisualStyleBackColor = true;
            this.reports_button.Click += new System.EventHandler(this.reports_button_Click);
            // 
            // invalidpostal_label
            // 
            this.invalidpostal_label.AutoSize = true;
            this.invalidpostal_label.ForeColor = System.Drawing.Color.Red;
            this.invalidpostal_label.Location = new System.Drawing.Point(498, 191);
            this.invalidpostal_label.Name = "invalidpostal_label";
            this.invalidpostal_label.Size = new System.Drawing.Size(101, 13);
            this.invalidpostal_label.TabIndex = 87;
            this.invalidpostal_label.Text = "Invalid Postal Code!";
            this.invalidpostal_label.Visible = false;
            // 
            // required_label
            // 
            this.required_label.AutoSize = true;
            this.required_label.ForeColor = System.Drawing.Color.Red;
            this.required_label.Location = new System.Drawing.Point(498, 160);
            this.required_label.Name = "required_label";
            this.required_label.Size = new System.Drawing.Size(116, 13);
            this.required_label.TabIndex = 86;
            this.required_label.Text = "Red fields are required!";
            this.required_label.Visible = false;
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
            this.province_comboBox.Location = new System.Drawing.Point(501, 38);
            this.province_comboBox.Name = "province_comboBox";
            this.province_comboBox.Size = new System.Drawing.Size(82, 21);
            this.province_comboBox.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 84;
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
            this.ladder_combobox.Location = new System.Drawing.Point(257, 160);
            this.ladder_combobox.Name = "ladder_combobox";
            this.ladder_combobox.Size = new System.Drawing.Size(100, 21);
            this.ladder_combobox.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "Notes";
            // 
            // notes_richtext
            // 
            this.notes_richtext.Location = new System.Drawing.Point(14, 160);
            this.notes_richtext.Name = "notes_richtext";
            this.notes_richtext.Size = new System.Drawing.Size(223, 55);
            this.notes_richtext.TabIndex = 81;
            this.notes_richtext.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "On Site Contact";
            // 
            // onsitecontact_text
            // 
            this.onsitecontact_text.Location = new System.Drawing.Point(373, 97);
            this.onsitecontact_text.Name = "onsitecontact_text";
            this.onsitecontact_text.Size = new System.Drawing.Size(100, 20);
            this.onsitecontact_text.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Property Manager";
            // 
            // propertymanager_text
            // 
            this.propertymanager_text.Location = new System.Drawing.Point(257, 97);
            this.propertymanager_text.Name = "propertymanager_text";
            this.propertymanager_text.Size = new System.Drawing.Size(100, 20);
            this.propertymanager_text.TabIndex = 77;
            // 
            // company_combobox
            // 
            this.company_combobox.DataSource = this.companiesBindingSource;
            this.company_combobox.DisplayMember = "companyName";
            this.company_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.company_combobox.FormattingEnabled = true;
            this.company_combobox.Location = new System.Drawing.Point(14, 96);
            this.company_combobox.Name = "company_combobox";
            this.company_combobox.Size = new System.Drawing.Size(100, 21);
            this.company_combobox.TabIndex = 76;
            this.company_combobox.ValueMember = "companyID";
            // 
            // firedept_label
            // 
            this.firedept_label.AutoSize = true;
            this.firedept_label.Location = new System.Drawing.Point(617, 80);
            this.firedept_label.Name = "firedept_label";
            this.firedept_label.Size = new System.Drawing.Size(82, 13);
            this.firedept_label.TabIndex = 75;
            this.firedept_label.Text = "Fire Department";
            // 
            // fire_combobox
            // 
            this.fire_combobox.DataSource = this.fireDepartmentBindingSource;
            this.fire_combobox.DisplayMember = "fireDepartment";
            this.fire_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fire_combobox.FormattingEnabled = true;
            this.fire_combobox.Location = new System.Drawing.Point(620, 96);
            this.fire_combobox.Name = "fire_combobox";
            this.fire_combobox.Size = new System.Drawing.Size(100, 21);
            this.fire_combobox.TabIndex = 74;
            this.fire_combobox.ValueMember = "fireDeptID";
            // 
            // invoice_label
            // 
            this.invoice_label.AutoSize = true;
            this.invoice_label.Location = new System.Drawing.Point(149, 80);
            this.invoice_label.Name = "invoice_label";
            this.invoice_label.Size = new System.Drawing.Size(58, 13);
            this.invoice_label.TabIndex = 73;
            this.invoice_label.Text = "Invoice To";
            // 
            // invoice_combobox
            // 
            this.invoice_combobox.DataSource = this.companiesBindingSource1;
            this.invoice_combobox.DisplayMember = "companyName";
            this.invoice_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invoice_combobox.FormattingEnabled = true;
            this.invoice_combobox.Location = new System.Drawing.Point(137, 96);
            this.invoice_combobox.Name = "invoice_combobox";
            this.invoice_combobox.Size = new System.Drawing.Size(100, 21);
            this.invoice_combobox.TabIndex = 72;
            this.invoice_combobox.ValueMember = "companyID";
            // 
            // company_label
            // 
            this.company_label.AutoSize = true;
            this.company_label.Location = new System.Drawing.Point(35, 80);
            this.company_label.Name = "company_label";
            this.company_label.Size = new System.Drawing.Size(51, 13);
            this.company_label.TabIndex = 71;
            this.company_label.Text = "Company";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Alternate Name";
            // 
            // altname_text
            // 
            this.altname_text.Location = new System.Drawing.Point(620, 39);
            this.altname_text.Name = "altname_text";
            this.altname_text.Size = new System.Drawing.Size(100, 20);
            this.altname_text.TabIndex = 69;
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(388, 23);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(24, 13);
            this.city_label.TabIndex = 68;
            this.city_label.Text = "City";
            // 
            // city_text
            // 
            this.city_text.Location = new System.Drawing.Point(373, 39);
            this.city_text.Name = "city_text";
            this.city_text.Size = new System.Drawing.Size(100, 20);
            this.city_text.TabIndex = 67;
            // 
            // province_label
            // 
            this.province_label.AutoSize = true;
            this.province_label.Location = new System.Drawing.Point(513, 23);
            this.province_label.Name = "province_label";
            this.province_label.Size = new System.Drawing.Size(49, 13);
            this.province_label.TabIndex = 66;
            this.province_label.Text = "Province";
            // 
            // postalcode_label
            // 
            this.postalcode_label.AutoSize = true;
            this.postalcode_label.Location = new System.Drawing.Point(269, 23);
            this.postalcode_label.Name = "postalcode_label";
            this.postalcode_label.Size = new System.Drawing.Size(64, 13);
            this.postalcode_label.TabIndex = 65;
            this.postalcode_label.Text = "Postal Code";
            // 
            // postalcode_text
            // 
            this.postalcode_text.Location = new System.Drawing.Point(257, 39);
            this.postalcode_text.Name = "postalcode_text";
            this.postalcode_text.Size = new System.Drawing.Size(100, 20);
            this.postalcode_text.TabIndex = 64;
            // 
            // street_label
            // 
            this.street_label.AutoSize = true;
            this.street_label.Location = new System.Drawing.Point(172, 23);
            this.street_label.Name = "street_label";
            this.street_label.Size = new System.Drawing.Size(35, 13);
            this.street_label.TabIndex = 63;
            this.street_label.Text = "Street";
            // 
            // street_text
            // 
            this.street_text.Location = new System.Drawing.Point(137, 39);
            this.street_text.Name = "street_text";
            this.street_text.Size = new System.Drawing.Size(100, 20);
            this.street_text.TabIndex = 62;
            // 
            // streetnumber_label
            // 
            this.streetnumber_label.AutoSize = true;
            this.streetnumber_label.Location = new System.Drawing.Point(26, 23);
            this.streetnumber_label.Name = "streetnumber_label";
            this.streetnumber_label.Size = new System.Drawing.Size(75, 13);
            this.streetnumber_label.TabIndex = 61;
            this.streetnumber_label.Text = "Street Number";
            // 
            // streetnumber_text
            // 
            this.streetnumber_text.Location = new System.Drawing.Point(14, 39);
            this.streetnumber_text.Name = "streetnumber_text";
            this.streetnumber_text.Size = new System.Drawing.Size(100, 20);
            this.streetnumber_text.TabIndex = 60;
            // 
            // devices_button
            // 
            this.devices_button.Location = new System.Drawing.Point(135, 223);
            this.devices_button.Name = "devices_button";
            this.devices_button.Size = new System.Drawing.Size(100, 23);
            this.devices_button.TabIndex = 88;
            this.devices_button.Text = "View Devices";
            this.devices_button.UseVisualStyleBackColor = true;
            this.devices_button.Click += new System.EventHandler(this.devices_button_Click);
            // 
            // elu_button
            // 
            this.elu_button.Location = new System.Drawing.Point(257, 223);
            this.elu_button.Name = "elu_button";
            this.elu_button.Size = new System.Drawing.Size(100, 23);
            this.elu_button.TabIndex = 89;
            this.elu_button.Text = "View ELUs";
            this.elu_button.UseVisualStyleBackColor = true;
            this.elu_button.Click += new System.EventHandler(this.elu_button_Click);
            // 
            // ext_button
            // 
            this.ext_button.Location = new System.Drawing.Point(257, 252);
            this.ext_button.Name = "ext_button";
            this.ext_button.Size = new System.Drawing.Size(100, 23);
            this.ext_button.TabIndex = 90;
            this.ext_button.Text = "View Exts";
            this.ext_button.UseVisualStyleBackColor = true;
            this.ext_button.Click += new System.EventHandler(this.ext_button_Click);
            // 
            // ViewBuildings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.ext_button);
            this.Controls.Add(this.elu_button);
            this.Controls.Add(this.devices_button);
            this.Controls.Add(this.invalidpostal_label);
            this.Controls.Add(this.required_label);
            this.Controls.Add(this.province_comboBox);
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
            this.Controls.Add(this.reports_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.save_button);
            this.Name = "ViewBuildings";
            this.Text = "Capital City Fire - Building View";
            this.Load += new System.EventHandler(this.BuildingView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildings_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companies_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire_Departments_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Buildings_DataSet buildings_DataSet;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private Buildings_DataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button save_button;
        private Companies_DataSet companies_DataSet;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private Companies_DataSetTableAdapters.companiesTableAdapter companiesTableAdapter;
        private System.Windows.Forms.BindingSource companiesBindingSource1;
        private Fire_Departments_DataSet fire_Departments_DataSet;
        private System.Windows.Forms.BindingSource fireDepartmentBindingSource;
        private Fire_Departments_DataSetTableAdapters.fireDepartmentTableAdapter fireDepartmentTableAdapter;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button reports_button;
        private System.Windows.Forms.Label invalidpostal_label;
        private System.Windows.Forms.Label required_label;
        private System.Windows.Forms.ComboBox province_comboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ladder_combobox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox notes_richtext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox onsitecontact_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox propertymanager_text;
        private System.Windows.Forms.ComboBox company_combobox;
        private System.Windows.Forms.Label firedept_label;
        private System.Windows.Forms.ComboBox fire_combobox;
        private System.Windows.Forms.Label invoice_label;
        private System.Windows.Forms.ComboBox invoice_combobox;
        private System.Windows.Forms.Label company_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox altname_text;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox city_text;
        private System.Windows.Forms.Label province_label;
        private System.Windows.Forms.Label postalcode_label;
        private System.Windows.Forms.TextBox postalcode_text;
        private System.Windows.Forms.Label street_label;
        private System.Windows.Forms.TextBox street_text;
        private System.Windows.Forms.Label streetnumber_label;
        private System.Windows.Forms.TextBox streetnumber_text;
        private System.Windows.Forms.Button devices_button;
        private System.Windows.Forms.Button elu_button;
        private System.Windows.Forms.Button ext_button;
    }
}