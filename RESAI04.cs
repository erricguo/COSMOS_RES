using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COSMOS_RES.DataSet;
using COSMOS_RES.DataSet.DS_RESAI04TableAdapters;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Reflection;
using DevExpress.XtraEditors;

namespace COSMOS_RES
{
    public partial class RESAI04 : COSMOS_RES.BaseForm
    {
        List<string> DetailViewFields = new List<string>();
        COSMOS_RES.DataSet.DS_RESAI04.POSXKDataTable dt = null;
        List<fc.POSXKTable> FPOSXK = new List<fc.POSXKTable>();
        public RESAI04()
        {
            InitializeComponent();
        }        

        private void RESAI04_Load(object sender, EventArgs e)
        {
            InitUIVar();
            dt = dS_RESAI04.POSXK;
            pOSXKTableAdapter.Fill(dt);
            DetailViewFields.AddRange(new string[] { "XK004", "XK005", "XK006", "XK006C", "XH004" });
            GetMessage();
        }

        public class AI04Formatter : IFormatProvider, ICustomFormatter
        {
            public object GetFormat(System.Type type)
            {
                return this;
            }
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                string formatValue = arg.ToString();
                if (format == "XC009" && formatValue != "")
                {
                    if (formatValue == "1")
                        formatValue = "1:早餐";
                    else if (formatValue == "2")
                        formatValue = "2:午餐";
                    else if (formatValue == "3")
                        formatValue = "3:下午茶";
                    else if (formatValue == "4")
                        formatValue = "4:晚餐";
                    return formatValue;
                }
                else if (format == "XK005" && formatValue != "")
                {
                    if (formatValue == "1")
                        formatValue = "1.口味";
                    else if (formatValue == "2")
                        formatValue = "2.加料";
                    return formatValue;
                }
                else return formatValue;
            }
        }
        public override void InitUIVar()
        {
            f2 = new F2Window(this);
            TabControlMainHeight = 230;
            GC_Main.DataSource = pOSXFBindingSource;
            GC_Body.DataSource = pOSXGBindingSource;

            MainControls.Add(XF001);
            MainControls.Add(XF008);

            KeyFieldMain = "XF001";
            KeyFieldBody = "XG001,XG010,XG002";
            VisibleFieldMain = "XF005,XF006,XF007";
            VisibleFieldBody = "XG001,XB006,XG007,XG008";
            OrderFieldMain = "XF001";
            OrderFieldBody = "XG001,XG010,XG002";
            RequiredFieldMain = "XF008";
            RequiredFieldBody = "XG002,XG010";
            ReadOnlyFieldBody = "XB007C,XG002C,XB004,XG006C,XG004,XG010";

            DateFieldMain.Fields = "XF003,XC008";            
            TimeFieldMain.Fields = "XF004,XC007";
            NumberFieldBody.Fields = "XG004,XG006C";
            NumberFieldBody.NumFields.Add("XB004", "n1");

            SetGroupSum("XG003", "XG004");
            GV_Body.Columns["XG006C"].GroupIndex = 0;

            ButtonFieldListMain.Add(XF008);
            ButtonFieldListBody.Add(new ButtonFieldFormat(GCNum.GCN_Body, "", "XG002", this.XG002ButtonEdit_ButtonClick));
            ButtonFieldListBody.Add(new ButtonFieldFormat(GCNum.GCN_Body, "", "XB007", this.XB007ButtonEdit_ButtonClick));
            ButtonFieldListBody.Add(new ButtonFieldFormat(GCNum.GCN_Body, "", "XG006", this.XG006ButtonEdit_ButtonClick));
            ButtonFieldListBody.Add(new ButtonFieldFormat(GCNum.GCN_Body, "", "XG009", this.XG009ButtonEdit_ButtonClick));   
            
            VisibleListMain.Add("XF001", 0);
            VisibleListMain.Add("XF008", 1);
            VisibleListMain.Add("XC009", 2);
            VisibleListMain.Add("XF002", 3);
            VisibleListMain.Add("XF002C", 4);
            VisibleListMain.Add("XF003", 5);
            VisibleListMain.Add("XF004", 6);
            VisibleListMain.Add("XC006", 7);
            VisibleListMain.Add("XC006C", 8);
            VisibleListMain.Add("XC008", 9);
            VisibleListMain.Add("XC007", 10);

            VisibleListBody.Add("XG010", 0);    //序號
            VisibleListBody.Add("XB007", 1);    //菜色類別
            VisibleListBody.Add("XB007C", 2);   //類別名稱
            VisibleListBody.Add("XG002", 3);    //菜色編號
            VisibleListBody.Add("XG002C", 4);   //菜色名稱
            VisibleListBody.Add("XB004", 5);    //單價
            VisibleListBody.Add("XG003", 6);    //數量
            VisibleListBody.Add("XG004", 7);    //金額
            VisibleListBody.Add("XG006", 8);    //訂購人
            VisibleListBody.Add("XG006C", 9);   //名稱
            VisibleListBody.Add("XG009", 10);   //口味加料
            VisibleListBody.Add("XG005", 11);   //備註

            FieldWidthMain.Add("XF001", 116);
            FieldWidthMain.Add("XF002", 86);
            FieldWidthMain.Add("XF003", 98);
            FieldWidthMain.Add("XF004", 86);
            FieldWidthMain.Add("XF005", 75);
            FieldWidthMain.Add("XF006", 75);
            FieldWidthMain.Add("XF007", 75);
            FieldWidthMain.Add("XF008", 119);
            FieldWidthMain.Add("XC006", 70);
            FieldWidthMain.Add("XC007", 86);
            FieldWidthMain.Add("XC008", 93);
            FieldWidthMain.Add("XC009", 86);
            FieldWidthMain.Add("XF002C", 205);
            FieldWidthMain.Add("XC006C", 102);

            FieldWidthBody.Add("XG001", 75);
            FieldWidthBody.Add("XG002", 86);
            FieldWidthBody.Add("XG003", 54);
            FieldWidthBody.Add("XG004", 75);
            FieldWidthBody.Add("XG005", 473);
            FieldWidthBody.Add("XG006", 70);
            FieldWidthBody.Add("XB004", 75);
            FieldWidthBody.Add("XB006", 75);
            FieldWidthBody.Add("XB007", 86);
            FieldWidthBody.Add("XG002C", 172);
            FieldWidthBody.Add("XB007C", 86);
            FieldWidthBody.Add("XG007", 75);
            FieldWidthBody.Add("XG008", 75);
            FieldWidthBody.Add("XG006C", 75);
            FieldWidthBody.Add("XG009", 335);
            FieldWidthBody.Add("XG010", 87);

            DS_RESAI04.POSXFDataTable dataTable = pOSXFTableAdapter.GetDataBy("");
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

            RepositoryItemTextEdit edit = new RepositoryItemTextEdit();
            GV_Main.Columns["XC009"].ColumnEdit = edit;
            edit.DisplayFormat.FormatType = FormatType.Custom;
            edit.DisplayFormat.FormatString = "XC009";
            edit.DisplayFormat.Format = new AI04Formatter();

            //body
            RepositoryItemTextEdit mTextEdit = new RepositoryItemTextEdit();
            GV_Body.Columns["XG003"].ColumnEdit = mTextEdit;
            mTextEdit.EditValueChanging += mTextEdit_EditValueChanging;

            SelectKeyMain = "XF001";
            SelectKeyBody = "XG001";

            XF002C.Text = "";
            XC006C.Text = "";

            XC009.Properties.DisplayMember = "Text";
            XC009.Properties.ValueMember = "Value";

            var items = new[] { 
            new { Text = "1.早餐",   Value = "1" }, 
            new { Text = "2.午餐",   Value = "2" }, 
            new { Text = "3.下午茶", Value = "3" },
            new { Text = "4.晚餐",   Value = "4" }};

            XC009.Properties.DataSource = items;

            base.InitUIVar();
            GV_Body.SetMasterRowExpanded(GV_Body.FocusedRowHandle, GV_Body.GetMasterRowExpanded(GV_Body.FocusedRowHandle));
        }

