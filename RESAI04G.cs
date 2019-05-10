using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace COSMOS_RES
{
    public partial class RESAI04G : COSMOS_RES.RootForm
    {
        string[] KeyValue = new string[2];
        List<List<string>> SelectList = new List<List<string>>();
        public RESAI04G()
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

        private void RESAI04G_Load(object sender, EventArgs e)
        {
            rESAI04_FavoriteTableAdapter.Fill(dS_RESAI04.RESAI04_Favorite, KeyValue[0], KeyValue[1]);
            DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit edit = (DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit)GV_Main.Columns["Selected"].ColumnEdit;
            edit.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(QueryCheckStateByValue);
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

        private void RESAI04G_KeyUp(object sender, KeyEventArgs e)
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

        private void GV_Main_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "XR005")
            {
                if (GV_Main.GetRowCellValue(e.RowHandle, "XR005") != null)
                {
                    Bitmap img = new Bitmap(Properties.Resources.Grades0);
                    Bitmap img2 = null;
                    float mGrade = 0;
                    float.TryParse(GV_Main.GetRowCellValue(e.RowHandle, "XR005").ToString(), out mGrade);
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
