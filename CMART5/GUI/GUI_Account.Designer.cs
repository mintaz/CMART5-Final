namespace CMART5
{
    partial class GUI_Account
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
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnreload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcAccount = new DevExpress.XtraGrid.GridControl();
            this.gvAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENDANGNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MATKHAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).BeginInit();
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
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnreload});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnreload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Glyph = global::CMART5.Properties.Resources.Actions_list_add_user_icon;
            this.btnAdd.Id = 0;
            this.btnAdd.LargeGlyph = global::CMART5.Properties.Resources.Actions_list_add_user_icon;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Glyph = global::CMART5.Properties.Resources.Actions_document_edit_icon;
            this.btnEdit.Id = 1;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Glyph = global::CMART5.Properties.Resources.Actions_window_close_icon;
            this.btnDelete.Id = 2;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnreload
            // 
            this.btnreload.Caption = "Reload";
            this.btnreload.Glyph = global::CMART5.Properties.Resources.Button_Refresh_icon;
            this.btnreload.Id = 3;
            this.btnreload.Name = "btnreload";
            this.btnreload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnreload_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(784, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 394);
            this.barDockControlBottom.Size = new System.Drawing.Size(784, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 362);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(784, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 362);
            // 
            // gcAccount
            // 
            this.gcAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAccount.Location = new System.Drawing.Point(0, 32);
            this.gcAccount.MainView = this.gvAccount;
            this.gcAccount.MenuManager = this.barManager1;
            this.gcAccount.Name = "gcAccount";
            this.gcAccount.Size = new System.Drawing.Size(784, 362);
            this.gcAccount.TabIndex = 4;
            this.gcAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAccount});
            // 
            // gvAccount
            // 
            this.gvAccount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.HOTEN,
            this.DIACHI,
            this.SDT,
            this.CMND,
            this.TENDANGNHAP,
            this.MATKHAU,
            this.QUYEN});
            this.gvAccount.GridControl = this.gcAccount;
            this.gvAccount.Name = "gvAccount";
            this.gvAccount.OptionsFind.AlwaysVisible = true;
            this.gvAccount.OptionsView.ShowGroupPanel = false;
            this.gvAccount.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvAccount_FocusedRowChanged);
            this.gvAccount.DoubleClick += new System.EventHandler(this.gvAccount_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "idTAIKHOAN";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 95;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "HỌ TÊN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MinWidth = 30;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.OptionsColumn.AllowEdit = false;
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 120;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "ĐỊA CHỈ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.OptionsColumn.AllowEdit = false;
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 2;
            this.DIACHI.Width = 89;
            // 
            // SDT
            // 
            this.SDT.Caption = "SỐ ĐIỆN THOẠI";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.OptionsColumn.AllowEdit = false;
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 3;
            this.SDT.Width = 89;
            // 
            // CMND
            // 
            this.CMND.Caption = "CMND";
            this.CMND.FieldName = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.OptionsColumn.AllowEdit = false;
            this.CMND.Visible = true;
            this.CMND.VisibleIndex = 4;
            this.CMND.Width = 89;
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.Caption = "TÊN ĐĂNG NHẬP";
            this.TENDANGNHAP.FieldName = "TENDANGNHAP";
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.OptionsColumn.AllowEdit = false;
            this.TENDANGNHAP.Visible = true;
            this.TENDANGNHAP.VisibleIndex = 5;
            this.TENDANGNHAP.Width = 89;
            // 
            // MATKHAU
            // 
            this.MATKHAU.Caption = "MẬT KHẨU";
            this.MATKHAU.FieldName = "MATKHAU";
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.OptionsColumn.AllowEdit = false;
            this.MATKHAU.Visible = true;
            this.MATKHAU.VisibleIndex = 6;
            this.MATKHAU.Width = 89;
            // 
            // QUYEN
            // 
            this.QUYEN.Caption = "QUYỀN";
            this.QUYEN.FieldName = "QUYEN";
            this.QUYEN.Name = "QUYEN";
            this.QUYEN.OptionsColumn.AllowEdit = false;
            this.QUYEN.Visible = true;
            this.QUYEN.VisibleIndex = 7;
            this.QUYEN.Width = 106;
            // 
            // GUI_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 394);
            this.Controls.Add(this.gcAccount);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_Account";
            this.Text = "GUI_Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnreload;
        private DevExpress.XtraGrid.GridControl gcAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAccount;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn CMND;
        private DevExpress.XtraGrid.Columns.GridColumn TENDANGNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn MATKHAU;
        private DevExpress.XtraGrid.Columns.GridColumn QUYEN;
    }
}