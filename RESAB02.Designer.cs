using COSMOS_RES.DataSet;
namespace COSMOS_RES
{
    partial class RESAB02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label xM003Label;
            System.Windows.Forms.Label xM004Label;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RESAB02));
            this.XM002 = new DevExpress.XtraEditors.TextEdit();
            this.pOSXMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESLeaderDataSet = new COSMOS_RES.DataSet.RESLeaderDataSet();
            this.XM003 = new DevExpress.XtraEditors.TextEdit();
            this.tb01 = new DevExpress.XtraEditors.TextEdit();
            this.memo02 = new DevExpress.XtraEditors.MemoEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.pOSXMTableAdapter = new COSMOS_RES.DataSet.RESLeaderDataSetTableAdapters.POSXMTableAdapter();
            this.tableAdapterManager = new COSMOS_RES.DataSet.RESLeaderDataSetTableAdapters.TableAdapterManager();
            this.btnF2 = new DevExpress.XtraEditors.SimpleButton();
            this.GC_Main = new DevExpress.XtraGrid.GridControl();
            this.GV_Main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnDelOne = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnOldLList = new DevExpress.XtraEditors.SimpleButton();
            this.posxmTableAdapter1 = new COSMOS_RES.DataSet.RESLeaderDataSetTableAdapters.POSXMTableAdapter();
            this.rd01 = new RichEditEX.RichEditControlEX();
            xM003Label = new System.Windows.Forms.Label();
            xM004Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XM002.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESLeaderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XM003.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb01.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo02.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // xM003Label
            // 
            xM003Label.AutoSize = true;
            xM003Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            xM003Label.ForeColor = System.Drawing.Color.White;
            xM003Label.Location = new System.Drawing.Point(847, 501);
            xM003Label.Name = "xM003Label";
            xM003Label.Size = new System.Drawing.Size(97, 20);
            xM003Label.TabIndex = 2;
            xM003Label.Text = "E-Mail 帳號:";
            xM003Label.Visible = false;
            // 
            // xM004Label
            // 
            xM004Label.AutoSize = true;
            xM004Label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            xM004Label.ForeColor = System.Drawing.Color.White;
            xM004Label.Location = new System.Drawing.Point(847, 541);
            xM004Label.Name = "xM004Label";
            xM004Label.Size = new System.Drawing.Size(97, 20);
            xM004Label.TabIndex = 3;
            xM004Label.Text = "E-Mail 密碼:";
            xM004Label.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(22, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 20);
            label1.TabIndex = 5;
            label1.Text = "主旨:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(22, 207);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "內容:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(6, 523);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 20);
            label3.TabIndex = 7;
            label3.Text = "收件者:";
            // 
            // XM002
            // 
            this.XM002.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pOSXMBindingSource, "XM003", true));
            this.XM002.EditValue = "";
            this.XM002.Location = new System.Drawing.Point(967, 497);
            this.XM002.Name = "XM002";
            this.XM002.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XM002.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.XM002.Properties.Appearance.Options.UseFont = true;
            this.XM002.Properties.Appearance.Options.UseForeColor = true;
            this.XM002.Size = new System.Drawing.Size(48, 26);
            this.XM002.TabIndex = 3;
            this.XM002.Visible = false;
            // 
            // pOSXMBindingSource
            // 
            this.pOSXMBindingSource.DataMember = "POSXM";
            this.pOSXMBindingSource.DataSource = this.rESLeaderDataSet;
            // 
            // rESLeaderDataSet
            // 
            this.rESLeaderDataSet.DataSetName = "RESLeaderDataSet";
            this.rESLeaderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // XM003
            // 
            this.XM003.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pOSXMBindingSource, "XM004", true));
            this.XM003.EditValue = "";
            this.XM003.Location = new System.Drawing.Point(967, 538);
            this.XM003.Name = "XM003";
            this.XM003.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XM003.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.XM003.Properties.Appearance.Options.UseFont = true;
            this.XM003.Properties.Appearance.Options.UseForeColor = true;
            this.XM003.Properties.PasswordChar = '*';
            this.XM003.Size = new System.Drawing.Size(48, 26);
            this.XM003.TabIndex = 4;
            this.XM003.Visible = false;
            // 
            // tb01
            // 
            this.tb01.EditValue = "";
            this.tb01.Location = new System.Drawing.Point(81, 20);
            this.tb01.Name = "tb01";
            this.tb01.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb01.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tb01.Properties.Appearance.Options.UseFont = true;
            this.tb01.Properties.Appearance.Options.UseForeColor = true;
            this.tb01.Size = new System.Drawing.Size(513, 26);
            this.tb01.TabIndex = 8;
            // 
            // memo02
            // 
            this.memo02.EditValue = "Dear All:\r\n          開始訂餐囉~~ 沒訂到的就要吃自己啦!";
            this.memo02.Location = new System.Drawing.Point(837, 405);
            this.memo02.Name = "memo02";
            this.memo02.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.memo02.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.memo02.Properties.Appearance.Options.UseFont = true;
            this.memo02.Properties.Appearance.Options.UseForeColor = true;
            this.memo02.Size = new System.Drawing.Size(178, 83);
            this.memo02.TabIndex = 9;
            this.memo02.UseOptimizedRendering = true;
            this.memo02.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::COSMOS_RES.Properties.Resources._30;
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(722, 8);
            this.btnCancel.LookAndFeel.SkinName = "Seven Classic";
            this.btnCancel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.LookAndFeel.UseWindowsXPTheme = true;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 51);
            this.btnCancel.TabIndex = 92;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::COSMOS_RES.Properties.Resources._5454;
            this.btnOK.Location = new System.Drawing.Point(622, 8);
            this.btnOK.LookAndFeel.SkinName = "Seven Classic";
            this.btnOK.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOK.LookAndFeel.UseWindowsXPTheme = true;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 51);
            this.btnOK.TabIndex = 91;
            this.btnOK.Text = "確定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pOSXMTableAdapter
            // 
            this.pOSXMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.POSXATableAdapter = null;
            this.tableAdapterManager.POSXBTableAdapter = null;
            this.tableAdapterManager.POSXCTableAdapter = null;
            this.tableAdapterManager.POSXFTableAdapter = null;
            this.tableAdapterManager.POSXGTableAdapter = null;
            this.tableAdapterManager.POSXITableAdapter = null;
            this.tableAdapterManager.POSXKTableAdapter = null;
            this.tableAdapterManager.POSXLTableAdapter = null;
            this.tableAdapterManager.POSXMTableAdapter = this.pOSXMTableAdapter;
            this.tableAdapterManager.POSXNTableAdapter = null;
            this.tableAdapterManager.POSXOTableAdapter = null;
            this.tableAdapterManager.POSXRTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COSMOS_RES.DataSet.RESLeaderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnF2
            // 
            this.btnF2.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnF2.Appearance.Options.UseFont = true;
            this.btnF2.Image = global::COSMOS_RES.Properties.Resources.search;
            this.btnF2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnF2.Location = new System.Drawing.Point(179, 369);
            this.btnF2.LookAndFeel.SkinName = "Seven Classic";
            this.btnF2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnF2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnF2.LookAndFeel.UseWindowsXPTheme = true;
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(49, 49);
            this.btnF2.TabIndex = 93;
            this.btnF2.ToolTip = "選取";
            this.btnF2.Click += new System.EventHandler(this.btnF2_Click);
            // 
            // GC_Main
            // 
            this.GC_Main.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GC_Main.Location = new System.Drawing.Point(81, 419);
            this.GC_Main.LookAndFeel.SkinName = "Office 2007 Silver";
            this.GC_Main.LookAndFeel.UseDefaultLookAndFeel = false;
            this.GC_Main.MainView = this.GV_Main;
            this.GC_Main.Name = "GC_Main";
            this.GC_Main.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.GC_Main.Size = new System.Drawing.Size(730, 231);
            this.GC_Main.TabIndex = 120;
            this.GC_Main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Main});
            // 
            // GV_Main
            // 
            this.GV_Main.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.GV_Main.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.GV_Main.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.GV_Main.Appearance.DetailTip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.DetailTip.Options.UseFont = true;
            this.GV_Main.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GV_Main.Appearance.Empty.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.Empty.Options.UseBackColor = true;
            this.GV_Main.Appearance.Empty.Options.UseFont = true;
            this.GV_Main.Appearance.EvenRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.EvenRow.Options.UseFont = true;
            this.GV_Main.Appearance.FilterCloseButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.FilterCloseButton.Options.UseFont = true;
            this.GV_Main.Appearance.FilterPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.FilterPanel.Options.UseFont = true;
            this.GV_Main.Appearance.FixedLine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.FixedLine.Options.UseFont = true;
            this.GV_Main.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.GV_Main.Appearance.FocusedCell.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.GV_Main.Appearance.FocusedCell.Options.UseBackColor = true;
            this.GV_Main.Appearance.FocusedCell.Options.UseFont = true;
            this.GV_Main.Appearance.FocusedCell.Options.UseForeColor = true;
            this.GV_Main.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(223)))));
            this.GV_Main.Appearance.FocusedRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GV_Main.Appearance.FocusedRow.Options.UseFont = true;
            this.GV_Main.Appearance.FooterPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.FooterPanel.Options.UseFont = true;
            this.GV_Main.Appearance.GroupButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.GroupButton.Options.UseFont = true;
            this.GV_Main.Appearance.GroupFooter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.GroupFooter.Options.UseFont = true;
            this.GV_Main.Appearance.GroupPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.GroupPanel.Options.UseFont = true;
            this.GV_Main.Appearance.GroupRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.GroupRow.Options.UseFont = true;
            this.GV_Main.Appearance.HeaderPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.HeaderPanel.Options.UseFont = true;
            this.GV_Main.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(188)))), ((int)(((byte)(162)))));
            this.GV_Main.Appearance.HideSelectionRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GV_Main.Appearance.HideSelectionRow.Options.UseFont = true;
            this.GV_Main.Appearance.HorzLine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.HorzLine.Options.UseFont = true;
            this.GV_Main.Appearance.OddRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.OddRow.Options.UseFont = true;
            this.GV_Main.Appearance.Preview.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.Preview.Options.UseFont = true;
            this.GV_Main.Appearance.Row.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.Row.Options.UseFont = true;
            this.GV_Main.Appearance.RowSeparator.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.RowSeparator.Options.UseFont = true;
            this.GV_Main.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(223)))));
            this.GV_Main.Appearance.SelectedRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GV_Main.Appearance.SelectedRow.Options.UseFont = true;
            this.GV_Main.Appearance.TopNewRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.TopNewRow.Options.UseFont = true;
            this.GV_Main.Appearance.VertLine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.VertLine.Options.UseFont = true;
            this.GV_Main.Appearance.ViewCaption.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Main.Appearance.ViewCaption.Options.UseFont = true;
            this.GV_Main.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn2,
            this.gridColumn3});
            this.GV_Main.GridControl = this.GC_Main;
            this.GV_Main.Name = "GV_Main";
            this.GV_Main.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Main.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Main.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Main.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.GV_Main.OptionsCustomization.AllowQuickHideColumns = false;
            this.GV_Main.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.GV_Main.OptionsView.ColumnAutoWidth = false;
            this.GV_Main.OptionsView.EnableAppearanceEvenRow = true;
            this.GV_Main.OptionsView.EnableAppearanceOddRow = true;
            this.GV_Main.OptionsView.ShowGroupPanel = false;
            this.GV_Main.PaintStyleName = "Skin";
            this.GV_Main.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GV_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GV_Main_MouseDown);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "選擇";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gridColumn1.FieldName = "Select";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 50;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Check";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = "Y";
            this.repositoryItemCheckEdit2.ValueUnchecked = "N";
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "工號";
            this.gridColumn4.FieldName = "XM001";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "名稱";
            this.gridColumn2.FieldName = "XM004";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "E-Mail";
            this.gridColumn3.FieldName = "XM002";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 240;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaxLength = 5;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = "Y";
            this.repositoryItemCheckEdit1.ValueUnchecked = "N";
            // 
            // btnDelOne
            // 
            this.btnDelOne.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelOne.Appearance.Options.UseFont = true;
            this.btnDelOne.Image = global::COSMOS_RES.Properties.Resources.delone;
            this.btnDelOne.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDelOne.Location = new System.Drawing.Point(228, 369);
            this.btnDelOne.LookAndFeel.SkinName = "Seven Classic";
            this.btnDelOne.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnDelOne.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelOne.LookAndFeel.UseWindowsXPTheme = true;
            this.btnDelOne.Name = "btnDelOne";
            this.btnDelOne.Size = new System.Drawing.Size(49, 49);
            this.btnDelOne.TabIndex = 121;
            this.btnDelOne.ToolTip = "刪除選取";
            this.btnDelOne.Click += new System.EventHandler(this.btnDelOne_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelAll.Appearance.Options.UseFont = true;
            this.btnDelAll.Image = global::COSMOS_RES.Properties.Resources.delall;
            this.btnDelAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDelAll.Location = new System.Drawing.Point(277, 369);
            this.btnDelAll.LookAndFeel.SkinName = "Seven Classic";
            this.btnDelAll.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnDelAll.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelAll.LookAndFeel.UseWindowsXPTheme = true;
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(49, 49);
            this.btnDelAll.TabIndex = 122;
            this.btnDelAll.ToolTip = "刪除全部";
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnAll
            // 
            this.btnAll.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAll.Appearance.Options.UseFont = true;
            this.btnAll.Image = global::COSMOS_RES.Properties.Resources._31;
            this.btnAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAll.Location = new System.Drawing.Point(81, 369);
            this.btnAll.LookAndFeel.SkinName = "Seven Classic";
            this.btnAll.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnAll.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAll.LookAndFeel.UseWindowsXPTheme = true;
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(49, 49);
            this.btnAll.TabIndex = 123;
            this.btnAll.ToolTip = "匯入全部";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnOldLList
            // 
            this.btnOldLList.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOldLList.Appearance.Options.UseFont = true;
            this.btnOldLList.Image = global::COSMOS_RES.Properties.Resources.TimeMachine_Cosmos;
            this.btnOldLList.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnOldLList.Location = new System.Drawing.Point(130, 369);
            this.btnOldLList.LookAndFeel.SkinName = "Seven Classic";
            this.btnOldLList.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnOldLList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOldLList.LookAndFeel.UseWindowsXPTheme = true;
            this.btnOldLList.Name = "btnOldLList";
            this.btnOldLList.Size = new System.Drawing.Size(49, 49);
            this.btnOldLList.TabIndex = 124;
            this.btnOldLList.ToolTip = "載入上次訂餐發送人員清單";
            this.btnOldLList.Click += new System.EventHandler(this.btnOldLList_Click);
            // 
            // posxmTableAdapter1
            // 
            this.posxmTableAdapter1.ClearBeforeFill = true;
            // 
            // rd01
            // 
            this.rd01.Location = new System.Drawing.Point(82, 65);
            this.rd01.Name = "rd01";
            this.rd01.RCText = "";
            this.rd01.Size = new System.Drawing.Size(731, 298);
            this.rd01.TabIndex = 125;
            // 
            // RESAB02
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 662);
            this.Controls.Add(this.rd01);
            this.Controls.Add(this.btnOldLList);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnDelOne);
            this.Controls.Add(this.GC_Main);
            this.Controls.Add(this.btnF2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.memo02);
            this.Controls.Add(this.tb01);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(xM004Label);
            this.Controls.Add(this.XM003);
            this.Controls.Add(xM003Label);
            this.Controls.Add(this.XM002);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RESAB02";
            this.Text = "訂餐通知批次作業";
            this.Load += new System.EventHandler(this.POSAB02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XM002.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESLeaderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XM003.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb01.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo02.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RESLeaderDataSet rESLeaderDataSet;
        private System.Windows.Forms.BindingSource pOSXMBindingSource;
        private COSMOS_RES.DataSet.RESLeaderDataSetTableAdapters.POSXMTableAdapter pOSXMTableAdapter;
        private COSMOS_RES.DataSet.RESLeaderDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit XM002;
        private DevExpress.XtraEditors.TextEdit XM003;
        private DevExpress.XtraEditors.TextEdit tb01;
        private DevExpress.XtraEditors.MemoEdit memo02;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnF2;
        public DevExpress.XtraGrid.GridControl GC_Main;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Main;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btnDelOne;
        private DevExpress.XtraEditors.SimpleButton btnDelAll;
        private DevExpress.XtraEditors.SimpleButton btnAll;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnOldLList;
        private DataSet.RESLeaderDataSetTableAdapters.POSXMTableAdapter posxmTableAdapter1;
        private RichEditEX.RichEditControlEX rd01;
    }
}