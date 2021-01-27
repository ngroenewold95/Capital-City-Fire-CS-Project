using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class ViewExts : Form
    {
        public int bldID;
        public CapcityDataSet.bld_extRow[] bldExts;
        public ViewExts(int buildingID)
        {
            bldID = buildingID;
            InitializeComponent();

        }

        private void ViewExts_Load(object sender, EventArgs e)
        {
            fillTables();
            displayExts();
        }

        private void fillTables()
        {
            this.buildingsTableAdapter.Fill(this.buildings_DataSet.buildings);
            this.bld_extTableAdapter.Fill(this.capcityDataSet.bld_ext);
            this.extListTableAdapter.Fill(this.eXT_Types_DataSet.extList);
        }

        private void displayExts()
        {
            ext_dataGridView.Rows.Clear();
            bldExts = (CapcityDataSet.bld_extRow[])capcityDataSet.bld_ext.Select("buildingID = " + bldID);

            foreach (CapcityDataSet.bld_extRow ext in bldExts)
            {
                if (!ext.IsdeletedNull() && ext.deleted == true) continue;
                int rowID = ext_dataGridView.Rows.Add();

                DataGridViewRow row = ext_dataGridView.Rows[rowID];

                row.Cells["extID"].Value = ext.extID;
                row.Cells["extUID"].Value = ext.extUID;
                row.Cells["extLocation"].Value = ext.extLocation;
                row.Cells["extRemarks"].Value = ext.remarks;

                row.Cells["serial"].Value = ext.IsserialNull() ? string.Empty : ext.serial;
                row.Cells["mfgDate"].Value = ext.IsmfgDateNull() ? string.Empty : ext.mfgDate;
                row.Cells["srvDate"].Value = ext.IssrvDateNull() ? string.Empty : ext.srvDate;

                EXT_Types_DataSet.extListRow extRow = eXT_Types_DataSet.extList.FindByextID(ext.extID);

                row.Cells["sizeType"].Value = extRow.extType;
            }
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
            displayExts();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int index;
            int UID;

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
            fillTables();
            displayExts();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

