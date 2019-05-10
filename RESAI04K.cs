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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace COSMOS_RES
{
    public partial class RESAI04K : COSMOS_RES.RootForm
    {
        string[] KeyValue = new string[2];
        List<List<string>> SelectList = new List<List<string>>();
        public RESAI04K()
        {
            InitializeComponent();
        }

        public string[] SetKey
        {
            set
            {
                KeyValue = value;
            }
        }
        public bool SetCanSelect
        {
            set
            {
                if (!value)
                {
                    GV_Main.Columns[0].VisibleIndex = -1;
                }
            }
        }
        public List<List<string>> GetReturn
        {
            get
            {
                return SelectList;
            }
        }
        private void RESAI04K_Load(object sender, EventArgs e)
        {
            pOSXRTableAdapter.Fill(dS_RESAI04.POSXR, KeyValue[0]);
            DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit edit = (DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit)GV_Main.Columns["Selected"].ColumnEdit;            
            edit.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(QueryCheckStateByValue);

            ButtonFieldListBody.Add(new ButtonFieldFormat(GCNum.GCN_Body, "", "XR006", this.XR006ButtonEdit_ButtonClick));
            SetButtonEditField();
        }

        private void XR006ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            RESAI04L ai04l = new RESAI04L();
            ai04l.SetKey = new string[] { KeyValue[0], GV_Main.GetFocusedRowCellValue("XB002").ToString()};
            ai04l.ShowDialog();
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

        private void InitComboBoxEdit()
        {
            for (int i = 0; i < GV_Main.RowCount;i++ )
            {
                int idx = GV_Main.GetRowHandle(i);
                string mXB007 = "["+GV_Main.GetRowCellValue(idx, "XB007").ToString() +"] " +GV_Main.GetRowCellValue(idx, "XB007C").ToString();

                if (!cbo01.Properties.Items.Contains(mXB007))
                {
                    cbo01.Properties.Items.Add(mXB007);
                }
            }

            if (cbo01.Properties.Items.Count > 0)
            {
                cbo01.SelectedIndex = 0;
            }
        }

        private void GV_Main_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo hitInfo = GV_Main.CalcHitInfo(e.Location);
            if (hitInfo == null || hitInfo.Column == null)
            {
                return;
            }
            if (hitInfo.InRowCell)
            {
                if (hitInfo.Column.RealColumnEdit is RepositoryItemCheckEdit)
                {
                    GV_Main.FocusedColumn = hitInfo.Column;
                    GV_Main.FocusedRowHandle = hitInfo.RowHandle;
                    GV_Main.ShowEditor();
                    CheckEdit edit = GV_Main.ActiveEditor as CheckEdit;
                    if (edit == null) return;
                    edit.Toggle();
                    DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                    GV_Main.CloseEditor();
                }
                else if (hitInfo.Column.RealColumnEdit is RepositoryItemButtonEdit)
                {
                    GC_Main.Enabled = false;
                    GV_Main.FocusedColumn = hitInfo.Column;
                    GV_Main.FocusedRowHandle = hitInfo.RowHandle;
                    GV_Main.ShowEditor();
                    ButtonEdit edit = (GV_Main.ActiveEditor as ButtonEdit);
                    EditorButton eb = ((RepositoryItemButtonEdit)GV_Main.FocusedColumn.ColumnEdit).Buttons[0];
                    PerformClick(GV_Main.FocusedColumn.FieldName, edit, new ButtonPressedEventArgs(eb));
                    GV_Main.CloseEditor();
                    DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                    GC_Main.Enabled = true;
                }
                
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GV_Main.RowCount;i++ )
            {
                if (GV_Main.GetRowCellValue(i, "Selected").ToString() == "Y")
                {
                    List<string> ls = new List<string>() { "T",
                        GV_Main.GetRowCellValue(i, "XB007").ToString(), GV_Main.GetRowCellValue(i, "XB007C").ToString() ,
                    GV_Main.GetRowCellValue(i, "XB002").ToString(), GV_Main.GetRowCellValue(i, "XB003").ToString(),
                    GV_Main.GetRowCellValue(i, "XB004").ToString()};
                    SelectList.Add(ls);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GV_Main.RowCount; i++)
            {
                GV_Main.SetRowCellValue(i, "Selected", "Y");
            }  
        }

        private void btnUnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GV_Main.RowCount; i++)
            {
                GV_Main.SetRowCellValue(i, "Selected", "N");
            }   
        }

        private void cbo01_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mXB007 =GetXB007();
            if (mXB007 != "")
            {
                GV_Main.ActiveFilterEnabled = false;
                GV_Main.ActiveFilterString = "[XB007]='" + mXB007 + "'";
                GV_Main.ActiveFilterEnabled = true;
            }           
        }
        private string GetXB007()
        {
            string mXB007 = "";
            if (cbo01.SelectedIndex >= 0)
            {
                string[] mTmp = cbo01.Text.Split(']');
                if (mTmp.Length > 0)
                {
                    mXB007 = mTmp[0].Substring(1, mTmp[0].Length - 1);
                }
            }
            return mXB007;
        }
        private void RESAI04K_Shown(object sender, EventArgs e)
        {
            InitComboBoxEdit();
        }

        private void GV_Main_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
  
        }

        private void GV_Main_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "XR005")
            {
                if (GV_Main.GetRowCellValue(e.RowHandle, "XR005") != null)
                {
                    Bitmap img = new Bitmap(Properties.Resources.Grades0);
                    Bitmap img2 = null;
                    float mGrade = float.Parse(GV_Main.GetRowCellValue(e.RowHandle, "XR005").ToString());
                    if (mGrade >= 0)
                    {
                        img2 = new Bitmap(Properties.Resources.Grades50);
                    }
                    else
                    {
                        img2 = new Bitmap(Properties.Resources.Grades_50);
                    }
                    mGrade = Math.Abs(mGrade);
                    int mXR005 = (int)(mGrade / 5 * 160);
                    //int mXR005 = (int)(float.Parse(GV_Main.GetRowCellValue(e.RowHandle, "XR005").ToString()) / 5 * 160);
                    Graphics g = Graphics.FromImage(img);
                    g.DrawImage(img2, new Rectangle(0, 0, mXR005, 32), new Rectangle(0, 0, mXR005, 32), GraphicsUnit.Pixel);
                    e.Cache.Paint.DrawImage(e.Graphics, img, new Rectangle(e.Bounds.X, e.Bounds.Y, 160, 32));
                    e.Handled = true;
                }                
            }
        }

        
    }
}
