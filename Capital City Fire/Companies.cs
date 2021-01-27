using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class Companies : Form
    {
        public Companies()
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

        private void Companies_Load(object sender, EventArgs e)
        {
            this.companiesTableAdapter.Fill(this.companies_DataSet.companies);

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
                companiesTableAdapter.Update(companies_DataSet.companies);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save your changes ?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                companiesTableAdapter.Update(companies_DataSet.companies);
                dataGridView1.ReadOnly = true;
                save_button.Enabled = false;
                new_button.Enabled = true;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            this.companiesTableAdapter.Fill(this.companies_DataSet.companies);
            dataGridView1.ReadOnly = true;
            save_button.Enabled = false;
            new_button.Enabled = true;
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
           
            DataGridViewCell nameCell = row.Cells[dataGridView1.Columns["Company"].Index];
            DataGridViewCell phoneCell = row.Cells[dataGridView1.Columns["Phone Number"].Index];
            DataGridViewCell emailCell = row.Cells[dataGridView1.Columns["Email"].Index];

            e.Cancel = !(IsNameGood(nameCell) && IsPhoneGood(phoneCell) && IsEmailGood(emailCell));
        }

        private bool IsNameGood(DataGridViewCell cell)
        {
            if ((cell.Value == null) || (cell.Value.ToString().Length == 0))
            {
                cell.ErrorText = "Please enter a company name";
                dataGridView1.Rows[cell.RowIndex].ErrorText = "Please enter a company name";
                return false;
            }
            return true;
        }

        private bool IsPhoneGood(DataGridViewCell cell)
        {
            Int32 cellValueAsInt;
            if ((cell.Value == null) || (cell.Value.ToString().Length == 0))
            {
                cell.ErrorText = "Please enter a phone number";
                dataGridView1.Rows[cell.RowIndex].ErrorText = "Please enter a phone number";
                return false;
            }
            else if (!Int32.TryParse(cell.Value.ToString(), out cellValueAsInt))
            {
                cell.ErrorText = "A phone number must be all digits";
                dataGridView1.Rows[cell.RowIndex].ErrorText =
                    "A phone number must be all digits";
                return false;
            }
            else if (cell.Value.ToString().Length != 10)
            {
                cell.ErrorText = "A phone number must be 10 digits";
                dataGridView1.Rows[cell.RowIndex].ErrorText =
                    "A phone number must be 10 digits";
                return false;
            }
            return true;
        }
        private bool IsEmailGood(DataGridViewCell cell)
        {
            return true;
        }
    }
}
