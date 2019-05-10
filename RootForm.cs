using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace COSMOS_RES
{
    public partial class RootForm : DevExpress.XtraEditors.XtraForm
    {
        public enum GridStatu : int
        {
            gsBrowse = 1,
            gsAdd = 2,
            gsEdit = 3
        }
        public enum GCNum : int
        {
            GCN_Main = 1,
            GCN_Body = 2
        }

        public class Fieldformat
        {
            public GCNum TableType;
            public string DateType;
            public string Fields;
            public Dictionary<string, string> NumFields = new Dictionary<string, string>();

            public Fieldformat(GCNum xTableType, string xDateType)
            {
                TableType = xTableType;
                DateType = xDateType;
            }
        }

        public class ButtonFieldFormat : RepositoryItemButtonEdit
        {
            public GCNum TableType;
            public string DateType;
            public string Field;

            public ButtonFieldFormat(GCNum xTableType, string xDateType, string xField, ButtonPressedEventHandler func)
            {
                TableType = xTableType;
                DateType = xDateType;
                Field = xField;
                ButtonsStyle = BorderStyles.UltraFlat;
                Buttons[0].Width = 15;
                ButtonClick += new ButtonPressedEventHandler(func);
            }
            public void SetLeave(EventHandler func)
            {
                Leave += new EventHandler(func);
            }
        }

        public F2Window f2 = null;
        public GridStatu FGridStatu = GridStatu.gsBrowse;
        public List<string> SchemaList = new List<string>();
        public List<BaseEdit> MainControls = new List<BaseEdit>();
        public string SelectKeyMain = "";
        public string SelectKeyBody = "";
        public string VisibleFieldMain = "";
        public string VisibleFieldBody = "";
        public string OrderFieldMain = "";
        public string OrderFieldBody = "";
        public string KeyFieldMain = "";
        public string KeyFieldBody = "";
        public List<string> KeyListMain = new List<string>();
        public List<string> KeyListBody = new List<string>();
        public List<string> ReadOnlyListMain = new List<string>();
        public List<string> ReadOnlyListBody = new List<string>();
        public List<string> RequiredListMain = new List<string>();
        public List<string> RequiredListBody = new List<string>();
        public Dictionary<string, int> VisibleListMain = new Dictionary<string, int>();
        public Dictionary<string, int> VisibleListBody = new Dictionary<string, int>();
        public Dictionary<string, int> FieldWidthMain = new Dictionary<string, int>();
        public Dictionary<string, int> FieldWidthBody = new Dictionary<string, int>();
        public string RequiredFieldMain = "";
        public string RequiredFieldBody = "";
        public string ReadOnlyFieldMain = "";
        public string ReadOnlyFieldBody = "";
        public int FocuseRow_Main = 0;
        public int FocuseRow_Body = 0;
        public bool IsCheckRequired = true;
        public string DefaultQueryStr = "";
        public bool IsNowDeleteRow = false;
        public bool IsNowAddRow = false;
        public bool IsGCCHeck = false;
        public bool IsCanCgangeRow = false;
        public bool IsValidEditor = false;
        public string LeaveCheckFieldMain = "";
        public string LeaveCheckFieldBody = "";
        public List<string> LeaveCheckListMain = new List<string>();
        public List<string> LeaveCheckListBody = new List<string>();

        public Fieldformat DateFieldMain = new Fieldformat(GCNum.GCN_Main, "Date");
        public Fieldformat DateFieldBody = new Fieldformat(GCNum.GCN_Body, "Date");
        public Fieldformat TimeFieldMain = new Fieldformat(GCNum.GCN_Main, "Time");
        public Fieldformat TimeFieldBody = new Fieldformat(GCNum.GCN_Body, "Time");
        public Fieldformat CheckFieldMain = new Fieldformat(GCNum.GCN_Main, "");
        public Fieldformat CheckFieldBody = new Fieldformat(GCNum.GCN_Body, "");
        public Fieldformat NumberFieldMain = new Fieldformat(GCNum.GCN_Main, "");
        public Fieldformat NumberFieldBody = new Fieldformat(GCNum.GCN_Body, "");
        public Fieldformat PassWordFieldMain = new Fieldformat(GCNum.GCN_Main, "");
        public Fieldformat PassWordFieldBody = new Fieldformat(GCNum.GCN_Body, "");
        public List<BaseEdit> ButtonFieldListMain = new List<BaseEdit>();
        public List<ButtonFieldFormat> ButtonFieldListBody = new List<ButtonFieldFormat>();
        public List<string> F2FieldMain = new List<string>();
        public List<string> F2FieldBody = new List<string>();


        public RootForm()
        {
            InitializeComponent();
        }

        public class CustomFormatter : IFormatProvider, ICustomFormatter
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

                if (format == "Date" && formatValue != "" )
                {
                    try
                    {
                        DateTime dt = DateTime.Now;
                        if (!DateTime.TryParse(formatValue, out dt))
                        {
                            dt = DateTime.ParseExact(formatValue, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                        }
                        return formatValue = dt.ToString("yyyy/MM/dd");
                    }
                    catch (System.Exception ex)
                    {
                        return "";
                    }

                }
                else if (format == "Time" && formatValue != "" )
                {
                    try
                    {
                        DateTime dt = DateTime.Now;
                        if (!DateTime.TryParse(formatValue, out dt))
                        {
                            dt = DateTime.ParseExact(formatValue, "HHmm", System.Globalization.CultureInfo.InvariantCulture);
                        }
                        return formatValue = dt.ToString("HH:mm");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        fc.ErrorLog(ex.Message);
                        return "";
                    }
                }
                else return formatValue;
            }
        }

        public virtual DevExpress.XtraGrid.GridControl GetGC(GCNum xGCNum)
        {
            return null;
        }
        public virtual DevExpress.XtraGrid.Views.Grid.GridView GetGV(GCNum xGCNum)
        {
            return null;
        }

        public virtual DevExpress.XtraGrid.Views.Grid.GridView GetGridView()
        {
            return null;
        }

        public void QueryCheckStateByValue(object sender, DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventArgs e)
        {
            string val = "";
            if (e.Value != null)
            {
                val = e.Value.ToString();
            }
            else
            {
                val = "N";//預設N
            }
            switch (val)
            {
                case "Y":
                    e.CheckState = CheckState.Checked;
                    break;
                case "N":
                    e.CheckState = CheckState.Unchecked;
                    break;
                default:
                    e.CheckState = CheckState.Unchecked;
                    break;
            }
            e.Handled = true;
        }

        public GridStatu GetGridStatu()
        {
            return FGridStatu;
        }

        public virtual void GOReSize()
        {

        }

        public string TryGetDateTime(string xDateTime,string xFormatStr)
        {
            try
            {
                DateTime dt = DateTime.Now;
                if (!DateTime.TryParse(xDateTime, out dt))
                {
                    if (xFormatStr == "Date")
                    {
                        dt = DateTime.ParseExact(xDateTime, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                        return dt.ToString("yyyy/MM/dd");
                    }
                    else if (xFormatStr == "Time")
                    {
                        dt = DateTime.ParseExact(xDateTime, "HHmm", System.Globalization.CultureInfo.InvariantCulture);
                        return dt.ToString("HH:mm");
                    }
                    else
                    {
                        return xDateTime;
                    }
                }
                else
                {
                    return xDateTime;
                }
            }
            catch (Exception ex)
            {
                fc.ErrorLog(ex.Message);
                return xDateTime;
            }
        }
        public bool CheckDateValid(string xType,string xBegin, string xEnd, string xMsg)
        {
            if (xBegin != "" && xEnd != "")
            {
                TimeSpan ts = DateTime.Parse(xBegin) - DateTime.Parse(xEnd);
                if (xType == "Date")
                {
                    if (ts.Days > 0)
                    {
                        MessageBox.Show(xMsg, "錯誤");
                        return false;
                    }
                }
                else if (xType == "Time")
                {
                    if (ts.Minutes > 0 || ts.Hours > 0)
                    {
                        MessageBox.Show(xMsg, "錯誤");
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public virtual bool ValidMaxNo(string xSQL)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(xSQL, conn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                fc.ErrorLog(ex.Message);
                return false;
            }
        }
        public virtual void PerformClick(string FieldName, ButtonEdit editor, ButtonPressedEventArgs e)
        {
            if (editor == null || e == null) return;
            MethodInfo mi = typeof(RepositoryItemButtonEdit).GetMethod("RaiseButtonClick",
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            if (mi != null)
                mi.Invoke(editor.Properties, new object[] { e });
        }
    }
}
