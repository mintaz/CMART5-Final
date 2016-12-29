namespace CMART5
{
    partial class GUI_HQTicket
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btn_AddTick = new DevExpress.XtraEditors.SimpleButton();
            this.gcHQticket = new DevExpress.XtraGrid.GridControl();
            this.gvHQticket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.IDHQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDRQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONGTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkRequest = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pHIEUNHAPHANGTRUSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHQticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHQticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkRequest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPHANGTRUSOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1125, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 534);
            this.barDockControlBottom.Size = new System.Drawing.Size(1125, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 534);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1125, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 534);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.lkRequest);
            this.layoutControl1.Controls.Add(this.btn_AddTick);
            this.layoutControl1.Controls.Add(this.gcHQticket);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1125, 534);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btn_AddTick
            // 
            this.btn_AddTick.Location = new System.Drawing.Point(284, 12);
            this.btn_AddTick.Name = "btn_AddTick";
            this.btn_AddTick.Size = new System.Drawing.Size(156, 22);
            this.btn_AddTick.StyleController = this.layoutControl1;
            this.btn_AddTick.TabIndex = 6;
            this.btn_AddTick.Text = "Thêm Phiếu";
            this.btn_AddTick.Click += new System.EventHandler(this.btn_AddTick_Click);
            // 
            // gcHQticket
            // 
            this.gcHQticket.DataSource = this.pHIEUNHAPHANGTRUSOBindingSource;
            this.gcHQticket.Location = new System.Drawing.Point(12, 38);
            this.gcHQticket.MainView = this.gvHQticket;
            this.gcHQticket.MenuManager = this.barManager1;
            this.gcHQticket.Name = "gcHQticket";
            this.gcHQticket.Size = new System.Drawing.Size(1101, 484);
            this.gcHQticket.TabIndex = 5;
            this.gcHQticket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHQticket});
            // 
            // gvHQticket
            // 
            this.gvHQticket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDHQ,
            this.IDRQ,
            this.NGAYNHAP,
            this.TONGTIEN,
            this.IDAC});
            this.gvHQticket.GridControl = this.gcHQticket;
            this.gvHQticket.Name = "gvHQticket";
            this.gvHQticket.OptionsFind.AlwaysVisible = true;
            this.gvHQticket.OptionsFind.FindDelay = 250;
            this.gvHQticket.OptionsFind.ShowFindButton = false;
            this.gvHQticket.OptionsView.ShowGroupPanel = false;
            this.gvHQticket.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvHQticket_FocusedRowChanged);
            this.gvHQticket.DoubleClick += new System.EventHandler(this.gvHQticket_DoubleClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1125, 534);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcHQticket;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1105, 488);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(562, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(543, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_AddTick;
            this.layoutControlItem3.Location = new System.Drawing.Point(272, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(160, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // IDHQ
            // 
            this.IDHQ.Caption = "ID phiếu Trụ Sở";
            this.IDHQ.FieldName = "idPHIEUTRUSO";
            this.IDHQ.Name = "IDHQ";
            this.IDHQ.Visible = true;
            this.IDHQ.VisibleIndex = 0;
            // 
            // IDRQ
            // 
            this.IDRQ.Caption = "ID phiếu Đề Xuất";
            this.IDRQ.FieldName = "idPHIEUDEXUAT";
            this.IDRQ.Name = "IDRQ";
            this.IDRQ.Visible = true;
            this.IDRQ.VisibleIndex = 1;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.Caption = "Ngày Nhập";
            this.NGAYNHAP.FieldName = "NGAYNHAP";
            this.NGAYNHAP.Name = "NGAYNHAP";
            this.NGAYNHAP.Visible = true;
            this.NGAYNHAP.VisibleIndex = 2;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.Caption = "Tổng tiền";
            this.TONGTIEN.FieldName = "TONGTIEN";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.Visible = true;
            this.TONGTIEN.VisibleIndex = 3;
            // 
            // IDAC
            // 
            this.IDAC.Caption = "ID Tài Khoản";
            this.IDAC.FieldName = "idTAIKHOAN";
            this.IDAC.Name = "IDAC";
            this.IDAC.Visible = true;
            this.IDAC.VisibleIndex = 4;
            // 
            // lkRequest
            // 
            this.lkRequest.Location = new System.Drawing.Point(98, 12);
            this.lkRequest.MenuManager = this.barManager1;
            this.lkRequest.Name = "lkRequest";
            this.lkRequest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkRequest.Size = new System.Drawing.Size(182, 20);
            this.lkRequest.StyleController = this.layoutControl1;
            this.lkRequest.TabIndex = 14;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lkRequest;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(272, 26);
            this.layoutControlItem1.Text = "ID Phiếu Yêu Cầu";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(83, 13);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(444, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Sửa Phiếu";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(432, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(130, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // pHIEUNHAPHANGTRUSOBindingSource
            // 
            this.pHIEUNHAPHANGTRUSOBindingSource.DataSource = typeof(CMART5.PHIEUNHAPHANGTRUSO);
            // 
            // GUI_HQTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 534);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_HQTicket";
            this.Text = "GUI_RequestTicket";
            this.Load += new System.EventHandler(this.GUI_HQTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHQticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHQticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkRequest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPHANGTRUSOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btn_AddTick;
        private DevExpress.XtraGrid.GridControl gcHQticket;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHQticket;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn IDHQ;
        private DevExpress.XtraGrid.Columns.GridColumn IDRQ;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn TONGTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn IDAC;
        private DevExpress.XtraEditors.LookUpEdit lkRequest;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource pHIEUNHAPHANGTRUSOBindingSource;
    }
}