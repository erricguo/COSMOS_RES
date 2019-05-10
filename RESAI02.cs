using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using COSMOS_RES.DataSet;
using DevExpress.XtraGrid.Views.Base;

namespace COSMOS_RES
{
    public partial class RESAI02 : COSMOS_RES.SingleForm
    {
        string FDateError = "訂餐日期 不可大於 截止日期!!";
        string FTimeError = "起始時間 不可大於 截止時間!!";
        byte[] FBuffer = null;
        public RESAI02()
        {
            InitializeComponent();
        }
        private void POSAI02_Load(object sender, EventArgs e)
        {
            InitUIVar();
        }
        public class AI02Formatter : IFormatProvider, ICustomFormatter
        {
            public object GetFormat(System.Type type)
            {
                return this;
            }
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                string formatValue = arg.ToString();
                if (format == "XC009" && formatValue != "")
                {
                    if (formatValue == "1")
                        formatValue = "1:早餐";
                    else if (formatValue == "2")
                        formatValue = "2:午餐";
                    else if (formatValue == "3")
                        formatValue = "3:下午茶";
                    else if (formatValue == "4")
                        formatValue = "4:晚餐";
                    return formatValue;
                }
                else return formatValue;
            }
        }
        public override void InitUIVar()
        {
            f2 = new F2Window(this);
            GC_Main.DataSource = pOSXCBindingSource;
            MainControls.Add(XC001);
            MainControls.Add(XC010);
            MainControls.Add(XC009);
            MainControls.Add(XC004);
            MainControls.Add(XC002);
            MainControls.Add(XC002C);
            MainControls.Add(XC003);
            MainControls.Add(XC008);
            MainControls.Add(XC007);
            MainControls.Add(XC006);

            VisibleFieldMain = "XC005";
            KeyFieldMain = "XC001";
            RequiredFieldMain = "XC009,XC004,XC002,XC003,XC008,XC007,XC006";
            OrderFieldMain = "XC001";

            DateFieldMain.Fields = "XC002,XC008";
            TimeFieldMain.Fields = "XC003,XC007";

            ButtonFieldListMain.Add(XC004);
            ButtonFieldListMain.Add(XC006);

            VisibleListMain.Add("XC001", 0);
            VisibleListMain.Add("XC010", 1);
            VisibleListMain.Add("XC009", 2);
            VisibleListMain.Add("XC004", 3);
            VisibleListMain.Add("XC004C", 4);
            VisibleListMain.Add("XC002", 5);
            VisibleListMain.Add("XC003", 6);
            VisibleListMain.Add("XC008", 7);
            VisibleListMain.Add("XC007", 8);
            VisibleListMain.Add("XC006", 9);
            VisibleListMain.Add("XC006C", 10);

            FieldWidthMain.Add("XC001",114);
            FieldWidthMain.Add("XC002", 93);
            FieldWidthMain.Add("XC003", 86);
            FieldWidthMain.Add("XC004", 86);
            FieldWidthMain.Add("XC005", 75);
            FieldWidthMain.Add("XC006", 70);
            FieldWidthMain.Add("XC007", 86);
            FieldWidthMain.Add("XC008", 93);
            FieldWidthMain.Add("XC009", 86);
            FieldWidthMain.Add("XC010", 251);
            FieldWidthMain.Add("XC004C", 119);
            FieldWidthMain.Add("XC006C", 102);

            DS_RESAI02.POSXCDataTable dataTable = pOSXCTableAdapter.GetDataBy("");
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
            GV_Main.Columns["XC009"].ColumnEdit = edit;
            edit.DisplayFormat.FormatType = FormatType.Custom;
            edit.DisplayFormat.FormatString = "XC009";
            edit.DisplayFormat.Format = new AI02Formatter();

            XC004C.Text = "";
            XC006C.Text = "";

            XC009.Properties.DisplayMember = "Text";
            XC009.Properties.ValueMember = "Value";

            var items = new[] { 
            new { Text = "1.早餐",   Value = "1" }, 
            new { Text = "2.午餐",   Value = "2" }, 
            new { Text = "3.下午茶", Value = "3" },
            new { Text = "4.晚餐",   Value = "4" }};

            XC009.Properties.DataSource = items;
            base.InitUIVar();
        }

