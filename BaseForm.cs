using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using COSMOS_RES.Properties;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.ViewInfo;
using System.Reflection;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace COSMOS_RES     
{                            
    public partial class BaseForm : RootForm
    {
        public bool IsCanNew = true;
        public bool IsCanDel = true;
        public bool IsMJOK = true;
        public bool IsKeyDownOK = true;
        public bool IsSaveOK = true;
        public int TabControlMainHeight = 0;
        public string FReFreshStr = "";

        public void SetDateTimeField()
        {
            Fieldformat[] mFieldGroup = new Fieldformat[] { DateFieldMain, TimeFieldMain, DateFieldBody, TimeFieldBody };
            for (int j = 0; j < mFieldGroup.Length; j++)
            {
                if (mFieldGroup[j].Fields == "" || mFieldGroup[j].Fields == null) continue;                
                string[] mTemp = mFieldGroup[j].Fields.Split(',');
                GCNum mTableType = mFieldGroup[j].TableType;
                string mDateType = mFieldGroup[j].DateType;

                for (int i = 0; i < mTemp.Length; i++)
                {
                    using (RepositoryItemTextEdit edit = new RepositoryItemTextEdit())
                    {
                        GetGV(mTableType).Columns[mTemp[i]].ColumnEdit = edit;
                        edit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                        edit.DisplayFormat.FormatType = FormatType.Custom;
                        edit.DisplayFormat.FormatString = mDateType;
                        edit.DisplayFormat.Format = new CustomFormatter();
                    }

                    if (mTableType == GCNum.GCN_Main)
                    {
                        {
                            DevExpress.XtraEditors.TextEdit tbx = this.Controls.Find(mTemp[i], true).FirstOrDefault() as DevExpress.XtraEditors.TextEdit;
                            if (tbx != null)
                            {
                                if (mDateType == "Date")
                                {
                                    tbx.Properties.Mask.EditMask = "yyyy/MM/dd";
                                }
                                else if (mDateType == "Time")
                                {
                                    tbx.Properties.Mask.EditMask = "HH:mm";
                                }
                                tbx.Properties.DisplayFormat.FormatType = FormatType.Custom;
                                tbx.Properties.DisplayFormat.FormatString = mDateType;
                                tbx.Properties.DisplayFormat.Format = new CustomFormatter();
                            }
                        }
                    }
                }
            }
        }
        public void SetCheckEditField()
        {
            Fieldformat[] mFieldGroup = new Fieldformat[] { CheckFieldMain, CheckFieldBody };
            for (int j = 0; j < mFieldGroup.Length; j++)
            {
                if (mFieldGroup[j].Fields == "" || mFieldGroup[j].Fields == null) continue;
                string[] mTemp = mFieldGroup[j].Fields.Split(',');
                GCNum mTableType = mFieldGroup[j].TableType;
                for (int i = 0; i < mTemp.Length; i++)
                {
                    using (RepositoryItemCheckEdit edit = new RepositoryItemCheckEdit())
                    {
                        GetGV(mTableType).Columns[mTemp[i]].ColumnEdit = edit;
                        edit.ValueChecked = "Y";
                        edit.ValueUnchecked = "N";
                    }
                }
            }
        }

        public void SetNumberField()
        {
            Fieldformat[] mFieldGroup = new Fieldformat[] { NumberFieldMain, NumberFieldBody };
            //n0
            for (int j = 0; j < mFieldGroup.Length; j++)
            {
                if (mFieldGroup[j].Fields == "" || mFieldGroup[j].Fields == null) continue;
                string[] mTemp = mFieldGroup[j].Fields.Split(',');
                GCNum mTableType = mFieldGroup[j].TableType;
                for (int i = 0; i < mTemp.Length; i++)
                {
                    GetGV(mTableType).Columns[mTemp[i]].DisplayFormat.FormatType = FormatType.Numeric;
                    GetGV(mTableType).Columns[mTemp[i]].DisplayFormat.FormatString = "n0";
                    if (mTableType == GCNum.GCN_Main)
                    {
                        {
                            DevExpress.XtraEditors.TextEdit tbx = this.Controls.Find(mTemp[i], true).FirstOrDefault() as DevExpress.XtraEditors.TextEdit;
                            if (tbx != null)
                            {
                                tbx.Properties.DisplayFormat.FormatType = FormatType.Numeric;
                                tbx.Properties.DisplayFormat.FormatString = "n0";
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mFieldGroup.Length; j++)
            {
                if (mFieldGroup[j].NumFields.Count <= 0) return;
                GCNum mTableType = mFieldGroup[j].TableType;
                for (int k = 0; k < mFieldGroup[j].NumFields.Count;k++ )
                {
                    KeyValuePair<string, string> key = mFieldGroup[j].NumFields.ElementAt(k);
                    string[] mTemp = key.Value.Split(',');
                    if (mTemp.Length > 1)
                    {
                        GetGV(mTableType).Columns[mTemp[0]].DisplayFormat.FormatType = FormatType.Numeric;
                        GetGV(mTableType).Columns[mTemp[0]].DisplayFormat.FormatString = mTemp[1];
                        if (mTableType == GCNum.GCN_Main)
                        {
                            {
                                DevExpress.XtraEditors.TextEdit tbx = this.Controls.Find(mTemp[0], true).FirstOrDefault() as DevExpress.XtraEditors.TextEdit;
                                if (tbx != null)
                                {
                                    tbx.Properties.DisplayFormat.FormatType = FormatType.Numeric;
                                    tbx.Properties.DisplayFormat.FormatString = mTemp[1];
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SetButtonEditField()
        {
            for (int i = 0; i < ButtonFieldListMain.Count;i++ )
            {
                ((ButtonEdit)ButtonFieldListMain[i]).Properties.ButtonsStyle = BorderStyles.UltraFlat;
                ((ButtonEdit)ButtonFieldListMain[i]).Properties.Buttons[0].Width = 15;
                F2FieldMain.Add(ButtonFieldListMain[i].Name);
            }
            for (int i = 0; i < ButtonFieldListBody.Count;i++ )
            {
                if (ButtonFieldListBody[i].Field == "" || ButtonFieldListBody[i].Field == null) continue;
                GCNum mTableType = ButtonFieldListBody[i].TableType;
                GetGV(mTableType).Columns[ButtonFieldListBody[i].Field].ColumnEdit = ButtonFieldListBody[i];
                F2FieldBody.Add(ButtonFieldListBody[i].Field);
            }         
        }

        public void SetPassWordEditField()
        {
            Fieldformat[] mFieldGroup = new Fieldformat[] { PassWordFieldMain, PassWordFieldBody };
            for (int j = 0; j < mFieldGroup.Length; j++)
            {
                if (mFieldGroup[j].Fields == "" || mFieldGroup[j].Fields == null) continue;
                string[] mTemp = mFieldGroup[j].Fields.Split(',');
                GCNum mTableType = mFieldGroup[j].TableType;
                for (int i = 0; i < mTemp.Length; i++)
                {
                    using (RepositoryItemTextEdit edit = new RepositoryItemTextEdit())
                    {
                        GetGV(mTableType).Columns[mTemp[i]].ColumnEdit = edit;
                        edit.PasswordChar = '*';
                    }
                }
            }
        }

        public BaseForm()
        {
            InitializeComponent();
        }
        public virtual void InitUIVar()
        {
            SetDateTimeField();
            SetCheckEditField();
            SetNumberField();
            SetButtonEditField();
            SetPassWordEditField();
            TabControlMainHeight = TabControlMain.Height;
            BtnNew.Enabled = IsCanNew;
            BtnQuery.Enabled = true;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            BtnFirst.Enabled = false;
            BtnPrior.Enabled = false;
            BtnNext.Enabled = false;
            BtnLast.Enabled = false;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            btnAutoWidth.Enabled = true;
            //KeyListMain = new List<string>(OrderFieldMain.Split(','));
            //KeyListBody = new List<string>(OrderFieldBody.Split(','));
            KeyListMain = new List<string>(KeyFieldMain.Split(','));
            KeyListBody = new List<string>(KeyFieldBody.Split(','));
            ReadOnlyListMain = new List<string>(ReadOnlyFieldMain.Split(','));
            ReadOnlyListBody = new List<string>(ReadOnlyFieldBody.Split(','));
            RequiredListMain = new List<string>(RequiredFieldMain.Split(','));
            RequiredListBody = new List<string>(RequiredFieldBody.Split(','));
            LeaveCheckListMain = new List<string>(LeaveCheckFieldMain.Split(','));
            LeaveCheckListBody = new List<string>(LeaveCheckFieldBody.Split(','));

            string[] Manage = new string[] { "COMPANY", "CREATOR", "USR_GROUP", "CREATE_DATE", "MODIFIER", "MODI_DATE", "FLAG", "CREATE_TIME", "MODI_TIME", "TRANS_TYPE", "TRANS_NAME" };
            for (int i = 0; i < Manage.Count() ;i++ )
            {
                if (GV_Main.Columns.Count < i)
                {
                    break;
                }
                if (GV_Main.Columns[Manage[i]] != null)
                {
                    GV_Main.Columns[Manage[i]].Visible = false;
                }
            }

            for (int i = 0; i < Manage.Count(); i++)
            {
                if (GV_Body.Columns.Count < i)
                {
                    break;
                }
                if (GV_Body.Columns[Manage[i]] != null)
                {
                    GV_Body.Columns[Manage[i]].Visible = false;
                }
            }

            if (VisibleFieldMain.Trim() != "")
            {
                string[] mTemp = VisibleFieldMain.Split(',');
                for (int i = 0; i < mTemp.Count(); i++)
                {
                    GV_Main.Columns[mTemp[i]].Visible = false;
                }
            }

            if (VisibleFieldBody.Trim() != "")
            {
                string[] mTemp = VisibleFieldBody.Split(',');
                for (int i = 0; i < mTemp.Count(); i++)
                {
                    GV_Body.Columns[mTemp[i]].Visible = false;
                }
            }

            for (int i = 0; i < GV_Main.Columns.Count;i++ )
            {
                GV_Main.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            for (int i = 0; i < GV_Body.Columns.Count; i++)
            {
                GV_Body.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            for (int i = 0; i < MainControls.Count;i++ )
            {
                MainControls[i].Properties.ReadOnly = true;
                if (KeyListMain.Contains(MainControls[i].Name))
                {
                    MainControls[i].ForeColor = Color.White;
                    MainControls[i].BackColor = Color.FromArgb(88, 88, 88);
                }
                if (RequiredListMain.Contains(MainControls[i].Name))
                {
                    MainControls[i].BackColor = Color.FromArgb(255, 255, 192);
                    if (LeaveCheckFieldMain.Contains(MainControls[i].Name))
                    {
                        MainControls[i].Leave += MainControl_Leave;
                    }
                }
            }

            for (int i = 0; i < KeyListMain.Count; i++)
            {
                GV_Main.Columns[KeyListMain[i]].AppearanceHeader.BackColor = Color.FromArgb(88, 88, 88);
                GV_Main.Columns[KeyListMain[i]].AppearanceHeader.BackColor2 = Color.Gray;
                GV_Main.Columns[KeyListMain[i]].AppearanceHeader.ForeColor = Color.White;
                GV_Main.Columns[KeyListMain[i]].AppearanceHeader.BorderColor = Color.Black;
                GV_Main.Columns[KeyListMain[i]].AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            }

            for (int i = 0; i < KeyListBody.Count;i++ )
            {
                GV_Body.Columns[KeyListBody[i]].AppearanceHeader.BackColor = Color.FromArgb(88, 88, 88);
                GV_Body.Columns[KeyListBody[i]].AppearanceHeader.BackColor2 = Color.Gray;
                GV_Body.Columns[KeyListBody[i]].AppearanceHeader.ForeColor = Color.White;
                GV_Body.Columns[KeyListBody[i]].AppearanceHeader.BorderColor = Color.Black;
                GV_Body.Columns[KeyListBody[i]].AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            }

            WidthColumns(GCNum.GCN_Main, FieldWidthMain);
            WidthColumns(GCNum.GCN_Body, FieldWidthBody);
            SortColumns(GCNum.GCN_Main, VisibleListMain);
            SortColumns(GCNum.GCN_Body, VisibleListBody);
        }

        public virtual void MainControl_Leave(object sender, EventArgs e)
        {

        }
        public virtual void InitEvent()
        {
            
        }

        public override DevExpress.XtraGrid.GridControl GetGC(GCNum xGCNum)
        {
            switch (xGCNum)
            {
                case GCNum.GCN_Main:
                    return GC_Main;                    
                case GCNum.GCN_Body:
                    return GC_Body;
            }
            return null;
        }
        public override DevExpress.XtraGrid.Views.Grid.GridView GetGV(GCNum xGCNum)
        {
            switch (xGCNum)
            {
                case GCNum.GCN_Main:
                    return GV_Main;
                case GCNum.GCN_Body:
                    return GV_Body;
            }
            return null;
        }
        protected virtual void BindingData()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public virtual void DBFillBy(GCNum xNum,string xStr)
        {
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    SortColumns(GCNum.GCN_Main, VisibleListMain);
                    break;
                case GCNum.GCN_Body:
                    SortColumns(GCNum.GCN_Body, VisibleListBody);
                    break;
            }
        }
        public virtual bool DBUpdate(GCNum xNum)
        {
            return true;
        }

        public string makeConnectString(fc.DBInfo xDBInfo)
        {
            string mRes = "Persist Security Info=true"+
                          ";Integrated Security="+
                          ";Data Source=" + xDBInfo.IP +
                          ";Initial Catalog=" + xDBInfo.DB +
                          ";User ID=" + xDBInfo.ID +
                          ";Password=" + xDBInfo.PW;
            return mRes;
        }

        public virtual DataTable QueryInfo(string xSQL, fc.DBInfo xDBInfo)
        {
            SqlConnection conn = null;
            conn = null;
            conn = new SqlConnection(makeConnectString(xDBInfo));
            try
            {
                conn.Open();
                SqlCommand myCommand = null; 
                myCommand = new SqlCommand(xSQL, conn);

                SqlDataAdapter sqldataadpt = new SqlDataAdapter(myCommand);
                DataTable dt1 = new DataTable();
                sqldataadpt.Fill(dt1);

                conn.Close();
                return dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                fc.ErrorLog(ex.Message);
                return null;
            }

        }
        public virtual void BtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FGridStatu == GridStatu.gsBrowse)
            {
                TabControlMain.SelectedTabPageIndex = 0;
                BtnNew.Enabled = false;
                BtnQuery.Enabled = false;
                BtnEdit.Enabled = false;
                BtnDel.Enabled = false;
                BtnFirst.Enabled = false;
                BtnPrior.Enabled = false;
                BtnNext.Enabled = false;
                BtnLast.Enabled = false;
                BtnSave.Enabled = true;
                BtnCancel.Enabled = true;
                btnAutoWidth.Enabled = false;
                FGridStatu = GridStatu.gsAdd;
                GV_Body.OptionsBehavior.ReadOnly = false;
                for (int i = 0; i < MainControls.Count; i++)
                {
                    //if (KeyListMain.Contains(MainControls[i].Name) || ReadOnlyListMain.Contains(MainControls[i].Name))
                    if (ReadOnlyListMain.Contains(MainControls[i].Name))
                    {
                        continue;
                    }
                    MainControls[i].Properties.ReadOnly = false;
                }

                for (int i = 0; i < GV_Body.Columns.Count; i++)
                {
                    if (ReadOnlyListBody.Contains(GV_Body.Columns[i].FieldName))
                    {
                        GV_Body.Columns[i].OptionsColumn.ReadOnly = true;
                    }
                    else
                    {
                        GV_Body.Columns[i].OptionsColumn.ReadOnly = false;
                    }
                }
                DBFillBy(GCNum.GCN_Main, " WHERE 1=2");
                DBFillBy(GCNum.GCN_Body, " WHERE 1=2");
                GV_Main.AddNewRow();               
            }            
        }

        protected virtual void BtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FGridStatu == GridStatu.gsBrowse)
            {
                TabControlMain.SelectedTabPageIndex = 1;
                BtnSave.Enabled = false;
                BtnCancel.Enabled = false;
                for (int i = 0; i < MainControls.Count; i++)
                {
                    MainControls[i].Properties.ReadOnly = true;
                }

                Search sc = new Search();
                sc.SetFilter = DefaultQueryStr;
                sc.SetCondition = SchemaList;
                if (sc.ShowDialog() == DialogResult.OK)
                {
                    //pOSXATableAdapter.FillBy(rESLeaderDataSet.POSXA, sc.GetFilter);
                    DBFillBy(GCNum.GCN_Main, sc.GetFilter + " ORDER BY " + OrderFieldMain);
                    DefaultQueryStr = sc.GetCondition;
                }
                
                if (GV_Main.RowCount > 0)
                {
                    BtnNew.Enabled = IsCanNew;
                    BtnQuery.Enabled = true;
                    BtnEdit.Enabled = true;
                    BtnDel.Enabled = IsCanDel;
                    BtnFirst.Enabled = true;
                    BtnPrior.Enabled = true;
                    BtnNext.Enabled = true;
                    BtnLast.Enabled = true;
                    BtnSave.Enabled = false;
                    BtnCancel.Enabled = false;
                    btnAutoWidth.Enabled = true;
                }
            }
        }

        public virtual void BtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FGridStatu == GridStatu.gsBrowse)
            {
                TabControlMain.SelectedTabPageIndex = 0;
                BtnNew.Enabled = false;
                BtnQuery.Enabled = false;
                BtnEdit.Enabled = false;
                BtnDel.Enabled = false;
                BtnFirst.Enabled = false;
                BtnPrior.Enabled = false;
                BtnNext.Enabled = false;
                BtnLast.Enabled = false;
                BtnSave.Enabled = true;
                BtnCancel.Enabled = true;
                btnAutoWidth.Enabled = false;
                GV_Body.OptionsBehavior.ReadOnly = false;
                for (int i = 0; i < MainControls.Count; i++)
                {
                    if (KeyListMain.Contains(MainControls[i].Name) || ReadOnlyListMain.Contains(MainControls[i].Name))
                    {
                        MainControls[i].Enabled = false;
                        continue;
                    }
                    MainControls[i].Properties.ReadOnly = false;
                }

                for (int i = 0; i < GV_Body.Columns.Count; i++)
                {
                    if (ReadOnlyListBody.Contains(GV_Body.Columns[i].FieldName))
                    {
                        GV_Body.Columns[i].OptionsColumn.ReadOnly = true;
                    }
                    else
                    {
                        GV_Body.Columns[i].OptionsColumn.ReadOnly = false;
                    }
                }
                FGridStatu = GridStatu.gsEdit;
            }
        }

        public virtual void BtnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FGridStatu == GridStatu.gsBrowse)
            {
                if (GV_Main.RowCount > 0)
                {
                    if (MessageBox.Show("確定要刪除此筆資料?","詢問",MessageBoxButtons.OKCancel)==DialogResult.OK)
                    {
                        while (GV_Body.RowCount > 0)
                        {
                            GV_Body.DeleteRow(0);                            
                        }
                        DBUpdate(GCNum.GCN_Body);                        
                        GV_Body.RefreshData();
                        GC_Body.Refresh();

                        GV_Main.DeleteSelectedRows();                                 
                        DBUpdate(GCNum.GCN_Main);                        
                        GV_Main.RefreshData();
                        GC_Main.Refresh();

                        FGridStatu = GridStatu.gsBrowse;
                        GV_Body.OptionsBehavior.ReadOnly = true;

                        BtnNew.Enabled = IsCanNew;
                        BtnQuery.Enabled = true;
                        BtnEdit.Enabled = true;
                        BtnDel.Enabled = IsCanDel;
                        BtnFirst.Enabled = true;
                        BtnPrior.Enabled = true;
                        BtnNext.Enabled = true;
                        BtnLast.Enabled = true;
                        BtnSave.Enabled = false;
                        BtnCancel.Enabled = false;
                        btnAutoWidth.Enabled = true;
                    }
                }
            }
        }

        private void BtnFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FGridStatu == GridStatu.gsBrowse)
            {
                GV_Main.MoveFirst();
            }
        }

        private void BtnPrior_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FGridStatu == GridStatu.gsBrowse)
            {
                GV_Main.MovePrev();
            }
        }

        private void BtnNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FGridStatu == GridStatu.gsBrowse)
            {
                GV_Main.MoveNext();
            }
        }

        private void BtnLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FGridStatu == GridStatu.gsBrowse)
            {
                GV_Main.MoveLast();
            }
        }

        public virtual void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsSaveOK = true;
            if (FGridStatu == GridStatu.gsEdit || FGridStatu == GridStatu.gsAdd)
            {
                if (CheckRequiredField(GCNum.GCN_Main) && CheckRequiredField(GCNum.GCN_Body))
                {
                    DateTimeToStr();
                    GV_Main.PostEditor();
                    GV_Body.PostEditor();
                    if (DBUpdate(GCNum.GCN_Body) && DBUpdate(GCNum.GCN_Main))
                    {
                        GOFillBy(GCNum.GCN_Main);
                        GOFillBy(GCNum.GCN_Body);
                        //DBFillBy(GCNum.GCN_Main, " WHERE " + SelectKeyMain + "='" + GV_Main.GetFocusedRowCellValue(GV_Main.Columns[SelectKeyMain]).ToString() + "' ORDER BY " + OrderFieldMain);
                        //DBFillBy(GCNum.GCN_Body, " WHERE " + SelectKeyBody + "='" +
                        //    GV_Main.GetFocusedRowCellValue(GV_Main.Columns[SelectKeyMain]).ToString() +
                        //    "' ORDER BY " + OrderFieldBody);
                        if (FGridStatu == GridStatu.gsAdd)
                        {
                            GV_Main.FocusedRowHandle = GV_Main.RowCount - 1;
                        }

                        FGridStatu = GridStatu.gsBrowse;
                        GV_Body.OptionsBehavior.ReadOnly = true;
                        for (int i = 0; i < MainControls.Count; i++)
                        {
                            MainControls[i].Enabled = true;
                            MainControls[i].Properties.ReadOnly = true;
                        }

                        BtnNew.Enabled = IsCanNew;
                        BtnQuery.Enabled = true;
                        BtnEdit.Enabled = true;
                        BtnDel.Enabled = IsCanDel;
                        BtnFirst.Enabled = true;
                        BtnPrior.Enabled = true;
                        BtnNext.Enabled = true;
                        BtnLast.Enabled = true;
                        BtnSave.Enabled = false;
                        BtnCancel.Enabled = false;
                        btnAutoWidth.Enabled = true;
                        TabControlMain.Focus();
                    }
                    else
                    {
                        IsSaveOK = false;
                    }
                }
                else
                {
                   IsSaveOK = false;
                }
            }
            else
            {
                IsSaveOK = false;
            }
        }

        public virtual void BtnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FGridStatu != GridStatu.gsBrowse)
            {
                FGridStatu = GridStatu.gsBrowse;
                
                GV_Main.CancelUpdateCurrentRow();
                GV_Main.RefreshData();
                GV_Body.CancelUpdateCurrentRow();
                GV_Body.RefreshData();
                GV_Body.OptionsBehavior.ReadOnly = true;
              
                for (int i = 0; i < MainControls.Count;i++ )
                {
                    if (MainControls[i].Name.EndsWith("C"))
                    {
                        MainControls[i].Text = "";
                    }
                }

                if (GV_Main.RowCount > 0)
                {
                    GOFillBy(GCNum.GCN_Body);
                    //DBFillBy(GCNum.GCN_Body, " WHERE " + SelectKeyBody + "='" +
                    //GV_Main.GetRowCellValue(FocuseRow_Main, GV_Main.Columns[SelectKeyMain]).ToString() +
                    //"' ORDER BY " + OrderFieldBody);
                    BtnNew.Enabled = IsCanNew;
                    BtnQuery.Enabled = true;
                    BtnEdit.Enabled = true;
                    BtnDel.Enabled = IsCanDel;
                    BtnFirst.Enabled = true;
                    BtnPrior.Enabled = true;
                    BtnNext.Enabled = true;
                    BtnLast.Enabled = true;
                    BtnSave.Enabled = false;
                    BtnCancel.Enabled = false;
                    btnAutoWidth.Enabled = true;
                }
                else
                {
                    DBFillBy(GCNum.GCN_Body, " WHERE 1=2");
                    BtnNew.Enabled = IsCanNew;
                    BtnQuery.Enabled = true;
                    BtnEdit.Enabled = false;
                    BtnDel.Enabled = false;
                    BtnFirst.Enabled = false;
                    BtnPrior.Enabled = false;
                    BtnNext.Enabled = false;
                    BtnLast.Enabled = false;
                    BtnSave.Enabled = false;
                    BtnCancel.Enabled = false;
                    btnAutoWidth.Enabled = true;
                }

                for (int i = 0; i < MainControls.Count; i++)
                {
                    MainControls[i].Enabled = true;
                    MainControls[i].Properties.ReadOnly = true;
                }
            }
        }

        public virtual void GV_Body_KeyUP(object sender, KeyEventArgs e)
        {

        }

        public virtual void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (FGridStatu == GridStatu.gsAdd || FGridStatu == GridStatu.gsEdit)
            {
               e.Cancel = true;
            }
        }

        public virtual void GV_Body_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            FocuseRow_Body = e.FocusedRowHandle;
            if (FGridStatu != GridStatu.gsBrowse)
            {
               /* if (!CheckRequiredField(RootForm.GCNum.GCN_Body))
                {
                    GV_Body.FocusedRowHandle = e.PrevFocusedRowHandle;
                }
                else
                {    
                    if (GV_Body != null)
                    {
                        GV_Body.ShowEditor();
                        GV_Body.SelectAll();
                    }
                }*/
            }
        }

        public virtual void GV_Main_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            FocuseRow_Main = e.FocusedRowHandle;
            if (e.FocusedRowHandle >= 0)
            {
                if (SelectKeyMain.Trim() != "")
                {

                    if (SelectKeyMain.IndexOf(',') < 0)
                    {
                        FReFreshStr = " WHERE " + SelectKeyBody + "='" +
                                    GV_Main.GetRowCellValue(e.FocusedRowHandle, GV_Main.Columns[SelectKeyMain]).ToString() +
                                    "' ORDER BY " + OrderFieldBody;
                        DBFillBy(GCNum.GCN_Body, FReFreshStr);
                    }
                    else
                    {
                        string xSQL = " WHERE ";
                        string[] Main = SelectKeyMain.Split(',');
                        string[] Body = SelectKeyBody.Split(',');
                        for (int i = 0; i < Main.Length; i++)
                        {
                            if (i == Main.Length - 1)
                            {
                                xSQL += Body[i] + " ='" + GV_Main.GetRowCellValue(e.FocusedRowHandle, GV_Main.Columns[Main[i]]).ToString() + "' ";
                            }
                            else
                            {
                                xSQL += Body[i] + " ='" + GV_Main.GetRowCellValue(e.FocusedRowHandle, GV_Main.Columns[Main[i]]).ToString() + "' AND ";
                            }
                        }
                        FReFreshStr = xSQL + " ORDER BY " + OrderFieldBody;
                        DBFillBy(GCNum.GCN_Body, FReFreshStr);
                    }
                }
            }
            else
            {
                if (FGridStatu == GridStatu.gsAdd)
                {

                }
            }
        }
        private void GC_Body_KeyDown(object sender, KeyEventArgs e)
        {
            if (GV_Body.IsLastRow && FGridStatu != GridStatu.gsBrowse)
            {
                if (e.KeyData == Keys.Down)
                {
                    GV_Body.CloseEditor();
                    IsGCCHeck = true;
                    {
                        if (CheckRequiredField(RootForm.GCNum.GCN_Body))
                        {
                            {
                                IsCanCgangeRow = true;
                                GV_Body.AddNewRow();
                            }
                        }
                    }
                }
            }
        }
        public virtual void GV_Body_KeyDown(object sender, KeyEventArgs e)
        {
            IsKeyDownOK = true;
            if (FGridStatu != GridStatu.gsBrowse)
            {
                if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
                {
                    if (GV_Body.RowCount > 0 && FocuseRow_Body <= GV_Body.RowCount)
                    {
                        if (MessageBox.Show("確定要刪除此筆資料?", "詢問", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            GV_Body.DeleteRow(FocuseRow_Body);
                            GV_Body.RefreshData();
                        }
                    }
                }
                if (GV_Body.IsLastRow)
                {
                    if (e.KeyData == Keys.Down)
                    {
                        if (!IsGCCHeck)
                        {
                            GV_Body.CloseEditor();
                            {
                                if (CheckRequiredField(RootForm.GCNum.GCN_Body))
                                {
                                    if (GV_Body.IsLastRow)
                                    {
                                        IsCanCgangeRow = true;
                                        GV_Body.AddNewRow();
                                    }
                                }
                            }
                        }
                        IsGCCHeck = false;
                    }
                }
            }
            else
            {
                IsKeyDownOK = false;
            }
        }

        public virtual void GC_Body_MouseClick(object sender, MouseEventArgs e)
        {
            IsCheckRequired = true;
            if (FGridStatu != GridStatu.gsBrowse)
            {
                if (CheckRequiredField(GCNum.GCN_Main))
                {
                    GV_Body.OptionsBehavior.Editable = true;
                }

                if (GV_Body.RowCount == 0)
                {
                    GV_Body.AddNewRow();
                }        
            }
            else
            {
                IsCheckRequired = false;
            }
        }


        private void GV_Main_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            /*if (e.Button == MouseButtons.Right)
            {
                TabControlMain.SelectedTabPageIndex = 0;
            }*/
        }

        public virtual void GV_Body_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            if (FGridStatu != GridStatu.gsBrowse)
            {
                //ColumnView newview = (ColumnView)GC_Body.FocusedView;
                if (GV_Body != null)
                {
                    GV_Body.ShowEditor();
                    GV_Body.SelectAll();                
                }                
            }
        }

        public virtual void GC_Body_MouseDown(object sender, MouseEventArgs e)
        {

        }

        public void SortColumns(GCNum xNum,Dictionary<string, int> FDic)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv = GetGV(xNum);
            for (int i = 0; i < FDic.Count; i++)
            {
                KeyValuePair<string, int> dic = FDic.ElementAt(i);
                for (int j = 0; j < gv.Columns.Count; j++)
                {
                    if (dic.Key == gv.Columns[j].FieldName)
                    {
                        gv.Columns[j].VisibleIndex = dic.Value;
                        break;
                    }
                }
            }
        }

        public void WidthColumns(GCNum xNum, Dictionary<string, int> FDic)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv = GetGV(xNum);
            for (int i = 0; i < FDic.Count; i++)
            {
                KeyValuePair<string, int> dic = FDic.ElementAt(i);
                for (int j = 0; j < gv.Columns.Count; j++)
                {
                    if (dic.Key == gv.Columns[j].FieldName)
                    {
                        gv.Columns[j].Width = dic.Value;
                        break;
                    }
                }
            }
        }

        public virtual void F2FieldMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (GetGridStatu() != GridStatu.gsBrowse)
            {
                if (e.KeyData == Keys.F2)
                {
                    DevExpress.XtraEditors.ButtonEdit btn = (DevExpress.XtraEditors.ButtonEdit)sender;
                    if (F2FieldMain.Contains(btn.Name))
                    {
                        btn.PerformClick(btn.Properties.Buttons[0]);
                    }
                }
            }
        }

        private void GC_Body_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (FGridStatu != GridStatu.gsBrowse)
            {
                if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
                {
                    if (GV_Body.RowCount > 0 && FocuseRow_Body <= GV_Body.RowCount)
                    {
                        if (MessageBox.Show("確定要刪除此筆資料?", "詢問", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            GV_Body.DeleteRow(FocuseRow_Body);
                            GV_Body.RefreshData();
                        }
                    }
                }
                else if (e.KeyCode == Keys.F2)
                {
                    if (F2FieldBody.Contains(GV_Body.FocusedColumn.FieldName))
                    {
                        ButtonEdit edit = (GV_Body.ActiveEditor as ButtonEdit);
                        EditorButton eb = ((RepositoryItemButtonEdit)GV_Body.FocusedColumn.ColumnEdit).Buttons[0];
                        PerformClick(GV_Body.FocusedColumn.FieldName, edit, new ButtonPressedEventArgs(eb));
                    }
                }
            }
        }

        private void GC_Body_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }
        public virtual bool CheckRequiredField(GCNum xNum)
        {
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    //單頭
                    for (int i = 0; i < MainControls.Count; i++)
                    {
                        if (KeyListMain.Contains(MainControls[i].Name) || RequiredListMain.Contains(MainControls[i].Name))
                        {
                            Label edit = this.Controls.Find("LB" + MainControls[i].Name, true).FirstOrDefault() as Label;
                            if (MainControls[i].Text == "")
                            {
                                MessageBox.Show(edit.Text + " 不可空白!!", "錯誤");
                                MainControls[i].Focus();
                                IsCheckRequired = false;
                                return false;
                            }
                        }
                    }
                    break;
                case GCNum.GCN_Body:
                    //單身
                    if (RequiredFieldBody != "")
                    {
                        string[] mTemp = RequiredFieldBody.Split(',');
                        //ColumnView newview = (ColumnView)GC_Body.FocusedView;
                        if (GV_Body != null)
                        {
                            for (int i = 0; i < mTemp.Length; i++)
                            {
                                if (GV_Body.GetFocusedRowCellValue(mTemp[i]) != null)
                                {
                                    if (GV_Body.GetFocusedRowCellValue(mTemp[i]).ToString() == "")
                                    {
                                        IsCheckRequired = false;
                                        MessageBox.Show(GV_Body.Columns[mTemp[i]].GetTextCaption() + " 不可空白!", "錯誤");
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                    break;
            }                           
            return true;
        }

        public virtual void GV_Body_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {

        }

        public virtual void GV_Body_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            if (!IsCanCgangeRow)
            {
                return;
            }
            if (IsNowAddRow)
            {
                IsNowAddRow = false;
                return;
            }
            if (CheckRequiredField(RootForm.GCNum.GCN_Body))
            {
                IsValidEditor = true;
                e.Valid = true;
            }
            else
            {
                IsValidEditor = false;
                e.Valid = false;
            }
        }

        private void GV_Body_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void GV_Body_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void GV_Body_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == null) return;
            if (!KeyListBody.Contains(e.Column.FieldName) && !KeyListMain.Contains(e.Column.FieldName)) return;
            Rectangle rect = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height + 1);
            ControlPaint.DrawBorder3D(e.Graphics, e.Bounds);
            Brush brush =
                e.Cache.GetGradientBrush(rect, e.Column.AppearanceHeader.BackColor,
                e.Column.AppearanceHeader.BackColor2, e.Column.AppearanceHeader.GradientMode);
            rect.Inflate(-1, -1);
            // Fill column headers with the specified colors.
            e.Graphics.FillRectangle(brush, rect);
            e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect);
            // Draw the filter and sort buttons.
            foreach (DevExpress.Utils.Drawing.DrawElementInfo info in e.Info.InnerElements)
            {
                if (!info.Visible) continue;
                DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, info.ElementPainter,
                    info.ElementInfo);
            }
            e.Handled = true;
        }

        public virtual void GV_Body_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            IsNowAddRow = true;
            IsCanCgangeRow = false;
        }

        private void TabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            GOReSize();
        }

        public override void GOReSize()
        {
            switch (TabControlMain.SelectedTabPageIndex)
            {
                case 0:
                    TabControlMain.Height = TabControlMainHeight;
                    break;
                case 1:
                    TabControlMain.Height = this.Height / 2;
                    break;
            }
        }

        public void SetGroupSum(string xCountField,string xSumField)
        {
            // Make the group footers always visible.
            //GV_Body.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
            // Create and setup the first summary item.
            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = xCountField;
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "    數量:{0:n0}";
            GV_Body.GroupSummary.Add(item);
            // Create and setup the second summary item.
            GridGroupSummaryItem item1 = new GridGroupSummaryItem();
            item1.FieldName = xSumField;
            item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item1.DisplayFormat = " {0:c0}";
            GV_Body.GroupSummary.Add(item1);
        }
        public void DateTimeToStr()
        {
            Fieldformat[] mFieldGroup = new Fieldformat[] { DateFieldMain, TimeFieldMain, DateFieldBody, TimeFieldBody };
            for (int j = 0; j < mFieldGroup.Length; j++)
            {
                if (mFieldGroup[j].Fields == "" || mFieldGroup[j].Fields == null) continue;
                string[] mTemp = mFieldGroup[j].Fields.Split(',');
                GCNum mTableType = mFieldGroup[j].TableType;
                string mDateType = mFieldGroup[j].DateType;

                for (int i = 0; i < mTemp.Length; i++)
                {
                    if (mTableType == GCNum.GCN_Main)
                    {
                        {
                            DevExpress.XtraEditors.TextEdit tbx = this.Controls.Find(mTemp[i], true).FirstOrDefault() as DevExpress.XtraEditors.TextEdit;
                            if (tbx != null)
                            {
                                if (mDateType == "Date")
                                {
                                    tbx.EditValue = tbx.EditValue.ToString().Replace("/", "");
                                }
                                else if (mDateType == "Time")
                                {
                                    tbx.EditValue = tbx.EditValue.ToString().Replace(":", "");
                                }
                            }
                        }
                    }
                }
            }
        }

        public virtual void GV_Body_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        public virtual void GV_Body_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {

        }

        private void GOFillBy(GCNum xNum)
        {
            switch (xNum)
            {
                //DBFillBy(GCNum.GCN_Main, " WHERE " + SelectKeyMain + "='" + GV_Main.GetFocusedRowCellValue(GV_Main.Columns[SelectKeyMain]).ToString() + "' ORDER BY " + OrderFieldMain);
                case RootForm.GCNum.GCN_Main:
                    if (SelectKeyMain.Trim() != "")
                    {

                        if (SelectKeyMain.IndexOf(',') < 0)
                        {
                            DBFillBy(GCNum.GCN_Main, " WHERE " + SelectKeyMain + "='" +
                                        GV_Main.GetRowCellValue(GV_Main.FocusedRowHandle, GV_Main.Columns[SelectKeyMain]).ToString() +
                                        "' ORDER BY " + OrderFieldMain);
                        }
                        else
                        {
                            string xSQL = " WHERE ";
                            string[] Main = SelectKeyMain.Split(',');
                            for (int i = 0; i < Main.Length; i++)
                            {
                                if (i == Main.Length - 1)
                                {
                                    xSQL += Main[i] + " ='" + GV_Main.GetRowCellValue(GV_Main.FocusedRowHandle, GV_Main.Columns[Main[i]]).ToString() + "' ";
                                }
                                else
                                {
                                    xSQL += Main[i] + " ='" + GV_Main.GetRowCellValue(GV_Main.FocusedRowHandle, GV_Main.Columns[Main[i]]).ToString() + "' AND ";
                                }
                            }
                            DBFillBy(GCNum.GCN_Main, xSQL + " ORDER BY " + OrderFieldMain);
                        }
                    }
                    break;
                case RootForm.GCNum.GCN_Body:
                    if (SelectKeyMain.Trim() != "")
                    {

                        if (SelectKeyMain.IndexOf(',') < 0)
                        {
                            DBFillBy(GCNum.GCN_Body, " WHERE " + SelectKeyBody + "='" +
                                        GV_Main.GetRowCellValue(GV_Main.FocusedRowHandle, GV_Main.Columns[SelectKeyMain]).ToString() +
                                        "' ORDER BY " + OrderFieldBody);
                        }
                        else
                        {
                            string xSQL = " WHERE ";
                            string[] Main = SelectKeyMain.Split(',');
                            string[] Body = SelectKeyBody.Split(',');
                            for (int i = 0; i < Main.Length; i++)
                            {
                                if (i == Main.Length - 1)
                                {
                                    xSQL += Body[i] + " ='" + GV_Main.GetRowCellValue(GV_Main.FocusedRowHandle, GV_Main.Columns[Main[i]]).ToString() + "' ";
                                }
                                else
                                {
                                    xSQL += Body[i] + " ='" + GV_Main.GetRowCellValue(GV_Main.FocusedRowHandle, GV_Main.Columns[Main[i]]).ToString() + "' AND ";
                                }
                            }
                            DBFillBy(GCNum.GCN_Body, xSQL + " ORDER BY " + OrderFieldBody);
                        }
                    }
                    break;
            }
        }

        public virtual void GV_Body_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {

        }

        public virtual void GV_Body_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e)
        {

        }

        private void btnAutoWidth_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //WidthOutput();
            if (GetGridStatu() == GridStatu.gsBrowse)
            {
                GV_Main.BestFitColumns();
                GV_Body.BestFitColumns();
            }
        }

        [Conditional("DEBUG")]
        private void WidthOutput()
        {
            string mMain = "";
            for (int i = 0; i < GV_Main.Columns.Count; i++)
            {
                if (GV_Main.Columns[i].FieldName.StartsWith("X"))
                {
                    mMain += "FieldWidthMain.Add(\"" + GV_Main.Columns[i].FieldName + "\"," + GV_Main.Columns[i].Width + ");\r\n";
                }                
            }
            string mBody = "";
            for (int i = 0; i < GV_Body.Columns.Count; i++)
            {
                if (GV_Body.Columns[i].FieldName.StartsWith("X"))
                {
                    mBody += "FieldWidthBody.Add(\"" + GV_Body.Columns[i].FieldName + "\"," + GV_Body.Columns[i].Width + ");\r\n";
                }
            }
            ShowBosxMemo sbm = new ShowBosxMemo();
            sbm.SetMemo = mMain + "\r\n" +mBody;
            sbm.ShowDialog();
        }

        public void LeaveCheckMainFunc(BaseEdit xControl, string[] xADMMJ, string[] xParam, Dictionary<BaseControl, int> xReturnFileds)
        {
            try
            {
                f2.SetMJ = xADMMJ;
                f2.SetMJParam = xParam;
                if (f2.GetMJ)
                {
                    for (int i = 0; i < xReturnFileds.Count; i++)
                    {
                        KeyValuePair<BaseControl, int> kv = xReturnFileds.ElementAt(i);
                        kv.Key.Text = f2.GetReturn[kv.Value];
                    }
                }
                else
                {
                    xControl.Focus();
                    MessageBox.Show("找不到符合的資料", "錯誤");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                fc.ErrorLog(ex.Message);
            }
        }

        DateTime mouseDownTime = DateTime.MinValue;
        GridCell mouseDownCell = new GridCell(GridControl.InvalidRowHandle, null);
        TimeSpan DoubleClickInterval = new TimeSpan(0, 0, 0, 0, 400);
        private void GV_Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                GridHitInfo hi = GV_Main.CalcHitInfo(e.Location);
                if (hi == null || hi.Column == null)
                {
                    return;
                }
                if (hi.InRowCell)
                {
                    if (hi.RowHandle == mouseDownCell.RowHandle && hi.Column == mouseDownCell.Column && DateTime.Now -mouseDownTime < DoubleClickInterval)
                        DoRowDoubleClick(sender as GridView, e.Location);      
                }
                mouseDownCell = new GridCell(hi.RowHandle, hi.Column);
                mouseDownTime = DateTime.Now;
            }
        }
        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                TabControlMain.SelectedTabPageIndex = 0;
            }
        }

        BaseEdit inplaceEditor;
        private void GV_Main_ShownEditor(object sender, EventArgs e)
        {
            inplaceEditor = ((GridView)sender).ActiveEditor;
            inplaceEditor.DoubleClick += inplaceEditor_DoubleClick; 
        }

        private void GV_Main_HiddenEditor(object sender, EventArgs e)
        {
            if (inplaceEditor != null)
            {
                inplaceEditor.DoubleClick -= inplaceEditor_DoubleClick;
                inplaceEditor = null;
            }
        }
        private void inplaceEditor_DoubleClick(object sender, EventArgs e)
        {
            BaseEdit editor = (BaseEdit)sender;
            GridControl grid = (GridControl)editor.Parent;
            Point pt = grid.PointToClient(Control.MousePosition);
            GridView view = (GridView)grid.FocusedView;
            DoRowDoubleClick(view, pt);
        }
    }
}
