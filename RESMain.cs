using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using Nini.Config;
using System.IO;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
using System.Deployment.Application;
using DevExpress.XtraSplashScreen;
//using SplashForm;

namespace COSMOS_RES
{
    public partial class RESMain : DevExpress.XtraEditors.XtraForm
    {
        
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int WriteProfileString(string lpszSection, string lpszKeyName, string lpszString);

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, // handle to destination window 
            uint Msg,
            int wParam,
            int lParam
        );

        [DllImport("gdi32")]
        public static extern int AddFontResource(string lpFileName);

        int tabCount = 1;
        //const string AppId = "843306145699388";
        //private Uri _loginUrl;
        //const string _ExtendedPermissions = "50ebeb6fe4ea1488fab283d70e7c4863";
        //FacebookClient fb = new FacebookClient();
        //string username = "abay1012@hotmail.com";
        //string password = "1qazXSW@";
        //fc.DES des = new fc.DES();
        string Fkey = "";
        string FProjectName = "COSMOS_RES";
        bool IsAutoLoagin = false;
        IniJsonInfo FINI = null;
        List<string> macList = new List<string>();
        Assembly FAssembly = null;

        public class IniJsonInfo
        {
            public string ID { get; set; }
            public string NAME { get; set; }
            public string EMAIL { get; set; }
            public string VERIFY { get; set; }
        }

        public RESMain()
        {            
            InitializeComponent();
            //splashScreenManager1.SetWaitFormDescription("正在檢查字型...");
            installFont("YaHei.Consolas.1.12.ttf", "雅黑1.12");
            //splashScreenManager1.SetWaitFormDescription("正在檢查字型...完成!");
        }

        private void InitRootNode()
        {
            Dictionary<string, string> mDic = new Dictionary<string, string>();
            mDic.Add(fc.VerifyKey, "");
            fc.FROOT.Add(fc.LOGINConfig, mDic);
            mDic = new Dictionary<string, string>();
            mDic.Add("IP", "10.40.40.129");
            mDic.Add("DB", "RESEX");
            mDic.Add("ID", "sa");
            mDic.Add("PW", fc.FDes.EncryptString("zxcvbnm,./", Fkey));
            fc.FROOT.Add(fc.DBINFOConfig, mDic);
        }

