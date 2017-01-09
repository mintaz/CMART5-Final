namespace CMART5
{
    partial class GUI_CRUDAccount
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
            this.txtpass = new DevExpress.XtraEditors.TextEdit();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.txtaddress = new DevExpress.XtraEditors.TextEdit();
            this.txtphone = new DevExpress.XtraEditors.TextEdit();
            this.txtcmnd = new DevExpress.XtraEditors.TextEdit();
            this.txtuser = new DevExpress.XtraEditors.TextEdit();
            this.cboquyen = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcmnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(449, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 227);
            this.barDockControlBottom.Size = new System.Drawing.Size(449, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 205);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(449, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 205);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtpass);
            this.layoutControl1.Controls.Add(this.txtname);
            this.layoutControl1.Controls.Add(this.txtaddress);
            this.layoutControl1.Controls.Add(this.txtphone);
            this.layoutControl1.Controls.Add(this.txtcmnd);
            this.layoutControl1.Controls.Add(this.txtuser);
            this.layoutControl1.Controls.Add(this.cboquyen);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(449, 205);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtpass
            // 
            this.txtpass.EditValue = "";
            this.txtpass.Location = new System.Drawing.Point(81, 132);
            this.txtpass.MenuManager = this.barManager1;
            this.txtpass.Name = "txtpass";
            this.txtpass.Properties.NullText = "cmart";
            this.txtpass.Properties.NullValuePrompt = "cmart";
            this.txtpass.Size = new System.Drawing.Size(356, 20);
            this.txtpass.StyleController = this.layoutControl1;
            this.txtpass.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(81, 12);
            this.txtname.MenuManager = this.barManager1;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(356, 20);
            this.txtname.StyleController = this.layoutControl1;
            this.txtname.TabIndex = 9;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(81, 36);
            this.txtaddress.MenuManager = this.barManager1;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(356, 20);
            this.txtaddress.StyleController = this.layoutControl1;
            this.txtaddress.TabIndex = 8;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(81, 60);
            this.txtphone.MenuManager = this.barManager1;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(356, 20);
            this.txtphone.StyleController = this.layoutControl1;
            this.txtphone.TabIndex = 7;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(81, 84);
            this.txtcmnd.MenuManager = this.barManager1;
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(356, 20);
            this.txtcmnd.StyleController = this.layoutControl1;
            this.txtcmnd.TabIndex = 6;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(81, 108);
            this.txtuser.MenuManager = this.barManager1;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(356, 20);
            this.txtuser.StyleController = this.layoutControl1;
            this.txtuser.TabIndex = 5;
            // 
            // cboquyen
            // 
            this.cboquyen.FormattingEnabled = true;
            this.cboquyen.Location = new System.Drawing.Point(81, 156);
            this.cboquyen.Name = "cboquyen";
            this.cboquyen.Size = new System.Drawing.Size(356, 21);
            this.cboquyen.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(449, 205);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboquyen;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(429, 41);
            this.layoutControlItem1.Text = "Quyền";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtuser;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(429, 24);
            this.layoutControlItem2.Text = "UserName";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtcmnd;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(429, 24);
            this.layoutControlItem3.Text = "CMND";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtphone;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(429, 24);
            this.layoutControlItem4.Text = "Số Điện Thoại";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtaddress;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(429, 24);
            this.layoutControlItem5.Text = "Địa chỉ";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtname;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(429, 24);
            this.layoutControlItem6.Text = "Họ Tên";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtpass;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(429, 24);
            this.layoutControlItem7.Text = "Password";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(66, 13);
            // 
            // GUI_CRUDAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 227);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GUI_CRUDAccount";
            this.Text = "GUI_CRUDAccount";
            this.Load += new System.EventHandler(this.GUI_CRUDAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcmnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtpass;
        private DevExpress.XtraEditors.TextEdit txtname;
        private DevExpress.XtraEditors.TextEdit txtaddress;
        private DevExpress.XtraEditors.TextEdit txtphone;
        private DevExpress.XtraEditors.TextEdit txtcmnd;
        private DevExpress.XtraEditors.TextEdit txtuser;
        private System.Windows.Forms.ComboBox cboquyen;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraBars.BarButtonItem btnSave;

    }
}