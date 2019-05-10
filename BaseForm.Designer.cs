namespace COSMOS_RES
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.GC_Body = new DevExpress.XtraGrid.GridControl();
            this.GV_Body = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.TabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.TP_Detail = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.TP_Browse = new DevExpress.XtraTab.XtraTabPage();
            this.GC_Main = new DevExpress.XtraGrid.GridControl();
            this.GV_Main = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.BtnNew = new DevExpress.XtraBars.BarButtonItem();
            this.BtnQuery = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFirst = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPrior = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNext = new DevExpress.XtraBars.BarButtonItem();
            this.BtnLast = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnAutoWidth = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlMain)).BeginInit();
            this.TabControlMain.SuspendLayout();
            this.TP_Detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.TP_Browse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 47);
            this.panelControl1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(884, 492);
            this.panelControl1.TabIndex = 5;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl3.Controls.Add(this.GC_Body);
            this.panelControl3.Controls.Add(this.splitterControl1);
            this.panelControl3.Controls.Add(this.TabControlMain);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.LookAndFeel.SkinName = "Xmas 2008 Blue";
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(880, 488);
            this.panelControl3.TabIndex = 6;
            // 
            // GC_Body
            // 
            this.GC_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GC_Body.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GC_Body.Location = new System.Drawing.Point(3, 267);
            this.GC_Body.LookAndFeel.SkinName = "Office 2007 Silver";
            this.GC_Body.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.GC_Body.LookAndFeel.UseDefaultLookAndFeel = false;
            this.GC_Body.MainView = this.GV_Body;
            this.GC_Body.Name = "GC_Body";
            this.GC_Body.Size = new System.Drawing.Size(874, 218);
            this.GC_Body.TabIndex = 5;
            this.GC_Body.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_Body});
            this.GC_Body.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.GC_Body_EditorKeyDown);
            this.GC_Body.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GC_Body_KeyDown);
            this.GC_Body.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GC_Body_MouseClick);
            this.GC_Body.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GC_Body_MouseDown);
            // 
            // GV_Body
            // 
            this.GV_Body.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.GV_Body.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.GV_Body.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.GV_Body.Appearance.DetailTip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.DetailTip.Options.UseFont = true;
            this.GV_Body.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GV_Body.Appearance.Empty.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.Empty.Options.UseBackColor = true;
            this.GV_Body.Appearance.Empty.Options.UseFont = true;
            this.GV_Body.Appearance.EvenRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.EvenRow.Options.UseFont = true;
            this.GV_Body.Appearance.FilterCloseButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.FilterCloseButton.Options.UseFont = true;
            this.GV_Body.Appearance.FilterPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.FilterPanel.Options.UseFont = true;
            this.GV_Body.Appearance.FixedLine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.FixedLine.Options.UseFont = true;
            this.GV_Body.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.GV_Body.Appearance.FocusedCell.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White;
            this.GV_Body.Appearance.FocusedCell.Options.UseBackColor = true;
            this.GV_Body.Appearance.FocusedCell.Options.UseFont = true;
            this.GV_Body.Appearance.FocusedCell.Options.UseForeColor = true;
            this.GV_Body.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(223)))));
            this.GV_Body.Appearance.FocusedRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GV_Body.Appearance.FocusedRow.Options.UseFont = true;
            this.GV_Body.Appearance.FooterPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.FooterPanel.Options.UseFont = true;
            this.GV_Body.Appearance.GroupButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.GroupButton.Options.UseFont = true;
            this.GV_Body.Appearance.GroupFooter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.GroupFooter.Options.UseFont = true;
            this.GV_Body.Appearance.GroupPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.GroupPanel.Options.UseFont = true;
            this.GV_Body.Appearance.GroupRow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GV_Body.Appearance.GroupRow.BackColor2 = System.Drawing.Color.Silver;
            this.GV_Body.Appearance.GroupRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.GV_Body.Appearance.GroupRow.Options.UseBackColor = true;
            this.GV_Body.Appearance.GroupRow.Options.UseFont = true;
            this.GV_Body.Appearance.GroupRow.Options.UseForeColor = true;
            this.GV_Body.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GV_Body.Appearance.HeaderPanel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.GV_Body.Appearance.HeaderPanel.Options.UseFont = true;
            this.GV_Body.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(188)))), ((int)(((byte)(162)))));
            this.GV_Body.Appearance.HideSelectionRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GV_Body.Appearance.HideSelectionRow.Options.UseFont = true;
            this.GV_Body.Appearance.HorzLine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.HorzLine.Options.UseFont = true;
            this.GV_Body.Appearance.OddRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.OddRow.Options.UseFont = true;
            this.GV_Body.Appearance.Preview.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.Preview.Options.UseFont = true;
            this.GV_Body.Appearance.Row.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.Row.Options.UseFont = true;
            this.GV_Body.Appearance.RowSeparator.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.RowSeparator.Options.UseFont = true;
            this.GV_Body.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(223)))));
            this.GV_Body.Appearance.SelectedRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GV_Body.Appearance.SelectedRow.Options.UseFont = true;
            this.GV_Body.Appearance.TopNewRow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.TopNewRow.Options.UseFont = true;
            this.GV_Body.Appearance.VertLine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.VertLine.Options.UseFont = true;
            this.GV_Body.Appearance.ViewCaption.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GV_Body.Appearance.ViewCaption.Options.UseFont = true;
            this.GV_Body.GridControl = this.GC_Body;
            this.GV_Body.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GV_Body.Name = "GV_Body";
            this.GV_Body.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GV_Body.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.GV_Body.OptionsBehavior.ReadOnly = true;
            this.GV_Body.OptionsCustomization.AllowGroup = false;
            this.GV_Body.OptionsCustomization.AllowQuickHideColumns = false;
            this.GV_Body.OptionsCustomization.AllowSort = false;
            this.GV_Body.OptionsDetail.AllowExpandEmptyDetails = true;
            this.GV_Body.OptionsMenu.EnableGroupPanelMenu = false;
            this.GV_Body.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.GV_Body.OptionsView.ColumnAutoWidth = false;
            this.GV_Body.OptionsView.EnableAppearanceEvenRow = true;
            this.GV_Body.OptionsView.EnableAppearanceOddRow = true;
            this.GV_Body.OptionsView.ShowGroupPanel = false;
            this.GV_Body.PaintStyleName = "Skin";
            this.GV_Body.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.GV_Body_CustomDrawColumnHeader);
            this.GV_Body.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.GV_Body_MasterRowExpanded);
            this.GV_Body.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.GV_Body_MasterRowGetRelationDisplayCaption);
            this.GV_Body.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GV_Body_InitNewRow);
            this.GV_Body.EndGrouping += new System.EventHandler(this.GV_Body_EndGrouping);
            this.GV_Body.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GV_Body_FocusedRowChanged);
            this.GV_Body.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.GV_Body_FocusedColumnChanged);
            this.GV_Body.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.GV_Body_CellValueChanged);
            this.GV_Body.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.GV_Body_InvalidRowException);
            this.GV_Body.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GV_Body_ValidateRow);
            this.GV_Body.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GV_Body_KeyDown);
            this.GV_Body.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GV_Body_KeyUP);
            this.GV_Body.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.GV_Body_ValidatingEditor);
            this.GV_Body.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.GV_Body_InvalidValueException);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(3, 263);
            this.splitterControl1.LookAndFeel.SkinName = "Office 2007 Black";
            this.splitterControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(874, 4);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // TabControlMain
            // 
            this.TabControlMain.AppearancePage.Header.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlMain.AppearancePage.Header.Options.UseFont = true;
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControlMain.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlMain.Location = new System.Drawing.Point(3, 3);
            this.TabControlMain.LookAndFeel.SkinName = "Black";
            this.TabControlMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedTabPage = this.TP_Detail;
            this.TabControlMain.Size = new System.Drawing.Size(874, 260);
            this.TabControlMain.TabIndex = 0;
            this.TabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TP_Detail,
            this.TP_Browse});
            this.TabControlMain.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabControlMain_SelectedPageChanged);
            this.TabControlMain.SelectedPageChanging += new DevExpress.XtraTab.TabPageChangingEventHandler(this.xtraTabControl1_SelectedPageChanging);
            // 
            // TP_Detail
            // 
            this.TP_Detail.Controls.Add(this.panelControl4);
            this.TP_Detail.Name = "TP_Detail";
            this.TP_Detail.Size = new System.Drawing.Size(869, 227);
            this.TP_Detail.Tag = "0";
            this.TP_Detail.Text = "詳細欄位";
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.Image = global::COSMOS_RES.Properties.Resources.auto_car_service_backgrounds_for_powerpoint;
            this.panelControl4.Appearance.Options.UseImage = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.LookAndFeel.SkinName = "Summer 2008";
            this.panelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(869, 227);
            this.panelControl4.TabIndex = 5;
            // 
            // TP_Browse
            // 
            this.TP_Browse.Controls.Add(this.GC_Main);
            this.TP_Browse.Name = "TP_Browse";
            this.TP_Browse.Size = new System.Drawing.Size(869, 227);
            this.TP_Browse.Tag = "1";
            this.TP_Browse.Text = "資料瀏覽";
            // 
            // GC_Main
            // 
            this.GC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GC_Main.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GC_Main.Location = new System.Drawing.Point(0, 0);
            this.GC_Main.LookAndFeel.SkinName = "Office 2007 Silver";
            this.GC_Main.LookAndFeel.UseDefaultLookAndFeel = false;
            this.GC_Main.MainView = this.GV_Main;
            this.GC_Main.Name = "GC_Main";
            this.GC_Main.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1});
            this.GC_Main.Size = new System.Drawing.Size(869, 227);
            this.GC_Main.TabIndex = 4;
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
            this.GV_Main.GridControl = this.GC_Main;
            this.GV_Main.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GV_Main.Name = "GV_Main";
            this.GV_Main.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.GV_Main.OptionsBehavior.ReadOnly = true;
            this.GV_Main.OptionsCustomization.AllowQuickHideColumns = false;
            this.GV_Main.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.GV_Main.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.GV_Main.OptionsView.ColumnAutoWidth = false;
            this.GV_Main.OptionsView.EnableAppearanceEvenRow = true;
            this.GV_Main.OptionsView.EnableAppearanceOddRow = true;
            this.GV_Main.OptionsView.ShowGroupPanel = false;
            this.GV_Main.PaintStyleName = "Skin";
            this.GV_Main.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GV_Main_RowClick);
            this.GV_Main.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.GV_Body_CustomDrawColumnHeader);
            this.GV_Main.HiddenEditor += new System.EventHandler(this.GV_Main_HiddenEditor);
            this.GV_Main.ShownEditor += new System.EventHandler(this.GV_Main_ShownEditor);
            this.GV_Main.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GV_Main_FocusedRowChanged);
            this.GV_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GV_Main_MouseDown);
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
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnNew,
            this.BtnQuery,
            this.BtnEdit,
            this.BtnDel,
            this.BtnFirst,
            this.BtnPrior,
            this.BtnNext,
            this.BtnLast,
            this.BtnSave,
            this.BtnCancel,
            this.btnAutoWidth});
            this.barManager1.MaxItemId = 12;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnQuery),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnDel),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnFirst, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnPrior),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnNext),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnLast),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnSave, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BtnCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAutoWidth, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.Text = "Tools";
            // 
            // BtnNew
            // 
            this.BtnNew.Caption = "新增";
            this.BtnNew.Glyph = global::COSMOS_RES.Properties.Resources.newfile;
            this.BtnNew.Id = 0;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNew_ItemClick);
            // 
            // BtnQuery
            // 
            this.BtnQuery.Caption = "查詢";
            this.BtnQuery.Glyph = global::COSMOS_RES.Properties.Resources.search;
            this.BtnQuery.Id = 1;
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnQuery_ItemClick);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Caption = "修改";
            this.BtnEdit.Glyph = global::COSMOS_RES.Properties.Resources.editfile;
            this.BtnEdit.Id = 2;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEdit_ItemClick);
            // 
            // BtnDel
            // 
            this.BtnDel.Caption = "刪除";
            this.BtnDel.Glyph = global::COSMOS_RES.Properties.Resources.delfile;
            this.BtnDel.Id = 3;
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDel_ItemClick);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Caption = "首筆";
            this.BtnFirst.Glyph = global::COSMOS_RES.Properties.Resources.first;
            this.BtnFirst.Id = 4;
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnFirst_ItemClick);
            // 
            // BtnPrior
            // 
            this.BtnPrior.Caption = "上一筆";
            this.BtnPrior.Glyph = global::COSMOS_RES.Properties.Resources.prior;
            this.BtnPrior.Id = 5;
            this.BtnPrior.Name = "BtnPrior";
            this.BtnPrior.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPrior_ItemClick);
            // 
            // BtnNext
            // 
            this.BtnNext.Caption = "下一筆";
            this.BtnNext.Glyph = global::COSMOS_RES.Properties.Resources.next;
            this.BtnNext.Id = 6;
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNext_ItemClick);
            // 
            // BtnLast
            // 
            this.BtnLast.Caption = "末筆";
            this.BtnLast.Glyph = global::COSMOS_RES.Properties.Resources.last;
            this.BtnLast.Id = 7;
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnLast_ItemClick);
            // 
            // BtnSave
            // 
            this.BtnSave.Caption = "儲存";
            this.BtnSave.Glyph = global::COSMOS_RES.Properties.Resources.save;
            this.BtnSave.Id = 8;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSave_ItemClick);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Caption = "取消";
            this.BtnCancel.Glyph = global::COSMOS_RES.Properties.Resources.cnacel;
            this.BtnCancel.Id = 9;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCancel_ItemClick);
            // 
            // btnAutoWidth
            // 
            this.btnAutoWidth.Caption = "調整欄寬";
            this.btnAutoWidth.Glyph = global::COSMOS_RES.Properties.Resources.Print_Preview_Fit_to_width_icon;
            this.btnAutoWidth.Id = 11;
            this.btnAutoWidth.Name = "btnAutoWidth";
            this.btnAutoWidth.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAutoWidth_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(884, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 539);
            this.barDockControlBottom.Size = new System.Drawing.Size(884, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 492);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(884, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 492);
            // 
            // BaseForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlMain)).EndInit();
            this.TabControlMain.ResumeLayout(false);
            this.TP_Detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.TP_Browse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.PanelControl panelControl3;
        public DevExpress.XtraBars.Bar bar3;
        public DevExpress.XtraBars.BarDockControl barDockControlTop;
        public DevExpress.XtraBars.BarDockControl barDockControlBottom;
        public DevExpress.XtraBars.BarDockControl barDockControlLeft;
        public DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraBars.BarButtonItem BtnNew;
        public DevExpress.XtraBars.BarButtonItem BtnEdit;
        public DevExpress.XtraBars.BarButtonItem BtnDel;
        public DevExpress.XtraBars.BarButtonItem BtnFirst;
        public DevExpress.XtraBars.BarButtonItem BtnPrior;
        public DevExpress.XtraBars.BarButtonItem BtnNext;
        public DevExpress.XtraBars.BarButtonItem BtnLast;
        public DevExpress.XtraBars.BarButtonItem BtnSave;
        public DevExpress.XtraBars.BarButtonItem BtnCancel;
        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Bar bar1;
        public DevExpress.XtraBars.BarButtonItem BtnQuery;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        public DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        public DevExpress.XtraTab.XtraTabPage TP_Browse;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Main;
        public DevExpress.XtraEditors.PanelControl panelControl4;
        public DevExpress.XtraGrid.GridControl GC_Main;
        public DevExpress.XtraTab.XtraTabControl TabControlMain;
        public DevExpress.XtraTab.XtraTabPage TP_Detail;
        public DevExpress.XtraEditors.SplitterControl splitterControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView GV_Body;
        public DevExpress.XtraGrid.GridControl GC_Body;
        private DevExpress.XtraBars.BarButtonItem btnAutoWidth;


    }
}

