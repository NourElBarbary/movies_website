using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace SWE_Project
{
    public partial class Report : Form
    {
        grouped_sum r;
        paramterized_formula p;
        string user_name;
        public Report(string user)
        {
            InitializeComponent();
            user_name = user;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            r = new grouped_sum();
            r.SetDatabaseLogon("hr", "hr");
            r.Refresh();
            crystalReportViewer1.ReportSource = r;
            Grouped_summ_pl.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p = new paramterized_formula();
            foreach(ParameterDiscreteValue v in p.ParameterFields[0].DefaultValues)
            {
                Film_categories.Items.Add(v.Value);
            }
            Parameter_pl.BringToFront();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.SetDatabaseLogon("hr", "hr");
            p.Refresh();
            p.SetParameterValue(0, Film_categories.Text);

            crystalReportViewer2.ReportSource = p;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var x = new dashboard(user_name);
            x.Show();
            this.Close();

        }
    }
}
