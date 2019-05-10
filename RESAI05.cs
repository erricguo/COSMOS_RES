using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using COSMOS_RES.DataSet;

namespace COSMOS_RES
{
    public partial class RESAI05 : COSMOS_RES.BaseForm
    {
        public RESAI05()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            InitUIVar();
        }

        public override void InitUIVar()
        {
            TabControlMainHeight = 160;
            GC_Main.DataSource = pOSXIBindingSource;
            GC_Body.DataSource = pOSXLBindingSource;
            MainControls.Add(XI001);
            MainControls.Add(XI002);
            KeyFieldMain = "XI001";
            KeyFieldBody = "XL002";
            VisibleFieldBody = "XL001";
            OrderFieldMain = "XI001";
            OrderFieldBody = "XL001,XL002";
            ReadOnlyFieldBody = "XL002";
            RequiredFieldMain = "XI002";

            FieldWidthMain.Add("XI001", 86);
            FieldWidthMain.Add("XI002", 255);

            FieldWidthBody.Add("XL001", 75);
            FieldWidthBody.Add("XL002", 86);
            FieldWidthBody.Add("XL003", 254);

            DS_RESAI05.POSXIDataTable dataTable = pOSXITableAdapter.GetDataBy("");
            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    if (!dataTable.Columns[i].ColumnName.StartsWith("XI"))
                    {
                        continue;
                    }
                    SchemaList.Add(dataTable.Columns[i].ColumnName + " " + dataTable.Columns[i].Caption);
                }
            }
            SelectKeyMain = "XI001";
            SelectKeyBody = "XL001";
            base.InitUIVar();
        }

        public override void DBFillBy(BaseForm.GCNum xNum, string xStr)
        {
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    pOSXITableAdapter.FillBy(dS_RESAI05.POSXI, xStr);
                    break;
                case GCNum.GCN_Body:
                    pOSXLTableAdapter.FillBy(dS_RESAI05.POSXL, xStr);
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
                        pOSXIBindingSource.EndEdit();
                        pOSXITableAdapter.Update(dS_RESAI05.POSXI);
                        break;
                    case GCNum.GCN_Body:
                        pOSXLBindingSource.EndEdit();
                        pOSXLTableAdapter.Update(dS_RESAI05.POSXL);
                        break;
                }
                base.DBUpdate(xNum);
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

       /* public override void GV_Body_KeyDown(object sender, KeyEventArgs e)
        {
            base.GV_Body_KeyDown(sender, e);
            if (e.KeyData == Keys.Down && IsKeyDownOK)
            {
                ColumnView view = (ColumnView)GC_Body.FocusedView;
                if (view.IsLastRow)
                {
                    {
                        GV_Body.PostEditor();
                        int index = Int32.Parse(GV_Body.GetRowCellValue(FocuseRow_Body, "XL002").ToString()) + 1;
                        
                        GV_Body.AddNewRow();
                        ColumnView newview = (ColumnView)GC_Body.FocusedView;
                        newview.FocusedColumn = newview.Columns["XL002"];//定位焦点网格的位置   
                        FocuseRow_Body = newview.FocusedRowHandle;//获取新焦点行的FocuseRowHandle并初始化全局变量

                        GV_Body.SetRowCellValue(FocuseRow_Body, "XL001", XI001.Text);
                        GV_Body.SetRowCellValue(FocuseRow_Body, "XL002", string.Format("{0:0000}", index));
                    }
                }
            }
            IsKeyDownOK = true;
        }*/
        public override void BtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnNew_ItemClick(sender, e);
            if (GetGridStatu() == GridStatu.gsAdd)
            {
                string mXI001 = "";
                using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT MAX(XI001) AS XI001 FROM POSXI ", conn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                mXI001 = dr["XI001"].ToString();
                            }
                        }
                    }
                }
                XI001.Text = "K" + fc.ZeroatFirst((Int32.Parse(mXI001.Substring(1, mXI001.Length - 1)) + 1), 3); //K000
            }
        }
        /*public override void GC_Body_MouseClick(object sender, MouseEventArgs e)
        {
            base.GC_Body_MouseClick(sender, e);
            if (IsCheckRequired)
            {
                if (GV_Body.RowCount == 0)
                {
                    GV_Body.AddNewRow();
                    GV_Body.SetRowCellValue(FocuseRow_Body, "XL001", XI001.Text);
                    GV_Body.SetRowCellValue(FocuseRow_Body, "XL002", "0001");
                }
            }
        }*/
        public override void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GetGridStatu() == GridStatu.gsAdd)
            {
                string mNo = XI001.Text;
                string mSQL = "SELECT XI001 FROM POSXI WHERE XI001='" + mNo + "'";
                while (!ValidMaxNo(mSQL))
                {
                    mNo = "K" + fc.ZeroatFirst((Int32.Parse(mNo.Substring(1, mNo.Length - 1)) + 1), 3); //K000
                    mSQL = "SELECT XI001 FROM POSXI WHERE XI001='" + mNo + "'";
                }
                XI001.Text = mNo;
                for (int i = 0; i < GV_Body.RowCount; i++)
                {
                    GV_Body.SetRowCellValue(i, "XL001", XI001.Text);
                }
            }
            base.BtnSave_ItemClick(sender, e);
        }

        public override void GV_Body_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            base.GV_Body_InitNewRow(sender, e);
            GV_Body.PostEditor();
            //int index = Int32.Parse(GV_Body.GetRowCellValue(FocuseRow_Body, "XL002").ToString()) + 1;
            int index = GV_Body.RowCount;
            GV_Body.FocusedColumn = GV_Body.Columns["XL002"];//定位焦点网格的位置   
            FocuseRow_Body = GV_Body.FocusedRowHandle;//获取新焦点行的FocuseRowHandle并初始化全局变量
            GV_Body.SetRowCellValue(FocuseRow_Body, "XL001", XI001.Text);
            GV_Body.SetRowCellValue(FocuseRow_Body, "XL002", string.Format("{0:0000}", index));
        }
    }
}
