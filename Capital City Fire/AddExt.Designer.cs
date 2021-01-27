
namespace Capital_City_Fire
{
    partial class AddExt
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
            this.added_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remarks_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ext_comboBox = new System.Windows.Forms.ComboBox();
            this.extListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capcityDataSet = new Capital_City_Fire.CapcityDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.location_text = new System.Windows.Forms.TextBox();
            this.close_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.extListTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.extListTableAdapter();
            this.bld_extTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.bld_extTableAdapter();
            this.buildingsTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.buildingsTableAdapter();
            this.serial_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mfg_comboBox = new System.Windows.Forms.ComboBox();
            this.srv_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.extListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // added_label
            // 
            this.added_label.AutoSize = true;
            this.added_label.Location = new System.Drawing.Point(3, 64);
            this.added_label.Name = "added_label";
            this.added_label.Size = new System.Drawing.Size(283, 65);
            this.added_label.TabIndex = 46;
            this.added_label.Text = "Extinguisher added to building. \r\n\r\nContinue saving new devices or click Close wh" +
    "en finished.\r\n\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Remarks";
            // 
            // remarks_text
            // 
            this.remarks_text.Location = new System.Drawing.Point(452, 24);
            this.remarks_text.Name = "remarks_text";
            this.remarks_text.Size = new System.Drawing.Size(253, 20);
            this.remarks_text.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ext Type";
            // 
            // ext_comboBox
            // 
            this.ext_comboBox.DataSource = this.extListBindingSource;
            this.ext_comboBox.DisplayMember = "extType";
            this.ext_comboBox.FormattingEnabled = true;
            this.ext_comboBox.Location = new System.Drawing.Point(112, 24);
            this.ext_comboBox.Name = "ext_comboBox";
            this.ext_comboBox.Size = new System.Drawing.Size(75, 21);
            this.ext_comboBox.TabIndex = 42;
            this.ext_comboBox.ValueMember = "extID";
            // 
            // extListBindingSource
            // 
            this.extListBindingSource.DataMember = "extList";
            this.extListBindingSource.DataSource = this.capcityDataSet;
            // 
            // capcityDataSet
            // 
            this.capcityDataSet.DataSetName = "CapcityDataSet";
            this.capcityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Location";
            // 
            // location_text
            // 
            this.location_text.Location = new System.Drawing.Point(6, 25);
            this.location_text.Name = "location_text";
            this.location_text.Size = new System.Drawing.Size(100, 20);
            this.location_text.TabIndex = 40;
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(520, 89);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 39;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(601, 89);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 38;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // extListTableAdapter
            // 
            this.extListTableAdapter.ClearBeforeFill = true;
            // 
            // bld_extTableAdapter
            // 
            this.bld_extTableAdapter.ClearBeforeFill = true;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // serial_text
            // 
            this.serial_text.Location = new System.Drawing.Point(193, 25);
            this.serial_text.Name = "serial_text";
            this.serial_text.Size = new System.Drawing.Size(123, 20);
            this.serial_text.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Serial #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Mfg Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Srv Date";
            // 
            // mfg_comboBox
            // 
            this.mfg_comboBox.FormattingEnabled = true;
            this.mfg_comboBox.Items.AddRange(new object[] {
            "13/19",
            "14/20",
            "15/21",
            "16/22",
            "17/23",
            "18/24",
            "19/25",
            "20/26",
            "21/27"});
            this.mfg_comboBox.Location = new System.Drawing.Point(322, 25);
            this.mfg_comboBox.Name = "mfg_comboBox";
            this.mfg_comboBox.Size = new System.Drawing.Size(58, 21);
            this.mfg_comboBox.TabIndex = 53;
            // 
            // srv_comboBox
            // 
            this.srv_comboBox.FormattingEnabled = true;
            this.srv_comboBox.Items.AddRange(new object[] {
            "13/19",
            "14/20",
            "15/21",
            "16/22",
            "17/23",
            "18/24",
            "19/25",
            "20/26",
            "21/27"});
            this.srv_comboBox.Location = new System.Drawing.Point(386, 25);
            this.srv_comboBox.Name = "srv_comboBox";
            this.srv_comboBox.Size = new System.Drawing.Size(60, 21);
            this.srv_comboBox.TabIndex = 54;
            // 
            // AddExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 126);
            this.Controls.Add(this.srv_comboBox);
            this.Controls.Add(this.mfg_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serial_text);
            this.Controls.Add(this.added_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.remarks_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ext_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location_text);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.save_button);
            this.Name = "AddExt";
            this.Text = "Capital City Fire - Add Extinguishers to Building";
            this.Load += new System.EventHandler(this.AddExt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.extListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label added_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remarks_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ext_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox location_text;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button save_button;
        private CapcityDataSet capcityDataSet;
        private System.Windows.Forms.BindingSource extListBindingSource;
        private CapcityDataSetTableAdapters.extListTableAdapter extListTableAdapter;
        private CapcityDataSetTableAdapters.bld_extTableAdapter bld_extTableAdapter;
        private CapcityDataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.TextBox serial_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox mfg_comboBox;
        private System.Windows.Forms.ComboBox srv_comboBox;
    }
}