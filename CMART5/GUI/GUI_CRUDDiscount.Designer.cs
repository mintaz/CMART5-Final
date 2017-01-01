namespace CMART5
{
    partial class GUI_CRUDDiscount
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
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtpath = new DevExpress.XtraEditors.TextEdit();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.ptDiscount = new System.Windows.Forms.PictureBox();
            this.btnAddHinhKM = new DevExpress.XtraEditors.SimpleButton();
            this.txtND = new DevExpress.XtraEditors.TextEdit();
            this.txtprice = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.btnSave});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu Lại";
            this.btnSave.Id = 0;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1009, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 317);
            this.barDockControlBottom.Size = new System.Drawing.Size(1009, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 295);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1009, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 295);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboSP);
            this.layoutControl1.Controls.Add(this.txtpath);
            this.layoutControl1.Controls.Add(this.dtEnd);
            this.layoutControl1.Controls.Add(this.dtStart);
            this.layoutControl1.Controls.Add(this.ptDiscount);
            this.layoutControl1.Controls.Add(this.btnAddHinhKM);
            this.layoutControl1.Controls.Add(this.txtND);
            this.layoutControl1.Controls.Add(this.txtprice);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(571, 118, 921, 408);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1009, 295);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtpath
            // 
            this.txtpath.Enabled = false;
            this.txtpath.Location = new System.Drawing.Point(115, 85);
            this.txtpath.MenuManager = this.barManager1;
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(387, 20);
            this.txtpath.StyleController = this.layoutControl1;
            this.txtpath.TabIndex = 16;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(609, 37);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(388, 20);
            this.dtEnd.TabIndex = 14;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(609, 12);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(388, 20);
            this.dtStart.TabIndex = 13;
            // 
            // ptDiscount
            // 
            this.ptDiscount.Location = new System.Drawing.Point(609, 61);
            this.ptDiscount.Name = "ptDiscount";
            this.ptDiscount.Size = new System.Drawing.Size(388, 196);
            this.ptDiscount.TabIndex = 12;
            this.ptDiscount.TabStop = false;
            // 
            // btnAddHinhKM
            // 
            this.btnAddHinhKM.Location = new System.Drawing.Point(506, 261);
            this.btnAddHinhKM.Name = "btnAddHinhKM";
            this.btnAddHinhKM.Size = new System.Drawing.Size(491, 22);
            this.btnAddHinhKM.StyleController = this.layoutControl1;
            this.btnAddHinhKM.TabIndex = 11;
            this.btnAddHinhKM.Text = "Thêm Hình Ảnh Khuyến Mãi";
            this.btnAddHinhKM.Click += new System.EventHandler(this.btnAddHinhKM_Click);
            // 
            // txtND
            // 
            this.txtND.Location = new System.Drawing.Point(115, 61);
            this.txtND.MenuManager = this.barManager1;
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(387, 20);
            this.txtND.StyleController = this.layoutControl1;
            this.txtND.TabIndex = 8;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(115, 37);
            this.txtprice.MenuManager = this.barManager1;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(387, 20);
            this.txtprice.StyleController = this.layoutControl1;
            this.txtprice.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.layoutControlItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1009, 295);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtprice;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(494, 24);
            this.layoutControlItem2.Text = "Giá Khuyến Mãi";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtND;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(494, 24);
            this.layoutControlItem5.Text = "Nội Dung";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnAddHinhKM;
            this.layoutControlItem6.Location = new System.Drawing.Point(494, 249);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(495, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.ptDiscount;
            this.layoutControlItem8.Location = new System.Drawing.Point(494, 49);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(495, 200);
            this.layoutControlItem8.Text = "Hình Ảnh";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dtStart;
            this.layoutControlItem7.Location = new System.Drawing.Point(494, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(495, 25);
            this.layoutControlItem7.Text = "Ngày Bắt Đầu";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.dtEnd;
            this.layoutControlItem9.Location = new System.Drawing.Point(494, 25);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(495, 24);
            this.layoutControlItem9.Text = "Ngày Kết Thúc";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtpath;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(494, 202);
            this.layoutControlItem1.Text = "Đường dẫn Hình Ảnh";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(100, 13);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataSource = typeof(CMART5.SANPHAM);
            // 
            // sANPHAMBindingSource1
            // 
            this.sANPHAMBindingSource1.DataSource = typeof(CMART5.SANPHAM);
            // 
            // cboSP
            // 
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Location = new System.Drawing.Point(115, 12);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(387, 21);
            this.cboSP.TabIndex = 17;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboSP;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(494, 25);
            this.layoutControlItem4.Text = "Sản Phẩm";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(100, 13);
            // 
            // GUI_CRUDDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 317);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_CRUDDiscount";
            this.Text = "GUI_CRUDDiscount";
            this.Load += new System.EventHandler(this.GUI_CRUDDiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtpath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SimpleButton btnAddHinhKM;
        private DevExpress.XtraEditors.TextEdit txtprice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit txtND;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.PictureBox ptDiscount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.TextEdit txtpath;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource1;
        private System.Windows.Forms.ComboBox cboSP;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}