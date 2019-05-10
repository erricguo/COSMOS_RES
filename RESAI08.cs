using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COSMOS_RES.DataSet;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace COSMOS_RES
{
    public partial class RESAI08 : COSMOS_RES.BaseForm
    {
        public RESAI08()
        {
            InitializeComponent();
        }
        private void RESAI08_Load(object sender, EventArgs e)
        {
            InitUIVar();
        }
        public class AI08Formatter : IFormatProvider, ICustomFormatter
        {
            public object GetFormat(System.Type type)
            {
                return this;
            }
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                string formatValue = arg.ToString();
                if (format == "XN002" && formatValue != "")
                {
                    if (formatValue == "1")
                        formatValue = "1.菜色類別";
                    else if (formatValue == "2")
                        formatValue = "2.菜色編號";                    
                    return formatValue;
                }
                else if (format == "XO004" && formatValue != "")
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
            GC_Main.DataSource = pOSXNBindingSource;
            GC_Body.DataSource = pOSXOBindingSource;
            MainControls.Add(XN001);
            MainControls.Add(XN002);
            MainControls.Add(XN003);

            KeyFieldMain = "XN001,XN002,XN003";
            KeyFieldBody = "XO001,XO002,XO003,XO004,XO005";
            VisibleFieldBody = "XO001,XO002,XO003";
            OrderFieldMain = "XN001,XN002,XN003";
            OrderFieldBody = "XO001,XO002,XO003,XO004,XO005";
            ReadOnlyFieldBody = "XO005C";
            LeaveCheckFieldMain = "XN001,XN003";

            ButtonFieldListMain.Add(XN001);
            ButtonFieldListMain.Add(XN003);
            ButtonFieldListBody.Add(new ButtonFieldFormat(GCNum.GCN_Body, "", "XO005", this.XO004ButtonEdit_ButtonClick));

            VisibleListMain.Add("XN001", 0);
            VisibleListMain.Add("XN001C", 1);
            VisibleListMain.Add("XN002", 2);
            VisibleListMain.Add("XN003", 3);
            VisibleListMain.Add("XN003C", 4);

            VisibleListMain.Add("XO004", 0);
            VisibleListMain.Add("XO005", 1);
            VisibleListMain.Add("XO005C", 2);

            FieldWidthMain.Add("XN001", 75);
            FieldWidthMain.Add("XN001C", 183);
            FieldWidthMain.Add("XN002", 151);
            FieldWidthMain.Add("XN003", 157);
            FieldWidthMain.Add("XN003C", 367);

            FieldWidthBody.Add("XO001", 75);
            FieldWidthBody.Add("XO002", 75);
            FieldWidthBody.Add("XO003", 75);
            FieldWidthBody.Add("XO004", 75);
            FieldWidthBody.Add("XO005", 125);
            FieldWidthBody.Add("XO005C", 279);

            DS_RESAI08.POSXNDataTable dataTable = pOSXNTableAdapter.GetDataBy("");
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
            GV_Main.Columns["XN002"].ColumnEdit = edit;         
            edit.DisplayFormat.FormatType = FormatType.Custom;
            edit.DisplayFormat.FormatString = "XN002";
            edit.DisplayFormat.Format = new AI08Formatter();

            var items = new[] { 
            new { Text = "1.菜色類別",   Value = "1" }, 
            new { Text = "2.菜色編號",   Value = "2" }};

            var items2 = new[] { 
            new { Text = "1.口味",   Value = "1" }, 
            new { Text = "2.加料",   Value = "2" }};

            RepositoryItemLookUpEdit edit2 = new RepositoryItemLookUpEdit();
            GV_Body.Columns["XO004"].ColumnEdit = edit2;
            edit2.DisplayMember = "Text";
            edit2.ValueMember = "Value";
            edit2.DataSource = items2;

            SelectKeyMain = "XN001,XN002,XN003";
            SelectKeyBody = "XO001,XO002,XO003";

            XN001C.Text = "";
            XN003C.Text = "";
            XN002.Properties.DisplayMember = "Text";
            XN002.Properties.ValueMember = "Value";
            XN002.Properties.DataSource = items;

            base.InitUIVar();
        }

        private void XO004ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != BaseForm.GridStatu.gsBrowse)
            {
                string mType = GV_Body.GetFocusedRowCellValue("XO004").ToString();
                f2.SetMI = new string[] { "POSXH", "001" };
                f2.SetMIParam = new string[] { mType };
                f2.SetMuity = true;                
                Dictionary<int, List<string>> muity = null;
                if (f2.GetMI)
                {
                    muity = f2.GetMuity;
                    bool IsExist = false;
                    bool IsFirst = true;
                    foreach (KeyValuePair<int, List<string>> s in muity)
                    {
                        for (int i = 0; i < GV_Body.RowCount; i++)
                        {
                            if ((GV_Body.GetRowCellValue(i, "XO005") == null))
                            {
                                IsExist = false;
                                break;
                            }
                            if (GV_Body.GetRowCellValue(i, "XO005").ToString() == s.Value[0])
                            {
                                if (GV_Body.GetRowCellValue(i, "XO004").ToString() == mType)
                                {
                                    IsExist = true;
                                    break;
                                }
                            }
                        }
                        if (IsExist)
                        {
                            IsExist = false;
                            continue;
                        }
                        else
                        {
                            if (IsFirst)
                            {
                                IsFirst = false;
                            }
                            else
                            {
                                GV_Body.AddNewRow();
                            }
                            GV_Body.SetFocusedRowCellValue("XO001", XN001.Text);
                            GV_Body.SetFocusedRowCellValue("XO002", XN002.EditValue);
                            GV_Body.SetFocusedRowCellValue("XO003", XN003.Text);
                            GV_Body.SetFocusedRowCellValue("XO004", mType);
                            GV_Body.SetFocusedRowCellValue("XO005", s.Value[0]);
                            GV_Body.SetFocusedRowCellValue("XO005C", s.Value[1]);
                            GV_Body.UpdateCurrentRow();
                        }
                    }
                }
            }    
        }

        private void XN003ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                if (XN002.EditValue.ToString() == "1")
                {
                    f2.SetMI = new string[] { "POSXL", "002" };
                    f2.SetMIParam = new string[] { XN001.Text };
                }
                else if (XN002.EditValue.ToString() == "2")
                {
                    f2.SetMI = new string[] { "POSXB", "001" };
                    f2.SetMIParam = new string[] { XN001.Text };
                }

                if (f2.GetMI)
                {
                    XN003.Text = f2.GetReturn[0];
                    XN003C.Text = f2.GetReturn[1];
                }
            }   
        }

        private void XN001ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                f2.SetMI = new string[] { "POSXC", "001" };
                if (f2.GetMI)
                {
                    XN001.Text = f2.GetReturn[0];
                    XN001C.Text = f2.GetReturn[1];
                }
            }   
        }

        public override void DBFillBy(BaseForm.GCNum xNum, string xStr)
        {
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    pOSXNTableAdapter.FillBy(dS_RESAI08.POSXN, xStr);
                    break;
                case GCNum.GCN_Body:
                    pOSXOTableAdapter.FillBy(dS_RESAI08.POSXO, xStr);
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
                        pOSXNBindingSource.EndEdit();
                        pOSXNTableAdapter.Update(dS_RESAI08.POSXN);
                        break;
                    case GCNum.GCN_Body:
                        pOSXOBindingSource.EndEdit();
                        pOSXOTableAdapter.Update(dS_RESAI08.POSXO);
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

        public override void BtnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnCancel_ItemClick(sender, e);
            XN001C.Text = "";
            XN003C.Text = "";
            if (XN002.EditValue.ToString() == "")
                XN002.EditValue = "";
        }
        public override void GV_Body_KeyDown(object sender, KeyEventArgs e)
        {
            base.GV_Body_KeyDown(sender, e);
            GV_Body.PostEditor();
            if (e.KeyData == Keys.Down && IsKeyDownOK)
            {
                ColumnView view = (ColumnView)GC_Body.FocusedView;
                if (view.IsLastRow)
                {
                    GV_Body.AddNewRow();
                }
            }
        }
        public override void GC_Body_MouseClick(object sender, MouseEventArgs e)
        {
            base.GC_Body_MouseClick(sender, e);
            if (IsCheckRequired)
            {
                if (GV_Body.RowCount == 0)
                {
                    GV_Body.AddNewRow();
                }
            }
        }
        public override void F2FieldMain_KeyDown(object sender, KeyEventArgs e)
        {
            base.F2FieldMain_KeyDown(sender, e);
        }

        public override void GV_Body_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GV_Body_InitNewRow(sender, e);
            GV_Body.SetFocusedRowCellValue("XO001", XN001.EditValue);
            GV_Body.SetFocusedRowCellValue("XO002", XN002.EditValue);
            GV_Body.SetFocusedRowCellValue("XO003", XN003.EditValue);
            GV_Body.SetFocusedRowCellValue("XO004", "1");
            GV_Body.FocusedColumn = GV_Body.Columns["XO005"];
            GV_Body.ShowEditor();
        }

        private void XN002_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (e.NewValue.ToString() == "")
            {
                e.Cancel = false;
                return;
            }
            if (e.NewValue==e.OldValue)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                if (MessageBox.Show("切換種類將會清除單身已建資料!\r\n是否確定?", "提示",MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    e.Cancel = false;
                    XN003.Text = "";
                    XN003C.Text = "";
                    while (GV_Body.RowCount > 0)
                    {
                        GV_Body.SelectAll();
                        GV_Body.DeleteSelectedRows();
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        public override void MainControl_Leave(object sender, EventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                base.MainControl_Leave(sender, e);
                DevExpress.XtraEditors.BaseEdit edit = (sender as DevExpress.XtraEditors.BaseEdit);
                if (edit.Text.Trim() =="")
                {
                    return;
                }
                string[] xADMMJ = null;
                string[] xParam = null;
                Dictionary<DevExpress.XtraEditors.BaseControl, int> xReturnFileds = new Dictionary<DevExpress.XtraEditors.BaseControl, int>();
                if (edit.Name == "XN001")
                {
                    xADMMJ = new string[] { "POSXC", "001" };
                    xParam = new string[] { edit.Text };
                    xReturnFileds.Add(XN001C, 0);
                }
                else if (edit.Name == "XN003")
                {
                    if (XN002.EditValue.ToString() == "1")
                    {
                        xADMMJ = new string[] { "POSXL", "002" };
                        xParam = new string[] { XN001.Text, XN003.EditValue.ToString() };
                    }
                    else if (XN002.EditValue.ToString() == "2")
                    {
                        xADMMJ = new string[] { "POSXB", "001" };
                        xParam = new string[] { XN001.Text, XN003.EditValue.ToString() };
                    }
                    xReturnFileds.Add(XN003C, 1);
                }
                LeaveCheckMainFunc(edit, xADMMJ, xParam, xReturnFileds);
            }
        }

    }
}
