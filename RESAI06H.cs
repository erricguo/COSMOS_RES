using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COSMOS_RES
{
    public partial class RESAI06H : COSMOS_RES.RootForm
    {
        string mXQ001 = "";
        public RESAI06H()
        {
            InitializeComponent();
        }

        public string SetXQ001
        {
            set
            {
                mXQ001 = value;
            }
        }

        private void RESAI06H_Load(object sender, EventArgs e)
        {
            pOSXQTableAdapter.Fill(dS_RESAI06.POSXQ, mXQ001);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            /*if (GV_Main.RowCount <= 0 )
            {
                return;
            }*/
            GV_Main.ActiveFilterEnabled = false;
            GV_Main.ActiveFilterString = "[XG002] = 'Y'";
            GV_Main.ActiveFilterEnabled = true;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            GV_Main.ActiveFilterEnabled = false;
            GV_Main.ActiveFilterString = "[XG002] = 'N'";
            GV_Main.ActiveFilterEnabled = true;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            GV_Main.ActiveFilterEnabled = false;
            GV_Main.ActiveFilterString = "";
            GV_Main.ActiveFilterEnabled = true;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            GV_Main.ActiveFilterEnabled = false;
            GV_Main.ActiveFilterString = "[XG007] = 'Y'";
            GV_Main.ActiveFilterEnabled = true;
        }

        private void btnUnPay_Click(object sender, EventArgs e)
        {
            GV_Main.ActiveFilterEnabled = false;
            GV_Main.ActiveFilterString = "[XG007] = 'N' and [XG002] = 'Y'";
            GV_Main.ActiveFilterEnabled = true;
        }

        private void btnEXChange_Click(object sender, EventArgs e)
        {
            GV_Main.ActiveFilterEnabled = false;
            GV_Main.ActiveFilterString = "[XG008] > 0";
            GV_Main.ActiveFilterEnabled = true;
        }

    }
}
