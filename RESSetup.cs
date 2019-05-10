using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Nini.Config;
using System.Data.SqlClient;

namespace COSMOS_RES
{
    public partial class RESSetup : DevExpress.XtraEditors.XtraForm
    {
        public RESSetup()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            IConfigSource source = new IniConfigSource(fc.INIPath);
            edLocalDBIP.Text = source.Configs[fc.DBINFOConfig].Get("IP", "127.0.0.1");
            edLocalDBName.Text = source.Configs[fc.DBINFOConfig].Get("DB", "RESEX");
            edLocalDBid.Text = source.Configs[fc.DBINFOConfig].Get("ID", "sa");
            string mPW = "123";
            if (source.Configs[fc.DBINFOConfig].Get("PW", null) != null)
            {
                mPW = fc.FDes.DecryptString(source.Configs[fc.DBINFOConfig].Get("PW", "123"), fc.FDes.GenerateKey());
            }
            edLocalDBpass.Text = mPW;
        }

        private void SetLocation()
        {
            btn_OK.Location = new Point(this.Width - btn_OK.Width - 145, this.Height - btn_OK.Height - 15);
            btn_No.Location = new Point(this.Width - btn_No.Width - 15, this.Height - btn_No.Height - 15);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                IConfigSource source = new IniConfigSource(fc.INIPath);
                source.Configs[fc.DBINFOConfig].Set("IP", edLocalDBIP.Text);
                source.Configs[fc.DBINFOConfig].Set("DB", edLocalDBName.Text);
                source.Configs[fc.DBINFOConfig].Set("ID", edLocalDBid.Text);
                source.Configs[fc.DBINFOConfig].Set("PW", fc.FDes.EncryptString(edLocalDBpass.Text, fc.FDes.GenerateKey()));
                source.Save();

                fc.FDBInfo.SetDBInfo(edLocalDBIP.Text, edLocalDBName.Text, edLocalDBid.Text, edLocalDBpass.Text);
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                fc.ErrorLog(ex.Message);
                return;
            }
        }

        private void RESSetup_Shown(object sender, EventArgs e)
        {
            
        }

        private void RESSetup_Resize(object sender, EventArgs e)
        {
            SetLocation();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbtnLocalTest_Click(object sender, EventArgs e)
        {
            string mRes = "Persist Security Info=true" +
              ";Integrated Security=" +
              ";Data Source=" + edLocalDBIP.Text +
              ";Initial Catalog=" + edLocalDBName.Text +
              ";User ID=" + edLocalDBid.Text +
              ";Password=" + edLocalDBpass.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(mRes))
                {
                    conn.Open();
                    fc.msg("連接成功!!", "資訊");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                fc.ErrorLog(ex.Message);
            }
        }
    }
}