        private void Init()
        {
            Fkey = fc.FDes.GenerateKey();
            InitRootNode();
            this.Text = "COSMOS訂餐系統 Ver " + fc.GetVersion() + " ";
            //Login(AppId, _ExtendedPermissions);
            //webBrowser1.Navigate("https://login.facebook.com/login.php?login_attempt=1");

            //fc.FDBInfo.SetDBInfo("127.0.0.1", "RESEX", "sa", "123");
            //fc.FDBInfo.SetDBInfo("10.40.40.129", "RESEX", "sa", "zxcvbnm,./");

            panel1.BackgroundImage = pictureEdit1.BackgroundImage;
            navBarControl1.Enabled = false;
            splitterControl1.Visible = false;
            
            foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    macList.Add(nic.GetPhysicalAddress().ToString());

            if (macList.Count > 0)
            {
                string mIP = "10.40.40.129";
                string mDB = "RESEX";
                string mID = "sa";
                string mPW = "zxcvbnm,./";
                fc.CheckIniPath();

                /*if (!File.Exists(fc.INIPath))
                {
                    if (!Directory.Exists(fc.KUPODIR))
                    {
                        Directory.CreateDirectory(fc.KUPODIR);
                    }
                    if (!Directory.Exists(fc.COSMOSRESDIR))
                    {
                        Directory.CreateDirectory(fc.COSMOSRESDIR);
                    }
                    File.Create(fc.INIPath).Close();
                    IConfigSource source = new IniConfigSource(fc.INIPath);
                    source.Configs.Add(LOGINConfig);
                    source.Configs[LOGINConfig].Set(VerifyKey, "");
                    source.Configs.Add(DBINFOConfig);
                    source.Configs[DBINFOConfig].Set("IP", "10.40.40.129");
                    source.Configs[DBINFOConfig].Set("DB", "RESEX");
                    source.Configs[DBINFOConfig].Set("ID", "sa");
                    source.Configs[DBINFOConfig].Set("PW", fc.FDes.EncryptString("zxcvbnm,./", Fkey));
                    source.Save();
                    fc.ErrorLog("新增 Config.ini 成功");
                }
                else
                {
                    IConfigSource source = new IniConfigSource(fc.INIPath);
                    foreach (KeyValuePair<string, Dictionary<string, string>> k in FROOT)
                    {
                        if (source.Configs[k.Key] == null)
                        {
                            source.Configs.Add(k.Key);
                            fc.ErrorLog("新增結點:" + k.Key);
                            foreach (KeyValuePair<string, string> j in FROOT[k.Key])
                            {
                                source.Configs[k.Key].Set(j.Key, j.Value);
                                fc.ErrorLog("新增子結點:"+j.Key + " 值:"+j.Value);
                            }
                        }
                        else
                        {
                            foreach (KeyValuePair<string, string> j in FROOT[k.Key])
                            {
                                if (source.Configs[k.Key].Get(j.Key, null) == null)
                                {
                                    source.Configs[k.Key].Set(j.Key, j.Value);
                                    fc.ErrorLog("新增子結點:" + j.Key + " 值:" + j.Value);
                                }
                            }
                        }
                    }
                    source.Save();
                    mIP = source.Configs[DBINFOConfig].Get("IP", "127.0.0.1");
                    mDB = source.Configs[DBINFOConfig].Get("DB", "RESEX");
                    mID = source.Configs[DBINFOConfig].Get("ID", "sa");
                    mPW = fc.FDes.DecryptString(source.Configs[DBINFOConfig].Get("PW", "123"),Fkey);
                }*/
                IConfigSource source = new IniConfigSource(fc.INIPath);
                mIP = source.Configs[fc.DBINFOConfig].Get("IP", "127.0.0.1");
                mDB = source.Configs[fc.DBINFOConfig].Get("DB", "RESEX");
                mID = source.Configs[fc.DBINFOConfig].Get("ID", "sa");
                mPW = fc.FDes.DecryptString(source.Configs[fc.DBINFOConfig].Get("PW", "123"), Fkey);
                fc.FDBInfo.SetDBInfo(mIP, mDB, mID, mPW);

                {
                    try
                    {
                        //IConfigSource source = new IniConfigSource(fc.INIPath);
                        if (source.Configs[fc.LOGINConfig] != null)
                        {
                            string mInfo = source.Configs[fc.LOGINConfig].GetString(fc.VerifyKey, "");
                            if (mInfo.Trim() != "")
                            {
                                FINI = JsonConvert.DeserializeObject<IniJsonInfo>(fc.FDes.DecryptString(mInfo, Fkey).Trim());
                                if (FINI != null)
                                {
                                    if (FINI.VERIFY == macList[0])
                                    {
                                        IsAutoLoagin = true;
                                        tbID.Text = FINI.ID;
                                        chk01.CheckState = CheckState.Checked;
                                        btnOK.PerformClick();
                                        fc.ErrorLog("自動登入");
                                    }
                                }
                            }
                        }
                        else
                        {
                            source.Configs.Add(fc.LOGINConfig);
                            source.Save();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        fc.ErrorLog(ex.Message);
                    }

                }
            }
            FAssembly = Assembly.Load(FProjectName);
        }

        /*private void InstallFont()
        {
            try
            {

                Application.DoEvents();
                int result = -1;
                string path = @"\\10.40.40.115\Cosmos\DBA21\02953\COSMOS_RES\YaHei.Consolas.1.12.ttf";
                result = RemoveFontResourceA(path);  //0:不存在 1:已刪除
                result = AddFontResourceA(path);     //0:已經安裝過 2:安裝成功
                //splashScreenManager1.SetWaitFormDescription("正在檢查字型...完成!");
               // splashScreenManager1.CloseWaitForm();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                fc.ErrorLog(ex.Message);
            }

        }*/
        public static bool installFont(string FontFileName, string FontName)
        {
            string WinFontDir = System.Environment.GetEnvironmentVariable("WINDIR") + "\\fonts";
            int Ret;
            int Res;
            string FontPath;
            string FromFontPath = @"\\10.40.40.115\Cosmos\DBA21\02953\COSMOS_RES\YaHei.Consolas.1.12.ttf";
            FontPath = WinFontDir + "\\" + FontFileName;
            try
            {
                if (!File.Exists(FontPath))
                {
                    File.Copy(FromFontPath, FontPath); //font是程序目录下放字体的文件夹
                    /*File.Copy(System.Windows.Forms.Application.StartupPath +
                        "\\font\\" + FontFileName, FontPath); //font是程序目录下放字体的文件夹*/
                    Ret = AddFontResource(FontPath);

                    //Res = SendMessage(HWND_BROADCAST, WM_FONTCHANGE, 0, 0); 
                    //WIN7下编译会出错，不清楚什么问题。注释就行了。  
                    Ret = WriteProfileString("fonts", FontName + "(TrueType)", FontFileName);
                }
                else
                {
                    //fc.ErrorLog("[ " + FontName + " ]字体安装失败！原因：已安裝過該字型");
                }
            }
            catch (Exception ex)
            {
                fc.ErrorLog("[ " + FontName + " ]字体安装失败！原因：" + ex.Message);
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormDescription("正在載入表單...");
            Init();
            splashScreenManager1.SetWaitFormDescription("正在載入表單...完成!");
            splashScreenManager1.CloseWaitForm();
        }

        private void Login(string appId, string extendedPermissions)
        {/*
            // for .net 3.5
            // var parameters = new Dictionary<string,object>
            // parameters["client_id"] = appId;
            dynamic parameters = new ExpandoObject();
            parameters.client_id = appId;
            parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html";
            // The requested response: an access token (token), an authorization code (code), or both (code token).
            parameters.response_type = "token";

            // list of additional display modes can be found at http://developers.facebook.com/docs/reference/dialogs/#display
            parameters.display = "popup";

            //scope
            parameters.scope = "Email";

            // add the 'scope' parameter only if we have extendedPermissions.
            if (!string.IsNullOrWhiteSpace(extendedPermissions))
                parameters.scope = extendedPermissions;

            _loginUrl = fb.GetLoginUrl(parameters);
            // when the Form is loaded navigate to the login url.
            //webBrowser1.Navigate("https://www.facebook.com/dialog/oauth?client_id=843306145699388&redirect_uri=https://www.facebook.com/connect/login_success.html&scope=publish_stream,read_friendlists,email&response_type=token");
            webBrowser1.Navigate(_loginUrl.AbsoluteUri);
            */ 
        }
        private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AddPageMdi(e.Link.Item);
        }

        //public void CreateForm(string strName, string AssemblyName,string xCaption)
        public void CreateForm(NavBarItem navItem)        
        {
            if (!splashScreenManager1.IsSplashFormVisible)
            {
                //navBarControl1.Enabled = false;
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormDescription(navItem.Caption + "\r\n正在初始化.....");
                Application.DoEvents();
                //string path = FProjectName;//專案的Assembly選項名稱
                string name = FProjectName + "." + navItem.Tag; //類的名字
                //Form doc = (Form)Assembly.Load(path).CreateInstance(name);
                Form doc = (Form)FAssembly.CreateInstance(name);
                //doc.Show();
                doc.MdiParent = this;
                // 子窗体的 Text  就是 Tab页中的标题 ,我这里是直接取 navItem中的标题作为 tab页的标题
                doc.Text = navItem.Caption + " [" + navItem.Tag + "_" + tabCount++ + "]";
                // 显示  
                doc.Show();
                splashScreenManager1.SetWaitFormDescription(navItem.Caption + "\r\n正在初始化.....完成!");
                splashScreenManager1.CloseWaitForm();
            }
            //navBarControl1.Enabled = true;
        }

        // 打开子窗体方法
        private void AddPageMdi(NavBarItem navItem)
        {
            /*Form3 childForm = new Form3();
            childForm.MdiParent = this;
            // 子窗体的 Text  就是 Tab页中的标题 ,我这里是直接取 navItem中的标题作为 tab页的标题
            childForm.Text = navItem.Caption + tabCount++;
            // 显示  
            childForm.Show();*/
            // 设置当前 tab页的 图标,我这里也默认取navBar中的Item中的图标
            //xtraTabbedMdiManager1.Pages[subform].Image = navItem.SmallImage;
            //CreateForm("DXApplication9." + navItem.Tag, "DXApplication9", navItem.Caption);
            CreateForm(navItem);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           /* HtmlElement ele = webBrowser1.Document.GetElementById("email");
            if (ele != null)
                ele.InnerText = "abay1012@hotmail.com";

            ele = webBrowser1.Document.GetElementById("pass");
            if (ele != null)
                ele.InnerText = "1qazXSW@";

            ele = webBrowser1.Document.GetElementById("Login");
            if (ele != null)
                ele.InvokeMember("click");*/
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsExist = false;
                /*if (tbID.Text == "ERRIC" )            
                {
                    IsExist = true;
                }
                else*/ if (IsAutoLoagin)
                {
                    fc.FUser.ID = FINI.ID;
                    fc.FUser.Email = FINI.EMAIL;
                    fc.FUser.Name = FINI.NAME;
                    IsExist = true;
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
                    {
                        conn.Open();
                        string SQL = "SELECT TOP 1 XM002,XM004 FROM POSXM WHERE XM001 = '" + tbID.Text + "'"
                                                                + " AND XM003 = '" + fc.FDes.EncryptString(tbPW.Text, Fkey) + "'";
                        using (SqlCommand cmd = new SqlCommand(SQL, conn))
                        {
                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    IsExist = true;
                                    fc.FUser.ID = tbID.Text;
                                    fc.FUser.Email = dr[0].ToString();
                                    fc.FUser.Name = dr[1].ToString();
                                }
                            }
                        }
                    }           
                }
                if (IsExist)
                {
                    navBarControl1.Enabled = true;
                    splitterControl1.Visible = true;
                    panel1.Visible = false;
                    Text = Text + "[" + fc.FUser.Name + "]";
                    if (chk01.Checked && macList.Count > 0)
                    {
                        //用Linq直接組
                        var result = new
                        {
                            ID = fc.FUser.ID,
                            NAME = fc.FUser.Name,
                            EMAIL = fc.FUser.Email,                        
                            VERIFY = macList[0]
                        };
                        string str = JsonConvert.SerializeObject(result);
                        IConfigSource source = new IniConfigSource(fc.INIPath);
                        source.Configs[fc.LOGINConfig].Set(fc.VerifyKey, fc.FDes.EncryptString(str, Fkey));
                        source.Save();
                    }
                    tbPW.Text = "";
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    tbID.Focus();
                    MessageBox.Show("帳號或密碼錯誤!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                fc.ErrorLog(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            RESAI03 ai03 = new RESAI03();
            ai03.ShowDialog();
        }

        private void navBarItem_Logout_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            this.Text = "COSMOS訂餐系統 Ver " + fc.GetVersion() + " ";
            navBarControl1.Enabled = false;
            splitterControl1.Visible = false;
            panel1.Visible = true;
            IsAutoLoagin = false;
            tbPW.Focus();

            IConfigSource source = new IniConfigSource(fc.INIPath);
            if (source.Configs[fc.LOGINConfig] != null)
            {
                source.Configs[fc.LOGINConfig].Set(fc.VerifyKey,"");
                source.Save();
            }
            this.WindowState = FormWindowState.Normal;
        }

        private void RESMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F3)
            {
                navBarControl1.Enabled = true;
                splitterControl1.Visible = true;
                panel1.Visible = false;
                tbPW.Text = "";
                Text = Text + "[" + fc.FUser.Name + "]";
            }
        }

        private void tbID_Enter(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraEditors.TextEdit).SelectAll();
        }

        public void SetMarqueeStr(string str)
        {
            barMarquee.Caption = str;
        }
        public void ShowMarqueeStr(bool IsShow)
        {
            bar3.Visible = IsShow;
        }
    }
}
