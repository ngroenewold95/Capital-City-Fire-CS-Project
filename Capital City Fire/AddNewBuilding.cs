using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class AddNewBuilding : Form
    {
        public AddNewBuilding()
        {
            InitializeComponent();

            province_comboBox.SelectedIndex = 1;
        }


        private void AddNewBuilding_Load(object sender, EventArgs e)
        {
            this.companiesTableAdapter.Fill(this.companies_DataSet.companies);
            this.fireDepartmentTableAdapter.Fill(this.fire_Departments_DataSet.fireDepartment);

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Buildings_DataSet.buildingsRow newbuildingsRow = buildings_DataSet.buildings.NewbuildingsRow();
            bool failure = false;

            if (string.IsNullOrWhiteSpace(streetnumber_text.Text))
            {
                streetnumber_label.ForeColor = Color.Red;
                required_label.Visible = true;
                failure = true;
            }
            else
            {
                streetnumber_label.ForeColor = Color.Black;
                newbuildingsRow.streetNumber = streetnumber_text.Text.Trim();
            }

            if (string.IsNullOrWhiteSpace(street_text.Text))
            {
                street_label.ForeColor = Color.Red;
                required_label.Visible = true;
                failure = true;
            }
            else
            {
                street_label.ForeColor = Color.Black;
                newbuildingsRow.street = street_text.Text.Trim();
            }

            if (string.IsNullOrWhiteSpace(postalcode_text.Text))
            {
                postalcode_label.ForeColor = Color.Red;
                required_label.Visible = true;
                failure = true;
            }
            else if (!IsPostalCode(postalcode_text.Text))
            {
                postalcode_label.ForeColor = Color.Red;
                invalidpostal_label.Visible = true;
                failure = true;
            }
            else
            {
                postalcode_label.ForeColor = Color.Black;
                newbuildingsRow.postalCode = postalcode_text.Text.Trim().ToUpper();
                invalidpostal_label.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(city_text.Text))
            {
                city_label.ForeColor = Color.Red;
                required_label.Visible = true;
                failure = true;
            }
            else
            {
                city_label.ForeColor = Color.Black;
                newbuildingsRow.city = city_text.Text.Trim();
            }

            newbuildingsRow.province = province_comboBox.SelectedItem.ToString();
            newbuildingsRow.altName = altname_text.Text.Trim();
            newbuildingsRow.companyID = (int)company_combobox.SelectedValue;
            newbuildingsRow.invoiceCompanyID = (int)invoice_combobox.SelectedValue;
            newbuildingsRow.propertyManager = propertymanager_text.Text.Trim();
            newbuildingsRow.onsiteContact = onsitecontact_text.Text.Trim();
            newbuildingsRow.fireDeptID = (int)fire_combobox.SelectedValue;
            newbuildingsRow.ladderRequired = Convert.ToString(ladder_combobox.SelectedItem);
            newbuildingsRow.otherNotes = notes_richtext.Text.Trim();

            if (failure == true)
            {
                MessageBox.Show("Invalid Building Entry!", "Invalid Entry", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Do you want to save your changes ?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                buildings_DataSet.buildings.Rows.Add(newbuildingsRow);
                buildingsTableAdapter.Update(buildings_DataSet.buildings);
                this.Close();
            }
        }


        private bool IsPostalCode(string postalCode)
        {

            var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
            var validPostalCode = true;
            if (!Regex.Match(postalCode.Trim().ToUpper(), _caZipRegEx).Success)
            {
                validPostalCode = false;
            }
            return validPostalCode;
        }
    }
}
