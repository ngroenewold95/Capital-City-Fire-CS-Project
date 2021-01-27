using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class ViewReport : Form
    {
        int repID;
        public Buildings_DataSet.buildingsRow bldRow;
        public CapcityDataSet.reportRow reportRow;
        public CapcityDataSet.report_devRow[] reportDevices;
        public CapcityDataSet.report_eluRow[] reportElus;
        public CapcityDataSet.report_extRow[] reportExts;
        public CapcityDataSet.report_techRow[] reportTechs;


        public ViewReport(int reportID)
        {
            repID = reportID;

            InitializeComponent();

            streetnumber_text.ReadOnly = true;
            street_text.ReadOnly = true;
            postalcode_text.ReadOnly = true;
            city_text.ReadOnly = true;
            province_text.ReadOnly = true;
            altname_text.ReadOnly = true;
            tech_text1.ReadOnly = true;
            tech_text2.ReadOnly = true;

            dev_dataGridView.Visible = true;
            elu_dataGridView.Visible = false;
            ext_dataGridView.Visible = false;
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            fillTables();
            displayBuilding();
            displayDevices();
            displayElus();
            displayExts();
            displayTechs();
        }

        public void displayBuilding()
        {
            reportRow = capcityDataSet.report.FindByreportID(repID);
            bldRow = buildings_DataSet.buildings.FindBybuildingID(reportRow.buildingID);

            device_comments_richText.Text = reportRow.IsdeviceCommentsNull() ? string.Empty : reportRow.deviceComments;
            elu_comments_richText.Text = reportRow.IseluCommentsNull() ? string.Empty : reportRow.eluComments;
            ext_comments_richText.Text = reportRow.IsextCommentsNull() ? string.Empty : reportRow.extComments;

            date_text.Text = reportRow.dateOfReport.ToLongDateString();

            streetnumber_text.Text = bldRow.streetNumber;
            street_text.Text = bldRow.streetNumber;
            postalcode_text.Text = bldRow.postalCode;
            city_text.Text = bldRow.city;
            province_text.Text = bldRow.province;
            altname_text.Text = bldRow.altName;
        }

        private void displayDevices()
        {
            reportDevices = (CapcityDataSet.report_devRow[])capcityDataSet.report_dev.Select("reportID = " + repID);

            foreach (CapcityDataSet.report_devRow device in reportDevices)
            {
                int rowID = dev_dataGridView.Rows.Add();

                DataGridViewRow row = dev_dataGridView.Rows[rowID];

                row.Cells["deviceUID"].Value = device.deviceUID;
                row.Cells["repairs"].Value = device.repairsRequired;
                row.Cells["remarks"].Value = device.IsremarksNull() ? string.Empty : device.remarks;

                CapcityDataSet.bld_devRow bldDev = capcityDataSet.bld_dev.FindBydeviceUID(device.deviceUID);

                row.Cells["deviceID"].Value = bldDev.deviceID;
                row.Cells["deviceLocation"].Value = bldDev.deviceLocation;

                Device_Types_DataSet.deviceListRow devRow = device_Types_DataSet.deviceList.FindBydeviceID(bldDev.deviceID);

                row.Cells["deviceCode"].Value = devRow.deviceCode;
                row.Cells["a"].Value = devRow.a;
                row.Cells["c"].Value = devRow.c;
                row.Cells["d"].Value = devRow.d;
                row.Cells["e"].Value = devRow.e;
            }
        }

        private void displayElus()
        {
            reportElus = (CapcityDataSet.report_eluRow[])capcityDataSet.report_elu.Select("reportID = " + repID);

            foreach (CapcityDataSet.report_eluRow elu in reportElus)
            {
                int rowID = elu_dataGridView.Rows.Add();

                DataGridViewRow row = elu_dataGridView.Rows[rowID];

                row.Cells["eluUID"].Value = elu.eluUID;
                row.Cells["eluRemarks"].Value = elu.IsremarksNull() ? string.Empty : elu.remarks;

                CapcityDataSet.bld_eluRow bldElu = capcityDataSet.bld_elu.FindByeluUID(elu.eluUID);

                row.Cells["eluID"].Value = bldElu.eluID;
                row.Cells["eluLocation"].Value = bldElu.eluLocation;

                ELU_Types_DataSet.eluListRow eluRow = eLU_Types_DataSet.eluList.FindByeluID(bldElu.eluID);

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
            reportExts = (CapcityDataSet.report_extRow[])capcityDataSet.report_ext.Select("reportID  = " + repID);

            foreach (CapcityDataSet.report_extRow ext in reportExts)
            {
                int rowID = ext_dataGridView.Rows.Add();

                DataGridViewRow row = ext_dataGridView.Rows[rowID];

                row.Cells["extUID"].Value = ext.extUID;
                row.Cells["extRemarks"].Value = ext.IsremarksNull() ? string.Empty : ext.remarks;
                row.Cells["rmh"].Value = ext.IsrmhNull() ? string.Empty : ext.rmh;

                CapcityDataSet.bld_extRow bldExt = capcityDataSet.bld_ext.FindByextUID(ext.extUID);

                row.Cells["extID"].Value = bldExt.extID;
                row.Cells["extLocation"].Value = bldExt.extLocation;

                row.Cells["serial"].Value = bldExt.IsserialNull() ? string.Empty : bldExt.serial;
                row.Cells["mfgDate"].Value = bldExt.IsmfgDateNull() ? string.Empty : bldExt.mfgDate;
                row.Cells["srvDate"].Value = bldExt.IssrvDateNull() ? string.Empty : bldExt.srvDate;

                EXT_Types_DataSet.extListRow extRow = eXT_Types_DataSet.extList.FindByextID(bldExt.extID);

                row.Cells["sizeType"].Value = extRow.extType;
            }
        }

        private void displayTechs()
        {
            reportTechs = (CapcityDataSet.report_techRow[])capcityDataSet.report_tech.Select("reportID = " + repID);
            CapcityDataSet.techniciansRow techRow1 = capcityDataSet.technicians.FindBytechnicianID(reportTechs[0].technicianID);
            CapcityDataSet.techniciansRow techRow2 = capcityDataSet.technicians.FindBytechnicianID(reportTechs[1].technicianID);

            string fullname1 = techRow1.firstName + " " + techRow1.lastName;
            string fullname2 = techRow2.firstName + " " + techRow2.lastName;

            tech_text1.Text = fullname1;
            tech_text2.Text = fullname2;

        }

        private void device_button_Click(object sender, EventArgs e)
        {
            dev_dataGridView.Visible = true;
            elu_dataGridView.Visible = false;
            ext_dataGridView.Visible = false;

        }

        private void elu_button_Click(object sender, EventArgs e)
        {
            dev_dataGridView.Visible = false;
            elu_dataGridView.Visible = true;
            ext_dataGridView.Visible = false;
        }

        private void ext_button_Click(object sender, EventArgs e)
        {
            dev_dataGridView.Visible = false;
            elu_dataGridView.Visible = false;
            ext_dataGridView.Visible = true;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
