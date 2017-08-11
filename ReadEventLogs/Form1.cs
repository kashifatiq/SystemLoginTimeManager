using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadEventLogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(chkOnlyTodaysLogs.Checked);
        }

        private void LoadData(bool ShowOnlyTodaysLogs)
        {
            DateTime TodaysDate = DateTime.Today;
            EventLog log = new EventLog("Security");
            var entries = log.Entries.Cast<EventLogEntry>().Where(x => x.InstanceId > 0 && x.CategoryNumber == 12544 && x.TimeGenerated > TodaysDate).Select(x => new
            {
                x.TimeGenerated,
                x.Message
            }).ToList();

            dataGridView1.DataSource = entries;
            
            DateTime TodaysFirstLogin = Convert.ToDateTime(dataGridView1.Rows[0].Cells["TimeGenerated"].Value);
            lblTotalTimeInOffice.TextAlign = ContentAlignment.TopCenter;
            lblTotalTimeInOffice.Text = DateTime.Now.Subtract(TodaysFirstLogin).ToString();
        }

        private void chkOnlyTodaysLogs_CheckedChanged(object sender, EventArgs e)
        {
            LoadData(chkOnlyTodaysLogs.Checked);
        }
    }
}
