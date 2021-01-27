using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class ViewElus : Form
    {
        public int bldID;
        public CapcityDataSet.bld_eluRow[] bldElus;

        public ViewElus(int buildingID)
        {
            bldID = buildingID;
            InitializeComponent();

        }

        private void ViewElus_Load(object sender, EventArgs e)
        {
            fillTables();
            displayElus();
        }

        private void fillTables()
        {
            this.buildingsTableAdapter.Fill(this.buildings_DataSet.buildings);
            this.bld_eluTableAdapter.Fill(this.capcityDataSet.bld_elu);
            this.eluListTableAdapter.Fill(this.eLU_Types_DataSet.eluList);
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
                row.Cells["eluRemarks"].Value = elu.remarks;


                ELU_Types_DataSet.eluListRow eluRow = eLU_Types_DataSet.eluList.FindByeluID(elu.eluID);

                row.Cells["type"].Value = eluRow.eluType;
                row.Cells["voltage"].Value = eluRow.c;
            }
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
            displayElus();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int index;
            int UID;

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
            fillTables();
            displayElus();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
