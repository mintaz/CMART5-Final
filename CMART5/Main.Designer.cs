namespace CMART5
{
    partial class Main
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
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_supplier = new DevExpress.XtraBars.BarButtonItem();
            this.btn_product_type = new DevExpress.XtraBars.BarButtonItem();
            this.btn_product = new DevExpress.XtraBars.BarButtonItem();
            this.btn_historyprice = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_discount = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_account_management = new DevExpress.XtraBars.BarButtonItem();
            this.btn_change_password = new DevExpress.XtraBars.BarButtonItem();
            this.btn_logout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Request = new DevExpress.XtraBars.BarButtonItem();
            this.btn_HQimport = new DevExpress.XtraBars.BarButtonItem();
            this.btn_BRimport = new DevExpress.XtraBars.BarButtonItem();
            this.btn_receipt = new DevExpress.XtraBars.BarButtonItem();
            this.btn_revenue = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh Mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_supplier);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_product_type);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_product);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_historyprice);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Hàng Hóa";
            // 
            // btn_supplier
            // 
            this.btn_supplier.Caption = "Nhà Cung Cấp";
            this.btn_supplier.Id = 5;
            this.btn_supplier.LargeGlyph = global::CMART5.Properties.Resources.truck_icon;
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_supplier_ItemClick);
            // 
            // btn_product_type
            // 
            this.btn_product_type.Caption = "Loại Sản Phẩm";
            this.btn_product_type.Id = 6;
            this.btn_product_type.LargeGlyph = global::CMART5.Properties.Resources.Catalog_icon;
            this.btn_product_type.LargeWidth = 70;
            this.btn_product_type.Name = "btn_product_type";
            this.btn_product_type.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_product_type_ItemClick);
            // 
            // btn_product
            // 
            this.btn_product.Caption = "Sản Phẩm";
            this.btn_product.Id = 7;
            this.btn_product.LargeGlyph = global::CMART5.Properties.Resources.product_icon;
            this.btn_product.LargeWidth = 70;
            this.btn_product.Name = "btn_product";
            this.btn_product.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_product_ItemClick);
            // 
            // btn_historyprice
            // 
            this.btn_historyprice.Caption = "Lịch Sử Giá";
            this.btn_historyprice.Id = 8;
            this.btn_historyprice.LargeGlyph = global::CMART5.Properties.Resources.File_History_icon;
            this.btn_historyprice.LargeWidth = 70;
            this.btn_historyprice.Name = "btn_historyprice";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_discount);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Khuyến Mãi";
            // 
            // btn_discount
            // 
            this.btn_discount.Caption = "Thông tin Khuyến Mãi";
            this.btn_discount.Id = 9;
            this.btn_discount.LargeGlyph = global::CMART5.Properties.Resources.megaphone_2_icon;
            this.btn_discount.LargeWidth = 70;
            this.btn_discount.Name = "btn_discount";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_account_management);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_change_password);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_logout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài Khoản";
            // 
            // btn_account_management
            // 
            this.btn_account_management.Caption = "Quản Lý Tài Khoản";
            this.btn_account_management.Id = 1;
            this.btn_account_management.LargeGlyph = global::CMART5.Properties.Resources.user_info_icon;
            this.btn_account_management.LargeWidth = 70;
            this.btn_account_management.Name = "btn_account_management";
            this.btn_account_management.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_account_management_ItemClick);
            // 
            // btn_change_password
            // 
            this.btn_change_password.Caption = "Change Password";
            this.btn_change_password.Id = 3;
            this.btn_change_password.LargeGlyph = global::CMART5.Properties.Resources.Apps_preferences_desktop_user_password_icon;
            this.btn_change_password.LargeWidth = 70;
            this.btn_change_password.Name = "btn_change_password";
            // 
            // btn_logout
            // 
            this.btn_logout.Caption = "Logout";
            this.btn_logout.Id = 4;
            this.btn_logout.LargeGlyph = global::CMART5.Properties.Resources.Apps_session_logout_icon;
            this.btn_logout.LargeWidth = 70;
            this.btn_logout.Name = "btn_logout";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_account_management,
            this.btn_change_password,
            this.btn_logout,
            this.btn_supplier,
            this.btn_product_type,
            this.btn_product,
            this.btn_historyprice,
            this.btn_discount,
            this.btn_Request,
            this.btn_HQimport,
            this.btn_BRimport,
            this.btn_receipt,
            this.btn_revenue});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(758, 130);
            // 
            // btn_Request
            // 
            this.btn_Request.Caption = "Phiếu đề xuất";
            this.btn_Request.Id = 10;
            this.btn_Request.LargeGlyph = global::CMART5.Properties.Resources.Order_history_icon;
            this.btn_Request.LargeWidth = 70;
            this.btn_Request.Name = "btn_Request";
            // 
            // btn_HQimport
            // 
            this.btn_HQimport.Caption = "Phiếu nhập hàng HQ";
            this.btn_HQimport.Id = 11;
            this.btn_HQimport.LargeGlyph = global::CMART5.Properties.Resources.import_icon;
            this.btn_HQimport.LargeWidth = 70;
            this.btn_HQimport.Name = "btn_HQimport";
            // 
            // btn_BRimport
            // 
            this.btn_BRimport.Caption = "Phiếu nhập hàng BR";
            this.btn_BRimport.Id = 12;
            this.btn_BRimport.LargeGlyph = global::CMART5.Properties.Resources.import_icon1;
            this.btn_BRimport.LargeWidth = 70;
            this.btn_BRimport.Name = "btn_BRimport";
            // 
            // btn_receipt
            // 
            this.btn_receipt.Caption = "Lập Hóa đơn";
            this.btn_receipt.Id = 13;
            this.btn_receipt.LargeGlyph = global::CMART5.Properties.Resources.folder_invoices_icon;
            this.btn_receipt.LargeWidth = 70;
            this.btn_receipt.Name = "btn_receipt";
            // 
            // btn_revenue
            // 
            this.btn_revenue.Caption = "Doanh Thu";
            this.btn_revenue.Id = 14;
            this.btn_revenue.LargeGlyph = global::CMART5.Properties.Resources.Sales_report_icon;
            this.btn_revenue.LargeWidth = 70;
            this.btn_revenue.Name = "btn_revenue";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Nhập Hàng";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_HQimport);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_Request);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Trụ sở";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_BRimport);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Chi Nhánh";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Hóa Đơn";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_receipt);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Quản lý Hóa đơn";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Báo Cáo Thống Kê";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_revenue);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Thống kê";
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
            this.Text = "CMART";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_supplier;
        private DevExpress.XtraBars.BarButtonItem btn_product_type;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_account_management;
        private DevExpress.XtraBars.BarButtonItem btn_change_password;
        private DevExpress.XtraBars.BarButtonItem btn_logout;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_product;
        private DevExpress.XtraBars.BarButtonItem btn_historyprice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_discount;
        private DevExpress.XtraBars.BarButtonItem btn_Request;
        private DevExpress.XtraBars.BarButtonItem btn_HQimport;
        private DevExpress.XtraBars.BarButtonItem btn_BRimport;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_receipt;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btn_revenue;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;

    }
}

