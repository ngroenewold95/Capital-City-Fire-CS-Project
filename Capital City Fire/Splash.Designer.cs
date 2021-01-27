
namespace Capital_City_Fire
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.tech_button = new System.Windows.Forms.Button();
            this.company_button = new System.Windows.Forms.Button();
            this.firedept_button = new System.Windows.Forms.Button();
            this.device_button = new System.Windows.Forms.Button();
            this.elu_button = new System.Windows.Forms.Button();
            this.ext_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.report_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tech_button
            // 
            this.tech_button.Location = new System.Drawing.Point(53, 354);
            this.tech_button.Name = "tech_button";
            this.tech_button.Size = new System.Drawing.Size(145, 55);
            this.tech_button.TabIndex = 0;
            this.tech_button.Text = "Technicians";
            this.tech_button.UseVisualStyleBackColor = true;
            this.tech_button.Click += new System.EventHandler(this.Technicians_Click);
            // 
            // company_button
            // 
            this.company_button.Location = new System.Drawing.Point(53, 282);
            this.company_button.Name = "company_button";
            this.company_button.Size = new System.Drawing.Size(145, 55);
            this.company_button.TabIndex = 1;
            this.company_button.Text = "Companies";
            this.company_button.UseVisualStyleBackColor = true;
            this.company_button.Click += new System.EventHandler(this.Companies_Click);
            // 
            // firedept_button
            // 
            this.firedept_button.Location = new System.Drawing.Point(617, 354);
            this.firedept_button.Name = "firedept_button";
            this.firedept_button.Size = new System.Drawing.Size(145, 55);
            this.firedept_button.TabIndex = 2;
            this.firedept_button.Text = "Fire Departments";
            this.firedept_button.UseVisualStyleBackColor = true;
            this.firedept_button.Click += new System.EventHandler(this.FireDept_Click);
            // 
            // device_button
            // 
            this.device_button.Location = new System.Drawing.Point(617, 282);
            this.device_button.Name = "device_button";
            this.device_button.Size = new System.Drawing.Size(145, 55);
            this.device_button.TabIndex = 3;
            this.device_button.Text = "Device Types";
            this.device_button.UseVisualStyleBackColor = true;
            this.device_button.Click += new System.EventHandler(this.device_button_Click);
            // 
            // elu_button
            // 
            this.elu_button.Location = new System.Drawing.Point(617, 134);
            this.elu_button.Name = "elu_button";
            this.elu_button.Size = new System.Drawing.Size(145, 55);
            this.elu_button.TabIndex = 4;
            this.elu_button.Text = "ELU Types";
            this.elu_button.UseVisualStyleBackColor = true;
            this.elu_button.Click += new System.EventHandler(this.elu_button_Click);
            // 
            // ext_button
            // 
            this.ext_button.Location = new System.Drawing.Point(617, 209);
            this.ext_button.Name = "ext_button";
            this.ext_button.Size = new System.Drawing.Size(145, 55);
            this.ext_button.TabIndex = 5;
            this.ext_button.Text = "EXT Types";
            this.ext_button.UseVisualStyleBackColor = true;
            this.ext_button.Click += new System.EventHandler(this.ext_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buildings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buildings_button_Click);
            // 
            // report_button
            // 
            this.report_button.Location = new System.Drawing.Point(53, 134);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(145, 55);
            this.report_button.TabIndex = 7;
            this.report_button.Text = "Reports";
            this.report_button.UseVisualStyleBackColor = true;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 181);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ext_button);
            this.Controls.Add(this.elu_button);
            this.Controls.Add(this.device_button);
            this.Controls.Add(this.firedept_button);
            this.Controls.Add(this.company_button);
            this.Controls.Add(this.tech_button);
            this.Name = "Splash";
            this.Text = "Capital City Fire - Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tech_button;
        private System.Windows.Forms.Button company_button;
        private System.Windows.Forms.Button firedept_button;
        private System.Windows.Forms.Button device_button;
        private System.Windows.Forms.Button elu_button;
        private System.Windows.Forms.Button ext_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button report_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

