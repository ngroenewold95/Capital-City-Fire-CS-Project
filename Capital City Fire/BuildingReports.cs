using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class BuildingReports : Form
    {
        int bldID;
        public Buildings_DataSet.buildingsRow bldRow;
        public CapcityDataSet.reportRow[] bldReports;

        public BuildingReports(int buildingID)
        {
            bldID = buildingID;
            InitializeComponent();

            streetnumber_text.ReadOnly = true;
            street_text.ReadOnly = true;
            postalcode_text.ReadOnly = true;
            city_text.ReadOnly = true;
            province_text.ReadOnly = true;
            altname_text.ReadOnly = true;
        }

        private void BuildingReports_Load(object sender, EventArgs e)
        {
            loadTables();
            displayBuilding();
            displayReports();
        }

        private void loadTables()
        {
            this.buildingsTableAdapter.Fill(this.buildings_DataSet.buildings);
            this.reportTableAdapter.Fill(this.capcityDataSet.report);
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

        private void displayReports()
        {
            bldReports = (CapcityDataSet.reportRow[])capcityDataSet.report.Select("buildingID = " + bldID);
            report_dataGridView.Rows.Clear();

            foreach (CapcityDataSet.reportRow report in bldReports)
            {
                int rowID = report_dataGridView.Rows.Add();

                DataGridViewRow row = report_dataGridView.Rows[rowID];

                row.Cells["reportID"].Value = report.reportID;
                row.Cells["dateOfReport"].Value = report.dateOfReport.ToShortDateString();
            }
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            var newReport = new NewReport(bldID);
            newReport.FormClosing += new FormClosingEventHandler(this.newReport_FormClosing);
            newReport.Show();
        }

        private void newReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            loadTables();
            displayReports();
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            int reportID = (int)report_dataGridView.SelectedRows[0].Cells["reportID"].Value;
            var viewReport = new ViewReport(reportID);
            viewReport.Show();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            loadTables();
            displayReports();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
