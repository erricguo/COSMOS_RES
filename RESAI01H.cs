using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace COSMOS_RES
{
    public partial class RESAI01H : COSMOS_RES.RootForm
    {
        int Fwidth = 0;
        int FHeight = 0;
        public RESAI01H()
        {
            InitializeComponent();
        }

        public int SetWidth
        {
            set
            {
                Fwidth = value;
            }
        }

        public int SetHeight
        {
            set
            {
                FHeight = value;
            }
        }

        public Image SetImg
        {
            set
            {
                pictureEdit1.Image = value;
            }
        }

        private void RESAI01H_Shown(object sender, EventArgs e)
        {
            this.Width = Fwidth;
            this.Height = FHeight;
        }
    }
}
