using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class ViewBuildings : Form
    {
        public int bldID;
        public Buildings_DataSet.buildingsRow bldRow;

        public ViewBuildings(int buildingID)
        {
            bldID = buildingID;
            InitializeComponent();

            streetnumber_text.ReadOnly = true;
            street_text.ReadOnly = true;
            postalcode_text.ReadOnly = true;
            city_text.ReadOnly = true;
            altname_text.ReadOnly = true;
            propertymanager_text.ReadOnly = true;
            onsitecontact_text.ReadOnly = true;
            notes_richtext.ReadOnly = true;

            province_comboBox.Enabled = false;
            ladder_combobox.Enabled = false;

            fire_combobox.Enabled = false;
            company_combobox.Enabled = false;
            invoice_combobox.Enabled = false;

            save_button.Enabled = false;
            edit_button.Enabled = true;

        }

        private void BuildingView_Load(object sender, EventArgs e)
        {
            this.buildingsTableAdapter.Fill(this.buildings_DataSet.buildings);
            this.fireDepartmentTableAdapter.Fill(this.fire_Departments_DataSet.fireDepartment);
            this.companiesTableAdapter.Fill(this.companies_DataSet.companies);

            displayBuilding();
        }

        public void displayBuilding()
        {
            bldRow = buildings_DataSet.buildings.FindBybuildingID(bldID);

            streetnumber_text.Text = bldRow.streetNumber;
            street_text.Text = bldRow.streetNumber;
            postalcode_text.Text = bldRow.postalCode;
            city_text.Text = bldRow.city;
            altname_text.Text = bldRow.altName;
            propertymanager_text.Text = bldRow.propertyManager;
            onsitecontact_text.Text = bldRow.onsiteContact;
            notes_richtext.Text = bldRow.otherNotes;

            province_comboBox.SelectedIndex = province_comboBox.Items.IndexOf(bldRow.province);
            ladder_combobox.SelectedIndex = ladder_combobox.Items.IndexOf(bldRow.ladderRequired);

            fire_combobox.SelectedValue = bldRow.fireDeptID;
            company_combobox.SelectedValue = bldRow.companyID;
            invoice_combobox.SelectedValue = bldRow.invoiceCompanyID;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this window? Any unsaved changes will be lost!", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            displayBuilding();

        }

        private void save_button_Click(object sender, EventArgs e)
        {

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
                bldRow.streetNumber = streetnumber_text.Text.Trim();
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
                bldRow.street = street_text.Text.Trim();
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
                bldRow.postalCode = postalcode_text.Text.Trim().ToUpper();
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
                bldRow.city = city_text.Text.Trim();
            }

            bldRow.province = province_comboBox.SelectedItem.ToString();
            bldRow.altName = altname_text.Text.Trim();
            bldRow.companyID = (int)company_combobox.SelectedValue;
            bldRow.invoiceCompanyID = (int)invoice_combobox.SelectedValue;
            bldRow.propertyManager = propertymanager_text.Text.Trim();
            bldRow.onsiteContact = onsitecontact_text.Text.Trim();
            bldRow.fireDeptID = (int)fire_combobox.SelectedValue;
            bldRow.ladderRequired = Convert.ToString(ladder_combobox.SelectedItem);
            bldRow.otherNotes = notes_richtext.Text.Trim();

            if (failure == true)
            {
                MessageBox.Show("Invalid Building Entry!", "Invalid Entry", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Do you want to save your changes ?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                buildingsTableAdapter.Update(buildings_DataSet.buildings);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {

            streetnumber_text.ReadOnly = false;
            street_text.ReadOnly = false;
            postalcode_text.ReadOnly = false;
            city_text.ReadOnly = false;
            altname_text.ReadOnly = false;
            propertymanager_text.ReadOnly = false;
            onsitecontact_text.ReadOnly = false;
            notes_richtext.ReadOnly = false;

            province_comboBox.Enabled = true;
            ladder_combobox.Enabled = true;

            fire_combobox.Enabled = true;
            company_combobox.Enabled = true;
            invoice_combobox.Enabled = true;

            save_button.Enabled = true;
            edit_button.Enabled = false;

        }

        private void reports_button_Click(object sender, EventArgs e)
        {
            var bldReports = new BuildingReports(bldID);
            bldReports.Show();

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

        private void devices_button_Click(object sender, EventArgs e)
        {
            var viewDevices = new ViewDevices(bldID);
            viewDevices.Show();
        }

        private void elu_button_Click(object sender, EventArgs e)
        {
            var viewElus = new ViewElus(bldID);
            viewElus.Show();
        }

        private void ext_button_Click(object sender, EventArgs e)
        {
            var viewExts = new ViewExts(bldID);
            viewExts.Show();
        }
    }
}
