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
    public partial class frmSummary : Form
    {
        public frmSummary()
        {
            InitializeComponent();
        }

        private void frmSummary_Load(object sender, EventArgs e)
        {
            DateTime TodaysDate = DateTime.Today;
            EventLog log = new EventLog("Security");
            var entries = log.Entries.Cast<EventLogEntry>().Where(x => x.InstanceId > 0 && x.CategoryNumber == 12544 && x.TimeGenerated > TodaysDate).Select(x => new
            {
                x.TimeGenerated
            }).First();
            lblFirstLoginTime.Text = entries.TimeGenerated.ToShortTimeString();
            TimeSpan ts = DateTime.Now.Subtract(entries.TimeGenerated);
            lblTotalTimeInOffice.Text = "Your total time spent in office until now = " + ts.Hours.ToString() + ":" + ts.Minutes.ToString();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Form1 frmDetails = new Form1();
            frmDetails.Show();
        }
    }
}
