namespace COSMOS_RES
{
    partial class RESAI04K
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbo01 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GC_Main = new DevExpress.XtraGrid.GridControl();
            this.pOSXRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_RESAI04 = new COSMOS_RES.DataSet.DS_RESAI04();
            this.GV_Main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colXB007 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXB003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXB004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXR005 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colXR006 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colXB007C = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXB002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pOSXRTableAdapter = new COSMOS_RES.DataSet.DS_RESAI04TableAdapters.POSXRTableAdapter();
            this.tableAdapterManager = new COSMOS_RES.DataSet.DS_RESAI04TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo01.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESAI04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::COSMOS_RES.Properties.Resources._30;
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(426, 500);
            this.btnCancel.LookAndFeel.SkinName = "Seven Classic";
            this.btnCancel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.LookAndFeel.UseWindowsXPTheme = true;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 46);
            this.btnCancel.TabIndex = 95;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::COSMOS_RES.Properties.Resources._5454;
            this.btnOK.Location = new System.Drawing.Point(306, 500);
            this.btnOK.LookAndFeel.SkinName = "Seven Classic";
            this.btnOK.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOK.LookAndFeel.UseWindowsXPTheme = true;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 46);
            this.btnOK.TabIndex = 94;
            this.btnOK.Text = "確定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnUnAll
            // 
            this.btnUnAll.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUnAll.Appearance.Options.UseFont = true;
            this.btnUnAll.Image = global::COSMOS_RES.Properties.Resources.unselectall1;
            this.btnUnAll.Location = new System.Drawing.Point(105, 500);
            this.btnUnAll.LookAndFeel.SkinName = "Seven Classic";
            this.btnUnAll.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnUnAll.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUnAll.LookAndFeel.UseWindowsXPTheme = true;
            this.btnUnAll.Name = "btnUnAll";
            this.btnUnAll.Size = new System.Drawing.Size(110, 46);
            this.btnUnAll.TabIndex = 121;
            this.btnUnAll.Text = "取消全選";
            this.btnUnAll.Click += new System.EventHandler(this.btnUnAll_Click);
            // 
            // btnAll
            // 
            this.btnAll.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAll.Appearance.Options.UseFont = true;
            this.btnAll.Image = global::COSMOS_RES.Properties.Resources.selectall;
            this.btnAll.Location = new System.Drawing.Point(7, 500);
            this.btnAll.LookAndFeel.SkinName = "Seven Classic";
            this.btnAll.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnAll.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAll.LookAndFeel.UseWindowsXPTheme = true;
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(92, 46);
            this.btnAll.TabIndex = 120;
            this.btnAll.Text = "全選";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.groupControl4.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.groupControl4.Appearance.Options.UseBackColor = true;
            this.groupControl4.Appearance.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.groupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl4.Controls.Add(this.labelControl1);
            this.groupControl4.Controls.Add(this.cbo01);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.groupControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl4.LookAndFeel.UseWindowsXPTheme = true;
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(815, 72);
            this.groupControl4.TabIndex = 155;
            this.groupControl4.Text = "選擇";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(35, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "菜色類別:";
            // 
            // cbo01
            // 
            this.cbo01.Location = new System.Drawing.Point(107, 33);
            this.cbo01.Name = "cbo01";
            this.cbo01.Properties.Appearance.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo01.Properties.Appearance.Options.UseFont = true;
            this.cbo01.Properties.AppearanceDisabled.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cbo01.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cbo01.Properties.AppearanceDropDown.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cbo01.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbo01.Properties.AppearanceFocused.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cbo01.Properties.AppearanceFocused.Options.UseFont = true;
            this.cbo01.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cbo01.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cbo01.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo01.Properties.DropDownRows = 10;
            this.cbo01.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbo01.Size = new System.Drawing.Size(206, 26);
            this.cbo01.TabIndex = 0;
            this.cbo01.SelectedIndexChanged += new System.EventHandler(this.cbo01_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.GC_Main);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.LookAndFeel.UseWindowsXPTheme = true;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(811, 418);
            this.groupControl1.TabIndex = 123;
            this.groupControl1.Text = "菜單評論查詢";
            // 
            // GC_Main
            // 
            this.GC_Main.DataSource = this.pOSXRBindingSource;
            this.GC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GC_Main.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GC_Main.Location = new System.Drawing.Point(4, 30);
            this.GC_Main.LookAndFeel.SkinName = "Office 2007 Silver";
            this.GC_Main.LookAndFeel.UseDefaultLookAndFeel = false;
            this.GC_Main.MainView = this.GV_Main;
            this.GC_Main.Name = "GC_Main";
            this.GC_Main.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemButtonEdit1,
            this.repositoryItemPictureEdit1});
            this.GC_Main.Size = new System.Drawing.Size(803, 383);
            this.GC_Main.TabIndex = 5;
            this.GC_Main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Main});
            // 
            // pOSXRBindingSource
            // 
            this.pOSXRBindingSource.DataMember = "POSXR";
            this.pOSXRBindingSource.DataSource = this.dS_RESAI04;
            // 
            // dS_RESAI04
            // 
            this.dS_RESAI04.DataSetName = "DS_RESAI04";
            this.dS_RESAI04.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colXB007,
            this.colXB003,
            this.colXB004,
            this.colXR005,
            this.colXR006,
            this.colXB007C,
            this.colXB002,
            this.colSelected});
            this.GV_Main.GridControl = this.GC_Main;
            this.GV_Main.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GV_Main.Name = "GV_Main";
            this.GV_Main.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.GV_Main.OptionsCustomization.AllowQuickHideColumns = false;
            this.GV_Main.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.GV_Main.OptionsSelection.MultiSelect = true;
            this.GV_Main.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.GV_Main.OptionsView.ColumnAutoWidth = false;
            this.GV_Main.OptionsView.EnableAppearanceEvenRow = true;
            this.GV_Main.OptionsView.EnableAppearanceOddRow = true;
            this.GV_Main.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.GV_Main.OptionsView.ShowGroupPanel = false;
            this.GV_Main.PaintStyleName = "Skin";
            this.GV_Main.RowHeight = 32;
            this.GV_Main.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GV_Main_CustomDrawCell);
            this.GV_Main.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GV_Main_CellValueChanged);
            this.GV_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GV_Main_MouseDown);
            // 
            // colXB007
            // 
            this.colXB007.AppearanceHeader.Options.UseTextOptions = true;
            this.colXB007.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXB007.FieldName = "XB007";
            this.colXB007.Name = "colXB007";
            // 
            // colXB003
            // 
            this.colXB003.AppearanceHeader.Options.UseTextOptions = true;
            this.colXB003.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXB003.FieldName = "XB003";
            this.colXB003.Name = "colXB003";
            this.colXB003.Visible = true;
            this.colXB003.VisibleIndex = 3;
            this.colXB003.Width = 249;
            // 
            // colXB004
            // 
            this.colXB004.AppearanceCell.Options.UseTextOptions = true;
            this.colXB004.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colXB004.AppearanceHeader.Options.UseTextOptions = true;
            this.colXB004.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXB004.DisplayFormat.FormatString = "n1";
            this.colXB004.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXB004.FieldName = "XB004";
            this.colXB004.Name = "colXB004";
            this.colXB004.Visible = true;
            this.colXB004.VisibleIndex = 4;
            this.colXB004.Width = 59;
            // 
            // colXR005
            // 
            this.colXR005.AppearanceHeader.Options.UseTextOptions = true;
            this.colXR005.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXR005.Caption = "綜合評價";
            this.colXR005.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colXR005.DisplayFormat.FormatString = "n1";
            this.colXR005.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXR005.FieldName = "XR005";
            this.colXR005.MaxWidth = 163;
            this.colXR005.MinWidth = 163;
            this.colXR005.Name = "colXR005";
            this.colXR005.OptionsColumn.ReadOnly = true;
            this.colXR005.Visible = true;
            this.colXR005.VisibleIndex = 1;
            this.colXR005.Width = 163;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // colXR006
            // 
            this.colXR006.AppearanceHeader.Options.UseTextOptions = true;
            this.colXR006.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXR006.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colXR006.FieldName = "XR006";
            this.colXR006.Name = "colXR006";
            this.colXR006.OptionsColumn.ReadOnly = true;
            this.colXR006.Visible = true;
            this.colXR006.VisibleIndex = 5;
            this.colXR006.Width = 122;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", 15, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // colXB007C
            // 
            this.colXB007C.AppearanceHeader.Options.UseTextOptions = true;
            this.colXB007C.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXB007C.FieldName = "XB007C";
            this.colXB007C.Name = "colXB007C";
            this.colXB007C.Width = 219;
            // 
            // colXB002
            // 
            this.colXB002.AppearanceHeader.Options.UseTextOptions = true;
            this.colXB002.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXB002.FieldName = "XB002";
            this.colXB002.Name = "colXB002";
            this.colXB002.Visible = true;
            this.colXB002.VisibleIndex = 2;
            this.colXB002.Width = 124;
            // 
            // colSelected
            // 
            this.colSelected.AppearanceHeader.Options.UseTextOptions = true;
            this.colSelected.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSelected.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 0;
            this.colSelected.Width = 44;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = "Y";
            this.repositoryItemCheckEdit1.ValueGrayed = "";
            this.repositoryItemCheckEdit1.ValueUnchecked = "N";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaxLength = 5;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Check";
            this.repositoryItemCheckEdit2.FullFocusRect = true;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = "Y";
            this.repositoryItemCheckEdit2.ValueGrayed = "";
            this.repositoryItemCheckEdit2.ValueUnchecked = "N";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 72);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(815, 422);
            this.panelControl1.TabIndex = 123;
            // 
            // pOSXRTableAdapter
            // 
            this.pOSXRTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.POSXFTableAdapter = null;
            this.tableAdapterManager.POSXGTableAdapter = null;
            this.tableAdapterManager.POSXKTableAdapter = null;
            this.tableAdapterManager.POSXR3TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COSMOS_RES.DataSet.DS_RESAI04TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // RESAI04K
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(815, 553);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.btnUnAll);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "RESAI04K";
            this.Text = "菜單評論";
            this.Load += new System.EventHandler(this.RESAI04K_Load);
            this.Shown += new System.EventHandler(this.RESAI04K_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo01.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESAI04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnUnAll;
        private DevExpress.XtraEditors.SimpleButton btnAll;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbo01;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraGrid.GridControl GC_Main;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Main;
        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DataSet.DS_RESAI04 dS_RESAI04;
        private DataSet.DS_RESAI04TableAdapters.POSXRTableAdapter pOSXRTableAdapter;
        private DataSet.DS_RESAI04TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colXB007;
        private DevExpress.XtraGrid.Columns.GridColumn colXB003;
        private DevExpress.XtraGrid.Columns.GridColumn colXB004;
        private DevExpress.XtraGrid.Columns.GridColumn colXR005;
        private DevExpress.XtraGrid.Columns.GridColumn colXR006;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colXB007C;
        private DevExpress.XtraGrid.Columns.GridColumn colXB002;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private System.Windows.Forms.BindingSource pOSXRBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}
