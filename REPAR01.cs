using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace COSMOS_RES
{
    public partial class REPAR01 : DevExpress.XtraReports.UI.XtraReport
    {
        public REPAR01()
        {
            InitializeComponent();
        }
        public string[] SetParameter
        {
            set
            {
                string mXF003 = value[0];
                string mXF008 = value[1];
                this.Parameters["XF003P"].Value = mXF003;
                this.Parameters["XF008P"].Value = mXF008;
                /*DateTime dt = DateTime.ParseExact(mXF003, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                lb10.Text = dt.ToString("yyyy/MM/dd");*/
            }
        }

        private void lb06_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (((XRLabel)sender).Text != "")
            {
                DateTime dt = DateTime.ParseExact(((XRLabel)sender).Text, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                ((XRLabel)sender).Text = dt.ToString("yyyy/MM/dd");
            }
        }

        private void lb04_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ((XRLabel)sender).Text = DateTime.Now.ToShortDateString();
        }

    }
}
