using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COSMOS_RES.DataSet;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace COSMOS_RES
{
    public partial class RESAI06 : COSMOS_RES.BaseForm
    {
        public RESAI06()
        {
            InitializeComponent();
        }

        private void RESAI06_Load(object sender, EventArgs e)
        {
            InitUIVar();
        }

        public override void InitUIVar()
        {
            TabControlMainHeight = 230;
            IsCanNew = false;
            IsCanDel = false;
            GC_Main.DataSource = pOSXCBindingSource;
            GC_Body.DataSource = pOSXGBindingSource;
            MainControls.Add(XC001);
            /*MainControls.Add(XF008);
            MainControls.Add(XF002);
            MainControls.Add(XF003);
            MainControls.Add(XF004);
            MainControls.Add(XF008);*/

            KeyFieldMain = "XC001";
            KeyFieldBody = "XG001,XG002";
            VisibleFieldMain = "XC005";
            VisibleFieldBody = "XG001,XB006,XB007,XB007C,XG006,XG010";
            OrderFieldMain = "XC001";
            OrderFieldBody = "XG006,XG002";
            ReadOnlyFieldBody = "XG002,XG002C,XB004,XG003,XG004,XG006,XG006C,XG005";

            DateFieldMain.Fields = "XC002,XC008";              
            TimeFieldMain.Fields = "XC003,XC007";
            NumberFieldBody.Fields = "XG004";
            NumberFieldBody.NumFields.Add("XB004", "n1");
            CheckFieldBody.Fields = "XG007";

            ButtonFieldListBody.Add(new ButtonFieldFormat(GCNum.GCN_Body, "", "XG008", this.XG008ButtonEdit_ButtonClick));   

            VisibleListMain.Add("XC001" , 0);
            VisibleListMain.Add("XC009" , 1);
            VisibleListMain.Add("XC004" , 2);
            VisibleListMain.Add("XC004C", 3);
            VisibleListMain.Add("XC002" , 4);
            VisibleListMain.Add("XC003" , 5);
            VisibleListMain.Add("XC006" , 6);
            VisibleListMain.Add("XC006C", 7);
            VisibleListMain.Add("XC008" , 8);

            VisibleListBody.Add("XG007" , 0); 
            VisibleListBody.Add("XG008" , 1);
            VisibleListBody.Add("XG002" , 2);
            VisibleListBody.Add("XG002C", 3);
            VisibleListBody.Add("XB004" , 4);
            VisibleListBody.Add("XG003" , 5);
            VisibleListBody.Add("XG004" , 6);
            VisibleListBody.Add("XG006" , 7);
            VisibleListBody.Add("XG006C", 8);
            VisibleListBody.Add("XG009", 9);
            VisibleListBody.Add("XG005" , 10);

            FieldWidthMain.Add("XC001", 117);
            FieldWidthMain.Add("XC002", 93);
            FieldWidthMain.Add("XC003", 86);
            FieldWidthMain.Add("XC004", 86);
            FieldWidthMain.Add("XC005", 75);
            FieldWidthMain.Add("XC006", 70);
            FieldWidthMain.Add("XC007", 86);
            FieldWidthMain.Add("XC008", 93);
            FieldWidthMain.Add("XC009", 86);
            FieldWidthMain.Add("XC010", 605);
            FieldWidthMain.Add("XC004C", 171);
            FieldWidthMain.Add("XC006C", 102);

            FieldWidthBody.Add("XG001", 75);
            FieldWidthBody.Add("XG002", 86);
            FieldWidthBody.Add("XG003", 75);
            FieldWidthBody.Add("XG004", 75);
            FieldWidthBody.Add("XG005", 437);
            FieldWidthBody.Add("XG006", 81);
            FieldWidthBody.Add("XG007", 75);
            FieldWidthBody.Add("XG008", 75);
            FieldWidthBody.Add("XG002C", 202);
            FieldWidthBody.Add("XB004", 75);
            FieldWidthBody.Add("XB006", 75);
            FieldWidthBody.Add("XB007", 75);
            FieldWidthBody.Add("XB007C", 75);
            FieldWidthBody.Add("XG006C", 75);
            FieldWidthBody.Add("XG009", 426);
            FieldWidthBody.Add("XG010", 75);


            SetGroupSum("XG003","XG004");

            DS_RESAI06.POSXCDataTable dataTable = pOSXCTableAdapter.GetDataBy("");
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

            SelectKeyMain = "XC001";
            SelectKeyBody = "XF008";

            XC004C.Text = "";
            XC006C.Text = "";

            XC009.Properties.DisplayMember = "Text";
            XC009.Properties.ValueMember = "Value";

            var items = new[] { 
            new { Text = "1.早餐",   Value = "1" }, 
            new { Text = "2.午餐",   Value = "2" }, 
            new { Text = "3.下午茶", Value = "3" },
            new { Text = "4.晚餐",   Value = "4" }};

            XC009.Properties.DataSource = items;
            GV_Body.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
            base.InitUIVar();
        }

        private void XG008ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }
        public override void DBFillBy(BaseForm.GCNum xNum, string xStr)
        {
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    pOSXCTableAdapter.FillBy(dS_RESAI06.POSXC, xStr);                 
                    break;
                case GCNum.GCN_Body:
                    pOSXGTableAdapter.FillBy(dS_RESAI06.POSXG, xStr);
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
                        pOSXCBindingSource.EndEdit();
                        //pOSXFTableAdapter.Update(dS_RESAI06.POSXF);
                        break;
                    case GCNum.GCN_Body:
                        pOSXGBindingSource.EndEdit();
                        pOSXGTableAdapter.Update(dS_RESAI06.POSXG);
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

        public override void GV_Main_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            base.GV_Main_FocusedRowChanged(sender, e);
            CheckMoney();
        }
        public override void GV_Body_KeyDown(object sender, KeyEventArgs e)
        {
            base.GV_Body_KeyDown(sender, e);
            GV_Body.PostEditor();
        }
        public override void BtnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnCancel_ItemClick(sender, e);
            XC004C.Text = "";
            XC006C.Text = "";
        }

        protected override void BtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mXC001 = "";
            using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MAX(XC001)XC001 FROM POSXC ", conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            mXC001 = dr["XC001"].ToString();
                        }
                    }
                }
            }
            DefaultQueryStr = " XC001 = '" + mXC001 + "'";
            GV_Body.Columns["XG006C"].GroupIndex = 0;
            
            base.BtnQuery_ItemClick(sender, e);
            CheckMoney();
        }

        public override void BtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XC006.Text == fc.FUser.ID)
            {
                if (GetGridStatu() == GridStatu.gsBrowse && FReFreshStr != "")
                {
                    DBFillBy(GCNum.GCN_Body, FReFreshStr);
                }
                base.BtnEdit_ItemClick(sender, e);
            }
            else
            {
                MessageBox.Show("只有此筆訂餐的負責人才可以修改!!", "錯誤");
            }
        }

        public override void GC_Body_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo hitInfo = GV_Body.CalcHitInfo(e.Location);
            if (hitInfo == null || hitInfo.Column == null)
            {
                return;
            }
            if (GetGridStatu() == GridStatu.gsEdit)
            {
                if (hitInfo.InRowCell)
                {
                    if (hitInfo.Column.RealColumnEdit is RepositoryItemCheckEdit)
                    {
                        GV_Body.FocusedColumn = hitInfo.Column;
                        GV_Body.FocusedRowHandle = hitInfo.RowHandle;
                        GV_Body.ShowEditor();
                        CheckEdit edit = GV_Body.ActiveEditor as CheckEdit;
                        if (edit == null) return;
                        edit.Toggle();
                        DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                        GV_Body.CloseEditor();
                    }
                }
            }
        }
        public override void GV_Body_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GV_Body_CellValueChanged(sender, e);
            CheckMoney();
        }
        private void CheckMoney()
        {
            if (rg01.SelectedIndex == 0)
            {
                GV_Body.ActiveFilterEnabled = false;
                GV_Body.ActiveFilterString = "[XG007] = 'N'";
                GV_Body.ActiveFilterEnabled = true;
            }
            else if (rg01.SelectedIndex == 1)
            {
                GV_Body.ActiveFilterEnabled = false;
                GV_Body.ActiveFilterString = "[XG008] > 0";
                GV_Body.ActiveFilterEnabled = true;
            }
            else if (rg01.SelectedIndex == 2)
            {
                GV_Body.ActiveFilterEnabled = false;
                GV_Body.ActiveFilterString = "";
                GV_Body.ActiveFilterEnabled = true;
            } 
            float mSale = 0;
            float mSale2 = 0;
            float mSale3 = 0;
            for (int i = 0; i < GV_Body.RowCount; i++)
            {
                if (GV_Body.GetRowCellValue(i, "XG004") != null)
                {
                    mSale += float.Parse(GV_Body.GetRowCellValue(i, "XG004").ToString());
                    if (GV_Body.GetRowCellValue(i, "XG007").ToString() == "Y")
                    {
                        mSale2 += float.Parse(GV_Body.GetRowCellValue(i, "XG004").ToString());
                    }
                    else if (GV_Body.GetRowCellValue(i, "XG007").ToString() == "N")
                    {
                        mSale3 += float.Parse(GV_Body.GetRowCellValue(i, "XG004").ToString());
                    }
                }
            }
            edMoney1.Text = mSale.ToString();
            edMoney2.Text = mSale2.ToString();
            //edMoney3.Text = (mSale - mSale2).ToString();
            edMoney3.Text = mSale3.ToString();
        }

        private void btnCheckLost_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RESAI06H ai06h = new RESAI06H();
            ai06h.SetXQ001 = XC001.Text;
            ai06h.ShowDialog();
        }

        private void tmRefresh_Tick(object sender, EventArgs e)
        {
            if (GetGridStatu() == GridStatu.gsBrowse && FReFreshStr != "")
            {
                DBFillBy(GCNum.GCN_Body, FReFreshStr);
                CheckMoney();
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GetGridStatu() == GridStatu.gsBrowse && FReFreshStr != "")
            {
                DBFillBy(GCNum.GCN_Body, FReFreshStr);
                CheckMoney();
            }
        }

        private void chkIsPay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rg01_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckMoney();
            /*if (rg01.SelectedIndex == 0)
            {
                GV_Body.ActiveFilterEnabled = false;
                GV_Body.ActiveFilterString = "[XG007] = 'N'";
                GV_Body.ActiveFilterEnabled = true;
            }
            else if (rg01.SelectedIndex == 1)
            {
                GV_Body.ActiveFilterEnabled = false;
                GV_Body.ActiveFilterString = "[XG008] > 0";
                GV_Body.ActiveFilterEnabled = true;
            }
            else if (rg01.SelectedIndex == 2)
            {
                GV_Body.ActiveFilterEnabled = false;
                GV_Body.ActiveFilterString = "";
                GV_Body.ActiveFilterEnabled = true;
            } */
            
        }

        private void RESAI06_Shown(object sender, EventArgs e)
        {
            rg01.SelectedIndex = 2;
            rg01.SelectedIndex = 0;
        }

    }
}
