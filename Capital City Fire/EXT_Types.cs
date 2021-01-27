using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class EXT_Types : Form
    {
        public EXT_Types()
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
        private void EXT_Types_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eXT_Types_DataSet.extList' table. You can move, or remove it, as needed.
            this.extListTableAdapter.Fill(this.eXT_Types_DataSet.extList);

        }

        private void new_button_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            save_button.Enabled = true;
            new_button.Enabled = false;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                extListTableAdapter.Update(eXT_Types_DataSet.extList);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save your changes ?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                extListTableAdapter.Update(eXT_Types_DataSet.extList);
                dataGridView1.ReadOnly = true;
                save_button.Enabled = false;
                new_button.Enabled = true;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            this.extListTableAdapter.Fill(this.eXT_Types_DataSet.extList);
            dataGridView1.ReadOnly = true;
            save_button.Enabled = false;
            new_button.Enabled = true;
        }
    }
}
