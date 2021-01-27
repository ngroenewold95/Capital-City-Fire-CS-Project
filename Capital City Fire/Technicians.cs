using System;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class Technicians : Form
    {
        public Technicians()
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

        private void Technicians_Load(object sender, EventArgs e)
        {
            this.techniciansTableAdapter.Fill(this.technicians_DataSet.technicians);

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
                techniciansTableAdapter.Update(technicians_DataSet.technicians);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save your changes ?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                techniciansTableAdapter.Update(technicians_DataSet.technicians);
                dataGridView1.ReadOnly = true;
                save_button.Enabled = false;
                new_button.Enabled = true;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            this.techniciansTableAdapter.Fill(this.technicians_DataSet.technicians);
            dataGridView1.ReadOnly = true;
            save_button.Enabled = false;
            new_button.Enabled = true;
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            int techID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var techReports = new TechReports(techID);
            techReports.Show();
        }
    }
}
