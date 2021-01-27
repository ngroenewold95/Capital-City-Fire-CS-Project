using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'capcityDataSet.report' table. You can move, or remove it, as needed.
            this.reportTableAdapter.Fill(this.capcityDataSet.report);
            // TODO: This line of code loads data into the 'capcityDataSet.buildings' table. You can move, or remove it, as needed.
            this.buildingsTableAdapter.Fill(this.capcityDataSet.buildings);
            // TODO: This line of code loads data into the 'capcityDataSet.companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.capcityDataSet.companies);

            foreach (DataGridViewRow row in report_dataGridView.Rows)
            {
                CapcityDataSet.buildingsRow bldRow = capcityDataSet.buildings.FindBybuildingID((int)row.Cells[0].Value);
                row.Cells["address"].Value = bldRow.streetNumber.ToString() + " " + bldRow.street.ToString() + ", " + bldRow.city.ToString() + ", " + bldRow.province.ToString();
            }
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            int reportID = (int)report_dataGridView.SelectedRows[0].Cells[1].Value;
            var viewReport = new ViewReport(reportID);
            viewReport.Show();
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Splash();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }
    }
}
