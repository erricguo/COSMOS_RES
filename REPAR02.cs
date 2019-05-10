using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace COSMOS_RES
{
    public partial class REPAR02 : DevExpress.XtraReports.UI.XtraReport
    {
        public REPAR02()
        {
            InitializeComponent();
        }
        public string SetFilter
        {
            set
            {
                this.FilterString = value;
            }
        }
        public string SetDate
        {
            set
            {
                //DateTime dt = DateTime.ParseExact(value, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                lb10.Text = value; //dt.ToString("yyyy/MM/dd");
            }
        }

        private void lb04_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lb04.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

    }
}