        private void XC004_Leave(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TextEdit mEdit = (sender as DevExpress.XtraEditors.TextEdit);
            string mValue = mEdit.Text;
            if (mValue == "") return;

            f2.SetMJ = new string[] { "POSXC", "001" };
            f2.SetMJParam = new string[] { mValue };
            if (f2.GetMJ)
            {
                XC004C.Text = f2.GetReturn[0];
            }
            else
            {
                XC004.Focus();
                MessageBox.Show("找不到符合的資料", "錯誤");
            }
        }

        private void XC006_Leave(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TextEdit mEdit = (sender as DevExpress.XtraEditors.TextEdit);
            string mValue = mEdit.Text;
            if (mValue == "") return;

            f2.SetMJ = new string[] { "POSXC", "002" };
            f2.SetMJParam = new string[] { mValue };
            if (f2.GetMJ)
            {
                XC006C.Text = f2.GetReturn[0];
            }
            else
            {
                XC006.Focus();
                MessageBox.Show("找不到符合的資料", "錯誤");
            }
        }
        public override void DBFillBy(SingleForm.GCNum xNum, string xStr)
        {            
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    pOSXCTableAdapter.FillBy(dS_RESAI02.POSXC, xStr);
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
                        pOSXCBindingSource.EndEdit();
                        pOSXCTableAdapter.Update(dS_RESAI02.POSXC);
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

        private void XC004_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                f2.SetMI = new string[] { "POSXC", "001" };
                if (f2.GetMI)
                {
                    XC004.Text = f2.GetReturn[0];
                    XC004C.Text = f2.GetReturn[1];
                }
            }   
        }

        private void XC006_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                f2.SetMI = new string[] { "POSXC", "002" };
                if (f2.GetMI)
                {
                    XC006.Text = f2.GetReturn[0];
                    XC006C.Text = f2.GetReturn[1];
                }
            }  
        }
        public override void BtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnNew_ItemClick(sender, e);
            XC001.Properties.ReadOnly = true;
            XC004C.Text = "";
            XC006C.Text = "";
            if (GetGridStatu() == GridStatu.gsAdd)
            {
                string mXC001 = "";
                string mXC002 = DateTime.Now.ToString("yyyyMMdd");
                using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT MAX(XC001) AS XC001 FROM POSXC WHERE XC002 = '" + mXC002 + "'", conn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                mXC001 = dr["XC001"].ToString();
                            }
                        }
                    }
                }

                if (mXC001 != "")
                {
                    XC001.Text = "C" + mXC002 +
                    fc.ZeroatFirst((Int32.Parse(mXC001.Substring(9, mXC001.Length - 9)) + 1), 2);
                }
                else
                    XC001.Text = "C" + mXC002 + "01";

                XC002.Text = TryGetDateTime(DateTime.Now.ToString(), "Date");
                XC008.Text = TryGetDateTime(DateTime.Now.ToString(), "Date");
                XC003.Text = TryGetDateTime(DateTime.Now.ToString(), "Time");
                //XC007.Text = TryGetDateTime(DateTime.Now.AddHours(3).ToString() , "Time");
                XC010.Text = "甲奔阿~~~~";
                XC009.EditValue = "2";
                
                f2.SetMJ = new string[] { "POSXC", "002" };
                f2.SetMJParam = new string[] { fc.FUser.ID };
                if (f2.GetMJ)
                {
                    XC006C.Text = f2.GetReturn[0];
                    XC006.Text = fc.FUser.ID;
                }
            }
        }

        public override void BtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnEdit_ItemClick(sender, e);
            if (GetGridStatu() == GridStatu.gsEdit)
            {
                XC002.Text = TryGetDateTime(XC002.Text, "Date");
                XC008.Text = TryGetDateTime(XC008.Text, "Date");
                XC003.Text = TryGetDateTime(XC003.Text, "Time");
                XC007.Text = TryGetDateTime(XC007.Text, "Time");
            }
        }

        public override void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckDateValid("Date", XC002.Text, XC008.Text, FDateError))
                return;
            if (!CheckDateValid("Time", XC003.Text, XC007.Text, FTimeError))
                return;

            if (GetGridStatu() == GridStatu.gsAdd)
            {
                string mNo = XC001.Text;
                string mSQL = "SELECT XC001 FROM POSXC WHERE XC001='" + mNo + "'";
                while (!ValidMaxNo(mSQL))
                {
                    mNo = mNo.Substring(0, 9) + fc.ZeroatFirst((Int32.Parse(mNo.Substring(9, mNo.Length - 9)) + 1), 2);
                    mSQL = "SELECT XC001 FROM POSXC WHERE XC001='" + mNo + "'";
                }
                XC001.Text = mNo;
            }
            base.BtnSave_ItemClick(sender, e);
            if(IsCheckRequired)
                ShowPOSAB02(true);
        }

        private void BtnPOSAB02_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowPOSAB02(false);
        }
        private void ShowPOSAB02(bool WriteData)
        {
            if (XC002.Text == "") return;
            LoadImage();
            RESAB02 ab02 = new RESAB02();
            ab02.SetRESMain = (Parent.Parent as RESMain);
            ab02.SetID = XC006.Text;
            ab02.SetXA001 = XC004.Text;
            ab02.SetDate = XC002.EditValue.ToString();
            ab02.SetSubject = XC010.Text;
            ab02.SetPDFName = XC001.Text;
            ab02.SetStoreName = XC004C.Text;
            ab02.SetOrderTime = XC003.Text + "~" + XC007.Text;
            ab02.SetBuffer = FBuffer;
            ab02.SetWriteData = WriteData;
            ab02.ShowDialog();
        }

        private void btnPreView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XC004.Text !="")
            {
                RESAB02 ab02 = new RESAB02();
                ab02.SetID = XC006.Text;
                ab02.SetXA001 = XC004.Text;
                ab02.SetDate = XC002.EditValue.ToString();
                ab02.SetSubject = XC010.Text;
                ab02.SetPDFName = XC001.Text;
                ab02.SetStoreName = XC002C.Text;
                ab02.MenuPreView();
            }
        }

        private void btnList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool CanSelect = false;
            string[] mTemp = null;
            if (GetGridStatu() != GridStatu.gsBrowse) CanSelect = true;
            RESAI02H ai02h = new RESAI02H(CanSelect);
            if (ai02h.ShowDialog() == DialogResult.OK)
            {
                if ((mTemp = ai02h.GetReturn) != null)
                {
                    XC004.Text = mTemp[0];
                    XC004C.Text = mTemp[1];
                }
            }
        }

        public override void F2FieldMain_KeyDown(object sender, KeyEventArgs e)
        {
            base.F2FieldMain_KeyDown(sender, e);
        }

        private void XC002C_EditValueChanged(object sender, EventArgs e)
        {
            XC002.Text = XC002C.DateTime.ToString("yyyy/MM/dd");
            CheckDateValid("Date", XC002.Text, XC008.Text, FDateError);
        }

        private void XC008C_EditValueChanged(object sender, EventArgs e)
        {
            XC008.Text = XC008C.DateTime.ToString("yyyy/MM/dd");
            CheckDateValid("Date", XC002.Text, XC008.Text, FDateError);
        }

        private void XC002_Leave(object sender, EventArgs e)
        {
            CheckDateValid("Date", XC002.Text, XC008.Text, FDateError);
        }

        private void XC003_Leave(object sender, EventArgs e)
        {
            CheckDateValid("Time", XC003.Text, XC007.Text, FTimeError);
        }

        private void LoadImage()
        {
            using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
            {
                conn.Open();
                try
                {
                    /*if (XC004.Text.Trim() == "")
                    {
                        StorePic.Image = StorePic.Properties.ErrorImage;
                    }
                    else*/
                    {
                        string SQL = "SELECT XA010 FROM [POSXA] WHERE XA001 ='" + XC004.Text + "'";
                        SqlCommand cmd = new SqlCommand(SQL, conn);
                        object obj = cmd.ExecuteScalar();
                        if (obj != null && obj != DBNull.Value)
                        {
                            byte[] buffer = (byte[])obj;
                            FBuffer = buffer;
                            StorePic.Image = fc.BufferToImage(buffer);
                        }
                       /* else
                        {
                            StorePic.Image = StorePic.Properties.ErrorImage;
                        }*/
                        conn.Close();
                    }
                }
                catch (System.Exception ex)
                {
                    fc.ErrorLog(ex.Message);
                    conn.Close();
                }
            }
        }

        private void btnMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadImage();
            if (StorePic.Image != null)
            {
                RESAI01H ai01h = new RESAI01H();
                ai01h.SetWidth = StorePic.Image.Width;
                ai01h.SetHeight = StorePic.Image.Height;
                ai01h.SetImg = StorePic.Image;
                ai01h.ShowDialog();
            }  
        }

        private void XC004_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void XC009_EditValueChanged(object sender, EventArgs e)
        {
            if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                if (XC009.EditValue.ToString() == "2")
                    XC007.Text = "10:30";
                else
                    XC007.Text = TryGetDateTime(DateTime.Now.AddHours(3).ToString(), "Time");
            }
        }
    }
}
