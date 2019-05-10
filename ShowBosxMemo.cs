using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COSMOS_RES
{
    public partial class ShowBosxMemo : COSMOS_RES.RootForm
    {
        string FReturn = "";
        public ShowBosxMemo()
        {
            InitializeComponent();
        }

        public string SetMemo
        {
            set
            {
                memo01.Text = value;
                FReturn = value;
            }
        }
        public bool SetCanEdit
        {
            set
            {               
                memo01.Properties.ReadOnly = !value;
                if (value)
                {
                    btnOK.Visible = true;
                    btnCancel.Visible = true;
                    btnEXIT.Visible = false;
                }                
            }
        }
        public string GetReturn
        {
            get
            {
                return FReturn;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FReturn = memo01.Text;
        }
    }
}
