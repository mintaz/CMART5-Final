namespace CMART5
{
    partial class GUI_Discount
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
            this.gcDiscount = new DevExpress.XtraGrid.GridControl();
            this.gvDiscount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TGSTART = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TGEND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
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
            // gcDiscount
            // 
            this.gcDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiscount.Location = new System.Drawing.Point(0, 32);
            this.gcDiscount.MainView = this.gvDiscount;
            this.gcDiscount.MenuManager = this.barManager1;
            this.gcDiscount.Name = "gcDiscount";
            this.gcDiscount.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.gcDiscount.Size = new System.Drawing.Size(784, 362);
            this.gcDiscount.TabIndex = 4;
            this.gcDiscount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiscount});
            // 
            // gvDiscount
            // 
            this.gvDiscount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDKM,
            this.IDSP,
            this.price,
            this.TGSTART,
            this.TGEND,
            this.ND,
            this.HA});
            this.gvDiscount.GridControl = this.gcDiscount;
            this.gvDiscount.Name = "gvDiscount";
            this.gvDiscount.OptionsFind.AlwaysVisible = true;
            this.gvDiscount.OptionsFind.ShowFindButton = false;
            this.gvDiscount.OptionsView.ShowGroupPanel = false;
            this.gvDiscount.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvAccount_FocusedRowChanged);
            this.gvDiscount.DoubleClick += new System.EventHandler(this.gvAccount_DoubleClick);
            // 
            // IDKM
            // 
            this.IDKM.Caption = "ID Khuyến Mãi";
            this.IDKM.FieldName = "idKHUYENMAI";
            this.IDKM.Name = "IDKM";
            this.IDKM.Visible = true;
            this.IDKM.VisibleIndex = 0;
            // 
            // IDSP
            // 
            this.IDSP.Caption = "ID Sản Phẩm";
            this.IDSP.FieldName = "SANPHAM.idSANPHAM";
            this.IDSP.Name = "IDSP";
            this.IDSP.Visible = true;
            this.IDSP.VisibleIndex = 1;
            // 
            // price
            // 
            this.price.Caption = "Giá Khuyến Mãi";
            this.price.FieldName = "GIA_KM";
            this.price.Name = "price";
            this.price.Visible = true;
            this.price.VisibleIndex = 2;
            // 
            // TGSTART
            // 
            this.TGSTART.Caption = "Thời gian bắt đầu";
            this.TGSTART.FieldName = "TG_BATDAU";
            this.TGSTART.Name = "TGSTART";
            this.TGSTART.Visible = true;
            this.TGSTART.VisibleIndex = 3;
            // 
            // TGEND
            // 
            this.TGEND.Caption = "Thời gian kết thúc";
            this.TGEND.FieldName = "TG_KETTHUC";
            this.TGEND.Name = "TGEND";
            this.TGEND.Visible = true;
            this.TGEND.VisibleIndex = 4;
            // 
            // ND
            // 
            this.ND.Caption = "Nội Dung";
            this.ND.FieldName = "NOIDUNG";
            this.ND.Name = "ND";
            this.ND.Visible = true;
            this.ND.VisibleIndex = 5;
            // 
            // HA
            // 
            this.HA.Caption = "Hình Ảnh";
            this.HA.FieldName = "HINHANH";
            this.HA.Name = "HA";
            this.HA.Visible = true;
            this.HA.VisibleIndex = 6;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // GUI_Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 394);
            this.Controls.Add(this.gcDiscount);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_Discount";
            this.Text = "GUI_Discount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_Discount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcDiscount;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn IDKM;
        private DevExpress.XtraGrid.Columns.GridColumn IDSP;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private DevExpress.XtraGrid.Columns.GridColumn TGSTART;
        private DevExpress.XtraGrid.Columns.GridColumn TGEND;
        private DevExpress.XtraGrid.Columns.GridColumn ND;
        private DevExpress.XtraGrid.Columns.GridColumn HA;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
    }
}