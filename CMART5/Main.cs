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
            Form frm = this.checkexist(typeof(GUI_HistoryPrice));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                GUI_HistoryPrice fhm = new GUI_HistoryPrice();
                fhm.MdiParent = this;
                fhm.Show();
            }

        }
    }
}
