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
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
                             
namespace COSMOS_RES     
{                            
    public partial class SingleForm : RootForm
    {
        public void SetDateTimeField()
        {
            Fieldformat[] mFieldGroup = new Fieldformat[] { DateFieldMain, TimeFieldMain };
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
                                tbx.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
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
            Fieldformat[] mFieldGroup = new Fieldformat[] { CheckFieldMain };
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
            Fieldformat[] mFieldGroup = new Fieldformat[] { NumberFieldMain };
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
        }

        public void SetButtonEditField()
        {
            for (int i = 0; i < ButtonFieldListMain.Count; i++)
            {
                ((ButtonEdit)ButtonFieldListMain[i]).Properties.ButtonsStyle = BorderStyles.UltraFlat;
                ((ButtonEdit)ButtonFieldListMain[i]).Properties.Buttons[0].Width = 15;
                F2FieldMain.Add(ButtonFieldListMain[i].Name);
            }

        }

        public void SetPassWordEditField()
        {
            Fieldformat[] mFieldGroup = new Fieldformat[] { PassWordFieldMain };
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

        public SingleForm()
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
            BtnNew.Enabled = true;
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
            KeyListMain = new List<string>(KeyFieldMain.Split(','));
            RequiredListMain = new List<string>(RequiredFieldMain.Split(','));
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

            if (VisibleFieldMain.Trim() != "")
            {
                string[] mTemp = VisibleFieldMain.Split(',');
                for (int i = 0; i < mTemp.Count(); i++)
                {
                    GV_Main.Columns[mTemp[i]].Visible = false;
                }
            }

            for (int i = 0; i < GV_Main.Columns.Count;i++ )
            {
                GV_Main.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            for (int i = 0; i < MainControls.Count; i++)
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

            WidthColumns(GCNum.GCN_Main, FieldWidthMain);
            SortColumns(GCNum.GCN_Main, VisibleListMain);
        }
        public override DevExpress.XtraGrid.GridControl GetGC(GCNum xGCNum)
        {
            switch (xGCNum)
            {
                case GCNum.GCN_Main:
                    return GC_Main;                    
            }
            return null;
        }
        public override DevExpress.XtraGrid.Views.Grid.GridView GetGV(GCNum xGCNum)
        {
            switch (xGCNum)
            {
                case GCNum.GCN_Main:
                    return GV_Main;
            }
            return null;
        }
        protected virtual void BindingData()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //SetDBInfo("10.40.31.89", "RESLeader", "sa", "123");
            // TODO: 這行程式碼會將資料載入 'rESLeaderDataSet.POSXA' 資料表。您可以視需要進行移動或移除。
            //this.pOSXATableAdapter.Fill(this.rESLeaderDataSet.POSXA);
            //this.pOSXBTableAdapter.Fill(this.rESLeaderDataSet.POSXB,"");
            //SetDBInfo();
            //QueryMain("SELECT * FORM POSXA", DBInfo);
        }
        public virtual void DBFillBy(GCNum xNum,string xStr)
        {
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    for (int i = GV_Main.Columns.Count - 1; i >= 0; i--)
                    {
                        if (VisibleListMain.ContainsKey(GV_Main.Columns[i].FieldName))
                        {
                            GV_Main.Columns[i].VisibleIndex = VisibleListMain[GV_Main.Columns[i].FieldName];
                        }
                    }
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

                for (int i = 0; i < MainControls.Count; i++)
                {
                    MainControls[i].Properties.ReadOnly = false;
                }

                DBFillBy(GCNum.GCN_Main, " WHERE 1=2");
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
                    BtnNew.Enabled = true;
                    BtnQuery.Enabled = true;
                    BtnEdit.Enabled = true;
                    BtnDel.Enabled = true;
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
                for (int i = 0; i < MainControls.Count; i++)
                {
                    if (KeyListMain.Contains(MainControls[i].Name))
                    {
                        MainControls[i].Enabled = false;
                        continue;
                    }
                    MainControls[i].Properties.ReadOnly = false;
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
                        GV_Main.DeleteSelectedRows();
                        GV_Main.RefreshData();
                        DBUpdate(GCNum.GCN_Main);

                        GC_Main.Refresh();
                        FGridStatu = GridStatu.gsBrowse;

                        BtnNew.Enabled = true;
                        BtnQuery.Enabled = true;
                        BtnEdit.Enabled = true;
                        BtnDel.Enabled = true;
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
            if (FGridStatu == GridStatu.gsEdit || FGridStatu == GridStatu.gsAdd)
            {
                //CheckMainField();
                if (!CheckRequiredField())
                {
                    return;
                }
                DateTimeToStr();
                GV_Main.PostEditor();
                if (DBUpdate(GCNum.GCN_Main))
                {
                    if (FGridStatu == GridStatu.gsAdd)
                    {
                        GV_Main.FocusedRowHandle = GV_Main.RowCount - 1;
                    }

                    FGridStatu = GridStatu.gsBrowse;

                    for (int i = 0; i < MainControls.Count; i++)
                    {
                        MainControls[i].Enabled = true;
                        MainControls[i].Properties.ReadOnly = true;
                    }

                    BtnNew.Enabled = true;
                    BtnQuery.Enabled = true;
                    BtnEdit.Enabled = true;
                    BtnDel.Enabled = true;
                    BtnFirst.Enabled = true;
                    BtnPrior.Enabled = true;
                    BtnNext.Enabled = true;
                    BtnLast.Enabled = true;
                    BtnSave.Enabled = false;
                    BtnCancel.Enabled = false;
                    btnAutoWidth.Enabled = true;
                    IsCheckRequired = true;
                    TabControlMain.Focus();
                }
            }
        }
        
        public virtual void BtnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FGridStatu != GridStatu.gsBrowse)
            {
                FGridStatu = GridStatu.gsBrowse;
                GV_Main.CancelUpdateCurrentRow();
                GV_Main.RefreshData();

                for (int i = 0; i < MainControls.Count; i++)
                {
                    if (MainControls[i].Name.EndsWith("C"))
                    {
                        MainControls[i].Text = "";
                    }
                }

                if (GV_Main.RowCount > 0)
                {
                    BtnNew.Enabled = true;
                    BtnQuery.Enabled = true;
                    BtnEdit.Enabled = true;
                    BtnDel.Enabled = true;
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
                    BtnNew.Enabled = true;
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

        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            if (FGridStatu == GridStatu.gsAdd || FGridStatu == GridStatu.gsEdit)
            {
               e.Cancel = true;
            }
        }

        private void BaseForm_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void BaseForm_SizeChanged(object sender, EventArgs e)
        {

        }

        public virtual void GV_Main_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            FocuseRow_Main = e.FocusedRowHandle;
        }

