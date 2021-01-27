using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class AddDevice : Form
    {
        int bldID;
        public CapcityDataSet.buildingsRow bldRow;

        public AddDevice(int buildingID)
        {

            bldID = buildingID;

            InitializeComponent();

            added_label.Visible = false;

        }

        private void AddDevices_Load(object sender, EventArgs e)
        {
            this.bld_devTableAdapter.Fill(this.capcityDataSet.bld_dev);
            this.deviceListTableAdapter.Fill(this.device_Types_DataSet.deviceList);
            this.buildingsTableAdapter.Fill(this.capcityDataSet.buildings);

            bldRow = capcityDataSet.buildings.FindBybuildingID(bldID);

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            CapcityDataSet.bld_devRow newBldDevRow = capcityDataSet.bld_dev.Newbld_devRow();

            if (String.IsNullOrWhiteSpace(location_text.Text))
            {
                if (MessageBox.Show("Please enter a location.", "Invalid Entry", MessageBoxButtons.OK) == DialogResult.OK)
                    return;
            };
            newBldDevRow.deviceLocation = location_text.Text.Trim();

            newBldDevRow.remarks = remarks_text.Text.Trim();
            newBldDevRow.deviceID = (int)device_comboBox.SelectedValue;
            newBldDevRow.buildingID = bldRow.buildingID;

            if (MessageBox.Show("Do you want to add device ?", "Add Device", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                capcityDataSet.bld_dev.Rows.Add(newBldDevRow);
                bld_devTableAdapter.Update(capcityDataSet.bld_dev);
                added_label.Visible = true;
            }

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
