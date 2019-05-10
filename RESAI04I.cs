using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace COSMOS_RES
{
    public partial class RESAI04I : COSMOS_RES.RootForm
    {
        COSMOS_RES.DataSet.DS_RESAI04.POSXKDataTable xk = null;
        DataSet.DS_RESAI04TableAdapters.POSXKTableAdapter dt = null;
        BindingSource bs = null;
        List<string> FData = new List<string>();
        //List<fc.POSXKTable> FPOSXK = new List<fc.POSXKTable>();
        GridView FGV = null;
        DataTable FPOSXK = null;
        public RESAI04I()
        {
            InitializeComponent();
        }
        public List<string> DefaultData
        {
            set
            {
                FData = value;
            }
        }
        public GridView GetGV_POSXK
        {
            get
            {
                return FGV;
            }
        }
        public DataTable SetPOSXK
        {
            set
            {
                FPOSXK = value;
            }
            get
            {
                return FPOSXK;
            }
        }
        public COSMOS_RES.DataSet.DS_RESAI04.POSXKDataTable POSXK
        {
            set
            {
                xk = value;

            }
            get
            {
                return xk;
            }
        }
        public DataSet.DS_RESAI04TableAdapters.POSXKTableAdapter POSXKTA
        {
            set
            {
                dt = value;
            }
            get
            {
                return dt;
            }
        }
        public BindingSource POSXKBS
        {
            set
            {
                bs = value;
            }
            get
            {
                return bs;
            }
        }
        private void RESAI04I_Load(object sender, EventArgs e)
        {
            InitUIVar();
            GV_Main.Focus();
        }
        public void InitUIVar()
        {
            f2 = new F2Window(this);
            GC_Main.DataSource = FPOSXK;

            KeyFieldMain = "XK001,XK002,XK003,XK004,XK005,XK006";
            RequiredFieldMain = "XK001,XK002,XK003,XK004,XK005,XK006";
            KeyListMain = new List<string>(KeyFieldMain.Split(','));
            for (int i = 0; i < KeyListMain.Count; i++)
            {
                GV_Main.Columns[KeyListMain[i]].AppearanceHeader.BackColor = Color.FromArgb(88, 88, 88);
                GV_Main.Columns[KeyListMain[i]].AppearanceHeader.BackColor2 = Color.Gray;
                GV_Main.Columns[KeyListMain[i]].AppearanceHeader.ForeColor = Color.White;
                GV_Main.Columns[KeyListMain[i]].AppearanceHeader.BorderColor = Color.Black;
                GV_Main.Columns[KeyListMain[i]].AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            }

            var items2 = new[] { 
            new { Text = "1.口味",   Value = "1" }, 
            new { Text = "2.加料",   Value = "2" }};

            RepositoryItemLookUpEdit edit2 = new RepositoryItemLookUpEdit();
            GV_Main.Columns["XK005"].ColumnEdit = edit2;
            edit2.DisplayMember = "Text";
            edit2.ValueMember = "Value";
            edit2.DataSource = items2;
            edit2.EditValueChanging += edit2_EditValueChanging;

            ButtonFieldListBody.Add(new ButtonFieldFormat(GCNum.GCN_Body, "", "XK006", this.XK006ButtonEdit_ButtonClick));
            SetButtonEditField();
        }

        void edit2_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (e.OldValue != e.NewValue)
            {
                GV_Main.SetFocusedRowCellValue("XK006", "");
                GV_Main.SetFocusedRowCellValue("XK006C", "");
                GV_Main.SetFocusedRowCellValue("XH004", 0);
            }            
        }

        private void XK006ButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            //if (GetGridStatu() != BaseForm.GridStatu.gsBrowse)
            {
                int mRowHandle = GV_Main.FocusedRowHandle;
                string mType = GV_Main.GetFocusedRowCellValue("XK005").ToString();
                f2.SetMI = new string[] { "POSXH", "002" };
                //f2.SetMIParam = new string[] { GV_Main.GetFocusedRowCellValue("XK005").ToString(), FData[3], FData[4], FData[3], FData[4] };
                //f2.SetMIParam = new string[] { FData[3], FData[4], FData[5], FData[4], FData[5] };
                f2.SetMIParam = new string[] {mType, FData[3], FData[4], FData[5] };
                f2.SetMuity = true;
                Dictionary<int, List<string>> muity = null;
                if (f2.GetMI)
                {
                    muity = f2.GetMuity;
                    bool IsExist = false;
                    bool IsFirst = true;
                    foreach (KeyValuePair<int, List<string>> s in muity)
                    {
                        for (int i = 0; i < GV_Main.RowCount; i++)
                        {
                            int idx = GV_Main.GetRowHandle(i);
                            if ((GV_Main.GetRowCellValue(idx, "XK006") == null))
                            {
                                IsExist = false;
                                break;
                            }
                            if (GV_Main.GetRowCellValue(idx, "XK006").ToString() == s.Value[0])
                            {
                                if (GV_Main.GetRowCellValue(idx, "XK005").ToString() == mType)
                                {
                                    if (idx == mRowHandle)
                                    {
                                        IsFirst = false;
                                    }
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
                                GV_Main.AddNewRow();
                            }
                            int mIndex = GV_Main.RowCount;
                            GV_Main.SetFocusedRowCellValue("XK001", FData[0]);
                            GV_Main.SetFocusedRowCellValue("XK002", FData[1]);
                            GV_Main.SetFocusedRowCellValue("XK003", FData[2]);
                            GV_Main.SetFocusedRowCellValue("XK004", string.Format("{0:0000}", mIndex));
                            GV_Main.SetFocusedRowCellValue("XK005", mType);
                            GV_Main.SetFocusedRowCellValue("XK006", s.Value[0]);
                            GV_Main.SetFocusedRowCellValue("XK006C", s.Value[1]);
                            GV_Main.SetFocusedRowCellValue("XH004", s.Value[2]);
                            GV_Main.UpdateCurrentRow();
                        }
                    }
                }
            }    
        }

        public void SetButtonEditField()
        {
            for (int i = 0; i < ButtonFieldListBody.Count; i++)
            {
                if (ButtonFieldListBody[i].Field == "" || ButtonFieldListBody[i].Field == null) continue;
                GCNum mTableType = ButtonFieldListBody[i].TableType;
                GV_Main.Columns[ButtonFieldListBody[i].Field].ColumnEdit = ButtonFieldListBody[i];
                F2FieldBody.Add(ButtonFieldListBody[i].Field);
            }
        }


        private void RESAI04I_FormClosing(object sender, FormClosingEventArgs e)
        {
            FGV = GV_Main;
        }

        private void GV_Main_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GV_Main.FocusedColumn = GV_Main.Columns["XK006"];//定位焦点网格的位置 
            FocuseRow_Main = GV_Main.FocusedRowHandle;//获取新焦点行的FocuseRowHandle并初始化全局变量
            GV_Main.ShowEditor();
            GV_Main.SetFocusedRowCellValue("XK001", FData[0]);
            GV_Main.SetFocusedRowCellValue("XK002", FData[1]);
            GV_Main.SetFocusedRowCellValue("XK003", FData[2]);
            int idx = GV_Main.RowCount ;
            GV_Main.SetFocusedRowCellValue("XK004", string.Format("{0:0000}", idx));
            GV_Main.SetFocusedRowCellValue("XK005", "1");
            GV_Main.SetFocusedRowCellValue("XH004", 0);
            IsNowAddRow = true;
            //GV_Main.UpdateCurrentRow();
        }

        private void GC_Main_MouseClick(object sender, MouseEventArgs e)
        {
            if (GV_Main.RowCount == 0)
            {
                GV_Main.AddNewRow();
            }
        }

        private void GC_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (GV_Main.IsLastRow)
            {
                if (e.KeyData == Keys.Down)
                {
                    GV_Main.CloseEditor();
                    IsGCCHeck = true;
                    {
                        if (CheckRequiredField())
                        {
                            {
                                GV_Main.AddNewRow();
                            }
                        }
                    }
                }
            }
        }

        private void GV_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (GV_Main.RowCount > 0 && FocuseRow_Main <= GV_Main.RowCount)
                {
                    if (MessageBox.Show("確定要刪除此筆資料?", "詢問", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        IsNowDeleteRow = true;
                        GV_Main.DeleteRow(FocuseRow_Main);
                        GV_Main.RefreshData();
                    }
                }
            }
            if (GV_Main.IsLastRow)
            {
                if (e.KeyData == Keys.Down)
                {
                    if (!IsGCCHeck)
                    {
                        GV_Main.CloseEditor();
                        {
                            if (CheckRequiredField())
                            {
                                if (GV_Main.IsLastRow)
                                {
                                    GV_Main.AddNewRow();
                                }
                            }
                        }
                    }
                    IsGCCHeck = false;
                }
            }
        }

        private void GC_Main_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (GV_Main.RowCount > 0 && FocuseRow_Main <= GV_Main.RowCount)
                {
                    if (MessageBox.Show("確定要刪除此筆資料?", "詢問", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        IsNowDeleteRow = true;
                        GV_Main.DeleteRow(FocuseRow_Main);
                        GV_Main.RefreshData();
                    }
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                if (F2FieldBody.Contains(GV_Main.FocusedColumn.FieldName))
                {
                    ButtonEdit edit = (GV_Main.ActiveEditor as ButtonEdit);
                    EditorButton eb = ((RepositoryItemButtonEdit)GV_Main.FocusedColumn.ColumnEdit).Buttons[0];
                    PerformClick(GV_Main.FocusedColumn.FieldName, edit, new ButtonPressedEventArgs(eb));
                }
            }
        }

        private void GV_Main_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            FocuseRow_Main = e.FocusedRowHandle;
        }

        private void RESAI04I_Shown(object sender, EventArgs e)
        {
            if (GV_Main.RowCount == 0)
            {
                GV_Main.AddNewRow();
            }
        }

        private void GV_Main_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
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
        public virtual bool CheckRequiredField()
        {
            if (IsNowDeleteRow)
            {
                IsNowDeleteRow = false;
                return true;
            }

            if (RequiredFieldMain != "")
            {
                string[] mTemp = RequiredFieldMain.Split(',');
                if (GV_Main != null)
                {
                    for (int i = 0; i < mTemp.Length; i++)
                    {
                        if (GV_Main.GetFocusedRowCellValue(mTemp[i]) != null)
                        {
                            if (GV_Main.GetFocusedRowCellValue(mTemp[i]).ToString() == "")
                            {
                                IsCheckRequired = false;
                                MessageBox.Show(GV_Main.Columns[mTemp[i]].GetTextCaption() + " 不可空白!", "錯誤");
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        private void GV_Main_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            if (IsNowAddRow)
            {
                IsNowAddRow = false;
                return;
            }
            if (CheckRequiredField())
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

        private void GV_Main_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void GV_Main_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void RESAI04I_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnOK.PerformClick();
            }
            else if (e.KeyData == Keys.Escape)
            {
                btnCancel.PerformClick();
            }
        }

    }
}
