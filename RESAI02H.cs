using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace COSMOS_RES
{
    public partial class RESAI02H : RootForm
    {
        bool FISCanSelect = false;
        GridView gv = null;
        string[] ResutnValus = null;
        public RESAI02H(bool CanSelect)
        {
            FISCanSelect = CanSelect;
            InitializeComponent();
            if (CanSelect)
            {
                btnOK.Visible = true;
                btnCancel.Visible = true;
                btnClose.Visible = false;
            }
            else
            {
                btnOK.Visible = false;
                btnCancel.Visible = false;
                btnClose.Visible = true; 
            }
            gv = GV_B;
        }

        public string[] GetReturn
        {
            get
            {
                return ResutnValus;
            }
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

        private void RESAI02H_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dS_RESAI02.DS_GVD' 資料表。您可以視需要進行移動或移除。
            this.gVDTableAdapter.Fill(this.dS_RESAI02.DS_GVD);
            // TODO: 這行程式碼會將資料載入 'dS_RESAI02.DS_GVC' 資料表。您可以視需要進行移動或移除。
            this.gVCTableAdapter.Fill(this.dS_RESAI02.DS_GVC);
            // TODO: 這行程式碼會將資料載入 'dS_RESAI02.DS_GVB' 資料表。您可以視需要進行移動或移除。
            this.gVBTableAdapter.Fill(this.dS_RESAI02.DS_GVB);
            // TODO: 這行程式碼會將資料載入 'dS_RESAI02.DS_GVA' 資料表。您可以視需要進行移動或移除。
            this.gVATableAdapter.Fill(this.dS_RESAI02.DS_GVA);

            RepositoryItemTextEdit edit = new RepositoryItemTextEdit();
            GV_B.Columns["XC002"].ColumnEdit = edit;
            GV_C.Columns["XC002"].ColumnEdit = edit;
            GV_D.Columns["XC002"].ColumnEdit = edit;
            edit.DisplayFormat.FormatType = FormatType.Custom;
            edit.DisplayFormat.FormatString = "Date";
            edit.DisplayFormat.Format = new CustomFormatter();

            edit = new RepositoryItemTextEdit();
            GV_A.Columns["XC009"].ColumnEdit = edit;
            GV_B.Columns["XC009"].ColumnEdit = edit;
            GV_C.Columns["XC009"].ColumnEdit = edit;
            GV_D.Columns["XC009"].ColumnEdit = edit;
            edit.DisplayFormat.FormatType = FormatType.Custom;
            edit.DisplayFormat.FormatString = "XC009";
            edit.DisplayFormat.Format = new AI02Formatter();

        }

        DateTime mouseDownTime = DateTime.MinValue;
        GridCell mouseDownCell = new GridCell(GridControl.InvalidRowHandle, null);
        TimeSpan DoubleClickInterval = new TimeSpan(0, 0, 0, 0, 100);
        private void GV_B_MouseDown(object sender, MouseEventArgs e)
        {
            if (!FISCanSelect || gv == null) return;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                GridHitInfo hi = gv.CalcHitInfo(e.Location);
                if (hi == null || hi.Column == null)
                {
                    return;
                }
                if (hi.InRowCell)
                {
                    if (hi.RowHandle == mouseDownCell.RowHandle && hi.Column == mouseDownCell.Column && mouseDownTime - DateTime.Now < DoubleClickInterval)
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
                btnOK.PerformClick();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (gv.RowCount > 0)
            {
                ResutnValus = new string[] { gv.GetFocusedRowCellValue("XC004").ToString(), gv.GetFocusedRowCellValue("XC004C").ToString() };
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == PAGE1)
            {
                gv = GV_B;
            }
            else if (e.Page == PAGE2)
            {
                gv = GV_D;
            }
            else if (e.Page == PAGE3)
            {
                gv = GV_C;
            }
            else if (e.Page == PAGE4)
            {
                gv = GV_A;
            }
        }

        private void RESAI02H_KeyUp(object sender, KeyEventArgs e)
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
