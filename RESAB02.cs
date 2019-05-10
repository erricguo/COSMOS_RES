using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;

namespace COSMOS_RES
{
    public partial class RESAB02 : RootForm
    {
        RESMain main = null;
        string mID = "";
        string pdfName = "";
        string mXA001 = "";
        string mDate = "";
        string mName = "";
        //string mStoreName = "";
        byte[] buffer = null;
        byte[] buffer2 = null;
        bool mWriteData = false;
        string FXM003 = "";
        public RESAB02()
        {
            InitializeComponent();
        }
        public RESMain SetRESMain
        {
            set
            {
                main = value;
            }
        }
        public string SetID
        {
            set
            {
                mID = value;
            }
        }
        public string SetXA001
        {
            set
            {
                mXA001 = value;
            }
        }
        public string SetDate
        {
            set
            {
                mDate = value;
            }
        }
        public string SetSubject
        {
            set
            {
                tb01.Text = value;                     
            }
        }
        public string SetPDFName
        {
            set
            {
                pdfName = value;
            }
        }
        public string SetStoreName
        {
            set
            {
                rd01.RCText = "Dear All:\r\n" +
                              "      開始訂餐囉~~ 沒訂到的就要吃自己啦!\r\n";
                if (value != "")
                    rd01.RCText += "      今天訂購的店家是【" + value + "】\r\n";
            }
        }

        public string SetOrderTime
        {
            set
            {
                if (value != "")
                    rd01.RCText += "      接受訂購時間【" + value + "】\r\n";
            }
        }
        public byte[] SetBuffer
        {
            set
            {
                buffer = value;
            }
        }
        public bool SetWriteData
        {
            set
            {
                mWriteData = value;
            }
        }
        public void MenuPreView()
        {
            REPAR02 report = new REPAR02();
            report.SetFilter = " XA001 = '" + mXA001 + "'";
            report.SetDate = mDate;
            report.ShowRibbonPreview();
        }
        private void POSAB02_Load(object sender, EventArgs e)
        {
            if (mID == "")
            {
                mID = fc.FUser.ID;
            }

            if (mID != "")
            {
                QueryMain();
            }            
            GV_Main.Columns[0].Width = 50;
            GV_Main.Columns[1].Width = 65;
            GV_Main.Columns[2].Width = 65;
            GV_Main.Columns[3].Width = GC_Main.Width - 220;

            rd01.SetRCSize = new Size[] { new Size(731, 298), new Size(731, 585) };
        }

        private void QueryMain()
        {
            using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT XM002,XM003,XM004 FROM POSXM WHERE XM001= "+ mID, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            XM002.Text = dr["XM002"].ToString();
                            XM003.Text = dr["XM003"].ToString();
                            FXM003 = XM003.Text;
                            mName = dr["XM004"].ToString();
                            //XM004.Text = fc.FDes.DecryptString(dr["XM003"].ToString(),fc.FDes.GenerateKey());                            
                        }
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (main == null)
            {
                (Parent.Parent as RESMain).SetMarqueeStr("正在傳送郵件");
                (Parent.Parent as RESMain).ShowMarqueeStr(true);
            }
            else
            {
                main.SetMarqueeStr("正在傳送郵件");
                main.ShowMarqueeStr(true);
            }
            string MailServer = "mail-tchdb1.digiwin.biz";
            //string MailServer = "mail-tch.digiwin.biz";
            if (FXM003 != XM003.Text)
            {
                XM003.Text = fc.FDes.EncryptString(XM003.Text, fc.FDes.GenerateKey());
            }
            string pw = fc.FDes.DecryptString(XM003.Text, fc.FDes.GenerateKey());
            string MailtoDigiwin = "";
            string MailtoGMail = "";
            for (int i = 0; i < GV_Main.RowCount;i++ )
            {
                if (GV_Main.GetRowCellValue(i, "XM002").ToString().ToLower().Contains("digiwin.biz"))
                {
                    MailtoDigiwin += GV_Main.GetRowCellValue(i, "XM002") + ",";
                }
                else if (GV_Main.GetRowCellValue(i, "XM002").ToString().ToLower().Contains("gmail.com"))
                {
                    MailtoGMail += GV_Main.GetRowCellValue(i, "XM002") + ",";
                }     
            }
            if (MailtoDigiwin.EndsWith(","))
            {
                MailtoDigiwin = MailtoDigiwin.Substring(0, MailtoDigiwin.Length - 1);
            }
            if (MailtoGMail.EndsWith(","))
            {
                MailtoGMail = MailtoGMail.Substring(0, MailtoGMail.Length - 1);
            }

