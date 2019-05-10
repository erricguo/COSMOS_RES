namespace COSMOS_RES
{
    partial class RESAI06H
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RESAI06H));
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.GC_Main = new DevExpress.XtraGrid.GridControl();
            this.pOSXQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_RESAI06 = new COSMOS_RES.DataSet.DS_RESAI06();
            this.GV_Main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colXG002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colXQ003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXM004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.pOSXQTableAdapter = new COSMOS_RES.DataSet.DS_RESAI06TableAdapters.POSXQTableAdapter();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.dS_POSAR021 = new COSMOS_RES.DataSet.DS_POSAR02();
            this.btnUnPay = new DevExpress.XtraEditors.SimpleButton();
            this.btnPay = new DevExpress.XtraEditors.SimpleButton();
            this.btnEXChange = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESAI06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_POSAR021)).BeginInit();
            this.SuspendLayout();
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
            this.groupControl4.Controls.Add(this.GC_Main);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.groupControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl4.LookAndFeel.UseWindowsXPTheme = true;
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(690, 419);
            this.groupControl4.TabIndex = 125;
            this.groupControl4.Text = "檢核漏訂清單";
            // 
            // GC_Main
            // 
            this.GC_Main.DataSource = this.pOSXQBindingSource;
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
            this.repositoryItemCheckEdit2});
            this.GC_Main.Size = new System.Drawing.Size(682, 384);
            this.GC_Main.TabIndex = 5;
            this.GC_Main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Main,
            this.gridView1});
            // 
            // pOSXQBindingSource
            // 
            this.pOSXQBindingSource.DataMember = "POSXQ";
            this.pOSXQBindingSource.DataSource = this.dS_RESAI06;
            // 
            // dS_RESAI06
            // 
            this.dS_RESAI06.DataSetName = "DS_RESAI06";
            this.dS_RESAI06.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colXG002,
            this.colXQ003,
            this.colXM004,
            this.gridColumn1,
            this.gridColumn2});
            this.GV_Main.GridControl = this.GC_Main;
            this.GV_Main.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GV_Main.Name = "GV_Main";
            this.GV_Main.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.GV_Main.OptionsBehavior.ReadOnly = true;
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
            // 
            // colXG002
            // 
            this.colXG002.AppearanceHeader.Options.UseTextOptions = true;
            this.colXG002.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXG002.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colXG002.FieldName = "XG002";
            this.colXG002.Name = "colXG002";
            this.colXG002.OptionsColumn.ReadOnly = true;
            this.colXG002.Visible = true;
            this.colXG002.VisibleIndex = 0;
            this.colXG002.Width = 104;
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
            // colXQ003
            // 
            this.colXQ003.AppearanceHeader.Options.UseTextOptions = true;
            this.colXQ003.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXQ003.FieldName = "XQ003";
            this.colXQ003.Name = "colXQ003";
            this.colXQ003.Visible = true;
            this.colXQ003.VisibleIndex = 1;
            this.colXQ003.Width = 113;
            // 
            // colXM004
            // 
            this.colXM004.AppearanceHeader.Options.UseTextOptions = true;
            this.colXM004.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXM004.FieldName = "XM004";
            this.colXM004.Name = "colXM004";
            this.colXM004.Visible = true;
            this.colXM004.VisibleIndex = 2;
            this.colXM004.Width = 247;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "已付款";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.FieldName = "XG007";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "找零";
            this.gridColumn2.DisplayFormat.FormatString = "n0";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "XG008";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 83;
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
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridView1.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridView1.Appearance.DetailTip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.DetailTip.Options.UseFont = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.Empty.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.Empty.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.FixedLine.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(223)))));
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.GroupButton.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(188)))), ((int)(((byte)(162)))));
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.Appearance.HorzLine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.HorzLine.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.RowSeparator.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(223)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.VertLine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.VertLine.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.GridControl = this.GC_Main;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "Skin";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::COSMOS_RES.Properties.Resources.exit;
            this.btnOK.Location = new System.Drawing.Point(592, 425);
            this.btnOK.LookAndFeel.SkinName = "Seven Classic";
            this.btnOK.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOK.LookAndFeel.UseWindowsXPTheme = true;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 46);
            this.btnOK.TabIndex = 123;
            this.btnOK.Text = "離開";
            // 
            // pOSXQTableAdapter
            // 
            this.pOSXQTableAdapter.ClearBeforeFill = true;
            // 
            // btnYes
            // 
            this.btnYes.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnYes.Appearance.Options.UseFont = true;
            this.btnYes.Image = global::COSMOS_RES.Properties.Resources._68;
            this.btnYes.Location = new System.Drawing.Point(4, 425);
            this.btnYes.LookAndFeel.SkinName = "Seven Classic";
            this.btnYes.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnYes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnYes.LookAndFeel.UseWindowsXPTheme = true;
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(92, 46);
            this.btnYes.TabIndex = 126;
            this.btnYes.Text = "已訂";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNo.Appearance.Options.UseFont = true;
            this.btnNo.Image = global::COSMOS_RES.Properties.Resources._67;
            this.btnNo.Location = new System.Drawing.Point(102, 425);
            this.btnNo.LookAndFeel.SkinName = "Seven Classic";
            this.btnNo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnNo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNo.LookAndFeel.UseWindowsXPTheme = true;
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(92, 46);
            this.btnNo.TabIndex = 127;
            this.btnNo.Text = "未訂";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnAll
            // 
            this.btnAll.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAll.Appearance.Options.UseFont = true;
            this.btnAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAll.Image")));
            this.btnAll.Location = new System.Drawing.Point(494, 425);
            this.btnAll.LookAndFeel.SkinName = "Seven Classic";
            this.btnAll.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnAll.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAll.LookAndFeel.UseWindowsXPTheme = true;
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(92, 46);
            this.btnAll.TabIndex = 128;
            this.btnAll.Text = "全部";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dS_POSAR021
            // 
            this.dS_POSAR021.DataSetName = "DS_POSAR02";
            this.dS_POSAR021.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUnPay
            // 
            this.btnUnPay.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUnPay.Appearance.Options.UseFont = true;
            this.btnUnPay.Image = global::COSMOS_RES.Properties.Resources.bankrupt_32;
            this.btnUnPay.Location = new System.Drawing.Point(298, 425);
            this.btnUnPay.LookAndFeel.SkinName = "Seven Classic";
            this.btnUnPay.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnUnPay.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnUnPay.LookAndFeel.UseWindowsXPTheme = true;
            this.btnUnPay.Name = "btnUnPay";
            this.btnUnPay.Size = new System.Drawing.Size(92, 46);
            this.btnUnPay.TabIndex = 130;
            this.btnUnPay.Text = "未付";
            this.btnUnPay.Click += new System.EventHandler(this.btnUnPay_Click);
            // 
            // btnPay
            // 
            this.btnPay.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPay.Appearance.Options.UseFont = true;
            this.btnPay.Image = global::COSMOS_RES.Properties.Resources.money1;
            this.btnPay.Location = new System.Drawing.Point(200, 425);
            this.btnPay.LookAndFeel.SkinName = "Seven Classic";
            this.btnPay.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnPay.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPay.LookAndFeel.UseWindowsXPTheme = true;
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(92, 46);
            this.btnPay.TabIndex = 129;
            this.btnPay.Text = "已付";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnEXChange
            // 
            this.btnEXChange.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEXChange.Appearance.Options.UseFont = true;
            this.btnEXChange.Image = global::COSMOS_RES.Properties.Resources.modney;
            this.btnEXChange.Location = new System.Drawing.Point(396, 425);
            this.btnEXChange.LookAndFeel.SkinName = "Seven Classic";
            this.btnEXChange.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnEXChange.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEXChange.LookAndFeel.UseWindowsXPTheme = true;
            this.btnEXChange.Name = "btnEXChange";
            this.btnEXChange.Size = new System.Drawing.Size(92, 46);
            this.btnEXChange.TabIndex = 131;
            this.btnEXChange.Text = "找零";
            this.btnEXChange.Click += new System.EventHandler(this.btnEXChange_Click);
            // 
            // RESAI06H
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(690, 477);
            this.Controls.Add(this.btnEXChange);
            this.Controls.Add(this.btnUnPay);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.btnOK);
            this.Name = "RESAI06H";
            this.Text = "訂餐確認";
            this.Load += new System.EventHandler(this.RESAI06H_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESAI06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_POSAR021)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        public DevExpress.XtraGrid.GridControl GC_Main;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Main;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.BindingSource pOSXQBindingSource;
        private DataSet.DS_RESAI06 dS_RESAI06;
        private DevExpress.XtraGrid.Columns.GridColumn colXG002;
        private DevExpress.XtraGrid.Columns.GridColumn colXQ003;
        private DevExpress.XtraGrid.Columns.GridColumn colXM004;
        private DataSet.DS_RESAI06TableAdapters.POSXQTableAdapter pOSXQTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.SimpleButton btnAll;
        private DataSet.DS_POSAR02 dS_POSAR021;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnUnPay;
        private DevExpress.XtraEditors.SimpleButton btnPay;
        private DevExpress.XtraEditors.SimpleButton btnEXChange;
    }
}
