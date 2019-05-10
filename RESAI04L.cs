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
    public partial class RESAI04L : COSMOS_RES.RootForm
    {
        string[] KeyValue = new string[2];
        public RESAI04L()
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

        private void RESAI04H_Load(object sender, EventArgs e)
        {
            pOSXR2TableAdapter.Fill(dS_RESAI04.POSXR2, KeyValue[0], KeyValue[1]);
        }

        private void GV_Main_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo hitInfo = GV_Main.CalcHitInfo(e.Location);
            if (hitInfo == null || hitInfo.Column == null)
            {
                return;
            }
            if (hitInfo.Column.FieldName == "XR006")
            {
                GV_Main.FocusedColumn = hitInfo.Column;
                GV_Main.FocusedRowHandle = hitInfo.RowHandle;
                //GV_Main.ShowEditor();                
                ShowBosxMemo sbm = new ShowBosxMemo();
                sbm.SetMemo = GV_Main.GetRowCellValue(hitInfo.RowHandle,"XR006").ToString();
                sbm.ShowDialog();
                DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                //GV_Main.CloseEditor();
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

        //SetMemo
        
    }
}
