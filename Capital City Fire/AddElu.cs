using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class AddElu : Form
    {
        int bldID;
        public CapcityDataSet.buildingsRow bldRow;

        public AddElu(int buildingID)
        {

            bldID = buildingID;
            InitializeComponent();

            added_label.Visible = false;
        }

        private void AddElu_Load(object sender, EventArgs e)
        {
            this.bld_eluTableAdapter.Fill(this.capcityDataSet.bld_elu);
            this.eluListTableAdapter.Fill(this.capcityDataSet.eluList);
            this.buildingsTableAdapter.Fill(this.capcityDataSet.buildings);

            bldRow = capcityDataSet.buildings.FindBybuildingID(bldID);

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            CapcityDataSet.bld_eluRow newBldEluRow = capcityDataSet.bld_elu.Newbld_eluRow();

            if (String.IsNullOrWhiteSpace(location_text.Text))
            {
                if (MessageBox.Show("Please enter a location.", "Invalid Entry", MessageBoxButtons.OK) == DialogResult.OK)
                    return;
            };
            newBldEluRow.eluLocation = location_text.Text.Trim();

            newBldEluRow.remarks = remarks_text.Text.Trim();
            newBldEluRow.eluID = (int)elu_comboBox.SelectedValue;
            newBldEluRow.buildingID = bldRow.buildingID;

            if (MessageBox.Show("Do you want to add ELU ?", "Add ELU", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                capcityDataSet.bld_elu.Rows.Add(newBldEluRow);
                bld_eluTableAdapter.Update(capcityDataSet.bld_elu);
                added_label.Visible = true;
            }


        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
