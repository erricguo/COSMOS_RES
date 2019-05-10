namespace COSMOS_RES
{
    partial class RESAI05
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label LBXI001;
            System.Windows.Forms.Label LBXI002;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RESAI05));
            this.XI001 = new DevExpress.XtraEditors.TextEdit();
            this.pOSXIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_RESAI05 = new COSMOS_RES.DataSet.DS_RESAI05();
            this.XI002 = new DevExpress.XtraEditors.TextEdit();
            this.pOSXITableAdapter = new COSMOS_RES.DataSet.DS_RESAI05TableAdapters.POSXITableAdapter();
            this.pOSXLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSXLTableAdapter = new COSMOS_RES.DataSet.DS_RESAI05TableAdapters.POSXLTableAdapter();
            LBXI001 = new System.Windows.Forms.Label();
            LBXI002 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlMain)).BeginInit();
            this.TabControlMain.SuspendLayout();
            this.TP_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XI001.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESAI05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XI002.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Size = new System.Drawing.Size(585, 434);
            // 
            // panelControl3
            // 
            this.panelControl3.LookAndFeel.SkinName = "Xmas 2008 Blue";
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Size = new System.Drawing.Size(581, 430);
            // 
            // TP_Browse
            // 
            this.TP_Browse.Size = new System.Drawing.Size(869, 126);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(LBXI002);
            this.panelControl4.Controls.Add(this.XI002);
            this.panelControl4.Controls.Add(LBXI001);
            this.panelControl4.Controls.Add(this.XI001);
            this.panelControl4.LookAndFeel.SkinName = "Summer 2008";
            this.panelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl4.Size = new System.Drawing.Size(570, 126);
            // 
            // TabControlMain
            // 
            this.TabControlMain.AppearancePage.Header.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlMain.AppearancePage.Header.Options.UseFont = true;
            this.TabControlMain.LookAndFeel.SkinName = "Black";
            this.TabControlMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TabControlMain.SelectedTabPage = this.TP_Detail;
            this.TabControlMain.Size = new System.Drawing.Size(575, 159);
            // 
            // TP_Detail
            // 
            this.TP_Detail.Size = new System.Drawing.Size(570, 126);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(3, 162);
            this.splitterControl1.LookAndFeel.SkinName = "Office 2007 Black";
            this.splitterControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.splitterControl1.Size = new System.Drawing.Size(575, 4);
            // 
            // LBXI001
            // 
            LBXI001.AutoSize = true;
            LBXI001.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            LBXI001.Location = new System.Drawing.Point(29, 34);
            LBXI001.Name = "LBXI001";
            LBXI001.Size = new System.Drawing.Size(109, 20);
            LBXI001.TabIndex = 0;
            LBXI001.Text = "店家類別序號:";
            // 
            // LBXI002
            // 
            LBXI002.AutoSize = true;
            LBXI002.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            LBXI002.Location = new System.Drawing.Point(29, 71);
            LBXI002.Name = "LBXI002";
            LBXI002.Size = new System.Drawing.Size(109, 20);
            LBXI002.TabIndex = 2;
            LBXI002.Text = "店家類別名稱:";
            // 
            // XI001
            // 
            this.XI001.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pOSXIBindingSource, "XI001", true));
            this.XI001.Location = new System.Drawing.Point(144, 31);
            this.XI001.MenuManager = this.barManager1;
            this.XI001.Name = "XI001";
            this.XI001.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.XI001.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XI001.Properties.Appearance.Options.UseBackColor = true;
            this.XI001.Properties.Appearance.Options.UseFont = true;
            this.XI001.Size = new System.Drawing.Size(100, 26);
            this.XI001.TabIndex = 1;
            // 
            // pOSXIBindingSource
            // 
            this.pOSXIBindingSource.DataMember = "POSXI";
            this.pOSXIBindingSource.DataSource = this.dS_RESAI05;
            // 
            // dS_RESAI05
            // 
            this.dS_RESAI05.DataSetName = "DS_RESAI05";
            this.dS_RESAI05.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // XI002
            // 
            this.XI002.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pOSXIBindingSource, "XI002", true));
            this.XI002.Location = new System.Drawing.Point(144, 68);
            this.XI002.MenuManager = this.barManager1;
            this.XI002.Name = "XI002";
            this.XI002.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XI002.Properties.Appearance.Options.UseFont = true;
            this.XI002.Size = new System.Drawing.Size(211, 26);
            this.XI002.TabIndex = 3;
            // 
            // pOSXITableAdapter
            // 
            this.pOSXITableAdapter.ClearBeforeFill = true;
            // 
            // pOSXLBindingSource
            // 
            this.pOSXLBindingSource.DataMember = "POSXL";
            this.pOSXLBindingSource.DataSource = this.dS_RESAI05;
            // 
            // pOSXLTableAdapter
            // 
            this.pOSXLTableAdapter.ClearBeforeFill = true;
            // 
            // RESAI05
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(585, 504);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RESAI05";
            this.Text = "店家類別建立作業";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlMain)).EndInit();
            this.TabControlMain.ResumeLayout(false);
            this.TP_Detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XI001.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESAI05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XI002.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit XI002;
        private DevExpress.XtraEditors.TextEdit XI001;
        private System.Windows.Forms.BindingSource pOSXIBindingSource;
        private DataSet.DS_RESAI05 dS_RESAI05;
        private DataSet.DS_RESAI05TableAdapters.POSXITableAdapter pOSXITableAdapter;
        private System.Windows.Forms.BindingSource pOSXLBindingSource;
        private DataSet.DS_RESAI05TableAdapters.POSXLTableAdapter pOSXLTableAdapter;
    }
}