        private void XG009ButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != BaseForm.GridStatu.gsBrowse)
            {
                try
                {
                    GV_Body.UpdateCurrentRow();
                    f2.SetMI = new string[] { "POSXN", "001" };
                    f2.SetMIParam = new string[] { XF002.Text, "1", GV_Body.GetFocusedRowCellValue("XB007").ToString(),
                                                                 "2", GV_Body.GetFocusedRowCellValue("XG002").ToString()};
                    f2.SetShowWindow = false;  
                    if (f2.GetMI)
                    {
                        string mXN002 = f2.GetReturn[2];
                        string mXN003 = f2.GetReturn[3];
                        double money = 0;
                        double mXB004 = 0;
                        double mQty = 0;
                        string MarkInfo = "";
                        RESAI04I ai04i = new RESAI04I();
                        string mXG001 = GV_Body.GetFocusedRowCellValue("XG001").ToString();
                        string mXG010 = GV_Body.GetFocusedRowCellValue("XG010").ToString();
                        string mXG002 = GV_Body.GetFocusedRowCellValue("XG002").ToString();
                        ai04i.DefaultData = new List<string>() { mXG001, mXG010, mXG002, XF002.Text, mXN002, mXN003 };
                        DataTable dtPOSXK = new DataTable("POSXK");
                        GridView gridViewTests = null;
                        float mXH004 = 0;
                        for (int i = 0; i < dS_RESAI04.POSXK.Columns.Count; i++)
                        {
                            dtPOSXK.Columns.Add(dS_RESAI04.POSXK.Columns[i].ColumnName, dS_RESAI04.POSXK.Columns[i].DataType);
                        }
                        //if (!GV_Body.IsMasterRowEmpty(GV_Body.FocusedRowHandle))
                        {
                            GV_Body.SetMasterRowExpanded(GV_Body.FocusedRowHandle, true);
                            gridViewTests = GV_Body.GetDetailView(GV_Body.FocusedRowHandle, 0) as GridView;
                            if (gridViewTests != null)
                            {
                                for (int i = 0; i < gridViewTests.RowCount; i++)
                                {

                                    int idx = gridViewTests.GetRowHandle(i);
                                    float.TryParse(gridViewTests.GetRowCellValue(idx, "XH004").ToString(), out mXH004);
                                    dtPOSXK.Rows.Add(new object[] 
                                { "", "", "", "", "", "", 0, "", "", "", "", //});
                                gridViewTests.GetRowCellValue(idx, "XK001").ToString(),
                                gridViewTests.GetRowCellValue(idx, "XK002").ToString(),
                                gridViewTests.GetRowCellValue(idx, "XK003").ToString(),
                                gridViewTests.GetRowCellValue(idx, "XK004").ToString(),
                                gridViewTests.GetRowCellValue(idx, "XK005").ToString(),
                                gridViewTests.GetRowCellValue(idx, "XK006").ToString(),
                                gridViewTests.GetRowCellValue(idx, "XK006C").ToString(),
                                mXH004});
                                }
                            }
                        }
                        ai04i.SetPOSXK = dtPOSXK;
                        if (ai04i.ShowDialog() == DialogResult.OK)
                        {
                            dtPOSXK = ai04i.SetPOSXK;

                            while (gridViewTests.RowCount != 0)
                            {
                                gridViewTests.SelectAll();
                                gridViewTests.DeleteSelectedRows();
                            }
                            for (int i = 0; i < dtPOSXK.Rows.Count; i++)
                            {
                                gridViewTests.BeginUpdate();
                                gridViewTests.AddNewRow();
                                gridViewTests.SetFocusedRowCellValue("COMPANY", dtPOSXK.Rows[i]["COMPANY"]);
                                gridViewTests.SetFocusedRowCellValue("CREATOR", dtPOSXK.Rows[i]["CREATOR"]);
                                gridViewTests.SetFocusedRowCellValue("USR_GROUP", dtPOSXK.Rows[i]["USR_GROUP"]);
                                gridViewTests.SetFocusedRowCellValue("CREATE_DATE", dtPOSXK.Rows[i]["CREATE_DATE"]);
                                gridViewTests.SetFocusedRowCellValue("MODIFIER", dtPOSXK.Rows[i]["MODIFIER"]);
                                gridViewTests.SetFocusedRowCellValue("MODI_DATE", dtPOSXK.Rows[i]["MODI_DATE"]);
                                gridViewTests.SetFocusedRowCellValue("FLAG", dtPOSXK.Rows[i]["FLAG"]);
                                gridViewTests.SetFocusedRowCellValue("CREATE_TIME", dtPOSXK.Rows[i]["CREATE_TIME"]);
                                gridViewTests.SetFocusedRowCellValue("MODI_TIME", dtPOSXK.Rows[i]["MODI_TIME"]);
                                gridViewTests.SetFocusedRowCellValue("TRANS_TYPE", dtPOSXK.Rows[i]["TRANS_TYPE"]);
                                gridViewTests.SetFocusedRowCellValue("TRANS_NAME", dtPOSXK.Rows[i]["TRANS_NAME"]);
                                gridViewTests.SetFocusedRowCellValue("XK001", dtPOSXK.Rows[i]["XK001"]);
                                gridViewTests.SetFocusedRowCellValue("XK002", dtPOSXK.Rows[i]["XK002"]);
                                gridViewTests.SetFocusedRowCellValue("XK003", dtPOSXK.Rows[i]["XK003"]);
                                gridViewTests.SetFocusedRowCellValue("XK004", dtPOSXK.Rows[i]["XK004"]);
                                gridViewTests.SetFocusedRowCellValue("XK005", dtPOSXK.Rows[i]["XK005"]);
                                gridViewTests.SetFocusedRowCellValue("XK006", dtPOSXK.Rows[i]["XK006"]);
                                gridViewTests.SetFocusedRowCellValue("XK006C", dtPOSXK.Rows[i]["XK006C"]);
                                gridViewTests.SetFocusedRowCellValue("XH004", dtPOSXK.Rows[i]["XH004"]);
                                money += float.Parse(dtPOSXK.Rows[i]["XH004"].ToString());
                                MarkInfo += dtPOSXK.Rows[i]["XK006C"].ToString() + ",";
                                gridViewTests.EndUpdate();
                                gridViewTests.UpdateCurrentRow();
                            }
                            mXB004 = float.Parse(GV_Body.GetFocusedRowCellValue("XB004").ToString());
                            mQty = float.Parse(GV_Body.GetFocusedRowCellValue("XG003").ToString()); ;
                            money += mXB004;
                            GV_Body.SetFocusedRowCellValue("XG004", money * mQty);
                            GV_Body.SetFocusedRowCellValue("XG009", MarkInfo);
                            GV_Body.UpdateCurrentRow();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    fc.ErrorLog(ex.Message);
                }
            }
        }

        void mTextEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (GetGridStatu() != BaseForm.GridStatu.gsBrowse)
            {
                float mPrice = 0;
                float mCount = 0;
                float mSale = 0;
                mPrice = float.Parse(GV_Body.GetFocusedRowCellValue("XB004").ToString());
                mCount = float.Parse(e.NewValue.ToString());
                mSale = mPrice * mCount;
                GV_Body.SetFocusedRowCellValue("XG004", mSale);
            }
        }

        private void XG006ButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (GetGridStatu() == BaseForm.GridStatu.gsBrowse) return;
            f2.SetMI = new string[] { "POSXC", "002" };
            if (f2.GetMI)
            {
                GV_Body.SetRowCellValue(FocuseRow_Body, "XG006", f2.GetReturn[0]);
                GV_Body.SetRowCellValue(FocuseRow_Body, "XG006C", f2.GetReturn[1]);
            }
        }

        private void XB007ButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (GetGridStatu() == BaseForm.GridStatu.gsBrowse) return;
            f2.SetMI = new string[] { "POSXG", "001" };
            f2.SetMIParam = new string[] { XF002.Text };
            if (f2.GetMI)
            {
                GV_Body.SetRowCellValue(FocuseRow_Body, "XB007", f2.GetReturn[0]);
                GV_Body.SetRowCellValue(FocuseRow_Body, "XB007C", f2.GetReturn[1]);
                GV_Body.FocusedColumn = GV_Body.VisibleColumns[2];//菜單編號
                GV_Body.ShowEditor();
            }
        }

        private void XG002ButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != BaseForm.GridStatu.gsBrowse)
            {
                string mXB007 = GV_Body.GetRowCellValue(FocuseRow_Body, "XB007").ToString();
                f2.SetMI = new string[] { "POSXG", "002" };
                f2.SetMIParam = new string[] { XF002.Text, mXB007 };
                if (f2.GetMI)
                {
                    GV_Body.SetRowCellValue(FocuseRow_Body, "XG002", f2.GetReturn[0]);
                    GV_Body.SetRowCellValue(FocuseRow_Body, "XG002C", f2.GetReturn[1]);
                    GV_Body.SetRowCellValue(FocuseRow_Body, "XB004", f2.GetReturn[2]);
                    float mPrice = float.Parse(f2.GetReturn[2]);
                    float mQty = float.Parse(GV_Body.GetRowCellValue(FocuseRow_Body,"XG003").ToString());
                    GV_Body.SetRowCellValue(FocuseRow_Body,"XG004", mPrice * mQty);
                    GV_Body.FocusedColumn = GV_Body.VisibleColumns[9];//數量
                    GV_Body.ShowEditor();
                }
            }    
        }
        public override void DBFillBy(BaseForm.GCNum xNum, string xStr)
        {            
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    pOSXFTableAdapter.FillBy(dS_RESAI04.POSXF, xStr);
                    break;
                case GCNum.GCN_Body:
                    pOSXGTableAdapter.FillBy(dS_RESAI04.POSXG, xStr);
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
                        pOSXFBindingSource.EndEdit();
                        pOSXFTableAdapter.Update(dS_RESAI04.POSXF);
                        break;
                    case GCNum.GCN_Body:
                        pOSXGBindingSource.EndEdit();
                        pOSXGTableAdapter.Update(dS_RESAI04.POSXG);
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

        private void XF008_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != BaseForm.GridStatu.gsBrowse)
            {
                f2.SetMI = new string[] { "POSXC", "004" };
                f2.SetMIParam = new string[] { XF003.EditValue.ToString(), XF004.EditValue.ToString() };
                if (f2.GetMI)
                {
                    //XF001.Text = f2.GetReturn[0];
                    XF002.Text = f2.GetReturn[2];
                    XF002C.Text = f2.GetReturn[3];
                    XF008.Text = f2.GetReturn[1];
                    XC006.Text = f2.GetReturn[4];
                    XC006C.Text = f2.GetReturn[5];
                    XC007.Text = f2.GetReturn[7];
                    XC008.Text = f2.GetReturn[6];
                    XC009.Text = f2.GetReturn[8]; 
                }              
            }     
        }

        public override void BtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnNew_ItemClick(sender, e);
            XF001.Properties.ReadOnly = true;
            XF002C.Text = "";
            if (GetGridStatu() == GridStatu.gsAdd)
            {
                string mXF003 = DateTime.Now.ToString("yyyyMMdd");
                string mXF004 = DateTime.Now.ToString("HHmm");
                /*string SQL = " SELECT CASE WHEN XF001 IS NULL THEN 'O'+'" + mXF003 + "'+'01' " +
                              " ELSE 'O'+'" + mXF003 + "'+ RIGHT(REPLICATE('0', 2) + CAST(COUNT(XF001)+1 as NVARCHAR), 2) END  XF001, " +
                              " XC003,XC001,XC004,XA003,XC006,XC007,XC008,XC009,XM004 XC006C FROM POSXC " +
                              " LEFT JOIN POSXF ON XC001=XF008 " +
                              " LEFT JOIN (SELECT XA001,XA003 FROM POSXA) B ON XA001=XC004 " +
                              " LEFT JOIN (SELECT XM001,XM004 FROM POSXM) C ON XM001=XC006 " +
                              " WHERE '" + mXF003 + "' BETWEEN XC002 AND XC008 AND '" + mXF004 + "' BETWEEN XC003 AND XC007 " +
                              " GROUP BY XF001,XC003,XC001,XC004,XA003,XC006,XC007,XC008,XC009,XM004 " +
                              " ORDER BY XC001 DESC";*/
                string SQL =  //" SELECT 'O'+'" + mXF003 + "'+ RIGHT(REPLICATE('0', 2) + CAST(COUNT(XF001)+1 as NVARCHAR), 2) XF001, " +
                              " SELECT 'O'+'" + mXF003 + "'+ RIGHT(REPLICATE('0', 2) + CAST(CAST(RIGHT(ISNULL(MAX(XF001),0),2) AS NUMERIC)+1 as NVARCHAR),2) XF001," +
                              " XC003,XC001,XC004,XA003,XC006,XC007,XC008,XC009,XM004 XC006C FROM POSXC " +
                              //" LEFT JOIN POSXF ON XC001=XF008 " +
                              " LEFT JOIN POSXF ON XC002=XF003 " +
                              " LEFT JOIN (SELECT XA001,XA003 FROM POSXA) B ON XA001=XC004 " +
                              " LEFT JOIN (SELECT XM001,XM004 FROM POSXM) C ON XM001=XC006 " +
                              " WHERE '" + mXF003 + "' BETWEEN XC002 AND XC008 AND '" + mXF004 + "' BETWEEN XC003 AND XC007 " +
                              " GROUP BY XC003,XC001,XC004,XA003,XC006,XC007,XC008,XC009,XM004 " +
                              " ORDER BY XC001 DESC";
                using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(SQL, conn))
                    {
                        using (SqlDataAdapter sqldataadpt = new SqlDataAdapter(cmd))
                        {                             
                            DataTable dt = new DataTable();
                            sqldataadpt.Fill(dt);
                            if(dt.Rows.Count > 0)
                            {
                                XF001.Text = dt.Rows[0]["XF001"].ToString();
                                XF002.Text = dt.Rows[0]["XC004"].ToString();
                                XF002C.Text = dt.Rows[0]["XA003"].ToString();
                                XF008.Text = dt.Rows[0]["XC001"].ToString();
                                XC006.Text = dt.Rows[0]["XC006"].ToString();
                                XC006C.Text = dt.Rows[0]["XC006C"].ToString();
                                XC007.Text = dt.Rows[0]["XC007"].ToString();
                                XC008.Text = dt.Rows[0]["XC008"].ToString();
                                XC009.EditValue = dt.Rows[0]["XC009"].ToString();

                                XF003.Text = mXF003;
                                XF004.Text = mXF004;
                            }
                        }
                    }
                }
            }
        }
        public override void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GetGridStatu() == GridStatu.gsAdd)
            {
                
                int mRow = 0;
                string mNo = XF001.Text;
                string mSQL = "SELECT XF001 FROM POSXC LEFT JOIN POSXF ON XC001=XF008 WHERE XF001='" + mNo + "'";
                while (!ValidMaxNo(mSQL))
                {

                    mNo = mNo.Substring(0, 9) + fc.ZeroatFirst((Int32.Parse(mNo.Substring(9, mNo.Length - 9)) + 1), 2);
                    mSQL = "SELECT XF001 FROM POSXC LEFT JOIN POSXF ON XC001=XF008 WHERE XF001='" + mNo + "'";
                }
                XF001.Text = mNo;
                //單身
                for (int i = 0; i < GV_Body.RowCount; i++)
                {
                    mRow = GV_Body.GetRowHandle(i);
                    GV_Body.SetRowCellValue(mRow, "XG001", XF001.Text);

                    //口味加料子單身
                    GV_Body.SetMasterRowExpanded(mRow, true);
                    GridView gridViewTests = GV_Body.GetDetailView(mRow, 0) as GridView;
                    if (gridViewTests != null)
                    {
                        for (int j = 0; j < gridViewTests.Columns.Count; j++)
                        {
                            gridViewTests.SetRowCellValue(mRow, "XK001", XF001.Text);
                        }
                    }
                }
            }
            base.BtnSave_ItemClick(sender, e);
        }

        public override void F2FieldMain_KeyDown(object sender, KeyEventArgs e)
        {
            base.F2FieldMain_KeyDown(sender, e);
        }

        private void btnOrderList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XF008.Text != "" && XF002.Text != "")
            {
                RESAI04H ai04h = new RESAI04H();
                bool CanSelect = false;
                if (GetGridStatu() != GridStatu.gsBrowse) CanSelect = true;
                ai04h.SetKey = new string[] { XF008.Text, XF002.Text };
                ai04h.SetCanSelect = CanSelect;
                if (ai04h.ShowDialog() == DialogResult.OK && CanSelect)
                {
                    GetSPValue(ai04h.GetReturn);
                }
            }
        }

       /* public override void GV_Body_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            if (GV_Body.FocusedRowHandle < 0) return;
            if (CheckRequiredField(GCNum.GCN_Body))
            {
                e.Valid = true;
            }
            else
            {
                e.Valid = false;
            }
            base.GV_Body_ValidateRow(sender, e);
        }*/
        public override void GV_Body_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)        
        {
            bool IsCheckOK = true;
            GridView newview = sender as GridView;
            if (e.Value == null)
            {
                return;
            }

            string mValue = e.Value.ToString();            
            if (mValue == "")
            {
                return;
            }

            if (newview.FocusedColumn.FieldName == "XG002")
            {
                string mValue2 = newview.GetFocusedRowCellValue("XB007").ToString();
                f2.SetMJ = new string[] { "POSXG", "002" };
                f2.SetMJParam = new string[] { XF002.Text, mValue2, mValue };
                if (f2.GetMJ)
                {
                    newview.SetFocusedRowCellValue("XG002", mValue);
                    newview.SetFocusedRowCellValue("XG002C", f2.GetReturn[1]);
                    newview.SetFocusedRowCellValue("XB004", f2.GetReturn[2]);
                    newview.SetFocusedRowCellValue("XG005", f2.GetReturn[3]);
                    float mPrice = float.Parse(f2.GetReturn[2]);
                    float mQty = float.Parse(newview.GetFocusedRowCellValue("XG003").ToString());
                    newview.SetFocusedRowCellValue("XG004", mPrice * mQty);
                }
                else
                    IsCheckOK = false;
            }
            else if (newview.FocusedColumn.FieldName == "XB007")
            {
                f2.SetMJ = new string[] { "POSXG", "001" };
                f2.SetMJParam = new string[] { XF002.Text, mValue };
                if (f2.GetMJ)
                {
                    newview.SetFocusedRowCellValue("XB007", mValue);
                    newview.SetFocusedRowCellValue("XB007C", f2.GetReturn[1]);
                }
                else
                    IsCheckOK = false;
            }
            else if (newview.FocusedColumn.FieldName == "XG006")
            {
                f2.SetMJ = new string[] { "POSXC", "002" };
                f2.SetMJParam = new string[] { mValue };
                if (f2.GetMJ)
                {
                    newview.SetFocusedRowCellValue("XG006", mValue);
                    newview.SetFocusedRowCellValue("XG006C", f2.GetReturn[0]);
                }
                else
                    IsCheckOK = false;
            }

            e.Valid = IsCheckOK;
            IsMJOK = IsCheckOK;
            if (!IsCheckOK)
            {
                MessageBox.Show("找不到符合的資料", "錯誤");
            }
            base.GV_Body_ValidatingEditor(sender, e);
        }

        public override void GV_Body_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GV_Body_InitNewRow(sender, e);
            ColumnView newview = (ColumnView)GC_Body.FocusedView;
            newview.FocusedColumn = newview.Columns["XB007"];
            FocuseRow_Body = newview.FocusedRowHandle;
            newview.ShowEditor();
            int idx = 0;
            for (int i = 0; i < GV_Body.RowCount; i++)
            {
                int mRow = GV_Body.GetRowHandle(i);
                if (GV_Body.IsMasterRow(mRow))
                    idx++;
            }
            GV_Body.SetFocusedRowCellValue("XG001", XF001.Text);
            GV_Body.SetFocusedRowCellValue("XG002", "");
            GV_Body.SetFocusedRowCellValue("XG006", fc.FUser.ID);
            GV_Body.SetFocusedRowCellValue("XG006C", fc.FUser.Name);
            GV_Body.SetFocusedRowCellValue("XG010", string.Format("{0:0000}", idx));
        }

        private void GetSPValue(List<List<string>> ls)
        {
            if (XF008.Text != "" && XF002.Text != "")
            {
                if (ls != null)
                {
                    for (int j = 0; j < ls.Count; j++)
                    {
                        for (int i = 0; i < GV_Body.RowCount; i++)
                        {
                            if (GV_Body.GetRowCellValue(i, "XB007") != null && GV_Body.GetRowCellValue(i, "XG002") != null)
                            {
                                if (ls[j][1] == GV_Body.GetRowCellValue(i, "XB007").ToString() &&
                                    ls[j][3] == GV_Body.GetRowCellValue(i, "XG002").ToString())
                                {
                                    ls[j][0] = "F";
                                }
                            }
                        }
                    }
                    for (int j = 0; j < ls.Count; j++)
                    {
                        if (ls[j][0] == "T")
                        {
                            if (GV_Body.GetFocusedRowCellValue("XG002") == null)
                            {
                                GV_Body.AddNewRow();
                            }
                            else
                            {
                                if(GV_Body.GetFocusedRowCellValue("XG002").ToString().Trim()!="")
                                    GV_Body.AddNewRow();
                            }
                            GV_Body.SetFocusedRowCellValue("XG001", XF001.Text);
                            GV_Body.SetFocusedRowCellValue("XB007", ls[j][1]);
                            GV_Body.SetFocusedRowCellValue("XB007C", ls[j][2]);
                            GV_Body.SetFocusedRowCellValue("XG002", ls[j][3]);
                            GV_Body.SetFocusedRowCellValue("XG002C", ls[j][4]);
                            GV_Body.SetFocusedRowCellValue("XG006", fc.FUser.ID);
                            GV_Body.SetFocusedRowCellValue("XG006C", fc.FUser.Name);
                            GV_Body.SetFocusedRowCellValue("XB004", ls[j][5]);
                            GV_Body.SetFocusedRowCellValue("XG004", ls[j][5]);                           
                        }
                    }
                    GV_Body.PostEditor();
                    GV_Body.FocusedRowHandle = GV_Body.RowCount;
                }
            }
        }
        private void btnFavorite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XF008.Text != "" && XF002.Text != "")
            {
                RESAI04G ai04g = new RESAI04G();
                bool CanSelect = false;
                if (GetGridStatu() != GridStatu.gsBrowse) CanSelect = true;
                ai04g.SetKey = new string[] { XF002.Text,fc.FUser.ID };
                ai04g.SetCanSelect = CanSelect;
                if (ai04g.ShowDialog() == DialogResult.OK && CanSelect)
                {
                    GetSPValue(ai04g.GetReturn);
                }
            }
        }
        public override void GV_Body_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            base.GV_Body_MasterRowExpanded(sender, e);
            GridView gridViewWelds = sender as GridView;
            GridView gridViewTests = gridViewWelds.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            gridViewTests.OptionsBehavior.ReadOnly = true;
            gridViewTests.BeginUpdate();
            for (int i = 0; i < gridViewTests.Columns.Count; i++)
            {
                gridViewTests.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                if (!DetailViewFields.Contains(gridViewTests.Columns[i].FieldName))
                {
                    gridViewTests.Columns[i].Visible = false;
                    gridViewTests.Columns[i].OptionsColumn.ShowInCustomizationForm = false;
                }
            }
            if (DetailViewFields.Contains("XK005"))
            {
                RepositoryItemTextEdit edit = new RepositoryItemTextEdit();
                gridViewTests.Columns["XK005"].ColumnEdit = edit;
                edit.DisplayFormat.FormatType = FormatType.Custom;
                edit.DisplayFormat.FormatString = "XK005";
                edit.DisplayFormat.Format = new AI04Formatter();
            }

            if (DetailViewFields.Contains("XH004"))
            {
                gridViewTests.Columns["XH004"].DisplayFormat.FormatType = FormatType.Numeric;
                gridViewTests.Columns["XH004"].DisplayFormat.FormatString = "n0";
            }
            gridViewTests.EndUpdate();
        }
        public override void GV_Body_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {
            base.GV_Body_MasterRowGetRelationDisplayCaption(sender, e);
            e.RelationName = "口味/加料明細";
        }

        private void btnGrades_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XF008.Text != "" && XF002.Text != "")
            {
                RESAI04K ai04k = new RESAI04K();
                bool CanSelect = false;
                if (GetGridStatu() != GridStatu.gsBrowse) CanSelect = true;
                ai04k.SetKey = new string[] { XF002.Text };
                ai04k.SetCanSelect = CanSelect;
                if (ai04k.ShowDialog() == DialogResult.OK && CanSelect)
                {
                    GetSPValue(ai04k.GetReturn);
                }
            }
        }

        private void btnFast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RESAI04M ai04m = new RESAI04M();            
            ai04m.ShowDialog();
            GetMessage();
        }

        private int GetNoneFastCount()
        {
            int mCount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
                {
                    conn.Open();
                    string mSQL = "SELECT XF002,XG002,XB003,XR001 FROM POSXG " +
                                  "LEFT JOIN POSXF ON XG001=XF001 " +
                                  "LEFT JOIN POSXB ON XF002=XB001 AND XG002=XB002 " +
                                  "LEFT JOIN POSXR ON XR002=XF002 AND XR003=XG002 AND XR004=XG006 " +
                                  "WHERE XG006=@XG006 AND XR001 IS NULL " +
                                  "GROUP BY XF002,XG002,XB003,XR001 ";
                    using (SqlCommand cmd = new SqlCommand(mSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@XG006", fc.FUser.ID);
                        using (SqlDataAdapter dta = new SqlDataAdapter(cmd))
                        {
                            DataTable dt1 = new DataTable();
                            dta.Fill(dt1);
                            mCount = dt1.Rows.Count;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                fc.ErrorLog(ex.Message);
            }
            return mCount;
        }
        private void GetMessage()
        {
            int mCount = GetNoneFastCount();
            if (mCount <= 0)
            {
                btnFast.Glyph = Properties.Resources.star1;
                return;
            }

            int mwidth = 16;
            int NumTen = mCount / 10 * 16;
            int NumOne = mCount % 10 * 16;
            btnFast.Caption = "快速評論 [" + mCount.ToString() + "]";
            Bitmap img = new Bitmap(Properties.Resources.Cycle);
            Bitmap img2 = new Bitmap(Properties.Resources.Number);
            Graphics g = Graphics.FromImage(img);
            if (NumTen == 0)
            {
                g.DrawImage(img2, new Rectangle(18, 15, 16, 22), new Rectangle(NumOne, 0, 16, 22), GraphicsUnit.Pixel);
            }
            else if (NumTen >= 99)
            {
                g.DrawImage(img2, new Rectangle(10, 15, 16, 22), new Rectangle(16 * 9, 0, 16, 22), GraphicsUnit.Pixel);
                g.DrawImage(img2, new Rectangle(26, 15, 16, 22), new Rectangle(16 * 9, 0, 16, 22), GraphicsUnit.Pixel);
            }
            else
            {
                g.DrawImage(img2, new Rectangle(10, 15, 16, 22), new Rectangle(NumTen, 0, 16, 22), GraphicsUnit.Pixel);
                g.DrawImage(img2, new Rectangle(26, 15, 16, 22), new Rectangle(NumOne, 0, 16, 22), GraphicsUnit.Pixel);
            }
            Image img5 = fc.ScaleImage(img, mwidth, mwidth);
            Bitmap img3 = new Bitmap(Properties.Resources.star1);
            Graphics g2 = Graphics.FromImage(img3);
            g2.DrawImage(img5, new Rectangle(14, 0, mwidth, mwidth), new Rectangle(0, 0, mwidth, mwidth), GraphicsUnit.Pixel);
            btnFast.Glyph = img3;
        }
    }
}
