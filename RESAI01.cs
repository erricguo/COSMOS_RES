using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;
using System.Net.Mail;
using System.IO;
using DevExpress.XtraReports.Parameters;
using System.Net;
using DevExpress.XtraReports.UI;
using COSMOS_RES.DataSet;
using DevExpress.XtraGrid.Views.Grid;

namespace COSMOS_RES
{
    public partial class RESAI01 : COSMOS_RES.BaseForm
    {
        int FImageW = 0;
        int FImageH = 0;
        Image FImage = null;
        public RESAI01()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InitUIVar();
        }

        public override void InitUIVar()
        {
            f2 = new F2Window(this);
            TabControlMainHeight = 250;
            GC_Main.DataSource = pOSXABindingSource;
            GC_Body.DataSource = pOSXBBindingSource;
            MainControls.Add(XA001);
            MainControls.Add(XA002);
            MainControls.Add(XA003);
            MainControls.Add(XA004);
            MainControls.Add(XA005);
            MainControls.Add(XA006);
            MainControls.Add(XA007);
            MainControls.Add(XA008);
            MainControls.Add(XA009);

            KeyFieldMain = "XA001";
            KeyFieldBody = "XB001,XB002";
            VisibleFieldMain = "XA010,XA011";
            VisibleFieldBody = "XB001,XB006,XB008,XB009,XB010";
            OrderFieldMain = "XA001";
            OrderFieldBody = "XB001,XB002";
            ReadOnlyFieldBody = "XB002,XB007C";
            RequiredFieldMain = "XA002";

            TimeFieldMain.Fields = "XA007";
            CheckFieldMain.Fields = "XA009";
            NumberFieldBody.NumFields.Add("XB004", "n1");
            ButtonFieldListMain.Add(XA002);
            ButtonFieldListBody.Add(new ButtonFieldFormat(GCNum.GCN_Body,"","XB007", this.XB002ButtonEdit_ButtonClick));

            VisibleListMain.Add("XA001", 0);
            VisibleListMain.Add("XA002", 1);
            VisibleListMain.Add("XA002C", 2); 
            VisibleListMain.Add("XA003", 3);
            VisibleListMain.Add("XA009", 4);
            VisibleListMain.Add("XA007", 5);
            VisibleListMain.Add("XA004", 6);
            VisibleListMain.Add("XA005", 7);
            VisibleListMain.Add("XA006", 8);
            VisibleListMain.Add("XA008", 9);

            VisibleListBody.Add("XB002", 0);
            VisibleListBody.Add("XB007", 1);
            VisibleListBody.Add("XB007C", 2);
            VisibleListBody.Add("XB003", 4);
            VisibleListBody.Add("XB004", 5);
            VisibleListBody.Add("XB005", 6);

            FieldWidthMain.Add("XA001",86);
            FieldWidthMain.Add("XA002",86);
            FieldWidthMain.Add("XA003",257);
            FieldWidthMain.Add("XA004",111);
            FieldWidthMain.Add("XA005",111);
            FieldWidthMain.Add("XA006",500);
            FieldWidthMain.Add("XA007",86);
            FieldWidthMain.Add("XA008",500);
            FieldWidthMain.Add("XA009",54);
            FieldWidthMain.Add("XA011",75);
            FieldWidthMain.Add("XA002C",87);
            FieldWidthMain.Add("XA010", 75);

            FieldWidthBody.Add("XB001",75);
            FieldWidthBody.Add("XB002", 86);
            FieldWidthBody.Add("XB003", 237);
            FieldWidthBody.Add("XB004", 67);
            FieldWidthBody.Add("XB005", 588);
            FieldWidthBody.Add("XB006", 75);
            FieldWidthBody.Add("XB007", 86);
            FieldWidthBody.Add("XB008", 75);
            FieldWidthBody.Add("XB009", 75);
            FieldWidthBody.Add("XB010", 75);
            FieldWidthBody.Add("XB007C", 86);

            DS_RESAI01.POSXADataTable dataTable = pOSXATableAdapter.GetDataBy("");
            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Columns.Count-1; i++)
                {
                    if (!dataTable.Columns[i].ColumnName.StartsWith("XA"))
                    {
                        continue;
                    }
                    SchemaList.Add(dataTable.Columns[i].ColumnName + " " + dataTable.Columns[i].Caption);
                }
            }
            SelectKeyMain = "XA001";
            SelectKeyBody = "XB001";
            XA002C.Text = "";
            base.InitUIVar();
        }

        public override void DBFillBy(BaseForm.GCNum xNum, string xStr)
        {
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    pOSXATableAdapter.FillBy(dS_RESAI01.POSXA, xStr);
                    LoadImage();
                    break;
                case GCNum.GCN_Body:
                    pOSXBTableAdapter.FillBy(dS_RESAI01.POSXB, xStr);
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
                        pOSXABindingSource.EndEdit();
                        pOSXATableAdapter.Update(dS_RESAI01.POSXA);
                        break;
                    case GCNum.GCN_Body:
                        pOSXBBindingSource.EndEdit();
                        pOSXBTableAdapter.Update(dS_RESAI01.POSXB);
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

        private void xA002ComboBoxEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != BaseForm.GridStatu.gsBrowse)
            {
                f2.SetMI = new string[] { "POSXI", "001" };
                if (f2.GetMI)
                {
                    XA002.Text = f2.GetReturn[0];
                    XA002C.Text = f2.GetReturn[1]; 
                }
            }             
        }

        private void XB002ButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != BaseForm.GridStatu.gsBrowse)
            {
                f2.SetMI = new string[] { "POSXL", "001" };
                f2.SetMIParam = new string[] { XA002.Text };
                if (f2.GetMI)
                {
                    GV_Body.SetRowCellValue(FocuseRow_Body, "XB007", f2.GetReturn[0]);
                    GV_Body.SetRowCellValue(FocuseRow_Body, "XB007C", f2.GetReturn[1]);  
                }             
            }    
        }

        public override void BtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnNew_ItemClick(sender, e);
            XA001.Properties.ReadOnly = true;
            XA002C.Text = "";
            if (GetGridStatu() == GridStatu.gsAdd)
            {
                string mXA001 = "";
                using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT MAX(XA001) AS XA001 FROM POSXA ", conn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                mXA001 = dr["XA001"].ToString();
                            }
                        }
                    }
                }
                XA001.Text = "R" + fc.ZeroatFirst((Int32.Parse(mXA001.Substring(1, mXA001.Length - 1)) + 1), 4); //R0000
                XA009.CheckState = CheckState.Unchecked;          
            }
        }
        public override void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GetGridStatu() == GridStatu.gsAdd)
            {
                int mRow = 0;
                string mNo = XA001.Text;
                string mSQL = "SELECT XA001 FROM POSXA WHERE XA001='" + mNo + "'";
                while (!ValidMaxNo(mSQL))
                {
                    mNo = "R" + fc.ZeroatFirst((Int32.Parse(mNo.Substring(1, mNo.Length - 1)) + 1), 4); //R0000
                    mSQL = "SELECT XA001 FROM POSXA WHERE XA001='" + mNo + "'";
                }
                XA001.Text = mNo;
                for (int i = 0; i < GV_Body.RowCount; i++)
                {
                    mRow = GV_Body.GetRowHandle(i);
                    GV_Body.SetRowCellValue(mRow, "XB001", XA001.Text);
                }
            }
            base.BtnSave_ItemClick(sender, e);
            if (FImage != null)
            {
                using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
                {
                    conn.Open();
                    try
                    {
                        string SQL = "UPDATE POSXA SET XA010=@XA010 WHERE XA001='" + XA001.Text + "'";
                        SqlCommand cmd = new SqlCommand(SQL, conn);
                        byte[] buffer = fc.ImageToBuffer(FImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                        cmd.Parameters.AddWithValue("@XA010", buffer);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        fc.ErrorLog(ex.Message);
                        conn.Close();
                    }
                }
                StorePic.Image = FImage;
            }
        }
        public override void BtnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnCancel_ItemClick(sender, e);
            StorePic.Image = null;
        }
        public override void GV_Main_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            base.GV_Main_FocusedRowChanged(sender, e);
            LoadImage();
        }

        private void LoadImage()
        {
            using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
            {
                conn.Open();
                try
                {
                    string SQL = "SELECT XA010 FROM [POSXA] WHERE XA001 ='" + XA001.Text + "'";
                    SqlCommand cmd = new SqlCommand(SQL, conn);
                    object obj = cmd.ExecuteScalar();
                    if (obj != null && obj != DBNull.Value)
                    {
                        byte[] buffer = (byte[])obj;
                        StorePic.Image = fc.BufferToImage(buffer);
                    }
                    else
                    {
                        StorePic.Image = null;
                    }
                    conn.Close();
                }
                catch (System.Exception ex)
                {
                    fc.ErrorLog(ex.Message);
                    conn.Close();
                }
            }
        }

        public override void F2FieldMain_KeyDown(object sender, KeyEventArgs e)
        {
            base.F2FieldMain_KeyDown(sender, e);
        }

        public override void GV_Body_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            base.GV_Body_ValidatingEditor(sender, e);
            bool IsCheckOK = true;
            GridView newview = sender as GridView;
            if (e.Value == null)
            {
                return;
            }

            string mValue = e.Value.ToString();
            if (mValue == "")
            {
                return;
            }

            if (newview.FocusedColumn.FieldName == "XB007")
            {
                f2.SetMJ = new string[] { "POSXL", "001" };
                f2.SetMJParam = new string[] { XA002.Text, mValue };
                if (f2.GetMJ)
                {
                    newview.SetFocusedRowCellValue("XB007C", f2.GetReturn[1]);
                }
                else
                    IsCheckOK = false;
            }

            e.Valid = IsCheckOK;
            IsMJOK = IsCheckOK;
            if (!IsCheckOK)
            {
                MessageBox.Show("找不到符合的資料", "錯誤");
            }

        }
        public override void GV_Body_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GV_Body_InitNewRow(sender, e);
            GV_Body.SetFocusedRowCellValue("XB001", XA001.Text);
            GV_Body.SetFocusedRowCellValue("XB002", string.Format("{0:0000}", GV_Body.RowCount));
            GV_Body.SetFocusedRowCellValue("XB006",XA002.Text);
            GV_Body.UpdateCurrentRow();
            GV_Body.FocusedColumn = GV_Body.Columns["XB007"];
            GV_Body.ShowEditor();
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            if (GetGridStatu() != BaseForm.GridStatu.gsBrowse)
            {
                StorePic.Properties.SizeMode = PictureSizeMode.Zoom;
                StorePic.LoadImage();
                FImage = StorePic.Image;
                FImageW = StorePic.Image.Width;
                FImageH = StorePic.Image.Height;
                StorePic.Properties.SizeMode = PictureSizeMode.Stretch;
            }   
        }

        private void StorePic_DoubleClick(object sender, EventArgs e)
        {
            if (StorePic.Image != null)
            {
                RESAI01H ai01h = new RESAI01H();
                ai01h.SetWidth = FImageW;
                ai01h.SetHeight = FImageH;
                ai01h.SetImg = StorePic.Image;
                ai01h.ShowDialog();
            }   
        }

        public override void MainControl_Leave(object sender, EventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                base.MainControl_Leave(sender, e);
                DevExpress.XtraEditors.BaseEdit edit = (sender as DevExpress.XtraEditors.BaseEdit);
                if (edit.Text.Trim() == "")
                {
                    return;
                }
                string[] xADMMJ = null;
                string[] xParam = null;
                Dictionary<DevExpress.XtraEditors.BaseControl, int> xReturnFileds = new Dictionary<DevExpress.XtraEditors.BaseControl, int>();
                if (edit.Name == "XA002")
                {
                    xADMMJ = new string[] { "POSXI", "001" };
                    xParam = new string[] { edit.Text };
                    xReturnFileds.Add(XA002C, 1);
                }
                LeaveCheckMainFunc(edit, xADMMJ, xParam, xReturnFileds);
            }
        }
    }
}
