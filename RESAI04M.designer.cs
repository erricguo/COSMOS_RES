﻿namespace COSMOS_RES
{
    partial class RESAI04M
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
            this.GC_Main = new DevExpress.XtraGrid.GridControl();
            this.pOSXR3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_RESAI04 = new COSMOS_RES.DataSet.DS_RESAI04();
            this.GV_Main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colXF002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXA003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXG002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXB003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXR001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXR002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXR003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXR004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXR005 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colXR006 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.pOSXR3TableAdapter = new COSMOS_RES.DataSet.DS_RESAI04TableAdapters.POSXR3TableAdapter();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXR3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESAI04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GC_Main
            // 
            this.GC_Main.DataSource = this.pOSXR3BindingSource;
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
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemRichTextEdit1,
            this.repositoryItemPictureEdit1});
            this.GC_Main.Size = new System.Drawing.Size(907, 423);
            this.GC_Main.TabIndex = 5;
            this.GC_Main.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Main,
            this.gridView1});
            // 
            // pOSXR3BindingSource
            // 
            this.pOSXR3BindingSource.DataMember = "POSXR3";
            this.pOSXR3BindingSource.DataSource = this.dS_RESAI04;
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
            this.colXF002,
            this.colXA003,
            this.colXG002,
            this.colXB003,
            this.colXR001,
            this.colXR002,
            this.colXR003,
            this.colXR004,
            this.colXR005,
            this.colXR006});
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
            this.GV_Main.OptionsView.ShowGroupPanel = false;
            this.GV_Main.PaintStyleName = "Skin";
            this.GV_Main.RowHeight = 32;
            this.GV_Main.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GV_Main_CustomDrawCell);
            this.GV_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GV_Main_MouseDown);
            // 
            // colXF002
            // 
            this.colXF002.AppearanceHeader.Options.UseTextOptions = true;
            this.colXF002.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXF002.FieldName = "XF002";
            this.colXF002.Name = "colXF002";
            this.colXF002.OptionsColumn.ReadOnly = true;
            this.colXF002.Visible = true;
            this.colXF002.VisibleIndex = 0;
            // 
            // colXA003
            // 
            this.colXA003.AppearanceHeader.Options.UseTextOptions = true;
            this.colXA003.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXA003.FieldName = "XA003";
            this.colXA003.Name = "colXA003";
            this.colXA003.OptionsColumn.ReadOnly = true;
            this.colXA003.Visible = true;
            this.colXA003.VisibleIndex = 1;
            this.colXA003.Width = 135;
            // 
            // colXG002
            // 
            this.colXG002.AppearanceHeader.Options.UseTextOptions = true;
            this.colXG002.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXG002.FieldName = "XG002";
            this.colXG002.Name = "colXG002";
            this.colXG002.OptionsColumn.ReadOnly = true;
            this.colXG002.Visible = true;
            this.colXG002.VisibleIndex = 2;
            // 
            // colXB003
            // 
            this.colXB003.AppearanceHeader.Options.UseTextOptions = true;
            this.colXB003.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXB003.FieldName = "XB003";
            this.colXB003.Name = "colXB003";
            this.colXB003.OptionsColumn.ReadOnly = true;
            this.colXB003.Visible = true;
            this.colXB003.VisibleIndex = 3;
            this.colXB003.Width = 135;
            // 
            // colXR001
            // 
            this.colXR001.AppearanceHeader.Options.UseTextOptions = true;
            this.colXR001.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXR001.FieldName = "XR001";
            this.colXR001.Name = "colXR001";
            this.colXR001.OptionsColumn.ReadOnly = true;
            // 
            // colXR002
            // 
            this.colXR002.AppearanceHeader.Options.UseTextOptions = true;
            this.colXR002.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXR002.FieldName = "XR002";
            this.colXR002.Name = "colXR002";
            this.colXR002.OptionsColumn.ReadOnly = true;
            // 
            // colXR003
            // 
            this.colXR003.AppearanceHeader.Options.UseTextOptions = true;
            this.colXR003.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXR003.FieldName = "XR003";
            this.colXR003.Name = "colXR003";
            this.colXR003.OptionsColumn.ReadOnly = true;
            // 
            // colXR004
            // 
            this.colXR004.AppearanceHeader.Options.UseTextOptions = true;
            this.colXR004.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXR004.FieldName = "XR004";
            this.colXR004.Name = "colXR004";
            this.colXR004.OptionsColumn.ReadOnly = true;
            // 
            // colXR005
            // 
            this.colXR005.AppearanceHeader.Options.UseTextOptions = true;
            this.colXR005.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colXR005.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colXR005.FieldName = "XR005";
            this.colXR005.MaxWidth = 163;
            this.colXR005.MinWidth = 163;
            this.colXR005.Name = "colXR005";
            this.colXR005.OptionsColumn.ReadOnly = true;
            this.colXR005.Visible = true;
            this.colXR005.VisibleIndex = 4;
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
            this.colXR006.FieldName = "XR006";
            this.colXR006.Name = "colXR006";
            this.colXR006.Visible = true;
            this.colXR006.VisibleIndex = 5;
            this.colXR006.Width = 287;
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
            this.repositoryItemCheckEdit1.ValueGrayed = "";
            this.repositoryItemCheckEdit1.ValueUnchecked = "N";
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
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemRichTextEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
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
            this.groupControl4.Size = new System.Drawing.Size(915, 458);
            this.groupControl4.TabIndex = 122;
            this.groupControl4.Text = "快速評論清單";
            // 
            // pOSXR3TableAdapter
            // 
            this.pOSXR3TableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::COSMOS_RES.Properties.Resources._30;
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(481, 467);
            this.btnCancel.LookAndFeel.SkinName = "Seven Classic";
            this.btnCancel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.LookAndFeel.UseWindowsXPTheme = true;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 46);
            this.btnCancel.TabIndex = 124;
            this.btnCancel.Text = "取消";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Image = global::COSMOS_RES.Properties.Resources._5454;
            this.btnOK.Location = new System.Drawing.Point(361, 467);
            this.btnOK.LookAndFeel.SkinName = "Seven Classic";
            this.btnOK.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOK.LookAndFeel.UseWindowsXPTheme = true;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 46);
            this.btnOK.TabIndex = 123;
            this.btnOK.Text = "確定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // RESAI04M
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(915, 522);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupControl4);
            this.Name = "RESAI04M";
            this.Text = "菜色評論";
            this.Load += new System.EventHandler(this.RESAI04H_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSXR3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RESAI04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl GC_Main;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Main;
        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.BindingSource pOSXR3BindingSource;
        private DataSet.DS_RESAI04 dS_RESAI04;
        private DevExpress.XtraGrid.Columns.GridColumn colXF002;
        private DevExpress.XtraGrid.Columns.GridColumn colXA003;
        private DevExpress.XtraGrid.Columns.GridColumn colXG002;
        private DevExpress.XtraGrid.Columns.GridColumn colXB003;
        private DevExpress.XtraGrid.Columns.GridColumn colXR001;
        private DevExpress.XtraGrid.Columns.GridColumn colXR002;
        private DevExpress.XtraGrid.Columns.GridColumn colXR003;
        private DevExpress.XtraGrid.Columns.GridColumn colXR004;
        private DevExpress.XtraGrid.Columns.GridColumn colXR005;
        private DevExpress.XtraGrid.Columns.GridColumn colXR006;
        private DataSet.DS_RESAI04TableAdapters.POSXR3TableAdapter pOSXR3TableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}
