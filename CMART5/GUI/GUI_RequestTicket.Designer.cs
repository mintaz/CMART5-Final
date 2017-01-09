namespace CMART5.GUI
{
    partial class GUI_RequestTicket
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Add = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcRequestTicket = new DevExpress.XtraGrid.GridControl();
            this.gvRequestTicket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRequestTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequestTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Add,
            this.btnEdit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Add, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_Add
            // 
            this.btn_Add.Caption = "Thêm";
            this.btn_Add.Glyph = global::CMART5.Properties.Resources.addfile_32x32;
            this.btn_Add.Id = 0;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Add_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(603, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 421);
            this.barDockControlBottom.Size = new System.Drawing.Size(603, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 381);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(603, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 381);
            // 
            // gcRequestTicket
            // 
            this.gcRequestTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcRequestTicket.Location = new System.Drawing.Point(0, 40);
            this.gcRequestTicket.MainView = this.gvRequestTicket;
            this.gcRequestTicket.MenuManager = this.barManager1;
            this.gcRequestTicket.Name = "gcRequestTicket";
            this.gcRequestTicket.Size = new System.Drawing.Size(603, 381);
            this.gcRequestTicket.TabIndex = 4;
            this.gcRequestTicket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRequestTicket});
            this.gcRequestTicket.DoubleClick += new System.EventHandler(this.gcRequestTicket_DoubleClick);
            // 
            // gvRequestTicket
            // 
            this.gvRequestTicket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.DATE,
            this.NCC,
            this.TK});
            this.gvRequestTicket.GridControl = this.gcRequestTicket;
            this.gvRequestTicket.Name = "gvRequestTicket";
            this.gvRequestTicket.OptionsDetail.EnableMasterViewMode = false;
            this.gvRequestTicket.OptionsFind.AlwaysVisible = true;
            this.gvRequestTicket.OptionsFind.FindDelay = 250;
            this.gvRequestTicket.OptionsFind.ShowFindButton = false;
            this.gvRequestTicket.OptionsView.ShowGroupPanel = false;
            this.gvRequestTicket.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvRequestTicket_FocusedRowChanged);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "idPHIEUDEXUAT";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // DATE
            // 
            this.DATE.Caption = "Ngày Đề Xuất";
            this.DATE.FieldName = "NGAYDEXUAT";
            this.DATE.Name = "DATE";
            this.DATE.Visible = true;
            this.DATE.VisibleIndex = 1;
            // 
            // NCC
            // 
            this.NCC.Caption = "ID Nhà Cung Cấp";
            this.NCC.FieldName = "idNHACUNGCAP";
            this.NCC.Name = "NCC";
            this.NCC.Visible = true;
            this.NCC.VisibleIndex = 2;
            // 
            // TK
            // 
            this.TK.Caption = "ID Tài Khoản";
            this.TK.FieldName = "idTAIKHOAN";
            this.TK.Name = "TK";
            this.TK.Visible = true;
            this.TK.VisibleIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa Thông tin Phiếu";
            this.btnEdit.Glyph = global::CMART5.Properties.Resources.edit_32x32;
            this.btnEdit.Id = 1;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // GUI_RequestTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 421);
            this.Controls.Add(this.gcRequestTicket);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_RequestTicket";
            this.Text = "GUI_RequestTicket";
            this.Load += new System.EventHandler(this.GUI_RequestTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRequestTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequestTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_Add;
        private DevExpress.XtraGrid.GridControl gcRequestTicket;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRequestTicket;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn DATE;
        private DevExpress.XtraGrid.Columns.GridColumn NCC;
        private DevExpress.XtraGrid.Columns.GridColumn TK;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
    }
}