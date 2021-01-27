using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class TechReports : Form
    {
        int techID;
        public CapcityDataSet.techniciansRow techRow;
        public CapcityDataSet.report_techRow[] techReports;

        public TechReports(int technicianID)
        {
            techID = technicianID;

            InitializeComponent();
        }

        private void TechReports_Load(object sender, EventArgs e)
        {
            this.reportTableAdapter.Fill(this.capcityDataSet.report);
            this.report_techTableAdapter.Fill(this.capcityDataSet.report_tech);
            this.techniciansTableAdapter.Fill(this.capcityDataSet.technicians);
            this.buildingsTableAdapter.Fill(this.buildings_DataSet.buildings);

            displayTech();
            displayReports();
        }

        private void displayReports()
        {
            techReports = (CapcityDataSet.report_techRow[])capcityDataSet.report_tech.Select("technicianID = " + techID);

            foreach (CapcityDataSet.report_techRow techReport in techReports)
            {
                int rowID = report_dataGridView.Rows.Add();

                DataGridViewRow row = report_dataGridView.Rows[rowID];

                CapcityDataSet.reportRow reportRow = capcityDataSet.report.FindByreportID(techReport.reportID);
                Buildings_DataSet.buildingsRow bldRow = buildings_DataSet.buildings.FindBybuildingID(reportRow.buildingID);

                row.Cells["address"].Value = bldRow.streetNumber.ToString() + " " + bldRow.street.ToString() + ", " + bldRow.city.ToString() + ", " + bldRow.province.ToString();
                row.Cells["reportID"].Value = techReport.reportID;
                row.Cells["dateOfReport"].Value = techReport.dateofInsp.ToShortDateString();
            }
        }

        private void displayTech()
        {
            techRow = capcityDataSet.technicians.FindBytechnicianID(techID);
            //CapcityDataSet.techniciansRow techRow = capcityDataSet.technicians.FindBytechnicianID(reportTechs[1].technicianID);

            string fullname = techRow.firstName + " " + techRow.lastName;

            tech_label.Text = fullname;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            int reportID = (int)report_dataGridView.SelectedRows[0].Cells["reportID"].Value;
            var viewReport = new ViewReport(reportID);
            viewReport.Show();
        }
    }

}
