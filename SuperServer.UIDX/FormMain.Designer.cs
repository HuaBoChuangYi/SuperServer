namespace SuperServer.UIDX
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.m_txtStatus = new DevExpress.XtraBars.BarStaticItem();
            this.m_btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.m_btnClear = new DevExpress.XtraBars.BarButtonItem();
            this.m_switchRefresh = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.m_switchClear = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.m_gridLog = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.m_treeSockets = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.m_propSession = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.m_rowIP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.m_rowDeviceId = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.m_rowState = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.m_rowIsThree = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_gridLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_treeSockets)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_propSession)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.m_txtStatus,
            this.m_btnRefresh,
            this.barButtonItem1,
            this.barButtonItem2,
            this.m_btnClear,
            this.m_switchRefresh,
            this.m_switchClear});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(897, 160);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // m_txtStatus
            // 
            this.m_txtStatus.Caption = "状态栏";
            this.m_txtStatus.Id = 1;
            this.m_txtStatus.Name = "m_txtStatus";
            // 
            // m_btnRefresh
            // 
            this.m_btnRefresh.Caption = "刷新";
            this.m_btnRefresh.Id = 2;
            this.m_btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m_btnRefresh.ImageOptions.SvgImage")));
            this.m_btnRefresh.Name = "m_btnRefresh";
            this.m_btnRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.m_btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_btnRefresh_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "列表";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "属性";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // m_btnClear
            // 
            this.m_btnClear.Caption = "清空";
            this.m_btnClear.Id = 5;
            this.m_btnClear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m_btnClear.ImageOptions.SvgImage")));
            this.m_btnClear.Name = "m_btnClear";
            this.m_btnClear.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.m_btnClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_btnClear_ItemClick);
            // 
            // m_switchRefresh
            // 
            this.m_switchRefresh.BindableChecked = true;
            this.m_switchRefresh.Caption = "是否定时刷新";
            this.m_switchRefresh.Checked = true;
            this.m_switchRefresh.Id = 6;
            this.m_switchRefresh.Name = "m_switchRefresh";
            this.m_switchRefresh.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.m_switchRefresh_CheckedChanged);
            // 
            // m_switchClear
            // 
            this.m_switchClear.BindableChecked = true;
            this.m_switchClear.Caption = "是否自动清空";
            this.m_switchClear.Checked = true;
            this.m_switchClear.Id = 7;
            this.m_switchClear.Name = "m_switchClear";
            this.m_switchClear.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.m_switchClear_CheckedChanged);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "功能";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.m_btnRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.m_btnClear);
            this.ribbonPageGroup1.ItemLinks.Add(this.m_switchRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.m_switchClear);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "功能";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "显示";
            this.ribbonPageGroup2.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.m_txtStatus);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 476);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(897, 24);
            // 
            // documentManager1
            // 
            this.documentManager1.ClientControl = this.m_gridLog;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.noDocumentsView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.noDocumentsView1,
            this.tabbedView1});
            // 
            // m_gridLog
            // 
            this.m_gridLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_gridLog.Location = new System.Drawing.Point(200, 280);
            this.m_gridLog.MainView = this.gridView1;
            this.m_gridLog.Name = "m_gridLog";
            this.m_gridLog.Size = new System.Drawing.Size(697, 196);
            this.m_gridLog.TabIndex = 3;
            this.m_gridLog.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.m_gridLog;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "时间";
            this.gridColumn1.FieldName = "Time";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "来源方";
            this.gridColumn2.FieldName = "FromDeviceId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "接收方";
            this.gridColumn3.FieldName = "ToDeviceId";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "命令";
            this.gridColumn4.FieldName = "Key";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "内容";
            this.gridColumn5.FieldName = "Content";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1,
            this.dockPanel2});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("a7a0040a-a9ed-4f95-b980-b03850272281");
            this.dockPanel1.Location = new System.Drawing.Point(0, 160);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 316);
            this.dockPanel1.Text = "连接列表";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.m_treeSockets);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 287);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // m_treeSockets
            // 
            this.m_treeSockets.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.m_treeSockets.CustomizationFormBounds = new System.Drawing.Rectangle(247, 369, 254, 230);
            this.m_treeSockets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_treeSockets.Location = new System.Drawing.Point(0, 0);
            this.m_treeSockets.Name = "m_treeSockets";
            this.m_treeSockets.OptionsBehavior.Editable = false;
            this.m_treeSockets.Size = new System.Drawing.Size(193, 287);
            this.m_treeSockets.TabIndex = 0;
            this.m_treeSockets.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.m_treeSockets_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "名称";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 87;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel2.FloatVertical = true;
            this.dockPanel2.ID = new System.Guid("e315bc0f-5150-43a9-b83a-c587c1e4cd15");
            this.dockPanel2.Location = new System.Drawing.Point(200, 160);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.Options.ShowCloseButton = false;
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 120);
            this.dockPanel2.Size = new System.Drawing.Size(697, 120);
            this.dockPanel2.Text = "连接信息";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.m_propSession);
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(691, 90);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // m_propSession
            // 
            this.m_propSession.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_propSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_propSession.Location = new System.Drawing.Point(0, 0);
            this.m_propSession.MenuManager = this.ribbon;
            this.m_propSession.Name = "m_propSession";
            this.m_propSession.OptionsBehavior.Editable = false;
            this.m_propSession.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.m_rowIP,
            this.m_rowDeviceId,
            this.m_rowState,
            this.m_rowIsThree});
            this.m_propSession.Size = new System.Drawing.Size(691, 90);
            this.m_propSession.TabIndex = 0;
            // 
            // m_rowIP
            // 
            this.m_rowIP.Height = 17;
            this.m_rowIP.Name = "m_rowIP";
            this.m_rowIP.Properties.Caption = "IP";
            this.m_rowIP.Properties.FieldName = "IP";
            // 
            // m_rowDeviceId
            // 
            this.m_rowDeviceId.Height = 17;
            this.m_rowDeviceId.Name = "m_rowDeviceId";
            this.m_rowDeviceId.Properties.Caption = "设备Id";
            this.m_rowDeviceId.Properties.FieldName = "DeviceId";
            // 
            // m_rowState
            // 
            this.m_rowState.Name = "m_rowState";
            this.m_rowState.Properties.Caption = "连接状态";
            this.m_rowState.Properties.FieldName = "SetIdState";
            // 
            // m_rowIsThree
            // 
            this.m_rowIsThree.Name = "m_rowIsThree";
            this.m_rowIsThree.Properties.Caption = "是否三方设备";
            this.m_rowIsThree.Properties.FieldName = "IsThree";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 500);
            this.Controls.Add(this.m_gridLog);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormMain.IconOptions.SvgImage")));
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "消息服务器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.RibbonForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_gridLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_treeSockets)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_propSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem m_txtStatus;
        private DevExpress.XtraBars.BarButtonItem m_btnRefresh;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraGrid.GridControl m_gridLog;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraTreeList.TreeList m_treeSockets;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraVerticalGrid.PropertyGridControl m_propSession;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow m_rowIP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow m_rowDeviceId;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow m_rowState;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow m_rowIsThree;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.BarButtonItem m_btnClear;
        private DevExpress.XtraBars.BarToggleSwitchItem m_switchRefresh;
        private DevExpress.XtraBars.BarToggleSwitchItem m_switchClear;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}