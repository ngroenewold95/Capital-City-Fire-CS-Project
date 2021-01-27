using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class ViewDevices : Form
    {
        public int bldID;
        public CapcityDataSet.bld_devRow[] bldDevices;

        public ViewDevices(int buildingID)
        {
            bldID = buildingID;
            InitializeComponent();

        }

        private void ViewDevices_Load(object sender, EventArgs e)
        {
            fillTables();
            displayDevices();
        }

        private void fillTables()
        {
            this.buildingsTableAdapter.Fill(this.buildings_DataSet.buildings);
            this.bld_devTableAdapter.Fill(this.capcityDataSet.bld_dev);
            this.deviceListTableAdapter.Fill(this.device_Types_DataSet.deviceList);
        }

        private void displayDevices()
        {
            dev_dataGridView.Rows.Clear();
            bldDevices = (CapcityDataSet.bld_devRow[])capcityDataSet.bld_dev.Select("buildingID = " + bldID);

            foreach (CapcityDataSet.bld_devRow device in bldDevices)
            {
                if (!device.IsdeletedNull() && device.deleted == true) continue;
                int rowID = dev_dataGridView.Rows.Add();

                DataGridViewRow row = dev_dataGridView.Rows[rowID];

                row.Cells["deviceID"].Value = device.deviceID;
                row.Cells["deviceUID"].Value = device.deviceUID;
                row.Cells["deviceLocation"].Value = device.deviceLocation;
                row.Cells["remarks"].Value = device.remarks;


                Device_Types_DataSet.deviceListRow devRow = device_Types_DataSet.deviceList.FindBydeviceID(device.deviceID);

                row.Cells["deviceCode"].Value = devRow.deviceCode;
            }
        }

        private void add_device_button_Click(object sender, EventArgs e)
        {
            fillTables();
            var newDevice = new AddDevice(bldID);
            newDevice.FormClosing += new FormClosingEventHandler(newDevice_FormClosing);
            newDevice.Show();
        }

        private void newDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            fillTables();
            displayDevices();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int index;
            int UID;

            if (dev_dataGridView.SelectedRows.Count > 0)
            {
                index = dev_dataGridView.SelectedRows[0].Index;
                UID = (int)dev_dataGridView.Rows[index].Cells["deviceUID"].Value;

                capcityDataSet.bld_dev.FindBydeviceUID(UID).deleted = true;
                bld_devTableAdapter.Update(capcityDataSet.bld_dev);
            }
            else
            {
                MessageBox.Show("No Device Selected for Deletion!", "No Device Selected", MessageBoxButtons.OK);
            }
            fillTables();
            displayDevices();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
