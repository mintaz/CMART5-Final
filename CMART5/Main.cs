using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMART5
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }
        public int auth;
        public string idacc;

        //kiem tra form ton tai
        private Form checkexist(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if(f.GetType()== ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (auth == 1)
            {
                //pagecatalog.Visible = true;
                //pageimport.Visible = false;
                //pagereceipt.Visible = false;
                //pagerevenue.Visible = true;
                //pagesystem.Visible = true;
                pagecatalog.Visible = true;
                pageimport.Visible = true;
                pagereceipt.Visible = true;
                pagerevenue.Visible = true;
                pagesystem.Visible = true;
            }else if(auth == 2)
            {
                pagecatalog.Visible = false;
                pageimport.Visible = true;
                btn_BRimport.Enabled = true;
                btn_HQimport.Enabled = false;
                btn_Request.Enabled = false;
                pagereceipt.Visible = false;
                pagerevenue.Visible = false;
                pagesystem.Visible = true;
                btn_account_management.Enabled = false;
            }else if( auth ==3)
            {
                pagecatalog.Visible = false;
                pageimport.Visible = true;
                btn_BRimport.Enabled = false;
                btn_HQimport.Enabled = true;
                btn_Request.Enabled = false;
                pagereceipt.Visible = false;
                pagerevenue.Visible = false;
                pagesystem.Visible = true;
                btn_account_management.Enabled = false;
            }else if(auth ==4)
            {
                pagecatalog.Visible = false;
                pageimport.Visible = false;
                pagereceipt.Visible = true;
                pagerevenue.Visible = false;
                pagesystem.Visible = true;
                btn_account_management.Enabled = false;
            }else if (auth ==5)
            {
                pagecatalog.Visible = false;
                pageimport.Visible = true;
                btn_BRimport.Enabled = false;
                btn_HQimport.Enabled = false;
                btn_Request.Enabled = true;
                pagereceipt.Visible = false;
                pagerevenue.Visible = false;
                pagesystem.Visible = true;
                btn_account_management.Enabled = false;
            }
            
        }

        private void btn_account_management_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkexist(typeof(GUI_Account));
            if (frm!= null)
            {
                frm.Activate();
            }
            else
            {
                GUI_Account fm = new GUI_Account();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void btn_supplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkexist(typeof(GUI_Supplier));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                GUI_Supplier fsm = new GUI_Supplier();
                fsm.MdiParent = this;
                fsm.Show();
            }
        }

        private void btn_product_type_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkexist(typeof(GUI_ProductType));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                GUI_ProductType fpm = new GUI_ProductType();
                fpm.MdiParent = this;
                fpm.Show();
            }

        }

        private void btn_product_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkexist(typeof(GUI_Product));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                GUI_Product fdm = new GUI_Product();
                fdm.MdiParent = this;
                fdm.Show();
            }
        }

        private void btn_historyprice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkexist(typeof(GUI.GUI_HistoryP));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                GUI.GUI_HistoryP fhp = new GUI.GUI_HistoryP();
                fhp.MdiParent = this;
                fhp.Show();
            }

        }

        private void btn_discount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkexist(typeof(GUI_Discount));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                GUI_Discount fhm = new GUI_Discount();
                fhm.MdiParent = this;
                fhm.Show();
            }
        }

        private void btn_HQimport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkexist(typeof(GUI_HQTicket));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                GUI_HQTicket fhqt = new GUI_HQTicket();
                fhqt.idaccount = idacc;
                fhqt.MdiParent = this;
                fhqt.Show();
            }
        }

        private void btn_logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_change_password_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkexist(typeof(GUI_ChangePass));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                GUI_ChangePass fchange = new GUI_ChangePass();
                fchange.MdiParent = this;
                fchange.id = idacc;
                fchange.Show();
            }
        }

        private void btn_Request_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkexist(typeof(GUI.GUI_RequestTicket));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                GUI.GUI_RequestTicket frequest = new GUI.GUI_RequestTicket();
                frequest.MdiParent = this;
                frequest.idacc = idacc;
                frequest.Show();
            }

        }

        private void btn_BRimport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkexist(typeof(GUI_BRTickets));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                GUI_BRTickets fhbr = new GUI_BRTickets();
                fhbr.idaccount = idacc;
                fhbr.MdiParent = this;
                fhbr.Show();
            }

        }
    }
}
