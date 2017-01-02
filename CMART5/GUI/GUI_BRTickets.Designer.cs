﻿namespace CMART5
{
    partial class GUI_BRTickets
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
            this.cbBR = new System.Windows.Forms.ComboBox();
            this.cborequest = new System.Windows.Forms.ComboBox();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddTick = new DevExpress.XtraEditors.SimpleButton();
            this.gcBRticket = new DevExpress.XtraGrid.GridControl();
            this.pHIEUNHAPHANGCHINHANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvBRticket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDBR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDHQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cboBr = new DevExpress.XtraLayout.LayoutControlItem();
            this.pHIEUNHAPHANGTRUSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBRticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPHANGCHINHANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBRticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBr)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.cbBR);
            this.layoutControl1.Controls.Add(this.cborequest);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btn_AddTick);
            this.layoutControl1.Controls.Add(this.gcBRticket);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1125, 534);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbBR
            // 
            this.cbBR.FormattingEnabled = true;
            this.cbBR.Location = new System.Drawing.Point(424, 12);
            this.cbBR.Name = "cbBR";
            this.cbBR.Size = new System.Drawing.Size(85, 21);
            this.cbBR.TabIndex = 17;
            // 
            // cborequest
            // 
            this.cborequest.FormattingEnabled = true;
            this.cborequest.Location = new System.Drawing.Point(145, 12);
            this.cborequest.Name = "cborequest";
            this.cborequest.Size = new System.Drawing.Size(142, 21);
            this.cborequest.TabIndex = 16;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(585, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Sửa Phiếu";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btn_AddTick
            // 
            this.btn_AddTick.Location = new System.Drawing.Point(513, 12);
            this.btn_AddTick.Name = "btn_AddTick";
            this.btn_AddTick.Size = new System.Drawing.Size(68, 22);
            this.btn_AddTick.StyleController = this.layoutControl1;
            this.btn_AddTick.TabIndex = 6;
            this.btn_AddTick.Text = "Thêm Phiếu";
            this.btn_AddTick.Click += new System.EventHandler(this.btn_AddTick_Click);
            // 
            // gcBRticket
            // 
            this.gcBRticket.DataSource = this.pHIEUNHAPHANGCHINHANHBindingSource;
            this.gcBRticket.Location = new System.Drawing.Point(12, 38);
            this.gcBRticket.MainView = this.gvBRticket;
            this.gcBRticket.MenuManager = this.barManager1;
            this.gcBRticket.Name = "gcBRticket";
            this.gcBRticket.Size = new System.Drawing.Size(1101, 484);
            this.gcBRticket.TabIndex = 5;
            this.gcBRticket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBRticket});
            // 
            // pHIEUNHAPHANGCHINHANHBindingSource
            // 
            this.pHIEUNHAPHANGCHINHANHBindingSource.DataSource = typeof(CMART5.PHIEUNHAPHANGCHINHANH);
            // 
            // gvBRticket
            // 
            this.gvBRticket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDBR,
            this.IDHQ,
            this.NGAYNHAP,
            this.TK,
            this.BR});
            this.gvBRticket.GridControl = this.gcBRticket;
            this.gvBRticket.Name = "gvBRticket";
            this.gvBRticket.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gvBRticket.OptionsDetail.ShowDetailTabs = false;
            this.gvBRticket.OptionsDetail.SmartDetailExpand = false;
            this.gvBRticket.OptionsFind.AlwaysVisible = true;
            this.gvBRticket.OptionsFind.FindDelay = 250;
            this.gvBRticket.OptionsFind.ShowFindButton = false;
            this.gvBRticket.OptionsView.ShowGroupPanel = false;
            this.gvBRticket.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvBRticket_FocusedRowChanged);
            this.gvBRticket.DoubleClick += new System.EventHandler(this.gvBRticket_DoubleClick);
            // 
            // IDBR
            // 
            this.IDBR.Caption = "ID phiếu Chi Nhánh";
            this.IDBR.FieldName = "idPHIEUCHINHANH";
            this.IDBR.Name = "IDBR";
            this.IDBR.Visible = true;
            this.IDBR.VisibleIndex = 0;
            // 
            // IDHQ
            // 
            this.IDHQ.Caption = "ID Phiếu Trụ Sở";
            this.IDHQ.FieldName = "idPHIEUTRUSO";
            this.IDHQ.Name = "IDHQ";
            this.IDHQ.Visible = true;
            this.IDHQ.VisibleIndex = 1;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.Caption = "Ngày Nhập";
            this.NGAYNHAP.FieldName = "NGAYNHAP";
            this.NGAYNHAP.Name = "NGAYNHAP";
            this.NGAYNHAP.Visible = true;
            this.NGAYNHAP.VisibleIndex = 2;
            // 
            // TK
            // 
            this.TK.Caption = "Tài Khoản";
            this.TK.FieldName = "idTAIKHOAN";
            this.TK.Name = "TK";
            this.TK.Visible = true;
            this.TK.VisibleIndex = 4;
            // 
            // BR
            // 
            this.BR.Caption = "Chi Nhánh";
            this.BR.FieldName = "idCHINHANH";
            this.BR.Name = "BR";
            this.BR.Visible = true;
            this.BR.VisibleIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.cboBr});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1125, 534);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcBRticket;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1105, 488);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(676, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(429, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_AddTick;
            this.layoutControlItem3.Location = new System.Drawing.Point(501, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(72, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(573, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(103, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cborequest;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(279, 26);
            this.layoutControlItem5.Text = "ID Phiếu Nhập Hàng Trụ Sở";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(130, 13);
            // 
            // cboBr
            // 
            this.cboBr.Control = this.cbBR;
            this.cboBr.Location = new System.Drawing.Point(279, 0);
            this.cboBr.Name = "cboBr";
            this.cboBr.Size = new System.Drawing.Size(222, 26);
            this.cboBr.Text = "Chi Nhánh";
            this.cboBr.TextSize = new System.Drawing.Size(130, 13);
            // 
            // pHIEUNHAPHANGTRUSOBindingSource
            // 
            this.pHIEUNHAPHANGTRUSOBindingSource.DataSource = typeof(CMART5.PHIEUNHAPHANGTRUSO);
            // 
            // GUI_BRTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 534);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_BRTickets";
            this.Text = "GUI_BRTickets";
            this.Load += new System.EventHandler(this.GUI_HQTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBRticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPHANGCHINHANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBRticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBr)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcBRticket;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBRticket;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn IDBR;
        private DevExpress.XtraGrid.Columns.GridColumn IDHQ;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYNHAP;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource pHIEUNHAPHANGTRUSOBindingSource;
        private System.Windows.Forms.ComboBox cborequest;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource pHIEUNHAPHANGCHINHANHBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn TK;
        private DevExpress.XtraGrid.Columns.GridColumn BR;
        private System.Windows.Forms.ComboBox cbBR;
        private DevExpress.XtraLayout.LayoutControlItem cboBr;
    }
}