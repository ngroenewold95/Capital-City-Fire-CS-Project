using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class AddExt : Form
    {
        int bldID;
        public CapcityDataSet.buildingsRow bldRow;

        public AddExt(int buildingID)
        {
            bldID = buildingID;
            InitializeComponent();

            added_label.Visible = false;
        }

        private void AddExt_Load(object sender, EventArgs e)
        {
            this.extListTableAdapter.Fill(this.capcityDataSet.extList);
            this.bld_extTableAdapter.Fill(this.capcityDataSet.bld_ext);
            this.buildingsTableAdapter.Fill(this.capcityDataSet.buildings);

            bldRow = capcityDataSet.buildings.FindBybuildingID(bldID);

        }
        private void save_button_Click(object sender, EventArgs e)
        {
            CapcityDataSet.bld_extRow newBldExtRow = capcityDataSet.bld_ext.Newbld_extRow();

            if (String.IsNullOrWhiteSpace(location_text.Text))
            {
                if (MessageBox.Show("Please enter a location.", "Invalid Entry", MessageBoxButtons.OK) == DialogResult.OK)
                    return;
            };

            if (!String.IsNullOrWhiteSpace(serial_text.Text))
            {
                if(!serial_text.Text.All(char.IsDigit))
                {
                    if (MessageBox.Show("Please enter a valid numeric serial number.", "Invalid Entry", MessageBoxButtons.OK) == DialogResult.OK)
                        return;
                }
            };

            newBldExtRow.extLocation = location_text.Text.Trim();

            newBldExtRow.serial = serial_text.Text.Trim();
            newBldExtRow.mfgDate = Convert.ToString(mfg_comboBox.SelectedItem);
            newBldExtRow.srvDate = Convert.ToString(srv_comboBox.SelectedItem);
            newBldExtRow.remarks = remarks_text.Text.Trim();
            newBldExtRow.extID = (int)ext_comboBox.SelectedValue;
            newBldExtRow.buildingID = bldRow.buildingID;

            if (MessageBox.Show("Do you want to add extinguisher ?", "Add Extinguisher", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                capcityDataSet.bld_ext.Rows.Add(newBldExtRow);
                bld_extTableAdapter.Update(capcityDataSet.bld_ext);
                added_label.Visible = true;
            }


        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