            //DSC 
            REPAR02 report = new REPAR02();
            report.SetFilter = " XA001 = '" + mXA001 + "'";
            report.SetDate = mDate;
            //report.ShowPreviewDialog();

            // Create a new memory stream and export the report into it as PDF.
            MemoryStream mem = new MemoryStream();
            report.ExportToPdf(mem);

            // Create a new attachment and put the PDF report into it.
            mem.Seek(0, System.IO.SeekOrigin.Begin);
            System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(mem, DateTime.Now.ToString("yyyyMMdd") + "_Menu.pdf", "application/pdf");

            System.Net.Mail.Attachment imageAttachment = null;
            if (buffer != null)
            {
                MemoryStream ms = new MemoryStream(buffer);
                System.Net.Mime.ContentType contentType = new System.Net.Mime.ContentType();
                contentType.MediaType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
                contentType.Name = "menu.jpg";
                imageAttachment = new System.Net.Mail.Attachment(ms, contentType);
            }

            if (MailtoDigiwin.Trim()!="")
            {
                SmtpClient client = new SmtpClient(MailServer);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(XM002.Text, pw, MailServer);
                MailMessage message = new MailMessage();
                message.Attachments.Add(att);
                if (imageAttachment != null)
                {
                    message.Attachments.Add(imageAttachment);
                }
                message.From = new MailAddress(XM002.Text, mName);
                message.To.Add(MailtoDigiwin);
                message.Subject = tb01.Text;
                message.Body = rd01.HtmlText;
                message.IsBodyHtml = true;
                message = rd01.CreateExporter(rd01.GetRC, message);
                //client.Send(message);
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);//回调函数
                string userState = "寄出郵件";
                client.SendAsync(message, userState);

            }
            //mem.Close();
            //mem.Flush();
 
