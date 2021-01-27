
namespace Capital_City_Fire
{
    partial class AddElu
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
            this.elu_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.location_text = new System.Windows.Forms.TextBox();
            this.close_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.capcityDataSet = new Capital_City_Fire.CapcityDataSet();
            this.eluListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eluListTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.eluListTableAdapter();
            this.buildingsTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.buildingsTableAdapter();
            this.bld_eluTableAdapter = new Capital_City_Fire.CapcityDataSetTableAdapters.bld_eluTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eluListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // added_label
            // 
            this.added_label.AutoSize = true;
            this.added_label.Location = new System.Drawing.Point(16, 59);
            this.added_label.Name = "added_label";
            this.added_label.Size = new System.Drawing.Size(283, 65);
            this.added_label.TabIndex = 37;
            this.added_label.Text = "ELU added to building. \r\n\r\nContinue saving new devices or click Close when finish" +
    "ed.\r\n\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Remarks";
            // 
            // remarks_text
            // 
            this.remarks_text.Location = new System.Drawing.Point(229, 24);
            this.remarks_text.Name = "remarks_text";
            this.remarks_text.Size = new System.Drawing.Size(253, 20);
            this.remarks_text.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "ELU Type";
            // 
            // elu_comboBox
            // 
            this.elu_comboBox.DataSource = this.eluListBindingSource;
            this.elu_comboBox.DisplayMember = "eluType";
            this.elu_comboBox.FormattingEnabled = true;
            this.elu_comboBox.Location = new System.Drawing.Point(125, 23);
            this.elu_comboBox.Name = "elu_comboBox";
            this.elu_comboBox.Size = new System.Drawing.Size(98, 21);
            this.elu_comboBox.TabIndex = 33;
            this.elu_comboBox.ValueMember = "eluID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Location";
            // 
            // location_text
            // 
            this.location_text.Location = new System.Drawing.Point(19, 24);
            this.location_text.Name = "location_text";
            this.location_text.Size = new System.Drawing.Size(100, 20);
            this.location_text.TabIndex = 31;
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(326, 79);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 30;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(407, 79);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 29;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // capcityDataSet
            // 
            this.capcityDataSet.DataSetName = "CapcityDataSet";
            this.capcityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eluListBindingSource
            // 
            this.eluListBindingSource.DataMember = "eluList";
            this.eluListBindingSource.DataSource = this.capcityDataSet;
            // 
            // eluListTableAdapter
            // 
            this.eluListTableAdapter.ClearBeforeFill = true;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // bld_eluTableAdapter
            // 
            this.bld_eluTableAdapter.ClearBeforeFill = true;
            // 
            // AddElu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 145);
            this.Controls.Add(this.added_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.remarks_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elu_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location_text);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.save_button);
            this.Name = "AddElu";
            this.Text = "Capital City Fire - Add ELUs to Building";
            this.Load += new System.EventHandler(this.AddElu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capcityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eluListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label added_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox remarks_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox elu_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox location_text;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button save_button;
        private CapcityDataSet capcityDataSet;
        private System.Windows.Forms.BindingSource eluListBindingSource;
        private CapcityDataSetTableAdapters.eluListTableAdapter eluListTableAdapter;
        private CapcityDataSetTableAdapters.buildingsTableAdapter buildingsTableAdapter;
        private CapcityDataSetTableAdapters.bld_eluTableAdapter bld_eluTableAdapter;
    }
}