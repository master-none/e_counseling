using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_counseling
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_studentprofile_Click(object sender, EventArgs e)
        {
            var newform = new StudentProfile();
            newform.Show();
        }

        private void btn_logcomplaint_Click(object sender, EventArgs e)
        {
            var newform = new LogComplaints();
            newform.Show();
        }

        private void btn_managecomplaint_Click(object sender, EventArgs e)
        {
            var newform = new ManageComplaint();
            newform.Show();
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            var newform = new ScheduleComplaint();
            newform.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            var newform = new Settings();
            newform.Show();
        }
    }
}
