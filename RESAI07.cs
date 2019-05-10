using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using COSMOS_RES.DataSet;

namespace COSMOS_RES
{
    public partial class RESAI07 : COSMOS_RES.SingleForm
    {
        public RESAI07()
        {
            InitializeComponent();
        }
        private void RESAI07_Load(object sender, EventArgs e)
        {
            InitUIVar();
        }
        public class AI07Formatter : IFormatProvider, ICustomFormatter
        {
            public object GetFormat(System.Type type)
            {
                return this;
            }
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                string formatValue = arg.ToString();
                if (format == "XH001" && formatValue != "")
                {
                    if (formatValue == "1")
                        formatValue = "1.口味";
                    else if (formatValue == "2")
                        formatValue = "2.加料";                    
                    return formatValue;
                }
                else return formatValue;
            }
        }

        public override void InitUIVar()
        {
            f2 = new F2Window(this);
            GC_Main.DataSource = pOSXHBindingSource;
            MainControls.Add(XH001);
            MainControls.Add(XH002);
            MainControls.Add(XH003);
            MainControls.Add(XH004);

            KeyFieldMain = "XH001,XH002";
            OrderFieldMain = "XH001,XH002";
            NumberFieldMain.Fields = "XH004";

            VisibleListMain.Add("XH001", 0);
            VisibleListMain.Add("XH002", 1);
            VisibleListMain.Add("XH003", 2);
            VisibleListMain.Add("XH004", 3);

            FieldWidthMain.Add("XH001", 80);
            FieldWidthMain.Add("XH002", 111);
            FieldWidthMain.Add("XH003", 178);
            FieldWidthMain.Add("XH004", 75);

            DS_RESAI07.POSXHDataTable dataTable = pOSXHTableAdapter.GetDataBy("");
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
            GV_Main.Columns["XH001"].ColumnEdit = edit;
            edit.DisplayFormat.FormatType = FormatType.Custom;
            edit.DisplayFormat.FormatString = "XH001";
            edit.DisplayFormat.Format = new AI07Formatter();

            XH001.Properties.DisplayMember = "Text";
            XH001.Properties.ValueMember = "Value";

            var items = new[] { 
            new { Text = "1.口味",   Value = "1" }, 
            new { Text = "2.加料",   Value = "2" }};
            XH001.Properties.DataSource = items;
            base.InitUIVar();
        
        }

        public override void DBFillBy(SingleForm.GCNum xNum, string xStr)
        {
            switch (xNum)
            {
                case GCNum.GCN_Main:
                    pOSXHTableAdapter.FillBy(dS_RESAI07.POSXH, xStr);
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
                        pOSXHBindingSource.EndEdit();
                        pOSXHTableAdapter.Update(dS_RESAI07.POSXH);
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

        public override void BtnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.BtnNew_ItemClick(sender, e);
            XH001.EditValue = "1";
            XH004.EditValue = 0;
        }

    }
}