            // Create a new attachment and put the PDF report into it.
            if (MailtoGMail.Trim()!="")
            {            
                //GMAIL
                MailMessage mail = new MailMessage();
                
                mail.From = new MailAddress("erricguo@gmail.com", "郭育宏");
                mail.To.Add(MailtoGMail);
                mail.Subject = tb01.Text;
                mail.Body = rd01.RCText;
                mail.IsBodyHtml = true;
                mail.Attachments.Add(att);
                if (imageAttachment != null)
                {
                    mail.Attachments.Add(imageAttachment);
                }
                NetworkCredential cred = new NetworkCredential("erricguo@gmail.com", "zz10121205");
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                //smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = cred;
                //smtp.Send(mail);
                mail = rd01.CreateExporter(rd01.GetRC, mail);
                smtp.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback2);//回调函数
                string userState = "寄出郵件";
                smtp.SendAsync(mail, userState);
            }
            //mem.Close();
            //mem.Flush();
            
            if (mWriteData)
            {
                string mXP002 = "";
                using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
                {
                    conn.Open();
                    try
                    {
                        string SQL = "SELECT TOP 1 XP002 FROM POSXP WHERE XP001=@XP001 ORDER BY XP002 DESC";
                        using (SqlCommand cmd = new SqlCommand(SQL, conn))
                        {
                            cmd.Parameters.AddWithValue("@XP001", pdfName);
                            SqlDataReader rd = cmd.ExecuteReader();
                            if (rd.Read())
                            {
                                mXP002 = string.Format("{0:0000}", Int32.Parse(rd["XP002"].ToString()) + 1);
                            }
                            else
                            {
                                mXP002 = "0001";
                            }
                            rd.Close();
                            cmd.Cancel();
                        }

                        SQL = "INSERT INTO POSXP (XP001,XP002,XP003) VALUES(@XP001,@XP002,@XP003)";
                        using (SqlCommand cmd = new SqlCommand(SQL, conn))
                        {
                            cmd.Parameters.AddWithValue("@XP001", pdfName);
                            cmd.Parameters.AddWithValue("@XP002", mXP002);
                            cmd.Parameters.AddWithValue("@XP003", mID);
                            cmd.ExecuteNonQuery();   
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        fc.ErrorLog(ex.Message);
                    }
                }

                DataTable dt = new DataTable("POSXQ");
                dt.Columns.Add("XQ001", typeof(string));
                dt.Columns.Add("XQ002", typeof(string));
                dt.Columns.Add("XQ003", typeof(string));
                for (int i = 0; i < GV_Main.RowCount; i++)
                {
                    dt.Rows.Add(pdfName, mXP002, GV_Main.GetRowCellValue(i, "XM001"));
                }
                DataView dv = dt.DefaultView;
                DataTable dtsort = dv.ToTable();
                Stopwatch sw = new Stopwatch();
                sw.Reset();
                sw.Start();
                InsertV4(dtsort); //using SqlBulkCopy 
            }
            

            // Create a new memory stream and export the report into it as PDF.
            /*MemoryStream mem = new MemoryStream();
            report.ExportToPdf(mem);
            // Create a new attachment and put the PDF report into it.
            mem.Seek(0, System.IO.SeekOrigin.Begin);
            System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(mem, "TestReport.pdf", "application/pdf");

            SmtpClient client = new SmtpClient("mail-tchdb1.digiwin.biz");  
            client.DeliveryMethod = SmtpDeliveryMethod.Network;  
	 
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("erric", "zz10121205", "mail-tchdb1.digiwin.biz");

            MailMessage message = new MailMessage();
            message.Attachments.Add(att);
                
            // Specify sender and recipient options for the e-mail message.
            message.From = new MailAddress("erric@digiwin.biz", "erricguo");
            message.To.Add("erric@digiwin.biz,aveinswu@digiwin.biz");
            // Specify other e-mail options.
            message.Subject = "Subject";
            message.Body = "This is a test e-mail message sent by an application.";
            client.Send(message);
            // Close the memory stream.
            mem.Close();
            mem.Flush();*/

            
            // Create a new report.                
            /*RESAR02 report = new RESAR02();
            report.SetFilter = " XA001 = '" + mXA001 + "'";
            report.SetDate =  mDate;
            report.ShowPreviewDialog();
            //if (report.ShowPageSetupDialog() == DialogResult.OK)
            {
                // Create a new memory stream and export the report into it as PDF.
                MemoryStream mem = new MemoryStream();
                report.ExportToPdf(mem);

                // Create a new attachment and put the PDF report into it.
                mem.Seek(0, System.IO.SeekOrigin.Begin);
                System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(mem, DateTime.Now.ToString("yyyyMMdd") + "_Menu.pdf", "application/pdf");

                // Create a new message and attach the PDF report to it.
                MailMessage mail = new MailMessage();
                mail.Attachments.Add(att);

                // Specify sender and recipient options for the e-mail message.
                mail.From = new MailAddress("erric@digiwin.biz", "erricguo");
                mail.To.Add(Mailto);
                // Specify other e-mail options.
                mail.Subject = tb01.Text;
                mail.Body = rd01.Text;

                //設定SMTP
                NetworkCredential cred = new NetworkCredential("erricguo@gmail.com", pw);
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = cred;
                smtp.Port = 587;
                smtp.Send(mail);

                // Close the memory stream.
                mem.Close();
                mem.Flush();
            }*/
        }

        private void SendCompletedCallback2(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)  //邮件发送被取消
            {

            }
            if (e.Error != null)   //邮件发送失败
            {
                fc.ErrorLog(e.Error.Message);
                fc.Emsg("郵件發送失敗!+\r\n" + e.Error.Message);
            }
            else   //发送成功
            {

            }
        }

        private void SendCompletedCallback(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)  //邮件发送被取消
            {
                if (main == null)
                {
                    (Parent.Parent as RESMain).ShowMarqueeStr(false);
                }
                else
                {
                    main.ShowMarqueeStr(false);
                }
            }
            if (e.Error != null)   //邮件发送失败
            {
                if (main == null)
                {
                    (Parent.Parent as RESMain).ShowMarqueeStr(false);
                }
                else
                {
                    main.ShowMarqueeStr(false);
                }
                fc.ErrorLog(e.Error.Message);
                fc.Emsg("郵件發送失敗!+\r\n"+e.Error.Message);
            }
            else   //发送成功
            {
                if (main == null)
                {
                    (Parent.Parent as RESMain).ShowMarqueeStr(false);
                }
                else
                {
                    main.ShowMarqueeStr(false);
                }
                fc.Emsg("郵件已發送!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            {
                bool IsExist = false;
                F2Window f2 = new F2Window(this);
                f2.SetMI = new string[] { "POSXM", "001" };
                f2.SetMuity = true;                
                Dictionary<int, List<string>> muity = null;
                if (f2.GetMI)
                {
                    muity = f2.GetMuity;
                    DataTable dt = null;
                    if (GC_Main.DataSource == null)
                    {
                        dt = new DataTable();
                        dt.Columns.Add("Select");
                        dt.Columns.Add("XM001");
                        dt.Columns.Add("XM004");
                        dt.Columns.Add("XM002");
                        GC_Main.DataSource = dt;
                    }
                    else
                    {
                        dt = (DataTable)GC_Main.DataSource;
                    }

                    foreach (KeyValuePair<int, List<string>> s in muity)
                    {
                        for (int i = 0; i < GV_Main.RowCount; i++)
                        {
                            if (GV_Main.GetRowCellValue(i, "XM004").ToString() == s.Value[0])
                            {
                                IsExist = true;
                                break;
                            }
                        }
                        if (IsExist)
                        {
                            IsExist = false;
                            continue;
                        }
                        else
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = "N";
                            dr[1] = s.Value[0];
                            dr[2] = s.Value[1];
                            dr[3] = s.Value[2];
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }   
        }

        private void GV_Main_MouseDown(object sender, MouseEventArgs e)
        {
            //if (IsMuity)
            {
                GridHitInfo hitInfo = GV_Main.CalcHitInfo(e.Location);
                if (hitInfo == null || hitInfo.Column == null)
                {
                    return;
                }
                if (hitInfo.InRowCell)
                {
                    if (hitInfo.Column.RealColumnEdit is RepositoryItemCheckEdit)
                    {
                        GV_Main.FocusedColumn = hitInfo.Column;
                        GV_Main.FocusedRowHandle = hitInfo.RowHandle;
                        GV_Main.ShowEditor();
                        CheckEdit edit = GV_Main.ActiveEditor as CheckEdit;
                        if (edit == null) return;
                        edit.Toggle();
                        DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                        GV_Main.CloseEditor();
                    }
                }
            }
        }

        private void btnDelOne_Click(object sender, EventArgs e)
        {            
            int i=0;
            while (i < GV_Main.RowCount)
            {
                if (GV_Main.GetRowCellValue(i, "Select").ToString() == "Y")
                {
                    GV_Main.DeleteRow(i);
                }
                else
                    i++;
            }
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < GV_Main.RowCount)
            {                
                GV_Main.DeleteRow(i);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            bool IsExist = false;
            F2Window f2 = new F2Window(this);
            f2.SetMI = new string[] { "POSXM", "001" };
            f2.SetMuity = true;
            f2.SetShowWindow = false;
            Dictionary<int, List<string>> muity = null;
            if (f2.GetMI)
            {
                muity = f2.GetMuity;
                DataTable dt = null;
                if (GC_Main.DataSource == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("Select");
                    dt.Columns.Add("XM001");
                    dt.Columns.Add("XM004");
                    dt.Columns.Add("XM002");
                    GC_Main.DataSource = dt;
                }
                else
                {
                    dt = (DataTable)GC_Main.DataSource;
                }

                foreach (KeyValuePair<int, List<string>> s in muity)
                {
                    for (int i = 0; i < GV_Main.RowCount; i++)
                    {
                        if (GV_Main.GetRowCellValue(i, "XM004").ToString() == s.Value[0])
                        {
                            IsExist = true;
                            break;
                        }
                    }
                    if (IsExist)
                    {
                        IsExist = false;
                        continue;
                    }
                    else
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] = "N";
                        dr[1] = s.Value[0];
                        dr[2] = s.Value[1];
                        dr[3] = s.Value[2];
                        dt.Rows.Add(dr);
                    }
                }
            }
        }

        private void InsertV4(DataTable srcdata)
        {
            using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                //SqlBulkCopy批次處理新增 沒有檢驗比對處理
                using (SqlBulkCopy bulkCopy =
                           new SqlBulkCopy(conn, SqlBulkCopyOptions.KeepIdentity, trans))
                {
                    bulkCopy.DestinationTableName = "dbo.POSXQ";
                    bulkCopy.WriteToServer(srcdata);
                }

                trans.Commit();
            }
        }

        private void btnOldLList_Click(object sender, EventArgs e)
        {
            //string mXQ003 = "";
            Dictionary<int, List<string>> muity = new Dictionary<int, List<string>>();
            using (SqlConnection conn = new SqlConnection(fc.makeConnectString(fc.FDBInfo)))
            {
                conn.Open();
                try
                {
                    string SQL = " SELECT XQ003 XM001,XM004,XM002 FROM POSXQ " +
                                 " LEFT JOIN( " +
                                 " SELECT TOP 1 XP001,XP002 FROM POSXP " +
                                 " ORDER BY XP001 DESC,XP002 DESC) A ON XQ001=XP001 AND XQ002=XP002 " +
                                 " LEFT JOIN POSXM ON XQ003=XM001 " +
                                 " WHERE XP001 IS NOT NULL ";
                    using (SqlCommand cmd = new SqlCommand(SQL, conn))
                    {
                        SqlDataReader rd = cmd.ExecuteReader();
                        int i = 0;
                        while(rd.Read())
                        {
                            muity.Add(i++, new List<string>() { rd["XM001"].ToString(), rd["XM004"].ToString(), rd["XM002"].ToString() });
                        }
                        rd.Close();
                        cmd.Cancel();
                    }
                    conn.Close();
                }
                catch (System.Exception ex)
                {
                    fc.ErrorLog(ex.Message);
                    conn.Close();
                }
            }

            bool IsExist = false;
            DataTable dt = null;
            if (GC_Main.DataSource == null)
            {
                dt = new DataTable();
                dt.Columns.Add("Select");
                dt.Columns.Add("XM001");
                dt.Columns.Add("XM004");
                dt.Columns.Add("XM002");
                GC_Main.DataSource = dt;
            }
            else
            {
                dt = (DataTable)GC_Main.DataSource;
            }

            foreach (KeyValuePair<int, List<string>> s in muity)
            {
                for (int i = 0; i < GV_Main.RowCount; i++)
                {
                    if (GV_Main.GetRowCellValue(i, "XM004").ToString() == s.Value[0])
                    {
                        IsExist = true;
                        break;
                    }
                }
                if (IsExist)
                {
                    IsExist = false;
                    continue;
                }
                else
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = "N";
                    dr[1] = s.Value[0];
                    dr[2] = s.Value[1];
                    dr[3] = s.Value[2];
                    dt.Rows.Add(dr);
                }
                
            }
        }
        public static void SmtpClient_OnCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //Get the Original MailMessage object
            MailMessage mail = (MailMessage)e.UserState;

            //write out the subject
            string subject = mail.Subject;

            if (e.Cancelled)
            {
                Console.WriteLine("Send canceled for mail with subject [{0}].", subject);
            }
            if (e.Error != null)
            {
                Console.WriteLine("Error {1} occurred when sending mail [{0}] ", subject, e.Error.ToString());
            }
            else
            {
                Console.WriteLine("Message [{0}] sent.", subject);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (rd01.Height == 585)
            {
                rd01.Size = new System.Drawing.Size(731, 298);
            }
            else
            {
                rd01.Size = new System.Drawing.Size(731, 585);
            }
        }
    }
}
