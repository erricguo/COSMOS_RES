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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;

namespace COSMOS_RES
{
    public partial class RESAR01 : RootForm
    {
        //F2Window f2 = null;
        public RESAR01()
        {
            InitializeComponent();
            InitUIVar();
        }

        private void InitUIVar()
        {
            f2 = new F2Window(this);
            XC002.Text = DateTime.Now.ToString("yyyyMMdd");
            XC002.Properties.DisplayFormat.FormatType = FormatType.Custom;
            XC002.Properties.DisplayFormat.FormatString = "XC002";
            XC002.Properties.DisplayFormat.Format = new AR01Formatter();

            f2.SetMI = new string[] { "POSXC", "003" };
            f2.SetMIParam = new string[] { XC002.EditValue.ToString() };
            f2.SetShowWindow = false;
            if (f2.GetMI)
            {
                XC001.Text = f2.GetReturn[0];
            }
        }

        public class AR01Formatter : IFormatProvider, ICustomFormatter
        {
            // The GetFormat method of the IFormatProvider interface.
            // This must return an object that provides formatting services for the specified type.
            public object GetFormat(System.Type type)
            {
                return this;
            }
            // The Format method of the ICustomFormatter interface.
            // This must format the specified value according to the specified format settings.
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                string formatValue = arg.ToString();

                if (format == "XC002" && formatValue != "")
                {
                    try
                    {
                        DateTime dt = DateTime.ParseExact(formatValue, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                        return formatValue = dt.ToString("yyyy/MM/dd");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        fc.ErrorLog(ex.Message);
                        return formatValue;
                    }

                }
                else return formatValue;
            }
        }
        private void XC002C_EditValueChanged(object sender, EventArgs e)
        {
            XC002.Text = XC002C.DateTime.ToString("yyyyMMdd");
            XC001.Text = "";
        }

        private void btnPreView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XC002.Text == "" || XC001.Text =="")
            {
                MessageBox.Show("訂購日期及精選編號不可空白!!", "錯誤");
            }
            else
            {
                if (cbo01.SelectedIndex == 0)//依訂購人
                {
                    REPAR01G ar01 = new REPAR01G();
                    ar01.SetParameter = new string[] { XC002.EditValue.ToString(), XC001.Text };
                    ar01.RequestParameters = false;
                    ar01.CreateDocument();
                    if (ar01.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Parameters) != DevExpress.XtraPrinting.CommandVisibility.None)
                    {
                        ar01.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Parameters, DevExpress.XtraPrinting.CommandVisibility.None);
                    }
                    ar01.Name = "REPAR01";
                    ar01.ShowRibbonPreview();
                    //ar01.ShowPreviewDialog();
                }
                else //依菜單編號
                {
                    REPAR01 ar01 = new REPAR01();
                    ar01.SetParameter = new string[] { XC002.EditValue.ToString(), XC001.Text };
                    ar01.RequestParameters = false;
                    ar01.CreateDocument();
                    if (ar01.PrintingSystem.GetCommandVisibility(PrintingSystemCommand.Parameters) != DevExpress.XtraPrinting.CommandVisibility.None)
                    {
                        ar01.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Parameters, DevExpress.XtraPrinting.CommandVisibility.None);
                    }
                    ar01.Name = "REPAR01";
                    ar01.ShowRibbonPreview();
                    //ar01.ShowPreviewDialog();
                }
            }
        }

        private void XC004_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (GetGridStatu() != SingleForm.GridStatu.gsBrowse)
            {
                //f2 = new F2Window();
                f2.SetMI = new string[] { "POSXC", "003" };
                f2.SetMIParam = new string[] { XC002.EditValue.ToString() };
                if (f2.GetMI)
                {
                    XC001.Text = f2.GetReturn[0];
                }
            }  
        }

        private void XC001_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                DevExpress.XtraEditors.ButtonEdit btn = (DevExpress.XtraEditors.ButtonEdit)sender;
                btn.PerformClick(btn.Properties.Buttons[0]);
            }
        }

        private void RESAR01_Shown(object sender, EventArgs e)
        {
            XC002.Focus();
        }

    }
}
