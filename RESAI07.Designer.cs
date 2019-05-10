namespace COSMOS_RES
{
    partial class RESAI07
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
            System.Windows.Forms.Label xH001Label;
            System.Windows.Forms.Label xH002Label;
            System.Windows.Forms.Label xH003Label;
            System.Windows.Forms.Label xH004Label;
            this.dS_RESAI07 = new COSMOS_RES.DataSet.DS_RESAI07();
            this.pOSXHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSXHTableAdapter = new COSMOS_RES.DataSet.DS_RESAI07TableAdapters.POSXHTableAdapter();
            this.tableAdapterManager = new COSMOS_RES.DataSet.DS_RESAI07TableAdapters.TableAdapterManager();
            this.XH002 = new DevExpress.XtraEditors.TextEdit();
            this.XH003 = new DevExpress.XtraEditors.TextEdit();
            this.XH004 = new DevExpress.XtraEditors.TextEdit();
            this.XH001 = new DevExpress.XtraEditors.LookUpEdit();
            xH001Label = new System.Windows.Forms.Label();
            xH002Label = new System.Windows.Forms.Label();
            xH003Label = new System.Windows.Forms.Label();
            xH004Label = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESAI07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XH002.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XH003.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XH004.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XH001.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // panelControl3
            // 
            this.panelControl3.LookAndFeel.SkinName = "Xmas 2008 Blue";
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(xH004Label);
            this.panelControl4.Controls.Add(xH003Label);
            this.panelControl4.Controls.Add(this.XH003);
            this.panelControl4.Controls.Add(xH002Label);
            this.panelControl4.Controls.Add(this.XH002);
            this.panelControl4.Controls.Add(xH001Label);
            this.panelControl4.Controls.Add(this.XH004);
            this.panelControl4.Controls.Add(this.XH001);
            this.panelControl4.LookAndFeel.SkinName = "Summer 2008";
            this.panelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // TabControlMain
            // 
            this.TabControlMain.AppearancePage.Header.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlMain.AppearancePage.Header.Options.UseFont = true;
            this.TabControlMain.LookAndFeel.SkinName = "Black";
            this.TabControlMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TabControlMain.SelectedTabPage = this.TP_Detail;
            // 
            // xH001Label
            // 
            xH001Label.AutoSize = true;
            xH001Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            xH001Label.Location = new System.Drawing.Point(89, 54);
            xH001Label.Name = "xH001Label";
            xH001Label.Size = new System.Drawing.Size(45, 20);
            xH001Label.TabIndex = 0;
            xH001Label.Text = "型態:";
            // 
            // xH002Label
            // 
            xH002Label.AutoSize = true;
            xH002Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            xH002Label.Location = new System.Drawing.Point(89, 91);
            xH002Label.Name = "xH002Label";
            xH002Label.Size = new System.Drawing.Size(45, 20);
            xH002Label.TabIndex = 2;
            xH002Label.Text = "代號:";
            // 
            // xH003Label
            // 
            xH003Label.AutoSize = true;
            xH003Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            xH003Label.Location = new System.Drawing.Point(89, 129);
            xH003Label.Name = "xH003Label";
            xH003Label.Size = new System.Drawing.Size(45, 20);
            xH003Label.TabIndex = 4;
            xH003Label.Text = "名稱:";
            // 
            // xH004Label
            // 
            xH004Label.AutoSize = true;
            xH004Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            xH004Label.Location = new System.Drawing.Point(89, 170);
            xH004Label.Name = "xH004Label";
            xH004Label.Size = new System.Drawing.Size(45, 20);
            xH004Label.TabIndex = 6;
            xH004Label.Text = "加價:";
            // 
            // dS_RESAI07
            // 
            this.dS_RESAI07.DataSetName = "DS_RESAI07";
            this.dS_RESAI07.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOSXHBindingSource
            // 
            this.pOSXHBindingSource.DataMember = "POSXH";
            this.pOSXHBindingSource.DataSource = this.dS_RESAI07;
            // 
            // pOSXHTableAdapter
            // 
            this.pOSXHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.POSXHTableAdapter = this.pOSXHTableAdapter;
            this.tableAdapterManager.UpdateOrder = COSMOS_RES.DataSet.DS_RESAI07TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // XH002
            // 
            this.XH002.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pOSXHBindingSource, "XH002", true));
            this.XH002.Location = new System.Drawing.Point(140, 88);
            this.XH002.MenuManager = this.barManager1;
            this.XH002.Name = "XH002";
            this.XH002.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XH002.Properties.Appearance.Options.UseFont = true;
            this.XH002.Size = new System.Drawing.Size(152, 26);
            this.XH002.TabIndex = 3;
            // 
            // XH003
            // 
            this.XH003.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pOSXHBindingSource, "XH003", true));
            this.XH003.EditValue = "";
            this.XH003.Location = new System.Drawing.Point(140, 126);
            this.XH003.MenuManager = this.barManager1;
            this.XH003.Name = "XH003";
            this.XH003.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XH003.Properties.Appearance.Options.UseFont = true;
            this.XH003.Size = new System.Drawing.Size(280, 26);
            this.XH003.TabIndex = 5;
            // 
            // XH004
            // 
            this.XH004.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pOSXHBindingSource, "XH004", true));
            this.XH004.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.XH004.Location = new System.Drawing.Point(140, 167);
            this.XH004.MenuManager = this.barManager1;
            this.XH004.Name = "XH004";
            this.XH004.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XH004.Properties.Appearance.Options.UseFont = true;
            this.XH004.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.XH004.Properties.Mask.EditMask = "n0";
            this.XH004.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.XH004.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.XH004.Size = new System.Drawing.Size(115, 26);
            this.XH004.TabIndex = 7;
            // 
            // XH001
            // 
            this.XH001.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pOSXHBindingSource, "XH001", true));
            this.XH001.Location = new System.Drawing.Point(140, 51);
            this.XH001.MenuManager = this.barManager1;
            this.XH001.Name = "XH001";
            this.XH001.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XH001.Properties.Appearance.Options.UseFont = true;
            this.XH001.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.XH001.Properties.DataSource = this.pOSXHBindingSource;
            this.XH001.Properties.NullText = "";
            this.XH001.Properties.PopupSizeable = false;
            this.XH001.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.XH001.Properties.ValueMember = "XH001";
            this.XH001.Size = new System.Drawing.Size(152, 26);
            this.XH001.TabIndex = 1;
            // 
            // RESAI07
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(662, 527);
            this.Name = "RESAI07";
            this.Load += new System.EventHandler(this.RESAI07_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESAI07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XH002.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XH003.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XH004.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XH001.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet.DS_RESAI07 dS_RESAI07;
        private System.Windows.Forms.BindingSource pOSXHBindingSource;
        private DataSet.DS_RESAI07TableAdapters.POSXHTableAdapter pOSXHTableAdapter;
        private DataSet.DS_RESAI07TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit XH003;
        private DevExpress.XtraEditors.TextEdit XH002;
        private DevExpress.XtraEditors.TextEdit XH004;
        private DevExpress.XtraEditors.LookUpEdit XH001;
    }
}
