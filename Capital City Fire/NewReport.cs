using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class NewReport : Form
    {
        int bldID;
        public Buildings_DataSet.buildingsRow bldRow;
        public CapcityDataSet.bld_devRow[] bldDevices;
        public CapcityDataSet.bld_eluRow[] bldElus;
        public CapcityDataSet.bld_extRow[] bldExts;

        public bool deviceListDisplayed;
        public bool eluListDisplayed;
        public bool extListDisplayed;

        public NewReport(int buildingID)
        {
            bldID = buildingID;

            InitializeComponent();

            streetnumber_text.ReadOnly = true;
            street_text.ReadOnly = true;
            postalcode_text.ReadOnly = true;
            city_text.ReadOnly = true;
            province_text.ReadOnly = true;
            altname_text.ReadOnly = true;

            dev_dataGridView.Visible = true;
            elu_dataGridView.Visible = false;
            ext_dataGridView.Visible = false;

            deviceListDisplayed = true;
            eluListDisplayed = false;
            extListDisplayed = false;

        }

        private void NewReport_Load(object sender, EventArgs e)
        {
            this.techniciansTableAdapter.Fill(this.capcityDataSet1.technicians);
            this.techniciansTableAdapter.Fill(this.capcityDataSet1.technicians);
            fillTables();
            displayBuilding();
            displayDevices();
            displayElus();
            displayExts();
        }

        public void displayBuilding()
        {
            bldRow = buildings_DataSet.buildings.FindBybuildingID(bldID);

            streetnumber_text.Text = bldRow.streetNumber;
            street_text.Text = bldRow.streetNumber;
            postalcode_text.Text = bldRow.postalCode;
            city_text.Text = bldRow.city;
            province_text.Text = bldRow.province;
            altname_text.Text = bldRow.altName;
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


                Device_Types_DataSet.deviceListRow devRow = device_Types_DataSet.deviceList.FindBydeviceID(device.deviceID);

                row.Cells["deviceCode"].Value = devRow.deviceCode;
                row.Cells["a"].Value = devRow.a;
                row.Cells["c"].Value = devRow.c;
                row.Cells["d"].Value = devRow.d;
                row.Cells["e"].Value = devRow.e;
            }
        }

        private void displayElus()
        {
            elu_dataGridView.Rows.Clear();
            bldElus = (CapcityDataSet.bld_eluRow[])capcityDataSet.bld_elu.Select("buildingID = " + bldID);

            foreach (CapcityDataSet.bld_eluRow elu in bldElus)
            {
                if (!elu.IsdeletedNull() && elu.deleted == true) continue;
                int rowID = elu_dataGridView.Rows.Add();

                DataGridViewRow row = elu_dataGridView.Rows[rowID];

                row.Cells["eluID"].Value = elu.eluID;
                row.Cells["eluUID"].Value = elu.eluUID;
                row.Cells["eluLocation"].Value = elu.eluLocation;

                ELU_Types_DataSet.eluListRow eluRow = eLU_Types_DataSet.eluList.FindByeluID(elu.eluID);

                row.Cells["type"].Value = eluRow.eluType;
                row.Cells["eluA"].Value = eluRow.a;
                row.Cells["eluB"].Value = eluRow.b;
                row.Cells["eluC"].Value = eluRow.c;
                row.Cells["eluD"].Value = eluRow.d;
                row.Cells["eluE"].Value = eluRow.e;
            }
        }

        private void displayExts()
        {
            ext_dataGridView.Rows.Clear();
            bldExts = (CapcityDataSet.bld_extRow[])capcityDataSet.bld_ext.Select("buildingID  = " + bldID);

            foreach (CapcityDataSet.bld_extRow ext in bldExts)
            {
                if (!ext.IsdeletedNull() && ext.deleted == true) continue;
                int rowID = ext_dataGridView.Rows.Add();

                DataGridViewRow row = ext_dataGridView.Rows[rowID];

                row.Cells["extID"].Value = ext.extID;
                row.Cells["extUID"].Value = ext.extUID;
                row.Cells["extLocation"].Value = ext.extLocation;

                row.Cells["serial"].Value = ext.IsserialNull() ? string.Empty : ext.serial;
                row.Cells["mfgDate"].Value = ext.IsmfgDateNull() ? string.Empty : ext.mfgDate;
                row.Cells["srvDate"].Value = ext.IssrvDateNull() ? string.Empty : ext.srvDate;

                EXT_Types_DataSet.extListRow extRow = eXT_Types_DataSet.extList.FindByextID(ext.extID);

                row.Cells["sizeType"].Value = extRow.extType;
            }
        }

        private void device_button_Click(object sender, EventArgs e)
        {
            dev_dataGridView.Visible = true;
            elu_dataGridView.Visible = false;
            ext_dataGridView.Visible = false;

            deviceListDisplayed = true;
            eluListDisplayed = false;
            extListDisplayed = false;
        }

        private void elu_button_Click(object sender, EventArgs e)
        {
            dev_dataGridView.Visible = false;
            elu_dataGridView.Visible = true;
            ext_dataGridView.Visible = false;

            deviceListDisplayed = false;
            eluListDisplayed = true;
            extListDisplayed = false;
        }

        private void ext_button_Click(object sender, EventArgs e)
        {
            dev_dataGridView.Visible = false;
            elu_dataGridView.Visible = false;
            ext_dataGridView.Visible = true;

            deviceListDisplayed = false;
            eluListDisplayed = false;
            extListDisplayed = true;
        }


        private void save_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save your changes ?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if ((int)tech_comboBox1.SelectedValue == (int)tech_comboBox2.SelectedValue)
                {
                    MessageBox.Show("Selected techs cannot be the same person!", "Invalid Techs", MessageBoxButtons.OK);
                    tech_label1.ForeColor = Color.Red;
                    tech_label2.ForeColor = Color.Red;
                    return;
                }
                int newreportID = createReport();

                createReportTech(newreportID);
                createReportDev(newreportID);
                createReportElu(newreportID);
                createReportExt(newreportID);

                this.Close();
            }

        }

        private int createReport()
        {
            CapcityDataSet.reportRow newReport = capcityDataSet.report.NewreportRow();
            newReport.buildingID = bldRow.buildingID;
            newReport.dateOfReport = dateTimePicker.Value;
            newReport.deviceComments = device_comments_richText.Text;
            newReport.eluComments = elu_comments_richText.Text;
            newReport.extComments = ext_comments_richText.Text;

            capcityDataSet.report.AddreportRow(newReport);
            int reportID = Convert.ToInt32(reportTableAdapter.InsertQuery(newReport.buildingID, newReport.dateOfReport, newReport.deviceComments, newReport.eluComments, newReport.extComments, string.Empty));
            fillTables();
            return reportID;
        }

        private void createReportTech(int reportID)
        {
            createtech1(reportID);
            createtech2(reportID);

        }

        private void createtech1(int reportID)
        {
            CapcityDataSet.report_techRow newReportTech1 = capcityDataSet.report_tech.Newreport_techRow();
            CapcityDataSet.techniciansRow tech = capcityDataSet.technicians.FindBytechnicianID((int)tech_comboBox1.SelectedValue);


            newReportTech1.reportID = capcityDataSet.report.FindByreportID(reportID).reportID;
            newReportTech1.technicianID = tech.technicianID;
            newReportTech1.dateofInsp = dateTimePicker.Value;

            capcityDataSet.report_tech.Addreport_techRow(newReportTech1);
            report_techTableAdapter.Update(capcityDataSet.report_tech);
        }

        private void createtech2(int reportID)
        {
            CapcityDataSet.report_techRow newReportTech2 = capcityDataSet.report_tech.Newreport_techRow();
            CapcityDataSet.techniciansRow tech = capcityDataSet.technicians.FindBytechnicianID((int)tech_comboBox2.SelectedValue);

            newReportTech2.reportID = capcityDataSet.report.FindByreportID(reportID).reportID;
            newReportTech2.technicianID = tech.technicianID;
            newReportTech2.dateofInsp = dateTimePicker.Value;


            capcityDataSet.report_tech.Addreport_techRow(newReportTech2);
            report_techTableAdapter.Update(capcityDataSet.report_tech);
        }

        private void createReportDev(int reportID)
        {
            foreach (DataGridViewRow row in dev_dataGridView.Rows)
            {
                CapcityDataSet.report_devRow newRepDevRow = capcityDataSet.report_dev.Newreport_devRow();
                CapcityDataSet.bld_devRow bldDevRow = capcityDataSet.bld_dev.FindBydeviceUID((int)row.Cells["deviceUID"].Value);

                newRepDevRow.reportID = capcityDataSet.report.FindByreportID(reportID).reportID;
                newRepDevRow.deviceUID = bldDevRow.deviceUID;

                if (row.Cells["b"].Value != null)
                    newRepDevRow.repairsRequired = row.Cells["b"].Value.ToString();
                else
                    newRepDevRow.repairsRequired = "N";

                if (row.Cells["remarks"].Value != null)
                    newRepDevRow.remarks = row.Cells["remarks"].Value.ToString();

                capcityDataSet.report_dev.Addreport_devRow(newRepDevRow);
            }
            report_devTableAdapter.Update(capcityDataSet.report_dev);
        }

        private void createReportElu(int reportID)
        {
            foreach (DataGridViewRow row in elu_dataGridView.Rows)
            {
                CapcityDataSet.report_eluRow newRepEluRow = capcityDataSet.report_elu.Newreport_eluRow();
                CapcityDataSet.bld_eluRow bldEluRow = capcityDataSet.bld_elu.FindByeluUID((int)row.Cells["eluUID"].Value);

                newRepEluRow.reportID = capcityDataSet.report.FindByreportID(reportID).reportID;
                newRepEluRow.eluUID = bldEluRow.eluUID;

                if (row.Cells["eluRemarks"].Value != null)
                    newRepEluRow.remarks = row.Cells["eluRemarks"].Value.ToString();

                capcityDataSet.report_elu.Addreport_eluRow(newRepEluRow);
            }
            report_eluTableAdapter.Update(capcityDataSet.report_elu);
        }

        private void createReportExt(int reportID)
        {
            foreach (DataGridViewRow row in ext_dataGridView.Rows)
            {
                CapcityDataSet.report_extRow newRepExtRow = capcityDataSet.report_ext.Newreport_extRow();
                CapcityDataSet.bld_extRow bldExtRow = capcityDataSet.bld_ext.FindByextUID((int)row.Cells["extUID"].Value);

                newRepExtRow.reportID = capcityDataSet.report.FindByreportID(reportID).reportID;
                newRepExtRow.extUID = bldExtRow.extUID;

                if (row.Cells["rmh"].Value != null)
                    newRepExtRow.rmh = row.Cells["rmh"].Value.ToString();

                if (row.Cells["extRemarks"].Value != null)
                    newRepExtRow.remarks = row.Cells["extRemarks"].Value.ToString();

                capcityDataSet.report_ext.Addreport_extRow(newRepExtRow);
            }
            report_extTableAdapter.Update(capcityDataSet.report_ext);
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
            displayBuilding();
            displayDevices();
        }

        private void add_elu_button_Click(object sender, EventArgs e)
        {
            fillTables();
            var newElu = new AddElu(bldID);
            newElu.FormClosing += new FormClosingEventHandler(newElu_FormClosing);
            newElu.Show();
        }

        private void newElu_FormClosing(object sender, FormClosingEventArgs e)
        {
            fillTables();
            displayBuilding();
            displayElus();
        }

        private void add_ext_button_Click(object sender, EventArgs e)
        {
            fillTables();
            var newExt = new AddExt(bldID);
            newExt.FormClosing += new FormClosingEventHandler(newExt_FormClosing);
            newExt.Show();
        }

        private void newExt_FormClosing(object sender, FormClosingEventArgs e)
        {
            fillTables();
            displayBuilding();
            displayExts();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            fillTables();
            displayDevices();
            displayElus();
            displayExts();
        }

        private void fillTables()
        {
            this.reportTableAdapter.Fill(this.capcityDataSet.report);
            this.companiesTableAdapter.Fill(this.capcityDataSet.companies);

            this.bld_devTableAdapter.Fill(this.capcityDataSet.bld_dev);
            this.bld_eluTableAdapter.Fill(this.capcityDataSet.bld_elu);
            this.bld_extTableAdapter.Fill(this.capcityDataSet.bld_ext);

            this.eluListTableAdapter.Fill(this.eLU_Types_DataSet.eluList);
            this.deviceListTableAdapter.Fill(this.device_Types_DataSet.deviceList);
            this.extListTableAdapter.Fill(this.eXT_Types_DataSet.extList);

            this.report_techTableAdapter.Fill(this.capcityDataSet.report_tech);
            this.report_devTableAdapter.Fill(this.capcityDataSet.report_dev);
            this.report_eluTableAdapter.Fill(this.capcityDataSet.report_elu);
            this.report_extTableAdapter.Fill(this.capcityDataSet.report_ext);

            this.buildingsTableAdapter.Fill(this.buildings_DataSet.buildings);
            this.techniciansTableAdapter.Fill(this.capcityDataSet.technicians);
            this.techniciansTableAdapter1.Fill(this.technicians_DataSet.technicians);
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int index;
            int UID;

            if (deviceListDisplayed == true)
            {
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
            }
            else if (eluListDisplayed == true)
            {
                if (elu_dataGridView.SelectedRows.Count > 0)
                {
                    index = elu_dataGridView.SelectedRows[0].Index;
                    UID = (int)elu_dataGridView.Rows[index].Cells["eluUID"].Value;

                    capcityDataSet.bld_elu.FindByeluUID(UID).deleted = true;
                    bld_eluTableAdapter.Update(capcityDataSet.bld_elu);
                }
                else
                {
                    MessageBox.Show("No ELU Selected for Deletion!", "No ELU Selected", MessageBoxButtons.OK);
                }
            }
            else if (extListDisplayed == true)
            {
                if (ext_dataGridView.SelectedRows.Count > 0)
                {
                    index = ext_dataGridView.SelectedRows[0].Index;
                    UID = (int)ext_dataGridView.Rows[index].Cells["extUID"].Value;

                    capcityDataSet.bld_ext.FindByextUID(UID).deleted = true;
                    bld_extTableAdapter.Update(capcityDataSet.bld_ext);
                }
                else
                {
                    MessageBox.Show("No Extinguisher Selected for Deletion!", "No Extinguisher Selected", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No list selected!!", "No list Selected", MessageBoxButtons.OK);
            }
            fillTables();
            displayBuilding();
            displayDevices();
            displayElus();
            displayExts();
        }
    }
}
