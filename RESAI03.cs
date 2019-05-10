using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COSMOS_RES.DataSet;
using DevExpress.XtraEditors.Repository;

namespace COSMOS_RES
{
    public partial class RESAI03 : COSMOS_RES.SingleForm
    {
        string oldPw = "";
        public RESAI03()
        {
            InitializeComponent();
        }
        private void RESAI03_Load(object sender, EventArgs e)
        {
            InitUIVar();
        }

        public override void InitUIVar()
        {
            GC_Main.DataSource = pOSXMBindingSource;
            MainControls.Add(XM001);
            MainControls.Add(XM004);
            MainControls.Add(XM002);
            MainControls.Add(XM003);            

            VisibleFieldMain = "";
            KeyFieldMain = "XM001";
            OrderFieldMain = "XM001";
            RequiredFieldMain = "XM004,XM002,XM003";
            PassWordFieldMain.Fields = "XM003";

            VisibleListMain.Add("XM001", 0);
            VisibleListMain.Add("XM004", 1);
            VisibleListMain.Add("XM002", 2);
            VisibleListMain.Add("XM003", 3);

            FieldWidthMain.Add("XM001", 71);
            FieldWidthMain.Add("XM002", 341);
            FieldWidthMain.Add("XM003", 504);
            FieldWidthMain.Add("XM004", 87);

            DS_RESAI03.POSXMDataTable dataTable = pOSXMTableAdapter.GetDataBy("");
            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Columns.Count - 1; i++)
                {
                    if (!dataTable.Columns[i].ColumnName.StartsWith("XM"))
                    {
                        continue;
                    }
                    SchemaList.Add(dataTable.Columns[i].ColumnName + " " + dataTable.Columns[i].Caption);
                }
            }

            base.InitUIVar();
        }
        public override void DBFillBy(SingleForm.GCNum xNum, string xStr)
        {
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    pOSXMTableAdapter.FillBy(dS_RESAI03.POSXM, xStr);
                    break;
            }
            base.DBFillBy(xNum, xStr);
        }
        public override bool DBUpdate(SingleForm.GCNum xNum)
        {
            try
            {
                switch (xNum)
                {
                    case GCNum.GCN_Main:
                        pOSXMBindingSource.EndEdit();
                        pOSXMTableAdapter.Update(dS_RESAI03.POSXM);
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
        public override void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (oldPw != XM003.Text)
            {
                XM003.Text = fc.FDes.EncryptString(XM003.Text, fc.FDes.GenerateKey());                
            }
            base.BtnSave_ItemClick(sender, e);
        }
        public override void BtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fc.FUser.ID != "ERRIC")
            {
                if (XM001.Text == fc.FUser.ID)
                {
                    oldPw = XM003.Text;
                    base.BtnEdit_ItemClick(sender, e);
                }
                else
                {
                    MessageBox.Show("只允許修改自己的資料!", "提示");
                }
            }
            else
            {
                oldPw = XM003.Text;
                base.BtnEdit_ItemClick(sender, e);
            }
        }


    }
}