        private void GV_Main_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TabControlMain.SelectedTabPageIndex = 0;
            }
        }
        private bool CheckRequiredField()
        {
            /*if (RequiredFieldMain != "")
            {
                string[] mTemp = RequiredFieldMain.Split(',');
                for (int i = 0; i < mTemp.Length; i++)
                {
                    DevExpress.XtraEditors.BaseEdit edit = this.Controls.Find(mTemp[i], true).FirstOrDefault() as DevExpress.XtraEditors.BaseEdit;
                    if (edit != null)
                    {
                        if (edit.Text == "")
                        {
                            Label lb = this.Controls.Find("LB" + mTemp[i], true).FirstOrDefault() as Label;
                            MessageBox.Show(lb.Text + " 不可空白!", "錯誤");
                            IsCheckRequired = false;
                            return false;
                        }
                    }
                }
            }
            return true;*/
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
            return true;
        }

        private void GV_Main_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == null) return;
            if (!KeyListMain.Contains(e.Column.FieldName)) return;
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
        public void SortColumns(GCNum xNum, Dictionary<string, int> FDic)
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
                                    tbx.Text = tbx.Text.Replace("/", "");
                                }
                                else if (mDateType == "Time")
                                {
                                    tbx.Text = tbx.Text.Replace(":", "");
                                }
                            }
                        }
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

        private void btnAutoWidth_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //WidthOutput();
            if (GetGridStatu() == GridStatu.gsBrowse)
            {
                GV_Main.BestFitColumns();
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

        [Conditional("DEBUG")]
        private void WidthOutput()
        {
            string mMain = "";
            for (int i = 0; i < GV_Main.Columns.Count; i++)
            {
                mMain += "FieldWidthMain.Add(\"" + GV_Main.Columns[i].FieldName + "\"," + GV_Main.Columns[i].Width + ");\r\n";
            }
            ShowBosxMemo sbm = new ShowBosxMemo();
            sbm.SetMemo = mMain;
            sbm.ShowDialog();
        }

        public virtual void GV_Main_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {

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
                    if (hi.RowHandle == mouseDownCell.RowHandle && hi.Column == mouseDownCell.Column && DateTime.Now - mouseDownTime < DoubleClickInterval)
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
