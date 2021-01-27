using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class Buildings : Form
    {
        public Buildings()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new Splash();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void Buildings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'buildings_DataSet.buildings' table. You can move, or remove it, as needed.
            this.buildingsTableAdapter.Fill(this.buildings_DataSet.buildings);

        }

        private void new_button_Click(object sender, EventArgs e)
        {
            var newBuild = new AddNewBuilding();
            newBuild.FormClosing += new FormClosingEventHandler(this.newBuild_FormClosing);
            newBuild.Show();
        }

        private void newBuild_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.buildingsTableAdapter.Fill(this.buildings_DataSet.buildings);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                buildingsTableAdapter.Update(buildings_DataSet.buildings);
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            this.buildingsTableAdapter.Fill(this.buildings_DataSet.buildings);
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            int bldID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var editBuild = new ViewBuildings(bldID);
            editBuild.Show();
        }
    }
}
