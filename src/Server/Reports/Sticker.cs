using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ErpDashboard.Server.Reports
{
    public partial class Sticker : DevExpress.XtraReports.UI.XtraReport
    {
        public Sticker()
        {
            InitializeComponent();
        }

        private void Sticker_ParametersRequestValueChanged(object sender, DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs e)
        {
            xrLabel1.Text = "Parameter Changed The Text";
        }

        private void Sticker_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            xrLabel1.Text = "Parameter Changed The Text";
        }

        private void Sticker_AfterPrint(object sender, EventArgs e)
        {
            xrLabel1.Text = "Parameter Changed The Text";
        }
    }
}
