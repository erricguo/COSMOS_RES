using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COSMOS_RES.DataSet;

namespace COSMOS_RES
{
    public partial class RESAQ01 : COSMOS_RES.SingleForm
    {
        public RESAQ01()
        {
            InitializeComponent();
        }

        private void RESAQ01_Load(object sender, EventArgs e)
        {
            InitUIVar();
        }

        public override void InitUIVar()
        {
            f2 = new F2Window(this);
            GC_Main.DataSource = qUEXABindingSource;
            MainControls.Add(XA001);
            MainControls.Add(XA002);
            MainControls.Add(XA003);
            MainControls.Add(XA006);
            MainControls.Add(XA004);
            MainControls.Add(XA005);

            KeyFieldMain = "XA001,XA002";
            RequiredFieldMain = "XA003,XA004";
            OrderFieldMain = "XA001,XA002";
            CheckFieldMain.Fields = "XA006";

            DateFieldMain.Fields = "XA003";

            VisibleListMain.Add("XA001", 0);
            VisibleListMain.Add("XA001C", 1);
            VisibleListMain.Add("XA002", 2);
            VisibleListMain.Add("XA003", 3);
            VisibleListMain.Add("XA006", 4);
            VisibleListMain.Add("XA004", 5);
            VisibleListMain.Add("XA005", 6);


            DS_RESAQ01.QUEXADataTable dataTable = qUEXATableAdapter.GetDataBy("");
            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Columns.Count - 1; i++)
                {
                    if (!dataTable.Columns[i].ColumnName.StartsWith("X"))
                    {
                        continue;
                    }
                    SchemaList.Add(dataTable.Columns[i].ColumnName + " " + dataTable.Columns[i].Caption);
                }
            }

            XA001C.Text = "";
            base.InitUIVar();
        }

        public override void DBFillBy(BaseForm.GCNum xNum, string xStr)
        {
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    qUEXATableAdapter.FillBy(dS_RESAQ01.QUEXA, xStr);
                    break;
            }
            base.DBFillBy(xNum, xStr);
        }

        public override bool DBUpdate(BaseForm.GCNum xNum)
        {
            try
            {
                switch (xNum)
                {
                    case GCNum.GCN_Main:
                        qUEXABindingSource.EndEdit();
                        qUEXATableAdapter.Update(dS_RESAQ01.QUEXA);
                        break;
                }
                if (base.DBUpdate(xNum))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                fc.ErrorLog(ex.Message);
                return false;
            }
        }

        private void XA001_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != BaseForm.GridStatu.gsBrowse)
            {
                f2.SetMI = new string[] { "QUEXA", "001" };
                if (f2.GetMI)
                {
                    XA001.Text = f2.GetReturn[0];
                    XA001C.Text = f2.GetReturn[1];

                    if (GetGridStatu() == GridStatu.gsAdd)
                    {
                        string mXA002 = "";
                        DateTime dt = DateTime.ParseExact(XA003.Text, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                        string mXA003 = dt.ToString("yyyyMMdd");
                        using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("SELECT MAX(XA002) AS XA002 FROM QUEXA WHERE XA001 = '" + XA001.Text + "' AND XA003 = '" + mXA003 + "' ", conn))
                            {
                                using (SqlDataReader dr = cmd.ExecuteReader())
                                {
                                    if (dr.Read())
                                    {
                                        mXA002 = dr["XA002"].ToString();
                                    }
                                }
                            }
                        }

                        if (mXA002 != "")
                        {
                            XA002.Text = DateTime.Now.ToString("yyyyMMdd") +
                            fc.ZeroatFirst((Int32.Parse(mXA002.Substring(9, mXA002.Length - 9)) + 1), 3);
                        }
                        else
                            XA002.Text = DateTime.Now.ToString("yyyyMMdd") +"001";

                        }
                    }  
            }
        }
        public override void BtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnNew_ItemClick(sender, e);
            if (GetGridStatu() == GridStatu.gsAdd)
            {
                XA003.Text = DateTime.Now.ToString("yyyy/MM/dd");
                XA006.Enabled = false;
            } 
        }

        public override void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GetGridStatu() == GridStatu.gsAdd)
            {
                DateTime dt = DateTime.ParseExact(XA003.Text, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);
                string mXA003 = dt.ToString("yyyyMMdd");
                string mNo = XA002.Text;
                string mSQL = "SELECT XA002 FROM QUEXA WHERE XA001 = '" + XA001.Text + "' AND XA002 = '"+ mNo +"' AND XA003 = '" + mXA003 + "' ";
                while (!ValidMaxNo(mSQL))
                {
                    mNo = fc.ZeroatFirst((Int32.Parse(mNo.Substring(9, mNo.Length - 9)) + 1), 4); 
                    mSQL = "SELECT XA002 FROM QUEXA WHERE XA001 = '" + XA001.Text + "' AND XA002 = '" + mNo + "' AND XA003 = '" + mXA003 + "' ";
                }
                XA002.Text = mNo;
            }
            base.BtnSave_ItemClick(sender, e);

        }
    }
}
