using System;
using System.Text.RegularExpressions;
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

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string _phoneRegex = @"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$";
            string headerText =
                dataGridView1.Columns[e.ColumnIndex].HeaderText;

            if (headerText.Equals("Phone Number"))
            {
                DataGridViewCell cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                
                if (e.FormattedValue != null && !Regex.Match(e.FormattedValue.ToString().Trim().ToUpper(), 
                    _phoneRegex).Success)
                {
                    if (e.FormattedValue.ToString().Trim().Equals(""))
                    {
                        cell.ErrorText = string.Empty;
                        return;
                    }
                    cell.ErrorText = "Invalid Phone Number";
                    MessageBox.Show("Invalid Phone Number Entry!", "Invalid Entry", MessageBoxButtons.OK);
                    e.Cancel = true;
                }
                else
                {
                    cell.ErrorText = string.Empty;
                }
            }
            else if (headerText.Equals("Email"))
            {
                DataGridViewCell cell = dataGridView1[e.ColumnIndex, e.RowIndex];

                if (e.FormattedValue != null && !IsValidEmail(e.FormattedValue.ToString().Trim()))
                {
                    if (e.FormattedValue.ToString().Trim().Equals(""))
                    {
                        cell.ErrorText = string.Empty;
                        return;
                    }
                    cell.ErrorText = "Invalid Email";
                    MessageBox.Show("Invalid Email Entry!", "Invalid Entry", MessageBoxButtons.OK);
                    e.Cancel = true;
                }
                else
                {
                    cell.ErrorText = string.Empty;
                }
            }



        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
