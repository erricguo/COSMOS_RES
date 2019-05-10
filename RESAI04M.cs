using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace COSMOS_RES
{
    public partial class RESAI04M : COSMOS_RES.RootForm
    {
        string[] KeyValue = new string[2];
        public RESAI04M()
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
            pOSXR3TableAdapter.Fill(dS_RESAI04.POSXR3, fc.FUser.ID);
        }

        private void GV_Main_MouseDown(object sender, MouseEventArgs e)
        {
            GridHitInfo hitInfo = GV_Main.CalcHitInfo(e.Location);
            if (hitInfo == null || hitInfo.Column == null)
            {
                return;
            }
            if (hitInfo.Column.FieldName == "XR005")
            {
                GridViewInfo info = (GridViewInfo)GV_Main.GetViewInfo();
                if (info != null)
                {
                    GridCellInfo cell = info.GetGridCellInfo(hitInfo.RowHandle, hitInfo.Column);
                    if (cell != null)
                    {
                        int mGrade = ((e.X - cell.Bounds.X) / 32)+1;
                        if (e.Button == MouseButtons.Right)
                        {
                            mGrade = mGrade * -1;
                        }
                        GV_Main.SetRowCellValue(hitInfo.RowHandle, "XR005", mGrade);
                        DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                    }                    
                }
            }
            else if (hitInfo.Column.FieldName == "XR006")
            {
                GV_Main.FocusedColumn = hitInfo.Column;
                GV_Main.FocusedRowHandle = hitInfo.RowHandle;            
                ShowBosxMemo sbm = new ShowBosxMemo();
                sbm.SetCanEdit = true;
                sbm.SetMemo = GV_Main.GetRowCellValue(hitInfo.RowHandle,"XR006").ToString();
                if (sbm.ShowDialog() == DialogResult.OK)
                {
                    GV_Main.SetRowCellValue(hitInfo.RowHandle, "XR006", sbm.GetReturn);
                }
                DXMouseEventArgs.GetMouseArgs(e).Handled = true;
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
                    Graphics g = Graphics.FromImage(img);
                    g.DrawImage(img2, new Rectangle(0, 0, mXR005, 32), new Rectangle(0, 0, mXR005, 32), GraphicsUnit.Pixel);
                    e.Cache.Paint.DrawImage(e.Graphics, img, new Rectangle(e.Bounds.X, e.Bounds.Y, 160, 32));
                    e.Handled = true;
                    
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string mNo = "";
            string mSQL = "";
            string mXR001 = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT MAX(XR001) AS XR001 FROM POSXR ", conn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                mXR001 = dr["XR001"].ToString();
                            }
                        }
                    }


                    if (mXR001 != "")
                    {
                        mNo = "S" + DateTime.Now.ToString("yyyyMMdd") + fc.ZeroatFirst((Int32.Parse(mXR001.Substring(9, mXR001.Length - 9)) + 1), 4);
                    }
                    else
                        mNo = "S" + DateTime.Now.ToString("yyyyMMdd") + "0001";

                    mSQL = "SELECT XR001 FROM POSXR WHERE XR001='" + mNo + "'";
                    for (int i = 0; i < GV_Main.RowCount; i++)
                    {
                        while (!ValidMaxNo(mSQL))
                        {
                            mNo = mNo.Substring(0, 9) + fc.ZeroatFirst((Int32.Parse(mNo.Substring(9, mNo.Length - 9)) + 1), 4);
                            mSQL = "SELECT XR001 FROM POSXR WHERE XR001='" + mNo + "'";
                        }
                        int mHandle = GV_Main.GetRowHandle(i);
                        float mXR005 = 0;
                        float.TryParse(GV_Main.GetRowCellValue(mHandle, "XR005").ToString(), out mXR005);
                        if (mXR005==0)
                        {
                            continue;
                        }
                        string mSQL2 = "INSERT INTO POSXR (XR001,XR002,XR003,XR004,XR005,XR006) VALUES(@XR001,@XR002,@XR003,@XR004,@XR005,@XR006)";
                        using (SqlCommand cmd = new SqlCommand(mSQL2, conn))
                        {
                            cmd.Parameters.AddWithValue("@XR001", mNo);
                            cmd.Parameters.AddWithValue("@XR002", GV_Main.GetRowCellValue(mHandle, "XF002").ToString());
                            cmd.Parameters.AddWithValue("@XR003", GV_Main.GetRowCellValue(mHandle, "XG002").ToString());
                            cmd.Parameters.AddWithValue("@XR004", fc.FUser.ID);
                            cmd.Parameters.AddWithValue("@XR005", GV_Main.GetRowCellValue(mHandle, "XR005").ToString());
                            cmd.Parameters.AddWithValue("@XR006", GV_Main.GetRowCellValue(mHandle, "XR006").ToString());
                            cmd.ExecuteNonQuery();
                        }
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
}
