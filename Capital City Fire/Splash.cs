using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capital_City_Fire
{
    public partial class Splash : Form
    {
        public Splash()
        {
            string sConn = "Capital_City_Fire.Properties.Settings.capcityConn";
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[sConn];

            SqlConnection conn = new SqlConnection(settings.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            InitializeComponent();
        }

        private void Technicians_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tech = new Technicians();
            tech.Closed += (s, args) => this.Close();
            tech.Show();
        }

        private void Companies_Click(object sender, EventArgs e)
        {
            this.Hide();
            var comp = new Companies();
            comp.Closed += (s, args) => this.Close();
            comp.Show();
        }

        private void FireDept_Click(object sender, EventArgs e)
        {
            this.Hide();
            var firedept = new Fire_Departments();
            firedept.Closed += (s, args) => this.Close();
            firedept.Show();
        }

        private void elu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var elu = new ELU_Types();
            elu.Closed += (s, args) => this.Close();
            elu.Show();
        }

        private void ext_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ext = new EXT_Types();
            ext.Closed += (s, args) => this.Close();
            ext.Show();
        }

        private void device_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var device = new Device_Types();
            device.Closed += (s, args) => this.Close();
            device.Show();
        }

        private void buildings_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var buildings = new Buildings();
            buildings.Closed += (s, args) => this.Close();
            buildings.Show();
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reports = new Reports();
            reports.Closed += (s, args) => this.Close();
            reports.Show();
        }
    }
}
