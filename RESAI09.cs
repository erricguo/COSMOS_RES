using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COSMOS_RES.DataSet;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace COSMOS_RES
{
    public partial class RESAI09 : COSMOS_RES.SingleForm
    {
        List<SimpleButton> SBtnList = new List<SimpleButton>();
        bool IsGood = true;
        public RESAI09()
        {
            InitializeComponent();
        }
        private void RESAI09_Load(object sender, EventArgs e)
        {
            InitUIVar();
        }
        public override void InitUIVar()
        {
            f2 = new F2Window(this);
            GC_Main.DataSource = pOSXRBindingSource;
            SBtnList.Add(btnStar1);
            SBtnList.Add(btnStar2);
            SBtnList.Add(btnStar3);
            SBtnList.Add(btnStar4);
            SBtnList.Add(btnStar5);

            MainControls.Add(XR001);
            MainControls.Add(XR002);
            MainControls.Add(XR003);
            MainControls.Add(XR004);
            //MainControls.Add(XR005);
            MainControls.Add(XR006);
     
            KeyFieldMain = "XR001,XR002,XR003";
            ReadOnlyFieldMain = "XR001";
            RequiredFieldMain = "XR004";
            OrderFieldMain = "XR001,XR002,XR003";
            NumberFieldMain.Fields = "XR005";

            ButtonFieldListMain.Add(XR002);
            ButtonFieldListMain.Add(XR003);
            ButtonFieldListMain.Add(XR004);

            VisibleListMain.Add("XR001", 0);
            VisibleListMain.Add("XR002", 1);
            VisibleListMain.Add("XR002C", 2);
            VisibleListMain.Add("XR003", 3);
            VisibleListMain.Add("XR003C", 4);
            VisibleListMain.Add("XR004", 5);
            VisibleListMain.Add("XR004C", 6);
            VisibleListMain.Add("XR005", 7);
            VisibleListMain.Add("XR006", 8);

            FieldWidthMain.Add("XR001", 133);
            FieldWidthMain.Add("XR002", 86);
            FieldWidthMain.Add("XR003", 86);
            FieldWidthMain.Add("XR004", 70);
            FieldWidthMain.Add("XR005", 163);
            FieldWidthMain.Add("XR006", 622);
            FieldWidthMain.Add("XR002C", 183);
            FieldWidthMain.Add("XR003C", 204);
            FieldWidthMain.Add("XR004C", 102);
            GV_Main.Columns["XR005"].MinWidth = 163;
            GV_Main.Columns["XR005"].MaxWidth = 163;
            GV_Main.RowHeight = 32;

            DS_RESAI09.POSXRDataTable dataTable = pOSXRTableAdapter.GetDataBy("");
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
            /*RepositoryItemTextEdit edit = new RepositoryItemTextEdit();
            GV_Main.Columns["XC009"].ColumnEdit = edit;
            edit.DisplayFormat.FormatType = FormatType.Custom;
            edit.DisplayFormat.FormatString = "XC009";
            edit.DisplayFormat.Format = new AI02Formatter();*/

            XR002C.Text = "";
            XR003C.Text = "";
            XR004C.Text = "";
            LBGrade.Text = "";

            base.InitUIVar();
        }
        public override void DBFillBy(SingleForm.GCNum xNum, string xStr)
        {
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    pOSXRTableAdapter.FillBy(dS_RESAI09.POSXR, xStr);
                    break;
            }
            base.DBFillBy(xNum, xStr);
        }
        public override bool DBUpdate(SingleForm.GCNum xNum)
        {
            try
            {
                switch (xNum)
                {
                    case GCNum.GCN_Main:
                        pOSXRBindingSource.EndEdit();
                        pOSXRTableAdapter.Update(dS_RESAI09.POSXR);
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
        protected override void BtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnQuery_ItemClick(sender, e);
            if (GV_Main.GetFocusedRowCellValue("XR005") != null)
            {
                SetLightOn(GV_Main.GetFocusedRowCellValue("XR005").ToString());
            }
        }
        public override void BtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnNew_ItemClick(sender, e);
            XR002C.Text = "";
            XR003C.Text = "";
            XR004C.Text = "";
            if (GetGridStatu() == GridStatu.gsAdd)
            {
                string mXR001 = "";               
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
                }

                if (mXR001 != "")
                {
                    XR001.Text = "S" + DateTime.Now.ToString("yyyyMMdd") + fc.ZeroatFirst((Int32.Parse(mXR001.Substring(9, mXR001.Length - 9)) + 1), 4);
                }
                else
                    XR001.Text = "S" + DateTime.Now.ToString("yyyyMMdd") + "0001";

                XR004.Text = fc.FUser.ID;
                XR004C.Text = fc.FUser.Name;
            }
        }
        public override void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GetGridStatu() == GridStatu.gsAdd)
            {
                string mNo = XR001.Text;
                string mSQL = "SELECT XR001 FROM POSXR WHERE XR001='" + mNo + "'";
                while (!ValidMaxNo(mSQL))
                {
                    mNo = mNo.Substring(0, 9) + fc.ZeroatFirst((Int32.Parse(mNo.Substring(9, mNo.Length - 9)) + 1), 4);
                    mSQL = "SELECT XR001 FROM POSXR WHERE XR001='" + mNo + "'";
                }
                XR001.Text = mNo;
            }
            base.BtnSave_ItemClick(sender, e);
        }
        public override void GV_Main_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GV_Main_FocusedRowChanged(sender, e);
            if (GV_Main.GetFocusedRowCellValue("XR005") == null) return;
            float mGrade = 0;
            if (float.TryParse(GV_Main.GetFocusedRowCellValue("XR005").ToString(),out mGrade))
            {
                if (mGrade < 0)
                {
                    IsGood = false;
                    mGrade = mGrade * -1;
                }
                else
                {
                    IsGood = true;
                }
            }
            else
            {
                IsGood = true;
            }
            SetLightOn(mGrade.ToString());
        }
        public override void F2FieldMain_KeyDown(object sender, KeyEventArgs e)
        {
            base.F2FieldMain_KeyDown(sender, e);
        }

        private void btnStar1_MouseEnter(object sender, EventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                string mName = (sender as SimpleButton).Name;
                mName = mName.Substring(mName.Length - 1, 1);
                SetLightOn(mName);
            }
        }
        private void btnStar1_MouseLeave(object sender, EventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                if (GV_Main.GetFocusedRowCellValue("XR005") == null) return;
                SetLightOn(GV_Main.GetFocusedRowCellValue("XR005").ToString());
            }
        }

        private void btnStar1_Click(object sender, EventArgs e)
        {

        }
        private void SetLightOn(string xXR005)
        {
            float mNum = 0;
            int mGrade = 0;
            
            if (float.TryParse(xXR005, out mNum))
            {
                int mNum2 = Math.Abs((int)mNum);

                for (int i = 0; i < SBtnList.Count; i++)
                {
                    if (i < mNum2)
                    {
                        if (IsGood)
                        {
                            mGrade++;
                            SBtnList[i].ImageIndex = 1;
                        }
                        else
                        {
                            mGrade--;
                            SBtnList[i].ImageIndex = 2;
                        }                        
                    }
                    else
                    {
                        SBtnList[i].ImageIndex = 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < SBtnList.Count; i++)
                {
                    SBtnList[i].ImageIndex = 0;
                }
            }
            LBGrade.Text = "(" + mGrade + ")";
            if (mGrade >=0 )
            {
                LBGrade.ForeColor = Color.BlueViolet;
            }
            else
            {
                LBGrade.ForeColor = Color.Red;
            }
        }

        private void XR002_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                f2.SetMI = new string[] { "POSXC", "001" };
                if (f2.GetMI)
                {
                    XR002.Text = f2.GetReturn[0];
                    XR002C.Text = f2.GetReturn[1];
                }
            }
        }

        private void XR004_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                f2.SetMI = new string[] { "POSXC", "002" };
                if (f2.GetMI)
                {
                    XR004.Text = f2.GetReturn[0];
                    XR004C.Text = f2.GetReturn[1];
                }
            }  
        }

        private void XR003_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != BaseForm.GridStatu.gsBrowse)
            {
                f2.SetMI = new string[] { "POSXG", "003" };
                f2.SetMIParam = new string[] { XR002.Text};
                if (f2.GetMI)
                {
                    XR003.Text = f2.GetReturn[0];
                    XR003C.Text = f2.GetReturn[1];
                }
            }   
        }

        private void XR002_Leave(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TextEdit mEdit = (sender as DevExpress.XtraEditors.TextEdit);
            string mValue = mEdit.Text;
            if (mValue == "") return;

            f2.SetMJ = new string[] { "POSXC", "001" };
            f2.SetMJParam = new string[] { mValue };
            if (f2.GetMJ)
            {
                XR002C.Text = f2.GetReturn[0];
            }
            else
            {
                XR002.Focus();
                MessageBox.Show("找不到符合的資料", "錯誤");
            }
        }

        private void XR004_Leave(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TextEdit mEdit = (sender as DevExpress.XtraEditors.TextEdit);
            string mValue = mEdit.Text;
            if (mValue == "") return;

            f2.SetMJ = new string[] { "POSXC", "002" };
            f2.SetMJParam = new string[] { mValue };
            if (f2.GetMJ)
            {
                XR004C.Text = f2.GetReturn[0];
            }
            else
            {
                XR004.Focus();
                MessageBox.Show("找不到符合的資料", "錯誤");
            }
        }

        private void XR003_Leave(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TextEdit mEdit = (sender as DevExpress.XtraEditors.TextEdit);
            string mValue = mEdit.Text;
            if (mValue == "") return;

            f2.SetMJ = new string[] { "POSXG", "003" };
            f2.SetMJParam = new string[] { XR002.Text,mValue };
            if (f2.GetMJ)
            {
                XR003C.Text = f2.GetReturn[1];
            }
            else
            {
                XR003.Focus();
                MessageBox.Show("找不到符合的資料", "錯誤");
            }
        }
        public override void GV_Main_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            base.GV_Main_CustomDrawCell(sender, e);
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
                    Graphics g = Graphics.FromImage(img);
                    g.DrawImage(img2, new Rectangle(0, 0, mXR005, 32), new Rectangle(0, 0, mXR005, 32), GraphicsUnit.Pixel);
                    e.Cache.Paint.DrawImage(e.Graphics, img, new Rectangle(e.Bounds.X, e.Bounds.Y, 160, 32));
                    e.Handled = true;
                }
            }
        }

        private void XR002_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue.ToString() == "")
            {
                e.Cancel = false;
                return;
            }
            if (e.NewValue == e.OldValue)
            {
                e.Cancel = false;
            }
            else
            {
                XR003.Text = "";
                XR003C.Text = "";
                e.Cancel = false;       
            }
        }

        private void btnStar1_MouseUp(object sender, MouseEventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                if (GV_Main.GetFocusedRowCellValue("XR005") == null) return;
                string mName = (sender as SimpleButton).Name;
                int mGrade = Int32.Parse(mName.Substring(mName.Length - 1, 1));
                if (e.Button == MouseButtons.Right)
                {
                    IsGood = false;
                    mGrade = mGrade * -1;
                }
                else
                {
                    IsGood = true;
                }                                                
                GV_Main.SetFocusedRowCellValue("XR005", mGrade);
            }
        }


    }
}
