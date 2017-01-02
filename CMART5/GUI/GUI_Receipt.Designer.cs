namespace CMART5
{
    partial class GUI_Receipt
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
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gcReceipt = new DevExpress.XtraGrid.GridControl();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvReceipt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SELLDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONGTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIENKHACHDUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIENTRALAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TONGSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.POS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pHIEUNHAPHANGTRUSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.btnDetail);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.gcReceipt);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1125, 534);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(288, 12);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(134, 21);
            this.btnDetail.TabIndex = 7;
            this.btnDetail.Text = "Chi Tiết Phiếu";
            this.btnDetail.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(272, 21);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm Hóa Đơn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // gcReceipt
            // 
            this.gcReceipt.DataSource = this.hOADONBindingSource;
            this.gcReceipt.Location = new System.Drawing.Point(12, 37);
            this.gcReceipt.MainView = this.gvReceipt;
            this.gcReceipt.MenuManager = this.barManager1;
            this.gcReceipt.Name = "gcReceipt";
            this.gcReceipt.Size = new System.Drawing.Size(1101, 485);
            this.gcReceipt.TabIndex = 5;
            this.gcReceipt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReceipt});
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataSource = typeof(CMART5.HOADON);
            // 
            // gvReceipt
            // 
            this.gvReceipt.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.SELLDATE,
            this.TONGTIEN,
            this.TIENKHACHDUA,
            this.TIENTRALAI,
            this.TONGSL,
            this.POS,
            this.IDAC});
            this.gvReceipt.GridControl = this.gcReceipt;
            this.gvReceipt.Name = "gvReceipt";
            this.gvReceipt.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gvReceipt.OptionsDetail.EnableMasterViewMode = false;
            this.gvReceipt.OptionsDetail.ShowDetailTabs = false;
            this.gvReceipt.OptionsDetail.SmartDetailExpand = false;
            this.gvReceipt.OptionsFind.AlwaysVisible = true;
            this.gvReceipt.OptionsFind.FindDelay = 250;
            this.gvReceipt.OptionsFind.ShowFindButton = false;
            this.gvReceipt.OptionsView.ShowGroupPanel = false;
            this.gvReceipt.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvHQticket_FocusedRowChanged);
            this.gvReceipt.DoubleClick += new System.EventHandler(this.gvHQticket_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID Hóa Đơn";
            this.ID.FieldName = "idHOADON";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // SELLDATE
            // 
            this.SELLDATE.Caption = "Ngày Bán";
            this.SELLDATE.FieldName = "NGAYBAN";
            this.SELLDATE.Name = "SELLDATE";
            this.SELLDATE.OptionsColumn.AllowEdit = false;
            this.SELLDATE.Visible = true;
            this.SELLDATE.VisibleIndex = 1;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.Caption = "Tổng Tiền";
            this.TONGTIEN.FieldName = "TONGTIEN";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.OptionsColumn.AllowEdit = false;
            this.TONGTIEN.Visible = true;
            this.TONGTIEN.VisibleIndex = 2;
            // 
            // TIENKHACHDUA
            // 
            this.TIENKHACHDUA.Caption = "Tiền Khách Đưa";
            this.TIENKHACHDUA.FieldName = "TIENKHACHDUA";
            this.TIENKHACHDUA.Name = "TIENKHACHDUA";
            this.TIENKHACHDUA.OptionsColumn.AllowEdit = false;
            this.TIENKHACHDUA.Visible = true;
            this.TIENKHACHDUA.VisibleIndex = 3;
            // 
            // TIENTRALAI
            // 
            this.TIENTRALAI.Caption = "Tiền Trả Lại";
            this.TIENTRALAI.FieldName = "TIENTRALAI";
            this.TIENTRALAI.Name = "TIENTRALAI";
            this.TIENTRALAI.OptionsColumn.AllowEdit = false;
            this.TIENTRALAI.Visible = true;
            this.TIENTRALAI.VisibleIndex = 4;
            // 
            // TONGSL
            // 
            this.TONGSL.Caption = "Tổng Số Lượng";
            this.TONGSL.FieldName = "TONGSOLUONG";
            this.TONGSL.Name = "TONGSL";
            this.TONGSL.OptionsColumn.AllowEdit = false;
            this.TONGSL.Visible = true;
            this.TONGSL.VisibleIndex = 5;
            // 
            // POS
            // 
            this.POS.Caption = "Số POS";
            this.POS.FieldName = "SOPOS";
            this.POS.Name = "POS";
            this.POS.OptionsColumn.AllowEdit = false;
            this.POS.Visible = true;
            this.POS.VisibleIndex = 6;
            // 
            // IDAC
            // 
            this.IDAC.Caption = "ID Tài Khoản";
            this.IDAC.FieldName = "idTAIKHOAN";
            this.IDAC.Name = "IDAC";
            this.IDAC.OptionsColumn.AllowEdit = false;
            this.IDAC.Visible = true;
            this.IDAC.VisibleIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1125, 534);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcReceipt;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1105, 489);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(414, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(691, 25);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAdd;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(276, 25);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnDetail;
            this.layoutControlItem3.Location = new System.Drawing.Point(276, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(138, 25);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // pHIEUNHAPHANGTRUSOBindingSource
            // 
            this.pHIEUNHAPHANGTRUSOBindingSource.DataSource = typeof(CMART5.PHIEUNHAPHANGTRUSO);
            // 
            // GUI_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 534);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_Receipt";
            this.Text = "GUI_Receipt";
            this.Load += new System.EventHandler(this.GUI_HQTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcReceipt;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReceipt;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource pHIEUNHAPHANGTRUSOBindingSource;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnAdd;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn SELLDATE;
        private DevExpress.XtraGrid.Columns.GridColumn TONGTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn TIENKHACHDUA;
        private DevExpress.XtraGrid.Columns.GridColumn TIENTRALAI;
        private DevExpress.XtraGrid.Columns.GridColumn TONGSL;
        private DevExpress.XtraGrid.Columns.GridColumn POS;
        private DevExpress.XtraGrid.Columns.GridColumn IDAC;
    }
}